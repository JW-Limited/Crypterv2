using System.Net;

namespace LILO_WebEngine.Core.Contracts
{
    public interface IMediaProvider
    {
        Task<bool> StreamMediaAsync(HttpListenerRequest request, HttpListenerResponse response);
    }
}