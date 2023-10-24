using Crypterv2.DevTool.Core.Exceptions;
using System.Reflection;

namespace Crypterv2.DevTool.Core.Plugins
{
    public class PackageManager
    {
        public PluginPackage _package { get; set; }
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

                foreach(var item in _package.DependencieList) 
                {
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

                if (!File.Exists(_package.DllFile)) throw new DllFileNotFoundException(_package.DllFile, "The PluginBaseFile was not found!");

                File.Copy(_package.DllFile,tempDirectory + "\\" + new FileInfo(_package.DllFile).Name,true);

                _package.info.SerializeToXml(tempPluginInfoFile);

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
