using LILO_Packager.v2.Core.LILO.Interfaces;

namespace LILO_Packager.v2.Forms
{
    public partial class uiLicenseDetails : Form
    {
        public uiLicenseDetails(ILILOUser user)
        {
            InitializeComponent();

            _user = user;
        }

        public readonly ILILOUser _user;

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MainHost.Instance().OpenInApp(v2.Forms.uiAccount.Instance(_user));
        }

        private void label3_Click(object sender, EventArgs e)
        {
                    }
    }
}
