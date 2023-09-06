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
        pnlLoading = new Panel();
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
        progressSpinner.Location = new Point(440, 408);
        progressSpinner.Name = "progressSpinner";
        progressSpinner.Size = new Size(135, 135);
        progressSpinner.TabIndex = 7;
        // 
        // pnlLoading
        // 
        pnlLoading.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlLoading.BackColor = Color.White;
        pnlLoading.Controls.Add(label1);
        pnlLoading.Controls.Add(bntTrouble);
        pnlLoading.Controls.Add(progressSpinner);
        pnlLoading.Location = new Point(0, 0);
        pnlLoading.Name = "pnlLoading";
        pnlLoading.Size = new Size(1024, 952);
        pnlLoading.TabIndex = 8;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Bottom;
        label1.BackColor = Color.Transparent;
        label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        label1.ForeColor = SystemColors.WindowFrame;
        label1.Location = new Point(408, 864);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(200, 40);
        label1.TabIndex = 1;
        label1.Text = "JW Limited ©️ 2023";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // bntTrouble
        // 
        bntTrouble.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
        bntTrouble.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        bntTrouble.ForeColor = Color.DimGray;
        bntTrouble.Location = new Point(808, 24);
        bntTrouble.Margin = new Padding(2);
        bntTrouble.Name = "bntTrouble";
        bntTrouble.Size = new Size(192, 40);
        bntTrouble.TabIndex = 26;
        bntTrouble.Text = "Troubleshooting";
        bntTrouble.Visible = false;
        bntTrouble.Click += guna2Button1_Click;
        // 
        // pnlError
        // 
        pnlError.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlError.BackColor = Color.White;
        pnlError.Controls.Add(guna2Panel1);
        pnlError.Controls.Add(pnlPreview);
        pnlError.Location = new Point(192, 168);
        pnlError.Name = "pnlError";
        pnlError.Size = new Size(624, 608);
        pnlError.TabIndex = 8;
        pnlError.Visible = false;
        // 
        // guna2Panel1
        // 
        guna2Panel1.Anchor = AnchorStyles.None;
        guna2Panel1.BorderColor = SystemColors.ActiveBorder;
        guna2Panel1.BorderRadius = 15;
        guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        guna2Panel1.Controls.Add(bntOpen);
        guna2Panel1.Controls.Add(lblExc);
        guna2Panel1.FillColor = Color.Transparent;
        guna2Panel1.Location = new Point(80, 464);
        guna2Panel1.Margin = new Padding(2);
        guna2Panel1.Name = "guna2Panel1";
        guna2Panel1.Size = new Size(496, 141);
        guna2Panel1.TabIndex = 16;
        // 
        // bntOpen
        // 
        bntOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
        bntOpen.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        bntOpen.ForeColor = Color.Black;
        bntOpen.Location = new Point(16, 72);
        bntOpen.Margin = new Padding(2);
        bntOpen.Name = "bntOpen";
        bntOpen.Size = new Size(464, 48);
        bntOpen.TabIndex = 16;
        bntOpen.Text = "Retry";
        bntOpen.Click += bntOpen_Click;
        // 
        // lblExc
        // 
        lblExc.BackColor = Color.Transparent;
        lblExc.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        lblExc.ForeColor = Color.Black;
        lblExc.Location = new Point(16, 16);
        lblExc.Margin = new Padding(4, 0, 4, 0);
        lblExc.Name = "lblExc";
        lblExc.Size = new Size(464, 40);
        lblExc.TabIndex = 1;
        lblExc.Text = "(FeatureNullException)";
        lblExc.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnlPreview
        // 
        pnlPreview.Anchor = AnchorStyles.None;
        pnlPreview.BackColor = Color.White;
        pnlPreview.BorderColor = SystemColors.ActiveBorder;
        pnlPreview.BorderRadius = 15;
        pnlPreview.Controls.Add(lblName);
        pnlPreview.Controls.Add(imgImage);
        pnlPreview.FillColor = Color.White;
        pnlPreview.Location = new Point(88, 16);
        pnlPreview.Margin = new Padding(2);
        pnlPreview.Name = "pnlPreview";
        pnlPreview.Size = new Size(488, 416);
        pnlPreview.TabIndex = 15;
        // 
        // lblName
        // 
        lblName.Anchor = AnchorStyles.None;
        lblName.AutoEllipsis = true;
        lblName.BackColor = Color.Transparent;
        lblName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        lblName.ForeColor = Color.Black;
        lblName.Location = new Point(0, 357);
        lblName.Margin = new Padding(4, 0, 4, 0);
        lblName.Name = "lblName";
        lblName.Size = new Size(488, 56);
        lblName.TabIndex = 13;
        lblName.Text = "Ohh, Ohh";
        lblName.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // imgImage
        // 
        imgImage.Anchor = AnchorStyles.None;
        imgImage.BackColor = Color.Transparent;
        imgImage.BackgroundImage = Properties.Resources.pngwing_com__19_;
        imgImage.BackgroundImageLayout = ImageLayout.Zoom;
        imgImage.BorderColor = SystemColors.ActiveBorder;
        imgImage.BorderRadius = 20;
        imgImage.FillColor = Color.Transparent;
        imgImage.Location = new Point(80, 40);
        imgImage.Margin = new Padding(2);
        imgImage.Name = "imgImage";
        imgImage.Size = new Size(320, 312);
        imgImage.TabIndex = 11;
        // 
        // uiWebView
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1020, 948);
        ControlBox = false;
        Controls.Add(pnlError);
        Controls.Add(pnlLoading);
        Controls.Add(webView21);
        Name = "uiWebView";
        Text = "uiWebView";
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
}