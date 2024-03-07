using LILO_Packager.v2.Cloud.Storage;
using LILO_Packager.v2.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Shared
{
    internal class AuthenticationHandler
    {
        public static async Task GetPassword(Action<string> passwordAnswer)
        {
            var secUi = new uiSecureInputHandler(new Core.Dialogs.Secured.SecuredDialogPreferences("CDEX Creator", "AxKey Input", "Provide a suiting key.")
            {
                Channel = Shared.Api.Core.BroadcastChannel.Instance,
                Callback = e =>
                {
                    if (e.DialogClosingReason == Core.Dialogs.Secured.DialogClosingReason.Success)
                    {
                        passwordAnswer?.Invoke(e.DynamicCallbackValues[0]);
                    }
                }
            });

            secUi.ShowDialog();
        }
    }
}
