using LILO_WebEngine.Core.Contracts;
using LILO_WebEngine.Core.Pages;
using LILO_WebEngine.Service;
using System.ComponentModel;
using System.Net;

namespace LILO_WebEngine.Core.Handler
{
    public class SearchCommandHandler : ICommandHandler, ISearchHandle
    {

        public async Task Handle(HttpListenerRequest request, HttpListenerResponse response, HttpListenerContext context = null)
        {
            var responseSTR = new SearchSideGenerator(LocalServer.Instance.SourceDirectory).GenerateSide();
            var responseXML = (byte[])(Convert.FromBase64String(responseSTR));

            response.ContentLength64 = responseXML.Length;
            response.OutputStream.Write(responseXML, 0, responseXML.Length);
            response.Close();
        }

        public async Task<bool> AsyncSearch()
        {
            try
            {
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }

    public interface ISearchHandle
    {
        public Task<bool> AsyncSearch();
    }
}
