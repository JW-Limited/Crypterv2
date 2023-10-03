namespace LILO_WebEngine.Shared
{
    public class InitializationResponse
    {
        public bool SuccessFull { get; set; } = false;
        public int Port { get; set; } = 0000;
        public string ErrorMessage { get; set; } = string.Empty;
        public Exception Exception { get; set; } = null;
    }
}
