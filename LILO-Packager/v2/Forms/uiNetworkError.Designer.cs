namespace LILO_Packager.v2.Forms
{
    partial class uiNetworkError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiNetworkError));
            pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
            lblExc = new Label();
            imgImage = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            lblMes = new Label();
            bntTrouble = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            pnlPreview.SuspendLayout();
            imgImage.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPreview
            // 
            resources.ApplyResources(pnlPreview, "pnlPreview");
            pnlPreview.BackColor = Color.White;
            pnlPreview.BorderColor = SystemColors.ActiveBorder;
            pnlPreview.BorderRadius = 15;
            pnlPreview.Controls.Add(lblExc);
            pnlPreview.Controls.Add(imgImage);
            pnlPreview.FillColor = Color.White;
            pnlPreview.Name = "pnlPreview";
            // 
            // lblExc
            // 
            resources.ApplyResources(lblExc, "lblExc");
            lblExc.AutoEllipsis = true;
            lblExc.BackColor = Color.Transparent;
            lblExc.ForeColor = Color.Black;
            lblExc.Name = "lblExc";
            // 
            // imgImage
            // 
            resources.ApplyResources(imgImage, "imgImage");
            imgImage.BackColor = Color.Transparent;
            imgImage.BackgroundImage = Properties.Resources.image_removebg_preview__2_;
            imgImage.BorderColor = SystemColors.ActiveBorder;
            imgImage.BorderRadius = 20;
            imgImage.Controls.Add(guna2Panel2);
            imgImage.FillColor = Color.Transparent;
            imgImage.Name = "imgImage";
            // 
            // guna2Panel2
            // 
            resources.ApplyResources(guna2Panel2, "guna2Panel2");
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.BackgroundImage = Properties.Resources.Close;
            guna2Panel2.BorderColor = SystemColors.ActiveBorder;
            guna2Panel2.BorderRadius = 20;
            guna2Panel2.FillColor = Color.Transparent;
            guna2Panel2.Name = "guna2Panel2";
            // 
            // lblMes
            // 
            resources.ApplyResources(lblMes, "lblMes");
            lblMes.AutoEllipsis = true;
            lblMes.BackColor = Color.Transparent;
            lblMes.ForeColor = Color.Black;
            lblMes.Name = "lblMes";
            // 
            // bntTrouble
            // 
            resources.ApplyResources(bntTrouble, "bntTrouble");
            bntTrouble.Animated = true;
            bntTrouble.BackColor = Color.Transparent;
            bntTrouble.BorderColor = Color.Gainsboro;
            bntTrouble.BorderRadius = 15;
            bntTrouble.BorderThickness = 2;
            bntTrouble.DisabledState.BorderColor = Color.DarkGray;
            bntTrouble.DisabledState.CustomBorderColor = Color.DarkGray;
            bntTrouble.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntTrouble.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntTrouble.FillColor = Color.White;
            bntTrouble.FocusedColor = Color.FromArgb(100, 170, 209);
            bntTrouble.ForeColor = Color.DimGray;
            bntTrouble.Image = Properties.Resources.icons8_synchronize_240;
            bntTrouble.ImageSize = new Size(30, 30);
            bntTrouble.Name = "bntTrouble";
            bntTrouble.Click += bntRetry;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Name = "label1";
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
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Click += bntTrouble_Click;
            // 
            // uiNetworkError
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblMes);
            Controls.Add(label1);
            Controls.Add(guna2Button1);
            Controls.Add(bntTrouble);
            Controls.Add(pnlPreview);
            Name = "uiNetworkError";
            Load += uiFeatureNullException_Load;
            pnlPreview.ResumeLayout(false);
            imgImage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlPreview;
        private Guna.UI2.WinForms.Guna2Panel imgImage;
        private Label lblMes;
        private Label lblExc;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button bntTrouble;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}