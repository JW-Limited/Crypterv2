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
    [ToolboxBitmap(".\\Resources\\Close.png")]
    [ToolboxItem(true)]
    [Bindable(true)]
    public partial class DynamicPluginListItem : UserControl
    {
        public DynamicPluginListItem()
        {
            InitializeComponent();
        }

        [Bindable(true)]
        [Category("Data")]
        public object DataContext { get; set; }

        public void Bind(object dataContext, string dataMember)
        {
            DataContext = dataContext;
            lblProductName.DataBindings.Add(new Binding("Text", dataContext, dataMember));
            lblVersion.DataBindings.Add(new Binding("Text", dataContext, dataMember));
            lblPluginInfo.DataBindings.Add(new Binding("Text", dataContext, dataMember));
        }

        public void Unbind()
        {
            DataContext = null;
            lblProductName.DataBindings.Clear();
            lblVersion.DataBindings.Clear();
            lblPluginInfo.DataBindings.Clear();
        }

        public string ButtonText
        {
            get => bntDownload.Text;
            set => bntDownload.Text = value;
        }

        [Category("Color Pallet")]
        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }
        [Category("Color Pallet")]
        public Color ControlBackgroundColor
        {
            get => pnlPluginEntry.BackColor;
            set => pnlPluginEntry.BackColor = value;
        }
        [Category("Color Pallet")]
        public Color PluginNameForeColor
        {
            get => lblProductName.ForeColor;
            set => lblProductName.ForeColor = value;
        }
        [Category("Color Pallet")]
        public Color PluginDescriptionForeColor
        {
            get => lblPluginInfo.ForeColor;
            set => lblPluginInfo.ForeColor = value;
        }
        [Category("Color Pallet")]
        public Color PluginVersionForeColor
        {
            get => lblVersion.ForeColor;
            set => lblVersion.ForeColor = value;
        }
        [Category("Color Pallet")]
        public Color DownloadButtonForeColor
        {
            get => bntDownload.ForeColor;
            set => bntDownload.ForeColor = value;
        }
        [Category("Color Pallet")]
        public Color DownloadButtonBackColor
        {
            get => bntDownload.FillColor;
            set => bntDownload.FillColor = value;
        }
        [Category("Color Pallet")]
        public Color BorderColor
        {
            get { return pnlPluginEntry.BorderColor; }
            set => pnlPluginEntry.BorderColor = value;
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

        public Image PluginIcon
        {
            get => pnlIcon.BackgroundImage;
            set => pnlIcon.BackgroundImage = value;
        }

        [Category("Behavior")]
        public bool ButtonVisible
        {
            get => bntDownload.Visible;
            set => bntDownload.Visible = value;
        }

        [Category("Behavior")]
        public int BorderRadius
        {
            get => pnlPluginEntry.BorderRadius;
            set => pnlPluginEntry.BorderRadius = value;
        }

        [Category("Behavior")]
        public int BorderThickness
        {
            get => pnlPluginEntry.BorderSize;
            set => pnlPluginEntry.BorderSize = value;
        }

        [Category("Behavior")]
        public PluginState Plugin_State 
        {
            get; set;
               
        }

        public enum PluginState
        {
            Unknown,
            Available,
            Installed,
        }

        public event EventHandler ClickedDownload;

        private void bntDownload_Click(object sender, EventArgs e)
        {
            ClickedDownload?.Invoke(this, e);
        }

        private void pnlPluginEntry_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPluginEntry_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}