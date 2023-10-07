namespace LILO_Packager.v2.Shared.Api.Types
{
    public class BroadCastMessageParameters
    {
        public BroadCastMessageParameters(string message, Action<bool> process, string sender = "Plugin - BroadCaster", int idOfCast = 0x22)
        {
            Message = message;
            Process = process;
            Sender = sender;
            IdOfCast = idOfCast;
        }

        public string Message { get; set; }
        public Action<bool> Process { get; set; }
        public string Sender { get; set; }
        public int IdOfCast { get; set; }
    }
}
