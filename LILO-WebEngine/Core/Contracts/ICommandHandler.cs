using System.Net;

namespace LILO_WebEngine.Core.Contracts
{
    public interface ICommandHandler
    {
        Task Handle(HttpListenerRequest request, HttpListenerResponse responsem, HttpListenerContext context = null);
    }
}
