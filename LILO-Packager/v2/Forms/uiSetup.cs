using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LILO_Packager.v2.Forms
{
    public partial class uiSetup : Form
    {
        public uiSetup()
        {
            InitializeComponent();
        }

        private void uiSetup_Load(object sender, EventArgs e)
        {
            lblVersion_left.Text = Program.Version;
            var text = File.ReadAllText(".\\cloud_assets\\readme.rtf");
            richText.Rtf = text;
        }

        private void CheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            bntSync.Enabled = CheckBox.Checked;
        }

        private void bntSync_Click(object sender, EventArgs e)
        {
            config.Default.aggrementAccepted = true;
            config.Default.Save();
            Application.Restart();
        }
    }
}
