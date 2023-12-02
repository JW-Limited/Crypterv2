using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LILO_Packager.v2.Cloud.Storage
{
    public class LocalCloudMatrixFile
    {
        public Matrix MatrixDetail { get; set; }
        public List<MatrixEntry> MatrixEntrys { get; set; }

        public void SerializeToXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(LocalCloudMatrixFile));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, this);
            }
        }

        public static LocalCloudMatrixFile DeserializeFromXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(LocalCloudMatrixFile));
            using (TextReader reader = new StreamReader(filePath))
            {
                return (LocalCloudMatrixFile)serializer.Deserialize(reader);
            }
        }
    }

    public class Matrix
    {
        public string Version { get; set; }
        public string SchemeVersion { get; set; }
        public DateTime CreationDate { get; set; }
        public MatrixIdentifier MatrixVerifier { get; set; }
    }

    public class MatrixIdentifier
    {
        public string Name { get; set; }
        public string PublicKey { get; set; }
        public string MatrixHash { get; set; }
    }

    public class MatrixEntry
    {
        public LocalFile File { get; set; }
        public FileIdentity Identity { get; set; }
        public CloudPlace CloudEntry { get; set; }
    }

    public class LocalFile
    {
        public string FileName { get; set; }
        public string DirectoryPath { get; set; }
        public string RealPath { get; set; }
    }

    public class FileIdentity
    {
        public string FileHash { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class CloudPlace
    {
        public string FileUrl { get; set; }
        public string PublicFileId { get; set; }
    }


    public class FileIndexStorage 
    {
        public static FileIndexStorage Instance => _localInstance.Value;
        private static Lazy<FileIndexStorage> _localInstance = new Lazy<FileIndexStorage>();

        public FileIndexStorage()
        {
            CreateDirectoryRecursively(DefaultIndexPath);
        }

        private string DefaultIndexPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Crypterv2\\CCS_Service\\";
        private string DefaultIndexFilePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Crypterv2\\CCS_Service\\Registry";

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

        public LocalCloudMatrixFile GetMatrixFile()
        {
            try
            {
                return LocalCloudMatrixFile.DeserializeFromXml(DefaultIndexFilePath);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void CreateMatrixFile()
        {
            if (File.Exists(DefaultIndexFilePath))
            {
                File.Move(DefaultIndexFilePath, DefaultIndexPath + "_old");
            }


            LocalCloudMatrixFile matrixFile;
            matrixFile = new LocalCloudMatrixFile();
            matrixFile.MatrixDetail = new Matrix()
            {
                CreationDate = DateTime.Now.ToLocalTime(),
                SchemeVersion = "1-alpha-app/x",
                MatrixVerifier = new MatrixIdentifier()
                {
                    Name = "CloudFiles",
                    PublicKey = "F4-F0-DE-65-A2-D1-DE-EF-1F-FE-A2-5E-93-70-67-C9",
                    MatrixHash = "null"
                }
            };

            matrixFile.MatrixEntrys = new List<MatrixEntry>();

            matrixFile.SerializeToXml(DefaultIndexFilePath);
        }

        public void AddMatrixEntry(MatrixEntry entry)
        {
            LocalCloudMatrixFile matrixFile;

            if(File.Exists(DefaultIndexFilePath))
            {
                matrixFile = LocalCloudMatrixFile.DeserializeFromXml(DefaultIndexFilePath);
            }
            else
            {
                matrixFile = new LocalCloudMatrixFile();
                matrixFile.MatrixDetail = new Matrix()
                {
                    CreationDate = DateTime.Now.ToLocalTime(),
                    SchemeVersion = "1-alpha-app/x",
                    MatrixVerifier = new MatrixIdentifier()
                    {
                        Name = "CloudFiles",
                        PublicKey = "F4-F0-DE-65-A2-D1-DE-EF-1F-FE-A2-5E-93-70-67-C9",
                        MatrixHash = "null"
                    }
                };

                matrixFile.MatrixEntrys = new List<MatrixEntry>();
            }

            matrixFile.MatrixEntrys.Add(entry);
            matrixFile.SerializeToXml(DefaultIndexFilePath);

        }
    }
}

