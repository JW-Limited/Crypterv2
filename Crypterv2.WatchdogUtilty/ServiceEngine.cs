using System.Xml.Serialization;
using LILO_WebEngine.Core.Local.Types;

namespace Crypterv2.WatchdogUtilty
{
    public class ServiceEngine
    {
        private static readonly HttpClient client = new HttpClient();
        private int _id = 0;
        public static ServiceEngine Instance => serviceEngine.Value;
        private static Lazy<ServiceEngine> serviceEngine = new Lazy<ServiceEngine>(() => new ServiceEngine());
        private int _listeningPort = 0;

        public async Task<bool> InitializeAsync(int port)
        {
            _listeningPort = port;
            var uri = new Uri($"http://localhost:{port}/api/state");
            await client.GetAsync(uri);
            return true;
        }

        public async Task StartAsync(int port, int waitCallBackInSeconds)
        {
            if (await InitializeAsync(port))
            {
                while (true)
                {
                    try
                    {
                        await GetStateAsync();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());   
                    }
                    await Task.Delay(waitCallBackInSeconds * 1000);
                }
            }
            else
            {
                throw new WebEngineError();
            }
        }

        private async Task<WEB_ENGINE_STATE> GetStateAsync()
        {
            var uri = new Uri($"http://localhost:{_listeningPort}/api/state");
            var response = await client.GetAsync(uri);
            var stream = await response.Content.ReadAsStreamAsync();
            var state = new XmlSerializer(typeof(WEB_ENGINE_STATE)).Deserialize(stream);
            if (state is null)
            {
                throw new WebEngineError();
            }
            return (WEB_ENGINE_STATE)state;
        }

        public class WebEngineError : Exception { }
    }

}
