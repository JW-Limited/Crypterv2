using Crypterv2.DevTool.Core.Plugins.Types;
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

namespace Crypterv2.DevTool.Core.Forms
{
    public partial class uiPluginPackageView : Form
    {
        public readonly PluginPackage _package;

        public uiPluginPackageView(PluginPackage package)
        {
            InitializeComponent();

            _package = package;
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiPluginPackageView_Load(object sender, EventArgs e)
        {
            lblVerison.Text = Crypterv2_DevTool.Program.Version;
            lblPlugin.Text = _package.Name;
            lblDirectory.Text = _package.PluginDirectory;
        }

        private void bntStart_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", _package.PluginDirectory);
        }

        private void bntPublishToStore_Click(object sender, EventArgs e)
        {
            var proc = Process.Start(new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = "https://github.com/JW-Limited/Crypterv2"
            });
        }
    }
}
