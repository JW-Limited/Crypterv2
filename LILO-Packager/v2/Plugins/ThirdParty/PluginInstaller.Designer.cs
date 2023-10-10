namespace LILO_Packager.v2.Plugins.ThirdParty;

partial class PluginInstaller
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginInstaller));
        metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(components);
        pnlPluginIcon = new Sipaa.Framework.SPanel();
        lblProductName = new Label();
        lblProductInfo = new Label();
        bntInstall = new Guna.UI2.WinForms.Guna2Button();
        guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
        guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
        lblVersion = new Label();
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        panel1 = new Panel();
        panel2 = new Panel();
        lblError = new Label();
        lblFunctions = new Label();
        lblFunctionList = new Label();
        pnlProgess = new Guna.UI2.WinForms.Guna2Panel();
        lblProgressDescription = new Label();
        progress = new Guna.UI2.WinForms.Guna2ProgressBar();
        guna2Panel3.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        panel1.SuspendLayout();
        pnlProgess.SuspendLayout();
        SuspendLayout();
        // 
        // metroStyleExtender1
        // 
        metroStyleExtender1.Theme = MetroFramework.MetroThemeStyle.Dark;
        // 
        // pnlPluginIcon
        // 
        pnlPluginIcon.AllowDrop = true;
        pnlPluginIcon.BackColor = Color.White;
        pnlPluginIcon.BackgroundImage = Properties.Resources.icons8_bursts_96;
        pnlPluginIcon.BackgroundImageLayout = ImageLayout.Zoom;
        pnlPluginIcon.BorderColor = Color.Transparent;
        pnlPluginIcon.BorderRadius = 15;
        pnlPluginIcon.BorderSize = 0;
        pnlPluginIcon.Cursor = Cursors.Hand;
        pnlPluginIcon.ForeColor = Color.White;
        pnlPluginIcon.Location = new Point(24, 24);
        pnlPluginIcon.Margin = new Padding(4);
        pnlPluginIcon.Name = "pnlPluginIcon";
        pnlPluginIcon.Size = new Size(149, 144);
        pnlPluginIcon.TabIndex = 10;
        pnlPluginIcon.Click += pnlPluginIcon_Click;
        // 
        // lblProductName
        // 
        lblProductName.AutoSize = true;
        lblProductName.BackColor = Color.Transparent;
        lblProductName.Dock = DockStyle.Fill;
        lblProductName.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
        lblProductName.ForeColor = Color.Black;
        lblProductName.Location = new Point(2, 0);
        lblProductName.Margin = new Padding(2, 0, 2, 0);
        lblProductName.Name = "lblProductName";
        lblProductName.Size = new Size(188, 38);
        lblProductName.TabIndex = 11;
        lblProductName.Text = "PackageName";
        lblProductName.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblProductInfo
        // 
        lblProductInfo.BackColor = Color.White;
        lblProductInfo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblProductInfo.ForeColor = Color.Gray;
        lblProductInfo.Location = new Point(16, 0);
        lblProductInfo.Margin = new Padding(2, 0, 2, 0);
        lblProductInfo.Name = "lblProductInfo";
        lblProductInfo.Size = new Size(560, 64);
        lblProductInfo.TabIndex = 11;
        lblProductInfo.Text = "PackageInformations";
        // 
        // bntInstall
        // 
        bntInstall.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        bntInstall.Animated = true;
        bntInstall.BackColor = Color.Transparent;
        bntInstall.BorderColor = Color.Gainsboro;
        bntInstall.BorderRadius = 12;
        bntInstall.BorderThickness = 2;
        bntInstall.DisabledState.BorderColor = Color.Transparent;
        bntInstall.DisabledState.CustomBorderColor = Color.Transparent;
        bntInstall.DisabledState.FillColor = Color.White;
        bntInstall.DisabledState.ForeColor = Color.Silver;
        bntInstall.FillColor = Color.White;
        bntInstall.FocusedColor = Color.FromArgb(100, 170, 209);
        bntInstall.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        bntInstall.ForeColor = Color.Black;
        bntInstall.ImageAlign = HorizontalAlignment.Left;
        bntInstall.Location = new Point(624, 448);
        bntInstall.Margin = new Padding(2);
        bntInstall.Name = "bntInstall";
        bntInstall.ShadowDecoration.BorderRadius = 20;
        bntInstall.ShadowDecoration.Color = Color.DarkGray;
        bntInstall.ShadowDecoration.Depth = 10;
        bntInstall.ShadowDecoration.Enabled = true;
        bntInstall.ShadowDecoration.Shadow = new Padding(7);
        bntInstall.Size = new Size(208, 49);
        bntInstall.TabIndex = 31;
        bntInstall.Text = "Install";
        bntInstall.Click += bntInstall_Click;
        // 
        // guna2Panel3
        // 
        guna2Panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2Panel3.BackColor = Color.Transparent;
        guna2Panel3.BorderColor = Color.Gainsboro;
        guna2Panel3.BorderRadius = 15;
        guna2Panel3.BorderThickness = 2;
        guna2Panel3.Controls.Add(pnlPluginIcon);
        guna2Panel3.FillColor = Color.White;
        guna2Panel3.Location = new Point(640, 32);
        guna2Panel3.Margin = new Padding(2);
        guna2Panel3.Name = "guna2Panel3";
        guna2Panel3.Size = new Size(192, 192);
        guna2Panel3.TabIndex = 32;
        // 
        // guna2Button3
        // 
        guna2Button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        guna2Button3.Animated = true;
        guna2Button3.BackColor = Color.Transparent;
        guna2Button3.BorderColor = Color.Gainsboro;
        guna2Button3.BorderRadius = 12;
        guna2Button3.BorderThickness = 2;
        guna2Button3.DisabledState.BorderColor = Color.DarkGray;
        guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button3.FillColor = Color.White;
        guna2Button3.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button3.ForeColor = Color.DimGray;
        guna2Button3.Image = Properties.Resources.Info;
        guna2Button3.ImageSize = new Size(25, 25);
        guna2Button3.Location = new Point(32, 448);
        guna2Button3.Margin = new Padding(2);
        guna2Button3.Name = "guna2Button3";
        guna2Button3.Size = new Size(48, 48);
        guna2Button3.TabIndex = 25;
        guna2Button3.Click += guna2Button3_Click;
        // 
        // lblVersion
        // 
        lblVersion.BackColor = Color.Transparent;
        lblVersion.Dock = DockStyle.Fill;
        lblVersion.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
        lblVersion.Location = new Point(194, 0);
        lblVersion.Margin = new Padding(2, 0, 2, 0);
        lblVersion.Name = "lblVersion";
        lblVersion.Size = new Size(366, 38);
        lblVersion.TabIndex = 11;
        lblVersion.Text = "Version";
        lblVersion.TextAlign = ContentAlignment.BottomLeft;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel1.Controls.Add(lblVersion, 1, 0);
        tableLayoutPanel1.Controls.Add(lblProductName, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(3, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(562, 38);
        tableLayoutPanel1.TabIndex = 33;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
        tableLayoutPanel2.Location = new Point(32, 32);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 79.48718F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5128212F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel2.Size = new Size(568, 56);
        tableLayoutPanel2.TabIndex = 34;
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.ScrollBar;
        panel1.Controls.Add(lblProductInfo);
        panel1.Controls.Add(panel2);
        panel1.Location = new Point(40, 88);
        panel1.Name = "panel1";
        panel1.Size = new Size(560, 64);
        panel1.TabIndex = 35;
        // 
        // panel2
        // 
        panel2.BackColor = Color.White;
        panel2.Location = new Point(8, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(16, 64);
        panel2.TabIndex = 35;
        // 
        // lblError
        // 
        lblError.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblError.AutoEllipsis = true;
        lblError.BackColor = Color.White;
        lblError.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        lblError.ForeColor = Color.Black;
        lblError.Location = new Point(32, 344);
        lblError.Margin = new Padding(2, 0, 2, 0);
        lblError.Name = "lblError";
        lblError.Size = new Size(800, 80);
        lblError.TabIndex = 11;
        lblError.Text = "Error";
        lblError.Visible = false;
        // 
        // lblFunctions
        // 
        lblFunctions.BackColor = Color.White;
        lblFunctions.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        lblFunctions.ForeColor = Color.Black;
        lblFunctions.Location = new Point(32, 200);
        lblFunctions.Margin = new Padding(2, 0, 2, 0);
        lblFunctions.Name = "lblFunctions";
        lblFunctions.Size = new Size(112, 32);
        lblFunctions.TabIndex = 11;
        lblFunctions.Text = "Functions:";
        // 
        // lblFunctionList
        // 
        lblFunctionList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblFunctionList.AutoEllipsis = true;
        lblFunctionList.BackColor = Color.White;
        lblFunctionList.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblFunctionList.ForeColor = Color.Gray;
        lblFunctionList.Location = new Point(32, 240);
        lblFunctionList.Margin = new Padding(2, 0, 2, 0);
        lblFunctionList.Name = "lblFunctionList";
        lblFunctionList.Size = new Size(800, 88);
        lblFunctionList.TabIndex = 11;
        lblFunctionList.Text = "- func";
        lblFunctionList.Click += lblFunctionList_Click;
        // 
        // pnlProgess
        // 
        pnlProgess.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        pnlProgess.BackColor = Color.Transparent;
        pnlProgess.BorderColor = Color.Gainsboro;
        pnlProgess.BorderRadius = 15;
        pnlProgess.Controls.Add(lblProgressDescription);
        pnlProgess.Controls.Add(progress);
        pnlProgess.FillColor = Color.White;
        pnlProgess.Location = new Point(24, 288);
        pnlProgess.Margin = new Padding(2);
        pnlProgess.Name = "pnlProgess";
        pnlProgess.Size = new Size(808, 152);
        pnlProgess.TabIndex = 32;
        pnlProgess.Visible = false;
        // 
        // lblProgressDescription
        // 
        lblProgressDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblProgressDescription.BackColor = Color.Transparent;
        lblProgressDescription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblProgressDescription.ForeColor = Color.Black;
        lblProgressDescription.Location = new Point(8, 48);
        lblProgressDescription.Margin = new Padding(4, 0, 4, 0);
        lblProgressDescription.Name = "lblProgressDescription";
        lblProgressDescription.Size = new Size(752, 32);
        lblProgressDescription.TabIndex = 31;
        lblProgressDescription.Text = "Description";
        lblProgressDescription.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // progress
        // 
        progress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        progress.BackColor = Color.Transparent;
        progress.BorderColor = Color.Gainsboro;
        progress.BorderRadius = 10;
        progress.BorderThickness = 2;
        progress.FillColor = Color.White;
        progress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
        progress.Location = new Point(8, 88);
        progress.Margin = new Padding(2);
        progress.Name = "progress";
        progress.ProgressColor = Color.DeepSkyBlue;
        progress.ProgressColor2 = Color.RoyalBlue;
        progress.Size = new Size(800, 37);
        progress.TabIndex = 30;
        progress.Text = "guna2ProgressBar1";
        progress.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
        progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
        // 
        // PluginInstaller
        // 
        AllowDrop = true;
        metroStyleExtender1.SetApplyMetroTheme(this, true);
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(864, 528);
        Controls.Add(pnlProgess);
        Controls.Add(lblError);
        Controls.Add(lblFunctions);
        Controls.Add(lblFunctionList);
        Controls.Add(panel1);
        Controls.Add(tableLayoutPanel2);
        Controls.Add(guna2Button3);
        Controls.Add(bntInstall);
        Controls.Add(guna2Panel3);
        DoubleBuffered = true;
        ForeColor = Color.FromArgb(170, 170, 170);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        MaximizeBox = false;
        MinimizeBox = false;
        MinimumSize = new Size(886, 584);
        Name = "PluginInstaller";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "PluginInstaller";
        Load += UI_For_LILO_Load;
        guna2Panel3.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        tableLayoutPanel2.ResumeLayout(false);
        panel1.ResumeLayout(false);
        pnlProgess.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Bunifu.UI.WinForms.BunifuLoader bunifuLoader1;
    private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
    private Sipaa.Framework.SPanel pnlPluginIcon;
    private Label lblProductName;
    private Label lblProductInfo;
    private Guna.UI2.WinForms.Guna2Button bntInstall;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
    private Guna.UI2.WinForms.Guna2Button guna2Button3;
    private Label lblVersion;
    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private Panel panel1;
    private Label lblError;
    private Label lblFunctions;
    private Label lblFunctionList;
    private Guna.UI2.WinForms.Guna2Panel pnlProgess;
    private Label lblProgressDescription;
    private Guna.UI2.WinForms.Guna2ProgressBar progress;
    private Panel panel2;
}