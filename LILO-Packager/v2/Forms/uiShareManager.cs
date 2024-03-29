﻿using LILO_Packager.Properties;
using LILO_Packager.v2.Cloud.Services;
using LILO_Packager.v2.Cloud.Storage;
using LILO_Packager.v2.Core.Dialogs;
using LILO_Packager.v2.Core.History;
using LILO_Packager.v2.Forms.Dialogs;

namespace LILO_Packager.v2.Forms
{
    public partial class uiShareManager : Form
    {
        private FileIndexStorage MatrixHandler { get; set; }
        public List<MatrixEntry> MatrixEntries { get; set; }
        public LocalCloudMatrixFile _MatrixFile { get; set; }
        public Dictionary<string, (Bitmap, PixelDrainService.CloudFileInfo)> FetchedMatrixEntries = new Dictionary<string, (Bitmap, PixelDrainService.CloudFileInfo)>();
        public static bool fetchinEntries = false;

        public uiShareManager()
        {
            InitializeComponent();

            MatrixHandler = new FileIndexStorage();

            var matrixFile = MatrixHandler.GetMatrixFile();
            if (matrixFile != null)
            {
                _MatrixFile = matrixFile;

                if (matrixFile.MatrixEntrys.Count > 0)
                {
                    MatrixEntries = matrixFile.MatrixEntrys;

                }
            }
        }

        private void uiShareManager_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke((Action)(async () =>
                {
                    lblVersion.Text = Program.CloudVersion;

                    foreach (var item in MatrixEntries)
                    {
                        var listViewItem = new ListViewItem()
                        {
                            Text = item.File.FileName,
                            Tag = item.Identity.FileHash,
                        };

                        listViewItem.SubItems.Add(item.Identity.Timestamp.ToShortDateString() + " - " + item.Identity.Timestamp.ToShortTimeString());

                        listView1.Items.Add(listViewItem);
                    }
                }));
            });
        }

        private MatrixEntry GetMatrixEntry(ListViewItem Litem)
        {
            MatrixEntry entry = null;
            foreach (var item in MatrixEntries)
            {
                if (item.Identity.FileHash == Litem.Tag) entry = item;
            }

            return entry;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listView2.Items.Clear();

            foreach (var selected in listView1.SelectedItems)
            {
                var item = GetMatrixEntry((ListViewItem)selected);

                var listViewItem = new ListViewItem()
                {
                    Text = item.File.FileName,
                    Tag = item.Identity.FileHash,
                };

                listView2.Items.Add(listViewItem);
            }


            if (listView2.Items.Count != 0) { bntShare.Enabled = true; bntAdvanced.Enabled = true; }
            else { bntShare.Enabled = false; bntAdvanced.Enabled = false; }
        }

        private void bntShare_Click(object sender, EventArgs e)
        {
            if (MainHost.Instance().loggedInUser is null) throw new UnauthorizedAccessException();

            if (listView2.Items.Count == 1)
            {
                MatrixShareManager.ExportMatrixEntry(
                    GetMatrixEntry(
                        listView2.Items[0]),
                    MainHost.Instance().loggedInUser,
                    Resources.Close);
                
                //uiCloudFilesViewer.Instance(null).FetchedMatrixEntries.First(
                //k => k.Key == (string)listView2.Items[0].Tag).Value.Item1
            }
            else if (listView2.Items.Count > 1)
            {
                var secUi = new uiSecureInputHandler(new Core.Dialogs.Secured.SecuredDialogPreferences("CDEX Creator", "AxKey Input", "Provide a suiting key.")
                {
                    Channel = Shared.Api.Core.BroadcastChannel.Instance,
                    Callback = e =>
                    {
                        if (e.DialogClosingReason == Core.Dialogs.Secured.DialogClosingReason.Success)
                        {
                            var selectedItems = new List<MatrixEntry>();

                            foreach (var item in listView2.Items)
                            {
                                selectedItems.Add(GetMatrixEntry((ListViewItem)item));
                            }

                            MatrixShareManager.ExportMatrixEntries(MainHost.Instance().loggedInUser, Resources.Close, selectedItems, true, e.DynamicCallbackValues[0]);
                        }
                    }
                });

                secUi.ShowDialog();
            }
        }

        private void bntPlugin_Click(object sender, EventArgs e)
        {
            var pref = new FileDropDialogPreferences()
            {
                TaskName = "Share File",
                FileAccepted = HandleImportFile,
                TaskDescription = "Drop here youre .cdex file."
            };

            var FileDialog = new uiFileDropDialog(pref);
            FileDialog.ShowDialog();
        }

        private void HandleImportFile(string file)
        {
            var info = MatrixShareManager.GetPackageDeclaration(file);

            if (info.PasswordSecured)
            {
                var password = GetPassword();
                if (Core.Service.Services.Base.EncryptString(password, password) == info.PasswordEnc)
                {
                    MainHost.Instance().OpenInApp(new uiImportSharedFiles(file));
                }
                else
                {
                    MessageBox.Show("The passkey did not match.", "LILO Cloud", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetPassword()
        {
            if (pswDialog.ShowDialog(this) == DialogResult.OK)
            {
                return pswDialog.Input;
            }
            else
            {
                return null;
            }
        }

        private void bntAdvanced_Click(object sender, EventArgs e)
        {
            var selectedItems = new List<MatrixEntry>();

            foreach (var item in listView2.Items)
            {
                selectedItems.Add(GetMatrixEntry((ListViewItem)item));
            }

            var exportDialog = new uiDialogCreateCdex(selectedItems);
            exportDialog.ShowDialog();

        }
    }
}
