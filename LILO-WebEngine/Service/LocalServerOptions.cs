using System.Net;
using LILO_WebEngine.Shared;
using LILO_WebEngine.Core.Contracts;

namespace LILO_WebEngine.Service
{
    public class LocalServerOptions : ILILOServerOptions
    {
        public required string SourceDirectory { get; set; }
        public required string LogDirectory { get; set; }
        public required string ApiKey { get; set; }
        public required Port Port { get; set; }

        public List<ServerFilter>? Filters { get; set; }
        public Func<HttpListenerContext, Task>? RequestHandler { get; set; }

        public string? ServerName { get; set; } = "LocalServer";
        public string? CompanyName { get; set; } = null;
        public string? ServerUrl { get; set; } = null;
        public List<ServerFilter> FileActionFilter { get => Filters; set => Filters = value; }
    }
}
