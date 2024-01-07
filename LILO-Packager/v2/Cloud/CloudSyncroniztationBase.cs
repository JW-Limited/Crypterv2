using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace LILO_Packager.v2.Cloud
{
    public class CloudSyncroniztationBase
    {
        public static bool HasNetworkConnection()
        {
            try
            {
                var pings = new string[]
                {
                      "google.com",
                      "8.8.8.8",
                      "cloudflare.com"
                };

                var successfulPings = 0;
                foreach (var address in pings)
                {
                    var ping = new Ping();
                    var pingReply = ping.Send(address);
                    if (pingReply.Status == IPStatus.Success)
                    {
                        successfulPings++;
                    }
                }

                return successfulPings >= pings.Length / 2;
            }
            catch (Exception)
            {
                return false; 
            }
        }

        public static bool HasSufficientStorage()
        {
            var driveInfo = new DriveInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            var availableStorage = driveInfo.AvailableFreeSpace;

            int gb = 5 * (1024 ^ 3);
            return availableStorage > gb;
        }

        public static string GetFileHash(string pluginFile)
        {
            if (string.IsNullOrEmpty(pluginFile))
            {
                throw new ArgumentNullException(nameof(pluginFile));
            }

            var hashBytes = SHA256.HashData(File.ReadAllBytes(pluginFile));
            var hashString = BitConverter.ToString(hashBytes).Replace("-", "").Substring(0, 16);
            var fileName = Path.GetFileNameWithoutExtension(pluginFile);
            return hashString;
        }

        public static bool CloudAvailable()
        {
            try
            {
                var ping = new Ping();
                var pingTask = ping.Send("www.pixeldrain.com");
                return pingTask.Status == IPStatus.Success;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.Source + ex.StackTrace + ex.InnerException,"MainHost - Connection Service",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
