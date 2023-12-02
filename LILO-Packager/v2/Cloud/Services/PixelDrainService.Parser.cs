namespace LILO_Packager.v2.Cloud.Services
{
    public partial class PixelDrainService
    {
        public class Parser
        {
            public static ResponseData ParseResponse(string jsonResponse)
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseData>(jsonResponse);
            }
        }
    }
}
