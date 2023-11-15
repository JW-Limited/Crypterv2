using LILO_WebEngine.Core.Contracts;
using LILO_WebEngine.Exceptions;
using LILO_WebEngine.Service;
using System.Net;
using System.Text.Json;

namespace LILO_WebEngine.Core.Handler
{
    public class CloseCommandHandler : ICommandHandler, ILILOWebEngineHandle
    {
        private readonly ILILOWebService _service;

        public CloseCommandHandler(ILILOWebService service)
        {
            _service = service;
        }

        public string InstanceName => "Closing CommandHandle";

        public object InstanceContainer => this;

        public async Task Handle(HttpListenerRequest request, HttpListenerResponse response, HttpListenerContext context = null)
        {
            EngineEventHandler.Instance.AddEvent("", this);

            if (request.RawUrl.EndsWith("?=webengine"))
            {
                await LocalServer.Instance.ToHostConsole("Disposing WebEngine.", context);

                var responseText = JsonSerializer.SerializeToUtf8Bytes("Now Disposing the LILO-WebEngine. (TIP: We Dispose the hole thread so start the host in another.) ", typeof(string), new JsonSerializerOptions(JsonSerializerDefaults.Web)
                {
                    WriteIndented = true,
                });

                response.ContentLength64 = responseText.Length;
                response.OutputStream.Write(responseText, 0, responseText.Length);

                response.Close();
                _service.Dispose();
            }
            else
            {

                throw new InvalidQueryException("instance", new List<string> { "\"webengine\" - Disposes the WebEngine and its thread.", "host", "api" });
            }
        }
    }
}
