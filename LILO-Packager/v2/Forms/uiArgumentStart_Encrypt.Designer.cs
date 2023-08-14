namespace LILO_Packager.v2.Forms
{
    partial class uiArgumentStart_Encrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiArgumentStart_Encrypt));
            bntCrypter = new Guna.UI2.WinForms.Guna2Button();
            pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
            imgImage = new Guna.UI2.WinForms.Guna2Panel();
            bntEncrypt = new Guna.UI2.WinForms.Guna2Button();
            lblName = new Label();
            lblSize = new Label();
            lblEncryption = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            label1 = new Label();
            progress1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            taskBarProgress = new Guna.UI2.WinForms.Guna2TaskBarProgress(components);
            pswDialog = new Ookii.Dialogs.WinForms.InputDialog(components);
            pnlPreview.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bntCrypter
            // 
            bntCrypter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bntCrypter.Animated = true;
            bntCrypter.BackColor = Color.Transparent;
            bntCrypter.BorderColor = Color.Gainsboro;
            bntCrypter.BorderRadius = 15;
            bntCrypter.BorderThickness = 2;
            bntCrypter.DisabledState.BorderColor = Color.DarkGray;
            bntCrypter.DisabledState.CustomBorderColor = Color.DarkGray;
            bntCrypter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntCrypter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntCrypter.FillColor = Color.Transparent;
            bntCrypter.FocusedColor = Color.FromArgb(100, 170, 209);
            bntCrypter.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            bntCrypter.ForeColor = Color.Black;
            bntCrypter.Location = new Point(624, 365);
            bntCrypter.Margin = new Padding(2);
            bntCrypter.Name = "bntCrypter";
            bntCrypter.Size = new Size(232, 58);
            bntCrypter.TabIndex = 18;
            bntCrypter.Text = "Crypter";
            // 
            // pnlPreview
            // 
            pnlPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlPreview.BorderColor = SystemColors.ActiveBorder;
            pnlPreview.BorderRadius = 15;
            pnlPreview.BorderThickness = 2;
            pnlPreview.Controls.Add(imgImage);
            pnlPreview.FillColor = Color.Gainsboro;
            pnlPreview.Location = new Point(32, 29);
            pnlPreview.Margin = new Padding(2);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Size = new Size(336, 304);
            pnlPreview.TabIndex = 21;
            // 
            // imgImage
            // 
            imgImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            imgImage.BackColor = Color.Transparent;
            imgImage.BackgroundImage = Properties.Resources.Lock;
            imgImage.BackgroundImageLayout = ImageLayout.Center;
            imgImage.BorderColor = SystemColors.ActiveBorder;
            imgImage.BorderRadius = 15;
            imgImage.FillColor = Color.Transparent;
            imgImage.Location = new Point(24, 24);
            imgImage.Margin = new Padding(2);
            imgImage.Name = "imgImage";
            imgImage.Size = new Size(288, 256);
            imgImage.TabIndex = 11;
            // 
            // bntEncrypt
            // 
            bntEncrypt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bntEncrypt.Animated = true;
            bntEncrypt.BackColor = Color.Transparent;
            bntEncrypt.BorderColor = Color.Gainsboro;
            bntEncrypt.BorderRadius = 20;
            bntEncrypt.BorderThickness = 2;
            bntEncrypt.DisabledState.BorderColor = Color.DarkGray;
            bntEncrypt.DisabledState.CustomBorderColor = Color.DarkGray;
            bntEncrypt.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntEncrypt.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntEncrypt.FocusedColor = Color.FromArgb(100, 170, 209);
            bntEncrypt.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            bntEncrypt.ForeColor = Color.White;
            bntEncrypt.Location = new Point(24, 365);
            bntEncrypt.Margin = new Padding(2);
            bntEncrypt.Name = "bntEncrypt";
            bntEncrypt.Size = new Size(592, 58);
            bntEncrypt.TabIndex = 19;
            bntEncrypt.Text = "Encrypt";
            // 
            // lblName
            // 
            lblName.AutoEllipsis = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(424, 93);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(376, 56);
            lblName.TabIndex = 20;
            lblName.Text = "File";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSize
            // 
            lblSize.BackColor = Color.Transparent;
            lblSize.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSize.ForeColor = Color.Black;
            lblSize.Location = new Point(216, 8);
            lblSize.Margin = new Padding(4, 0, 4, 0);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(376, 56);
            lblSize.TabIndex = 1;
            lblSize.Text = "Size";
            lblSize.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEncryption
            // 
            lblEncryption.BackColor = Color.Transparent;
            lblEncryption.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncryption.ForeColor = Color.Black;
            lblEncryption.Location = new Point(216, 56);
            lblEncryption.Margin = new Padding(4, 0, 4, 0);
            lblEncryption.Name = "lblEncryption";
            lblEncryption.Size = new Size(376, 56);
            lblEncryption.TabIndex = 1;
            lblEncryption.Text = "Enryption Method";
            lblEncryption.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            guna2Panel1.BorderColor = SystemColors.ActiveBorder;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(lblSize);
            guna2Panel1.Controls.Add(lblEncryption);
            guna2Panel1.FillColor = Color.Transparent;
            guna2Panel1.Location = new Point(416, 165);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(440, 122);
            guna2Panel1.TabIndex = 22;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(16, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 56);
            label2.TabIndex = 1;
            label2.Text = "Size";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(16, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 56);
            label1.TabIndex = 1;
            label1.Text = "Enryption Method";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // progress1
            // 
            progress1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progress1.BackColor = Color.Transparent;
            progress1.BorderColor = Color.Gainsboro;
            progress1.BorderRadius = 20;
            progress1.BorderThickness = 2;
            progress1.FillColor = Color.Transparent;
            progress1.Location = new Point(24, 365);
            progress1.Name = "progress1";
            progress1.ProgressColor = Color.DeepSkyBlue;
            progress1.ProgressColor2 = Color.Navy;
            progress1.ShowText = true;
            progress1.Size = new Size(592, 56);
            progress1.TabIndex = 23;
            progress1.Text = "guna2ProgressBar1";
            progress1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            progress1.Visible = false;
            // 
            // taskBarProgress
            // 
            taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.NoProgress;
            taskBarProgress.TargetForm = null;
            // 
            // pswDialog
            // 
            pswDialog.Content = "Put in an Decrypten Key";
            pswDialog.MainInstruction = "Decrypten Key";
            pswDialog.WindowTitle = "MainHost";
            // 
            // uiArgumentStart_Encrypt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(888, 452);
            Controls.Add(bntCrypter);
            Controls.Add(pnlPreview);
            Controls.Add(bntEncrypt);
            Controls.Add(lblName);
            Controls.Add(guna2Panel1);
            Controls.Add(progress1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(910, 508);
            MinimizeBox = false;
            MinimumSize = new Size(910, 508);
            Name = "uiArgumentStart_Encrypt";
            Text = "Encrypt";
            Load += uiArgumentStart_Encrypt_Load;
            pnlPreview.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button bntCrypter;
        private Guna.UI2.WinForms.Guna2Panel pnlPreview;
        private Guna.UI2.WinForms.Guna2Panel imgImage;
        private Guna.UI2.WinForms.Guna2Button bntEncrypt;
        private Label lblName;
        private Label lblSize;
        private Label lblEncryption;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ProgressBar progress1;
        private Guna.UI2.WinForms.Guna2TaskBarProgress taskBarProgress;
        private Ookii.Dialogs.WinForms.InputDialog pswDialog;
    }
}