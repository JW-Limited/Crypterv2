using System.Net;

namespace LILO_WebEngine.Exceptions
{
    public class HttpContextNullException : Exception
    {
        public HttpContextNullException()
        {
        }

        public HttpContextNullException(string message) : base(message)
        {
        }

        public HttpContextNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public HttpContextNullException(HttpListenerRequest request, HttpListenerResponse response)
            : base($"HttpContext is null for request: {request.Url?.ToString() ?? "null"} and response: {response.StatusCode} / {(int)HttpStatusCode.NoContent}")
        {
        }
    }

}
