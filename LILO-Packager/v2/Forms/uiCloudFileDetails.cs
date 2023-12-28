using LILO_Packager.v2.Cloud.Services;
using LILO_Packager.v2.Cloud.Storage;
using LILO_Packager.v2.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.FileDialogs.DragDrop;

namespace LILO_Packager.v2.Forms
{
    public partial class uiCloudFileDetails : Form
    {
        public PixelDrainService.CloudFileInfo CloudFileInfo { get; set; }
        public MatrixEntry entry { get; set; }
        public string ID { get; set; }

        public uiCloudFileDetails(MatrixEntry entry)
        {
            InitializeComponent();

            ID = entry.CloudEntry.PublicFileId;
            this.entry = entry as MatrixEntry;
        }

        private async void uiCloudFileDetails_Load(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {

                if (uiCloudFilesViewer.Instance(null).FetchedMatrixEntries.ContainsKey(entry.Identity.FileHash))
                {
                    uiCloudFilesViewer.Instance(null).FetchedMatrixEntries.TryGetValue(entry.Identity.FileHash, out var info);

                    this.Invoke(() =>
                    {
                        pnlImage.BackgroundImage = info.Item1;

                        CloudFileInfo = info.Item2;

                        lblCanBeEdited.Text = CloudFileInfo.CanEdit.ToString();
                        lblDateUploaded.Text = entry.Identity.Timestamp.ToLocalTime().ToString();
                        lblDownloads.Text = CloudFileInfo.Downloads.ToString();
                        lblHash.Text = entry.Identity.FileHash;
                        lblID.Text = CloudFileInfo.Id;
                        lblMimeType.Text = "(.lca) LILO Cloud Anchor";
                        lblSize.Text = FileOperations.GetSizeString(CloudFileInfo.Size);
                        lblFileName.Text = CloudFileInfo.Name;
                        lblDescription.Text = entry.File.DirectoryPath.ToString();

                        pnlLoading.Visible = false;
                    });
                }
                else
                {
                    CloudFileInfo = await PixelDrainService.CloudFileInfo.GetFileInfoAsync(ID);
                    var image = await PixelDrainService.PixelDrainThumbnail.GetThumbnailAsync(ID);

                    this.Invoke(() =>
                    {
                        pnlImage.BackgroundImage = image;

                        lblCanBeEdited.Text = CloudFileInfo.CanEdit.ToString();
                        lblDateUploaded.Text = entry.Identity.Timestamp.ToLocalTime().ToString();
                        lblDownloads.Text = CloudFileInfo.Downloads.ToString();
                        lblHash.Text = entry.Identity.FileHash;
                        lblID.Text = CloudFileInfo.Id;
                        lblMimeType.Text = "(.lca) LILO Cloud Anchor";
                        lblSize.Text = FileOperations.GetSizeString(CloudFileInfo.Size);
                        lblFileName.Text = CloudFileInfo.Name;
                        lblDescription.Text = entry.File.DirectoryPath.ToString();

                        pnlLoading.Visible = false;
                    });
                }


            });

        }

        private void bntCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CloudFileInfo.Id);
        }

        
    }
}
