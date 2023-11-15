using System.Net;

namespace LILO_WebEngine.Service
{
    public class ServerFilter
    {
        public string FileExtension { get; set; }
        public Func<HttpListenerContext, Task> Action { get; set; }

        public ServerFilter(string fileExtension)
        {
            FileExtension = fileExtension;
        }

        public static ServerFilter Create(string fileExtension, Func<HttpListenerContext, Task> action)
        {
            return new ServerFilter(fileExtension)
            {
                Action = action
            };
        }
    }
}
