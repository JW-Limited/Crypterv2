namespace LILO_Packager.v2.Forms
{
    partial class uiImportSharedFiles
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
            sPanel1 = new Sipaa.Framework.SPanel();
            bntPlugin = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblArchieveName = new Label();
            lblText = new Label();
            label1 = new Label();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            pnlPlugins = new Panel();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            pnlFile = new Guna.UI2.WinForms.Guna2Panel();
            pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
            prgMiniProgress = new Guna.UI2.WinForms.Guna2ProgressBar();
            guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            panel1 = new Panel();
            pnlLoadButton = new Panel();
            guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            lblFileName = new Label();
            lblDescription = new Label();
            pnlIcon = new Sipaa.Framework.SPanel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckbox();
            materialCheckbox5 = new MaterialSkin.Controls.MaterialCheckbox();
            materialCheckbox6 = new MaterialSkin.Controls.MaterialCheckbox();
            materialCheckbox7 = new MaterialSkin.Controls.MaterialCheckbox();
            lblEntry = new Label();
            sPanel1.SuspendLayout();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            guna2Panel3.SuspendLayout();
            pnlFile.SuspendLayout();
            pnlPreview.SuspendLayout();
            guna2Panel6.SuspendLayout();
            pnlLoadButton.SuspendLayout();
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
            sPanel1.Controls.Add(guna2Panel1);
            sPanel1.Controls.Add(lblText);
            sPanel1.ForeColor = Color.White;
            sPanel1.Location = new Point(30, 30);
            sPanel1.Margin = new Padding(4, 4, 4, 4);
            sPanel1.Name = "sPanel1";
            sPanel1.Size = new Size(1070, 88);
            sPanel1.TabIndex = 11;
            // 
            // bntPlugin
            // 
            bntPlugin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntPlugin.Animated = true;
            bntPlugin.BackColor = Color.Transparent;
            bntPlugin.BackgroundImageLayout = ImageLayout.Zoom;
            bntPlugin.BorderColor = Color.Gainsboro;
            bntPlugin.BorderRadius = 10;
            bntPlugin.BorderThickness = 2;
            bntPlugin.DisabledState.BorderColor = Color.DarkGray;
            bntPlugin.DisabledState.CustomBorderColor = Color.DarkGray;
            bntPlugin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntPlugin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntPlugin.FillColor = Color.White;
            bntPlugin.FocusedColor = Color.FromArgb(100, 170, 209);
            bntPlugin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            bntPlugin.ForeColor = Color.DimGray;
            bntPlugin.Location = new Point(930, 20);
            bntPlugin.Margin = new Padding(2);
            bntPlugin.Name = "bntPlugin";
            bntPlugin.Size = new Size(116, 50);
            bntPlugin.TabIndex = 14;
            bntPlugin.Text = "Close";
            bntPlugin.Click += bntPlugin_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 10;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(lblArchieveName);
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(150, 20);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(280, 50);
            guna2Panel1.TabIndex = 58;
            // 
            // lblArchieveName
            // 
            lblArchieveName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblArchieveName.AutoEllipsis = true;
            lblArchieveName.BackColor = Color.Transparent;
            lblArchieveName.Font = new Font("Segoe UI", 9F);
            lblArchieveName.ForeColor = SystemColors.WindowFrame;
            lblArchieveName.Location = new Point(16, 8);
            lblArchieveName.Margin = new Padding(4, 0, 4, 0);
            lblArchieveName.Name = "lblArchieveName";
            lblArchieveName.Size = new Size(254, 39);
            lblArchieveName.TabIndex = 53;
            lblArchieveName.Text = "Name";
            lblArchieveName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblText
            // 
            lblText.BackColor = Color.Transparent;
            lblText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblText.ForeColor = Color.DimGray;
            lblText.Location = new Point(14, 0);
            lblText.Margin = new Padding(4, 0, 4, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(144, 88);
            lblText.TabIndex = 1;
            lblText.Text = "Import";
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(61, 135);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 40);
            label1.TabIndex = 15;
            label1.Text = "Files";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            guna2Panel2.BorderColor = Color.Gainsboro;
            guna2Panel2.BorderRadius = 15;
            guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel2.BorderThickness = 2;
            guna2Panel2.Controls.Add(pnlPlugins);
            guna2Panel2.FillColor = Color.Transparent;
            guna2Panel2.Location = new Point(30, 160);
            guna2Panel2.Margin = new Padding(2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.Size = new Size(352, 809);
            guna2Panel2.TabIndex = 16;
            // 
            // pnlPlugins
            // 
            pnlPlugins.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlPlugins.AutoScroll = true;
            pnlPlugins.AutoScrollMargin = new Size(1, 0);
            pnlPlugins.Location = new Point(24, 32);
            pnlPlugins.Margin = new Padding(2);
            pnlPlugins.Name = "pnlPlugins";
            pnlPlugins.Size = new Size(306, 756);
            pnlPlugins.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            guna2Panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel3.BorderColor = Color.Gainsboro;
            guna2Panel3.BorderRadius = 15;
            guna2Panel3.BorderThickness = 2;
            guna2Panel3.Controls.Add(pnlFile);
            guna2Panel3.FillColor = Color.Transparent;
            guna2Panel3.Location = new Point(410, 160);
            guna2Panel3.Margin = new Padding(2);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Size = new Size(690, 729);
            guna2Panel3.TabIndex = 16;
            // 
            // pnlFile
            // 
            pnlFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlFile.BackColor = Color.Transparent;
            pnlFile.BorderColor = Color.Gainsboro;
            pnlFile.BorderRadius = 15;
            pnlFile.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pnlFile.BorderThickness = 2;
            pnlFile.Controls.Add(pnlPreview);
            pnlFile.Controls.Add(pnlLoadButton);
            pnlFile.Controls.Add(guna2Button2);
            pnlFile.Controls.Add(lblFileName);
            pnlFile.Controls.Add(lblDescription);
            pnlFile.Controls.Add(pnlIcon);
            pnlFile.FillColor = Color.White;
            pnlFile.Location = new Point(30, 30);
            pnlFile.Margin = new Padding(2);
            pnlFile.Name = "pnlFile";
            pnlFile.Size = new Size(630, 530);
            pnlFile.TabIndex = 57;
            pnlFile.Visible = false;
            // 
            // pnlPreview
            // 
            pnlPreview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPreview.BackColor = Color.Transparent;
            pnlPreview.BorderColor = Color.Gainsboro;
            pnlPreview.BorderRadius = 15;
            pnlPreview.BorderThickness = 2;
            pnlPreview.Controls.Add(prgMiniProgress);
            pnlPreview.Controls.Add(guna2Panel6);
            pnlPreview.Controls.Add(panel1);
            pnlPreview.FillColor = Color.White;
            pnlPreview.Location = new Point(30, 150);
            pnlPreview.Margin = new Padding(2);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Size = new Size(570, 350);
            pnlPreview.TabIndex = 57;
            pnlPreview.Visible = false;
            // 
            // prgMiniProgress
            // 
            prgMiniProgress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            prgMiniProgress.BackColor = Color.Transparent;
            prgMiniProgress.BorderColor = Color.Gainsboro;
            prgMiniProgress.BorderRadius = 2;
            prgMiniProgress.BorderThickness = 2;
            prgMiniProgress.FillColor = Color.White;
            prgMiniProgress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            prgMiniProgress.Location = new Point(210, 170);
            prgMiniProgress.Margin = new Padding(2);
            prgMiniProgress.Name = "prgMiniProgress";
            prgMiniProgress.ProgressColor = Color.SteelBlue;
            prgMiniProgress.ProgressColor2 = Color.RoyalBlue;
            prgMiniProgress.ShadowDecoration.Depth = 20;
            prgMiniProgress.Size = new Size(155, 8);
            prgMiniProgress.Style = ProgressBarStyle.Marquee;
            prgMiniProgress.TabIndex = 60;
            prgMiniProgress.Text = "guna2ProgressBar1";
            prgMiniProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Panel6
            // 
            guna2Panel6.BackColor = Color.Transparent;
            guna2Panel6.BorderColor = Color.Gainsboro;
            guna2Panel6.BorderRadius = 6;
            guna2Panel6.BorderThickness = 2;
            guna2Panel6.Controls.Add(label2);
            guna2Panel6.FillColor = Color.White;
            guna2Panel6.Location = new Point(20, 20);
            guna2Panel6.Margin = new Padding(2);
            guna2Panel6.Name = "guna2Panel6";
            guna2Panel6.Size = new Size(100, 40);
            guna2Panel6.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(10, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 40);
            label2.TabIndex = 53;
            label2.Text = "Preview";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Location = new Point(20, 20);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 310);
            panel1.TabIndex = 61;
            // 
            // pnlLoadButton
            // 
            pnlLoadButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlLoadButton.BackColor = Color.White;
            pnlLoadButton.Controls.Add(guna2ProgressBar1);
            pnlLoadButton.Location = new Point(500, 50);
            pnlLoadButton.Margin = new Padding(4, 4, 4, 4);
            pnlLoadButton.Name = "pnlLoadButton";
            pnlLoadButton.Size = new Size(80, 50);
            pnlLoadButton.TabIndex = 58;
            pnlLoadButton.Visible = false;
            // 
            // guna2ProgressBar1
            // 
            guna2ProgressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2ProgressBar1.BackColor = Color.Transparent;
            guna2ProgressBar1.BorderColor = Color.Gainsboro;
            guna2ProgressBar1.BorderRadius = 2;
            guna2ProgressBar1.BorderThickness = 2;
            guna2ProgressBar1.FillColor = Color.White;
            guna2ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            guna2ProgressBar1.Location = new Point(10, 20);
            guna2ProgressBar1.Margin = new Padding(2);
            guna2ProgressBar1.Name = "guna2ProgressBar1";
            guna2ProgressBar1.ProgressColor = Color.SteelBlue;
            guna2ProgressBar1.ProgressColor2 = Color.RoyalBlue;
            guna2ProgressBar1.ShadowDecoration.Depth = 20;
            guna2ProgressBar1.Size = new Size(60, 8);
            guna2ProgressBar1.Style = ProgressBarStyle.Marquee;
            guna2ProgressBar1.TabIndex = 60;
            guna2ProgressBar1.Text = "guna2ProgressBar1";
            guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button2.Animated = true;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderColor = Color.Gainsboro;
            guna2Button2.BorderRadius = 20;
            guna2Button2.BorderThickness = 2;
            guna2Button2.DisabledState.BorderColor = Color.Gainsboro;
            guna2Button2.DisabledState.FillColor = Color.White;
            guna2Button2.DisabledState.ForeColor = Color.White;
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            guna2Button2.ForeColor = Color.DimGray;
            guna2Button2.Location = new Point(480, 40);
            guna2Button2.Margin = new Padding(2);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(120, 70);
            guna2Button2.TabIndex = 57;
            guna2Button2.Text = "Open";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // lblFileName
            // 
            lblFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFileName.AutoEllipsis = true;
            lblFileName.BackColor = Color.Transparent;
            lblFileName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFileName.ForeColor = SystemColors.WindowFrame;
            lblFileName.Location = new Point(141, 34);
            lblFileName.Margin = new Padding(4, 0, 4, 0);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(272, 40);
            lblFileName.TabIndex = 53;
            lblFileName.Text = "n/a";
            lblFileName.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblDescription.ForeColor = Color.Silver;
            lblDescription.Location = new Point(141, 82);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(302, 32);
            lblDescription.TabIndex = 54;
            lblDescription.Text = "n/a";
            // 
            // pnlIcon
            // 
            pnlIcon.BackColor = Color.White;
            pnlIcon.BackgroundImage = Properties.Resources.Screenshot_2023_10_13_052005;
            pnlIcon.BackgroundImageLayout = ImageLayout.Zoom;
            pnlIcon.BorderColor = Color.Gainsboro;
            pnlIcon.BorderRadius = 20;
            pnlIcon.BorderSize = 0;
            pnlIcon.ForeColor = Color.White;
            pnlIcon.Location = new Point(30, 26);
            pnlIcon.Margin = new Padding(4, 4, 4, 4);
            pnlIcon.Name = "pnlIcon";
            pnlIcon.Size = new Size(96, 88);
            pnlIcon.TabIndex = 52;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.WhiteSmoke;
            guna2Button1.BorderRadius = 15;
            guna2Button1.BorderThickness = 2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.RoyalBlue;
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(410, 909);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(690, 58);
            guna2Button1.TabIndex = 57;
            guna2Button1.Text = "Transfer Files";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // materialCheckbox1
            // 
            materialCheckbox1.AutoSize = true;
            materialCheckbox1.Depth = 0;
            materialCheckbox1.Location = new Point(0, 0);
            materialCheckbox1.Margin = new Padding(0);
            materialCheckbox1.MouseLocation = new Point(-1, -1);
            materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox1.Name = "materialCheckbox1";
            materialCheckbox1.ReadOnly = false;
            materialCheckbox1.Ripple = true;
            materialCheckbox1.Size = new Size(10, 10);
            materialCheckbox1.TabIndex = 0;
            materialCheckbox1.Text = "materialCheckbox1";
            materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            materialCheckbox2.AutoSize = true;
            materialCheckbox2.Depth = 0;
            materialCheckbox2.Location = new Point(0, 0);
            materialCheckbox2.Margin = new Padding(0);
            materialCheckbox2.MouseLocation = new Point(-1, -1);
            materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox2.Name = "materialCheckbox2";
            materialCheckbox2.ReadOnly = false;
            materialCheckbox2.Ripple = true;
            materialCheckbox2.Size = new Size(10, 10);
            materialCheckbox2.TabIndex = 0;
            materialCheckbox2.Text = "materialCheckbox2";
            materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox3
            // 
            materialCheckbox3.AutoSize = true;
            materialCheckbox3.Depth = 0;
            materialCheckbox3.Location = new Point(0, 0);
            materialCheckbox3.Margin = new Padding(0);
            materialCheckbox3.MouseLocation = new Point(-1, -1);
            materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox3.Name = "materialCheckbox3";
            materialCheckbox3.ReadOnly = false;
            materialCheckbox3.Ripple = true;
            materialCheckbox3.Size = new Size(10, 10);
            materialCheckbox3.TabIndex = 0;
            materialCheckbox3.Text = "materialCheckbox3";
            materialCheckbox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox4
            // 
            materialCheckbox4.AutoSize = true;
            materialCheckbox4.Depth = 0;
            materialCheckbox4.Location = new Point(0, 0);
            materialCheckbox4.Margin = new Padding(0);
            materialCheckbox4.MouseLocation = new Point(-1, -1);
            materialCheckbox4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox4.Name = "materialCheckbox4";
            materialCheckbox4.ReadOnly = false;
            materialCheckbox4.Ripple = true;
            materialCheckbox4.Size = new Size(10, 10);
            materialCheckbox4.TabIndex = 0;
            materialCheckbox4.Text = "materialCheckbox4";
            materialCheckbox4.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox5
            // 
            materialCheckbox5.AutoSize = true;
            materialCheckbox5.Depth = 0;
            materialCheckbox5.Location = new Point(0, 0);
            materialCheckbox5.Margin = new Padding(0);
            materialCheckbox5.MouseLocation = new Point(-1, -1);
            materialCheckbox5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox5.Name = "materialCheckbox5";
            materialCheckbox5.ReadOnly = false;
            materialCheckbox5.Ripple = true;
            materialCheckbox5.Size = new Size(10, 10);
            materialCheckbox5.TabIndex = 0;
            materialCheckbox5.Text = "materialCheckbox5";
            materialCheckbox5.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox6
            // 
            materialCheckbox6.AutoSize = true;
            materialCheckbox6.Depth = 0;
            materialCheckbox6.Location = new Point(0, 0);
            materialCheckbox6.Margin = new Padding(0);
            materialCheckbox6.MouseLocation = new Point(-1, -1);
            materialCheckbox6.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox6.Name = "materialCheckbox6";
            materialCheckbox6.ReadOnly = false;
            materialCheckbox6.Ripple = true;
            materialCheckbox6.Size = new Size(10, 10);
            materialCheckbox6.TabIndex = 0;
            materialCheckbox6.Text = "materialCheckbox6";
            materialCheckbox6.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox7
            // 
            materialCheckbox7.AutoSize = true;
            materialCheckbox7.Depth = 0;
            materialCheckbox7.Location = new Point(0, 0);
            materialCheckbox7.Margin = new Padding(0);
            materialCheckbox7.MouseLocation = new Point(-1, -1);
            materialCheckbox7.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox7.Name = "materialCheckbox7";
            materialCheckbox7.ReadOnly = false;
            materialCheckbox7.Ripple = true;
            materialCheckbox7.Size = new Size(10, 10);
            materialCheckbox7.TabIndex = 0;
            materialCheckbox7.Text = "materialCheckbox7";
            materialCheckbox7.UseVisualStyleBackColor = true;
            // 
            // lblEntry
            // 
            lblEntry.AutoSize = true;
            lblEntry.BackColor = Color.Transparent;
            lblEntry.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEntry.ForeColor = Color.DimGray;
            lblEntry.Location = new Point(310, 140);
            lblEntry.Margin = new Padding(4, 0, 4, 0);
            lblEntry.Name = "lblEntry";
            lblEntry.Size = new Size(0, 28);
            lblEntry.TabIndex = 15;
            lblEntry.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiImportSharedFiles
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1126, 992);
            Controls.Add(guna2Button1);
            Controls.Add(lblEntry);
            Controls.Add(label1);
            Controls.Add(guna2Panel3);
            Controls.Add(guna2Panel2);
            Controls.Add(sPanel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "uiImportSharedFiles";
            ShowIcon = false;
            Text = "LILO Cloud";
            Load += uiImportSharedFiles_Load;
            sPanel1.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            guna2Panel3.ResumeLayout(false);
            pnlFile.ResumeLayout(false);
            pnlPreview.ResumeLayout(false);
            guna2Panel6.ResumeLayout(false);
            pnlLoadButton.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sipaa.Framework.SPanel sPanel1;
        private Label lblText;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblArchieveName;
        private Guna.UI2.WinForms.Guna2Button bntPlugin;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Panel pnlPlugins;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel pnlFile;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Label lblFileName;
        private Label lblDescription;
        private Sipaa.Framework.SPanel pnlIcon;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel pnlPreview;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Label label2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox4;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox5;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox6;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox7;
        private Guna.UI2.WinForms.Guna2ProgressBar prgMiniProgress;
        private Panel panel1;
        private Panel pnlLoadButton;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private Label lblEntry;
    }
}