using System;
using System.Net;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;
using LILO_WebEngine.Core.Local;
using LILO_WebEngine.Core.Local.Types;
using LILO_WebEngine.Core.Handler;

namespace LILO_WebEngine.Core.WebSockets
{
    public class WebSocketCommandHandler
    {
        private readonly WebSocketServer _webSocketServer;

        public WebSocketCommandHandler()
        {
            _webSocketServer = WebSocketServer.Instance;
        }

        public async Task HandleTriggerReload(HttpListenerRequest request, HttpListenerResponse response)
        {
            try
            {
                var message = new WebSocketMessage
                {
                    Type = "reload",
                    Data = new { timestamp = DateTime.Now }
                };

                await _webSocketServer.BroadcastMessageAsync(message);

                var result = new
                {
                    success = true,
                    message = "Reload triggered for all connected clients"
                };

                response.StatusCode = 200;
                response.ContentType = "application/json";
                var jsonResponse = JsonSerializer.Serialize(result);
                var buffer = Encoding.UTF8.GetBytes(jsonResponse);
                await response.OutputStream.WriteAsync(buffer, 0, buffer.Length);
            }
            catch (Exception ex)
            {
                var errorResult = new
                {
                    success = false,
                    message = $"Failed to trigger reload: {ex.Message}"
                };

                response.StatusCode = 500;
                response.ContentType = "application/json";
                var jsonResponse = JsonSerializer.Serialize(errorResult);
                var buffer = Encoding.UTF8.GetBytes(jsonResponse);
                await response.OutputStream.WriteAsync(buffer, 0, buffer.Length);

                // Log error
                EngineEventHandler.Instance.AddEvent(new WEB_ENGINE_EVENT
                {
                    Name = "Trigger Reload Error",
                    Description = $"Error: {ex.Message}",
                    NeedsToAccept = false,
                    HappeningTime = DateTime.Now
                });
            }
        }

        public async Task HandleGetConnections(HttpListenerRequest request, HttpListenerResponse response)
        {
            try
            {
                var connections = _webSocketServer.GetConnectionsInfo();

                response.StatusCode = 200;
                response.ContentType = "application/json";
                var jsonResponse = JsonSerializer.Serialize(connections);
                var buffer = Encoding.UTF8.GetBytes(jsonResponse);
                await response.OutputStream.WriteAsync(buffer, 0, buffer.Length);
            }
            catch (Exception ex)
            {
                var errorResult = new
                {
                    success = false,
                    message = $"Failed to get connections: {ex.Message}"
                };

                response.StatusCode = 500;
                response.ContentType = "application/json";
                var jsonResponse = JsonSerializer.Serialize(errorResult);
                var buffer = Encoding.UTF8.GetBytes(jsonResponse);
                await response.OutputStream.WriteAsync(buffer, 0, buffer.Length);

                // Log error
                EngineEventHandler.Instance.AddEvent(new WEB_ENGINE_EVENT
                {
                    Name = "Get Connections Error",
                    Description = $"Error: {ex.Message}",
                    NeedsToAccept = false,
                    HappeningTime = DateTime.Now
                });
            }
        }
    }
} 