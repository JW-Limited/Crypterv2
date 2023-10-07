using LILO_Packager.v2.Shared;
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
    public partial class uiFeatureNullException : Form
    {
        public uiFeatureNullException(string Exception, string Message)
        {
            InitializeComponent();

            lblExc.Text = Exception;
            lblMes.Text = Message;
        }

        private void uiFeatureNullException_Load(object sender, EventArgs e)
        {
            ConsoleManager.Instance().WriteLineWithColor("The user wanted to use a feature that is not activated for him.",ConsoleColor.DarkRed);
        }

        private void bntTrouble_Click(object sender, EventArgs e)
        {
            ConsoleManager.Instance().WriteLineWithColor("Starting App \"FeatureManager\" - (https://beta.lilo.com/featureManagment#coutryRestriction)", ConsoleColor.Yellow);
            MainHost.Instance().OpenInApp(uiWebView.Instance(new Uri("https://beta.lilo.com/featureManagment#coutryRestriction")));
        }
    }
}
