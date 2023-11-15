namespace LILO_Packager.v2.Plugins.ThirdParty.Core
{
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
