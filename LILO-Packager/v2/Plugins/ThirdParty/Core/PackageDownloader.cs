using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;

namespace LILO_Packager.v2.Plugins.ThirdParty.Core
{
    public class PackageDownloader : ILILOPackageDownloader
    {
        public event EventHandler<DownloadProgressEventArgs> ProgressChanged;

        public async Task<DownloadResult> DownloadAsync(string url, string filename)
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += (sender, e) =>
            {
                ProgressChanged?.Invoke(this, new DownloadProgressEventArgs(e.BytesReceived, e.TotalBytesToReceive));
            };

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            await client.DownloadFileTaskAsync(new Uri(url), filename);

            stopwatch.Stop();

            long fileSize = new FileInfo(filename).Length;
            TimeSpan downloadTime = stopwatch.Elapsed;

            return new DownloadResult
            {
                Filename = filename,
                FileSize = fileSize,
                DownloadTime = downloadTime
            };
        }

        public bool HasNetworkConnection()
        {
            try
            {

                var ping = new Ping();
                var pingReply = ping.Send("google.com");

                return pingReply.Status == IPStatus.Success;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public class DownloadResult
        {
            public string Filename { get; set; }
            public long FileSize { get; set; }
            public TimeSpan DownloadTime { get; set; }
        }

        public class DownloadProgressEventArgs : EventArgs
        {
            public long BytesReceived { get; private set; }
            public long TotalBytesToReceive { get; private set; }

            public DownloadProgressEventArgs(long bytesReceived, long totalBytesToReceive)
            {
                BytesReceived = bytesReceived;
                TotalBytesToReceive = totalBytesToReceive;
            }

            public double Percentage
            {
                get { return (double)BytesReceived * 100 / TotalBytesToReceive; }
            }
        }
    }
}
