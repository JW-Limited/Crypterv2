using JWLimited.Licensing.Schemes;
using LILO_Packager.Properties;
using LILO_Packager.v2.Core.LILO.Interfaces;
using LILO_Packager.v2.Core.LILO.Types;
using System.Diagnostics;

namespace LILO_Packager.v2.Forms
{
    public partial class uiLicenseDetails : Form
    {
        public uiLicenseDetails(ILILOUser user)
        {
            InitializeComponent();

            if (user is null)
            {
                pnlBack.Visible = false;
            }
            else
            {
                _user = user;
            }
        }

        public readonly ILILOUser _user;

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MainHost.Instance().OpenInApp(v2.Forms.uiAccount.Instance(_user));
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void uiLicenseDetails_Load(object sender, EventArgs e)
        {
            lblProductname.Text = "Crypterv2";

            if (Program.LicMng.CheckLicenseAsync<CrypterLicense, CrypterLicenseTrail>(Program.AppPath, new CrypterLicense(), new CrypterLicenseTrail()) == 0)
            {
                pnlLicense.BackgroundImage = Resources.Close;
                lblActivationState.Text = "Product needs Activation.";
                lblLicenseName.Text = "Activator";
                pnlLicenseText.BackColor = Color.Red;
                lblLicenseName.ForeColor = Color.White;
                lblActivationState.ForeColor = Color.White;
                bntOpenLicenseFile.FillColor = Color.WhiteSmoke;
                lblLicenseNameTop.ForeColor = Color.Red;
                lblLicenseNameTop.Text = "Unlicensed";

                return;
            }

            var license = Program.LicMng.GetPrintedClass(Program.AppPath);
            lblActivationState.Text = "License Activated (Local)";
            lblLicenseName.Text = "License";
            if (license.License.LicenseName.Contains("Trail"))
            {
                lblLicenseName.Text = "Trail License";
                lblActivationState.Text = "Activated till: " + license.License.DieDay.ToShortDateString();
            }
            lblLicenseNameTop.Text = license.License.LicenseName;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "JW Limited License Object |*.licx|Alle Datein|*.*",
                FilterIndex = 0,
            };
            
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var proc = new Process();
            proc.StartInfo = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = "https://paypal.me/joeywest"
            };

            proc.Start();
        }
    }
}
