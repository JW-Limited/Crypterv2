using Aqua.EnumerableExtensions;
using LILO_Packager.v2.Core.Debug.Types;
using LILO_Packager.v2.Core.LILO;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LILO_Packager.v2.Forms
{
    public partial class uiDebugSessionLogViewer : Form
    {
        DebugSession _session;

        public uiDebugSessionLogViewer(DebugSession session)
        {
            _session = session;

            InitializeComponent();
        }

        public List<LogEntry> logEntries;

        private async void uiDebugSessionLogViewer_Load(object sender, EventArgs e)
        {
            lblSessionName.Text = _session.SessionName;
            lblCreated.Text = "Session from: " + _session.CreatedAt;
            lblCrashed.Text = "Crashed: " + _session.Crashed.ToString();

            var analyzer = new LogParser(new FileLogReader(_session.FileName));
            var problems = await analyzer.GetProblemsAsync();

            mainText.Text += problems.ToList().StringJoin("\n");

            _ = Task.Run(() =>
                {
                    foreach (var problem in problems)
                    {
                        mainText.Text += problem.Message;

                        mainText.Text += analyzer.ExplainProblem(problem);
                    }
                    pnlLoading.Visible = false;
                });
            

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bntOPen_Click(object sender, EventArgs e)
        {
            EmailHelper.OpenDefaultEmailClient("Joey_West@thekingjw.onmicrosoft.com", "Report Session", "An Error Accoured", _session.FileName);
            this.Close();
        }

        private void lblSessionName_Click(object sender, EventArgs e)
        {

        }

        private void bntAnalyze_Click(object sender, EventArgs e)
        {

        }
    }
}