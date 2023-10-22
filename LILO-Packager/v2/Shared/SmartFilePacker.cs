using LILO_Packager.v2.Shared.Interfaces;
using LILO_Packager.v2.Core.History;
using System.Security.Cryptography;
using System.IO.Compression;
using System.Xml;
using System.ComponentModel.DataAnnotations;

namespace LILO_Packager.v2.Shared
{
    public class ZippedFileInfo
    {
        [Required]
        public List<ZippedFile> Files { get; set; } = new List<ZippedFile>();
        public ApplicationXML Application { get; set; } = new ApplicationXML();
        [Required]
        public Package Package { get; set; } = new Package();
    }

    public class ZippedFile
    {
        [Required]
        public string FilePath { get; set; }
        [Required]
        public string Hash { get; set; }
        public long Size { get; set; }
        public DateTimeOffset LastModified { get; set; }
    }

    public class ApplicationXML
    {
        public string Name { get; set; }
        public string Version { get; set; }
    }

    public class Package
    {
        [Required] public string Name { get; set; }
    }

    public class SmartFilePacker : ILILOSecuredFilePacker
    {
        public async Task<ZippedFileInfo> GetZippedFileInfoAsync(string zipFilePath)
        {
            var zippedFileInfo = new ZippedFileInfo();

            using (var zipArchive = ZipFile.OpenRead(zipFilePath))
            {
                var xmlEntry = zipArchive.GetEntry("crypter_jwlimited.xml");
                if (xmlEntry != null)
                {
                    using (var stream = xmlEntry.Open())
                    {
                        var xmlDoc = new XmlDocument();
                        xmlDoc.Load(stream);

                        var filesNode = xmlDoc.SelectSingleNode("//files");
                        foreach (XmlNode fileNode in filesNode.ChildNodes)
                        {
                            var filePath = fileNode.Attributes["path"].Value;
                            var fileChecksum = fileNode.SelectSingleNode("checksum").InnerText;
                            long fileSize = long.Parse(fileNode.Attributes["size"].Value);
                            var fileEntry = zipArchive.GetEntry(new FileInfo(filePath).Name);

                            zippedFileInfo.Files.Add(new ZippedFile
                            {
                                FilePath = filePath,
                                Hash = fileChecksum,
                                LastModified = fileEntry.LastWriteTime,
                                Size = fileSize
                            });
                        }

                        var appNode = xmlDoc.SelectSingleNode("//application");
                        zippedFileInfo.Application.Name = appNode.SelectSingleNode("name").InnerText;
                        zippedFileInfo.Application.Version = appNode.SelectSingleNode("version").InnerText;

                        var packNode = xmlDoc.SelectSingleNode("//package");
                        zippedFileInfo.Application.Name = packNode.SelectSingleNode("name").InnerText;
                    }
                }
            }

            return zippedFileInfo;
        }

        public async Task<bool> CheckIfFileIsValid(string filePath)
        {
            try
            {
                using (var zipArchive = ZipFile.OpenRead(filePath))
                {
                    var xmlEntry = zipArchive.GetEntry("crypter_jwlimited.xml");
                    if (xmlEntry != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public async Task<string> GetFileHashAsync(string filePath)
        {
            using (var fileStream = File.OpenRead(filePath))
            {
                var sha256 = SHA256.Create();
                var hashBytes = await sha256.ComputeHashAsync(fileStream);
                return BitConverter.ToString(hashBytes).Replace("-", string.Empty);
            }
        }

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

                var xmlDoc = new XmlDocument();
                var rootNode = xmlDoc.CreateElement("crypter_jwlimited");
                rootNode.SetAttribute("version", "v2.0");
                xmlDoc.AppendChild(rootNode);

                var packageNode = xmlDoc.CreateElement("package");
                rootNode.AppendChild(packageNode);

                var packNameNode = xmlDoc.CreateElement("name");
                packNameNode.InnerText = new FileInfo(zipFilePath).Name;
                packageNode.AppendChild(packNameNode);

                var filesNode = xmlDoc.CreateElement("files");
                rootNode.AppendChild(filesNode);

                foreach (var file in filesToZip)
                {
                    var fileNode = xmlDoc.CreateElement("file");
                    fileNode.SetAttribute("path", file);

                    var fileInfo = new FileInfo(file);

                    fileNode.SetAttribute("size", fileInfo.Length.ToString());

                    var checksumNode = xmlDoc.CreateElement("checksum");
                    checksumNode.SetAttribute("method", "SHA256");
                    checksumNode.InnerText = await GetFileHashAsync(file);

                    fileNode.AppendChild(checksumNode);

                    filesNode.AppendChild(fileNode);
                }



                var applicationNode = xmlDoc.CreateElement("application");
                rootNode.AppendChild(applicationNode);

                var nameNode = xmlDoc.CreateElement("name");
                nameNode.InnerText = "LILO_Packager.v2";
                applicationNode.AppendChild(nameNode);

                var versionNode = xmlDoc.CreateElement("version");
                versionNode.InnerText = Program.Version;
                applicationNode.AppendChild(versionNode);

                var zipEntry = zipArchive.CreateEntry("crypter_jwlimited.xml");
                using (var stream = zipEntry.Open())
                {
                    xmlDoc.Save(stream);
                }
            }
        }
        public async Task UnzipFilesAsync(string zipFilePath, string extractionPath, IProgress<int> progress)
        {
            DatabaseHandling dbHandler = new DatabaseHandling();

            using (var zipArchive = ZipFile.OpenRead(zipFilePath))
            {
                var xmlEntry = zipArchive.GetEntry("crypter_jwlimited.xml");
                if (xmlEntry != null)
                {
                    using (var stream = xmlEntry.Open())
                    {
                        var xmlDoc = new XmlDocument();
                        xmlDoc.Load(stream);

                        var filesNode = xmlDoc.SelectSingleNode("//files");
                        foreach (XmlNode fileNode in filesNode.ChildNodes)
                        {
                            var filePath = fileNode.Attributes["path"].Value;
                            var fullFilePath = Path.Combine(extractionPath, filePath);

                            if (File.Exists(fullFilePath))
                            {
                                continue;
                            }

                            zipArchive.ExtractToDirectory(extractionPath);
                            await dbHandler.InsertEncryptedOperationAsync("DeCompress", "libraryBased", "v2", zipFilePath, fullFilePath, $"{new Random().NextInt64(11111, 99999)}");
                        }
                    }
                }
                else
                {
                    zipArchive.ExtractToDirectory(extractionPath);
                    await dbHandler.InsertEncryptedOperationAsync("DeCompress", "libraryBased", "v1", zipFilePath, extractionPath, $"{new Random().NextInt64(11111, 99999)}");
                }

                for (int i = 0; i < zipArchive.Entries.Count; i++)
                {
                    ZipArchiveEntry entry = zipArchive.Entries[i];
                    string entryFullName = Path.Combine(extractionPath, entry.FullName);

                    int progressPercentage = (i + 1) * 100 / zipArchive.Entries.Count;
                    progress?.Report(progressPercentage);
                    await Task.Yield();
                }
            }
        }

    }
}
