namespace LILO_Packager.v2.Shared.Api.Core
{
    public class BroadCastSubscriptionEventArgs : EventArgs
    {
        public bool Subscriped { get; private set; }
        public string Observer { get; private set; }

        public BroadCastSubscriptionEventArgs(bool subscriped, string observer)
        {
            Subscriped = subscriped;
            Observer = observer;
        }
    }
}
