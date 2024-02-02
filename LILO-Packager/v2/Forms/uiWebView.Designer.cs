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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiWebView));
        webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
        progressSpinner = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
        pnlLoading = new Panel();
        bntBack = new Guna.UI2.WinForms.Guna2Button();
        label1 = new Label();
        bntTrouble = new Guna.UI2.WinForms.Guna2Button();
        pnlError = new Panel();
        guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
        bntOpen = new Guna.UI2.WinForms.Guna2Button();
        lblExc = new Label();
        pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
        lblName = new Label();
        imgImage = new Guna.UI2.WinForms.Guna2Panel();
        ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
        pnlLoading.SuspendLayout();
        pnlError.SuspendLayout();
        guna2Panel1.SuspendLayout();
        pnlPreview.SuspendLayout();
        SuspendLayout();
        // 
        // webView21
        // 
        webView21.AllowExternalDrop = true;
        webView21.CreationProperties = null;
        webView21.DefaultBackgroundColor = Color.White;
        resources.ApplyResources(webView21, "webView21");
        webView21.Name = "webView21";
        webView21.Source = new Uri("D:\\LILO\\source\\repos\\LILO-Packager\\LILO-Packager\\bin\\Debug\\net7.0-windows\\html\\index.html", UriKind.Absolute);
        webView21.ZoomFactor = 1D;
        // 
        // progressSpinner
        // 
        resources.ApplyResources(progressSpinner, "progressSpinner");
        progressSpinner.AutoStart = true;
        progressSpinner.BackColor = Color.White;
        progressSpinner.Name = "progressSpinner";
        // 
        // pnlLoading
        // 
        resources.ApplyResources(pnlLoading, "pnlLoading");
        pnlLoading.BackColor = Color.White;
        pnlLoading.Controls.Add(bntBack);
        pnlLoading.Controls.Add(label1);
        pnlLoading.Controls.Add(bntTrouble);
        pnlLoading.Controls.Add(progressSpinner);
        pnlLoading.Name = "pnlLoading";
        // 
        // bntBack
        // 
        bntBack.Animated = true;
        bntBack.BackColor = Color.Transparent;
        bntBack.BorderColor = Color.Gainsboro;
        bntBack.BorderRadius = 12;
        bntBack.BorderThickness = 2;
        bntBack.DisabledState.BorderColor = Color.DarkGray;
        bntBack.DisabledState.CustomBorderColor = Color.DarkGray;
        bntBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntBack.FillColor = Color.White;
        bntBack.FocusedColor = Color.FromArgb(100, 170, 209);
        resources.ApplyResources(bntBack, "bntBack");
        bntBack.ForeColor = Color.Black;
        bntBack.Image = Properties.Resources.icons8_back_96;
        bntBack.ImageAlign = HorizontalAlignment.Left;
        bntBack.Name = "bntBack";
        bntBack.ShadowDecoration.BorderRadius = 20;
        bntBack.ShadowDecoration.Color = Color.DarkGray;
        bntBack.ShadowDecoration.Depth = 10;
        bntBack.ShadowDecoration.Enabled = true;
        bntBack.ShadowDecoration.Shadow = new Padding(7);
        bntBack.Click += bntBack_Click;
        // 
        // label1
        // 
        resources.ApplyResources(label1, "label1");
        label1.BackColor = Color.Transparent;
        label1.ForeColor = SystemColors.WindowFrame;
        label1.Name = "label1";
        label1.Click += label1_Click;
        // 
        // bntTrouble
        // 
        resources.ApplyResources(bntTrouble, "bntTrouble");
        bntTrouble.Animated = true;
        bntTrouble.BackColor = Color.Transparent;
        bntTrouble.BorderColor = Color.Gainsboro;
        bntTrouble.BorderRadius = 12;
        bntTrouble.BorderThickness = 2;
        bntTrouble.DisabledState.BorderColor = Color.DarkGray;
        bntTrouble.DisabledState.CustomBorderColor = Color.DarkGray;
        bntTrouble.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntTrouble.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntTrouble.FillColor = Color.White;
        bntTrouble.FocusedColor = Color.FromArgb(100, 170, 209);
        bntTrouble.ForeColor = Color.DimGray;
        bntTrouble.Name = "bntTrouble";
        bntTrouble.ShadowDecoration.BorderRadius = 20;
        bntTrouble.ShadowDecoration.Color = Color.DarkGray;
        bntTrouble.ShadowDecoration.Depth = 10;
        bntTrouble.ShadowDecoration.Enabled = true;
        bntTrouble.Click += guna2Button1_Click;
        // 
        // pnlError
        // 
        resources.ApplyResources(pnlError, "pnlError");
        pnlError.BackColor = Color.White;
        pnlError.Controls.Add(guna2Panel1);
        pnlError.Controls.Add(pnlPreview);
        pnlError.Name = "pnlError";
        // 
        // guna2Panel1
        // 
        resources.ApplyResources(guna2Panel1, "guna2Panel1");
        guna2Panel1.BorderColor = SystemColors.ActiveBorder;
        guna2Panel1.BorderRadius = 15;
        guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        guna2Panel1.Controls.Add(bntOpen);
        guna2Panel1.Controls.Add(lblExc);
        guna2Panel1.FillColor = Color.Transparent;
        guna2Panel1.Name = "guna2Panel1";
        // 
        // bntOpen
        // 
        resources.ApplyResources(bntOpen, "bntOpen");
        bntOpen.Animated = true;
        bntOpen.BackColor = Color.Transparent;
        bntOpen.BorderColor = Color.Gainsboro;
        bntOpen.BorderRadius = 20;
        bntOpen.BorderThickness = 2;
        bntOpen.DisabledState.BorderColor = Color.DarkGray;
        bntOpen.DisabledState.CustomBorderColor = Color.DarkGray;
        bntOpen.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntOpen.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntOpen.FillColor = Color.White;
        bntOpen.FocusedColor = Color.FromArgb(100, 170, 209);
        bntOpen.ForeColor = Color.Black;
        bntOpen.Name = "bntOpen";
        bntOpen.Click += bntOpen_Click;
        // 
        // lblExc
        // 
        lblExc.BackColor = Color.Transparent;
        resources.ApplyResources(lblExc, "lblExc");
        lblExc.ForeColor = Color.Black;
        lblExc.Name = "lblExc";
        // 
        // pnlPreview
        // 
        resources.ApplyResources(pnlPreview, "pnlPreview");
        pnlPreview.BackColor = Color.White;
        pnlPreview.BorderColor = SystemColors.ActiveBorder;
        pnlPreview.BorderRadius = 15;
        pnlPreview.Controls.Add(lblName);
        pnlPreview.Controls.Add(imgImage);
        pnlPreview.FillColor = Color.White;
        pnlPreview.Name = "pnlPreview";
        // 
        // lblName
        // 
        resources.ApplyResources(lblName, "lblName");
        lblName.AutoEllipsis = true;
        lblName.BackColor = Color.Transparent;
        lblName.ForeColor = Color.Black;
        lblName.Name = "lblName";
        // 
        // imgImage
        // 
        resources.ApplyResources(imgImage, "imgImage");
        imgImage.BackColor = Color.Transparent;
        imgImage.BackgroundImage = Properties.Resources.pngwing_com__19_;
        imgImage.BorderColor = SystemColors.ActiveBorder;
        imgImage.BorderRadius = 20;
        imgImage.FillColor = Color.Transparent;
        imgImage.Name = "imgImage";
        // 
        // uiWebView
        // 
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Font;
        ControlBox = false;
        Controls.Add(pnlError);
        Controls.Add(pnlLoading);
        Controls.Add(webView21);
        Name = "uiWebView";
        Load += uiWebView_Load;
        ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
        pnlLoading.ResumeLayout(false);
        pnlError.ResumeLayout(false);
        guna2Panel1.ResumeLayout(false);
        pnlPreview.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Guna.UI2.WinForms.Guna2WinProgressIndicator progressSpinner;
    private Panel pnlLoading;
    private Panel pnlError;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    private Label lblExc;
    private Guna.UI2.WinForms.Guna2Panel pnlPreview;
    private Label lblName;
    private Guna.UI2.WinForms.Guna2Panel imgImage;
    private Guna.UI2.WinForms.Guna2Button bntOpen;
    private Guna.UI2.WinForms.Guna2Button bntTrouble;
    public Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    private Label label1;
    private Guna.UI2.WinForms.Guna2Button bntBack;
}