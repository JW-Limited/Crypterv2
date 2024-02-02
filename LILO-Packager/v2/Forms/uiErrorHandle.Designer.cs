namespace LILO_Packager.v2.Forms
{
    partial class uiErrorHandle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiErrorHandle));
            pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            lblName = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            lblMes = new Label();
            lblExc = new Label();
            bntTrouble = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            lblAddtional = new Label();
            bntReport = new Guna.UI2.WinForms.Guna2Button();
            pnlPreview.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPreview
            // 
            resources.ApplyResources(pnlPreview, "pnlPreview");
            pnlPreview.BackColor = Color.White;
            pnlPreview.BorderColor = SystemColors.ActiveBorder;
            pnlPreview.BorderRadius = 15;
            pnlPreview.Controls.Add(guna2Panel2);
            pnlPreview.Controls.Add(lblName);
            pnlPreview.FillColor = Color.White;
            pnlPreview.Name = "pnlPreview";
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
            // lblName
            // 
            resources.ApplyResources(lblName, "lblName");
            lblName.AutoEllipsis = true;
            lblName.BackColor = Color.Transparent;
            lblName.ForeColor = Color.Black;
            lblName.Name = "lblName";
            // 
            // guna2Panel1
            // 
            resources.ApplyResources(guna2Panel1, "guna2Panel1");
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(guna2Button3);
            guna2Panel1.Controls.Add(lblMes);
            guna2Panel1.FillColor = Color.WhiteSmoke;
            guna2Panel1.Name = "guna2Panel1";
            // 
            // guna2Button3
            // 
            resources.ApplyResources(guna2Button3, "guna2Button3");
            guna2Button3.Animated = true;
            guna2Button3.BackColor = Color.Transparent;
            guna2Button3.BorderColor = Color.Gainsboro;
            guna2Button3.BorderRadius = 12;
            guna2Button3.BorderThickness = 2;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.White;
            guna2Button3.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button3.ForeColor = Color.DimGray;
            guna2Button3.Image = Properties.Resources.Info;
            guna2Button3.ImageSize = new Size(25, 25);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.Click += guna2Button3_Click;
            // 
            // lblMes
            // 
            resources.ApplyResources(lblMes, "lblMes");
            lblMes.BackColor = Color.Transparent;
            lblMes.ForeColor = Color.Gray;
            lblMes.Name = "lblMes";
            // 
            // lblExc
            // 
            resources.ApplyResources(lblExc, "lblExc");
            lblExc.BackColor = Color.Transparent;
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
            // lblAddtional
            // 
            lblAddtional.BackColor = Color.Transparent;
            resources.ApplyResources(lblAddtional, "lblAddtional");
            lblAddtional.ForeColor = Color.Black;
            lblAddtional.Name = "lblAddtional";
            // 
            // bntReport
            // 
            resources.ApplyResources(bntReport, "bntReport");
            bntReport.Animated = true;
            bntReport.BackColor = Color.Transparent;
            bntReport.BorderColor = Color.Gainsboro;
            bntReport.BorderRadius = 12;
            bntReport.BorderThickness = 2;
            bntReport.DisabledState.BorderColor = Color.DarkGray;
            bntReport.DisabledState.CustomBorderColor = Color.DarkGray;
            bntReport.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntReport.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntReport.FillColor = Color.WhiteSmoke;
            bntReport.FocusedColor = Color.FromArgb(100, 170, 209);
            bntReport.ForeColor = Color.SteelBlue;
            bntReport.HoverState.FillColor = Color.RoyalBlue;
            bntReport.HoverState.ForeColor = Color.White;
            bntReport.Name = "bntReport";
            bntReport.Click += bntReport_Clicked;
            // 
            // uiErrorHandle
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2Panel1);
            Controls.Add(label1);
            Controls.Add(lblExc);
            Controls.Add(lblAddtional);
            Controls.Add(bntReport);
            Controls.Add(bntTrouble);
            Controls.Add(pnlPreview);
            Name = "uiErrorHandle";
            Load += uiFeatureNullException_Load;
            pnlPreview.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlPreview;
        private Label lblName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblMes;
        private Label lblExc;
        private Guna.UI2.WinForms.Guna2Button bntTrouble;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label lblAddtional;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button bntReport;
    }
}