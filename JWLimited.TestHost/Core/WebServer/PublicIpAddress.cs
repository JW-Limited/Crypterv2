using Newtonsoft.Json;

namespace JWLimited.TestHost.Core.WebServer
{
    public partial class Manager
    {
        public class PublicIpAddress
        {
            public static async Task<string> GetUsingIpifyAsync()
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("https://api.ipify.org/?format=json");
                    if (response.IsSuccessStatusCode)
                    {
                        string content = (await response.Content.ReadAsStringAsync()).ToString();
                        var data = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);
                        return data["ip"];
                    }
                    else
                    {
                        throw new Exception("Error retrieving public IP: " + response.StatusCode);
                    }
                }
            }
        }
    }
}
