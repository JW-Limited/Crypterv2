using System.Xml.Linq;
using ICSharpCode.SharpZipLib.Zip;
using System.Windows.Forms;
using System.Text;
using System.IO.Compression;

namespace TextPreviewLibrary.Core.Third_Party.Docx
{
    public static class Converter
    {
        public static void ConvertToRichTextBox(string inputPath, RichTextBox output)
        {
            try
            {
                using (ICSharpCode.SharpZipLib.Zip.ZipInputStream zip = new ICSharpCode.SharpZipLib.Zip.ZipInputStream(File.OpenRead(inputPath)))
                {
                    ZipEntry entry;
                    while ((entry = zip.GetNextEntry()) != null)
                    {
                        if (entry.Name.EndsWith("document.xml"))
                        {
                            XDocument doc = XDocument.Load(zip);
                            output.Text = doc.Root.Value;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                output.Text = "Error converting document: " + ex.Message;
            }
        }

        public static string ConvertToPlainText(string inputPath)
        {
            try
            {
                StringBuilder text = new StringBuilder();

                using (FileStream fileToDecompress = File.OpenRead(inputPath))
                using (ZipArchive archive = new ZipArchive(fileToDecompress, ZipArchiveMode.Read))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        if (entry.FullName.EndsWith("document.xml"))
                        {
                            using (Stream stream = entry.Open())
                            {
                                XDocument doc = XDocument.Load(stream);
                                text.Append(doc.Root.Value);
                            }
                        }
                    }
                }

                return text.ToString();
            }
            catch(Exception ex)
            {
                return "Error happend while reading the file: " + ex.Message;
            }
        }
    }
}

