using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace LILO_Packager.v2.Cloud.Services
{
    public partial class PixelDrainService
    {
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
    }
}
