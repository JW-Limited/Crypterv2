using Crypterv2.DevTool.Core.Plugins.Types;
using Crypterv2_DevTool.Core.Forms;
using System.Xml;

namespace Crypterv2.DevTool.Core.Plugins
{
    public class PluginConfigManager
    {
        public readonly string _pluginConfigsPath = "C:\\ProgramData\\JW Limited\\Cryptex\\Devtool\\pluginConfigs";
        public string _pluginConfigPath;
        private readonly string _pluginName;
        private readonly Dictionary<string, PluginConfig> _plugins;
        public PluginConfig pluginConfig;

        public PluginConfigManager(string PluginName, PluginConfig pluginConfig)
        {
            this._pluginName = PluginName;
            this.pluginConfig = pluginConfig;

            uiTestPlugin.Instance().manager.pluginPaths.TryGetValue(uiTestPlugin.Instance().SelectedPlugin.PluginBase, out string dllFile);

            _pluginConfigPath = _pluginConfigsPath + "\\" + LILO_Packager.v2.Plugins.ThirdParty.Types.Plugin.GetTempDirectoryName(dllFile);

            CreateDirectoryRecursively(_pluginConfigPath);
        }

        public static void CreateDirectoryRecursively(string path)
        {
            string[] pathComponents = path.Split(Path.DirectorySeparatorChar);

            string currentDirectory = "";
            foreach (string pathComponent in pathComponents)
            {
                currentDirectory = Path.Combine(currentDirectory, pathComponent);

                if (!Directory.Exists(currentDirectory))
                {
                    Directory.CreateDirectory(currentDirectory);
                }
            }
        }

        public bool CheckForExistingConfigs()
        {
            if (File.Exists(_pluginConfigPath + $"\\{_pluginName}.excfg")) return true;
            else
            {
                return false;
            }
        }

        public void SavePluginConfig()
        {
            using (var writer = XmlWriter.Create(_pluginConfigPath + $"\\{_pluginName}.excfg" , new XmlWriterSettings { Indent = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("PluginConfig");

                writer.WriteElementString("Name", pluginConfig.Name);
                writer.WriteElementString("Version", pluginConfig.Version);
                writer.WriteElementString("Description", pluginConfig.Description);
                writer.WriteElementString("Changes", pluginConfig.Changes);
                writer.WriteElementString("State", pluginConfig.State);
                writer.WriteElementString("PluginIcon", pluginConfig.PluginIcon);

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

            if (File.Exists(pluginConfig.PluginIcon))
            {
                File.Copy(pluginConfig.PluginIcon, _pluginConfigPath + "\\backup_EX_ICON_" + new FileInfo(pluginConfig.PluginIcon).Name);
            }
        }

        public PluginConfig ReadPluginConfig()
        {
            PluginConfig pluginConfig = null;

            if (File.Exists(this._pluginName))
            {
                using (var reader = XmlReader.Create(this._pluginName))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            switch (reader.Name)
                            {
                                case "Name":
                                    pluginConfig.Name = reader.ReadString();
                                    break;
                                case "Version":
                                    pluginConfig.Version = reader.ReadString();
                                    break;
                                case "Description":
                                    pluginConfig.Description = reader.ReadString();
                                    break;
                                case "Changes":
                                    pluginConfig.Changes = reader.ReadString();
                                    break;
                                case "State":
                                    pluginConfig.State = reader.ReadString();
                                    break;
                                case "PluginIcon":
                                    pluginConfig.PluginIcon = reader.ReadString();
                                    break;
                            }
                        }
                    }
                }
            }

            return pluginConfig;
        }
    }
}
