using System.Net;
using System.Security.Cryptography.X509Certificates;
using LILO_WebEngine.Shared;
using LILO_WebEngine.Core.Contracts;
using LILO_WebEngine.Core.Security;

namespace LILO_WebEngine.Service
{
    public class LocalServerOptions : ILILOServerOptions
    {
        // Basic settings
        public required string SourceDirectory { get; set; }
        public required string LogDirectory { get; set; }
        public required string ApiKey { get; set; }
        public required Port Port { get; set; }

        // Request handling
        public List<ServerFilter>? Filters { get; set; }
        public Func<HttpListenerContext, Task>? RequestHandler { get; set; }

        // Server identity
        public string? ServerName { get; set; } = "LocalServer";
        public string? CompanyName { get; set; } = null;
        public string? ServerUrl { get; set; } = null;
        
        // Public access settings
        public ServerMode ServerMode { get; set; } = ServerMode.Local;
        public bool UseHttps { get; set; } = false;
        public X509Certificate2? Certificate { get; set; } = null;
        public int? PublicPort { get; set; } = null;
        
        // Security settings
        public bool UseAuthentication { get; set; } = false;
        public IAuthenticationProvider? AuthenticationProvider { get; set; } = null;
        
        // Compatibility property
        public List<ServerFilter> FileActionFilter { get => Filters ?? new List<ServerFilter>(); set => Filters = value; }
    }
}
