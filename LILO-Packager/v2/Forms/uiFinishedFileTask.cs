using LILO_Packager.Properties;
using LILO_Packager.v2.Core.Service;
using LILO_Packager.v2.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LILO_Packager.v2.Forms
{
    public enum FileOperation : uint
    {
        EncryptedFile = 0x1486,
        DecryptedFile = 0x2486
    }

    public partial class uiFinishedFileTask : Form
    {
        FileTaskInformation _fileInfo = new FileTaskInformation();

        public uiFinishedFileTask(FileTaskInformation info)
        {
            InitializeComponent();
            _fileInfo = info;
        }

        private void uiFinishedFileTask_Load(object sender, EventArgs e)
        {
            lblFile.Text = _fileInfo.BeforeFileOperation;
            if(_fileInfo.FileOperationType == FileOperation.EncryptedFile)
            {
                lblType.Text = "Encrypted File";
                pnlPluginIcon.BackgroundImage = Resources.encLib;
            }
            else
            {
                lblType.Text = "Decrypted File";
                pnlPluginIcon.BackgroundImage = FileOperations.GetFileIcon(_fileInfo.AfterFileOperation).ToBitmap();
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntShare(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", new FileInfo(_fileInfo.AfterFileOperation).Directory.FullName);
            this.Close();
        }
    }
}
