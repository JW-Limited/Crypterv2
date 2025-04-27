using System;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace LILO_WebEngine.Core.WebSockets
{
    public class WebSocketConnection
    {
        public string Id { get; }
        public WebSocket WebSocket { get; }
        public DateTime ConnectedAt { get; }

        public WebSocketConnection(string id, WebSocket webSocket)
        {
            Id = id;
            WebSocket = webSocket;
            ConnectedAt = DateTime.Now;
        }

        public async Task SendMessageAsync(WebSocketMessage message, CancellationToken cancellationToken = default)
        {
            if (WebSocket.State != WebSocketState.Open)
                return;

            var json = JsonSerializer.Serialize(message);
            var buffer = Encoding.UTF8.GetBytes(json);
            var segment = new ArraySegment<byte>(buffer);

            await WebSocket.SendAsync(
                segment, 
                WebSocketMessageType.Text, 
                true, 
                cancellationToken);
        }

        public async Task SendTextAsync(string text, CancellationToken cancellationToken = default)
        {
            if (WebSocket.State != WebSocketState.Open)
                return;

            var buffer = Encoding.UTF8.GetBytes(text);
            var segment = new ArraySegment<byte>(buffer);

            await WebSocket.SendAsync(
                segment, 
                WebSocketMessageType.Text, 
                true, 
                cancellationToken);
        }
    }
} 