using LILO_Packager.v2.Cloud.Storage;
using LILO_Packager.v2.Contracts;
using MimeKit;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;

namespace LILO_Packager.v2.Cloud.Services
{
    public class PixelDrainService : ICloudService
    {
        private const string PDSERVER = "https://pixeldrain.com";
        private const string PDCLIENTURL = "https://beta.lilo.com";


        public class CloudFileInfo
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public long Size { get; set; }
            public int Views { get; set; }
            public long BandwidthUsed { get; set; }
            public long BandwidthUsedPaid { get; set; }
            public int Downloads { get; set; }
            public DateTime DateUpload { get; set; }
            public DateTime DateLastView { get; set; }
            public string MimeType { get; set; }
            public string ThumbnailHref { get; set; }
            public string HashSha256 { get; set; }
            public bool CanEdit { get; set; }

            public static async Task<CloudFileInfo> GetFileInfoAsync(string id)
            {
                using var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await httpClient.GetAsync($"https://pixeldrain.com/api/file/{id}/info");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<CloudFileInfo>(json);
                }
                else
                {
                    throw new Exception("Unable to get file information");
                }
            }
        }

        public class PixelDrainThumbnail
        {
            public static async Task<Bitmap> GetThumbnailAsync(string id, int width = 128, int height = 128)
            {
                using var httpClient = new HttpClient();

                var request = new HttpRequestMessage(HttpMethod.Get, $"https://pixeldrain.com/api/file/{id}/thumbnail?width={width}&height={height}");
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("image/png"));

                var response = await httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var imageBytes = await response.Content.ReadAsByteArrayAsync();
                    using var memoryStream = new MemoryStream(imageBytes);
                    return new Bitmap(memoryStream); ;
                }
                else
                {
                    throw new Exception("Unable to get file thumbnail");
                }
            }

        }

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

        public class Parser
        {
            public static ResponseData ParseResponse(string jsonResponse)
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseData>(jsonResponse);
            }
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

    public class ProgressMessageHandler : DelegatingHandler
    {
        private readonly Action<long, long> _progressCallback;

        public ProgressMessageHandler(HttpMessageHandler innerHandler, Action<long, long> progressCallback)
            : base(innerHandler)
        {
            _progressCallback = progressCallback ?? throw new ArgumentNullException(nameof(progressCallback));
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var content = request.Content;
            if (content != null)
            {
                var progressContent = new ProgressStreamContent(await content.ReadAsStreamAsync(), _progressCallback);
                request.Content = progressContent;
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }

    public class ProgressStreamContent : StreamContent
    {
        private readonly Action<long, long> _progressCallback;

        public ProgressStreamContent(Stream stream, Action<long, long> progressCallback)
            : base(stream)
        {
            _progressCallback = progressCallback ?? throw new ArgumentNullException(nameof(progressCallback));
        }

        protected override async Task SerializeToStreamAsync(Stream stream, TransportContext context)
        {
            var length = Headers.ContentLength ?? 0;
            var buffer = new byte[4096];
            long bytesWritten = 0;

            try
            {
                using (var contentStream = await ReadAsStreamAsync())
                {
                    while (true)
                    {
                        var bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length);
                        if (bytesRead == 0)
                            break;

                        await stream.WriteAsync(buffer, 0, bytesRead);
                        bytesWritten += bytesRead;

                        _progressCallback(bytesWritten, length);
                    }
                }
            }
            catch (Exception writeException)
            {
                throw new InvalidOperationException($"Error writing into stream: {writeException.Message}", writeException);
            }
        }
    }
}
