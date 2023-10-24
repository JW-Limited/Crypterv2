using Crypterv2.DevTool.Core.Exceptions;
using Crypterv2.DevTool.Core.Plugins.Types;
using System.IO.Compression;
using System.Reflection;

namespace Crypterv2.DevTool.Core.Plugins
{

    public class PackageManager
    {
        public PluginPackage _package { get; set; }
        public IProgress<PackageManagerProgress> Progress { get; set; }

        public PackageManager(PluginPackage pack)
        {
            _package = pack;
        }

        public async Task<PackageManagerResponse> CreatePackage()
        {
            var tempDirectory = _package.PluginDirectory + "\\temp";
            var tempAssetFolder = tempDirectory + "\\assets";
            var tempPluginInfoFile = tempDirectory + "\\plugin.info";

            try
            {
                if (!Directory.Exists(tempDirectory)) Directory.CreateDirectory(tempDirectory);
                if (!Directory.Exists(tempAssetFolder)) Directory.CreateDirectory(tempAssetFolder);
                if (File.Exists(tempPluginInfoFile)) File.Delete(tempPluginInfoFile);

                var progress = new PackageManagerProgress()
                {
                    TotalItems = _package.DependencieList.Count + 1,
                    CurrentItem = 0
                };

                foreach (var item in _package.DependencieList) 
                {
                    progress.CurrentItem++;
                    progress.Message = $"Copying dependency {item}...";
                    Progress?.Report(progress);

                    if (!File.Exists(item)) throw DllFileNotFoundException.FromFile(item);
                    File.Copy(item, tempAssetFolder + "\\" + new FileInfo(item).Name, true);
                    var assymblyInfo = GetAssemblyInfo(item);

                    _package.info.Dependencies.Add(new LILO_Packager.v2.Plugins.ThirdParty.Types.DependencyInfo()
                    {
                        Name = assymblyInfo.Name,
                        Library = true,
                        Version = new LILO_Packager.v2.Plugins.ThirdParty.Types.VersionInfo()
                        {
                            Number = assymblyInfo.Version.ToString()
                        }
                    });
                }

                progress.CurrentItem++;
                progress.Message = $"Copying plugin file {_package.DllFile}...";
                Progress?.Report(progress);

                if (!File.Exists(_package.DllFile)) throw new DllFileNotFoundException(_package.DllFile, "The PluginBaseFile was not found!");

                File.Copy(_package.DllFile, tempDirectory + "\\" + new FileInfo(_package.DllFile).Name, true);

                _package.info.Version = new LILO_Packager.v2.Plugins.ThirdParty.Types.VersionInfo() { Number = _package.Version };
                _package.info.Description = _package.Description;
                _package.info.Author = new LILO_Packager.v2.Plugins.ThirdParty.Types.AuthorInfo() { Name = _package.Author };
                _package.info.PluginDll = new FileInfo(_package.DllFile).Name;
                _package.info.SerializeToXml(tempPluginInfoFile);

                var assetFiles = Directory.GetFiles(tempAssetFolder);
                progress.TotalItems = assetFiles.Length;
                progress.Message = "Creating PluginPackage...";
                Progress?.Report(progress);

                ZipFile.CreateFromDirectory(tempDirectory, _package.PluginDirectory + "\\" + _package.Name + ".cryptex");
                using (var archive = ZipFile.Open(_package.PluginDirectory + "\\" + _package.Name + ".cryptex",ZipArchiveMode.Create))
                {
                    archive.CreateEntryFromFile(tempPluginInfoFile, "plugin.info");
                    archive.CreateEntryFromFile(tempDirectory + "\\" + new FileInfo(_package.DllFile).Name, new FileInfo(_package.DllFile).Name, CompressionLevel.SmallestSize);

                    progress.CurrentItem = 2;
                    progress.Message = "Binding Assets...";
                    Progress?.Report(progress);
                    for (int i = 0; i < assetFiles.Length; i++)
                    {
                        progress.CurrentItem = i;
                        progress.Message = $"Binding Asset: assets/{new FileInfo(assetFiles[i]).Name}";
                        Progress?.Report(progress);

                        archive.CreateEntryFromFile(assetFiles[i],"assets/" + new FileInfo(assetFiles[i]).Name,CompressionLevel.SmallestSize);
                    }
                }


                Directory.Delete(tempDirectory, true);

                return PackageManagerResponse.Success();
            }
            catch (Exception ex)
            {
                return PackageManagerResponse.FromException(ex);
            }
        }

        public static AssemblyName GetAssemblyInfo(string filePath)
        {
            Assembly assembly = Assembly.LoadFrom(filePath);
            AssemblyName assemblyName = assembly.GetName();

            return assemblyName;
        }
    }
}
