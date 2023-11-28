namespace LILO_Packager.v2.Controls
{
    partial class DynamicCloudFileListItem
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DynamicCloudFileListItem));
            pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
            pnlDownload = new Guna.UI2.WinForms.Guna2Panel();
            prgMiniProgress = new Guna.UI2.WinForms.Guna2ProgressBar();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblFileSize = new Label();
            lblFileName = new Label();
            lblDetails = new Label();
            imgImage = new Guna.UI2.WinForms.Guna2Panel();
            pnlImage = new Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            bntDownloadButton = new Guna.UI2.WinForms.Guna2Button();
            Transition = new Guna.UI2.WinForms.Guna2Transition();
            pnlPreview.SuspendLayout();
            pnlDownload.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            imgImage.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPreview
            // 
            pnlPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPreview.BackColor = Color.Transparent;
            pnlPreview.BorderColor = Color.Gainsboro;
            pnlPreview.BorderRadius = 20;
            pnlPreview.BorderThickness = 2;
            pnlPreview.Controls.Add(pnlDownload);
            pnlPreview.Controls.Add(tableLayoutPanel2);
            pnlPreview.Controls.Add(imgImage);
            pnlPreview.Controls.Add(guna2Button1);
            pnlPreview.Controls.Add(bntDownloadButton);
            Transition.SetDecoration(pnlPreview, Guna.UI2.AnimatorNS.DecorationType.None);
            pnlPreview.FillColor = Color.WhiteSmoke;
            pnlPreview.Location = new Point(0, 0);
            pnlPreview.Margin = new Padding(2);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Size = new Size(888, 152);
            pnlPreview.TabIndex = 28;
            // 
            // pnlDownload
            // 
            pnlDownload.Anchor = AnchorStyles.Right;
            pnlDownload.BackColor = Color.Transparent;
            pnlDownload.BorderColor = Color.Gainsboro;
            pnlDownload.BorderRadius = 15;
            pnlDownload.BorderThickness = 2;
            pnlDownload.Controls.Add(prgMiniProgress);
            Transition.SetDecoration(pnlDownload, Guna.UI2.AnimatorNS.DecorationType.None);
            pnlDownload.FillColor = Color.White;
            pnlDownload.Location = new Point(664, 40);
            pnlDownload.Margin = new Padding(2);
            pnlDownload.Name = "pnlDownload";
            pnlDownload.Size = new Size(192, 72);
            pnlDownload.TabIndex = 47;
            // 
            // prgMiniProgress
            // 
            prgMiniProgress.Anchor = AnchorStyles.None;
            prgMiniProgress.BackColor = Color.Transparent;
            prgMiniProgress.BorderColor = Color.Gainsboro;
            prgMiniProgress.BorderRadius = 15;
            prgMiniProgress.BorderThickness = 2;
            Transition.SetDecoration(prgMiniProgress, Guna.UI2.AnimatorNS.DecorationType.None);
            prgMiniProgress.FillColor = Color.White;
            prgMiniProgress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            prgMiniProgress.Location = new Point(16, 16);
            prgMiniProgress.Margin = new Padding(2);
            prgMiniProgress.Name = "prgMiniProgress";
            prgMiniProgress.ProgressColor = Color.SteelBlue;
            prgMiniProgress.ProgressColor2 = Color.RoyalBlue;
            prgMiniProgress.ShadowDecoration.Depth = 20;
            prgMiniProgress.Size = new Size(160, 40);
            prgMiniProgress.TabIndex = 46;
            prgMiniProgress.Text = "guna2ProgressBar1";
            prgMiniProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            prgMiniProgress.Value = 70;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(lblDetails, 0, 1);
            Transition.SetDecoration(tableLayoutPanel2, Guna.UI2.AnimatorNS.DecorationType.None);
            tableLayoutPanel2.Location = new Point(152, 40);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 46.5909081F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 53.4090919F));
            tableLayoutPanel2.Size = new Size(512, 96);
            tableLayoutPanel2.TabIndex = 30;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(lblFileSize, 1, 0);
            tableLayoutPanel1.Controls.Add(lblFileName, 0, 0);
            Transition.SetDecoration(tableLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(506, 38);
            tableLayoutPanel1.TabIndex = 34;
            // 
            // lblFileSize
            // 
            lblFileSize.BackColor = Color.Transparent;
            Transition.SetDecoration(lblFileSize, Guna.UI2.AnimatorNS.DecorationType.None);
            lblFileSize.Dock = DockStyle.Fill;
            lblFileSize.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblFileSize.Location = new Point(194, 0);
            lblFileSize.Margin = new Padding(2, 0, 2, 0);
            lblFileSize.Name = "lblFileSize";
            lblFileSize.Size = new Size(382, 38);
            lblFileSize.TabIndex = 11;
            lblFileSize.Text = "Version";
            lblFileSize.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.BackColor = Color.Transparent;
            Transition.SetDecoration(lblFileName, Guna.UI2.AnimatorNS.DecorationType.None);
            lblFileName.Dock = DockStyle.Fill;
            lblFileName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblFileName.ForeColor = Color.Black;
            lblFileName.Location = new Point(2, 0);
            lblFileName.Margin = new Padding(2, 0, 2, 0);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(188, 38);
            lblFileName.TabIndex = 11;
            lblFileName.Text = "PackageName";
            lblFileName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetails
            // 
            lblDetails.BackColor = Color.Transparent;
            Transition.SetDecoration(lblDetails, Guna.UI2.AnimatorNS.DecorationType.None);
            lblDetails.Dock = DockStyle.Fill;
            lblDetails.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDetails.ForeColor = Color.Gray;
            lblDetails.Location = new Point(4, 44);
            lblDetails.Margin = new Padding(4, 0, 4, 0);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(504, 52);
            lblDetails.TabIndex = 1;
            lblDetails.Text = "Plugininformation";
            // 
            // imgImage
            // 
            imgImage.Anchor = AnchorStyles.Left;
            imgImage.BackColor = Color.Transparent;
            imgImage.BackgroundImageLayout = ImageLayout.Zoom;
            imgImage.BorderColor = Color.Gainsboro;
            imgImage.BorderRadius = 20;
            imgImage.BorderThickness = 2;
            imgImage.Controls.Add(pnlImage);
            Transition.SetDecoration(imgImage, Guna.UI2.AnimatorNS.DecorationType.None);
            imgImage.FillColor = Color.White;
            imgImage.Location = new Point(24, 24);
            imgImage.Margin = new Padding(2);
            imgImage.Name = "imgImage";
            imgImage.Size = new Size(104, 104);
            imgImage.TabIndex = 11;
            // 
            // pnlImage
            // 
            Transition.SetDecoration(pnlImage, Guna.UI2.AnimatorNS.DecorationType.None);
            pnlImage.Location = new Point(0, 0);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(104, 104);
            pnlImage.TabIndex = 0;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Right;
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.Gainsboro;
            guna2Button1.BorderRadius = 15;
            guna2Button1.BorderThickness = 2;
            Transition.SetDecoration(guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.DimGray;
            guna2Button1.Image = Properties.Resources.icons8_synchronize_240;
            guna2Button1.ImageSize = new Size(30, 30);
            guna2Button1.Location = new Point(712, 48);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(64, 56);
            guna2Button1.TabIndex = 29;
            // 
            // bntDownloadButton
            // 
            bntDownloadButton.Anchor = AnchorStyles.Right;
            bntDownloadButton.Animated = true;
            bntDownloadButton.BackColor = Color.Transparent;
            bntDownloadButton.BorderColor = Color.Gainsboro;
            bntDownloadButton.BorderRadius = 15;
            bntDownloadButton.BorderThickness = 2;
            Transition.SetDecoration(bntDownloadButton, Guna.UI2.AnimatorNS.DecorationType.None);
            bntDownloadButton.DisabledState.BorderColor = Color.DarkGray;
            bntDownloadButton.DisabledState.CustomBorderColor = Color.DarkGray;
            bntDownloadButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntDownloadButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntDownloadButton.FillColor = Color.White;
            bntDownloadButton.FocusedColor = Color.FromArgb(100, 170, 209);
            bntDownloadButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bntDownloadButton.ForeColor = Color.DimGray;
            bntDownloadButton.Image = Properties.Resources.pull_32;
            bntDownloadButton.ImageSize = new Size(30, 30);
            bntDownloadButton.Location = new Point(792, 48);
            bntDownloadButton.Margin = new Padding(2);
            bntDownloadButton.Name = "bntDownloadButton";
            bntDownloadButton.Size = new Size(64, 56);
            bntDownloadButton.TabIndex = 29;
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
            // DynamicCloudFileListItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlPreview);
            Transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            Name = "DynamicCloudFileListItem";
            Size = new Size(889, 152);
            pnlPreview.ResumeLayout(false);
            pnlDownload.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            imgImage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlPreview;
        private Guna.UI2.WinForms.Guna2Panel imgImage;
        private Guna.UI2.WinForms.Guna2Button bntDownloadButton;
        public TableLayoutPanel tableLayoutPanel2;
        public TableLayoutPanel tableLayoutPanel1;
        public Label lblFileSize;
        public Label lblFileName;
        public Label lblDetails;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Panel pnlImage;
        public Guna.UI2.WinForms.Guna2Transition Transition;
        private Guna.UI2.WinForms.Guna2Panel pnlDownload;
        private Guna.UI2.WinForms.Guna2ProgressBar prgMiniProgress;
    }
}
