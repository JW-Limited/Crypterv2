using LILO_Packager.v2.Core.AsyncTasks;
using LILO_Packager.v2.Core.Dialogs;
using LILO_Packager.v2.Core.History;
using LILO_Packager.v2.Core.LILO.Interfaces;
using LILO_Packager.v2.Core.LILO.Types;
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
using Telerik.WinControls.UI;

namespace LILO_Packager.v2.Forms
{
    public partial class uiAccontDetails : Form
    {
        public uiAccontDetails(ILILOUser user)
        {
            InitializeComponent();
            _user = user;
            _userAdvanced = new UserAdvanced(user);
        }

        public readonly ILILOUser _user;
        private readonly UserAdvanced _userAdvanced;

        private void uiAccontDetails_Load(object sender, EventArgs e)
        {
            lblEmail.Text = _userAdvanced.Email;
            lblUsername.Text = _user.Name;
            lblUserRole.Text = _userAdvanced.Role;
            pnlPicture.BackgroundImage = _userAdvanced.ProfilePicture;
            pnlBackGround.BackgroundImage = _userAdvanced.ProfilePicture;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MainHost.Instance().OpenInApp(v2.Forms.uiAccount.Instance(_user));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var dialogtest = new uiCustomDialog(
            new Core.Dialogs.MessageDialogPreference(
                "Autherization Required",
                "Do you really want to logoff from Crypterv2?",
                Core.Dialogs.Dialog.Authorization,
                Core.Dialogs.DialogButtons.Authorization,
                Core.Dialogs.DialogIcon.Question,
                result =>
                {
                    if (result == Core.Dialogs.DialogResults.Ok)
                    {
                        _user.LogOff();
                    }
                })
            );
            dialogtest.ShowDialog();

        }

        private void bntChooseFile(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Compatible Formats|*.png;*.jpg";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var file = ofd.FileName;
                if (file is not null)
                {
                    config.Default.localUserImage = file;
                    config.Default.Save();

                    pnlPicture.BackgroundImage = (Bitmap)Bitmap.FromFile(file);
                }
            }
        }

        private void bntDeletePictrue(object sender, EventArgs e)
        {
            config.Default.localUserImage = "";
            config.Default.Save();
            pnlPicture.BackgroundImage = Properties.Resources.icons8_male_user_96;
        }

        private void sPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
