using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LILO_Packager.v2.Plugins.ThirdParty.Forms
{
    public partial class InstallerInfoDialog : Form
    {
        public InstallerInfoDialog()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InstallerInfoDialog_Load(object sender, EventArgs e)
        {
            lblProgVers.Text = Program.Version;
        }

        private void InstallerInfoDialog_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlChild_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
