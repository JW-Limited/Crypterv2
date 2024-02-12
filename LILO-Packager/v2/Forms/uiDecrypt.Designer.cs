namespace LILO_Packager.v2.Forms;

partial class uiDecrypt
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiDecrypt));
        sPanel1 = new Sipaa.Framework.SPanel();
        bntCancel = new Guna.UI2.WinForms.Guna2Button();
        lblText = new Label();
        guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
        lblReady = new Label();
        linkAccountOnline = new LinkLabel();
        pnlFile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
        lblComb = new Label();
        pnlComb = new Guna.UI2.WinForms.Guna2CirclePictureBox();
        pnlReady = new Guna.UI2.WinForms.Guna2CirclePictureBox();
        lblDecrypt = new Label();
        pnlDecrypt = new Guna.UI2.WinForms.Guna2CirclePictureBox();
        lblFile = new Label();
        pnlFiles = new Guna.UI2.WinForms.Guna2Panel();
        bntChangeToFiles = new Guna.UI2.WinForms.Guna2Button();
        chblistFiles = new CheckedListBox();
        progress = new Guna.UI2.WinForms.Guna2ProgressBar();
        guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
        progress1 = new Guna.UI2.WinForms.Guna2ProgressBar();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
        bntOpen = new Guna.UI2.WinForms.Guna2Button();
        pnlChild = new Guna.UI2.WinForms.Guna2Panel();
        label1 = new Label();
        taskBarProgress = new Guna.UI2.WinForms.Guna2TaskBarProgress(components);
        pswDialog = new Ookii.Dialogs.WinForms.InputDialog(components);
        sPanel1.SuspendLayout();
        guna2Panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pnlFile).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pnlComb).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pnlReady).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pnlDecrypt).BeginInit();
        pnlFiles.SuspendLayout();
        guna2Panel3.SuspendLayout();
        guna2Panel2.SuspendLayout();
        pnlChild.SuspendLayout();
        SuspendLayout();
        // 
        // sPanel1
        // 
        resources.ApplyResources(sPanel1, "sPanel1");
        sPanel1.BackColor = Color.WhiteSmoke;
        sPanel1.BorderColor = Color.Gainsboro;
        sPanel1.BorderRadius = 20;
        sPanel1.BorderSize = 2;
        sPanel1.Controls.Add(bntCancel);
        sPanel1.Controls.Add(lblText);
        sPanel1.ForeColor = Color.White;
        sPanel1.Name = "sPanel1";
        // 
        // bntCancel
        // 
        resources.ApplyResources(bntCancel, "bntCancel");
        bntCancel.Animated = true;
        bntCancel.BackColor = Color.Transparent;
        bntCancel.BorderColor = Color.Gainsboro;
        bntCancel.BorderRadius = 20;
        bntCancel.BorderThickness = 2;
        bntCancel.DisabledState.BorderColor = Color.DarkGray;
        bntCancel.DisabledState.CustomBorderColor = Color.DarkGray;
        bntCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntCancel.FillColor = Color.White;
        bntCancel.FocusedColor = Color.FromArgb(100, 170, 209);
        bntCancel.ForeColor = Color.DimGray;
        bntCancel.Name = "bntCancel";
        // 
        // lblText
        // 
        lblText.BackColor = Color.Transparent;
        resources.ApplyResources(lblText, "lblText");
        lblText.ForeColor = Color.DimGray;
        lblText.Name = "lblText";
        // 
        // guna2Panel1
        // 
        resources.ApplyResources(guna2Panel1, "guna2Panel1");
        guna2Panel1.BackColor = Color.Transparent;
        guna2Panel1.BorderColor = Color.Gainsboro;
        guna2Panel1.BorderRadius = 20;
        guna2Panel1.BorderThickness = 2;
        guna2Panel1.Controls.Add(lblReady);
        guna2Panel1.Controls.Add(linkAccountOnline);
        guna2Panel1.Controls.Add(pnlFile);
        guna2Panel1.Controls.Add(lblComb);
        guna2Panel1.Controls.Add(pnlComb);
        guna2Panel1.Controls.Add(pnlReady);
        guna2Panel1.Controls.Add(lblDecrypt);
        guna2Panel1.Controls.Add(pnlDecrypt);
        guna2Panel1.Controls.Add(lblFile);
        guna2Panel1.FillColor = Color.WhiteSmoke;
        guna2Panel1.Name = "guna2Panel1";
        // 
        // lblReady
        // 
        resources.ApplyResources(lblReady, "lblReady");
        lblReady.ForeColor = SystemColors.ButtonHighlight;
        lblReady.Name = "lblReady";
        // 
        // linkAccountOnline
        // 
        resources.ApplyResources(linkAccountOnline, "linkAccountOnline");
        linkAccountOnline.Name = "linkAccountOnline";
        linkAccountOnline.TabStop = true;
        // 
        // pnlFile
        // 
        resources.ApplyResources(pnlFile, "pnlFile");
        pnlFile.BackColor = Color.Transparent;
        pnlFile.ImageRotate = 0F;
        pnlFile.Name = "pnlFile";
        pnlFile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
        pnlFile.TabStop = false;
        // 
        // lblComb
        // 
        resources.ApplyResources(lblComb, "lblComb");
        lblComb.ForeColor = SystemColors.ButtonHighlight;
        lblComb.Name = "lblComb";
        // 
        // pnlComb
        // 
        resources.ApplyResources(pnlComb, "pnlComb");
        pnlComb.BackColor = Color.Transparent;
        pnlComb.ImageRotate = 0F;
        pnlComb.Name = "pnlComb";
        pnlComb.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
        pnlComb.TabStop = false;
        // 
        // pnlReady
        // 
        resources.ApplyResources(pnlReady, "pnlReady");
        pnlReady.BackColor = Color.Transparent;
        pnlReady.ImageRotate = 0F;
        pnlReady.Name = "pnlReady";
        pnlReady.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
        pnlReady.TabStop = false;
        // 
        // lblDecrypt
        // 
        resources.ApplyResources(lblDecrypt, "lblDecrypt");
        lblDecrypt.ForeColor = SystemColors.ButtonHighlight;
        lblDecrypt.Name = "lblDecrypt";
        // 
        // pnlDecrypt
        // 
        resources.ApplyResources(pnlDecrypt, "pnlDecrypt");
        pnlDecrypt.BackColor = Color.Transparent;
        pnlDecrypt.ImageRotate = 0F;
        pnlDecrypt.Name = "pnlDecrypt";
        pnlDecrypt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
        pnlDecrypt.TabStop = false;
        // 
        // lblFile
        // 
        resources.ApplyResources(lblFile, "lblFile");
        lblFile.ForeColor = SystemColors.ButtonHighlight;
        lblFile.Name = "lblFile";
        // 
        // pnlFiles
        // 
        resources.ApplyResources(pnlFiles, "pnlFiles");
        pnlFiles.BorderColor = Color.Gainsboro;
        pnlFiles.BorderRadius = 15;
        pnlFiles.BorderThickness = 2;
        pnlFiles.Controls.Add(bntChangeToFiles);
        pnlFiles.Controls.Add(chblistFiles);
        pnlFiles.FillColor = Color.WhiteSmoke;
        pnlFiles.Name = "pnlFiles";
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
        // 
        // chblistFiles
        // 
        resources.ApplyResources(chblistFiles, "chblistFiles");
        chblistFiles.BackColor = Color.WhiteSmoke;
        chblistFiles.BorderStyle = BorderStyle.None;
        chblistFiles.CheckOnClick = true;
        chblistFiles.ForeColor = Color.Gray;
        chblistFiles.FormattingEnabled = true;
        chblistFiles.Name = "chblistFiles";
        chblistFiles.ThreeDCheckBoxes = true;
        // 
        // progress
        // 
        resources.ApplyResources(progress, "progress");
        progress.BackColor = Color.Transparent;
        progress.BorderRadius = 20;
        progress.FillColor = Color.Transparent;
        progress.Name = "progress";
        progress.ProgressColor = Color.DeepSkyBlue;
        progress.ProgressColor2 = Color.Navy;
        progress.ShowText = true;
        progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
        // 
        // guna2Panel3
        // 
        resources.ApplyResources(guna2Panel3, "guna2Panel3");
        guna2Panel3.BorderRadius = 15;
        guna2Panel3.Controls.Add(progress1);
        guna2Panel3.Controls.Add(progress);
        guna2Panel3.Controls.Add(guna2Button1);
        guna2Panel3.FillColor = Color.White;
        guna2Panel3.Name = "guna2Panel3";
        // 
        // progress1
        // 
        resources.ApplyResources(progress1, "progress1");
        progress1.BackColor = Color.Transparent;
        progress1.BorderColor = Color.Gainsboro;
        progress1.BorderRadius = 20;
        progress1.BorderThickness = 2;
        progress1.FillColor = Color.Transparent;
        progress1.Name = "progress1";
        progress1.ProgressColor = Color.DeepSkyBlue;
        progress1.ProgressColor2 = Color.RoyalBlue;
        progress1.ShowText = true;
        progress1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
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
        resources.ApplyResources(guna2Button1, "guna2Button1");
        guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button1.ForeColor = Color.White;
        guna2Button1.Name = "guna2Button1";
        guna2Button1.Click += guna2Button1_Click;
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
        guna2Panel2.FillColor = Color.Transparent;
        guna2Panel2.Name = "guna2Panel2";
        guna2Panel2.DragDrop += panel2_DragDrop;
        guna2Panel2.DragEnter += panel2_DragEnter;
        // 
        // bntOpen
        // 
        resources.ApplyResources(bntOpen, "bntOpen");
        bntOpen.Animated = true;
        bntOpen.BorderColor = Color.Gainsboro;
        bntOpen.BorderRadius = 15;
        bntOpen.BorderThickness = 2;
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
        // pnlChild
        // 
        pnlChild.AllowDrop = true;
        resources.ApplyResources(pnlChild, "pnlChild");
        pnlChild.BackColor = Color.Transparent;
        pnlChild.BackgroundImage = Properties.Resources.Removal_294;
        pnlChild.BorderRadius = 15;
        pnlChild.Controls.Add(label1);
        pnlChild.FillColor = Color.Transparent;
        pnlChild.Name = "pnlChild";
        pnlChild.DragDrop += panel2_DragDrop;
        pnlChild.DragEnter += panel2_DragEnter;
        // 
        // label1
        // 
        resources.ApplyResources(label1, "label1");
        label1.ForeColor = SystemColors.AppWorkspace;
        label1.Name = "label1";
        // 
        // taskBarProgress
        // 
        taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.NoProgress;
        taskBarProgress.TargetForm = null;
        // 
        // pswDialog
        // 
        resources.ApplyResources(pswDialog, "pswDialog");
        // 
        // uiDecrypt
        // 
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        Controls.Add(guna2Panel2);
        Controls.Add(guna2Panel3);
        Controls.Add(guna2Panel1);
        Controls.Add(pnlFiles);
        Controls.Add(sPanel1);
        Name = "uiDecrypt";
        Load += uiDecrypt_Load;
        sPanel1.ResumeLayout(false);
        guna2Panel1.ResumeLayout(false);
        guna2Panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pnlFile).EndInit();
        ((System.ComponentModel.ISupportInitialize)pnlComb).EndInit();
        ((System.ComponentModel.ISupportInitialize)pnlReady).EndInit();
        ((System.ComponentModel.ISupportInitialize)pnlDecrypt).EndInit();
        pnlFiles.ResumeLayout(false);
        guna2Panel3.ResumeLayout(false);
        guna2Panel2.ResumeLayout(false);
        pnlChild.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Sipaa.Framework.SPanel sPanel1;
    private Label lblText;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    private Label lblReady;
    private Label lblComb;
    private Label lblDecrypt;
    private Label lblFile;
    private LinkLabel linkAccountOnline;
    private Guna.UI2.WinForms.Guna2CirclePictureBox pnlReady;
    private Guna.UI2.WinForms.Guna2CirclePictureBox pnlComb;
    private Guna.UI2.WinForms.Guna2CirclePictureBox pnlDecrypt;
    private Guna.UI2.WinForms.Guna2CirclePictureBox pnlFile;
    private Guna.UI2.WinForms.Guna2Panel pnlFiles;
    private Guna.UI2.WinForms.Guna2ProgressBar progress;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
    private Guna.UI2.WinForms.Guna2ProgressBar progress1;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    private Guna.UI2.WinForms.Guna2Button bntOpen;
    private Guna.UI2.WinForms.Guna2Panel pnlChild;
    private Label label1;
    private CheckedListBox chblistFiles;
    private Guna.UI2.WinForms.Guna2TaskBarProgress taskBarProgress;
    private Ookii.Dialogs.WinForms.InputDialog pswDialog;
    private Guna.UI2.WinForms.Guna2Button bntCancel;
    private Guna.UI2.WinForms.Guna2Button bntChangeToFiles;
}