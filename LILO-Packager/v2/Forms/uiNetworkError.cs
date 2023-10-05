using LILO_Packager.v2.Core.Updates;
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
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;

namespace LILO_Packager.v2.Forms
{
    public partial class uiNetworkError : Form
    {
        public uiNetworkError(string Exception, string Message)
        {
            InitializeComponent();

            lblExc.Text = Exception;
            lblMes.Text = Message;
        }

        private void uiFeatureNullException_Load(object sender, EventArgs e)
        {
            ConsoleManager.Instance().WriteLineWithColor("The user wanted to use a feature that is not activated for him.", ConsoleColor.DarkRed);
        }

        private void bntTrouble_Click(object sender, EventArgs e)
        {
            uiLILOAccountLogin.Instance().ShowDialog();
        }

        private void bntRetry(object sender, EventArgs e)
        {
            var updater = Updater.Instance();

            try
            {
                var currentVersion = Program.Version.ToString();
                var latestVersion = updater.GetLatestVersion(MainHost.Instance().Owner, MainHost.Instance().Repository);
                var Semi = VersionComparer.CompareSemanticVersions(currentVersion, latestVersion);

                MainHost.Instance().pnlSide.Visible = false;

                MainHost.Instance().hider.Visible = true;

                MainHost.Instance().OpenInApp(v2.Forms.uiWebView.Instance(new Uri("http://localhost:8080")));

                this.Close(); 

            }
            catch (System.AggregateException ex)
            {
                ConsoleManager.Instance().WriteLineWithColor(ex.Message, ConsoleColor.DarkRed);

                MainHost.Instance().pnlSide.Visible = false;

                MainHost.Instance().hider.Visible = false;
            }
        }
    }
}
