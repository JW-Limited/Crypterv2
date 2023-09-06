using LILO_Packager.v2.Core.Debug;
using LILO_Packager.v2.shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void uiDebugSessionLogViewer_Load(object sender, EventArgs e)
        {
            lblSessionName.Text = _session.SessionName;
            lblCreated.Text = "Session from: " + _session.CreatedAt;
            lblCrashed.Text = "Crashed: " + _session.Crashed.ToString();

            mainText.Text = "Started Analizing the Session.\n";
            mainText.Text += ("----------------------------------------\n\n");

            Task.Run(() =>
            {
                logEntries = LogAnalyzer.ParseLog(_session.Content);

                foreach (LogEntry entry in logEntries)
                {
                    mainText.Text += ($"Timestamp: {entry.Timestamp}\n");
                    mainText.Text += ($"Session ID: {entry.SessionID}\n");
                    if (entry.Plugins.Count > 0)
                    {
                        mainText.Text += ("Plugins:\n");
                        foreach (var plugin in entry.Plugins)
                        {
                            mainText.Text += ($"  Description: {plugin.Description} \n");
                            mainText.Text += ($"  Version: {plugin.Version} \n");
                        }
                    }
                    if (entry.Loadings.Count > 0)
                    {
                        mainText.Text += ("Loading Task:\n");
                        foreach (var loading in entry.Loadings)
                        {
                            mainText.Text += ($"  ID: {loading.ID}\n");
                            mainText.Text += ($"  Type: {loading.Type}\n");
                            mainText.Text += ($"  Version: {loading.Version}\n");
                        }
                    }
                    if (!string.IsNullOrEmpty(entry.Arguments))
                    {
                        mainText.Text += ($"Arguments: {entry.Arguments}\n");
                    }
                    if (!string.IsNullOrEmpty(entry.Error))
                    {
                        mainText.Text += ($"An error occurred: {entry.Error}\n");
                    }
                    if (!string.IsNullOrEmpty(entry.SearchingForApplication))
                    {
                        mainText.Text += ($"Searching for Application to open: {entry.SearchingForApplication}\n");
                    }
                    foreach (var regEditEntry in entry.RegEditEntries)
                    {
                        mainText.Text += ($"RegEdit ({regEditEntry.Key}): {regEditEntry.Value}\n");
                    }
                    if (entry.ShowedPreviewer)
                    {
                        mainText.Text += ("Showed Previewer\n");
                    }
                    mainText.Text += ("----------------------------------------\n");

                }

                pnlLoading.Visible = false;
            });

            
        }
        public void AnalyzeLog(List<LogEntry> logEntries)
        {
            pnlLoading.Visible = true;
            Task.Run(() =>
            {
                bool errorOccurred = false;
                bool showedPreviewer = false;
                bool openedApplication = false;

                foreach (LogEntry entry in logEntries)
                {
                    if (!string.IsNullOrEmpty(entry.Error))
                    {
                        mainText.Text += ("An error occurred:\n\n");
                        mainText.Text += (entry.Error);
                        errorOccurred = true;
                        break;
                    }

                    if (entry.ShowedPreviewer)
                    {
                        showedPreviewer = true;
                    }

                    if (!string.IsNullOrEmpty(entry.SearchingForApplication))
                    {
                        openedApplication = true;
                    }
                }

                if (errorOccurred)
                {
                    mainText.Text += ("\n\nSession experienced errors. Please Report this Session via the Report Button.");

                    bntOPen.Enabled = true;
                }
                else
                {
                    mainText.Text += ("Session overview:\n\n");

                    if (showedPreviewer)
                    {
                        mainText.Text += ("- Previewer was shown.");
                    }

                    if (openedApplication)
                    {
                        mainText.Text += ("- Application was opened.");
                    }

                    foreach (LogEntry entry in logEntries)
                    {
                        foreach (var regEditEntry in entry.RegEditEntries)
                        {
                            mainText.Text += ($"- RegEdit ({regEditEntry.Key}): {regEditEntry.Value}");
                        }

                        foreach (var plugin in entry.Plugins)
                        {
                            mainText.Text += ($"- Plugin: {plugin.Description} (Version: {plugin.Version})");
                        }

                        foreach (var loading in entry.Loadings)
                        {
                            mainText.Text += ($"- Loading (ID: {loading.ID}, Type: {loading.Type}, Version: {loading.Version})");
                        }

                        if (!string.IsNullOrEmpty(entry.Arguments))
                        {
                            mainText.Text += ($"- Arguments: {entry.Arguments}");
                        }
                    }
                }

                pnlLoading.Visible = false;
            });
            
        }


        public void SummarizeLog(List<LogEntry> logEntries)
        {
            bool errorOccurred = false;

            foreach (LogEntry entry in logEntries)
            {
                if (!string.IsNullOrEmpty(entry.Error))
                {
                    mainText.Text += ("An error occurred:\n\n");
                    mainText.Text += (entry.Error);
                    errorOccurred = true;
                    break;
                }
            }

            if (!errorOccurred)
            {
                mainText.Text += ("Summary of events:\n\n");

                foreach (LogEntry entry in logEntries)
                {
                    if (!string.IsNullOrEmpty(entry.SearchingForApplication))
                    {
                        mainText.Text += ($"- Searching for Application to open: {entry.SearchingForApplication}\n");
                    }

                    foreach (var regEditEntry in entry.RegEditEntries)
                    {
                        mainText.Text += ($"- RegEdit ({regEditEntry.Key}): {regEditEntry.Value}\n");
                    }

                    if (entry.ShowedPreviewer)
                    {
                        mainText.Text += ("- Showed Previewer\n");
                    }

                    foreach (var plugin in entry.Plugins)
                    {
                        mainText.Text += ($"- Plugin: {plugin.Description} (Version: {plugin.Version})\n");
                    }

                    foreach (var loading in entry.Loadings)
                    {
                        mainText.Text += ($"- Loading (ID: {loading.ID}, Type: {loading.Type}, Version: {loading.Version})\n");
                    }

                    if (!string.IsNullOrEmpty(entry.Arguments))
                    {
                        mainText.Text += ($"- Arguments: {entry.Arguments}\n");
                    }
                }
            }
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
            mainText.Text = string.Empty;

            AnalyzeLog(logEntries);
        }
    }
}

public class EmailHelper
{
    public static void OpenDefaultEmailClient(string emailAddress, string subject, string body, params string[] attachments)
    {
        string uri = $"mailto:{Uri.EscapeDataString(emailAddress)}?subject={Uri.EscapeDataString(subject)}&body={Uri.EscapeDataString(body)}";

        if (attachments != null && attachments.Length > 0)
        {
            string attachmentList = string.Join(",", attachments);
            uri += $"&attachment={attachmentList}";
        }

        try
        {
            Process.Start(uri);
        }
        catch (Exception ex)
        {
            ConsoleManager.Instance().WriteLineWithColor($"An error occurred: {ex.Message}",ConsoleColor.DarkRed);
        }
    }
}