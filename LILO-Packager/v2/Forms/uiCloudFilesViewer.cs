using LILO_Packager.v2.Cloud;
using LILO_Packager.v2.Cloud.Services;
using LILO_Packager.v2.Cloud.Storage;
using LILO_Packager.v2.Contracts;
using LILO_Packager.v2.Shared;
using System.Diagnostics;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;

namespace LILO_Packager.v2.Forms
{
    public partial class uiCloudFilesViewer : Form
    {
        private ICloudServiceManager CloudServiceManager { get; set; }
        private FileIndexStorage MatrixHandler { get; set; }
        public List<MatrixEntry> MatrixEntries { get; set; }
        public LocalCloudMatrixFile _MatrixFile { get; set; }

        public uiCloudFilesViewer(ICloudServiceManager manager)
        {
            InitializeComponent();

            CloudServiceManager = manager;
            MatrixHandler = new FileIndexStorage();

            var matrixFile = MatrixHandler.GetMatrixFile();
            if (matrixFile != null)
            {
                _MatrixFile = matrixFile;

                if (matrixFile.MatrixEntrys.Count > 0)
                {
                    MatrixEntries = matrixFile.MatrixEntrys;

                    lblAllInCloud.Text = $"{matrixFile.MatrixEntrys.Count}";
                }
            }
            else
            {
                prgMiniProgress.Visible = false;
            }
        }

        private void CloudFilesViewer_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Program.CloudVersion;
            this.Size = MainHost.Instance().Size;
            this.Location = MainHost.Instance().Location;
            Task.Run(() =>
            {
                if (CloudSyncroniztationBase.HasNetworkConnection())
                {
                    lblNetwork.Text = "Connected";
                    lblNetwork.ForeColor = Color.Green;

                    if (CloudSyncroniztationBase.CloudAvailable())
                    {
                        lblCloud.Text = "Connected";
                        lblCloud.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblCloud.Text = "Offline";
                        lblCloud.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblNetwork.Text = "Offline";
                    lblNetwork.ForeColor = Color.Red;
                    lblCloud.Text = "Offline";
                    lblCloud.ForeColor = Color.Red;
                }

                lblMatrix.Text = MatrixHandler.GetMatrixFile().MatrixDetail.MatrixVerifier.Name;
                lblMatrixVersion.Text = MatrixHandler.GetMatrixFile().MatrixDetail.SchemeVersion;

                this.Invoke((Action)(async () =>
                {
                    var imageList = new ImageList();
                    listView1.StateImageList = imageList;
                    listView1.SmallImageList = imageList;
                    listView1.LargeImageList = imageList;
                    listView1.GroupImageList = imageList;

                    foreach (var item in MatrixEntries)
                    {
                        var listViewItem = new ListViewItem()
                        {
                            Text = item.File.FileName,
                            Tag = item.Identity.FileHash,
                        };

                        imageList.Images.Add(item.Identity.FileHash, await PixelDrainService.PixelDrainThumbnail.GetThumbnailAsync(item.CloudEntry.PublicFileId));
                        listViewItem.ImageKey = item.Identity.FileHash;
                        var itemInfo = await PixelDrainService.CloudFileInfo.GetFileInfoAsync(item.CloudEntry.PublicFileId);

                        listViewItem.SubItems.Add(itemInfo.MimeType);
                        listViewItem.SubItems.Add($"{FileOperations.GetSizeString((int)itemInfo.Size)}");
                        listViewItem.SubItems.Add(item.Identity.Timestamp.ToShortDateString() + " - " + item.Identity.Timestamp.ToShortTimeString());

                        if (File.Exists(item.File.RealPath))
                        {
                            listViewItem.SubItems.Add("Local/Cloud");
                        }
                        else
                        {
                            listViewItem.SubItems.Add("Cloud");
                        }

                        listView1.Items.Add(listViewItem);
                    }

                    prgMiniProgress.Visible = false;
                }));
            });
        }

        private async void DownloadFile(MatrixEntry entry, bool toCrypterv2 = true, string dir = null)
        {
            string placedDirectory = dir;

            if (entry is null)
            {
                throw new MatrixEntryNullException();
            }

            var pic = await PixelDrainService.PixelDrainThumbnail.GetThumbnailAsync(entry.CloudEntry.PublicFileId);

            if (toCrypterv2)
            {
                placedDirectory = entry.File.RealPath;
                SubOp_lblToLocation.Text = "Crypterv2 DB";
            }
            else
            {
                SubOp_lblToLocation.Text = "Custom Dir";
            }

            SubOp_lblFileName.Text = entry.File.FileName;
            SubOp_lblOperationType.Text = "Requesting...";
            SubOp_pnlIco.BackgroundImage = pic;
            SubOp_ProgressBar.Value = 0;

            SubOp.Visible = true;

            await Task.Run(async () =>
            {
                try
                {
                    await PixelDrainService.DownloadFileAsync(entry.CloudEntry.PublicFileId, placedDirectory,
                    (e, s) =>
                    {
                        this.Invoke(() =>
                        {
                            SubOp_lblOperationType.Text = "Downloading...";
                            SubOp_ProgressBar.Maximum = (int)s;
                            SubOp_ProgressBar.Value = (int)e;

                            if (e == s)
                            {
                                Process.Start("explorer.exe", placedDirectory);

                                this.Invoke(() =>
                                {
                                    SubOp.Visible = false;
                                });
                            }
                        });
                    });
                }
                catch (Exception ex)
                {
                    this.Invoke(() =>
                    {
                        MessageBox.Show(ex.Message, "MainHost - Cloud", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });
                }

            });
        }

        private MatrixEntry SelectedMatrixEntry
        {
            get
            {
                MatrixEntry entry = null;
                foreach (var item in MatrixEntries)
                {
                    if (item.Identity.FileHash == listView1.SelectedItems[0].Tag) entry = item;
                }

                return entry;
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", SelectedMatrixEntry.File.RealPath);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(SelectedMatrixEntry.File.RealPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MainHost - Cloud", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void compareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void toCrypterv2StorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DownloadFile(SelectedMatrixEntry);
        }

        private void toDownloadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileOperations.CreateDirectoryRecursively(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\LILO Cloud");
            DownloadFile(SelectedMatrixEntry, false, (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\LILO Cloud"));
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var infoDialog = new uiCloudFileDetails(SelectedMatrixEntry);
            infoDialog.ShowDialog();
        }
    }
}
