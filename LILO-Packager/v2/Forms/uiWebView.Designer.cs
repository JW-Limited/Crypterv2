namespace LILO_Packager.v2.Forms;

partial class uiWebView
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
        progressSpinner = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
        ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
        SuspendLayout();
        // 
        // webView21
        // 
        webView21.AllowExternalDrop = true;
        webView21.CreationProperties = null;
        webView21.DefaultBackgroundColor = Color.White;
        webView21.Dock = DockStyle.Fill;
        webView21.Location = new Point(0, 0);
        webView21.Name = "webView21";
        webView21.Size = new Size(1020, 948);
        webView21.Source = new Uri("D:\\LILO\\source\\repos\\LILO-Packager\\LILO-Packager\\bin\\Debug\\net7.0-windows\\html\\index.html", UriKind.Absolute);
        webView21.TabIndex = 0;
        webView21.ZoomFactor = 1D;
        // 
        // progressSpinner
        // 
        progressSpinner.Anchor = AnchorStyles.None;
        progressSpinner.AutoStart = true;
        progressSpinner.BackColor = Color.White;
        progressSpinner.Location = new Point(443, 407);
        progressSpinner.Name = "progressSpinner";
        progressSpinner.Size = new Size(135, 135);
        progressSpinner.TabIndex = 7;
        // 
        // uiWebView
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1020, 948);
        ControlBox = false;
        Controls.Add(progressSpinner);
        Controls.Add(webView21);
        Name = "uiWebView";
        Text = "uiWebView";
        Load += uiWebView_Load;
        ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    private Guna.UI2.WinForms.Guna2WinProgressIndicator progressSpinner;
}