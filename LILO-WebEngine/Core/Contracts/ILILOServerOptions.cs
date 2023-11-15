using System.Net;
using LILO_WebEngine.Service;
using LILO_WebEngine.Shared;

namespace LILO_WebEngine.Core.Contracts
{
    public interface ILILOServerOptions
    {
        public string SourceDirectory { get; set; }
        public string LogDirectory { get; set; }
        public string ApiKey { get; set; }
        public Port Port { get; set; }
        public List<ServerFilter> FileActionFilter { get; set; }

        public Func<HttpListenerContext, Task> RequestHandler { get; set; }
        public string? ServerName { get; set; }
        public string? CompanyName { get; set; }
        public string? ServerUrl { get; set; }
    }
}
