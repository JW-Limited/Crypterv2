using LILO_Packager.v2.Cloud;
using LILO_Packager.v2.Cloud.Storage;
using LILO_Packager.v2.Plugins.Internal;
using System.Xml.Serialization;

namespace LILO_Packager.v2.Shared
{
    public class StorageProvider
    {
        public static StorageProvider Instance {
            get
            {
                if(_instance == null)
                {
                    throw new NotInitializedException();
                }

                return _instance;
            }
            private set
            {
                if (value == null) { throw new ArgumentNullException(); }

                var instance = value as StorageProvider;

                if(_instance != instance)
                {
                    _instance = value;
                }
            } 
        }
        private static StorageProvider _instance = null;


        public static async Task<StorageProvider> Create(string Directory) 
        {
            var storageInstance = new StorageProvider();
            storageInstance.ServedDirectory = Directory;
            var IFiles = await storageInstance.IndexFiles();
            storageInstance.IndexedFiles = IFiles;

            _instance = storageInstance;
            return storageInstance;
        }

        public class IndexedFile
        {
            public string Name { get; set; }
            public string Path { get; set; }
            public string Sha256 { get; set; }
        }

        public class IndexFile
        {
            public FileFormatClearifier FileFormatClearifier { get; set; } = new FileFormatClearifier()
            {
                ExtensionPrefix = ".find",
                FriendlyName = "Find Protokol Data",
                Description = "An file with all indexed Files in on directory.",
                SchemeUri = "https://beta.lilo.com/schemes/indexing/1",
                FormatVersion = "1.0"
            };

            public List<IndexedFile> IndexedFiles { get; set; } = new List<IndexedFile>();
        }

        public string ServedDirectory;
        public readonly object lockInstance = new object();
        public FileSystemWatcher FileSystemWatcher { get; set; }
        public List<IndexedFile> IndexedFiles { get; set; } = new List<IndexedFile>();

        public async Task<List<IndexedFile>> IndexFiles()
        {
            if (string.IsNullOrEmpty(ServedDirectory) || !Directory.Exists(ServedDirectory))
            {
                throw new InvalidOperationException("Invalid ServedDirectory");
            }

            var files = new List<IndexedFile>();
            await Task.Run(async () =>
            {
                try
                {
                    var tasks = Directory.EnumerateFiles(ServedDirectory, "*", SearchOption.AllDirectories)
                                         .Select(file => GetIndexedFileInfoAsync(file))
                                         .ToList();

                    await Task.WhenAll(tasks);
                    files.AddRange(tasks.Select(t => t.Result));

                    SaveDataToXml(new IndexFile { IndexedFiles = files }, "__index__crypterv2.find", "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "StorageProvider - Index");
                }
            });
            

            FileSystemWatcher = new FileSystemWatcher(ServedDirectory);
            FileSystemWatcher.Created += FileSystemWatcher_Created;
            FileSystemWatcher.EnableRaisingEvents = true;
            FileSystemWatcher.IncludeSubdirectories = true;

            return files;
        }

        private async Task<IndexedFile> GetIndexedFileInfoAsync(string file)
        {
            var indexedFile = new IndexedFile
            {
                Name = new FileInfo(file).Name,
                Path = file
            };

            try
            {
                indexedFile.Sha256 = CloudSyncroniztationBase.GetFileHash(file);
            }
            catch (Exception)
            {
                indexedFile.Sha256 = "error";
            }

            return indexedFile;
        }

        private void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            try
            {
                if (System.IO.File.Exists(e.FullPath))
                {
                    var file = new IndexedFile()
                    {
                        Name = new FileInfo(e.FullPath).Name,
                        Path = e.FullPath,
                    };

                    try
                    {
                        file.Sha256 = CloudSyncroniztationBase.GetFileHash(e.FullPath);
                    }
                    catch (Exception)
                    {
                        file.Sha256 = "error";
                    }

                    IndexedFiles.Add(file);


                    SaveDataToXml(new IndexFile()
                    {
                        IndexedFiles = this.IndexedFiles
                    }, "__index__crypterv2.find", "");
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "StorageProvider - FSW");
            }
            
        }

        public IndexedFile FindFile(string fileName)
        {
            if (IndexedFiles is null) throw new NotInitializedException();

            foreach(var files in IndexedFiles)
            {
                if(files.Name == fileName) return files;
            }

            return null;
        }

        public void SaveDataToXml<T>(T data, string key, string directory ,bool Override = true)
        {
            lock (lockInstance)
            {
                var filePath = Path.Combine(ServedDirectory + directory, key);
                if (!Directory.Exists(ServedDirectory + directory))
                {
                    FileOperations.CreateDirectoryRecursively(ServedDirectory + directory);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (TextWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, data);
                }
            }
            
        }

        public T GetDataFromFile<T>(string key, string directory)
        {
            lock(lockInstance)
            {
                var filePath = Path.Combine(ServedDirectory + directory, key);

                if (!File.Exists(filePath)) throw new FileNotFoundException();

                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (TextReader reader = new StreamReader(filePath))
                {
                    return (T)serializer.Deserialize(reader);
                }
            }
            
        }
    }
}
