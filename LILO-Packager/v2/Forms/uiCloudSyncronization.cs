using LILO_Packager.v2.Cloud;
using LILO_Packager.v2.Cloud.Services;
using LILO_Packager.v2.Cloud.Storage;
using LILO_Packager.v2.Contracts;
using LILO_Packager.v2.Core.History;
using LILO_Packager.v2.Shared;
using System.Diagnostics;
using Telerik.Windows.Documents.Flow.FormatProviders.Html;

namespace LILO_Packager.v2.Forms
{
    public partial class uiCloudSyncronization : Form
    {
        private static Lazy<uiCloudSyncronization> instance = new Lazy<uiCloudSyncronization>();
        private ICloudServiceManager CloudServiceManager { get; set; }
        public static uiCloudSyncronization Instance => instance.Value;
        private FileIndexStorage MatrixHandler { get; set; }
        public DatabaseHandling DatabaseHandler { get; set; }
        private List<HistoryElement> LocalFilesList = new List<HistoryElement>();
        public List<string> LocalFilesListPath = new List<string>();
        private List<HistoryElement> UploadedFilesList = new List<HistoryElement>();
        public int UploadedFiles, LocalFiles, IndexedFiles, OnlyCloudFiles = 0;

        public uiCloudSyncronization()
        {
            CloudServiceManager = new CloudServiceManager(new PixelDrainService(), HandleCSM_StatusCallback, HandleCSM_ProcessCallback);
            DatabaseHandler = new DatabaseHandling();
            MatrixHandler = FileIndexStorage.Instance;

            InitializeComponent();

            this.FormClosing += (s, e) =>
            {
                e.Cancel = true;
                this.Hide();
            };
        }

        private async void LoadData()
        {
            var data = await DatabaseHandler.GetAllEncryptedOperationsAsync();
            if (data is not null) LocalFilesList = data;
            else
            {
                await DatabaseHandler.InitializeDatabaseAsync(Console.WriteLine);

            }
        }

        private void HandleCSM_StatusCallback(string message)
        {
            foreach (ListViewItem item in listViewFiles.Items)
            {
                if (item.Text.Contains(message))
                {
                    listViewFiles.Items.Remove(item);
                    UploadedFiles++;
                    LocalFiles--;

                    lblSyncedFiles.Text = $"{UploadedFiles}";

                }
            }

            foreach (var path in LocalFilesListPath)
            {
                if (path.Contains(message)) LocalFilesListPath.Remove(path);
            }

            lblStatus.Text = message;

            if (message == "Everything Done!")
            {
                LoadData();
                UploadedFiles = 0;
                CheckSynchronizedFiles();
            }

        }

        private void HandleCSM_ProcessCallback(long finished, long planed)
        {
            prgMiniProgress.Maximum = (int)planed + 1;
            prgMiniProgress.Value = (int)finished;
        }

        private void CheckSynchronizedFiles()
        {
            EnsureMatrixInitialized();

            var matrixFile = MatrixHandler.GetMatrixFile();
            EnsureValidMatrixFile(matrixFile);

            SynchronizeFiles(matrixFile);

            UpdateUI();
        }

        private void EnsureMatrixInitialized()
        {
            if (MatrixHandler is null)
            {
                throw new MatrixNotInitializedException();
            }
        }

        private void EnsureValidMatrixFile(LocalCloudMatrixFile matrixFile)
        {
            if (matrixFile is null)
            {
                throw new InvalidMatrixFileExcepion();
            }
        }

        private void SynchronizeFiles(LocalCloudMatrixFile matrixFile)
        {

            var LocalHardDrive = 0;
            var itemsExist = 0;

            foreach (var matrixEntry in matrixFile.MatrixEntrys)
            {
                var matchingLocalFile = LocalFilesList.FirstOrDefault(a => a.outputFileName == matrixEntry.File.RealPath);

                if (matchingLocalFile != null)
                {
                    UploadedFilesList.Add(matchingLocalFile);
                    UploadedFiles++;
                    LocalFilesList.Remove(matchingLocalFile);

                    if (File.Exists(matchingLocalFile.outputFileName))
                    {
                        LocalHardDrive++;
                    }
                    else
                    {
                        //ProcessNonMatchingFile(matrixEntry, ref itemsExist);
                    }
                }
                else
                {
                    itemsExist++;
                    //ProcessNonMatchingFile(matrixEntry, ref itemsExist);
                }
            }


            foreach (var localEntrys in LocalFilesList)
            {
                if (File.Exists(localEntrys.outputFileName))
                {
                    LocalHardDrive++;
                    listViewFiles.Items.Add($"[Local({LocalHardDrive})] - {new FileInfo(localEntrys.outputFileName).Name}");
                    LocalFilesListPath.Add(localEntrys.outputFileName);
                }
            }

            LocalFiles = LocalHardDrive;
            OnlyCloudFiles = itemsExist;
        }

        private void ProcessNonMatchingFile(MatrixEntry matrixEntry, ref int items)
        {
            var matchingFiles = LocalFilesList
                .Where(a => File.Exists(a.outputFileName) && a.outputFileName != matrixEntry.File.RealPath)
                .ToList();

            foreach (var localFile in matchingFiles)
            {
                listViewFiles.Items.Add($"[Cloud({items})] - {new FileInfo(localFile.outputFileName).Name}");
                LocalFilesListPath.Add(localFile.outputFileName);

                items++;
            }
        }

        private int locFile = 0;

        private async void UpdateUI()
        {
            locFile = 0;

            foreach (var item in await DatabaseHandler.GetAllEncryptedOperationsAsync())
            {
                if (File.Exists(item.outputFileName)) locFile++;
            }

            lblLocalFiles.Text = $"{locFile}";
            lblSyncedFiles.Text = $"{UploadedFiles}";
            lblAllInCloud.Text = $"{MatrixHandler.GetMatrixFile().MatrixEntrys.Count}";

            prgSynced.Maximum = MatrixHandler.GetMatrixFile().MatrixEntrys.Count + LocalFiles;
            prgSynced.Value = UploadedFiles + MatrixHandler.GetMatrixFile().MatrixEntrys.Count;
        }


        private void uiCloudSyncronization_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Program.CloudVersion;

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

                this.Invoke(() =>
                {
                    UploadedFiles = 0;
                    LocalFiles = 0;
                    IndexedFiles = 0;
                    listViewFiles.Clear();

                    try
                    {
                        LoadData();
                        CheckSynchronizedFiles();
                    }
                    catch (MatrixNotInitializedException ex)
                    {
                        MessageBox.Show(ex.Message, "MainHost - Matrix Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (InvalidMatrixFileExcepion ex)
                    {
                        MessageBox.Show(ex.Message, "MainHost - Matrix Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        ConsoleManager.Instance().WriteLineWithColor(ex.Message);
                    }
                });
            });
            

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                this.Invoke(new Action(() =>
                {
                    prgMiniProgress.Visible = true;
                }));

                await CloudServiceManager.Run(LocalFilesListPath.ToArray());

                this.Invoke(new Action(() =>
                {
                    prgMiniProgress.Visible = false;
                }));
            });
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pnlSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void myFiles(object sender, EventArgs e)
        {
            uiCloudFilesViewer.Instance(CloudServiceManager).ShowDialog();
        }

        private void bntClick_Chekc(object sender, EventArgs e)
        {
            var proc = new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = "https://stats.uptimerobot.com/vB2rASO4Y4"
                }
            };

            proc.Start();
        }

        private void ShareManager_Click(object sender, EventArgs e)
        {
            MainHost.Instance().OpenInApp(new uiShareManager());
        }
    }
}
