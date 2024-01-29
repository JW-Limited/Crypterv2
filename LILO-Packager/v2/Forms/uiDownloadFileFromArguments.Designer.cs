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
            lblFileName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFileName.ForeColor = SystemColors.WindowFrame;
            lblFileName.Location = new Point(32, 32);
            lblFileName.Margin = new Padding(4, 0, 4, 0);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(480, 40);
            lblFileName.TabIndex = 57;
            lblFileName.Text = "LILO Sync";
            lblFileName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlImage
            // 
            pnlImage.BackColor = Color.White;
            pnlImage.BackgroundImage = Properties.Resources.Screenshot_2023_10_13_052005;
            pnlImage.BackgroundImageLayout = ImageLayout.Zoom;
            pnlImage.BorderColor = Color.Gainsboro;
            pnlImage.BorderRadius = 20;
            pnlImage.BorderSize = 0;
            pnlImage.Controls.Add(pnlSuccess);
            pnlImage.ForeColor = Color.White;
            pnlImage.Location = new Point(616, 32);
            pnlImage.Margin = new Padding(4);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(152, 144);
            pnlImage.TabIndex = 56;
            // 
            // pnlSuccess
            // 
            pnlSuccess.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlSuccess.BackColor = Color.Transparent;
            pnlSuccess.BackgroundImage = Properties.Resources.icons8_checkmark_96;
            pnlSuccess.BackgroundImageLayout = ImageLayout.Zoom;
            pnlSuccess.BorderColor = Color.Transparent;
            pnlSuccess.BorderRadius = 0;
            pnlSuccess.BorderSize = 0;
            pnlSuccess.ForeColor = Color.White;
            pnlSuccess.Location = new Point(80, 16);
            pnlSuccess.Margin = new Padding(4);
            pnlSuccess.Name = "pnlSuccess";
            pnlSuccess.Size = new Size(56, 56);
            pnlSuccess.TabIndex = 56;
            pnlSuccess.Visible = false;
            // 
            // bntCopy
            // 
            bntCopy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            bntCopy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bntCopy.ForeColor = Color.DimGray;
            bntCopy.ImageSize = new Size(24, 24);
            bntCopy.Location = new Point(616, 368);
            bntCopy.Margin = new Padding(2);
            bntCopy.Name = "bntCopy";
            bntCopy.ShadowDecoration.BorderRadius = 15;
            bntCopy.ShadowDecoration.Color = Color.LightGray;
            bntCopy.ShadowDecoration.Depth = 40;
            bntCopy.ShadowDecoration.Enabled = true;
            bntCopy.Size = new Size(152, 48);
            bntCopy.TabIndex = 36;
            bntCopy.Text = "Download";
            bntCopy.Click += bntCopy_Click;
            // 
            // pnlProgess
            // 
            pnlProgess.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlProgess.BackColor = Color.Transparent;
            pnlProgess.BorderColor = Color.Gainsboro;
            pnlProgess.BorderRadius = 15;
            pnlProgess.Controls.Add(lblPrgDesc);
            pnlProgess.Controls.Add(progress);
            pnlProgess.FillColor = Color.White;
            pnlProgess.Location = new Point(0, 224);
            pnlProgess.Margin = new Padding(2);
            pnlProgess.Name = "pnlProgess";
            pnlProgess.Size = new Size(800, 200);
            pnlProgess.TabIndex = 59;
            pnlProgess.Visible = false;
            // 
            // lblPrgDesc
            // 
            lblPrgDesc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPrgDesc.BackColor = Color.Transparent;
            lblPrgDesc.Font = new Font("Segoe UI", 9F);
            lblPrgDesc.ForeColor = Color.Black;
            lblPrgDesc.Location = new Point(32, 96);
            lblPrgDesc.Margin = new Padding(4, 0, 4, 0);
            lblPrgDesc.Name = "lblPrgDesc";
            lblPrgDesc.Size = new Size(672, 32);
            lblPrgDesc.TabIndex = 31;
            lblPrgDesc.Text = "Description";
            lblPrgDesc.TextAlign = ContentAlignment.MiddleLeft;
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
            progress.Location = new Point(32, 136);
            progress.Margin = new Padding(2);
            progress.Name = "progress";
            progress.ProgressColor = Color.DeepSkyBlue;
            progress.ProgressColor2 = Color.RoyalBlue;
            progress.Size = new Size(736, 38);
            progress.TabIndex = 30;
            progress.Text = "guna2ProgressBar1";
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
            pnlInfos.Location = new Point(32, 144);
            pnlInfos.Margin = new Padding(2);
            pnlInfos.Name = "pnlInfos";
            pnlInfos.Size = new Size(480, 128);
            pnlInfos.TabIndex = 60;
            // 
            // lblDateUploaded
            // 
            lblDateUploaded.BackColor = Color.Transparent;
            lblDateUploaded.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDateUploaded.ForeColor = Color.DimGray;
            lblDateUploaded.Location = new Point(256, 80);
            lblDateUploaded.Margin = new Padding(4, 0, 4, 0);
            lblDateUploaded.Name = "lblDateUploaded";
            lblDateUploaded.Size = new Size(160, 30);
            lblDateUploaded.TabIndex = 44;
            lblDateUploaded.Text = "n/a";
            lblDateUploaded.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSize
            // 
            lblSize.BackColor = Color.Transparent;
            lblSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSize.ForeColor = Color.DimGray;
            lblSize.Location = new Point(256, 24);
            lblSize.Margin = new Padding(4, 0, 4, 0);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(160, 30);
            lblSize.TabIndex = 44;
            lblSize.Text = "n/a";
            lblSize.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(16, 56);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 16);
            panel2.TabIndex = 36;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(32, 80);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(168, 30);
            label10.TabIndex = 44;
            label10.Text = "Date Uploaded";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(32, 24);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(136, 30);
            label6.TabIndex = 44;
            label6.Text = "Size";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlLoading
            // 
            pnlLoading.BackColor = Color.White;
            pnlLoading.BackgroundImageLayout = ImageLayout.Center;
            pnlLoading.BorderColor = Color.Gainsboro;
            pnlLoading.BorderRadius = 0;
            pnlLoading.BorderSize = 0;
            pnlLoading.Controls.Add(sPanel1);
            pnlLoading.ForeColor = Color.White;
            pnlLoading.Location = new Point(0, 0);
            pnlLoading.Margin = new Padding(4);
            pnlLoading.Name = "pnlLoading";
            pnlLoading.Size = new Size(800, 456);
            pnlLoading.TabIndex = 61;
            // 
            // sPanel1
            // 
            sPanel1.BackColor = Color.White;
            sPanel1.BackgroundImage = Properties.Resources.Screenshot_2023_10_13_052005;
            sPanel1.BackgroundImageLayout = ImageLayout.Zoom;
            sPanel1.BorderColor = Color.Gainsboro;
            sPanel1.BorderRadius = 30;
            sPanel1.BorderSize = 0;
            sPanel1.ForeColor = Color.White;
            sPanel1.Location = new Point(328, 152);
            sPanel1.Margin = new Padding(4);
            sPanel1.Name = "sPanel1";
            sPanel1.Size = new Size(152, 136);
            sPanel1.TabIndex = 56;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.White;
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.ForeColor = Color.Silver;
            lblDescription.Location = new Point(16, 0);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(456, 32);
            lblDescription.TabIndex = 11;
            lblDescription.Text = "PackageInformations";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(40, 80);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 32);
            panel1.TabIndex = 62;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(8, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(16, 64);
            panel3.TabIndex = 35;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.DimGray;
            guna2Button1.Image = Properties.Resources.icons8_share_240;
            guna2Button1.ImageSize = new Size(24, 24);
            guna2Button1.Location = new Point(544, 368);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.BorderRadius = 15;
            guna2Button1.ShadowDecoration.Color = Color.LightGray;
            guna2Button1.ShadowDecoration.Depth = 40;
            guna2Button1.ShadowDecoration.Enabled = true;
            guna2Button1.Size = new Size(56, 48);
            guna2Button1.TabIndex = 36;
            guna2Button1.Click += bntShare_Click;
            // 
            // uiDownloadFileFromArguments
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Fetching";
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