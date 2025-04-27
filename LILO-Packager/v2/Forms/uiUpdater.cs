using LILO_Packager.Properties;
using LILO_Packager.v2.Core.Interfaces;
using LILO_Packager.v2.Core.Updates;
using LILO_Packager.v2.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinRT;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace LILO_Packager.v2.Forms
{
    public partial class uiUpdater : Form
    {
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public bool updating = false;
        public bool downloaded = false;
        public Action<bool> isEnabling;
        public string owner = "JW-Limited";
        public string repo = "Crypterv2";
        public string zipPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "JW Limited\\Crytpterv2\\temp\\latest_release.zip");

        public uiUpdater(ICrypterv2Version version)
        {
            if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "JW Limited\\Crytpterv2\\temp"))) Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "JW Limited\\Crytpterv2\\temp"));

            InitializeComponent();
            lblVerison.Text = version.ToString();
        }

        private void UpdateProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                progress.Value = e.ProgressPercentage;

                if (cancellationTokenSource.Token.IsCancellationRequested)
                {
                    updating = false;
                    downloaded = false;
                    lblExc.Text = "Update canceled.";
                    isEnabling?.Invoke(true);
                    Console.WriteLine("Download canceled.");
                    cancellationTokenSource.Dispose();
                    cancellationTokenSource = new CancellationTokenSource();
                }
                else if (e.ProgressPercentage == 100)
                {
                    updating = false;
                    downloaded = true;
                    this.ControlBox = true;
                    isEnabling?.Invoke(true);
                    Console.WriteLine();
                    ExtractPackage();
                }
            });
        }

        public string GetSizeString(long size)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            while (size >= 1024 && order < sizes.Length - 1)
            {
                order++;
                size /= 1024;
            }
            return $"{size} {sizes[order]}";
        }

        public async void ExtractPackage()
        {
            var updater = Updater.Instance();
            var newDir = updater.GetLatestVersion(owner, repo);

            if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "JW Limited\\Crytpterv2\\" + newDir))) Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "JW Limited\\Crytpterv2\\" + newDir));

            await Task.Run(() =>
            {
                try
                {
                    lblExc.Text = "Installing Update...";

                    updater.VerifyAndExtractZip(zipPath, "8a3a0cecf50f9e4a7387b23d4a4c4e4b3d2bbd8e91edc5729c15f9f1f10c8aaf", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "JW Limited\\Crytpterv2\\" + newDir),
                    progress =>
                    {

                        this.progress.Value = progress;

                        if (progress == 100)
                        {
                            lblExc.Text = "Installed Update.";
                            this.progress.Visible = false;
                            this.progress.Value = 0;
                            lblVerison.Visible = false;
                            bntCancel.Visible = false;

                            this.Invoke((MethodInvoker)delegate
                            {
                                bntRestart.Visible = true;
                                pnlImg.BackgroundImage = Resources.icons8_verified_badge_96;
                            });
                        }
                    },
                    error =>
                    {
                        ConsoleManager.Instance().WriteLineWithColor($"Error: {error}", ConsoleColor.DarkRed);
                        pnlImg.BackgroundImage = Resources.Close;
                        MainHost.Instance().Text = "Install Error";
                        lblExc.Text = error;
                        progress.Visible = false;
                        progress.Value = 0;
                        lblVerison.Visible = false;
                        bntCancel.Visible = false;
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Install Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }

        private async void uiUpdater_Load(object sender, EventArgs e)
        {
            var updater = Updater.Instance();

            try
            {
                if (downloaded)
                {
                    isEnabling?.Invoke(false);
                    this.ControlBox = false;
                    updating = true;
                    Text = "Installing Update...";

                    MessageBox.Show("Installed Updates", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    isEnabling?.Invoke(false);
                    lblExc.Text = "Downloading latest release...";
                    this.ControlBox = false;
                    updating = true;

                    await Task.Run(() =>
                    {
                        updater.DownloadLatestRelease(owner, repo, UpdateProgress, cancellationTokenSource.Token);

                        this.Invoke((MethodInvoker)delegate
                        {
                            this.ControlBox = false;
                        });
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                updating = false;
                downloaded = true;
                this.ControlBox = true;
            }
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            if (updating)
            {
                cancellationTokenSource.Cancel();
            }
        }

        private void bntRestart_Click(object sender, EventArgs e)
        {
            var updater = Updater.Instance();
            var newDir = updater.GetLatestVersion(owner, repo);

            NotifyIconManager.Instance().OnExit(sender,e);

            Process.Start(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "JW Limited\\Crytpterv2\\" + newDir, "net7.0-windows10.0.22000.0") + "crypterv2.exe");

        }
    }
}