namespace LILO_Packager.v2.Plugins.ThirdParty.Core
{
    public class DownloadResult
    {
        public string Filename { get; set; }
        public long FileSize { get; set; }
        public TimeSpan DownloadTime { get; set; }
    }
}
