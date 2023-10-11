
namespace LILO_Packager.v2.Plugins.ThirdParty.Core
{
    public interface ILILOPackageDownloader
    {
        event EventHandler<PackageDownloader.DownloadProgressEventArgs> ProgressChanged;

        Task<PackageDownloader.DownloadResult> DownloadAsync(string url, string filename);
        bool HasNetworkConnection();
    }
}