using LILO_Packager.v2.Core.LILO.Types;
using System.IO.Compression;

namespace LILO_Packager.v2.Cloud.Storage
{
    public partial class MatrixShareManager
    {
        public class Advanced
        {
            public static byte ExportMatrixEntries(User user,
            Bitmap preview,
            List<MatrixEntry> entrys,
            string file,
            bool secure = false,
            string password = "",
            bool encrypt = false)
            {
                if (entrys is null) throw new MatrixEntryNullException(nameof(entrys));
                try
                {
                    var indexCDEX = new CDEX_FILE_DECLARATION();

                    using (var archieve = ZipFile.Open(file, ZipArchiveMode.Create))
                    {
                        SerializeToXml(new CDEX_DECLARATION(), file + "~cdex_dec");

                        foreach (var entry in entrys)
                        {
                            if (archieve is null) throw new ArgumentNullException(nameof(archieve));
                            if (entry is null) continue;


                            indexCDEX.MatrixEntries.Add(entry);

                            user.Password = "";
                            SerializeToXml(entry, file + "~");
                            SerializeToXml(user, file + "~User");
                            preview.Save(file + "~preview");

                            archieve.CreateEntryFromFile(file + "~", $"{entry.Identity.FileHash}/entry.cdcex", CompressionLevel.SmallestSize);
                            archieve.CreateEntryFromFile(file + "~User", $"{entry.Identity.FileHash}/user.laex", CompressionLevel.SmallestSize);
                            archieve.CreateEntryFromFile(file + "~preview", $"{entry.Identity.FileHash}/preview.png", CompressionLevel.SmallestSize);


                            File.Delete(file + "~preview");
                            File.Delete(file + "~User");
                            File.Delete(file + "~");
                        }
                        archieve.CreateEntryFromFile(file + "~cdex_dec", $"file.cdex", CompressionLevel.SmallestSize);

                        File.Delete(file + "~cdex_dec");
                    }

                    using (var archieve = ZipFile.Open(file, ZipArchiveMode.Update))
                    {
                        foreach (var item in archieve.Entries)
                        {
                            indexCDEX.ArchieveEntries.Add(item.FullName);
                        }

                        indexCDEX.Hash256 = indexCDEX.GetHashCode().ToString();

                        if (secure)
                        {
                            indexCDEX.PasswordSecured = true;
                            indexCDEX.PasswordEnc = Core.Service.Services.Base.EncryptString(password, password);
                        }

                        SerializeToXml(indexCDEX, file + "~cdex_index");

                        archieve.CreateEntryFromFile(file + "~cdex_index", "CDEX_FILE_DECLARATION.cdex.info");
                    }

                    File.Delete(file + "~cdex_index");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.Source + ex.StackTrace, "LILO Cloud", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }

                return 1;
            }
        }
    }
}
