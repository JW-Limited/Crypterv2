using Crypterv2.DevTool.Core.Exceptions;
using Crypterv2.DevTool.Core.Plugins.Types;
using System.IO.Compression;
using System.Reflection;

namespace Crypterv2.DevTool.Core.Plugins
{
    public class PackageManager
    {
        /// <summary>
        /// The plugin package to be created.
        /// </summary>
        public PluginPackage _package { get; set; }
        /// <summary>
        /// A progress reporter for the packaging process.
        /// </summary>
        public IProgress<PackageManagerProgress> Progress { get; set; }
        /// <summary>
        /// A class for managing the creation of plugin packages.
        /// </summary>
        public PackageManager(PluginPackage pack)
        {
            _package = pack;
        }

        /// <summary>
        /// Creates the plugin package.
        /// </summary>
        /// <returns>A PackageManagerResponse object indicating the success or failure of the packaging process.</returns>
        public async Task<PackageManagerResponse> CreatePackage()
        {
            var tempDirectory = _package.PluginDirectory + "\\temp";
            var tempAssetFolder = tempDirectory + "\\assets";
            var tempPluginInfoFile = tempDirectory + "\\plugin.info";
            _package.info.Dependencies = new List<LILO_Packager.v2.Plugins.ThirdParty.Types.DependencyInfo>();
            try
            {
                if (!Directory.Exists(tempDirectory)) Directory.CreateDirectory(tempDirectory);
                if (!Directory.Exists(tempAssetFolder)) Directory.CreateDirectory(tempAssetFolder);
                if (File.Exists(tempPluginInfoFile)) File.Delete(tempPluginInfoFile);
                if (File.Exists(_package.PluginDirectory + "\\" + _package.Name + ".cryptex")) File.Delete(_package.PluginDirectory + "\\" + _package.Name + ".cryptex");

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

                    if(new FileInfo(item).Extension is ".exe" or ".dll")
                    {
                        var assymblyInfo = GetAssemblyInfo(item);

                        _package.info.Dependencies.Add(new LILO_Packager.v2.Plugins.ThirdParty.Types.DependencyInfo()
                        {
                            Name = assymblyInfo.LoadedAssymblyName.Name ?? new FileInfo(item).Name,
                            Library = true,
                            Version = new LILO_Packager.v2.Plugins.ThirdParty.Types.VersionInfo()
                            {
                                Number = assymblyInfo.LoadedAssymblyName?.Version?.ToString() ?? "1"
                            }
                        });
                    }
                    else
                    {
                        _package.info.Dependencies.Add(new LILO_Packager.v2.Plugins.ThirdParty.Types.DependencyInfo()
                        {
                            Name = new FileInfo(item).Name,
                            Library = true,
                            Version = new LILO_Packager.v2.Plugins.ThirdParty.Types.VersionInfo()
                            {
                                Number = "1"
                            }
                        });
                    }
                    
                }

                progress.CurrentItem++;
                progress.Message = $"Copying plugin file {_package.DllFile}...";
                Progress?.Report(progress);

                if (!File.Exists(_package.DllFile)) throw new DllFileNotFoundException(_package.DllFile, "The PluginBaseFile was not found!");

                File.Copy(_package.DllFile, tempDirectory + "\\" + new FileInfo(_package.DllFile).Name, true);

                if(!File.Exists(_package.IconFile))
                {
                    Properties.Resources.icons8_bursts_96.Save(tempDirectory + "\\icon.png");
                }
                else
                {
                    File.Copy(_package.IconFile, tempDirectory + "\\icon.png");
                }

                _package.info.Description = _package.Description;
                _package.info.Author = new LILO_Packager.v2.Plugins.ThirdParty.Types.AuthorInfo() { Name = _package.Author };
                _package.info.PluginDll = new FileInfo(_package.DllFile).Name;
                _package.info.SerializeToXml(tempPluginInfoFile);

                var assetFiles = Directory.GetFiles(tempAssetFolder);
                progress.TotalItems = assetFiles.Length;
                progress.Message = "Creating PluginPackage...";
                Progress?.Report(progress);

                using (var archive = ZipFile.Open(_package.PluginDirectory + "\\" + _package.Name + ".cryptex",ZipArchiveMode.Create))
                {
                    archive.CreateEntryFromFile(tempPluginInfoFile, "plugin.info");
                    archive.CreateEntryFromFile(tempDirectory + "\\" + new FileInfo(_package.DllFile).Name, new FileInfo(_package.DllFile).Name, CompressionLevel.SmallestSize);
                    archive.CreateEntryFromFile(tempDirectory + "\\icon.png", "icon.png");

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

                return PackageManagerResponse.SuccessFull();
            }
            catch (Exception ex)
            {
                return PackageManagerResponse.FromException(ex);
            }
        }

        public static AssemblyResponse GetAssemblyInfo(string filePath)
        {
            var response = new AssemblyResponse();

            try
            {
                response.LoadedAssembly = Assembly.LoadFrom(filePath);
                response.LoadedAssymblyName = response.LoadedAssembly.GetName();

                response.Success = true;
                response.ErrorCode = DevToolCodes.SuccessfullAllocated;

                return response;
            }
            catch(Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
                response.ErrorCode = DevToolCodes.UnknownAllocationError;
                return response;
            }

            
        }
    }
}
