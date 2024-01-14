using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextPreviewLibrary.Core;

namespace TextPreviewLibrary.Controls
{
    public partial class DynamikPluginListItem : UserControl
    {
        public DynamikPluginListItem()
        {
            InitializeComponent();
        }

        public string TabName
        {
            get => lblPluginName.Text;
            set => lblPluginName.Text = value;
        }

        public string Content { get; set; } = "";

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            PluginInterface.Instance(false).mainTextBox.Rtf = Content;
        }
    }
}
