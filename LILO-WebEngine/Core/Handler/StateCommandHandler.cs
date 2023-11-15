using LILO_WebEngine.Core.Contracts;
using LILO_WebEngine.Core.Local.Types;
using LILO_WebEngine.Service;
using System.ComponentModel;
using System.Net;
using System.Security.Cryptography;
using System.Text.Json;
using System.Xml.Serialization;

namespace LILO_WebEngine.Core.Handler
{
    public class StateCommandHandler : ICommandHandler
    {
        public StateCommandHandler()
        {
        }

        public async Task Handle(HttpListenerRequest request, HttpListenerResponse response, HttpListenerContext context = null)
        {
            var stateClass = new WEB_ENGINE_STATE()
            {
                PublicName = LocalServer.Instance.Name,
                PublicApiKey = LocalServer.Instance.Options.ApiKey,
                PublicLogDirectory = LocalServer.Instance.Options.LogDirectory,
                PublicSecret = LocalServer.Instance.Options.ApiKey.GetHashCode().ToString(),
                AvaillabelPorts = LocalServer.Instance.Options.Port,
                RequestHandler = LocalServer.Instance.Options.RequestHandler.Target.ToString(),
                PublicLoopbackPort = LocalServer.Instance.ListenPort,
                PublicServedDirectory = LocalServer.Instance.SourceDirectory,
                LibraryVersion = new LocalServerEventArgs().SemanticVersion,
                HealthCheckResponse = "WebEngine is running without problems: " + LocalServer.Instance.IsRunning.ToString(),
                HealthCheckStatus = "Finished",
                PublicEvents = EngineEventHandler.Instance.WebEngineEvents

            };

            var responseXML = XMLHandler.SerializeToXmlbA(stateClass);

            var responseText = JsonSerializer.SerializeToUtf8Bytes(stateClass, typeof(WEB_ENGINE_STATE), new JsonSerializerOptions(JsonSerializerDefaults.Web)
            {
                WriteIndented = true,
            });

            response.ContentLength64 = responseXML.Length;
            response.OutputStream.Write(responseXML, 0, responseXML.Length);
            response.Close();
        }

    }
}
