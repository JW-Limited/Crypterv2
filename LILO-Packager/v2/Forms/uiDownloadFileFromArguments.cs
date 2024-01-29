using LILO_Packager.v2.Cloud;
using LILO_Packager.v2.Cloud.Services;
using LILO_Packager.v2.Cloud.Storage;
using LILO_Packager.v2.Core.LILO;
using LILO_Packager.v2.Core.LILO.Types;
using LILO_Packager.v2.Shared;
using System.Diagnostics;
using System.Printing;

namespace LILO_Packager.v2.Forms
{
    public partial class uiDownloadFileFromArguments : Form
    {
        public uiDownloadFileFromArguments(string placeHolder)
        {
            InitializeComponent();

            File = ResolveAgent.ResolveFile(placeHolder);
        }

        private readonly MatrixEntry File;

        private async void uiDownloadFileFromArguments_Load(object sender, EventArgs e)
        {
            _ = Task.Run(async () =>
            {
                

                var itemInfo = await PixelDrainService.CloudFileInfo.GetFileInfoAsync(File.CloudEntry.PublicFileId);
                var picture = await PixelDrainService.PixelDrainThumbnail.GetThumbnailAsync(File.CloudEntry.PublicFileId);

                this.Text = "LILO Cloud";
                this.lblFileName.Text = File.File.FileName;
                this.lblDescription.Text = File.File.DirectoryPath;
                lblSize.Text = FileOperations.GetSizeString(itemInfo.Size);
                lblDateUploaded.Text = File.Identity.Timestamp.ToLocalTime().ToString();
                pnlImage.BackgroundImage = picture;

                if (System.IO.File.Exists(File.File.RealPath))
                {
                    this.Invoke(() =>
                    {
                        pnlProgess.Visible = false;
                        pnlInfos.Visible = true;
                        this.bntCopy.Text = "Open";
                        pnlSuccess.Visible = true;
                        pnlLoading.Visible = false;
                    });

                    return;
                }

                this.Invoke(() =>
                {
                    pnlLoading.Visible = false;
                });
            });

        }

        private async void bntCopy_Click(object sender, EventArgs e)
        {
            if (this.bntCopy.Text == "Open")
            {
                Process.Start("explorer.exe", File.File.RealPath);
                return;
            }
            await DownloadFile(File, false, File.File.DirectoryPath + "\\" + File.File.FileName);
        }

        private async Task DownloadFile(MatrixEntry entry, bool toCrypterv2 = true, string dir = null)
        {
            if (entry is not null)
            {
                string placedDirectory = dir;

                if (entry is null)
                {
                    throw new MatrixEntryNullException();
                }

                if (toCrypterv2)
                {
                    placedDirectory = entry.File.RealPath;
                }

                lblPrgDesc.Text = "Requesting...";
                progress.Value = 0;

                pnlProgess.Visible = true;
                pnlInfos.Visible = false;

                await Task.Run(async () =>
                {
                    try
                    {
                        await PixelDrainService.DownloadFileAsync(entry.CloudEntry.PublicFileId, placedDirectory,
                        (e, s) =>
                        {
                            this.Invoke(() =>
                            {
                                lblPrgDesc.Text = "Downloading...";
                                progress.Maximum = (int)s;
                                progress.Value = (int)e;

                                if (e == s)
                                {
                                    Process.Start("explorer.exe", placedDirectory);

                                    this.Invoke(() =>
                                    {
                                        pnlProgess.Visible = false;
                                        pnlInfos.Visible = true;
                                        this.bntCopy.Text = "Open";
                                        pnlSuccess.Visible = true;
                                    });
                                }
                            });
                        });
                    }
                    catch (Exception ex)
                    {
                        this.Invoke(() =>
                        {
                            MessageBox.Show(ex.Message, "LILO Cloud - Agent", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            this.Invoke(() =>
                            {
                                pnlProgess.Visible = false;
                                pnlInfos.Visible = true;
                                this.Text = "LILO Cloud - Error";
                            });
                        });
                    }

                });
            }
        }

        private void bntShare_Click(object sender, EventArgs e)
        {
            MatrixShareManager.ExportMatrixEntry(File, UserManager.Instance().LoadUserFromFile($"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user.json")}"), (Bitmap)pnlImage.BackgroundImage);
        }
    }
}
