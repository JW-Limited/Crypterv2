namespace LILO_WebEngine.Shared
{
    public class Port
    {
        /// <summary>
        /// Default port for local server
        /// </summary>
        public int Default { get; set; } = 8080;
        
        /// <summary>
        /// Fallback port if Default is unavailable
        /// </summary>
        public int FallBack { get; set; } = 9002;
        
        /// <summary>
        /// Public-facing port for Hybrid mode
        /// </summary>
        public int Public { get; set; } = 80;
        
        /// <summary>
        /// HTTPS port for secure connections (default 443)
        /// </summary>
        public int Https { get; set; } = 443;
    }
}
