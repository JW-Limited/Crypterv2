using LILO_Packager.Properties;
using LILO_Packager.v2.Cloud.Storage;
using LILO_Packager.v2.Shared;
using Microsoft.Win32;
using System.Diagnostics;

namespace LILO_Packager.v2.Forms.Dialogs
{
    public partial class uiDialogCreateCdex : Form, ICDEXDialog
    {
        public uiDialogCreateCdex(List<MatrixEntry> MatrixEntries)
        {
            InitializeComponent();
            CdexArguments.MatrixEntries = MatrixEntries;
        }

        public CdexArgs CdexArguments { get; set; } = new CdexArgs();
        public byte CanBeAccessed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IManagableDialog.CanBeAccessed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsAccessed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int DialogId => throw new NotImplementedException();

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
            MatrixShareManager.Advanced.ExportMatrixEntries(MainHost.Instance().loggedInUser, Resources.Close, CdexArguments.MatrixEntries, CdexArguments.Directory + "\\" + CdexArguments.Name + FileOperations.GetFileExtension(FileOperations.CrypterFileType.CloudEntry),true, CdexArguments.EncryptenKey);
            Process.Start("explorer.exe", CdexArguments.Directory);
            this.Close();
        }

        public void ShowDialog(object sender)
        {   
            this.ShowDialog();
        }

        public void LoadData()
        {
            throw new NotImplementedException();
        }

        public void SaveData()
        {
            throw new NotImplementedException();
        }

        public void ProcessDialog()
        {
            throw new NotImplementedException();
        }
    }
}
