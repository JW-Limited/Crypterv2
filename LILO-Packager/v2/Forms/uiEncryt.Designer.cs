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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiEncryt));
        Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
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
        resources.ApplyResources(sPanel1, "sPanel1");
        sPanel1.BackColor = Color.WhiteSmoke;
        sPanel1.BorderColor = Color.Gainsboro;
        sPanel1.BorderRadius = 20;
        sPanel1.BorderSize = 2;
        sPanel1.Controls.Add(bntPlugin);
        sPanel1.Controls.Add(bntCancel);
        sPanel1.Controls.Add(lblText);
        Transition.SetDecoration(sPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
        sPanel1.ForeColor = Color.White;
        sPanel1.Name = "sPanel1";
        // 
        // bntPlugin
        // 
        resources.ApplyResources(bntPlugin, "bntPlugin");
        bntPlugin.Animated = true;
        bntPlugin.BackColor = Color.Transparent;
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
        bntPlugin.ForeColor = Color.DimGray;
        bntPlugin.Name = "bntPlugin";
        bntPlugin.Click += bntOpenPlugin_Clicj;
        // 
        // bntCancel
        // 
        resources.ApplyResources(bntCancel, "bntCancel");
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
        bntCancel.ForeColor = Color.DimGray;
        bntCancel.Name = "bntCancel";
        bntCancel.Click += bntCancel_Click;
        // 
        // lblText
        // 
        lblText.BackColor = Color.Transparent;
        Transition.SetDecoration(lblText, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(lblText, "lblText");
        lblText.ForeColor = Color.DimGray;
        lblText.Name = "lblText";
        // 
        // bntOpen
        // 
        resources.ApplyResources(bntOpen, "bntOpen");
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
        bntOpen.ForeColor = Color.RoyalBlue;
        bntOpen.Name = "bntOpen";
        bntOpen.Click += bntOpen_Click;
        // 
        // pnlFile
        // 
        resources.ApplyResources(pnlFile, "pnlFile");
        pnlFile.BackColor = Color.Transparent;
        Transition.SetDecoration(pnlFile, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlFile.ImageRotate = 0F;
        pnlFile.Name = "pnlFile";
        pnlFile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
        pnlFile.TabStop = false;
        // 
        // guna2Panel1
        // 
        resources.ApplyResources(guna2Panel1, "guna2Panel1");
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
        guna2Panel1.Name = "guna2Panel1";
        // 
        // lblReady
        // 
        resources.ApplyResources(lblReady, "lblReady");
        Transition.SetDecoration(lblReady, Guna.UI2.AnimatorNS.DecorationType.None);
        lblReady.ForeColor = SystemColors.ButtonHighlight;
        lblReady.Name = "lblReady";
        // 
        // lblEnrcypt
        // 
        resources.ApplyResources(lblEnrcypt, "lblEnrcypt");
        Transition.SetDecoration(lblEnrcypt, Guna.UI2.AnimatorNS.DecorationType.None);
        lblEnrcypt.ForeColor = SystemColors.ButtonHighlight;
        lblEnrcypt.Name = "lblEnrcypt";
        // 
        // lblComb
        // 
        resources.ApplyResources(lblComb, "lblComb");
        Transition.SetDecoration(lblComb, Guna.UI2.AnimatorNS.DecorationType.None);
        lblComb.ForeColor = SystemColors.ButtonHighlight;
        lblComb.Name = "lblComb";
        // 
        // lblFile
        // 
        resources.ApplyResources(lblFile, "lblFile");
        Transition.SetDecoration(lblFile, Guna.UI2.AnimatorNS.DecorationType.None);
        lblFile.ForeColor = Color.White;
        lblFile.Name = "lblFile";
        // 
        // linkAccountOnline
        // 
        resources.ApplyResources(linkAccountOnline, "linkAccountOnline");
        Transition.SetDecoration(linkAccountOnline, Guna.UI2.AnimatorNS.DecorationType.None);
        linkAccountOnline.Name = "linkAccountOnline";
        linkAccountOnline.TabStop = true;
        // 
        // pnlReady
        // 
        resources.ApplyResources(pnlReady, "pnlReady");
        pnlReady.BackColor = Color.Transparent;
        Transition.SetDecoration(pnlReady, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlReady.ImageRotate = 0F;
        pnlReady.Name = "pnlReady";
        pnlReady.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
        pnlReady.TabStop = false;
        // 
        // pnlEncrypt
        // 
        resources.ApplyResources(pnlEncrypt, "pnlEncrypt");
        pnlEncrypt.BackColor = Color.Transparent;
        Transition.SetDecoration(pnlEncrypt, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlEncrypt.ImageRotate = 0F;
        pnlEncrypt.Name = "pnlEncrypt";
        pnlEncrypt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
        pnlEncrypt.TabStop = false;
        // 
        // pnlComb
        // 
        resources.ApplyResources(pnlComb, "pnlComb");
        pnlComb.BackColor = Color.Transparent;
        Transition.SetDecoration(pnlComb, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlComb.ImageRotate = 0F;
        pnlComb.Name = "pnlComb";
        pnlComb.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
        pnlComb.TabStop = false;
        // 
        // guna2Panel3
        // 
        resources.ApplyResources(guna2Panel3, "guna2Panel3");
        guna2Panel3.BorderRadius = 15;
        guna2Panel3.Controls.Add(progress);
        guna2Panel3.Controls.Add(guna2Button1);
        Transition.SetDecoration(guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Panel3.FillColor = Color.White;
        guna2Panel3.Name = "guna2Panel3";
        // 
        // progress
        // 
        resources.ApplyResources(progress, "progress");
        progress.BackColor = Color.Transparent;
        progress.BorderColor = Color.Gainsboro;
        progress.BorderRadius = 20;
        progress.BorderThickness = 2;
        Transition.SetDecoration(progress, Guna.UI2.AnimatorNS.DecorationType.None);
        progress.FillColor = Color.Transparent;
        progress.Name = "progress";
        progress.ProgressColor = Color.DeepSkyBlue;
        progress.ProgressColor2 = Color.RoyalBlue;
        progress.ShowText = true;
        progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
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
        resources.ApplyResources(guna2Button1, "guna2Button1");
        guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button1.ForeColor = Color.White;
        guna2Button1.Name = "guna2Button1";
        guna2Button1.Click += guna2Button1_Click;
        // 
        // pnlFiles
        // 
        resources.ApplyResources(pnlFiles, "pnlFiles");
        pnlFiles.BorderColor = Color.Gainsboro;
        pnlFiles.BorderRadius = 15;
        pnlFiles.BorderThickness = 2;
        pnlFiles.Controls.Add(chbFolders);
        pnlFiles.Controls.Add(bntChangeToFolders);
        pnlFiles.Controls.Add(bntChangeToFiles);
        pnlFiles.Controls.Add(chblistFiles);
        Transition.SetDecoration(pnlFiles, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlFiles.FillColor = Color.WhiteSmoke;
        pnlFiles.Name = "pnlFiles";
        // 
        // chbFolders
        // 
        resources.ApplyResources(chbFolders, "chbFolders");
        chbFolders.BackColor = Color.WhiteSmoke;
        chbFolders.BorderStyle = BorderStyle.None;
        Transition.SetDecoration(chbFolders, Guna.UI2.AnimatorNS.DecorationType.None);
        chbFolders.ForeColor = Color.Gray;
        chbFolders.FormattingEnabled = true;
        chbFolders.Name = "chbFolders";
        chbFolders.UseCompatibleTextRendering = true;
        // 
        // bntChangeToFolders
        // 
        resources.ApplyResources(bntChangeToFolders, "bntChangeToFolders");
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
        bntChangeToFolders.ForeColor = Color.Gray;
        bntChangeToFolders.HoverState.FillColor = Color.RoyalBlue;
        bntChangeToFolders.HoverState.ForeColor = Color.White;
        bntChangeToFolders.ImageSize = new Size(25, 25);
        bntChangeToFolders.Name = "bntChangeToFolders";
        bntChangeToFolders.Click += guna2Button7_Click;
        // 
        // bntChangeToFiles
        // 
        resources.ApplyResources(bntChangeToFiles, "bntChangeToFiles");
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
        bntChangeToFiles.ForeColor = Color.Gray;
        bntChangeToFiles.HoverState.FillColor = Color.RoyalBlue;
        bntChangeToFiles.HoverState.ForeColor = Color.White;
        bntChangeToFiles.Name = "bntChangeToFiles";
        bntChangeToFiles.Click += guna2Button2_Click;
        // 
        // chblistFiles
        // 
        resources.ApplyResources(chblistFiles, "chblistFiles");
        chblistFiles.BackColor = Color.WhiteSmoke;
        chblistFiles.BorderStyle = BorderStyle.None;
        Transition.SetDecoration(chblistFiles, Guna.UI2.AnimatorNS.DecorationType.None);
        chblistFiles.ForeColor = Color.Gray;
        chblistFiles.FormattingEnabled = true;
        chblistFiles.Name = "chblistFiles";
        // 
        // pnlChild
        // 
        pnlChild.AllowDrop = true;
        resources.ApplyResources(pnlChild, "pnlChild");
        pnlChild.BackColor = Color.Transparent;
        pnlChild.BackgroundImage = Properties.Resources.Removal_294;
        pnlChild.BorderRadius = 15;
        pnlChild.Controls.Add(label1);
        Transition.SetDecoration(pnlChild, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlChild.FillColor = Color.Transparent;
        pnlChild.Name = "pnlChild";
        pnlChild.DragDrop += panel2_DragDrop;
        pnlChild.DragEnter += panel2_DragEnter;
        // 
        // label1
        // 
        resources.ApplyResources(label1, "label1");
        Transition.SetDecoration(label1, Guna.UI2.AnimatorNS.DecorationType.None);
        label1.ForeColor = SystemColors.AppWorkspace;
        label1.Name = "label1";
        // 
        // guna2Panel2
        // 
        guna2Panel2.AllowDrop = true;
        resources.ApplyResources(guna2Panel2, "guna2Panel2");
        guna2Panel2.BackColor = Color.Transparent;
        guna2Panel2.BorderColor = Color.Gainsboro;
        guna2Panel2.BorderRadius = 15;
        guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        guna2Panel2.BorderThickness = 2;
        guna2Panel2.Controls.Add(bntOpen);
        guna2Panel2.Controls.Add(pnlChild);
        Transition.SetDecoration(guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Panel2.FillColor = Color.Transparent;
        guna2Panel2.Name = "guna2Panel2";
        guna2Panel2.DragDrop += panel2_DragDrop;
        guna2Panel2.DragEnter += panel2_DragEnter;
        // 
        // pswDialog
        // 
        resources.ApplyResources(pswDialog, "pswDialog");
        // 
        // taskBarProgress
        // 
        taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.NoProgress;
        taskBarProgress.TargetForm = this;
        // 
        // asyncTask
        // 
        resources.ApplyResources(asyncTask, "asyncTask");
        asyncTask.ShowTimeRemaining = true;
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
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ButtonHighlight;
        Controls.Add(guna2Panel1);
        Controls.Add(guna2Panel2);
        Controls.Add(pnlFiles);
        Controls.Add(guna2Panel3);
        Controls.Add(sPanel1);
        Transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
        DoubleBuffered = true;
        Name = "uiEncryt";
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