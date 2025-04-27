using System.Net;
using System.Security.Cryptography.X509Certificates;
using LILO_WebEngine.Service;
using LILO_WebEngine.Shared;
using LILO_WebEngine.Core.Security;

namespace LILO_WebEngine.Core.Contracts
{
    public interface ILILOServerOptions
    {
        // Basic configuration
        public string SourceDirectory { get; set; }
        public string LogDirectory { get; set; }
        public string ApiKey { get; set; }
        public Port Port { get; set; }
        public List<ServerFilter> FileActionFilter { get; set; }
        
        // Request handling
        public Func<HttpListenerContext, Task> RequestHandler { get; set; }
        
        // Server identity
        public string? ServerName { get; set; }
        public string? CompanyName { get; set; }
        public string? ServerUrl { get; set; }
        
        // Public access settings
        public ServerMode ServerMode { get; set; }
        public bool UseHttps { get; set; }
        public X509Certificate2? Certificate { get; set; }
        public int? PublicPort { get; set; }
        
        // Security settings
        public bool UseAuthentication { get; set; }
        public IAuthenticationProvider? AuthenticationProvider { get; set; }
    }
}
