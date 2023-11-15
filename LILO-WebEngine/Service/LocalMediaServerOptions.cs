using LILO_WebEngine.Core.Contracts;
using LILO_WebEngine.Shared;
using System.Net;

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
    }
}
