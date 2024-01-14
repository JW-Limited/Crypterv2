using Crypterv2.DevTool.Core.Plugins.Types;
using Crypterv2_DevTool.Core.Forms;
using LILO_Packager.v2.Plugins.PluginCore;
using System.Reflection;
using System.Xml;

namespace Crypterv2.DevTool.Core.Plugins.Config
{

    public class PluginConfigManager
    {
        public readonly string _pluginConfigsPath = "C:\\ProgramData\\JW Limited\\Cryptex\\Devtool\\pluginConfigs";
        public readonly string _pluginConfigPath;
        public readonly string _pluginDependencieConfigs;
        private readonly string _pluginName;
        private readonly Dictionary<string, PluginConfig> _plugins;
        public PluginConfig pluginConfig;

        public PluginConfigManager(string PluginName, PluginConfig pluginConfig)
        {
            _pluginName = PluginName;
            this.pluginConfig = pluginConfig ?? new PluginConfig();

            uiPluginKit.Instance().PluginBaseManager.pluginPaths.TryGetValue(((IPluginBase)uiPluginKit.Instance().SelectedPlugin), out string dllFile);

            _pluginConfigPath = _pluginConfigsPath + "\\" + LILO_Packager.v2.Plugins.ThirdParty.Types.Plugin.GetTempDirectoryName(dllFile);
            _pluginDependencieConfigs = _pluginConfigPath + "\\dependencieAlloc";

            CreateDirectoryRecursively(_pluginConfigPath);
            CreateDirectoryRecursively(_pluginDependencieConfigs);
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

        private bool CheckForExistingConfigs()
        {
            if (File.Exists(_pluginConfigPath + $"\\{_pluginName}.excfg")) return true;
            else
            {
                return false;
            }
        }

        public InitializationResponse TryGetExistingConfigs()
        {
            var config = new InitializationResponse();

            if (CheckForExistingConfigs())
            {
                config.PluginConfig = ReadPluginConfig();

                foreach (var file in Directory.GetFiles(_pluginConfigPath))
                {
                    if (new FileInfo(file).Name.StartsWith("backup_EX_ICON_")) config.PluginIcon = new FileInfo(file).FullName;
                    else continue;
                }

                var listDepend = new HashSet<DependencieConfig>();

                foreach (var file in Directory.GetFiles(_pluginDependencieConfigs))
                {
                    var tempDeoend = DependencieConfig.DeserializeFromXml(file);

                    if (tempDeoend != null)
                    {
                        listDepend.Add(tempDeoend);
                    }
                }

                config.Dependencies = listDepend;
                config.Success = true;
                config.EndCode = DevToolCodes.SuccessfullSerialized;
                return config;
            }
            else
            {
                config.Success = false;
                config.Message = "The PackageConfigManager didnt found any configs.";
                config.EndCode = DevToolCodes.NoPreSavedConfigsFound;
                config.ErrorCode = 0;

                return config;
            }
        }

        public void SavePluginConfig()
        {
            using (var writer = XmlWriter.Create(_pluginConfigPath + $"\\{_pluginName}.excfg", new XmlWriterSettings { Indent = true }))
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
                foreach(var item in Directory.GetFiles(_pluginConfigPath))
                {
                    if(new FileInfo(item).Name.StartsWith("backup_EX_ICON_")) File.Delete(item);
                }

                File.Copy(pluginConfig.PluginIcon, _pluginConfigPath + "\\backup_EX_ICON_" + new FileInfo(pluginConfig.PluginIcon).Name);
            }

            if (Directory.GetFiles(_pluginDependencieConfigs).Length > 0)
            {
                foreach (var item in Directory.GetFiles(_pluginDependencieConfigs))
                {
                    File.Delete(item);
                }
            }

            foreach (var item in uiPluginKit.Instance().Dependencies)
            {
                var asy = new AssemblyResponse();

                if (item.EndsWith(".dll"))
                {
                    asy = PackageManager.GetAssemblyInfo(item);

                    var depend = new DependencieConfig()
                    {
                        FilePath = item,
                        Type = GetFileType(new FileInfo(item).Extension),
                        Name = asy.LoadedAssymblyName.Name ?? new FileInfo(item).Name,
                        DevtoolManager = DevtoolManager.Default,
                        Version = asy.LoadedAssymblyName.Version.ToString() ?? "1",
                        IsIndispensible = true
                    };

                    depend.SerializeToXml(_pluginDependencieConfigs + "\\" + depend.Name + ".dpcfg");
                }
                else
                {
                    var depend = new DependencieConfig()
                    {
                        FilePath = item,
                        DevtoolManager = DevtoolManager.Default,
                        Type = GetFileType(new FileInfo(item).Extension),
                        Name = new FileInfo(item).Name,
                        Version = "1",
                        IsIndispensible = false
                    };

                    depend.SerializeToXml(_pluginDependencieConfigs + "\\" + depend.Name + ".dpcfg");
                }


            }

        }

        public void TryDeleteConfigs()
        {
            if (CheckForExistingConfigs())
            {
                Directory.Delete(_pluginConfigPath, true);
            }
        }

        public void TryDeleteDependencies()
        {
            if (CheckForExistingConfigs())
            {
                Directory.Delete(_pluginDependencieConfigs, true);
            }
        }

        public PluginConfig ReadPluginConfig()
        {
            PluginConfig pluginConfig = new PluginConfig();

            if (File.Exists(_pluginConfigPath + $"\\{_pluginName}.excfg"))
            {
                using (var reader = XmlReader.Create(_pluginConfigPath + $"\\{_pluginName}.excfg"))
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

        private string GetFileType(string type)
        {
            var fileTypes = new Dictionary<string, string>()
            {
                { ".dll", "Library" },
                { ".pdb", "Library" },
                { ".exe", "Application" },
                { ".msix", "Application" },
                { ".com", "Application" },
                { ".png", "MediaResource" },
                { ".jpg", "MediaResource" },
                { ".ico", "MediaResource" },
                { ".config", "Configuration File" },

                // Document files
                { ".pdf", "Document" },
                { ".docx", "Document" },
                { ".xlsx", "Spreadsheet" },
                { ".pptx", "Presentation" },
                { ".txt", "Text File" },
                { ".odt", "Open Document Text" },
                { ".ods", "Open Document Spreadsheet" },
                { ".epub", "E-Book" },
                { ".mobi", "E-Book" },
                { ".rtf", "Rich Text Format" },
                { ".tex", "LaTeX Document" },
                { ".cryptex", "Crypterv2 Extension" },

                // Audio files
                { ".mp3", "Audio" },
                { ".wav", "Audio" },
                { ".flac", "Audio" },
                { ".ogg", "Audio" },
                { ".aac", "Audio" },
                { ".m4a", "Audio" },

                // Video files
                { ".mp4", "Video" },
                { ".avi", "Video" },
                { ".mkv", "Video" },
                { ".mov", "Video" },
                { ".webm", "Video" },
                { ".mpeg", "Video" },
                { ".mpg", "Video" },
                { ".ts", "Video" },
                { ".m2ts", "Video" },

                // Compressed files
                { ".zip", "Compressed File" },
                { ".rar", "Compressed File" },
                { ".7z", "Compressed File" },
                { ".gz", "Compressed File" },
                { ".bz2", "Compressed File" },
                { ".tar", "Compressed File" },

                { ".html", "Web Page" },
                { ".css", "Cascading Style Sheet" },
                { ".js", "JavaScript" },
                { ".json", "JavaScript Object Notation" },
                { ".csv", "Comma-Separated Values" },
                { ".sql", "Structured Query Language" },
                { ".jar", "Java Archive" },
                { ".war", "Web Application Archive" },
                { ".apk", "Android Package Kit" },
                { ".ipa", "iOS App" },
                { ".dmg", "Disk Image" },
                { ".iso", "Disc Image" },
                { ".vbs", "Visual Basic Script" },
                { ".bat", "Batch File" },
                { ".ps1", "PowerShell Script" },
                { ".xml", "Extensible Markup Language" },
                { ".yaml", "YAML Ain't Markup Language" },
                { ".json5", "JSON5" },
                { ".ini", "Initialization File" },
                { ".log", "Log File" },
            };

            if (fileTypes.ContainsKey(type))
            {
                try
                {
                    return fileTypes[type];
                }
                catch (Exception)
                {
                    return "Unknown";
                }
            }

            return "Unknown";
        }
    }
}
