using LILO_Packager.v2.shared;
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
    public partial class uiAgrement : Form
    {
        private static uiAgrement _instance;

        public static uiAgrement Instance()
        {
            if (_instance == null)
            {
                _instance = new uiAgrement();
            }

            return _instance;
        }

        private uiAgrement()
        {
            InitializeComponent();
        }

        private void uiAgrement_Load(object sender, EventArgs e)
        {
            var text = File.ReadAllText(".\\cloud_assets\\readme.rtf");
            richText.Rtf = text;
            richText.ForeColor = Color.White;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiAgrement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Mes1_bnt_Click(object sender, EventArgs e)
        {
            config.Default.aggrementAccepted = true;
            config.Default.Save();
            Application.Restart();
        }
    }
}
