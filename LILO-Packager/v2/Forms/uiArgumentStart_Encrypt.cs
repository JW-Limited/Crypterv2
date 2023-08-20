using Guna.UI2.WinForms;
using LILO_Packager.Properties;
using LILO_Packager.v2.Core.History;
using LILO_Packager.v2.shared;
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

namespace LILO_Packager.v2.Forms
{
    public partial class uiArgumentStart_Encrypt : Form
    {
        private static uiArgumentStart_Encrypt _instance_de;
        private static DecryptedFile deFile = null;
        private string tempFile = Path.Combine(Path.GetTempPath(), new Random().NextInt64(9999, 12345) + "temp_lsf.mp3");
        public Core.History.DatabaseHandling dbHandler = new Core.History.DatabaseHandling();

        public static uiArgumentStart_Encrypt Instance(DecryptedFile defile)
        {
            if (_instance_de == null)
            {
                _instance_de = new uiArgumentStart_Encrypt(defile);
            }

            return _instance_de;
        }

        public uiArgumentStart_Encrypt(DecryptedFile defile)
        {
            InitializeComponent();
            deFile = defile;
        }
        private async void uiArgumentStart_Encrypt_Load(object sender, EventArgs e)
        {
            if (deFile is not null)
            {
                imgImage.BackgroundImage = Resources.Padlock;

                this.lblName.Text = deFile.FileName;
                this.lblSize.Text = deFile.Size;

                await dbHandler.InitializeDatabaseAsync(process =>
                {

                });

                this.lblEncryption.Text = deFile.Encryption;
            }
        }

        public string GetPasswordFrromUser()
        {
            if (pswDialog.ShowDialog() == DialogResult.OK)
            {
                return pswDialog.Input;
            }

            return null;
        }

        private void OpenCrypter()
        {
            Process.Start(Application.ExecutablePath);
            this.Close();
        }

        private async void bntEncrypt_Click(object sender, EventArgs e)
        {
            var psw = GetPasswordFrromUser();
            var previousFile = "";


            if (psw is not null or "")
            {
                ControlEnable(false);

                try
                {
                    string item = deFile.Path;

                    await dbHandler.InsertEncryptedOperationAsync("Encryption", "libraryBased", "v2", item, item + ".lsf", $"{new Random().NextInt64(11111, 99999)}");

                    Task.Run(() =>
                    {

                        Services.CompressAndEncryptFileAsync(item, item + ".lsf", psw,
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

                                bntEncrypt.Text = "Open";
                                imgImage.BackgroundImage = Resources.Lock;
                                lblEncryption.Text = "LILO Secured";

                                ControlEnable(true);
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
        }
        private void ShowError(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ControlEnable(bool disable)
        {
            bntEncrypt.Visible = disable;
            progress1.Visible = !disable;
            pnlSuccess.Visible = disable;
        }

        private void UpdateProgress(double progres)
        {
            progress1.Value = Convert.ToInt32(progres);
            taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.Normal;
            taskBarProgress.Value = Convert.ToInt32(progres);
        }

        private void bntCrypter_Click(object sender, EventArgs e)
        {
            OpenCrypter();
        }
    }
}
