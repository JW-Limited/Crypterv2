using LILO_Packager.v2.Plugins.ThirdParty.Core;
using LILO_Packager.v2.Plugins.ThirdParty.Interfaces;
using LILO_Packager.v2.Plugins.ThirdParty.Types.Exceptions;
using LILO_Packager.v2.Shared;
using System.Security.Cryptography;

namespace LILO_Packager.v2.Plugins.ThirdParty.Types
{
    public class Plugin : IPlugin
    {
        public Bitmap PluginIcon { get; set; }
        public string TempDirectory { get; set; }
        public PluginInformation PluginInformation { get; set; }
        public string PluginPackageFile { get; set; }

        public static IPlugin Create(string pluginFile)
        {
            try
            {
                if (!PluginPackageManager.IsValidPluginPackage(pluginFile))
                {
                    throw new InvalidPackageException(pluginFile);
                }

                ConsoleManager.Instance().WriteLineWithColor("Package is a valid Plugin");

                var plugin = new Plugin();
                var dir = Path.Combine(Application.CommonAppDataPath, "pluginInstaller");
                Directory.CreateDirectory(dir);
                var tempDir = Path.Combine(dir, GetTempDirectoryName(pluginFile));
                Directory.CreateDirectory(tempDir);

                plugin.TempDirectory = tempDir;

                ConsoleManager.Instance().WriteLineWithColor("Created tempPlugin Directory for Information: " + tempDir);

                PluginPackageManager.ExtractPluginInfo(pluginFile, tempDir);

                ConsoleManager.Instance().WriteLineWithColor("Extracted Plugin info file");

                var info = PluginInformation.DeserializeFromXml(Path.Combine(tempDir, "plugin.info"));
                plugin.PluginInformation = info;
                plugin.PluginIcon = (Bitmap)Bitmap.FromFile(Path.Combine(tempDir, "icon.png"));
                plugin.PluginPackageFile = pluginFile;
                Program.InstanceCacheContainer.Register<IPlugin>(() => plugin);

                return plugin;
            }
            catch (Exception ex)
            {
                ConsoleManager.Instance().WriteLineWithColor($"Error while creating the plugin: {ex.Message}", ConsoleColor.Red);
                throw;
            }
        }

        public static async Task<IPlugin> CreateAsync(string pluginFile)
        {
            try
            {
                if (!PluginPackageManager.IsValidPluginPackage(pluginFile))
                {
                    throw new InvalidPackageException(pluginFile);
                }

                ConsoleManager.Instance().WriteLineWithColor("Package is a valid Plugin");

                var plugin = new Plugin();
                var dir = Path.Combine(Application.CommonAppDataPath, "pluginInstaller");
                Directory.CreateDirectory(dir);
                var tempDir = Path.Combine(dir, GetTempDirectoryName(pluginFile));
                Directory.CreateDirectory(tempDir);

                plugin.TempDirectory = tempDir;

                ConsoleManager.Instance().WriteLineWithColor("Created tempPlugin Directory for Information: " + tempDir);

                PluginPackageManager.ExtractPluginInfo(pluginFile, tempDir);

                ConsoleManager.Instance().WriteLineWithColor("Extracted Plugin info file");

                var info = PluginInformation.DeserializeFromXml(Path.Combine(tempDir, "plugin.info"));
                plugin.PluginInformation = info;
                plugin.PluginIcon = (Bitmap)Bitmap.FromFile(Path.Combine(tempDir, "icon.png"));
                plugin.PluginPackageFile = pluginFile;

                return plugin;
            }
            catch (Exception ex)
            {
                ConsoleManager.Instance().WriteLineWithColor($"Error while creating the plugin: {ex.Message}", ConsoleColor.Red);
                throw;
            }
        }

        public static string GetTempDirectoryName(string pluginFile)
        {
            var hashBytes = SHA256.HashData(File.ReadAllBytes(pluginFile));
            var hashString = BitConverter.ToString(hashBytes).Replace("-", "").Substring(0, 16);
            var fileName = Path.GetFileNameWithoutExtension(pluginFile);
            return hashString + fileName;
        }
    }

}
