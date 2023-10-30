using Crypterv2.DevTool.Core.Plugins.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Crypterv2.DevTool.Core.Plugins
{
    public class PluginConfigManager
    {
        private readonly string xmlFilePath;

        public PluginConfigManager(string xmlFilePath)
        {
            this.xmlFilePath = xmlFilePath;
        }

        public void SavePluginConfig(PluginConfig pluginConfig)
        {
            using (var writer = XmlWriter.Create(this.xmlFilePath, new XmlWriterSettings { Indent = true }))
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
        }

        public PluginConfig ReadPluginConfig()
        {
            PluginConfig pluginConfig = null;

            if (File.Exists(this.xmlFilePath))
            {
                using (var reader = XmlReader.Create(this.xmlFilePath))
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
