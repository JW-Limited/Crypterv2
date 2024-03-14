using LILO_WebEngine.Shared;

namespace JWLimited.TestHost.Core.WebServer
{
    public class RecentWebProject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ID { get; set; }

        public string? ServerName { get; set; } = "LocalServer";
        public string? CompanyName { get; set; } = null;
        public string? ServerUrl { get; set; } = null;

        public string SourceDirectory { get; set; }
        public string LogDirectory { get; set; }
        public string ApiKey { get; set; }
        public Port Port { get; set; }
    }
}
