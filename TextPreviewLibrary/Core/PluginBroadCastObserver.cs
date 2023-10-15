using LILO_Packager.v2.Shared.Api.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextPreviewLibrary.Core
{
    internal class PluginBroadCastObserver : IObserver<BroadcastMessage>
    {
        public void OnCompleted()
        {
            
        }

        public void OnError(Exception error)
        {
            
        }

        public void OnNext(BroadcastMessage value)
        {
            if(value == null) throw new ArgumentNullException("value");


            if(value.EndPoint == BroadcastEndPoint.ForAll)
            {
                PluginInterface.Instance(null, null, null, false).lblTip.Text = value.Payload ?? "New Message in Notifications.";
            }

            if(value.EndPoint == BroadcastEndPoint.TPL)
            {
                if(value.Payload is "close" or "shutdown")
                {
                    PluginInterface.Instance(null, null, null, false).Close();
                    PluginInterface.Instance(null, null, null, false).Dispose();
                }
            }
        }
    }
}
