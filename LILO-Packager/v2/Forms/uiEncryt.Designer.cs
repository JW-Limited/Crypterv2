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
        chblistFiles = new CheckedListBox();
        label4 = new Label();
        pnlChild = new Guna.UI2.WinForms.Guna2Panel();
        label1 = new Label();
        guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
        pswDialog = new Ookii.Dialogs.WinForms.InputDialog(components);
        taskBarProgress = new Guna.UI2.WinForms.Guna2TaskBarProgress(components);
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
        sPanel1.BackColor = Color.Black;
        sPanel1.BackgroundImage = Properties.Resources.Aqua_Marine_180degree;
        sPanel1.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel1.BorderColor = Color.Black;
        sPanel1.BorderRadius = 20;
        sPanel1.BorderSize = 0;
        sPanel1.Controls.Add(bntPlugin);
        sPanel1.Controls.Add(bntCancel);
        sPanel1.Controls.Add(lblText);
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
        bntPlugin.DisabledState.BorderColor = Color.DarkGray;
        bntPlugin.DisabledState.CustomBorderColor = Color.DarkGray;
        bntPlugin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntPlugin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntPlugin.FillColor = Color.Transparent;
        bntPlugin.FocusedColor = Color.FromArgb(100, 170, 209);
        bntPlugin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        bntPlugin.ForeColor = Color.White;
        bntPlugin.Location = new Point(872, 16);
        bntPlugin.Margin = new Padding(2);
        bntPlugin.Name = "bntPlugin";
        bntPlugin.Size = new Size(88, 58);
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
        bntCancel.DisabledState.BorderColor = Color.DarkGray;
        bntCancel.DisabledState.CustomBorderColor = Color.DarkGray;
        bntCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntCancel.FillColor = Color.Transparent;
        bntCancel.FocusedColor = Color.FromArgb(100, 170, 209);
        bntCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        bntCancel.ForeColor = Color.White;
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
        lblText.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        lblText.ForeColor = Color.White;
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
        bntOpen.DisabledState.BorderColor = Color.DarkGray;
        bntOpen.DisabledState.CustomBorderColor = Color.DarkGray;
        bntOpen.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntOpen.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntOpen.FocusedColor = Color.FromArgb(100, 170, 209);
        bntOpen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        bntOpen.ForeColor = Color.White;
        bntOpen.Location = new Point(216, 344);
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
        guna2Panel1.BackColor = Color.Transparent;
        guna2Panel1.BorderColor = SystemColors.ActiveBorder;
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
        guna2Panel1.FillColor = Color.Gainsboro;
        guna2Panel1.Location = new Point(24, 160);
        guna2Panel1.Margin = new Padding(2);
        guna2Panel1.Name = "guna2Panel1";
        guna2Panel1.Size = new Size(976, 200);
        guna2Panel1.TabIndex = 12;
        // 
        // lblReady
        // 
        lblReady.Anchor = AnchorStyles.None;
        lblReady.Font = new Font("Open Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
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
        lblEnrcypt.Font = new Font("Open Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
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
        lblComb.Font = new Font("Open Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
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
        lblFile.Font = new Font("Open Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
        lblFile.ForeColor = SystemColors.ButtonHighlight;
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
        linkAccountOnline.Location = new Point(507, 535);
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
        guna2Panel3.FillColor = Color.White;
        guna2Panel3.Location = new Point(400, 864);
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
        progress.FillColor = Color.Transparent;
        progress.Location = new Point(0, 0);
        progress.Name = "progress";
        progress.ProgressColor = Color.DeepSkyBlue;
        progress.ProgressColor2 = Color.Navy;
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
        guna2Button1.DisabledState.BorderColor = Color.DarkGray;
        guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button1.Dock = DockStyle.Fill;
        guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
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
        pnlFiles.BorderColor = SystemColors.ActiveBorder;
        pnlFiles.BorderRadius = 15;
        pnlFiles.BorderThickness = 2;
        pnlFiles.Controls.Add(chblistFiles);
        pnlFiles.Controls.Add(label4);
        pnlFiles.FillColor = Color.Gainsboro;
        pnlFiles.Location = new Point(24, 384);
        pnlFiles.Margin = new Padding(2);
        pnlFiles.Name = "pnlFiles";
        pnlFiles.Size = new Size(352, 544);
        pnlFiles.TabIndex = 3;
        // 
        // chblistFiles
        // 
        chblistFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        chblistFiles.BackColor = Color.Gainsboro;
        chblistFiles.BorderStyle = BorderStyle.None;
        chblistFiles.CheckOnClick = true;
        chblistFiles.ColumnWidth = 35;
        chblistFiles.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        chblistFiles.ForeColor = Color.White;
        chblistFiles.FormattingEnabled = true;
        chblistFiles.Location = new Point(32, 64);
        chblistFiles.Name = "chblistFiles";
        chblistFiles.Size = new Size(296, 448);
        chblistFiles.TabIndex = 2;
        chblistFiles.ThreeDCheckBoxes = true;
        // 
        // label4
        // 
        label4.BackColor = Color.Transparent;
        label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        label4.ForeColor = Color.DimGray;
        label4.Location = new Point(8, 8);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(96, 56);
        label4.TabIndex = 1;
        label4.Text = "Files";
        label4.TextAlign = ContentAlignment.MiddleCenter;
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
        pnlChild.FillColor = Color.Transparent;
        pnlChild.Location = new Point(224, 72);
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
        label1.Font = new Font("Open Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
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
        guna2Panel2.FillColor = Color.Transparent;
        guna2Panel2.Location = new Point(400, 384);
        guna2Panel2.Margin = new Padding(2);
        guna2Panel2.Name = "guna2Panel2";
        guna2Panel2.Size = new Size(600, 456);
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
        // uiEncryt
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ButtonHighlight;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(1020, 948);
        Controls.Add(guna2Panel1);
        Controls.Add(guna2Panel2);
        Controls.Add(pnlFiles);
        Controls.Add(guna2Panel3);
        Controls.Add(sPanel1);
        DoubleBuffered = true;
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
    private Label label4;
    private Guna.UI2.WinForms.Guna2Panel pnlChild;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    private Label label1;
    private CheckedListBox chblistFiles;
    private Ookii.Dialogs.WinForms.InputDialog pswDialog;
    private Guna.UI2.WinForms.Guna2TaskBarProgress taskBarProgress;
    private Guna.UI2.WinForms.Guna2Button bntCancel;
    private Guna.UI2.WinForms.Guna2Button bntPlugin;
}