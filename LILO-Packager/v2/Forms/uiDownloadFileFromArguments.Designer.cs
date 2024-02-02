namespace LILO_Packager.v2.Forms
{
    partial class uiDownloadFileFromArguments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiDownloadFileFromArguments));
            lblFileName = new Label();
            pnlImage = new Sipaa.Framework.SPanel();
            pnlSuccess = new Sipaa.Framework.SPanel();
            bntCopy = new Guna.UI2.WinForms.Guna2Button();
            pnlProgess = new Guna.UI2.WinForms.Guna2Panel();
            lblPrgDesc = new Label();
            progress = new Guna.UI2.WinForms.Guna2ProgressBar();
            pnlInfos = new Guna.UI2.WinForms.Guna2Panel();
            lblDateUploaded = new Label();
            lblSize = new Label();
            panel2 = new Panel();
            label10 = new Label();
            label6 = new Label();
            pnlLoading = new Sipaa.Framework.SPanel();
            sPanel1 = new Sipaa.Framework.SPanel();
            lblDescription = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            pnlImage.SuspendLayout();
            pnlProgess.SuspendLayout();
            pnlInfos.SuspendLayout();
            pnlLoading.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFileName
            // 
            lblFileName.AutoEllipsis = true;
            lblFileName.BackColor = Color.Transparent;
            resources.ApplyResources(lblFileName, "lblFileName");
            lblFileName.ForeColor = SystemColors.WindowFrame;
            lblFileName.Name = "lblFileName";
            // 
            // pnlImage
            // 
            pnlImage.BackColor = Color.White;
            pnlImage.BackgroundImage = Properties.Resources.Screenshot_2023_10_13_052005;
            resources.ApplyResources(pnlImage, "pnlImage");
            pnlImage.BorderColor = Color.Gainsboro;
            pnlImage.BorderRadius = 20;
            pnlImage.BorderSize = 0;
            pnlImage.Controls.Add(pnlSuccess);
            pnlImage.ForeColor = Color.White;
            pnlImage.Name = "pnlImage";
            // 
            // pnlSuccess
            // 
            resources.ApplyResources(pnlSuccess, "pnlSuccess");
            pnlSuccess.BackColor = Color.Transparent;
            pnlSuccess.BackgroundImage = Properties.Resources.icons8_checkmark_96;
            pnlSuccess.BorderColor = Color.Transparent;
            pnlSuccess.BorderRadius = 0;
            pnlSuccess.BorderSize = 0;
            pnlSuccess.ForeColor = Color.White;
            pnlSuccess.Name = "pnlSuccess";
            // 
            // bntCopy
            // 
            resources.ApplyResources(bntCopy, "bntCopy");
            bntCopy.Animated = true;
            bntCopy.BackColor = Color.Transparent;
            bntCopy.BorderColor = Color.Gainsboro;
            bntCopy.BorderRadius = 12;
            bntCopy.BorderThickness = 2;
            bntCopy.DisabledState.BorderColor = Color.DarkGray;
            bntCopy.DisabledState.CustomBorderColor = Color.DarkGray;
            bntCopy.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntCopy.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntCopy.FillColor = Color.White;
            bntCopy.FocusedColor = Color.FromArgb(100, 170, 209);
            bntCopy.ForeColor = Color.DimGray;
            bntCopy.ImageSize = new Size(24, 24);
            bntCopy.Name = "bntCopy";
            bntCopy.ShadowDecoration.BorderRadius = 15;
            bntCopy.ShadowDecoration.Color = Color.LightGray;
            bntCopy.ShadowDecoration.Depth = 40;
            bntCopy.ShadowDecoration.Enabled = true;
            bntCopy.Click += bntCopy_Click;
            // 
            // pnlProgess
            // 
            resources.ApplyResources(pnlProgess, "pnlProgess");
            pnlProgess.BackColor = Color.Transparent;
            pnlProgess.BorderColor = Color.Gainsboro;
            pnlProgess.BorderRadius = 15;
            pnlProgess.Controls.Add(lblPrgDesc);
            pnlProgess.Controls.Add(progress);
            pnlProgess.FillColor = Color.White;
            pnlProgess.Name = "pnlProgess";
            // 
            // lblPrgDesc
            // 
            resources.ApplyResources(lblPrgDesc, "lblPrgDesc");
            lblPrgDesc.BackColor = Color.Transparent;
            lblPrgDesc.ForeColor = Color.Black;
            lblPrgDesc.Name = "lblPrgDesc";
            // 
            // progress
            // 
            resources.ApplyResources(progress, "progress");
            progress.BackColor = Color.Transparent;
            progress.BorderColor = Color.Gainsboro;
            progress.BorderRadius = 10;
            progress.BorderThickness = 2;
            progress.FillColor = Color.White;
            progress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            progress.Name = "progress";
            progress.ProgressColor = Color.DeepSkyBlue;
            progress.ProgressColor2 = Color.RoyalBlue;
            progress.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // pnlInfos
            // 
            pnlInfos.BackColor = SystemColors.HighlightText;
            pnlInfos.BorderColor = Color.Gainsboro;
            pnlInfos.BorderRadius = 15;
            pnlInfos.BorderThickness = 2;
            pnlInfos.Controls.Add(lblDateUploaded);
            pnlInfos.Controls.Add(lblSize);
            pnlInfos.Controls.Add(panel2);
            pnlInfos.Controls.Add(label10);
            pnlInfos.Controls.Add(label6);
            pnlInfos.FillColor = Color.White;
            resources.ApplyResources(pnlInfos, "pnlInfos");
            pnlInfos.Name = "pnlInfos";
            // 
            // lblDateUploaded
            // 
            lblDateUploaded.BackColor = Color.Transparent;
            resources.ApplyResources(lblDateUploaded, "lblDateUploaded");
            lblDateUploaded.ForeColor = Color.DimGray;
            lblDateUploaded.Name = "lblDateUploaded";
            // 
            // lblSize
            // 
            lblSize.BackColor = Color.Transparent;
            resources.ApplyResources(lblSize, "lblSize");
            lblSize.ForeColor = Color.DimGray;
            lblSize.Name = "lblSize";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            resources.ApplyResources(label10, "label10");
            label10.ForeColor = Color.Silver;
            label10.Name = "label10";
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = Color.Silver;
            label6.Name = "label6";
            // 
            // pnlLoading
            // 
            pnlLoading.BackColor = Color.White;
            resources.ApplyResources(pnlLoading, "pnlLoading");
            pnlLoading.BorderColor = Color.Gainsboro;
            pnlLoading.BorderRadius = 0;
            pnlLoading.BorderSize = 0;
            pnlLoading.Controls.Add(sPanel1);
            pnlLoading.ForeColor = Color.White;
            pnlLoading.Name = "pnlLoading";
            // 
            // sPanel1
            // 
            sPanel1.BackColor = Color.White;
            sPanel1.BackgroundImage = Properties.Resources.Screenshot_2023_10_13_052005;
            resources.ApplyResources(sPanel1, "sPanel1");
            sPanel1.BorderColor = Color.Gainsboro;
            sPanel1.BorderRadius = 30;
            sPanel1.BorderSize = 0;
            sPanel1.ForeColor = Color.White;
            sPanel1.Name = "sPanel1";
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.White;
            resources.ApplyResources(lblDescription, "lblDescription");
            lblDescription.ForeColor = Color.Silver;
            lblDescription.Name = "lblDescription";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(panel3);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // guna2Button1
            // 
            resources.ApplyResources(guna2Button1, "guna2Button1");
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.Gainsboro;
            guna2Button1.BorderRadius = 12;
            guna2Button1.BorderThickness = 2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.ForeColor = Color.DimGray;
            guna2Button1.Image = Properties.Resources.icons8_share_240;
            guna2Button1.ImageSize = new Size(24, 24);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.BorderRadius = 15;
            guna2Button1.ShadowDecoration.Color = Color.LightGray;
            guna2Button1.ShadowDecoration.Depth = 40;
            guna2Button1.ShadowDecoration.Enabled = true;
            guna2Button1.Click += bntShare_Click;
            // 
            // uiDownloadFileFromArguments
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlLoading);
            Controls.Add(pnlProgess);
            Controls.Add(guna2Button1);
            Controls.Add(panel1);
            Controls.Add(pnlInfos);
            Controls.Add(bntCopy);
            Controls.Add(lblFileName);
            Controls.Add(pnlImage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "uiDownloadFileFromArguments";
            ShowIcon = false;
            Load += uiDownloadFileFromArguments_Load;
            pnlImage.ResumeLayout(false);
            pnlProgess.ResumeLayout(false);
            pnlInfos.ResumeLayout(false);
            pnlLoading.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblFileName;
        private Sipaa.Framework.SPanel pnlImage;
        private Guna.UI2.WinForms.Guna2Button bntCopy;
        private Guna.UI2.WinForms.Guna2Panel pnlProgess;
        private Label lblPrgDesc;
        private Guna.UI2.WinForms.Guna2ProgressBar progress;
        private Guna.UI2.WinForms.Guna2Panel pnlInfos;
        private Label lblDateUploaded;
        private Label lblSize;
        private Panel panel2;
        private Label label10;
        private Label label6;
        private Sipaa.Framework.SPanel pnlLoading;
        private Sipaa.Framework.SPanel sPanel1;
        private Label lblDescription;
        private Panel panel1;
        private Panel panel3;
        private Sipaa.Framework.SPanel pnlSuccess;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}