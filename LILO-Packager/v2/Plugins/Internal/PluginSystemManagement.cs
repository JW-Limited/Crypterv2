using LILO_Packager.v2.Plugins.PluginCore;
using LILO_Packager.v2.Shared;

namespace LILO_Packager.v2.Plugins.Internal
{
    public class PluginSystemManagement
    {
        private static Lazy<PluginSystemManagement> _instance = new Lazy<PluginSystemManagement>(() => new PluginSystemManagement());
        public static PluginSystemManagement Instance => _instance.Value;
        public Dictionary<PluginID,IPluginBasev2> IndexedPlugins { get; private set; } = new Dictionary<PluginID, IPluginBasev2>();

        public PluginSystemManagement()
        {
            
        }

        public async Task<byte> RegisterPlugin(IPluginBasev2 plugin)
        {
            try
            {
                IndexedPlugins.Add(plugin.ID, plugin);

                var data = new PluginData()
                {
                    spValues = new PluginData.PluginStaticValues()
                    {
                        Subscription = plugin.License.License.Subscription,
                        LicenseKey = plugin.License.License.LicenseKey,
                        LicenseName = plugin.License.License.LicenseName,
                        Name = plugin.License.License.LicenseName,
                        LicensePayDay = plugin.License.License.LicensePayDay
                    },

                    FileFormatClearifier = new Shared.FileFormatClearifier()
                    {
                        ExtensionPrefix = ".pdex",
                        FriendlyName = "Plugin Data Extraction",
                        SchemeUri = "https://beta.lilo.com/schemes/formater/1",
                        Description = "An extraction of the Plugins Internal Data and Values the using Application generated.",
                        FormatVersion = "1.0",
                    },
                    Permissions = new List<PluginData.PermissionSet>()
                };

                if (StorageProvider.Instance.FindFile($"{PluginID.IDtoString(plugin.ID) + plugin.Name}.pdex") != null)
                {
                    return 1;
                }

                foreach (var prm in plugin.Permissions)
                {
                    data.Permissions.Add(new PluginData.PermissionSet()
                    {
                        Enabled = true,
                        Permission = prm
                    });
                }
                StorageProvider.Instance.SaveDataToXml(data, $"{PluginID.IDtoString(plugin.ID) + plugin.Name}.pdex", "\\plugins\\data");
                return 1; 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"PluginSystem",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return 0;
            }
        }

        public byte UpdatePlugin(string key, PluginData data)
        {
            try
            {
                var existingPluginData = GetPluginData(key);

                if (existingPluginData == null) throw new PluginDataNotFoundException();
                if (existingPluginData.Equals(data)) return 1;

                if (existingPluginData.spValues != data.spValues) throw new NotChangebleDataRequestException();
                if (existingPluginData.FileFormatClearifier != data.FileFormatClearifier) throw new NotChangebleDataRequestException();

                var file = StorageProvider.Instance.FindFile(key + ".pdex");
                File.Delete(file.Path);

                StorageProvider.Instance.SaveDataToXml(data, key, "\\plugins\\data");

                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PluginSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public byte DeletePlugin(string key)
        {
            var file = StorageProvider.Instance.FindFile(key + ".pdex");

            if (file is not null)
            {
                File.Delete(file.Path);
                return 1;
            }

            return 0;
        }

        public PluginData GetPluginData(string key)
        {
            var file = StorageProvider.Instance.FindFile(key + ".pdex");

            if(file is not null)
            {
                var pluginData = StorageProvider.Instance.GetDataFromFile<PluginData>(key + ".pdex", "\\plugins\\data");
                return pluginData;
            }

            return null;
        }
    }
}
