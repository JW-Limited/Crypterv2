using LILO_Packager.v2.Core.Updates;
using LILO_WebEngine.Core.Handler;
using System.Reflection;
using System.Security.Cryptography;
using System.Xml.Serialization;
using Telerik.WinControls;
using WinRT;

namespace LILO_Packager.v2.Plugins.PluginCore
{
    public class PluginManagerv2
    {
        public string PluginManagerIndexFile;
        private HashSet<String> DirectoryPaths = new HashSet<string>();
        public string PluginManagerIndexDirectory = ".\\pluginManager";
        public string PluginManagerIndexFileName = "Crypterv2PluginIndex.cif";
        public HashSet<IPluginBase> CurrentPlugins = new HashSet<IPluginBase>();
        public Dictionary<IPluginBase, string> pluginPaths = new Dictionary<IPluginBase, string>();

        public PluginManagerv2(String DirectoryPath)
        {
            DirectoryPaths.Add(DirectoryPath);
            PluginManagerIndexFile = PluginManagerIndexDirectory + "\\" + PluginManagerIndexFileName;
            CreateDirectoryRecursively(PluginManagerIndexDirectory);
        }

        public PluginManagerv2(List<String> DirectoryPaths)
        {
            this.DirectoryPaths = new HashSet<string>(DirectoryPaths);
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

        public string GetPluginHash(string pluginFile)
        {
            var hashBytes = SHA256.HashData(File.ReadAllBytes(pluginFile));
            var hashString = BitConverter.ToString(hashBytes).Replace("-", "").Substring(0, 16);
            var fileName = Path.GetFileNameWithoutExtension(pluginFile);
            return hashString + fileName;
        }

        private bool CheckForExistingConfigs()
        {
            if (File.Exists(PluginManagerIndexFile)) return true;
            else
            {
                return false;
            }
        }

        public async Task<PluginScannerResponse> Scan()
        {
            var response = new PluginScannerResponse();
            

            if (CheckForExistingConfigs())
            {
                await Task.Run(() =>
                {
                    var indexFile = PluginManagerIndex.DeserializeFromXml(PluginManagerIndexFile);
                    if (VersionComparer.CompareSemanticVersions(Program.Version, indexFile.PluginManagerVersion).IsNewer)
                    {
                        throw new NotSupportedException();
                    }

                    if (new FileInfo(PluginManagerIndexFile).Directory.FullName != indexFile.Directory)
                    {
                        throw new InvalidDataException();
                    }

                    foreach (var dirE in DirectoryPaths)
                    {
                        DirectoryInfo dir = new DirectoryInfo(dirE);

                        foreach (FileInfo file in dir.GetFiles("*.dll"))
                        {
                            Assembly ass = Assembly.LoadFrom(file.FullName);
                            foreach (Type t in ass.GetTypes())
                            {
                                if ((t.IsSubclassOf(typeof(IPluginBase)) || t.GetInterfaces().Contains(typeof(IPluginBase))) && t.IsAbstract == false)
                                {
                                    IPluginBase? b = t.InvokeMember(null,
                                                        BindingFlags.CreateInstance, null, null, null) as IPluginBase;


                                    CurrentPlugins.Add(b);
                                    pluginPaths.Add(b, file.FullName);

                                    if (b != null)
                                    {
                                        foreach (var plugin in indexFile.Plugins)
                                        {
                                            if (b.Name == plugin.Name)
                                            {
                                                if (b.Version != plugin.Version || GetPluginHash(file.FullName) != plugin.Identifier)
                                                {
                                                    response.PluginsChanged = true;

                                                    response.ChangedPlugins.Add(new ChangedPluginEntry()
                                                    {
                                                        Plugin = new PluginIndexEntry()
                                                        {
                                                            DllFile = file.FullName,
                                                            Identifier = GetPluginHash(file.FullName),
                                                            Name = plugin.Name,
                                                            Version = plugin.Version,
                                                        },
                                                        State = ChangedState.Updated
                                                    });
                                                }
                                            }

                                        }
                                    }

                                }
                            }

                        }
                    }
                });

                return response;
            }
            else
            {
                await Task.Run(() =>
                {
                    CurrentPlugins = new HashSet<IPluginBase>();

                    foreach (var ele in DirectoryPaths)
                    {
                        DirectoryInfo dir = new DirectoryInfo(ele);

                        foreach (FileInfo file in dir.GetFiles("*.dll"))
                        {
                            Assembly ass = Assembly.LoadFrom(file.FullName);
                            foreach (Type t in ass.GetTypes())
                            {
                                if ((t.IsSubclassOf(typeof(IPluginBase)) || t.GetInterfaces().Contains(typeof(IPluginBase))) && t.IsAbstract == false)
                                {
                                    IPluginBase? b = t.InvokeMember(null,
                                                        BindingFlags.CreateInstance, null, null, null) as IPluginBase;

                                    CurrentPlugins.Add(b);
                                    pluginPaths.Add(b, file.FullName);
                                }
                            }

                        }

                    }

                    var plugins = new HashSet<PluginIndexEntry>();

                    foreach (var plugin in CurrentPlugins)
                    {
                        pluginPaths.TryGetValue(plugin, out string path);

                        plugins.Add(new PluginIndexEntry()
                        {
                            Name = plugin.Name,
                            Version = plugin.Version,
                            DllFile = path,
                            Identifier = GetPluginHash(path)
                        });
                    }

                    var indexFile = new PluginManagerIndex()
                    {
                        PluginManagerVersion = Program.Version,
                        LastChecked = DateTime.Now.ToLocalTime(),
                        Directory = Application.ExecutablePath.Replace("crypterv2.exe","") + "pluginManager",
                        IndexFileVersion = "1",
                        Plugins = plugins
                    };

                    indexFile.SerializeToXml(PluginManagerIndexFile);

                    return null;
                });

            }

            return null;
        }
    }
    public class PluginManagerIndex
    {
        public string PluginManagerVersion { get; set; }
        public string IndexFileVersion { get; set; }
        public string Directory { get; set; }
        public DateTime LastChecked { get; set; }
        public HashSet<PluginIndexEntry> Plugins { get; set; }

        public void SerializeToXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PluginManagerIndex));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, this);
            }
        }

        public static PluginManagerIndex DeserializeFromXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PluginManagerIndex));
            using (TextReader reader = new StreamReader(filePath))
            {
                return (PluginManagerIndex)serializer.Deserialize(reader);
            }
        }
    }

    public class PluginIndexEntry
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string DllFile { get; set; }
        public string Identifier { get; set; }
    }

    public class ChangedPluginEntry
    {
        public PluginIndexEntry Plugin { get; set; } 
        public ChangedState State { get; set; }
    }

    public enum ChangedState
    {
        Removed,
        Updated,
        Added,
        Chnaged
    }

    public class PluginScannerResponse
    {
        public bool PluginsChanged { get; set; }
        public List<ChangedPluginEntry> ChangedPlugins { get; set; } = new List<ChangedPluginEntry> { };
    }
}




