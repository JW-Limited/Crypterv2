namespace LILO_Packager.v2.Forms
{
    partial class uiFeatureNullException
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiFeatureNullException));
            pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
            lblName = new Label();
            imgImage = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblMes = new Label();
            lblExc = new Label();
            bntTrouble = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            pnlPreview.SuspendLayout();
            imgImage.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPreview
            // 
            resources.ApplyResources(pnlPreview, "pnlPreview");
            pnlPreview.BackColor = Color.White;
            pnlPreview.BorderColor = SystemColors.ActiveBorder;
            pnlPreview.BorderRadius = 15;
            pnlPreview.Controls.Add(lblName);
            pnlPreview.Controls.Add(imgImage);
            pnlPreview.FillColor = Color.White;
            pnlPreview.Name = "pnlPreview";
            // 
            // lblName
            // 
            resources.ApplyResources(lblName, "lblName");
            lblName.AutoEllipsis = true;
            lblName.BackColor = Color.Transparent;
            lblName.ForeColor = Color.Black;
            lblName.Name = "lblName";
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
            // guna2Panel1
            // 
            resources.ApplyResources(guna2Panel1, "guna2Panel1");
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(lblMes);
            guna2Panel1.Controls.Add(lblExc);
            guna2Panel1.FillColor = Color.WhiteSmoke;
            guna2Panel1.Name = "guna2Panel1";
            // 
            // lblMes
            // 
            lblMes.AutoEllipsis = true;
            lblMes.BackColor = Color.Transparent;
            resources.ApplyResources(lblMes, "lblMes");
            lblMes.ForeColor = Color.Black;
            lblMes.Name = "lblMes";
            // 
            // lblExc
            // 
            lblExc.BackColor = Color.Transparent;
            resources.ApplyResources(lblExc, "lblExc");
            lblExc.ForeColor = Color.Black;
            lblExc.Name = "lblExc";
            // 
            // bntTrouble
            // 
            resources.ApplyResources(bntTrouble, "bntTrouble");
            bntTrouble.Animated = true;
            bntTrouble.BackColor = Color.Transparent;
            bntTrouble.BorderColor = Color.Gainsboro;
            bntTrouble.BorderRadius = 12;
            bntTrouble.BorderThickness = 2;
            bntTrouble.DisabledState.BorderColor = Color.DarkGray;
            bntTrouble.DisabledState.CustomBorderColor = Color.DarkGray;
            bntTrouble.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntTrouble.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntTrouble.FillColor = Color.White;
            bntTrouble.FocusedColor = Color.FromArgb(100, 170, 209);
            bntTrouble.ForeColor = Color.DimGray;
            bntTrouble.Name = "bntTrouble";
            bntTrouble.Click += bntTrouble_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Name = "label1";
            // 
            // uiFeatureNullException
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(bntTrouble);
            Controls.Add(guna2Panel1);
            Controls.Add(pnlPreview);
            Name = "uiFeatureNullException";
            Load += uiFeatureNullException_Load;
            pnlPreview.ResumeLayout(false);
            imgImage.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlPreview;
        private Guna.UI2.WinForms.Guna2Panel imgImage;
        private Label lblName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblMes;
        private Label lblExc;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button bntTrouble;
        private Label label1;
    }
}