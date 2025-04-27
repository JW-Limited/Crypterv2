using LILO_WebEngine.Shared;

namespace JWLimited.TestHost.Core.WebServer
{
    internal partial class ConsoleMenu
    {

        public class RequestResponse
        {
            public Port Port { get; set; } = new Port();
            public string SourceDirectory { get; set; }
            public string LogDirectory { get; set; }
        }
    }
}
