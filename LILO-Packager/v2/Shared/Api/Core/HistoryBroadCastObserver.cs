using LILO_Packager.v2.Core.Dialogs;
using LILO_Packager.v2.Core.History;
using LILO_Packager.v2.Shared.Api.Types;

namespace LILO_Packager.v2.Forms
{
    public class HistoryBroadCastObserver : IObserver<BroadcastMessage>
    {
        private static Lazy<HistoryBroadCastObserver> s_ = new Lazy<HistoryBroadCastObserver>();
        public static HistoryBroadCastObserver Instance => s_.Value;

        public void OnCompleted()
        {

        }

        public void OnError(Exception error)
        {

        }

        public void OnNext(BroadcastMessage value)
        {
            if (value is null) return;

            if (value.EndPoint == BroadcastEndPoint.ForAll)
            {

            }

            if (value.EndPoint == BroadcastEndPoint.HistoryQuery)
            {
                try
                {
                    var castElement = new HistoryElement(value.BroadcastMessageArgs.Message);
                    MainHost.Instance().OpenInApp(new uiHistoryElementInfo(castElement));
                }
                catch (Exception ex)
                {
                    OkDialog.Show(ex.Message, "Casting Error", DialogIcon.Error);
                }
            }
        }
    }
}
