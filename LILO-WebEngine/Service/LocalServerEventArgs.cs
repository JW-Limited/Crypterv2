using System.Net;

namespace LILO_WebEngine.Service
{
    public class LocalServerEventArgs : EventArgs
    {
        public HttpListenerContext ListenerContext { get; set; }
        public bool IsRunning { get; set; } = true;
        public string Message { get; set; } = string.Empty;
        public DateTime DateTime { get; set; } = DateTime.Now;
        public string SemanticVersion { get; set; } = "1.5.11";
    }
}
