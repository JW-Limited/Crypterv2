using LILO_Packager.Properties;
using LILO_Packager.v2.Core.LILO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LILO_Packager.v2.Forms
{
    public partial class uiAccount : Form
    {
        public User _user;
        private static uiAccount _encrypt;
        private static object _lock = new object();
        public static uiAccount Instance(User user)
        {
            lock (_lock)
            {
                if (_encrypt is null)
                {
                    _encrypt = new uiAccount(user);
                }

                return _encrypt;
            }
        }

        private uiAccount(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void uiAccount_Load(object sender, EventArgs e)
        {
            this.FormClosing += (s, e) =>
            {
                _encrypt = null;
            };

            lblEmail.Text = _user.Email;
            lblUsername.Text = _user.Email.Replace("@jwlmt.com", "");
            lblUser.Text = _user.Role;
            videoPanel.BackgroundImage = Resources.icons8_male_user_96;
        }

        private void bntSettings_Click(object sender, EventArgs e)
        {
            MainHost.Instance().OpenInApp(uiSettings.Instance());
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            MainHost.Instance().loggedInUser = null;
            File.Delete(MainHost.Instance().UserFile);
            uiLILOAccountLogin.SetInstance(null);
            MainHost.Instance().OpenInApp(v2.Forms.uiWebView.Instance(new Uri("http://localhost:8080")));
        }
    }
}
