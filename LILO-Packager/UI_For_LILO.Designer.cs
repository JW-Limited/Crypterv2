namespace LILO_Packager;

partial class InstallPackage
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
        components = new System.ComponentModel.Container();
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallPackage));
        tgl_delPkg = new Sipaa.Framework.SToggleButton();
        tgl_Connect = new Sipaa.Framework.SToggleButton();
        tgl_diagnostics = new Sipaa.Framework.SToggleButton();
        bnt_Install = new Sipaa.Framework.SButton();
        lblLicenseKey = new Label();
        txtKey = new Sipaa.Framework.STextBox();
        metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(components);
        sPanel1 = new Sipaa.Framework.SPanel();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        lblProductName = new Label();
        lblProductInfo = new Label();
        bntCancel = new Sipaa.Framework.SButton();
        sPanel2 = new Sipaa.Framework.SPanel();
        progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
        sPanel2.SuspendLayout();
        SuspendLayout();
        // 
        // tgl_delPkg
        // 
        tgl_delPkg.AutoSize = true;
        tgl_delPkg.Location = new Point(402, 395);
        tgl_delPkg.Margin = new Padding(4);
        tgl_delPkg.MinimumSize = new Size(56, 28);
        tgl_delPkg.Name = "tgl_delPkg";
        tgl_delPkg.OffBackColor = Color.Gray;
        tgl_delPkg.OffToggleColor = Color.Gainsboro;
        tgl_delPkg.OnBackColor = Color.MediumSlateBlue;
        tgl_delPkg.OnToggleColor = Color.WhiteSmoke;
        tgl_delPkg.Size = new Size(56, 28);
        tgl_delPkg.TabIndex = 0;
        tgl_delPkg.UseVisualStyleBackColor = true;
        // 
        // tgl_Connect
        // 
        tgl_Connect.AutoSize = true;
        tgl_Connect.Location = new Point(402, 448);
        tgl_Connect.Margin = new Padding(4);
        tgl_Connect.MinimumSize = new Size(56, 28);
        tgl_Connect.Name = "tgl_Connect";
        tgl_Connect.OffBackColor = Color.Gray;
        tgl_Connect.OffToggleColor = Color.Gainsboro;
        tgl_Connect.OnBackColor = Color.MediumSlateBlue;
        tgl_Connect.OnToggleColor = Color.WhiteSmoke;
        tgl_Connect.Size = new Size(56, 28);
        tgl_Connect.TabIndex = 0;
        tgl_Connect.UseVisualStyleBackColor = true;
        // 
        // tgl_diagnostics
        // 
        tgl_diagnostics.AutoSize = true;
        tgl_diagnostics.Location = new Point(402, 498);
        tgl_diagnostics.Margin = new Padding(4);
        tgl_diagnostics.MinimumSize = new Size(56, 28);
        tgl_diagnostics.Name = "tgl_diagnostics";
        tgl_diagnostics.OffBackColor = Color.Gray;
        tgl_diagnostics.OffToggleColor = Color.Gainsboro;
        tgl_diagnostics.OnBackColor = Color.MediumSlateBlue;
        tgl_diagnostics.OnToggleColor = Color.WhiteSmoke;
        tgl_diagnostics.Size = new Size(56, 28);
        tgl_diagnostics.TabIndex = 0;
        tgl_diagnostics.UseVisualStyleBackColor = true;
        // 
        // bnt_Install
        // 
        bnt_Install.BackColor = Color.MediumSlateBlue;
        bnt_Install.BorderColor = Color.PaleVioletRed;
        bnt_Install.BorderRadius = 10;
        bnt_Install.BorderSize = 0;
        bnt_Install.DialogResult = DialogResult.OK;
        bnt_Install.FlatAppearance.BorderSize = 0;
        bnt_Install.FlatStyle = FlatStyle.Flat;
        bnt_Install.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        bnt_Install.ForeColor = Color.White;
        bnt_Install.Location = new Point(544, 479);
        bnt_Install.Margin = new Padding(4);
        bnt_Install.Name = "bnt_Install";
        bnt_Install.Size = new Size(201, 55);
        bnt_Install.TabIndex = 2;
        bnt_Install.Text = "Install";
        bnt_Install.UseVisualStyleBackColor = false;
        bnt_Install.Click += Install;
        // 
        // lblLicenseKey
        // 
        lblLicenseKey.BackColor = Color.Transparent;
        lblLicenseKey.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        lblLicenseKey.Location = new Point(64, 40);
        lblLicenseKey.Margin = new Padding(4, 0, 4, 0);
        lblLicenseKey.Name = "lblLicenseKey";
        lblLicenseKey.Size = new Size(168, 42);
        lblLicenseKey.TabIndex = 5;
        lblLicenseKey.Text = "Lizens - Key";
        lblLicenseKey.TextAlign = ContentAlignment.MiddleLeft;
        lblLicenseKey.Click += label1_Click;
        // 
        // txtKey
        // 
        metroStyleExtender1.SetApplyMetroTheme(txtKey, true);
        txtKey.BackColor = Color.FromArgb(17, 17, 17);
        txtKey.BorderColor = Color.DarkBlue;
        txtKey.BorderFocusColor = Color.FromArgb(0, 0, 64);
        txtKey.BorderRadius = 15;
        txtKey.BorderSize = 2;
        txtKey.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        txtKey.ForeColor = Color.FromArgb(170, 170, 170);
        txtKey.Location = new Point(289, 40);
        txtKey.Margin = new Padding(5);
        txtKey.Multiline = false;
        txtKey.Name = "txtKey";
        txtKey.Padding = new Padding(12, 9, 12, 9);
        txtKey.PasswordChar = false;
        txtKey.PlaceholderColor = Color.DarkGray;
        txtKey.PlaceholderText = "Input Key here...";
        txtKey.Size = new Size(529, 43);
        txtKey.TabIndex = 9;
        txtKey.Texts = "";
        txtKey.UnderlinedStyle = false;
        // 
        // metroStyleExtender1
        // 
        metroStyleExtender1.Theme = MetroFramework.MetroThemeStyle.Dark;
        // 
        // sPanel1
        // 
        sPanel1.AllowDrop = true;
        sPanel1.BackColor = Color.FromArgb(20, 30, 30);
        sPanel1.BackgroundImage = Properties.Resources.Close;
        sPanel1.BackgroundImageLayout = ImageLayout.Zoom;
        sPanel1.BorderColor = Color.Black;
        sPanel1.BorderRadius = 15;
        sPanel1.BorderSize = 0;
        sPanel1.ForeColor = Color.White;
        sPanel1.Location = new Point(35, 40);
        sPanel1.Margin = new Padding(4);
        sPanel1.Name = "sPanel1";
        sPanel1.Size = new Size(168, 151);
        sPanel1.TabIndex = 10;
        // 
        // label2
        // 
        label2.BackColor = Color.Transparent;
        label2.Location = new Point(38, 439);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(338, 39);
        label2.TabIndex = 11;
        label2.Text = "Connect License to your Account";
        label2.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.BackColor = Color.Transparent;
        label3.Location = new Point(38, 392);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(338, 39);
        label3.TabIndex = 11;
        label3.Text = "Delete .lilo Package after Installation";
        label3.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label4
        // 
        label4.BackColor = Color.Transparent;
        label4.Location = new Point(35, 488);
        label4.Margin = new Padding(2, 0, 2, 0);
        label4.Name = "label4";
        label4.Size = new Size(338, 39);
        label4.TabIndex = 11;
        label4.Text = "Send Diagnosticdata";
        label4.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblProductName
        // 
        lblProductName.BackColor = Color.Transparent;
        lblProductName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblProductName.Location = new Point(228, 40);
        lblProductName.Margin = new Padding(2, 0, 2, 0);
        lblProductName.Name = "lblProductName";
        lblProductName.Size = new Size(338, 39);
        lblProductName.TabIndex = 11;
        lblProductName.Text = "PackageName";
        lblProductName.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblProductInfo
        // 
        lblProductInfo.BackColor = Color.Transparent;
        lblProductInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
        lblProductInfo.Location = new Point(276, 79);
        lblProductInfo.Margin = new Padding(2, 0, 2, 0);
        lblProductInfo.Name = "lblProductInfo";
        lblProductInfo.Size = new Size(632, 112);
        lblProductInfo.TabIndex = 11;
        lblProductInfo.Text = "PackageInformations";
        lblProductInfo.TextAlign = ContentAlignment.MiddleLeft;
        lblProductInfo.Click += lblProductInfo_Click;
        // 
        // bntCancel
        // 
        bntCancel.BackColor = Color.LightSlateGray;
        bntCancel.BorderColor = Color.PaleVioletRed;
        bntCancel.BorderRadius = 10;
        bntCancel.BorderSize = 0;
        bntCancel.DialogResult = DialogResult.Cancel;
        bntCancel.FlatAppearance.BorderSize = 0;
        bntCancel.FlatStyle = FlatStyle.Flat;
        bntCancel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        bntCancel.ForeColor = Color.White;
        bntCancel.Location = new Point(752, 479);
        bntCancel.Margin = new Padding(4);
        bntCancel.Name = "bntCancel";
        bntCancel.Size = new Size(146, 55);
        bntCancel.TabIndex = 2;
        bntCancel.Text = "Cancel";
        bntCancel.UseVisualStyleBackColor = false;
        bntCancel.Click += sButton1_Click;
        // 
        // sPanel2
        // 
        sPanel2.AllowDrop = true;
        sPanel2.BackColor = Color.FromArgb(20, 30, 30);
        sPanel2.BorderColor = Color.Black;
        sPanel2.BorderRadius = 20;
        sPanel2.BorderSize = 0;
        sPanel2.Controls.Add(progressBar);
        sPanel2.Controls.Add(txtKey);
        sPanel2.Controls.Add(lblLicenseKey);
        sPanel2.ForeColor = Color.White;
        sPanel2.Location = new Point(35, 229);
        sPanel2.Margin = new Padding(4);
        sPanel2.Name = "sPanel2";
        sPanel2.Size = new Size(864, 122);
        sPanel2.TabIndex = 10;
        // 
        // progressBar
        // 
        progressBar.BorderRadius = 20;
        progressBar.Location = new Point(44, 38);
        progressBar.Margin = new Padding(2);
        progressBar.Name = "progressBar";
        progressBar.ProgressColor = Color.White;
        progressBar.ProgressColor2 = Color.MediumSlateBlue;
        progressBar.Size = new Size(774, 45);
        progressBar.TabIndex = 10;
        progressBar.Text = "guna2ProgressBar1";
        progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
        progressBar.Visible = false;
        // 
        // InstallPackage
        // 
        AcceptButton = bnt_Install;
        AllowDrop = true;
        metroStyleExtender1.SetApplyMetroTheme(this, true);
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(17, 17, 17);
        BackgroundImage = Properties.Resources.Screenshot_2022_08_25_001747;
        BackgroundImageLayout = ImageLayout.Stretch;
        CancelButton = bntCancel;
        ClientSize = new Size(927, 562);
        ControlBox = false;
        Controls.Add(sPanel2);
        Controls.Add(lblProductInfo);
        Controls.Add(lblProductName);
        Controls.Add(label3);
        Controls.Add(label4);
        Controls.Add(label2);
        Controls.Add(sPanel1);
        Controls.Add(bnt_Install);
        Controls.Add(bntCancel);
        Controls.Add(tgl_diagnostics);
        Controls.Add(tgl_Connect);
        Controls.Add(tgl_delPkg);
        DoubleBuffered = true;
        ForeColor = Color.FromArgb(170, 170, 170);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        HelpButton = true;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        MaximizeBox = false;
        Name = "InstallPackage";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Install";
        Load += UI_For_LILO_Load;
        sPanel2.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Sipaa.Framework.SToggleButton tgl_delPkg;
    private Sipaa.Framework.SToggleButton tgl_Connect;
    private Sipaa.Framework.SToggleButton tgl_diagnostics;
    private Sipaa.Framework.SButton bnt_Install;
    private Bunifu.UI.WinForms.BunifuLoader bunifuLoader1;
    private Label lblLicenseKey;
    private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
    private Sipaa.Framework.STextBox txtKey;
    private Sipaa.Framework.SPanel sPanel1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label lblProductName;
    private Label lblProductInfo;
    private Sipaa.Framework.SButton bntCancel;
    private Sipaa.Framework.SPanel sPanel2;
    private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
}