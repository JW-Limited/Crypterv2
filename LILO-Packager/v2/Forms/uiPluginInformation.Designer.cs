namespace LILO_Packager.v2.Forms
{
    partial class uiPluginInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiPluginInformation));
            lblDescription = new Label();
            lblPluginName = new Label();
            pnlPluginIcon = new Sipaa.Framework.SPanel();
            pnlSide = new Guna.UI2.WinForms.Guna2Panel();
            pnlPermissions = new Panel();
            guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            pnlSide.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.Transparent;
            resources.ApplyResources(lblDescription, "lblDescription");
            lblDescription.ForeColor = Color.Silver;
            lblDescription.Name = "lblDescription";
            // 
            // lblPluginName
            // 
            lblPluginName.AutoEllipsis = true;
            lblPluginName.BackColor = Color.Transparent;
            resources.ApplyResources(lblPluginName, "lblPluginName");
            lblPluginName.ForeColor = SystemColors.WindowFrame;
            lblPluginName.Name = "lblPluginName";
            // 
            // pnlPluginIcon
            // 
            pnlPluginIcon.BackColor = Color.White;
            pnlPluginIcon.BackgroundImage = Properties.Resources.Screenshot_2023_10_13_052005;
            resources.ApplyResources(pnlPluginIcon, "pnlPluginIcon");
            pnlPluginIcon.BorderColor = Color.Gainsboro;
            pnlPluginIcon.BorderRadius = 20;
            pnlPluginIcon.BorderSize = 0;
            pnlPluginIcon.ForeColor = Color.White;
            pnlPluginIcon.Name = "pnlPluginIcon";
            // 
            // pnlSide
            // 
            resources.ApplyResources(pnlSide, "pnlSide");
            pnlSide.BackColor = Color.Transparent;
            pnlSide.BorderColor = Color.Gainsboro;
            pnlSide.BorderRadius = 15;
            pnlSide.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pnlSide.BorderThickness = 2;
            pnlSide.Controls.Add(pnlPermissions);
            pnlSide.FillColor = Color.White;
            pnlSide.Name = "pnlSide";
            // 
            // pnlPermissions
            // 
            resources.ApplyResources(pnlPermissions, "pnlPermissions");
            pnlPermissions.Name = "pnlPermissions";
            // 
            // guna2Button5
            // 
            resources.ApplyResources(guna2Button5, "guna2Button5");
            guna2Button5.Animated = true;
            guna2Button5.BackColor = Color.Transparent;
            guna2Button5.BorderColor = Color.WhiteSmoke;
            guna2Button5.BorderRadius = 20;
            guna2Button5.BorderThickness = 2;
            guna2Button5.DisabledState.BorderColor = Color.DarkGray;
            guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button5.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button5.ForeColor = Color.White;
            guna2Button5.HoverState.FillColor = Color.RoyalBlue;
            guna2Button5.HoverState.ForeColor = Color.White;
            guna2Button5.Name = "guna2Button5";
            guna2Button5.Click += guna2Button5_Click;
            // 
            // guna2Button2
            // 
            resources.ApplyResources(guna2Button2, "guna2Button2");
            guna2Button2.Animated = true;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderColor = Color.WhiteSmoke;
            guna2Button2.BorderRadius = 20;
            guna2Button2.BorderThickness = 2;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button2.ForeColor = Color.DimGray;
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Gray;
            label1.Name = "label1";
            // 
            // guna2Panel1
            // 
            resources.ApplyResources(guna2Panel1, "guna2Panel1");
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(guna2Button1);
            guna2Panel1.Controls.Add(lblPluginName);
            guna2Panel1.Controls.Add(lblDescription);
            guna2Panel1.Controls.Add(pnlPluginIcon);
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Name = "guna2Panel1";
            // 
            // guna2Button1
            // 
            resources.ApplyResources(guna2Button1, "guna2Button1");
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.WhiteSmoke;
            guna2Button1.BorderRadius = 20;
            guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Button1.BorderThickness = 2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.ForeColor = Color.DimGray;
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // uiPluginInformation
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2Panel1);
            Controls.Add(guna2Button5);
            Controls.Add(guna2Button2);
            Controls.Add(pnlSide);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "uiPluginInformation";
            ShowIcon = false;
            Load += uiPluginInformation_Load;
            pnlSide.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblDescription;
        private Label lblPluginName;
        private Sipaa.Framework.SPanel pnlPluginIcon;
        private Guna.UI2.WinForms.Guna2Panel pnlSide;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Panel pnlPermissions;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}