namespace LILO_Packager;

partial class mainUI
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        var animation1 = new Guna.UI2.AnimatorNS.Animation();
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(mainUI));
        lblPath = new Label();
        label2 = new Label();
        lblCorporation = new Label();
        lblStats = new Label();
        timer1 = new System.Windows.Forms.Timer(components);
        fd = new OpenFileDialog();
        label1 = new Label();
        txtKey = new Sipaa.Framework.STextBox();
        Form_Edit = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
        dragPanel = new Sipaa.Framework.SPanel();
        lblDrop = new Label();
        panel2 = new Panel();
        header = new Guna.UI2.WinForms.Guna2Panel();
        bntSettings = new Guna.UI2.WinForms.Guna2CircleButton();
        bntExit = new Guna.UI2.WinForms.Guna2ControlBox();
        progressSpinner = new Guna.UI2.WinForms.Guna2ProgressIndicator();
        lblText = new Label();
        label5 = new Label();
        txtInfo = new Sipaa.Framework.STextBox();
        drageControl = new Guna.UI2.WinForms.Guna2DragControl(components);
        bntCorp = new Guna.UI2.WinForms.Guna2Button();
        panelPreview2 = new Sipaa.Framework.SPanel();
        progress = new Guna.UI2.WinForms.Guna2ProgressBar();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        panelPreview = new Sipaa.Framework.SPanel();
        previewImage = new PictureBox();
        bntEncrypt = new Guna.UI2.WinForms.Guna2Button();
        bnt_Decrypt = new Guna.UI2.WinForms.Guna2Button();
        bntChoose_File = new Guna.UI2.WinForms.Guna2Button();
        hider = new Sipaa.Framework.SPanel();
        picbox = new PictureBox();
        sPanel1 = new Sipaa.Framework.SPanel();
        label6 = new Label();
        taskBarProgress = new Guna.UI2.WinForms.Guna2TaskBarProgress(components);
        guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
        bntDirectory = new Guna.UI2.WinForms.Guna2Button();
        dragPanel.SuspendLayout();
        panel2.SuspendLayout();
        header.SuspendLayout();
        panelPreview2.SuspendLayout();
        panelPreview.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)previewImage).BeginInit();
        hider.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picbox).BeginInit();
        sPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // lblPath
        // 
        lblPath.AutoEllipsis = true;
        lblPath.BackColor = Color.Transparent;
        guna2Transition1.SetDecoration(lblPath, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(lblPath, "lblPath");
        lblPath.Name = "lblPath";
        // 
        // label2
        // 
        resources.ApplyResources(label2, "label2");
        label2.BackColor = Color.Transparent;
        guna2Transition1.SetDecoration(label2, Guna.UI2.AnimatorNS.DecorationType.None);
        label2.Name = "label2";
        // 
        // lblCorporation
        // 
        lblCorporation.AllowDrop = true;
        guna2Transition1.SetDecoration(lblCorporation, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(lblCorporation, "lblCorporation");
        lblCorporation.ForeColor = SystemColors.AppWorkspace;
        lblCorporation.Name = "lblCorporation";
        // 
        // lblStats
        // 
        lblStats.AutoEllipsis = true;
        lblStats.BackColor = Color.Transparent;
        guna2Transition1.SetDecoration(lblStats, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(lblStats, "lblStats");
        lblStats.Name = "lblStats";
        // 
        // timer1
        // 
        timer1.Enabled = true;
        timer1.Tick += dropDraged_Tick;
        // 
        // label1
        // 
        resources.ApplyResources(label1, "label1");
        guna2Transition1.SetDecoration(label1, Guna.UI2.AnimatorNS.DecorationType.None);
        label1.ForeColor = SystemColors.ButtonFace;
        label1.Name = "label1";
        // 
        // txtKey
        // 
        txtKey.BackColor = Color.FromArgb(17, 17, 17);
        txtKey.BorderColor = Color.DarkBlue;
        txtKey.BorderFocusColor = Color.FromArgb(192, 192, 255);
        txtKey.BorderRadius = 0;
        txtKey.BorderSize = 1;
        guna2Transition1.SetDecoration(txtKey, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(txtKey, "txtKey");
        txtKey.ForeColor = Color.FromArgb(64, 64, 64);
        txtKey.Multiline = false;
        txtKey.Name = "txtKey";
        txtKey.PasswordChar = false;
        txtKey.PlaceholderColor = Color.DarkGray;
        txtKey.PlaceholderText = "Input Key here...";
        txtKey.Texts = "";
        txtKey.UnderlinedStyle = false;
        // 
        // Form_Edit
        // 
        Form_Edit.BorderRadius = 15;
        Form_Edit.ContainerControl = this;
        Form_Edit.DockForm = false;
        Form_Edit.DockIndicatorTransparencyValue = 0.6D;
        Form_Edit.DragForm = false;
        Form_Edit.DragStartTransparencyValue = 1D;
        Form_Edit.HasFormShadow = false;
        Form_Edit.ResizeForm = false;
        Form_Edit.TransparentWhileDrag = true;
        // 
        // dragPanel
        // 
        dragPanel.AllowDrop = true;
        dragPanel.BackColor = Color.DimGray;
        dragPanel.BorderColor = Color.Black;
        dragPanel.BorderRadius = 15;
        dragPanel.BorderSize = 0;
        dragPanel.Controls.Add(lblDrop);
        guna2Transition1.SetDecoration(dragPanel, Guna.UI2.AnimatorNS.DecorationType.None);
        dragPanel.ForeColor = Color.White;
        resources.ApplyResources(dragPanel, "dragPanel");
        dragPanel.Name = "dragPanel";
        dragPanel.DragDrop += panel2_DragDrop;
        dragPanel.DragEnter += panel2_DragEnter;
        // 
        // lblDrop
        // 
        lblDrop.AllowDrop = true;
        lblDrop.AutoEllipsis = true;
        lblDrop.BackColor = Color.Transparent;
        guna2Transition1.SetDecoration(lblDrop, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(lblDrop, "lblDrop");
        lblDrop.ForeColor = Color.Gray;
        lblDrop.Name = "lblDrop";
        lblDrop.UseCompatibleTextRendering = true;
        lblDrop.DragDrop += panel2_DragDrop;
        lblDrop.DragEnter += panel2_DragEnter;
        lblDrop.MouseHover += mouseHover;
        // 
        // panel2
        // 
        panel2.BackColor = SystemColors.ControlDarkDark;
        panel2.Controls.Add(lblCorporation);
        guna2Transition1.SetDecoration(panel2, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(panel2, "panel2");
        panel2.Name = "panel2";
        // 
        // header
        // 
        header.BackColor = SystemColors.ControlDarkDark;
        header.BorderRadius = 10;
        header.Controls.Add(bntSettings);
        header.Controls.Add(bntExit);
        header.Controls.Add(progressSpinner);
        header.Controls.Add(lblText);
        guna2Transition1.SetDecoration(header, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(header, "header");
        header.Name = "header";
        header.Paint += header_Paint;
        // 
        // bntSettings
        // 
        bntSettings.Animated = true;
        bntSettings.BackColor = Color.Transparent;
        bntSettings.BackgroundImage = Properties.Resources.icons8_settings_32;
        resources.ApplyResources(bntSettings, "bntSettings");
        guna2Transition1.SetDecoration(bntSettings, Guna.UI2.AnimatorNS.DecorationType.None);
        bntSettings.DisabledState.BorderColor = Color.DarkGray;
        bntSettings.DisabledState.CustomBorderColor = Color.DarkGray;
        bntSettings.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntSettings.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntSettings.FillColor = Color.Transparent;
        bntSettings.ForeColor = Color.White;
        bntSettings.Name = "bntSettings";
        bntSettings.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
        // 
        // bntExit
        // 
        bntExit.Animated = true;
        guna2Transition1.SetDecoration(bntExit, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(bntExit, "bntExit");
        bntExit.FillColor = Color.FromArgb(139, 152, 166);
        bntExit.HoverState.FillColor = Color.Red;
        bntExit.IconColor = Color.White;
        bntExit.Name = "bntExit";
        // 
        // progressSpinner
        // 
        resources.ApplyResources(progressSpinner, "progressSpinner");
        progressSpinner.AutoStart = true;
        progressSpinner.BackColor = Color.Transparent;
        guna2Transition1.SetDecoration(progressSpinner, Guna.UI2.AnimatorNS.DecorationType.None);
        progressSpinner.Name = "progressSpinner";
        progressSpinner.NumberOfCircles = 6;
        progressSpinner.ProgressColor = Color.LightSlateGray;
        // 
        // lblText
        // 
        lblText.BackColor = Color.Transparent;
        guna2Transition1.SetDecoration(lblText, Guna.UI2.AnimatorNS.DecorationType.None);
        lblText.ForeColor = SystemColors.ButtonHighlight;
        resources.ApplyResources(lblText, "lblText");
        lblText.Name = "lblText";
        // 
        // label5
        // 
        resources.ApplyResources(label5, "label5");
        guna2Transition1.SetDecoration(label5, Guna.UI2.AnimatorNS.DecorationType.None);
        label5.ForeColor = SystemColors.ButtonFace;
        label5.Name = "label5";
        // 
        // txtInfo
        // 
        txtInfo.BackColor = Color.FromArgb(17, 17, 18);
        txtInfo.BorderColor = Color.DarkBlue;
        txtInfo.BorderFocusColor = Color.FromArgb(192, 192, 255);
        txtInfo.BorderRadius = 0;
        txtInfo.BorderSize = 1;
        guna2Transition1.SetDecoration(txtInfo, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(txtInfo, "txtInfo");
        txtInfo.ForeColor = Color.FromArgb(64, 64, 64);
        txtInfo.Multiline = false;
        txtInfo.Name = "txtInfo";
        txtInfo.PasswordChar = false;
        txtInfo.PlaceholderColor = Color.DarkGray;
        txtInfo.PlaceholderText = "Optional";
        txtInfo.Texts = "";
        txtInfo.UnderlinedStyle = false;
        // 
        // drageControl
        // 
        drageControl.DockIndicatorTransparencyValue = 0.6D;
        drageControl.DragStartTransparencyValue = 1D;
        drageControl.TargetControl = lblText;
        drageControl.TransparentWhileDrag = false;
        // 
        // bntCorp
        // 
        bntCorp.Animated = true;
        bntCorp.BorderRadius = 10;
        bntCorp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        guna2Transition1.SetDecoration(bntCorp, Guna.UI2.AnimatorNS.DecorationType.None);
        bntCorp.DisabledState.BorderColor = Color.DarkGray;
        bntCorp.DisabledState.CustomBorderColor = Color.DarkGray;
        bntCorp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntCorp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        resources.ApplyResources(bntCorp, "bntCorp");
        bntCorp.FillColor = Color.MediumSlateBlue;
        bntCorp.ForeColor = Color.White;
        bntCorp.Name = "bntCorp";
        bntCorp.Click += guna2Button1_Click;
        // 
        // panelPreview2
        // 
        panelPreview2.AllowDrop = true;
        panelPreview2.BackColor = Color.DimGray;
        panelPreview2.BackgroundImage = Properties.Resources.Screenshot_2022_08_25_001747;
        resources.ApplyResources(panelPreview2, "panelPreview2");
        panelPreview2.BorderColor = Color.Black;
        panelPreview2.BorderRadius = 15;
        panelPreview2.BorderSize = 0;
        panelPreview2.Controls.Add(progress);
        panelPreview2.Controls.Add(guna2Button1);
        panelPreview2.Controls.Add(label2);
        panelPreview2.Controls.Add(lblStats);
        guna2Transition1.SetDecoration(panelPreview2, Guna.UI2.AnimatorNS.DecorationType.None);
        panelPreview2.ForeColor = Color.White;
        panelPreview2.Name = "panelPreview2";
        panelPreview2.DragDrop += panel2_DragDrop;
        panelPreview2.DragEnter += panel2_DragEnter;
        // 
        // progress
        // 
        progress.BackColor = Color.Transparent;
        progress.BorderRadius = 16;
        guna2Transition1.SetDecoration(progress, Guna.UI2.AnimatorNS.DecorationType.None);
        progress.FillColor = Color.Gray;
        resources.ApplyResources(progress, "progress");
        progress.Name = "progress";
        progress.ProgressColor = Color.Red;
        progress.ProgressColor2 = Color.Navy;
        progress.ShowText = true;
        progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
        // 
        // guna2Button1
        // 
        guna2Button1.Animated = true;
        guna2Button1.BackColor = Color.Transparent;
        guna2Button1.BorderRadius = 17;
        guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        guna2Transition1.SetDecoration(guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button1.DisabledState.BorderColor = Color.DarkGray;
        guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button1.FillColor = Color.LightSlateGray;
        resources.ApplyResources(guna2Button1, "guna2Button1");
        guna2Button1.ForeColor = Color.White;
        guna2Button1.Name = "guna2Button1";
        guna2Button1.Click += bntClose;
        // 
        // panelPreview
        // 
        panelPreview.AllowDrop = true;
        panelPreview.BackColor = Color.DimGray;
        panelPreview.BackgroundImage = Properties.Resources.Screenshot_2022_08_25_001747;
        resources.ApplyResources(panelPreview, "panelPreview");
        panelPreview.BorderColor = Color.Black;
        panelPreview.BorderRadius = 15;
        panelPreview.BorderSize = 0;
        panelPreview.Controls.Add(previewImage);
        panelPreview.Controls.Add(lblPath);
        guna2Transition1.SetDecoration(panelPreview, Guna.UI2.AnimatorNS.DecorationType.None);
        panelPreview.ForeColor = Color.White;
        panelPreview.Name = "panelPreview";
        panelPreview.DragDrop += panel2_DragDrop;
        panelPreview.DragEnter += panel2_DragEnter;
        // 
        // previewImage
        // 
        previewImage.BackColor = Color.Transparent;
        resources.ApplyResources(previewImage, "previewImage");
        guna2Transition1.SetDecoration(previewImage, Guna.UI2.AnimatorNS.DecorationType.None);
        previewImage.Name = "previewImage";
        previewImage.TabStop = false;
        previewImage.Click += pictureBox1_Click;
        // 
        // bntEncrypt
        // 
        bntEncrypt.Animated = true;
        bntEncrypt.BorderRadius = 10;
        bntEncrypt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        guna2Transition1.SetDecoration(bntEncrypt, Guna.UI2.AnimatorNS.DecorationType.None);
        bntEncrypt.DisabledState.BorderColor = Color.DarkGray;
        bntEncrypt.DisabledState.CustomBorderColor = Color.DarkGray;
        bntEncrypt.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntEncrypt.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        resources.ApplyResources(bntEncrypt, "bntEncrypt");
        bntEncrypt.FillColor = Color.LightSlateGray;
        bntEncrypt.ForeColor = Color.White;
        bntEncrypt.Name = "bntEncrypt";
        bntEncrypt.Click += bntEncrypt_Click;
        // 
        // bnt_Decrypt
        // 
        bnt_Decrypt.Animated = true;
        bnt_Decrypt.BorderRadius = 10;
        bnt_Decrypt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        guna2Transition1.SetDecoration(bnt_Decrypt, Guna.UI2.AnimatorNS.DecorationType.None);
        bnt_Decrypt.DisabledState.BorderColor = Color.DarkGray;
        bnt_Decrypt.DisabledState.CustomBorderColor = Color.DarkGray;
        bnt_Decrypt.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bnt_Decrypt.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        resources.ApplyResources(bnt_Decrypt, "bnt_Decrypt");
        bnt_Decrypt.FillColor = Color.LightSlateGray;
        bnt_Decrypt.ForeColor = Color.White;
        bnt_Decrypt.Name = "bnt_Decrypt";
        bnt_Decrypt.Click += bnt_Decrypt_Click;
        // 
        // bntChoose_File
        // 
        bntChoose_File.Animated = true;
        bntChoose_File.BorderRadius = 17;
        bntChoose_File.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        guna2Transition1.SetDecoration(bntChoose_File, Guna.UI2.AnimatorNS.DecorationType.None);
        bntChoose_File.DisabledState.BorderColor = Color.DarkGray;
        bntChoose_File.DisabledState.CustomBorderColor = Color.DarkGray;
        bntChoose_File.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntChoose_File.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntChoose_File.FillColor = Color.LightSlateGray;
        resources.ApplyResources(bntChoose_File, "bntChoose_File");
        bntChoose_File.ForeColor = Color.White;
        bntChoose_File.Name = "bntChoose_File";
        bntChoose_File.Click += bntChoose_File_Click;
        // 
        // hider
        // 
        hider.AllowDrop = true;
        hider.BackColor = Color.DimGray;
        hider.BorderColor = Color.Black;
        hider.BorderRadius = 15;
        hider.BorderSize = 0;
        hider.Controls.Add(picbox);
        hider.Controls.Add(sPanel1);
        guna2Transition1.SetDecoration(hider, Guna.UI2.AnimatorNS.DecorationType.None);
        hider.ForeColor = Color.White;
        resources.ApplyResources(hider, "hider");
        hider.Name = "hider";
        hider.DragDrop += panel2_DragDrop;
        hider.DragEnter += panel2_DragEnter;
        hider.Paint += hider_Paint;
        // 
        // picbox
        // 
        guna2Transition1.SetDecoration(picbox, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(picbox, "picbox");
        picbox.Name = "picbox";
        picbox.TabStop = false;
        picbox.MouseHover += mouseHover;
        // 
        // sPanel1
        // 
        sPanel1.AllowDrop = true;
        sPanel1.BackColor = Color.Black;
        sPanel1.BackgroundImage = Properties.Resources.Screenshot_2022_08_25_001747;
        sPanel1.BorderColor = Color.Black;
        sPanel1.BorderRadius = 20;
        sPanel1.BorderSize = 0;
        sPanel1.Controls.Add(label6);
        guna2Transition1.SetDecoration(sPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
        sPanel1.ForeColor = Color.White;
        resources.ApplyResources(sPanel1, "sPanel1");
        sPanel1.Name = "sPanel1";
        sPanel1.DragDrop += panel2_DragDrop;
        sPanel1.DragEnter += panel2_DragEnter;
        // 
        // label6
        // 
        label6.BackColor = Color.Transparent;
        guna2Transition1.SetDecoration(label6, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(label6, "label6");
        label6.Name = "label6";
        // 
        // taskBarProgress
        // 
        taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.NoProgress;
        taskBarProgress.TargetForm = this;
        // 
        // guna2Transition1
        // 
        guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Custom;
        guna2Transition1.Cursor = null;
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
        guna2Transition1.DefaultAnimation = animation1;
        guna2Transition1.Interval = 1;
        // 
        // bntDirectory
        // 
        bntDirectory.Animated = true;
        bntDirectory.BorderRadius = 17;
        bntDirectory.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        guna2Transition1.SetDecoration(bntDirectory, Guna.UI2.AnimatorNS.DecorationType.None);
        bntDirectory.DisabledState.BorderColor = Color.DarkGray;
        bntDirectory.DisabledState.CustomBorderColor = Color.DarkGray;
        bntDirectory.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntDirectory.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        resources.ApplyResources(bntDirectory, "bntDirectory");
        bntDirectory.FillColor = Color.LightSlateGray;
        bntDirectory.ForeColor = Color.White;
        bntDirectory.Name = "bntDirectory";
        bntDirectory.Click += bntDirectory_Click;
        // 
        // mainUI
        // 
        AllowDrop = true;
        AutoScaleMode = AutoScaleMode.None;
        BackColor = Color.FromArgb(17, 17, 17);
        resources.ApplyResources(this, "$this");
        ControlBox = false;
        Controls.Add(header);
        Controls.Add(hider);
        Controls.Add(bntDirectory);
        Controls.Add(bntChoose_File);
        Controls.Add(bnt_Decrypt);
        Controls.Add(bntEncrypt);
        Controls.Add(bntCorp);
        Controls.Add(panel2);
        Controls.Add(panelPreview);
        Controls.Add(panelPreview2);
        Controls.Add(dragPanel);
        Controls.Add(txtInfo);
        Controls.Add(label5);
        Controls.Add(txtKey);
        Controls.Add(label1);
        guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
        FormBorderStyle = FormBorderStyle.None;
        MaximizeBox = false;
        Name = "mainUI";
        Load += Form1_Load;
        dragPanel.ResumeLayout(false);
        panel2.ResumeLayout(false);
        header.ResumeLayout(false);
        panelPreview2.ResumeLayout(false);
        panelPreview2.PerformLayout();
        panelPreview.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)previewImage).EndInit();
        hider.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picbox).EndInit();
        sPanel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblPath;
    private Label label2;
    private Label lblStats;
    private System.Windows.Forms.Timer timer1;
    private OpenFileDialog fd;
    private Label label1;
    private Sipaa.Framework.STextBox txtKey;
    private Guna.UI2.WinForms.Guna2BorderlessForm Form_Edit;
    private Guna.UI2.WinForms.Guna2Panel header;
    private Guna.UI2.WinForms.Guna2ControlBox bntExit;
    private Panel panel2;
    private Sipaa.Framework.SPanel dragPanel;
    public Label lblCorporation;
    private Label lblText;
    private Sipaa.Framework.STextBox txtInfo;
    private Label label5;
    private Guna.UI2.WinForms.Guna2DragControl drageControl;
    private Guna.UI2.WinForms.Guna2Button bntCorp;
    private Sipaa.Framework.SPanel panelPreview;
    private Sipaa.Framework.SPanel panelPreview2;
    private Guna.UI2.WinForms.Guna2Button bnt_Decrypt;
    private Guna.UI2.WinForms.Guna2Button bntEncrypt;
    private Guna.UI2.WinForms.Guna2Button bntChoose_File;
    private Sipaa.Framework.SPanel hider;
    private Sipaa.Framework.SPanel sPanel1;
    private Label label6;
    private Label lblDrop;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
    private Guna.UI2.WinForms.Guna2ProgressBar progress;
    private Guna.UI2.WinForms.Guna2TaskBarProgress taskBarProgress;
    private PictureBox picbox;
    private PictureBox previewImage;
    private Guna.UI2.WinForms.Guna2ProgressIndicator progressSpinner;
    private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
    private Guna.UI2.WinForms.Guna2Button bntDirectory;
    private Guna.UI2.WinForms.Guna2CircleButton bntSettings;
}
