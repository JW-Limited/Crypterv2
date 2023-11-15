using System.Net;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using LILO_WebEngine;
using LILO_WebEngine.Core.Handler;
using LILO_WebEngine.Core.Local.Types;

namespace Crypterv2.WatchdogUtilty
{
    public class ServiceEngine
    {
        public static ServiceEngine Instance => serviceEngine.Value;
        private static Lazy<ServiceEngine> serviceEngine = new Lazy<ServiceEngine>(() => new ServiceEngine());
        private int _id = 0;
        private int _listeningPort = 0;
        private WebRequest _request;

        public ServiceEngine() 
        {

        }

        public async Task<bool> Initialize(int port)
        {
            _listeningPort = port;
            _request = WebRequest.Create(new Uri($"http://localhost:{port}/api/state"));
            return true;
        }

        public async Task Start(int port, int waitCallBackInSeconds)
        {
            if(await Initialize(port))
            {
                while (true)
                {
                    Thread.Sleep(waitCallBackInSeconds * 1000);

                    var response = _request.GetResponse();
                    var stream = response.GetResponseStream();
                    var state = new XmlSerializer(typeof(WEB_ENGINE_STATE)).Deserialize(stream);

                    if(state is null)
                    {
                        throw new WebEngineError();
                    }
                }
            }
        }
    }

    public class WebEngineError : Exception { } 
}
    