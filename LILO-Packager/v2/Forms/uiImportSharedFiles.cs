using LILO_Packager.v2.Cloud.Services;
using LILO_Packager.v2.Cloud.Storage;
using LILO_Packager.v2.Controls;
using LILO_Packager.v2.Core.AsyncTasks;
using System.Diagnostics;

namespace LILO_Packager.v2.Forms
{
    public partial class uiImportSharedFiles : Form
    {
        public uiImportSharedFiles(string file)
        {
            InitializeComponent();

            CDEXFile = file;
        }

        public string CDEXFile { get; set; }
        public CDEX_FILE_DECLARATION CDEX_FILE_DECLARATION { get; set; }
        public MatrixEntry SelectedMatrixEntry { get; set; }

        private void uiImportSharedFiles_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke(() =>
                {
                    lblArchieveName.Text = new FileInfo(CDEXFile).Name;

                    CDEX_FILE_DECLARATION = MatrixShareManager.GetPackageDeclaration(CDEXFile);

                    foreach (var item in CDEX_FILE_DECLARATION.MatrixEntries)
                    {
                        var user = MatrixShareManager.GetFileOwner(CDEX_FILE_DECLARATION, CDEXFile, item.Identity.FileHash);
                        AddToPluginList(item.File.FileName, "Owned by: " + user.Name, item);
                    }

                    lblEntry.Text = CDEX_FILE_DECLARATION.MatrixEntries.Count.ToString();
                });
            });
        }

        public async Task SetFile(MatrixEntry entry)
        {
            var fileInfo = MatrixShareManager.GetPackageDeclaration(CDEXFile);
            var user = MatrixShareManager.GetFileOwner(fileInfo, CDEXFile, entry.Identity.FileHash);
            prgMiniProgress.Visible = true;
            lblFileName.Text = entry.File.FileName;
            lblDescription.Text = "Owned by: " + user.Name + " - " + user.Email;
            pnlIcon.BackgroundImage = await Cloud.Services.PixelDrainService.PixelDrainThumbnail.GetThumbnailAsync(entry.CloudEntry.PublicFileId);
            SelectedMatrixEntry = entry;
            pnlFile.Visible = true;
            pnlPreview.Visible = true;
            var result = await Cloud.Services.PixelDrainService.WebviewPreview.GetPreview(entry, (p, c) => { if (p == c) this.Invoke(() => prgMiniProgress.Visible = false); });
        }

        public int Height;

        public Task AddToPluginList(string name, string username, MatrixEntry entry)
        {
            var uiElement = new DynamikFileListItem();
            uiElement.PluginName = name;
            uiElement.PluginVersion = username;
            uiElement.Entry = entry;
            uiElement.ShowedInstance = this;

            pnlPlugins.Controls.Add(uiElement);
            pnlPlugins.Show();

            uiElement.Location = new Point(0, Height);
            uiElement.Width = pnlPlugins.Width;
            uiElement.Height = 72;

            Height += uiElement.Height + 20;

            return Task<Task>.CompletedTask;
        }

        private void bntPlugin_Click(object sender, EventArgs e)
        {
            MainHost.Instance().OpenInApp(uiCloudSyncronization.Instance);
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Button2.Enabled = false;
            pnlLoadButton.Visible = true;

            await PixelDrainService.DownloadFileAsync(SelectedMatrixEntry.CloudEntry.PublicFileId, PixelDrainService.WebviewPreview.TempPath + $"\\tempDownloader~{SelectedMatrixEntry.File.FileName}",
             (p, c) =>
             {
                 if (p == c)
                 {
                     this.Invoke(() =>
                     {
                         guna2Button2.Enabled = true;
                         pnlLoadButton.Visible = false;
                         Process.Start("explorer.exe", PixelDrainService.WebviewPreview.TempPath + $"\\tempDownloader~{SelectedMatrixEntry.File.FileName}");
                     });
                 }
             });
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var matrix = SelectedMatrixEntry;
            var asyncTask = new Core.AsyncTasks.AsyncTask("Mainhost - Task", TaskMode.Updating, async (progress) =>
            {
                var entries = 0;
                foreach(var item in CDEX_FILE_DECLARATION.MatrixEntries)
                {
                    entries++;

                    if(MatrixShareManager.CheckIfEntryExist(CDEXFile,item.Identity.FileHash) == 1)
                    {
                        FileIndexStorage.Instance.AddMatrixEntry(item);
                    }

                    progress?.Report((entries / CDEX_FILE_DECLARATION.MatrixEntries.Count) * 100);
                }

                bntPlugin_Click(sender,e);
            });

            var uiAsyncTask = new uiCustomProcess(asyncTask);
            uiAsyncTask.ShowDialog();
        }
    }
}
