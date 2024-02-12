using LILO_Packager.v2.Shared.Packages;

namespace LILO_Packager.v2.Shared.Interfaces
{
    public interface ILILOSecuredFilePacker
    {
        Task<string> GetFileHashAsync(string filePath);
        Task<ZippedFileInfo> GetZippedFileInfoAsync(string zipFilePath);
        Task UnzipFilesAsync(string zipFilePath, string extractionPath, IProgress<int> progress, bool indexRequired = true);
        Task ZipFilesAsync(string zipFilePath, IProgress<int> progress, List<string> files);
    }
}