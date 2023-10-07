using System.IO.Pipes;
using System.Runtime.Serialization.Formatters.Binary;
using LILO_Packager.v2.Core.Interfaces;
using System.Net.Sockets;
using System.Net;
using Newtonsoft.Json;
using LILO_Packager.v2.Core;

namespace Crypterv2_DevTool.Core
{
    public class FeatureFlag : IFeatureFlagSwitcher
    {
        public Dictionary<string, bool> ListFeaturesViaConnectedSocket(TcpClient client)
        {
            using (var stream = client.GetStream())
            using (var writer = new StreamWriter(stream))
            {
                writer.WriteLine("list");
                writer.Flush();

                using (var reader = new StreamReader(stream))
                {
                    string response = reader.ReadToEnd();
                    Dictionary<string, bool> featureValues = JsonConvert.DeserializeObject<Dictionary<string, bool>>(response);
                    return featureValues;
                }
            }
        }

        public void ToggleFeatureViaConnectedSocket(string featureName, bool isEnabled, TcpClient client)
        {
            using (var stream = client.GetStream())
            using (var writer = new StreamWriter(stream))
            {
                writer.WriteLine(featureName);
                writer.WriteLine(isEnabled);
                writer.Flush();
            }
        }

        public Dictionary<string, bool> ListFeaturesViaSocket()
        {
            using (var client = new TcpClient())
            {
                client.Connect(IPAddress.Loopback, 9001);
            
                using (var stream = client.GetStream())
                using (var writer = new StreamWriter(stream))
                {
                    writer.WriteLine("list");
                    writer.Flush();

                    using (var reader = new StreamReader(stream))
                    {
                        string response = reader.ReadToEnd();
                        Dictionary<string, bool> featureValues = JsonConvert.DeserializeObject<Dictionary<string, bool>>(response);
                        return featureValues;
                    }
                }
            }
        }

        public void CloseDeveloperSocket()
        {
            using (var client = new TcpClient())
            {
                client.Connect(IPAddress.Loopback, 9001);

                using (var stream = client.GetStream())
                using (var writer = new StreamWriter(stream))
                {
                    writer.WriteLine("closeThread");
                    writer.Flush();
                }
            }
        }

        public void ToggleFeatureViaSocket(string featureName)
        {
            using (var client = new TcpClient())
            {
                client.Connect(IPAddress.Loopback, 9001); 

                using (var stream = client.GetStream())
                using (var writer = new StreamWriter(stream))
                {
                    writer.WriteLine(featureName);
                    writer.Flush();
                }
            }
        }

        //------------------------------ OLD and USED (only for compatibilty)--------------------------------------

        public void ToggleFeature(FeatureFlags feature, bool isEnabled)
        {
            using (NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", FeatureFlagePipeLineConfig.PipeName, PipeDirection.Out))
            {
                pipeClient.Connect();

                using (StreamWriter sw = new StreamWriter(pipeClient))
                {
                    var formatter = new BinaryFormatter();
                    var featureFlagInfo = new FeatureFlagInfo(feature, isEnabled);
#pragma warning disable SYSLIB0011
                    formatter.Serialize(sw.BaseStream, featureFlagInfo);
#pragma warning restore SYSLIB0011
                }
            }
        }
    }
}
