using LILO_Packager.v2.Shared.Api.Types;

namespace LILO_Packager.v2.Core.Dialogs.Secured
{
    public class SecuredDialogBroadCastObserver : IObserver<BroadcastMessage>
    {
        private readonly BroadcastEndPoint listeningEndpoint;
        public SecuredDialogBroadCastObserver(BroadcastEndPoint endPoint)
        {
            listeningEndpoint = endPoint;
        }

        public void OnCompleted()
        {
            
        }

        public void OnError(Exception error)
        {
            
        }

        public void OnNext(BroadcastMessage value)
        {
            if(value == null) throw new ArgumentNullException("value");
            if(value.EndPoint == listeningEndpoint)
            {

            }
        }
    }
}
