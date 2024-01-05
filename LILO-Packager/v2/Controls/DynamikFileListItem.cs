using LILO_Packager.v2.Cloud.Storage;
using LILO_Packager.v2.Forms;
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
    public partial class DynamikFileListItem : UserControl
    {
        public DynamikFileListItem()
        {
            InitializeComponent();
        }

        public string PluginName
        {
            get => lblPluginName.Text;
            set => lblPluginName.Text = value;
        }

        public string PluginVersion
        {
            get => lblDescription.Text;
            set => lblDescription.Text = value;
        }

        public MatrixEntry Entry { get; set; }
        public uiImportSharedFiles ShowedInstance { get; set; }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ShowedInstance.SetFile(Entry);
        }
    }
}
