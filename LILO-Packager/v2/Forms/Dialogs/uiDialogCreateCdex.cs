using LILO_Packager.Properties;
using LILO_Packager.v2.Cloud.Storage;
using LILO_Packager.v2.Core.LILO.Types;
using LILO_Packager.v2.Shared;
using Microsoft.Win32;
using System.Diagnostics;

namespace LILO_Packager.v2.Forms.Dialogs
{
    public partial class uiDialogCreateCdex : Form
    {
        public uiDialogCreateCdex(List<MatrixEntry> MatrixEntries)
        {
            InitializeComponent();

            Entrys = MatrixEntries;
        }

        List<MatrixEntry> Entrys { get; set; }
        public CdexArgs CdexArguments { get; set; } = new CdexArgs();

        public class CdexArgs
        {
            public string Name { get; set; } = "";
            public string Directory { get; set; } = "";
            public string EncryptenKey { get; set; } = "";

            // Not Essential
            public List<User> AllowedUsers { get; set; } = null;
        }

        private void uiDialogCreateCdex_Load(object sender, EventArgs e)
        {

        }

        private bool CanExport()
        {
            return !CdexArguments.Name.Equals("") && !CdexArguments.Directory.Equals("") && !CdexArguments.EncryptenKey.Equals("");
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var secUi = new uiSecureInputHandler(new Core.Dialogs.Secured.SecuredDialogPreferences("CDEX Creator", "AxKey Input", "Provide a suiting key.")
            {
                Channel = Shared.Api.Core.BroadcastChannel.Instance,
                Callback = e =>
                {
                    if (e.DialogClosingReason == Core.Dialogs.Secured.DialogClosingReason.Success)
                    {
                        CdexArguments.EncryptenKey = e.DynamicCallbackValues[0];
                        lblLILOSecure.ForeColor = Color.Green;
                        bntShare.Enabled = CanExport();
                    }
                }
            });

            secUi.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPsw__TextChanged(object sender, EventArgs e)
        {
            CdexArguments.Name = txtPsw.Texts;
            bntShare.Enabled = CanExport();
        }

        private void sTextBox1__TextChanged(object sender, EventArgs e)
        {
            CdexArguments.Directory = sTextBox1.Texts;
            bntShare.Enabled = CanExport();
        }

        private void bntPlugin_Click(object sender, EventArgs e)
        {
            OpenFolderDialog ofd = new OpenFolderDialog()
            {
                AddToRecent = false,
                ShowHiddenItems = true,
                Multiselect = false,
                DereferenceLinks = true,
                ValidateNames = true,
                Title = "Select Directory"
            };

            if (ofd.ShowDialog() == true)
            {
                CdexArguments.Directory = ofd.FolderName;
                sTextBox1.Texts = ofd.FolderName;
                bntShare.Enabled = CanExport();
            }

        }

        private void bntShare_Click(object sender, EventArgs e)
        {
            MatrixShareManager.Advanced.ExportMatrixEntries(MainHost.Instance().loggedInUser, Resources.Close, Entrys, CdexArguments.Directory + "\\" + CdexArguments.Name + FileOperations.GetFileExtension(FileOperations.CrypterFileType.CloudEntry),true, CdexArguments.EncryptenKey);
            Process.Start("explorer.exe", CdexArguments.Directory);
            this.Close();
        }
    }
}
