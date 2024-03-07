using LILO_Packager.v2.Core.AsyncTasks;
using LILO_Packager.v2.Core.Dialogs.Secured;
using LILO_Packager.v2.Shared.Api.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace LILO_Packager.v2.Forms
{
    public partial class uiSecureInputHandler : Form
    {
        public Core.AsyncTasks.AsyncTask _Task { get; set; }
        private readonly SecuredDialogPreferences _Preferences;

        public uiSecureInputHandler(SecuredDialogPreferences args)
        {
            InitializeComponent();
            _Preferences = args;
        }

        private void uiCustomProcess_Load(object sender, EventArgs e)
        {
            lblTask.Text = _Preferences.Task;
            this.Text = _Preferences.FormTitle;
            _Preferences?.Channel.Broadcast(new BroadcastMessage(BroadcastMessageType.Info, BroadcastEndPoint.ForAll, "SecuredDialogHost:LoadedUI"));
        }

        private void progress_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bntOk_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            _Preferences.Callback?.Invoke(new SecuredDialogCallBack()
            {
                DialogClosingReason = DialogClosingReason.DialogAborted,
            });

            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            _Preferences.Callback?.Invoke(new SecuredDialogCallBack()
            {
                DialogClosingReason = DialogClosingReason.Success,
                DynamicCallbackValues = new System.Collections.ObjectModel.ObservableCollection<string>() { txtPsw.Texts }
            });

            this.Close();
        }

        private void showPsw_Click(object sender, EventArgs e)
        {
            txtPsw.PasswordChar = !showPsw.Checked;
        }
    }
}
