using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using LILO_Packager.v2.Core.Interfaces;
using LILO_Packager.v2.Core;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Crypterv2_DevTool.Core
{
    public class FeatureFlag : IFeatureFlagSwitcher
    {
        public void ToggleFeature(FeatureFlags feature, bool isEnabled)
        {
            using (NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", FeatureFlagePipeLineConfig.PipeName, PipeDirection.Out))
            {
                pipeClient.Connect();

                using (StreamWriter sw = new StreamWriter(pipeClient))
                {
                    // Serialize the feature flag information and send it through the pipe
                    var formatter = new BinaryFormatter();
                    var featureFlagInfo = new FeatureFlagInfo(feature, isEnabled);
#pragma warning disable SYSLIB0011 // Typ oder Element ist veraltet
                    formatter.Serialize(sw.BaseStream, featureFlagInfo);
#pragma warning restore SYSLIB0011 // Typ oder Element ist veraltet
                }
            }
        }

        public void ToggleFeatureViaSocket(string featureName, bool isEnabled)
        {
            using (var client = new TcpClient())
            {
                client.Connect(IPAddress.Loopback, 9001); 

                using (var stream = client.GetStream())
                using (var writer = new StreamWriter(stream))
                {
                    writer.WriteLine(featureName);
                    writer.WriteLine(isEnabled);
                    writer.Flush();
                }
            }
        }
    }
}
