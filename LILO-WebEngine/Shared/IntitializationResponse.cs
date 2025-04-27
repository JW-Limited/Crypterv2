using LILO_WebEngine.Service;

namespace LILO_WebEngine.Shared
{
    public class InitializationResponse
    {
        /// <summary>
        /// Whether initialization was successful
        /// </summary>
        public bool SuccessFull { get; set; } = false;
        
        /// <summary>
        /// The listening port
        /// </summary>
        public int Port { get; set; } = 0;
        
        /// <summary>
        /// Error message if initialization failed
        /// </summary>
        public string ErrorMessage { get; set; } = string.Empty;
        
        /// <summary>
        /// Exception that occurred during initialization
        /// </summary>
        public Exception Exception { get; set; } = null;
        
        /// <summary>
        /// If the server is using HTTPS
        /// </summary>
        public bool IsSecure { get; set; } = false;
        
        /// <summary>
        /// The operating mode of the server
        /// </summary>
        public ServerMode ServerMode { get; set; } = ServerMode.Local;
        
        /// <summary>
        /// Original exception that led to fallback
        /// </summary>
        public Exception OriginalException { get; set; } = null;
        
        /// <summary>
        /// Indicates if fallback settings were used
        /// </summary>
        public bool FallbackActivated { get; set; } = false;
    }
}
