using System;
using System.Collections.Concurrent;
using System.IO;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LILO_WebEngine.Core.Local.Types;
using System.Text.Json;
using System.Linq;

namespace LILO_WebEngine.Core.WebSockets
{
    public class WebSocketServer
    {
        private static readonly Lazy<WebSocketServer> _instance = new(() => new WebSocketServer());
        public static WebSocketServer Instance => _instance.Value;

        private readonly ConcurrentDictionary<string, WebSocketConnection> _connections = new();
        private readonly CancellationTokenSource _cts = new();

        private WebSocketServer() { }

        public async Task HandleWebSocketRequest(HttpListenerContext context)
        {
            if (!context.Request.IsWebSocketRequest)
            {
                context.Response.StatusCode = 400;
                context.Response.Close();
                return;
            }

            try
            {
                var webSocketContext = await context.AcceptWebSocketAsync(null);
                var webSocket = webSocketContext.WebSocket;
                var connectionId = Guid.NewGuid().ToString();
                var connection = new WebSocketConnection(connectionId, webSocket);
                
                _connections.TryAdd(connectionId, connection);
                
                // Start listening for messages from this client
                _ = HandleConnectionAsync(connection);
                
                // Send initial connection message
                await connection.SendMessageAsync(new WebSocketMessage 
                { 
                    Type = "connection", 
                    Data = new { id = connectionId, status = "connected" } 
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"WebSocket error: {ex.Message}");
                context.Response.StatusCode = 500;
                context.Response.Close();
            }
        }

        private async Task HandleConnectionAsync(WebSocketConnection connection)
        {
            try
            {
                while (connection.WebSocket.State == WebSocketState.Open && !_cts.Token.IsCancellationRequested)
                {
                    var buffer = new byte[4096];
                    var result = await connection.WebSocket.ReceiveAsync(
                        new ArraySegment<byte>(buffer), _cts.Token);

                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        await connection.WebSocket.CloseAsync(
                            WebSocketCloseStatus.NormalClosure,
                            "Connection closed by client",
                            CancellationToken.None);
                        
                        _connections.TryRemove(connection.Id, out _);
                        break;
                    }

                    if (result.MessageType == WebSocketMessageType.Text)
                    {
                        var message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                        await HandleClientMessageAsync(connection, message);
                    }
                }
            }
            catch (Exception)
            {
                // Clean up on error
                if (_connections.TryRemove(connection.Id, out _))
                {
                    try
                    {
                        if (connection.WebSocket.State == WebSocketState.Open)
                        {
                            await connection.WebSocket.CloseAsync(
                                WebSocketCloseStatus.InternalServerError,
                                "Connection error",
                                CancellationToken.None);
                        }
                    }
                    catch { /* Ignore errors during cleanup */ }
                }
            }
        }

        private async Task HandleClientMessageAsync(WebSocketConnection connection, string messageJson)
        {
            try
            {
                var message = JsonSerializer.Deserialize<WebSocketMessage>(messageJson);
                
                switch (message?.Type)
                {
                    case "ping":
                        await connection.SendMessageAsync(new WebSocketMessage { Type = "pong" });
                        break;
                    
                    // Add more message handlers as needed
                    
                    default:
                        // Unknown message type
                        break;
                }
            }
            catch (Exception ex)
            {
                await connection.SendMessageAsync(new WebSocketMessage 
                { 
                    Type = "error", 
                    Data = new { message = "Failed to process message", error = ex.Message } 
                });
            }
        }

        public async Task BroadcastFileChangeAsync(string filePath)
        {
            var message = new WebSocketMessage
            {
                Type = "fileChange",
                Data = new
                {
                    path = filePath,
                    timestamp = DateTime.Now
                }
            };

            await BroadcastMessageAsync(message);
        }

        public async Task BroadcastMessageAsync(WebSocketMessage message)
        {
            var tasks = new List<Task>();
            
            foreach (var connection in _connections.Values)
            {
                if (connection.WebSocket.State == WebSocketState.Open)
                {
                    tasks.Add(connection.SendMessageAsync(message));
                }
            }
            
            await Task.WhenAll(tasks);
        }

        public object GetConnectionsInfo()
        {
            var connectionInfo = _connections.Values
                .Where(c => c.WebSocket.State == WebSocketState.Open)
                .Select(c => new
                {
                    id = c.Id,
                    connectedAt = c.ConnectedAt,
                    state = c.WebSocket.State.ToString()
                })
                .ToList();

            return new
            {
                totalConnections = connectionInfo.Count,
                connections = connectionInfo
            };
        }

        public void Dispose()
        {
            _cts.Cancel();
            
            // Close all connections
            foreach (var connection in _connections.Values)
            {
                try
                {
                    if (connection.WebSocket.State == WebSocketState.Open)
                    {
                        connection.WebSocket.CloseAsync(
                            WebSocketCloseStatus.NormalClosure,
                            "Server shutting down",
                            CancellationToken.None).Wait(1000);
                    }
                }
                catch { /* Ignore errors during cleanup */ }
            }
            
            _connections.Clear();
            _cts.Dispose();
        }
    }
} 