using System.Text.Json.Serialization;

namespace LILO_WebEngine.Core.WebSockets
{
    public class WebSocketMessage
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("data")]
        public object Data { get; set; }
    }
}