using LILO_WebEngine.Core.Contracts;
using LILO_WebEngine.Core.Security;
using LILO_WebEngine.Shared;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace LILO_WebEngine.Service
{
    public class LocalMediaServerOptions : ILILOServerOptions
    {
        public LocalMediaServerOptions() { }

        public LocalMediaServerOptions(ILILOServerOptions options)
        {
            MediaFolder = options.SourceDirectory;
            ListeningPort = options.Port;
            RequestHandler = options.RequestHandler;
            ServerName = options.ServerName;
            CompanyName = options.CompanyName;
        }

        public required string MediaFolder { get; set; }
        public required Port ListeningPort { get; set; }
        public Func<HttpListenerContext, Task> RequestHandler { get; set; }
        public string? ServerName { get; set; } = "MediaServer";
        public string? CompanyName { get; set; } = null;
        public string SourceDirectory { get => MediaFolder; set => MediaFolder = value; }
        public Port Port { get => ListeningPort; set => ListeningPort = value; }
        public string LogDirectory { get => ".\\logs"; set => LogDirectory = value; }


        public string ApiKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? ServerUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<ServerFilter> FileActionFilter { get => FileActionFilter; set => FileActionFilter = value; }
        public ServerMode ServerMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool UseHttps { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public X509Certificate2? Certificate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? PublicPort { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool UseAuthentication { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IAuthenticationProvider? AuthenticationProvider { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
