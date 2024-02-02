namespace LILO_Packager.v2.Forms
{
    partial class uiArgumentStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiArgumentStart));
            bntCrypter = new Guna.UI2.WinForms.Guna2Button();
            pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
            imgImage = new Guna.UI2.WinForms.Guna2Panel();
            lblName = new Label();
            bntDecrypt = new Guna.UI2.WinForms.Guna2Button();
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
            resources.ApplyResources(bntCrypter, "bntCrypter");
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
            bntCrypter.ForeColor = Color.Black;
            bntCrypter.Name = "bntCrypter";
            bntCrypter.Click += guna2Button1_Click;
            // 
            // pnlPreview
            // 
            resources.ApplyResources(pnlPreview, "pnlPreview");
            pnlPreview.BorderColor = Color.Gainsboro;
            pnlPreview.BorderRadius = 15;
            pnlPreview.BorderThickness = 2;
            pnlPreview.Controls.Add(imgImage);
            pnlPreview.FillColor = Color.WhiteSmoke;
            pnlPreview.Name = "pnlPreview";
            // 
            // imgImage
            // 
            resources.ApplyResources(imgImage, "imgImage");
            imgImage.BackColor = Color.Transparent;
            imgImage.BackgroundImage = Properties.Resources.Lock;
            imgImage.BorderColor = SystemColors.ActiveBorder;
            imgImage.BorderRadius = 15;
            imgImage.FillColor = Color.Transparent;
            imgImage.Name = "imgImage";
            // 
            // lblName
            // 
            lblName.AutoEllipsis = true;
            lblName.BackColor = Color.Transparent;
            resources.ApplyResources(lblName, "lblName");
            lblName.ForeColor = Color.Black;
            lblName.Name = "lblName";
            // 
            // bntDecrypt
            // 
            resources.ApplyResources(bntDecrypt, "bntDecrypt");
            bntDecrypt.Animated = true;
            bntDecrypt.BackColor = Color.Transparent;
            bntDecrypt.BorderColor = Color.Gainsboro;
            bntDecrypt.BorderRadius = 20;
            bntDecrypt.BorderThickness = 2;
            bntDecrypt.DisabledState.BorderColor = Color.DarkGray;
            bntDecrypt.DisabledState.CustomBorderColor = Color.DarkGray;
            bntDecrypt.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntDecrypt.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntDecrypt.FocusedColor = Color.FromArgb(100, 170, 209);
            bntDecrypt.ForeColor = Color.White;
            bntDecrypt.Name = "bntDecrypt";
            bntDecrypt.Click += bntDecrypt_Click;
            // 
            // lblSize
            // 
            lblSize.BackColor = Color.Transparent;
            resources.ApplyResources(lblSize, "lblSize");
            lblSize.ForeColor = Color.Black;
            lblSize.Name = "lblSize";
            // 
            // lblEncryption
            // 
            lblEncryption.BackColor = Color.Transparent;
            resources.ApplyResources(lblEncryption, "lblEncryption");
            lblEncryption.ForeColor = Color.Black;
            lblEncryption.Name = "lblEncryption";
            // 
            // guna2Panel1
            // 
            resources.ApplyResources(guna2Panel1, "guna2Panel1");
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(lblSize);
            guna2Panel1.Controls.Add(lblEncryption);
            guna2Panel1.FillColor = Color.Transparent;
            guna2Panel1.Name = "guna2Panel1";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.Gray;
            label2.Name = "label2";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Gray;
            label1.Name = "label1";
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
            // taskBarProgress
            // 
            taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.NoProgress;
            taskBarProgress.TargetForm = null;
            // 
            // pswDialog
            // 
            resources.ApplyResources(pswDialog, "pswDialog");
            // 
            // uiArgumentStart
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(progress1);
            Controls.Add(bntCrypter);
            Controls.Add(bntDecrypt);
            Controls.Add(lblName);
            Controls.Add(guna2Panel1);
            Controls.Add(pnlPreview);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "uiArgumentStart";
            Load += uiArgumentStart_Load;
            pnlPreview.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button bntCrypter;
        private Guna.UI2.WinForms.Guna2Panel pnlPreview;
        private Label lblName;
        private Guna.UI2.WinForms.Guna2Button bntDecrypt;
        private Label lblSize;
        private Label lblEncryption;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel imgImage;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ProgressBar progress1;
        private Guna.UI2.WinForms.Guna2TaskBarProgress taskBarProgress;
        private Ookii.Dialogs.WinForms.InputDialog pswDialog;
    }
}