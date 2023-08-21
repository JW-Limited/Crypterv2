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
        public async Task ZipFilesAsync(string zipFilePath, Action<int> progressCallback, List<string> files)
        {
            if (files == null || files.Count == 0)
            {
                throw new ArgumentException("No files provided to zip.");
            }

            var filesHash = new HashSet<string>(files);
            var filesToZip = new List<string>(filesHash);   

            using (ZipArchive zipArchive = ZipFile.Open(zipFilePath, ZipArchiveMode.Create))
            {
                for (int i = 0; i < filesToZip.Count; i++)
                {
                    string fileToZip = filesToZip[i];
                    string fileName = Path.GetFileName(fileToZip);
                    zipArchive.CreateEntryFromFile(fileToZip, fileName);

                    int progress = (i + 1) / filesToZip.Count;
                    progressCallback?.Invoke(progress);
                }
            }
        }

        public async Task UnzipFilesAsync(string zipFilePath, string extractionPath, Action<double> progressCallback)
        {
            using (ZipArchive zipArchive = ZipFile.OpenRead(zipFilePath))
            {
                for (int i = 0; i < zipArchive.Entries.Count; i++)
                {
                    ZipArchiveEntry entry = zipArchive.Entries[i];
                    string entryFullName = Path.Combine(extractionPath, entry.FullName);
                    entry.ExtractToFile(entryFullName, true);

                    double progress = (i + 1.0) / zipArchive.Entries.Count;
                    progressCallback?.Invoke(progress);
                }
            }
        }
    }
}
