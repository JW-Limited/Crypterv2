using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.shared
{
    public class MultiplefileHandling
    {
        public async Task ZipFilesAsync(string zipFilePath, IProgress<int> progress, List<string> files)
        {
            if (files == null || files.Count == 0)
            {
                throw new ArgumentException("No files provided to zip.");
            }

            var filesHash = new HashSet<string>(files);
            var filesToZip = new List<string>(filesHash);

            using (var zipArchive = ZipFile.Open(zipFilePath, ZipArchiveMode.Create))
            {
                for (int i = 0; i < filesToZip.Count; i++)
                {
                    string fileToZip = filesToZip[i];
                    string fileName = Path.GetFileName(fileToZip);
                    zipArchive.CreateEntryFromFile(fileToZip, fileName);

                    int progressPercentage = (i + 1) * 100 / filesToZip.Count;
                    progress?.Report(progressPercentage);
                    await Task.Yield();
                }
            }
        }

        public async Task UnzipFilesAsync(string zipFilePath, string extractionPath, IProgress<int> progress)
        {
            using (var zipArchive = ZipFile.OpenRead(zipFilePath))
            {
                for (int i = 0; i < zipArchive.Entries.Count; i++)
                {
                    ZipArchiveEntry entry = zipArchive.Entries[i];
                    string entryFullName = Path.Combine(extractionPath, entry.FullName);
                    entry.ExtractToFile(entryFullName, true);

                    int progressPercentage = (i + 1) * 100 / zipArchive.Entries.Count;
                    progress?.Report(progressPercentage);
                    await Task.Yield(); 
                }
            }
        }
    }
}
