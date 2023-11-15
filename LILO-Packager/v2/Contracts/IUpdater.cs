using System.Net;

namespace LILO_Packager.v2.Core.Updates
{
    public interface IUpdater
    {
        void DownloadLatestRelease(string owner, string repo, DownloadProgressChangedEventHandler progressHandler, CancellationToken cancellationToken = default);
        string GetCurrentVersion();
        Task<string> GetLatestChanges(string owner, string repo);
        string GetLatestReleaseUrl(string owner, string repo);
        string GetLatestVersion(string owner, string repo);
        bool HasNewRelease(string owner, string repo);
        void SafeDeleteZipFile(string zipFilePath, Action<int> progressCallback = null, Action<string> errorCallback = null);
        void VerifyAndExtractZip(string zipFilePath, string expectedHashValue, string destinationDirectory, Action<int> progressCallback = null, Action<string> errorCallback = null);
    }
}