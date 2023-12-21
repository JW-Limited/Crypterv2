using LILO_Packager.v2.Core.Updates;
using System.Reflection;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Serialization;

namespace LILO_Packager.v2.Plugins.PluginCore
{
    public class PluginManagerv2
    {
        // --- Plugins ---

        public HashSet<IPluginBase> Pluginsv1 = new HashSet<IPluginBase>();
        public HashSet<IPluginBasev2> PluginsV2 = new HashSet<IPluginBasev2>();

        // --- Other Variables ---

        public string PluginManagerIndexFile;
        private HashSet<String> DirectoryPaths = new HashSet<string>();
        public string PluginManagerIndexDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Crypterv2\\Extensions\\";
        public string PluginManagerIndexFileName = "Crypterv2PluginIndex.cif";
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
            if (string.IsNullOrEmpty(pluginFile))
            {
                throw new ArgumentNullException(nameof(pluginFile));
            }

            var hashBytes = SHA256.HashData(File.ReadAllBytes(pluginFile));
            var hashString = BitConverter.ToString(hashBytes).Replace("-", "").Substring(0, 16);
            var fileName = Path.GetFileNameWithoutExtension(pluginFile);
            return hashString + fileName;
        }

        public bool CheckForExistingConfigs()
        {
            if (string.IsNullOrEmpty(PluginManagerIndexFile))
            {
                throw new InvalidOperationException("PluginManagerIndexFile property is not set.");
            }

            return File.Exists(PluginManagerIndexFile);
        }


        public async Task<PluginScannerResponse> Scan()
        {
            var response = new PluginScannerResponse();
            response.ChangedPlugins = new List<ChangedPluginEntry>();

            if (CheckForExistingConfigs())
            {
                await Task.Run(() =>
                {
                    try
                    {
                        var indexFile = PluginManagerIndex.DeserializeFromXml(PluginManagerIndexFile);

                        if (VersionComparer.CompareSemanticVersions(Program.Version, indexFile.PluginManagerVersion).IsNewer)
                        {
                            throw new NotSupportedException();
                        }

                        if (new FileInfo(PluginManagerIndexFile).Directory.FullName + "\\" != indexFile.Directory)
                        {
                            throw new InvalidDataException($"Corrupt File.\n{new FileInfo(PluginManagerIndexFile).Directory.FullName} != {indexFile.Directory} --- ");
                        }

                        if (!indexFile.Validate())
                        {
                            throw new IndexFileInvalidException(PluginManagerIndexFile);
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

                                        Pluginsv1.Add(b);
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

                                    if ((t.IsSubclassOf(typeof(IPluginBasev2)) || t.GetInterfaces().Contains(typeof(IPluginBasev2))) && t.IsAbstract == false)
                                    {
                                        IPluginBasev2? b = t.InvokeMember(null,
                                                            BindingFlags.CreateInstance, null, null, null) as IPluginBasev2;

                                        b.MainHostInstance = MainHost.Instance();
                                        PluginsV2.Add(b);

                                    }
                                }

                            }
                        }

                        if (response.PluginsChanged)
                        {
                            foreach(var plugin in response.ChangedPlugins)
                            {
                                try
                                {
                                    var entry = indexFile.Plugins.FirstOrDefault(x => x.Name == plugin.Plugin.Name);
                                    indexFile.Plugins.Remove(entry);
                                }
                                catch(Exception ex)
                                {

                                }

                                indexFile.Plugins.Add(plugin.Plugin);
                            }

                            File.Delete(PluginManagerIndexFile);

                            indexFile.SerializeToXml(PluginManagerIndexFile);
                        }
                    }
                    catch (XmlException)
                    {
                        throw new IndexFileInvalidException(PluginManagerIndexFile);
                    }
                    
                });

                return response;
            }
            else
            {
                await Task.Run(() =>
                {
                    Pluginsv1 = new HashSet<IPluginBase>();

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

                                    Pluginsv1.Add(b);
                                    pluginPaths.Add(b, file.FullName);
                                    try
                                    {
                                        response.ChangedPlugins.Add(new ChangedPluginEntry()
                                        {
                                            Plugin = new PluginIndexEntry()
                                            {
                                                Name = b.Name,
                                                Version = b.Version,
                                                DllFile = file.FullName,
                                                Identifier = GetPluginHash(file.FullName)
                                            },
                                            State = ChangedState.Added
                                        });
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message + ex.Source + ex.InnerException);
                                    }
                                }

                                if ((t.IsSubclassOf(typeof(IPluginBasev2)) || t.GetInterfaces().Contains(typeof(IPluginBasev2))) && t.IsAbstract == false)
                                {
                                    IPluginBasev2? b = t.InvokeMember(null,
                                                        BindingFlags.CreateInstance, null, null, null) as IPluginBasev2;


                                    PluginsV2.Add(b);

                                }
                            }

                        }

                    }

                    var plugins = new HashSet<PluginIndexEntry>();

                    foreach (var plugin in Pluginsv1)
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
                        Directory = PluginManagerIndexDirectory,
                        IndexFileVersion = "1",
                        Plugins = plugins
                    };

                    indexFile.SerializeToXml(PluginManagerIndexFile);

                    response.PluginsChanged = true;

                    return response;
                });

                return response;
            }

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


        public bool Validate()
        {
            if (string.IsNullOrEmpty(PluginManagerVersion))
            {
                return false;
            }

            if (string.IsNullOrEmpty(IndexFileVersion))
            {
                return false;
            }

            if (string.IsNullOrEmpty(Directory))
            {
                return false;
            }

            if (Plugins == null || Plugins.Count == 0)
            {
                return false;
            }

            foreach (var pluginEntry in Plugins)
            {
                if (string.IsNullOrEmpty(pluginEntry.Name))
                {
                    return false;
                }

                if (string.IsNullOrEmpty(pluginEntry.Version))
                {
                    return false;
                }

                if (string.IsNullOrEmpty(pluginEntry.DllFile))
                {
                    return false;
                }

                if (string.IsNullOrEmpty(pluginEntry.Identifier))
                {
                    return false;
                }
            }

            return true;
        }
    }
}




