using LILO_Packager.v2.Core;
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

            if (uri != _url)
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

        

    }

    private void ChangeDisplayedContent(Uri newUri)
    {
        try
        {
            if (newUri is null) { return; }

            webView21.Source = newUri;

            webView21.NavigationStarting += (sender, e) =>
            {
                progressSpinner.Visible = true;
            };

            webView21.NavigationCompleted += (sender, e) =>
            {
                progressSpinner.Visible = false;
            };

            _url = newUri;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
