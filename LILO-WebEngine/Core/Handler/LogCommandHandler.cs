using LILO_WebEngine.Core.Contracts;
using System.Net;

namespace LILO_WebEngine.Core.Handler
{
    public class LogCommandHandler : ICommandHandler
    {
        public async Task Handle(HttpListenerRequest request, HttpListenerResponse response, HttpListenerContext context = null)
        {
            var responseXML = XMLHandler.SerializeToXmlbA(EngineLogHandler.Instance.LogEntries);

            response.ContentLength64 = responseXML.Length;
            response.OutputStream.Write(responseXML, 0, responseXML.Length);
            response.Close();
        }
    }
}
