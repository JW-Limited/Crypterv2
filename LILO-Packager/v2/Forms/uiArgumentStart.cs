using LILO_Packager.Properties;
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
    public partial class uiArgumentStart : Form
    {
        private static uiArgumentStart _instance;
        private static EncryptedFile file;

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

        private void uiArgumentStart_Load(object sender, EventArgs e)
        {
            this.lblName.Text = file.FileName;
            this.lblSize.Text = file.Size;

            if (file.Encryption == ".lsf")
            {

                this.lblEncryption.Text = "LILO Secured";
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Process.Start(Application.ExecutablePath);
            this.Close();
        }

        public void ControlEnable(bool disable)
        {
            bntDecrypt.Visible = disable;
            this.ControlBox = disable;
            bntCrypter.Enabled = disable;
            progress1.Visible = !disable;
        }

        private void bntDecrypt_Click(object sender, EventArgs e)
        {
            if (bntDecrypt.Text is not "Open")
            {
                var psw = GetPasswordFrromUser();

                if (psw is not null or "")
                {

                    ControlEnable(false);

                    try
                    {

                        Task.Run(() =>
                        {

                            Services.DecryptAndDecompressFileAsync(file.Path, file.Path.Replace(".lsf", ""), psw,
                            progress =>
                            {
                                UpdateProgress(progress);
                            },
                            error =>
                            {
                                //ShowError("Encryption Error", error.Message);
                            },
                            currentTask =>
                            {


                                if (currentTask == "success")
                                {

                                    taskBarProgress.Value = 0;
                                    taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.NoProgress;
                                    ControlEnable(true);

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
