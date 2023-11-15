using System.Net;

namespace LILO_WebEngine.Core.Contracts
{
    public interface ICoreTaskHandler
    {
        Task Handle(HttpListenerContext context, HttpStatusCode statusCode, Exception ex = null);
    }
}