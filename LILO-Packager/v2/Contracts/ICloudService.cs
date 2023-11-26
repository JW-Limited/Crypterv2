namespace LILO_Packager.v2.Contracts
{
    public interface ICloudService
    {
        private string PDSERVER { get => PDSERVER; }
        public Task UploadFiles(string[] files, Action<string> statusCallback, Action<long, long> progressCallback);
        public Task DownloadFiles(string[] files);
    }
}
