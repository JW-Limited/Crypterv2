using LILO_Packager.v2.Core;
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

namespace LILO_Packager.v2.Forms;
public partial class uiWebView : Form
{
    private static uiWebView _webView;
    private static object _lock = new object();
    private static Uri _url = null;

    public static uiWebView Instance(Uri uri)
    {
        lock (_lock)
        {
            if (_webView is null)
            {
                _webView = new uiWebView();
            }

            if (uri != _url && uri is not null)
            {
                _webView.ChangeDisplayedContent(uri);
            }

            return _webView;
        }
    }

    private uiWebView()
    {
        InitializeComponent();

        this.FormClosing += (sender, e) =>
        {
            e.Cancel = true;
            this.Hide();
        };
    }

    private void uiWebView_Load(object sender, EventArgs e)
    {
        webView21.CreateControl();
        webView21.CreateGraphics();
        webView21.Show();

        ConsoleManager.Instance().WriteLineWithColor("Initializing WebView2 Core.", ConsoleColor.Cyan);
    }

    private void ChangeDisplayedContent(Uri newUri)
    {
        try
        {
            if (newUri is null) { return; }

            webView21.Source = newUri;

            webView21.NavigationStarting += (sender, e) =>
            {
                pnlError.Visible = false;
                progressSpinner.Visible = true;
                pnlLoading.Visible = true;
                bntTrouble.Visible = false;
            };

            webView21.NavigationCompleted += (sender, e) =>
            {
                if (e.IsSuccess)
                {
                    progressSpinner.Visible = false;
                    pnlLoading.Visible = false;
                }
                else
                {
                    pnlError.Visible = true;
                    bntTrouble.Visible = true;
                    lblExc.Text = "Something went wrong!";
                }

            };

            _url = newUri;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void bntOpen_Click(object sender, EventArgs e)
    {
        pnlError.Visible = false;
        bntTrouble.Visible = false;
        webView21.Reload();
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
        var trouble = uiCare.Instance();
        trouble.ShowDialog();
    }

    private void bntBack_Click(object sender, EventArgs e)
    {
        webView21.GoBack();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
}
