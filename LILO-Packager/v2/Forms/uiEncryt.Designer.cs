namespace LILO_Packager.v2.Forms;

partial class uiEncryt
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
        Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiEncryt));
        sPanel1 = new Sipaa.Framework.SPanel();
        bntPlugin = new Guna.UI2.WinForms.Guna2Button();
        bntCancel = new Guna.UI2.WinForms.Guna2Button();
        lblText = new Label();
        bntOpen = new Guna.UI2.WinForms.Guna2Button();
        pnlFile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
        guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
        lblReady = new Label();
        lblEnrcypt = new Label();
        lblComb = new Label();
        lblFile = new Label();
        linkAccountOnline = new LinkLabel();
        pnlReady = new Guna.UI2.WinForms.Guna2CirclePictureBox();
        pnlEncrypt = new Guna.UI2.WinForms.Guna2CirclePictureBox();
        pnlComb = new Guna.UI2.WinForms.Guna2CirclePictureBox();
        guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
        progress = new Guna.UI2.WinForms.Guna2ProgressBar();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        pnlFiles = new Guna.UI2.WinForms.Guna2Panel();
        chbFolders = new CheckedListBox();
        bntChangeToFolders = new Guna.UI2.WinForms.Guna2Button();
        bntChangeToFiles = new Guna.UI2.WinForms.Guna2Button();
        chblistFiles = new CheckedListBox();
        pnlChild = new Guna.UI2.WinForms.Guna2Panel();
        label1 = new Label();
        guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
        pswDialog = new Ookii.Dialogs.WinForms.InputDialog(components);
        taskBarProgress = new Guna.UI2.WinForms.Guna2TaskBarProgress(components);
        asyncTask = new Ookii.Dialogs.WinForms.ProgressDialog(components);
        Transition = new Guna.UI2.WinForms.Guna2Transition();
        sPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pnlFile).BeginInit();
        guna2Panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pnlReady).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pnlEncrypt).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pnlComb).BeginInit();
        guna2Panel3.SuspendLayout();
        pnlFiles.SuspendLayout();
        pnlChild.SuspendLayout();
        guna2Panel2.SuspendLayout();
        SuspendLayout();
        // 
        // sPanel1
        // 
        sPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        sPanel1.BackColor = Color.WhiteSmoke;
        sPanel1.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel1.BorderColor = Color.Gainsboro;
        sPanel1.BorderRadius = 20;
        sPanel1.BorderSize = 2;
        sPanel1.Controls.Add(bntPlugin);
        sPanel1.Controls.Add(bntCancel);
        sPanel1.Controls.Add(lblText);
        Transition.SetDecoration(sPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
        sPanel1.ForeColor = Color.White;
        sPanel1.Location = new Point(24, 32);
        sPanel1.Margin = new Padding(4);
        sPanel1.Name = "sPanel1";
        sPanel1.Size = new Size(976, 88);
        sPanel1.TabIndex = 10;
        // 
        // bntPlugin
        // 
        bntPlugin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        bntPlugin.Animated = true;
        bntPlugin.BackColor = Color.Transparent;
        bntPlugin.BackgroundImageLayout = ImageLayout.Zoom;
        bntPlugin.BorderColor = Color.Gainsboro;
        bntPlugin.BorderRadius = 20;
        bntPlugin.BorderThickness = 2;
        Transition.SetDecoration(bntPlugin, Guna.UI2.AnimatorNS.DecorationType.None);
        bntPlugin.DisabledState.BorderColor = Color.DarkGray;
        bntPlugin.DisabledState.CustomBorderColor = Color.DarkGray;
        bntPlugin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntPlugin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntPlugin.FillColor = Color.White;
        bntPlugin.FocusedColor = Color.FromArgb(100, 170, 209);
        bntPlugin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        bntPlugin.ForeColor = Color.DimGray;
        bntPlugin.Location = new Point(864, 16);
        bntPlugin.Margin = new Padding(2);
        bntPlugin.Name = "bntPlugin";
        bntPlugin.Size = new Size(96, 58);
        bntPlugin.TabIndex = 13;
        bntPlugin.Text = "More";
        bntPlugin.Click += bntOpenPlugin_Clicj;
        // 
        // bntCancel
        // 
        bntCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        bntCancel.Animated = true;
        bntCancel.BackColor = Color.Transparent;
        bntCancel.BorderColor = Color.Gainsboro;
        bntCancel.BorderRadius = 20;
        bntCancel.BorderThickness = 2;
        Transition.SetDecoration(bntCancel, Guna.UI2.AnimatorNS.DecorationType.None);
        bntCancel.DisabledState.BorderColor = Color.DarkGray;
        bntCancel.DisabledState.CustomBorderColor = Color.DarkGray;
        bntCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntCancel.FillColor = Color.White;
        bntCancel.FocusedColor = Color.FromArgb(100, 170, 209);
        bntCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        bntCancel.ForeColor = Color.DimGray;
        bntCancel.Location = new Point(832, 16);
        bntCancel.Margin = new Padding(2);
        bntCancel.Name = "bntCancel";
        bntCancel.Size = new Size(128, 58);
        bntCancel.TabIndex = 13;
        bntCancel.Text = "Cancel";
        bntCancel.Visible = false;
        bntCancel.Click += bntCancel_Click;
        // 
        // lblText
        // 
        lblText.BackColor = Color.Transparent;
        Transition.SetDecoration(lblText, Guna.UI2.AnimatorNS.DecorationType.None);
        lblText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblText.ForeColor = Color.DimGray;
        lblText.Location = new Point(24, 0);
        lblText.Margin = new Padding(4, 0, 4, 0);
        lblText.Name = "lblText";
        lblText.Size = new Size(144, 88);
        lblText.TabIndex = 1;
        lblText.Text = "Encrypt";
        lblText.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // bntOpen
        // 
        bntOpen.Anchor = AnchorStyles.None;
        bntOpen.Animated = true;
        bntOpen.BorderColor = Color.Gainsboro;
        bntOpen.BorderRadius = 15;
        bntOpen.BorderThickness = 2;
        Transition.SetDecoration(bntOpen, Guna.UI2.AnimatorNS.DecorationType.None);
        bntOpen.DisabledState.BorderColor = Color.DarkGray;
        bntOpen.DisabledState.CustomBorderColor = Color.DarkGray;
        bntOpen.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntOpen.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntOpen.FillColor = Color.WhiteSmoke;
        bntOpen.FocusedColor = Color.FromArgb(100, 170, 209);
        bntOpen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        bntOpen.ForeColor = Color.RoyalBlue;
        bntOpen.Location = new Point(216, 308);
        bntOpen.Margin = new Padding(2);
        bntOpen.Name = "bntOpen";
        bntOpen.Size = new Size(176, 40);
        bntOpen.TabIndex = 0;
        bntOpen.Text = "Select Files";
        bntOpen.Click += bntOpen_Click;
        // 
        // pnlFile
        // 
        pnlFile.Anchor = AnchorStyles.None;
        pnlFile.BackColor = Color.Transparent;
        Transition.SetDecoration(pnlFile, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlFile.ImageRotate = 0F;
        pnlFile.Location = new Point(104, 72);
        pnlFile.Margin = new Padding(2);
        pnlFile.Name = "pnlFile";
        pnlFile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
        pnlFile.Size = new Size(40, 40);
        pnlFile.TabIndex = 11;
        pnlFile.TabStop = false;
        // 
        // guna2Panel1
        // 
        guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        guna2Panel1.AutoScroll = true;
        guna2Panel1.BackColor = Color.Transparent;
        guna2Panel1.BorderColor = Color.Gainsboro;
        guna2Panel1.BorderRadius = 20;
        guna2Panel1.BorderThickness = 2;
        guna2Panel1.Controls.Add(lblReady);
        guna2Panel1.Controls.Add(lblEnrcypt);
        guna2Panel1.Controls.Add(lblComb);
        guna2Panel1.Controls.Add(lblFile);
        guna2Panel1.Controls.Add(linkAccountOnline);
        guna2Panel1.Controls.Add(pnlReady);
        guna2Panel1.Controls.Add(pnlEncrypt);
        guna2Panel1.Controls.Add(pnlComb);
        guna2Panel1.Controls.Add(pnlFile);
        Transition.SetDecoration(guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Panel1.FillColor = Color.WhiteSmoke;
        guna2Panel1.Location = new Point(24, 160);
        guna2Panel1.Margin = new Padding(2);
        guna2Panel1.Name = "guna2Panel1";
        guna2Panel1.Size = new Size(976, 200);
        guna2Panel1.TabIndex = 12;
        // 
        // lblReady
        // 
        lblReady.Anchor = AnchorStyles.None;
        Transition.SetDecoration(lblReady, Guna.UI2.AnimatorNS.DecorationType.None);
        lblReady.Font = new Font("Open Sans", 10F, FontStyle.Bold);
        lblReady.ForeColor = SystemColors.ButtonHighlight;
        lblReady.Location = new Point(792, 128);
        lblReady.Margin = new Padding(2, 0, 2, 0);
        lblReady.Name = "lblReady";
        lblReady.Size = new Size(138, 32);
        lblReady.TabIndex = 13;
        lblReady.Text = "Encrypted";
        lblReady.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblEnrcypt
        // 
        lblEnrcypt.Anchor = AnchorStyles.None;
        Transition.SetDecoration(lblEnrcypt, Guna.UI2.AnimatorNS.DecorationType.None);
        lblEnrcypt.Font = new Font("Open Sans", 10F, FontStyle.Bold);
        lblEnrcypt.ForeColor = SystemColors.ButtonHighlight;
        lblEnrcypt.Location = new Point(544, 128);
        lblEnrcypt.Margin = new Padding(2, 0, 2, 0);
        lblEnrcypt.Name = "lblEnrcypt";
        lblEnrcypt.Size = new Size(138, 32);
        lblEnrcypt.TabIndex = 13;
        lblEnrcypt.Text = "Encrypt";
        lblEnrcypt.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblComb
        // 
        lblComb.Anchor = AnchorStyles.None;
        Transition.SetDecoration(lblComb, Guna.UI2.AnimatorNS.DecorationType.None);
        lblComb.Font = new Font("Open Sans", 10F, FontStyle.Bold);
        lblComb.ForeColor = SystemColors.ButtonHighlight;
        lblComb.Location = new Point(304, 128);
        lblComb.Margin = new Padding(2, 0, 2, 0);
        lblComb.Name = "lblComb";
        lblComb.Size = new Size(138, 32);
        lblComb.TabIndex = 13;
        lblComb.Text = "Compress";
        lblComb.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblFile
        // 
        lblFile.Anchor = AnchorStyles.None;
        Transition.SetDecoration(lblFile, Guna.UI2.AnimatorNS.DecorationType.None);
        lblFile.Font = new Font("Open Sans", 10F, FontStyle.Bold);
        lblFile.ForeColor = Color.White;
        lblFile.Location = new Point(56, 128);
        lblFile.Margin = new Padding(2, 0, 2, 0);
        lblFile.Name = "lblFile";
        lblFile.Size = new Size(138, 32);
        lblFile.TabIndex = 13;
        lblFile.Text = "Choose File";
        lblFile.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // linkAccountOnline
        // 
        linkAccountOnline.Anchor = AnchorStyles.None;
        linkAccountOnline.AutoSize = true;
        Transition.SetDecoration(linkAccountOnline, Guna.UI2.AnimatorNS.DecorationType.None);
        linkAccountOnline.Location = new Point(508, 535);
        linkAccountOnline.Margin = new Padding(2, 0, 2, 0);
        linkAccountOnline.Name = "linkAccountOnline";
        linkAccountOnline.Size = new Size(180, 25);
        linkAccountOnline.TabIndex = 0;
        linkAccountOnline.TabStop = true;
        linkAccountOnline.Text = "Manage Subscription";
        // 
        // pnlReady
        // 
        pnlReady.Anchor = AnchorStyles.None;
        pnlReady.BackColor = Color.Transparent;
        Transition.SetDecoration(pnlReady, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlReady.ImageRotate = 0F;
        pnlReady.Location = new Point(840, 72);
        pnlReady.Margin = new Padding(2);
        pnlReady.Name = "pnlReady";
        pnlReady.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
        pnlReady.Size = new Size(40, 40);
        pnlReady.TabIndex = 11;
        pnlReady.TabStop = false;
        // 
        // pnlEncrypt
        // 
        pnlEncrypt.Anchor = AnchorStyles.None;
        pnlEncrypt.BackColor = Color.Transparent;
        Transition.SetDecoration(pnlEncrypt, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlEncrypt.ImageRotate = 0F;
        pnlEncrypt.Location = new Point(592, 72);
        pnlEncrypt.Margin = new Padding(2);
        pnlEncrypt.Name = "pnlEncrypt";
        pnlEncrypt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
        pnlEncrypt.Size = new Size(40, 40);
        pnlEncrypt.TabIndex = 11;
        pnlEncrypt.TabStop = false;
        // 
        // pnlComb
        // 
        pnlComb.Anchor = AnchorStyles.None;
        pnlComb.BackColor = Color.Transparent;
        Transition.SetDecoration(pnlComb, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlComb.ImageRotate = 0F;
        pnlComb.Location = new Point(352, 72);
        pnlComb.Margin = new Padding(2);
        pnlComb.Name = "pnlComb";
        pnlComb.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
        pnlComb.Size = new Size(40, 40);
        pnlComb.TabIndex = 11;
        pnlComb.TabStop = false;
        // 
        // guna2Panel3
        // 
        guna2Panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        guna2Panel3.BorderRadius = 15;
        guna2Panel3.Controls.Add(progress);
        guna2Panel3.Controls.Add(guna2Button1);
        Transition.SetDecoration(guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Panel3.FillColor = Color.White;
        guna2Panel3.Location = new Point(400, 789);
        guna2Panel3.Margin = new Padding(2);
        guna2Panel3.Name = "guna2Panel3";
        guna2Panel3.Size = new Size(600, 58);
        guna2Panel3.TabIndex = 3;
        // 
        // progress
        // 
        progress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        progress.BackColor = Color.Transparent;
        progress.BorderColor = Color.Gainsboro;
        progress.BorderRadius = 20;
        progress.BorderThickness = 2;
        Transition.SetDecoration(progress, Guna.UI2.AnimatorNS.DecorationType.None);
        progress.FillColor = Color.Transparent;
        progress.Location = new Point(0, 0);
        progress.Margin = new Padding(2);
        progress.Name = "progress";
        progress.ProgressColor = Color.DeepSkyBlue;
        progress.ProgressColor2 = Color.RoyalBlue;
        progress.ShowText = true;
        progress.Size = new Size(600, 56);
        progress.TabIndex = 15;
        progress.Text = "guna2ProgressBar1";
        progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
        progress.Visible = false;
        // 
        // guna2Button1
        // 
        guna2Button1.Animated = true;
        guna2Button1.BorderColor = Color.Gainsboro;
        guna2Button1.BorderRadius = 20;
        guna2Button1.BorderThickness = 2;
        Transition.SetDecoration(guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button1.DisabledState.BorderColor = Color.DarkGray;
        guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button1.Dock = DockStyle.Fill;
        guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        guna2Button1.ForeColor = Color.White;
        guna2Button1.Location = new Point(0, 0);
        guna2Button1.Margin = new Padding(2);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.Size = new Size(600, 58);
        guna2Button1.TabIndex = 0;
        guna2Button1.Text = "Start";
        guna2Button1.Click += guna2Button1_Click;
        // 
        // pnlFiles
        // 
        pnlFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        pnlFiles.BorderColor = Color.Gainsboro;
        pnlFiles.BorderRadius = 15;
        pnlFiles.BorderThickness = 2;
        pnlFiles.Controls.Add(chbFolders);
        pnlFiles.Controls.Add(bntChangeToFolders);
        pnlFiles.Controls.Add(bntChangeToFiles);
        pnlFiles.Controls.Add(chblistFiles);
        Transition.SetDecoration(pnlFiles, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlFiles.FillColor = Color.WhiteSmoke;
        pnlFiles.Location = new Point(24, 384);
        pnlFiles.Margin = new Padding(2);
        pnlFiles.Name = "pnlFiles";
        pnlFiles.Size = new Size(352, 469);
        pnlFiles.TabIndex = 3;
        // 
        // chbFolders
        // 
        chbFolders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        chbFolders.BackColor = Color.WhiteSmoke;
        chbFolders.BorderStyle = BorderStyle.None;
        chbFolders.ColumnWidth = 35;
        Transition.SetDecoration(chbFolders, Guna.UI2.AnimatorNS.DecorationType.None);
        chbFolders.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        chbFolders.ForeColor = Color.Gray;
        chbFolders.FormattingEnabled = true;
        chbFolders.Location = new Point(32, 112);
        chbFolders.Margin = new Padding(2);
        chbFolders.Name = "chbFolders";
        chbFolders.Size = new Size(296, 280);
        chbFolders.TabIndex = 4;
        chbFolders.UseCompatibleTextRendering = true;
        chbFolders.Visible = false;
        // 
        // bntChangeToFolders
        // 
        bntChangeToFolders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        bntChangeToFolders.Animated = true;
        bntChangeToFolders.BackColor = Color.Transparent;
        bntChangeToFolders.BorderColor = Color.Gainsboro;
        bntChangeToFolders.BorderRadius = 20;
        bntChangeToFolders.BorderThickness = 2;
        bntChangeToFolders.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
        bntChangeToFolders.CheckedState.ForeColor = Color.White;
        bntChangeToFolders.CustomizableEdges.BottomLeft = false;
        bntChangeToFolders.CustomizableEdges.TopLeft = false;
        Transition.SetDecoration(bntChangeToFolders, Guna.UI2.AnimatorNS.DecorationType.None);
        bntChangeToFolders.DisabledState.BorderColor = Color.DarkGray;
        bntChangeToFolders.DisabledState.CustomBorderColor = Color.DarkGray;
        bntChangeToFolders.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntChangeToFolders.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntChangeToFolders.FillColor = Color.WhiteSmoke;
        bntChangeToFolders.FocusedColor = Color.FromArgb(100, 170, 209);
        bntChangeToFolders.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        bntChangeToFolders.ForeColor = Color.Gray;
        bntChangeToFolders.HoverState.FillColor = Color.RoyalBlue;
        bntChangeToFolders.HoverState.ForeColor = Color.White;
        bntChangeToFolders.ImageSize = new Size(25, 25);
        bntChangeToFolders.Location = new Point(176, 40);
        bntChangeToFolders.Margin = new Padding(2);
        bntChangeToFolders.Name = "bntChangeToFolders";
        bntChangeToFolders.Size = new Size(144, 48);
        bntChangeToFolders.TabIndex = 16;
        bntChangeToFolders.Text = "Folders";
        bntChangeToFolders.Click += guna2Button7_Click;
        // 
        // bntChangeToFiles
        // 
        bntChangeToFiles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        bntChangeToFiles.Animated = true;
        bntChangeToFiles.BackColor = Color.Transparent;
        bntChangeToFiles.BorderColor = Color.Gainsboro;
        bntChangeToFiles.BorderRadius = 20;
        bntChangeToFiles.BorderThickness = 2;
        bntChangeToFiles.Checked = true;
        bntChangeToFiles.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
        bntChangeToFiles.CheckedState.ForeColor = Color.White;
        bntChangeToFiles.CustomizableEdges.BottomRight = false;
        bntChangeToFiles.CustomizableEdges.TopRight = false;
        Transition.SetDecoration(bntChangeToFiles, Guna.UI2.AnimatorNS.DecorationType.None);
        bntChangeToFiles.DisabledState.BorderColor = Color.DarkGray;
        bntChangeToFiles.DisabledState.CustomBorderColor = Color.DarkGray;
        bntChangeToFiles.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntChangeToFiles.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntChangeToFiles.FillColor = Color.WhiteSmoke;
        bntChangeToFiles.FocusedColor = Color.FromArgb(100, 170, 209);
        bntChangeToFiles.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        bntChangeToFiles.ForeColor = Color.Gray;
        bntChangeToFiles.HoverState.FillColor = Color.RoyalBlue;
        bntChangeToFiles.HoverState.ForeColor = Color.White;
        bntChangeToFiles.Location = new Point(32, 40);
        bntChangeToFiles.Margin = new Padding(2);
        bntChangeToFiles.Name = "bntChangeToFiles";
        bntChangeToFiles.Size = new Size(152, 48);
        bntChangeToFiles.TabIndex = 17;
        bntChangeToFiles.Text = "Files";
        bntChangeToFiles.Click += guna2Button2_Click;
        // 
        // chblistFiles
        // 
        chblistFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        chblistFiles.BackColor = Color.WhiteSmoke;
        chblistFiles.BorderStyle = BorderStyle.None;
        chblistFiles.ColumnWidth = 35;
        Transition.SetDecoration(chblistFiles, Guna.UI2.AnimatorNS.DecorationType.None);
        chblistFiles.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        chblistFiles.ForeColor = Color.Gray;
        chblistFiles.FormattingEnabled = true;
        chblistFiles.Location = new Point(32, 112);
        chblistFiles.Margin = new Padding(2);
        chblistFiles.Name = "chblistFiles";
        chblistFiles.Size = new Size(296, 280);
        chblistFiles.TabIndex = 2;
        // 
        // pnlChild
        // 
        pnlChild.AllowDrop = true;
        pnlChild.Anchor = AnchorStyles.None;
        pnlChild.BackColor = Color.Transparent;
        pnlChild.BackgroundImage = Properties.Resources.Removal_294;
        pnlChild.BackgroundImageLayout = ImageLayout.Zoom;
        pnlChild.BorderRadius = 15;
        pnlChild.Controls.Add(label1);
        Transition.SetDecoration(pnlChild, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlChild.FillColor = Color.Transparent;
        pnlChild.Location = new Point(224, 36);
        pnlChild.Margin = new Padding(2);
        pnlChild.Name = "pnlChild";
        pnlChild.Size = new Size(160, 240);
        pnlChild.TabIndex = 3;
        pnlChild.DragDrop += panel2_DragDrop;
        pnlChild.DragEnter += panel2_DragEnter;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.None;
        Transition.SetDecoration(label1, Guna.UI2.AnimatorNS.DecorationType.None);
        label1.Font = new Font("Open Sans", 9F, FontStyle.Bold);
        label1.ForeColor = SystemColors.AppWorkspace;
        label1.Location = new Point(8, 200);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(144, 32);
        label1.TabIndex = 13;
        label1.Text = "or";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // guna2Panel2
        // 
        guna2Panel2.AllowDrop = true;
        guna2Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        guna2Panel2.BackColor = Color.Transparent;
        guna2Panel2.BackgroundImageLayout = ImageLayout.Zoom;
        guna2Panel2.BorderColor = Color.Gainsboro;
        guna2Panel2.BorderRadius = 15;
        guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        guna2Panel2.BorderThickness = 2;
        guna2Panel2.Controls.Add(bntOpen);
        guna2Panel2.Controls.Add(pnlChild);
        Transition.SetDecoration(guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Panel2.FillColor = Color.Transparent;
        guna2Panel2.Location = new Point(400, 384);
        guna2Panel2.Margin = new Padding(2);
        guna2Panel2.Name = "guna2Panel2";
        guna2Panel2.Size = new Size(600, 384);
        guna2Panel2.TabIndex = 3;
        guna2Panel2.DragDrop += panel2_DragDrop;
        guna2Panel2.DragEnter += panel2_DragEnter;
        // 
        // pswDialog
        // 
        pswDialog.Content = "Put in an Encrypten Key";
        pswDialog.MainInstruction = "Encrypten Key";
        pswDialog.WindowTitle = "MainHost";
        // 
        // taskBarProgress
        // 
        taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.NoProgress;
        taskBarProgress.TargetForm = this;
        // 
        // asyncTask
        // 
        asyncTask.Description = "We prepraing youre Files";
        asyncTask.ShowTimeRemaining = true;
        asyncTask.Text = "Please hold on";
        asyncTask.WindowTitle = "MainHost";
        // 
        // Transition
        // 
        Transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
        Transition.Cursor = null;
        animation1.AnimateOnlyDifferences = true;
        animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
        animation1.LeafCoeff = 0F;
        animation1.MaxTime = 1F;
        animation1.MinTime = 0F;
        animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
        animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
        animation1.MosaicSize = 0;
        animation1.Padding = new Padding(0);
        animation1.RotateCoeff = 0F;
        animation1.RotateLimit = 0F;
        animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
        animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
        animation1.TimeCoeff = 0F;
        animation1.TransparencyCoeff = 1F;
        Transition.DefaultAnimation = animation1;
        Transition.Interval = 1;
        // 
        // uiEncryt
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ButtonHighlight;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(1020, 872);
        Controls.Add(guna2Panel1);
        Controls.Add(guna2Panel2);
        Controls.Add(pnlFiles);
        Controls.Add(guna2Panel3);
        Controls.Add(sPanel1);
        Transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
        DoubleBuffered = true;
        Margin = new Padding(2);
        Name = "uiEncryt";
        Text = "uiEncryt";
        Load += uiEncryt_Load;
        sPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pnlFile).EndInit();
        guna2Panel1.ResumeLayout(false);
        guna2Panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pnlReady).EndInit();
        ((System.ComponentModel.ISupportInitialize)pnlEncrypt).EndInit();
        ((System.ComponentModel.ISupportInitialize)pnlComb).EndInit();
        guna2Panel3.ResumeLayout(false);
        pnlFiles.ResumeLayout(false);
        pnlChild.ResumeLayout(false);
        guna2Panel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Sipaa.Framework.SPanel sPanel1;
    private Label lblText;
    private Guna.UI2.WinForms.Guna2Button bntOpen;
    private Guna.UI2.WinForms.Guna2CirclePictureBox pnlFile;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    private LinkLabel linkAccountOnline;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
    private Guna.UI2.WinForms.Guna2Panel pnlFiles;
    private Guna.UI2.WinForms.Guna2CirclePictureBox pnlReady;
    private Guna.UI2.WinForms.Guna2CirclePictureBox pnlEncrypt;
    private Guna.UI2.WinForms.Guna2CirclePictureBox pnlComb;
    private Label lblReady;
    private Label lblEnrcypt;
    private Label lblComb;
    private Label lblFile;
    private Guna.UI2.WinForms.Guna2ProgressBar progress;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
    private Guna.UI2.WinForms.Guna2Panel pnlChild;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    private Label label1;
    private CheckedListBox chblistFiles;
    private Ookii.Dialogs.WinForms.InputDialog pswDialog;
    private Guna.UI2.WinForms.Guna2TaskBarProgress taskBarProgress;
    private Guna.UI2.WinForms.Guna2Button bntCancel;
    private Guna.UI2.WinForms.Guna2Button bntPlugin;
    private Ookii.Dialogs.WinForms.ProgressDialog asyncTask;
    private Guna.UI2.WinForms.Guna2Button bntChangeToFolders;
    private Guna.UI2.WinForms.Guna2Button bntChangeToFiles;
    public Guna.UI2.WinForms.Guna2Transition Transition;
    private CheckedListBox chbFolders;
}