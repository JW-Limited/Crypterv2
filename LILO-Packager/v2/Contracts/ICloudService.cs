namespace LILO_Packager.v2.Contracts
{
    public interface ICloudService
    {
        public string PDSERVER { get => _pdServer; }
        internal string _pdServer => "";
        public Task UploadFiles(string[] files, Action<string> statusCallback, Action<long, long> progressCallback);
        public Task DownloadFiles(string[] files);
    }
}
