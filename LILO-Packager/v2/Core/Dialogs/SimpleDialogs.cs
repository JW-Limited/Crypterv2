using LILO_Packager.v2.Core.AsyncTasks;
using LILO_Packager.v2.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.Dialogs
{
    public class OkDialog
    {
        public static void Show(string message, string title, DialogIcon icon = Core.Dialogs.DialogIcon.Information)
        {
            var dialogtest = new uiCustomDialog(
            new Core.Dialogs.MessageDialogPreference(
                title,
                message,
                Core.Dialogs.Dialog.Message,
                Core.Dialogs.DialogButtons.OkCancel,
                icon,
                result => {})
            );
            dialogtest.ShowDialog();
        }
    }

    public class ContinueDialog
    {
        public static void Show(string _message, string _title, DialogIcon _icon = Core.Dialogs.DialogIcon.Information)
        {
            var dialogtest = new uiCustomDialog(
            new Core.Dialogs.MessageDialogPreference(
                _title,
                _message,
                Core.Dialogs.Dialog.Authorization,
                Core.Dialogs.DialogButtons.Allow,
                _icon,
                result => {})
            );
            dialogtest.ShowDialog();
        }
    }
}
