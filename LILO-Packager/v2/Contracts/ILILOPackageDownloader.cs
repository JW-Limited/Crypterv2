
namespace LILO_Packager.v2.Plugins.ThirdParty.Core
{
    public interface ILILOPackageDownloader
    {
        event EventHandler<DownloadProgressEventArgs> ProgressChanged;

        Task<DownloadResult> DownloadAsync(string url, string filename);
        bool HasNetworkConnection();
    }
}