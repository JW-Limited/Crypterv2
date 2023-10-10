namespace LILO_Packager.v2.Shared.Interfaces
{
    public interface ILILOFilePacker
    {
        Task UnzipFilesAsync(string zipFilePath, string extractionPath, IProgress<int> progress);
        Task ZipFilesAsync(string zipFilePath, IProgress<int> progress, List<string> files);
    }
}