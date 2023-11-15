using LILO_WebEngine.Core.Contracts;
using LILO_WebEngine.Exceptions;
using System.Net;
using System.Text.Json;

namespace LILO_WebEngine.Core.Handler
{
    public class GetCommandListCommandHandler : ICommandHandler
    {
        public async Task Handle(HttpListenerRequest request, HttpListenerResponse response, HttpListenerContext context = null)
        {
            if (request is null || response is null)
            {
                throw new HttpContextNullException(request, response);
            }

            var commandList = GetCommandNames();

            var responseText = JsonSerializer.SerializeToUtf8Bytes(commandList.ToList(), typeof(List<string>), new JsonSerializerOptions(JsonSerializerDefaults.Web)
            {
                WriteIndented = true,
            });

            response.ContentLength64 = responseText.Length;
            response.OutputStream.Write(responseText, 0, responseText.Length);
        }

        private IEnumerable<string> GetCommandNames()
        {
            return new[] { "close", "state", "GetCommandList", "OpenFile", "Custom" };
        }
    }

}
