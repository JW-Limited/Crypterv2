using LILO_Packager.v2.Core.History;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Storage;

namespace LILO_Packager.v2.Forms
{
    public partial class uiHistoryElementInfo : Form
    {
        public HistoryElement _file;

        public uiHistoryElementInfo(HistoryElement ele)
        {
            InitializeComponent();

            _file = ele;
        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr ExtractAssociatedIcon(IntPtr hInst,
                                                            string lpIconPath, out ushort lpiIcon);

        static Icon GetFileIcon(string filePath)
        {
            ushort iconIndex;
            IntPtr hIcon = ExtractAssociatedIcon(IntPtr.Zero, filePath, out iconIndex);
            if (hIcon != IntPtr.Zero)
            {
                Icon icon = (Icon)Icon.FromHandle(hIcon).Clone();
                DestroyIcon(hIcon);
                return icon;
            }
            return null;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool DestroyIcon(IntPtr handle);

        private void uiHistoryElementInfo_Load(object sender, EventArgs e)
        {
            lblFile.Text = new FileInfo(_file.outputFileName).Name;
            lblDirectory.Text = _file.outputFileName.Replace(new FileInfo(_file.outputFileName).Name, "");
            lblDescription.Text = "Library: " + _file.mode;
            lblDes2.Text = "Mode: " + _file.operationType;
            lbl3.Text = "Algorythemversion: " + _file.algorithmVersion;

            var fileIcon = GetFileIcon(_file.outputFileName);
            pnlImage.BackgroundImage = fileIcon.ToBitmap();
        }

        private void bntOpen_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", _file.outputFileName);
            MainHost.Instance().OpenInApp(v2.Forms.uiHistory.Instance());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MainHost.Instance().OpenInApp(v2.Forms.uiHistory.Instance());
        }
    }
}
