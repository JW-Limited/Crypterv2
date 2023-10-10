using System.IO.Compression;
using System.Xml.Linq;
using System.Xml;
using LILO_Packager.v2.Plugins.ThirdParty.Types;
using LILO_Packager.v2.Core.Dialogs;
using Guna.UI2.WinForms.Suite;
using System;


namespace LILO_Packager.v2.Plugins.ThirdParty.Core
{
    public class PluginPackageManager
    {
        public static bool IsValidPluginPackage(string zipFilePath)
        {
            try
            {
                using (ZipArchive zipArchive = ZipFile.OpenRead(zipFilePath))
                {
                    return zipArchive.Entries.Any(entry => entry.FullName == "plugin.info")
                        && IsPluginInfoValid(zipArchive, "plugin.info");
                }
            }
            catch(IOException ex)
            {
                OkDialog.Show(ex.Message, "IOException");
                return false;
            }
            catch (Exception)
            { return false; }
            
        }

        private static bool IsPluginInfoValid(ZipArchive zipArchive, string entryName)
        {
            var pluginInfoEntry = zipArchive.Entries.FirstOrDefault(entry => entry.FullName == entryName);
            if (pluginInfoEntry == null)
            {
                return false;
            }

            using (var streamReader = new StreamReader(pluginInfoEntry.Open()))
            {
                try
                {
                    XDocument.Load(XmlReader.Create(streamReader));
                    return true;
                }
                catch (XmlException)
                {
                    return false;
                }
            }
        }

        public static void ExtractPluginInfo(string zipFilePath, string outputFolderPath)
        {
            using (ZipArchive zipArchive = ZipFile.OpenRead(zipFilePath))
            {
                foreach (ZipArchiveEntry zipArchiveEntry in zipArchive.Entries)
                {
                    if (zipArchiveEntry.FullName == "icon.png" || zipArchiveEntry.FullName == "plugin.info")
                    {
                        string outputFilePath = Path.Combine(outputFolderPath, zipArchiveEntry.FullName);
                        zipArchiveEntry.ExtractToFile(outputFilePath, true);
                    }
                }
            }
        }

        public class ExtractionResponse
        {
            public ExtractionResponse(int responseCode, List<string> extractedDllFiles, List<string> extractedAssetFiles)
            {
                ResponseCode = responseCode;
                ExtractedDllFiles = extractedDllFiles;
                ExtractedAssetFiles = extractedAssetFiles;
            }

            public int ResponseCode { get; set; }
            public List<string> ExtractedDllFiles { get; set; }
            public List<string> ExtractedAssetFiles { get; set; }
        }


        public static async Task<int> CopyToPluginRepo(
                                                        ExtractionResponse extractionResponse,
                                                        string mainDirectory,
                                                        Action<int, string> progressCallback,
                                                        FileExistsHandling fileExistsHandling = FileExistsHandling.Overwrite)
        {
            if (extractionResponse == null || extractionResponse.ResponseCode != INSTALLER_CODES.SUCCESS)
            {
                return INSTALLER_CODES.INVALID_PARAMETER;
            }

            try
            {
                var extractedDllFiles = extractionResponse.ExtractedDllFiles;
                var extractedAssetFiles = extractionResponse.ExtractedAssetFiles;
                int previousProgress = -1;
                int previousProgressASS = -1;
                int totalFilesToCopy = extractedDllFiles.Count + extractedAssetFiles.Count;
                int filesCopied = 0;

                foreach (var dllFile in extractedDllFiles)
                {
                    string dllFileName = Path.GetFileName(dllFile);
                    string destinationPath = Path.Combine(mainDirectory, dllFileName);

                    if (File.Exists(destinationPath))
                    {
                        switch (fileExistsHandling)
                        {
                            case FileExistsHandling.Skip:
                                break;
                            case FileExistsHandling.Overwrite:
                                File.Copy(dllFile, destinationPath, true);
                                break;
                        }
                    }
                    else
                    {
                        File.Copy(dllFile, destinationPath);
                    }

                    filesCopied++;
                    string description = $"Register: {dllFileName}";
                    int progressPercentage = (int)((double)filesCopied / totalFilesToCopy * 100);

                    int increment = 50;
                    if (progressPercentage > previousProgress)
                    {
                        increment = progressPercentage - previousProgress;
                    }

                    for (int i = previousProgress; i <= progressPercentage; i += increment)
                    {
                        progressCallback?.Invoke(i, description);

                        await Task.Delay(60);
                    }

                    previousProgress = progressPercentage;
                }

                string assetsDirectory = Path.Combine(mainDirectory, "assets");
                Directory.CreateDirectory(assetsDirectory); 

                foreach (var assetFile in extractedAssetFiles)
                {
                    string assetFileName = Path.GetFileName(assetFile);
                    string destinationPath = Path.Combine(assetsDirectory, assetFileName);

                    if (File.Exists(destinationPath))
                    {
                        switch (fileExistsHandling)
                        {
                            case FileExistsHandling.Skip:
                                break;
                            case FileExistsHandling.Overwrite:
                                File.Copy(assetFile, destinationPath, true);
                                break;
                        }
                    }
                    else
                    {
                        File.Copy(assetFile, destinationPath);
                    }

                    filesCopied++;
                    int progressPercentage = (int)((double)filesCopied / totalFilesToCopy * 100);
                    string description = $"Register: assets/{assetFileName}";

                    int increment = 50;
                    if (progressPercentage > previousProgressASS)
                    {
                        increment = progressPercentage - previousProgressASS;
                    }

                    for (int i = previousProgressASS; i <= progressPercentage; i += increment)
                    {
                        progressCallback?.Invoke(i, description);

                        await Task.Delay(60);
                    }

                    previousProgressASS = progressPercentage;
                }

                progressCallback.Invoke(100, "Awaiting Crypterv2 Callback");

                await Task.Delay(1000);

                progressCallback.Invoke(100, "");

                return INSTALLER_CODES.SUCCESS;
            }
            catch (Exception)
            {
                return INSTALLER_CODES.INVALID_OPERATION;
            }
        }

        public static void CleanTempDirectory(string tempDirectory)
        {
            try
            {
                if (Directory.Exists(tempDirectory))
                {
                    foreach (string file in Directory.GetFiles(tempDirectory))
                    {
                        File.Delete(file);
                    }

                    string assetsDirectory = Path.Combine(tempDirectory, "assets");
                    if (Directory.Exists(assetsDirectory))
                    {
                        Directory.Delete(assetsDirectory, true);
                    }

                    Directory.Delete(tempDirectory, true);
                }
            }
            catch (Exception)
            {
               
            }
        }

        public enum FileExistsHandling
        {
            Skip,
            Overwrite
        }


        public static async Task<ExtractionResponse> ExtractPluginWithAssets(string zipFilePath, 
                                                               string outputFolderPath, 
                                                               PluginInformation info, 
                                                               Action<int, string> progressCallback)
        {
            try
            {
                using (ZipArchive zipArchive = ZipFile.OpenRead(zipFilePath))
                {
                    int totalEntries = zipArchive.Entries.Count;
                    int currentEntry = 0;
                    int previousProgress = -1;
                    var listDLL = new List<string>();
                    var listASS = new List<string>();

                    foreach (ZipArchiveEntry zipArchiveEntry in zipArchive.Entries)
                    {

                        currentEntry++;

                        string description = $"Extracting: {zipArchiveEntry.FullName}";
                        int progress = (int)((double)currentEntry / totalEntries * 100);

                        int increment = 50;
                        if (progress > previousProgress)
                        {
                            increment = progress - previousProgress;
                        }

                        for (int i = previousProgress; i <= progress; i += increment)
                        {
                            progressCallback?.Invoke(i, description);

                            await Task.Delay(50);
                        }

                        previousProgress = progress;

                        if (zipArchiveEntry.FullName == info.PluginDll)
                        {
                            string outputFilePath = Path.Combine(outputFolderPath, zipArchiveEntry.FullName);
                            zipArchiveEntry.ExtractToFile(outputFilePath, true);
                            listDLL.Add(outputFilePath); 
                        }
                        else if (zipArchiveEntry.FullName.StartsWith("assets/") && !string.IsNullOrWhiteSpace(zipArchiveEntry.Name))
                        {
                            string assetFilePath = Path.Combine(outputFolderPath, zipArchiveEntry.FullName);
                            if(!Directory.Exists(outputFolderPath + "\\assets"))
                            {
                                Directory.CreateDirectory(outputFolderPath + "\\assets");
                            }
                            zipArchiveEntry.ExtractToFile(assetFilePath, true);
                            listASS.Add(assetFilePath);
                        }
                    }

                    progressCallback?.Invoke(100, "Checking register of: " + info.Name);

                    //File.Delete(zipFilePath);

                    await Task.Delay(2000);

                    progressCallback?.Invoke(100, "Finished Extracting.");

                    return new ExtractionResponse(INSTALLER_CODES.SUCCESS,listDLL,listASS); 
                }
            }
            catch(IOException ex)
            {
                return new ExtractionResponse(INSTALLER_CODES.FILE_ACCESS_DENIED,null,null);
            }
            catch (Exception)
            {
                return new ExtractionResponse(INSTALLER_CODES.INVALID_DATA, null, null);
            }
            
        }

        public static bool IsWindowsVersionSupported(string targetVersion)
        {
            if (Version.TryParse(targetVersion, out Version requiredVersion))
            {
                return Environment.OSVersion.Version >= requiredVersion;
            }
            else
            {
                return false;
            }
        }
    }
}
