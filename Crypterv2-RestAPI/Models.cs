namespace Crypterv2_RestAPI
{
    public class CommandModel
    {
        public string Action { get; set; }
        public string Parameters { get; set; }
    }

    public class EncryptModel
    {
        public string InputData { get; set; }
        public string Key { get; set; }
    }

    public class DecryptModel
    {
        public string EncryptedData { get; set; }
        public string Key { get; set; }
    }

}
