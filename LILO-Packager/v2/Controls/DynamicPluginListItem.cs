using LILO.Shell;
using LILO_Packager.v2.Shared.Streaming.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LILO_Packager.v2.Controls
{
    public partial class DynamicPluginListItem : UserControl
    {
        public DynamicPluginListItem()
        {
            InitializeComponent();
        }

        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }

        public string PluginName
        {
            get => lblProductName.Text;
            set => lblProductName.Text = value;
        }

        public string PluginVersion
        {
            get => lblVersion.Text;
            set => lblVersion.Text = value;
        }

        public string PluginDescription
        {
            get => lblPluginInfo.Text;
            set => lblPluginInfo.Text = value;
        }

        public Color ControlBackgroundColor
        {
            get => pnlPluginEntry.BackColor;
            set => pnlPluginEntry.BackColor = value;
        }

        public Image PluginIcon
        {
            get => pnlIcon.BackgroundImage;
            set => pnlIcon.BackgroundImage = value;
        }

        public Color PluginNameForeColor
        {
            get => lblProductName.ForeColor;
            set => lblProductName.ForeColor = value;
        }

        public Color PluginDescriptionForeColor
        {
            get => lblPluginInfo.ForeColor;
            set => lblPluginInfo.ForeColor = value;
        }

        public Color PluginVersionForeColor
        {
            get => lblVersion.ForeColor;
            set => lblVersion.ForeColor = value;
        }

        public Color DownloadButtonForeColor
        {
            get => bntDownload.ForeColor;
            set => bntDownload.ForeColor = value;
        }

        public Color DownloadButtonBackColor
        {
            get => bntDownload.BackColor;
            set => bntDownload.BackColor = value;
        }

        public event EventHandler ClickedDownload;

        private void bntDownload_Click(object sender, EventArgs e)
        {
            ClickedDownload?.Invoke(this, e);
        }
    }
}