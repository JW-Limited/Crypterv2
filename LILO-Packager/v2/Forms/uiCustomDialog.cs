using LILO_Packager.v2.Core.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LILO_Packager.v2.Forms
{
    public partial class uiCustomDialog : Form
    {
        private MessageDialogPreference MessageDialogPreference { get; set; }

        public uiCustomDialog(MessageDialogPreference dialogPreference)
        {
            InitializeComponent();
            if (dialogPreference is not null) MessageDialogPreference = dialogPreference;
            else throw new ArgumentNullException("dialogPreference");
            lblMessageText.SizeChanged += lblMessageText_SizeChanged;
        }

        private void uiCustomDialog_Load(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            pnlIcon.BackgroundImage = DialogIconHandler.GetDialogIcon(MessageDialogPreference.Icon);
            var buttonText = DialogButtonHandler.GetSutttingText(MessageDialogPreference.Buttons);
            bntCancel.Text = buttonText[1];
            bntOk.Text = buttonText[0];

            this.Text = MessageDialogPreference.Title ?? "Information";
            lblMessageText.Text = MessageDialogPreference.Message ?? "n/a";
        }

        private void lblMessageText_SizeChanged(object sender, EventArgs e) 
        { 
            this.ClientSize = new Size(this.ClientSize.Width, lblMessageText.Bottom + 20); 
        }


        private void bntOk_Click(object sender, EventArgs e)
        {
            MessageDialogPreference.DialogCallback?.Invoke(DialogResults.Ok);
            this.Close();
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            MessageDialogPreference.DialogCallback?.Invoke(DialogResults.Cancel);
            this.Close();
        }
    }
}
