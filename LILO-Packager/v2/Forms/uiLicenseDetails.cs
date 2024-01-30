using LILO_Packager.Properties;
using LILO_Packager.v2.Core.LILO.Interfaces;
using LILO_Packager.v2.Shared;
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

            if (Program.LicMng.CheckLicx<CrypterLicense, CrypterLicenseTrail>(EnviromentVariables.ApplicationDirectory, new CrypterLicense(), new CrypterLicenseTrail()) == 0)
            {
                pnlLicense.BackgroundImage = Resources.Close;
                lblActivationState.Text = "Product needs Activation.";
                lblLicenseName.Text = "Activator";
                pnlLicenseText.BackColor = Color.Red;
                lblLicenseName.ForeColor = Color.White;
                lblActivationState.ForeColor = Color.White;
                bntOpenLicenseFile.FillColor = Color.WhiteSmoke;
                lblLicenseNameTop.Text = "Unlicensed";

                return;
            }

            var license = Program.LicMng.GetPrintedClass(EnviromentVariables.ApplicationDirectory);
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
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Program.LicMng.CheckLicxDynamic(openFileDialog.FileName, new CrypterLicense()) == 1)
                {
                    File.Copy(openFileDialog.FileName, EnviromentVariables.ApplicationDirectory + "\\objdt\\license.licx");
                    Application.Restart();
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var proc = new Process();
            proc.StartInfo = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = "https://paypal.me/joeyweest"
            };

            proc.Start();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        { 
            var proc = new Process();
            proc.StartInfo = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = "https://github.com/JW-Limited/Crypterv2/releases/"
            };

            proc.Start();
        }
    }
}
