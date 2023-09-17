using LILO_Packager.v2.Forms;
using LILO_Packager.Properties;
using LILO_Packager.v2.shared;
using LILO_Packager.v2.streaming.MusikPlayer.Core;
using LILO_Packager.v2.streaming.MusikPlayer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LILO_Packager.v2.Core;
using LILO_Packager.v2.Core.AsyncTasks;

namespace LILO_Packager.v2.Forms
{
    public partial class uiArgumentStart : Form
    {

        private static EncryptedFile file = null;
        private static uiArgumentStart _instance;

        private bool istreamingReady = false;

        private string tempFile = Path.Combine(Path.GetTempPath(), new Random().NextInt64(9999, 12345) + "temp_lsf.mp3");
        public Core.History.DatabaseHandling dbHandler = new Core.History.DatabaseHandling();

        public static uiArgumentStart Instance(EncryptedFile enfile)
        {
            if (_instance == null)
            {
                _instance = new uiArgumentStart(enfile);
            }

            return _instance;
        }

        public uiArgumentStart(EncryptedFile enfile)
        {
            InitializeComponent();

            file = enfile;
        }

        private async void uiArgumentStart_Load(object sender, EventArgs e)
        {
            if(file is not null)
            {
                this.lblName.Text = file.FileName;
                this.lblSize.Text = file.Size;


                await FeatureManager.LoadConfigurationAsync();

                await dbHandler.InitializeDatabaseAsync(process =>
                {

                });

                if (file.Encryption == ".lsf")
                {

                    this.lblEncryption.Text = "LILO Secured";
                }

                if ((file.Path.Replace(".lsf", "").EndsWith("mp3") || file.Path.Replace(".lsf", "").EndsWith("wav")) && FeatureManager.IsFeatureEnabled(FeatureFlags.SecuredContainerStreaming))
                {
                    bntCrypter.Text = "Stream";
                }
            }
            
        }

        private void UpdateProgress(double progres)
        {
            progress1.Value = Convert.ToInt32(progres);
            taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.Normal;
            taskBarProgress.Value = Convert.ToInt32(progres);
        }

        public string GetPasswordFrromUser()
        {
            if (pswDialog.ShowDialog() == DialogResult.OK)
            {
                return pswDialog.Input;
            }

            return null;
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if(bntCrypter.Text == "Stream")
            {
                string psw = null;

                if (!istreamingReady) psw = GetPasswordFrromUser();
                else psw = "n/a";

                if (psw is not null or "")
                {
                    
                    try
                    {
                        bool errorHappend = false;

                        await dbHandler.InsertEncryptedOperationAsync("Streaming", "AppCore", "v0.2beta", "n/a", "n/a", "0");

                        if (istreamingReady)
                        {
                            var player = uiPlayer.Instance(null,false);
                            player.ShowDialog();
                        }
                        else
                        {
                            await Services.DecryptAndDecompressFileAsync(file.Path, tempFile, psw,
                            progress =>
                            {
                                //UpdateProgress(progress);
                            },
                            error =>
                            {
                                errorHappend = true;

                                ShowError("Encryption Error", error.Message);
                            },
                            async currentTask =>
                            {

                            },
                            false
                          );

                            if (!errorHappend)
                            {
                                istreamingReady = true;

                                var para = await MusicPlayerParameters.Get(tempFile);

                                var player = uiPlayer.Instance(para,false);
                                player.ShowDialog();
                            }

                            
                        }
                        
                    }
                    catch (Exception ey)
                    {
                        ControlEnable(true);

                        ShowError("Error", ey.Message);
                    }
                }
                else
                {

                }
            }
            else
            {
                Process.Start(Application.ExecutablePath);
                this.Close();
            }
        }

        public async void ControlEnable(bool disable, string decryptedFile = null)
        {
            if (disable && decryptedFile is not null)
            {
                var info = new FileInfo(decryptedFile);

                if (decryptedFile.Replace(".lsf", "").Contains("collected_files"))
                {
                    var items = await dbHandler.GetAllEncryptedOperationsAsync();

                    foreach (var env in items)
                    {
                        if ($"{env.outputFileName}" == decryptedFile)
                        {

                            try
                            {
                                Directory.CreateDirectory(decryptedFile.Replace(".lsf", "").Replace(".zip", ""));

                                var handler = new shared.MultiplefileHandling();
                                var tempZip = info.FullName.Replace(info.Name, "") + $"{new Random().NextInt64(1111111, 9999999)}_collected_files.zip";
                                var musltifileHandler = new shared.MultiplefileHandling();
                                var asyncTask = new Core.AsyncTasks.AsyncTask("Mainhost - Task", TaskMode.Copying, async (progress) =>
                                {

                                    var unzipProgress = new Progress<int>(progressPercentage =>
                                    {
                                        progress?.Report(progressPercentage);
                                    });


                                    await handler.UnzipFilesAsync(decryptedFile.Replace(".lsf", ""), decryptedFile.Replace(".lsf", "").Replace(".zip", ""), unzipProgress);
                                });

                                var uiAsyncTask = new uiCustomProcess(asyncTask);
                                uiAsyncTask.ShowDialog();

                                File.Delete(decryptedFile.Replace(".lsf", ""));
                            }
                            catch (Exception ex)
                            {
                                ShowError("File Operation", ex.Message + decryptedFile.Replace(".lsf", "").Replace(".zip", ""));
                            }

                        }
                    }
                }
            }

            bntDecrypt.Visible = disable;
            this.ControlBox = disable;
            bntCrypter.Enabled = disable;
            progress1.Visible = !disable;
        }

        private async void bntDecrypt_Click(object sender, EventArgs e)
        {
            if (bntDecrypt.Text is not "Open")
            {
                var psw = GetPasswordFrromUser();

                if (psw is not null or "")
                {

                    ControlEnable(false);

                    try
                    {
                        await dbHandler.InsertEncryptedOperationAsync("Decryption", "AppCore", "v1", file.Path, file.Path.Replace(".lsf", ""), $"{new Random().NextInt64(11111, 99999)}");

                        Task.Run(() =>
                        {

                            Services.DecryptAndDecompressFileAsync(file.Path, file.Path.Replace(".lsf", ""), psw,
                            progress =>
                            {
                                UpdateProgress(progress);
                            },
                            error =>
                            {
                                ShowError("Encryption Error", error.Message);
                            },
                            currentTask =>
                            {


                                if (currentTask == "success")
                                {

                                    taskBarProgress.Value = 0;
                                    taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.NoProgress;
                                    ControlEnable(true, file.Path.Replace(".lsf", ""));
                                    istreamingReady = true;
                                    bntDecrypt.Text = "Open";
                                    imgImage.BackgroundImage = Resources.Padlock;
                                    lblEncryption.Text = "None";

                                }
                            });
                        });
                    }
                    catch (Exception ey)
                    {
                        ControlEnable(true);

                        ShowError("Error", ey.Message);
                    }
                }
                else
                {

                }
            }
            else
            {
                Process.Start("explorer.exe", file.Path.Replace(".lsf", ""));
                this.Close();
            }

        }

        private void ShowError(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
