using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.Dialogs
{

    public class MessageDialogPreference
    {
        public MessageDialogPreference(string title, string message)
        {
            Title = title;
            Message = message;
        }
        
        public MessageDialogPreference(string title, string message, Dialog mode, DialogButtons buttons)
        {
            Title = title;
            Message = message;
            Mode = mode;
            Buttons = buttons;
        }
        public MessageDialogPreference(string title, string message, Dialog mode, DialogButtons buttons,DialogIcon icon,Action<DialogResults> result)
        {
            Title = title;
            Message = message;
            Mode = mode;
            Buttons = buttons;
            Icon = icon;
            DialogCallback = result;
        }

        public Dialog Mode { get; set; } = Dialog.Message;
        public string Title { get; set; } = null;
        public string Message { get; set; } = null;
        public DialogIcon Icon { get; set; } = DialogIcon.Information;
        public DialogButtons Buttons { get; set; } = DialogButtons.OkCancel;
        public Action<DialogResults> DialogCallback { get; set; } = null;
    }
}
