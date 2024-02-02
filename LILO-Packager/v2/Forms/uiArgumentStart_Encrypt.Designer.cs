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
            pnlSuccess = new Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            label3 = new Label();
            pnlPreview.SuspendLayout();
            guna2Panel1.SuspendLayout();
            pnlSuccess.SuspendLayout();
            guna2Panel2.SuspendLayout();
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
            bntCrypter.Click += bntCrypter_Click;
            // 
            // pnlPreview
            // 
            resources.ApplyResources(pnlPreview, "pnlPreview");
            pnlPreview.BorderColor = SystemColors.ActiveBorder;
            pnlPreview.BorderRadius = 15;
            pnlPreview.BorderThickness = 2;
            pnlPreview.Controls.Add(imgImage);
            pnlPreview.FillColor = Color.Gainsboro;
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
            // bntEncrypt
            // 
            resources.ApplyResources(bntEncrypt, "bntEncrypt");
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
            bntEncrypt.ForeColor = Color.White;
            bntEncrypt.Name = "bntEncrypt";
            bntEncrypt.Click += bntEncrypt_Click;
            // 
            // lblName
            // 
            lblName.AutoEllipsis = true;
            lblName.BackColor = Color.Transparent;
            resources.ApplyResources(lblName, "lblName");
            lblName.ForeColor = Color.Black;
            lblName.Name = "lblName";
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
            guna2Panel1.BorderColor = SystemColors.ActiveBorder;
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
            label2.ForeColor = Color.Black;
            label2.Name = "label2";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Black;
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
            progress1.ProgressColor2 = Color.Navy;
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
            // pnlSuccess
            // 
            resources.ApplyResources(pnlSuccess, "pnlSuccess");
            pnlSuccess.Controls.Add(guna2Panel2);
            pnlSuccess.Controls.Add(label3);
            pnlSuccess.Name = "pnlSuccess";
            // 
            // guna2Panel2
            // 
            resources.ApplyResources(guna2Panel2, "guna2Panel2");
            guna2Panel2.BorderColor = Color.Gainsboro;
            guna2Panel2.BorderRadius = 15;
            guna2Panel2.BorderThickness = 2;
            guna2Panel2.Controls.Add(guna2Panel4);
            guna2Panel2.FillColor = Color.White;
            guna2Panel2.Name = "guna2Panel2";
            // 
            // guna2Panel4
            // 
            guna2Panel4.BackColor = Color.Transparent;
            guna2Panel4.BackgroundImage = Properties.Resources.icons8_verified_badge_96;
            resources.ApplyResources(guna2Panel4, "guna2Panel4");
            guna2Panel4.BorderColor = SystemColors.ActiveBorder;
            guna2Panel4.BorderRadius = 15;
            guna2Panel4.FillColor = Color.Transparent;
            guna2Panel4.Name = "guna2Panel4";
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.BackColor = Color.Transparent;
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.Black;
            label3.Name = "label3";
            // 
            // uiArgumentStart_Encrypt
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlSuccess);
            Controls.Add(bntCrypter);
            Controls.Add(pnlPreview);
            Controls.Add(bntEncrypt);
            Controls.Add(lblName);
            Controls.Add(guna2Panel1);
            Controls.Add(progress1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "uiArgumentStart_Encrypt";
            Load += uiArgumentStart_Encrypt_Load;
            pnlPreview.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            pnlSuccess.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
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
        private Panel pnlSuccess;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Label label3;
    }
}