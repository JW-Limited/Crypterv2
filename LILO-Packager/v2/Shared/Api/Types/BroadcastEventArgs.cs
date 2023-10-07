namespace LILO_Packager.v2.Shared.Api.Types
{
    public class BroadcastEventArgs : EventArgs
    {
        public BroadcastMessage Message { get; }

        public BroadcastEventArgs(BroadcastMessage message)
        {
            Message = message;
        }
    }
}
