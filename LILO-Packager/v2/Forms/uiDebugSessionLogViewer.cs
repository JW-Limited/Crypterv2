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

        private void uiDebugSessionLogViewer_Load(object sender, EventArgs e)
        {
            lblSessionName.Text = _session.SessionName;
            mainText.Text = _session.Content;
            lblCreated.Text = "Session from: " + _session.CreatedAt;
            lblCrashed.Text = "Crashed: " + _session.Crashed.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void bntOPen_Click(object sender, EventArgs e)
        {
            EmailHelper.OpenDefaultEmailClient("Joey_West@thekingjw.onmicrosoft.com", "Report Session", "An Error Accoured", _session.FileName);

            this.Close();
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