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
using LILO_Packager.v2.Core.BugBarrier;
using LILO_Packager.v2.Core.BugBarrier.Types;

namespace LILO_Packager.v2.Forms
{
    public partial class uiErrorHandle : Form
    {
        CustomError _error;

        public uiErrorHandle(CustomError error)
        {
            InitializeComponent();

            _error = error ?? new CustomError(ErrorCatcher.ErrorRank.Medium, null, DateTime.Now, null);
        }

        private void uiFeatureNullException_Load(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Type: " + _error.ParsedMessage.ExceptionType.ToString() + "(Risk: " + _error.Rank.ToString() + ")");
            sb.AppendLine("Library: " + _error.ParsedMessage.Library.ToString());
            sb.AppendLine("Method: " + _error.ParsedMessage.Method.ToString());

            lblName.Text = _error.Message;
            lblExc.Text = _error.Timestamp.ToString();
            lblMes.Text = _error.ParsedMessage.ToString();
            lblAddtional.Text = _error.ApplicationVersion.ToString();

            ConsoleManager.Instance().WriteLineWithColor(_error.ParsedMessage.ToString());
        }

        private void bntTrouble_Click(object sender, EventArgs e)
        {
            ConsoleManager.Instance().WriteLineWithColor("Starting App \"FeatureManager\" - (https://beta.lilo.com/featureManagment#coutryRestriction)", ConsoleColor.Yellow);
            MainHost.Instance().OpenInApp(uiWebView.Instance(new Uri("https://beta.lilo.com/featureManagment#coutryRestriction")));
        }
    }
}
