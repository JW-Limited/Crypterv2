using LILO_Packager.v2.Cloud.Storage;
using LILO_Packager.v2.Shared;

namespace LILO_Packager.v2.Cloud.Services
{
    public partial class PixelDrainService
    {
        public class WebviewPreview
        {
            public static string TempPath = Path.Combine(Application.ExecutablePath.Replace("crypterv2.exe", ""), "temp");

            public static async Task<KeyValuePair<byte,Uri>> GetPreview(MatrixEntry entry, Action<long,long> progressCallback)
            {
                FileOperations.CreateDirectoryRecursively(TempPath);

                await DownloadFileAsync(entry.CloudEntry.PublicFileId, TempPath + $"\\webviewSource-{entry.File.FileName}",progressCallback);

                //var html = FilePreviewer.GenerateHtmlPage(TempPath + $"\\webviewSource-{entry.File.FileName}");
                //File.WriteAllText(TempPath + $"\\webviewSource-{entry.File.FileName}.html", html);

                var mime = FilePreviewer.GetMimetype(Path.GetExtension(TempPath + $"\\webviewSource-{entry.File.FileName}").ToLowerInvariant());
                if(mime is not null)
                {
                    return new KeyValuePair<byte, Uri>(1, new Uri(TempPath + $"\\webviewSource-{entry.File.FileName}"));
                }

                return new KeyValuePair<byte, Uri>(0, null);
            }

            class FilePreviewer
            {
                public static string GenerateHtmlPage(string filePath)
                {
                    string extension = Path.GetExtension(filePath).ToLowerInvariant();
                    string mimetype = GetMimetype(extension);

                    string html = @$"
                    <!DOCTYPE html>
                    <html>
                    <head>
                        <meta http-equiv='Content-Type' content='text/html; charset=utf-8'>
                        <title>File Preview</title>
                    </head>
                    <body>
                        <object id='filePreview' data='{filePath}' type='{mimetype}' width='100%' height='500'></object>
                    </body>
                    </html>
                    ";

                    return html;
                }

                public static string GetMimetype(string extension)
                {
                    switch (extension)
                    {
                        case ".pdf":
                            return "application/pdf";
                        case ".mp3":
                            return "audio/mpeg";
                        case ".zip":
                            return "application/zip";
                        default:
                            return null;
                    }
                }
            }
        }
    }
}
