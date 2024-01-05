using LILO_Packager.v2.Shared.Api.Types;

namespace LILO_Packager.v2.Shared
{
    public class MainHostBroadCast : IObserver<BroadcastMessage>
    {
        public void OnCompleted()
        {

        }

        public void OnError(Exception error)
        {
            Console.WriteLine(error.ToString());
            Console.WriteLine(error.Message);
            //MainHost.Instance().SetNotification(error.Message);
        }

        public void OnNext(BroadcastMessage value)
        {
            Console.WriteLine(value.ToString());
            Console.WriteLine(value.Payload);
            //MainHost.Instance().SetNotification(value.Payload);
        }
    }
}

