using System.Net.Http.Headers;

namespace LILO_Packager.v2.Cloud.Services
{
    public partial class PixelDrainService
    {
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
    }
}
