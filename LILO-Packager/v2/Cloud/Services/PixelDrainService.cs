using LILO_Packager.v2.Cloud.Storage;
using LILO_Packager.v2.Contracts;
using MimeKit;
using System.Net.Http.Headers;

namespace LILO_Packager.v2.Cloud.Services
{
    public partial class PixelDrainService : ICloudService
    {
        private const string PDSERVER = "https://pixeldrain.com";
        private const string PDCLIENTURL = "https://beta.lilo.com";


        public static async Task DownloadFileAsync(string id, string outputPath, Action<long, long> progressCallback, bool downloadAsAttachment = false)
        {
            HttpClient httpClient = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"https://pixeldrain.com/api/file/{id}");

            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/octet-stream"));

            HttpResponseMessage response = await httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                long totalLength = response.Content.Headers.ContentLength ?? 0;
                long bytesDownloaded = 0;

                using (FileStream fileStream = new FileStream(outputPath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (Stream contentStream = await response.Content.ReadAsStreamAsync())
                    {
                        var buffer = new byte[4096];
                        int bytesRead;

                        while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                        {
                            await fileStream.WriteAsync(buffer, 0, bytesRead);
                            bytesDownloaded += bytesRead;

                            if (progressCallback != null)
                            {
                                progressCallback(bytesDownloaded, totalLength);
                            }
                        }
                    }
                }
            }
            else
            {
                throw new Exception("Unable to download file");
            }
        }

        public Task DownloadFiles(string[] files)
        {
            throw new NotImplementedException();
        }
        public class ResponseData
        {
            public bool success { get; set; }
            public string id { get; set; }
        }

        private async Task AddToMatrix(string file, string fileId)
        {
            FileIndexStorage.Instance.AddMatrixEntry(new MatrixEntry()
            {
                CloudEntry = new CloudPlace()
                {
                    FileUrl = $"{PDSERVER}/u/{fileId}",
                    PublicFileId = fileId
                },
                File = new LocalFile()
                {
                    FileName = new FileInfo(file).Name,
                    DirectoryPath = new FileInfo(file).Directory.ToString(),
                    RealPath = file
                },
                Identity = new FileIdentity()
                {
                    FileHash = CloudSyncroniztationBase.GetFileHash(file),
                    Timestamp = DateTime.Now.ToLocalTime(),
                }
            });
        }

        public async Task UploadFiles(string[] files, Action<string> statusCallback, Action<long, long> progressCallback)
        {
            using var httpClient = new HttpClient();
            var filesCount = files.Length;
            var currentFile = 0;

            foreach (var file in files)
            {
                try
                {
                    currentFile++;

                    var fileId = "";
                    var fileName = Path.GetFileName(file);
                    var fileSize = new FileInfo(file).Length;

                    progressCallback.Invoke(currentFile, filesCount);

                    statusCallback($"Uploading {fileName} ... ");

                    using var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
                    using var formData = new MultipartFormDataContent();
                    var content = new StreamContent(fileStream);

                    formData.Add(content, "file", fileName);

                    var response = await httpClient.PostAsync($"{PDSERVER}/api/file", formData);
                    response.EnsureSuccessStatusCode();

                    try
                    {
                        string fileIdStr = await response.Content.ReadAsStringAsync();
                        fileId = Parser.ParseResponse(fileIdStr).id;
                    }
                    catch { }

                    await AddToMatrix(file, fileId);

                    statusCallback($"{new FileInfo(file).Name}");
                }
                catch (Exception ex)
                {
                    statusCallback?.Invoke(ex.Message);
                }
            }

            progressCallback.Invoke(currentFile+1, filesCount);
            statusCallback.Invoke("Everything Done!");
        }
    }
}
