using LILO_Packager.v2.Core.LILO.Types;
using System.IO.Compression;
using System.Xml.Serialization;

namespace LILO_Packager.v2.Cloud.Storage
{
    public partial class MatrixShareManager
    {
        public static byte CheckIfEntryExist(string file,string hash)
        {
            using (var zipFile = ZipFile.Open(file, ZipArchiveMode.Read))
            {
                var zz = zipFile.GetEntry(hash);
                if (zz is not null) return 1;
                else return 0;
            }
        }

        public static CDEX_FILE_DECLARATION GetPackageDeclaration(string file)
        {
            using(var zipFile = ZipFile.Open(file, ZipArchiveMode.Read))
            {
                var zz = zipFile.GetEntry("CDEX_FILE_DECLARATION.cdex.info");

                XmlSerializer serializer = new XmlSerializer(typeof(CDEX_FILE_DECLARATION));
                using (Stream reader = zz.Open())
                {
                    return (CDEX_FILE_DECLARATION)serializer.Deserialize(reader);
                }
            }
        }

        public static User GetFileOwner(CDEX_FILE_DECLARATION file, string zipFile,string Hash)
        {
            foreach(var item in file.ArchieveEntries)
            {
                if (item.StartsWith(Hash) && item.EndsWith("user.laex"))
                {
                    using (var zFile = ZipFile.Open(zipFile, ZipArchiveMode.Read))
                    {
                        var zz = zFile.GetEntry(item);

                        XmlSerializer serializer = new XmlSerializer(typeof(User));
                        using (Stream reader = zz.Open())
                        {
                            return (User)serializer.Deserialize(reader);
                        }
                    }
                }
            }

            return null;
        }

        public static byte ExportMatrixEntry(MatrixEntry entry, User user,Bitmap preview,bool secure = false,bool encrypt = false, string password = "")
        {
            if(entry is null) throw new MatrixEntryNullException(nameof(entry));
            try
            {
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    CheckWriteAccess = true,
                    AddExtension = true,
                    RestoreDirectory = true,
                    DefaultExt = ".cdex",
                    Filter = "Cloud Shareble Object |*.cdex",
                };

                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    user.Password = "";
                    SerializeToXml(entry, sfd.FileName + "~");
                    SerializeToXml(user, sfd.FileName + "~User");
                    SerializeToXml(new CDEX_DECLARATION(), sfd.FileName + "~cdex_dec");
                    preview.Save(sfd.FileName + "~preview");

                    var indexCDEX = new CDEX_FILE_DECLARATION();
                    indexCDEX.MatrixEntries.Add(entry);

                    using(var archieve = ZipFile.Open(sfd.FileName, ZipArchiveMode.Create))
                    {
                        archieve.CreateEntryFromFile(sfd.FileName + "~", $"{entry.Identity.FileHash}/entry.cdcex",CompressionLevel.SmallestSize);
                        archieve.CreateEntryFromFile(sfd.FileName + "~User", $"{entry.Identity.FileHash}/user.laex", CompressionLevel.SmallestSize);
                        archieve.CreateEntryFromFile(sfd.FileName + "~preview", $"{entry.Identity.FileHash}/preview.png", CompressionLevel.SmallestSize);

                        archieve.CreateEntryFromFile(sfd.FileName + "~cdex_dec", $"file.cdex", CompressionLevel.SmallestSize);

                    }

                    using(var archieve = ZipFile.Open(sfd.FileName, ZipArchiveMode.Update))
                    {
                        foreach(var item in archieve.Entries)
                        {
                            indexCDEX.ArchieveEntries.Add(item.FullName);
                        }

                        indexCDEX.Hash256 = indexCDEX.GetHashCode().ToString().Replace("-","");

                        if (secure)
                        {
                            indexCDEX.PasswordSecured = true;
                            indexCDEX.PasswordEnc = Core.Service.Services.Base.EncryptString(password, "lilo--dd--dd--sfsf--crypter-89862387346785238||@");
                        }

                        SerializeToXml(indexCDEX,sfd.FileName + "~cdex_index");

                        archieve.CreateEntryFromFile(sfd.FileName + "~cdex_index", "CDEX_FILE_DECLARATION.cdex.info");
                    }


                    File.Delete(sfd.FileName + "~cdex_index");
                    File.Delete(sfd.FileName + "~cdex_dec");
                    File.Delete(sfd.FileName + "~preview");
                    File.Delete(sfd.FileName + "~User");
                    File.Delete(sfd.FileName + "~");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"LILO Cloud",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return 0;
            }

            return 1;
        }

        public static byte AddEntryToPackage(MatrixEntry entry, 
                                             User user, 
                                             Bitmap preview, 
                                             bool encrypt = false,
                                             string password = "")
        {
            if (entry is null) throw new MatrixEntryNullException(nameof(entry));
            try
            {
                OpenFileDialog sfd = new OpenFileDialog()
                {
                    AddExtension = true,
                    RestoreDirectory = true,
                    DefaultExt = ".cdex",
                    Filter = "Cloud Shareble Object |*.cdex",
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    user.Password = "";
                    SerializeToXml(entry, sfd.FileName + "~");
                    SerializeToXml(user, sfd.FileName + "~User");
                    SerializeToXml(new CDEX_DECLARATION(), sfd.FileName + "~cdex_dec");
                    preview.Save(sfd.FileName + "~preview");

                    using (var archieve = ZipFile.Open(sfd.FileName, ZipArchiveMode.Update))
                    {
                        archieve.CreateEntryFromFile(sfd.FileName + "~", $"{entry.Identity.FileHash}/entry.cdcex", CompressionLevel.SmallestSize);
                        archieve.CreateEntryFromFile(sfd.FileName + "~User", $"{entry.Identity.FileHash}/user.laex", CompressionLevel.SmallestSize);
                        archieve.CreateEntryFromFile(sfd.FileName + "~preview", $"{entry.Identity.FileHash}/preview.png", CompressionLevel.SmallestSize);
                        archieve.CreateEntryFromFile(sfd.FileName + "~cdex_dec", $"file.cdex", CompressionLevel.SmallestSize);
                    }

                    
                    File.Delete(sfd.FileName + "~cdex_dec");
                    File.Delete(sfd.FileName + "~preview");
                    File.Delete(sfd.FileName + "~User");
                    File.Delete(sfd.FileName + "~");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LILO Cloud", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            return 1;
        }

        public static byte ExportMatrixEntries(User user, 
            Bitmap preview, 
            List<MatrixEntry> entrys, 
            bool secure = false, 
            string password = "", 
            bool encrypt = false)
        {
            if (entrys is null) throw new MatrixEntryNullException(nameof(entrys));
            try
            {
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    CheckWriteAccess = true,
                    AddExtension = true,
                    RestoreDirectory = true,
                    DefaultExt = ".cdex",
                    Filter = "Cloud Shareble Object |*.cdex",
                };



                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    var indexCDEX = new CDEX_FILE_DECLARATION();

                    using (var archieve = ZipFile.Open(sfd.FileName, ZipArchiveMode.Create))
                    {
                        SerializeToXml(new CDEX_DECLARATION(), sfd.FileName + "~cdex_dec");

                        foreach (var entry in entrys)
                        {
                            if (archieve is null) throw new ArgumentNullException(nameof(archieve));
                            if (entry is null) continue;


                            indexCDEX.MatrixEntries.Add(entry);

                            user.Password = "";
                            SerializeToXml(entry, sfd.FileName + "~");
                            SerializeToXml(user, sfd.FileName + "~User");
                            preview.Save(sfd.FileName + "~preview");

                            archieve.CreateEntryFromFile(sfd.FileName + "~", $"{entry.Identity.FileHash}/entry.cdcex", CompressionLevel.SmallestSize);
                            archieve.CreateEntryFromFile(sfd.FileName + "~User", $"{entry.Identity.FileHash}/user.laex", CompressionLevel.SmallestSize);
                            archieve.CreateEntryFromFile(sfd.FileName + "~preview", $"{entry.Identity.FileHash}/preview.png", CompressionLevel.SmallestSize);


                            File.Delete(sfd.FileName + "~preview");
                            File.Delete(sfd.FileName + "~User");
                            File.Delete(sfd.FileName + "~");
                        }
                        archieve.CreateEntryFromFile(sfd.FileName + "~cdex_dec", $"file.cdex", CompressionLevel.SmallestSize);

                        File.Delete(sfd.FileName + "~cdex_dec");
                    }

                    using (var archieve = ZipFile.Open(sfd.FileName, ZipArchiveMode.Update))
                    {
                        foreach (var item in archieve.Entries)
                        {
                            indexCDEX.ArchieveEntries.Add(item.FullName);
                        }

                        indexCDEX.Hash256 = indexCDEX.GetHashCode().ToString();

                        if (secure)
                        {
                            indexCDEX.PasswordSecured = true;
                            indexCDEX.PasswordEnc = Core.Service.Services.Base.EncryptString(password,password);
                        }

                        SerializeToXml(indexCDEX, sfd.FileName + "~cdex_index");

                        archieve.CreateEntryFromFile(sfd.FileName + "~cdex_index", "CDEX_FILE_DECLARATION.cdex.info");
                    }

                    File.Delete(sfd.FileName + "~cdex_index");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.Source + ex.StackTrace, "LILO Cloud", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            return 1;
        }

        private static void SerializeToXml<T>(T data,string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, data);
            }
        }
    }
}
