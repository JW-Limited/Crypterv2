namespace LILO_Packager.v2.Forms
{
    partial class uiPluginManagerv2
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
            sPanel2 = new Sipaa.Framework.SPanel();
            bntPlugin = new Guna.UI2.WinForms.Guna2Button();
            lblText = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            pnlPlugins = new Panel();
            label1 = new Label();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            lblPluginName = new Label();
            lblDescription = new Label();
            pnlPluginIcon = new Sipaa.Framework.SPanel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            pnlSide = new Guna.UI2.WinForms.Guna2Panel();
            pnlPermissions = new Panel();
            label2 = new Label();
            label3 = new Label();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            lblVersion = new Label();
            label6 = new Label();
            lblCompany = new Label();
            label5 = new Label();
            lblAuthor = new Label();
            label4 = new Label();
            sPanel2.SuspendLayout();
            guna2Panel1.SuspendLayout();
            guna2Panel3.SuspendLayout();
            pnlSide.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sPanel2
            // 
            sPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sPanel2.BackColor = Color.WhiteSmoke;
            sPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel2.BorderColor = Color.Gainsboro;
            sPanel2.BorderRadius = 20;
            sPanel2.BorderSize = 2;
            sPanel2.Controls.Add(bntPlugin);
            sPanel2.Controls.Add(lblText);
            sPanel2.ForeColor = Color.White;
            sPanel2.Location = new Point(24, 32);
            sPanel2.Margin = new Padding(4);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(952, 88);
            sPanel2.TabIndex = 13;
            // 
            // bntPlugin
            // 
            bntPlugin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntPlugin.Animated = true;
            bntPlugin.BackColor = Color.Transparent;
            bntPlugin.BackgroundImageLayout = ImageLayout.Zoom;
            bntPlugin.BorderColor = Color.Gainsboro;
            bntPlugin.BorderRadius = 20;
            bntPlugin.BorderThickness = 2;
            bntPlugin.DisabledState.BorderColor = Color.DarkGray;
            bntPlugin.DisabledState.CustomBorderColor = Color.DarkGray;
            bntPlugin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntPlugin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntPlugin.FillColor = Color.Transparent;
            bntPlugin.FocusedColor = Color.FromArgb(100, 170, 209);
            bntPlugin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            bntPlugin.ForeColor = Color.DimGray;
            bntPlugin.Location = new Point(824, 16);
            bntPlugin.Margin = new Padding(2);
            bntPlugin.Name = "bntPlugin";
            bntPlugin.Size = new Size(112, 58);
            bntPlugin.TabIndex = 15;
            bntPlugin.Text = "Shop";
            bntPlugin.Click += bntPlugin_Click;
            // 
            // lblText
            // 
            lblText.BackColor = Color.Transparent;
            lblText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblText.ForeColor = Color.DimGray;
            lblText.Location = new Point(24, 0);
            lblText.Margin = new Padding(4, 0, 4, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(144, 88);
            lblText.TabIndex = 1;
            lblText.Text = "Plugins";
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(pnlPlugins);
            guna2Panel1.FillColor = Color.Transparent;
            guna2Panel1.Location = new Point(32, 192);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(352, 824);
            guna2Panel1.TabIndex = 14;
            // 
            // pnlPlugins
            // 
            pnlPlugins.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlPlugins.Location = new Point(24, 32);
            pnlPlugins.Name = "pnlPlugins";
            pnlPlugins.Size = new Size(304, 768);
            pnlPlugins.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(64, 168);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 40);
            label1.TabIndex = 1;
            label1.Text = "Plugins";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel3
            // 
            guna2Panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel3.BackColor = Color.Transparent;
            guna2Panel3.BorderColor = Color.Gainsboro;
            guna2Panel3.BorderRadius = 15;
            guna2Panel3.BorderThickness = 2;
            guna2Panel3.Controls.Add(guna2Button2);
            guna2Panel3.Controls.Add(lblPluginName);
            guna2Panel3.Controls.Add(lblDescription);
            guna2Panel3.Controls.Add(pnlPluginIcon);
            guna2Panel3.FillColor = Color.White;
            guna2Panel3.Location = new Point(416, 192);
            guna2Panel3.Margin = new Padding(2);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Size = new Size(560, 120);
            guna2Panel3.TabIndex = 56;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button2.Animated = true;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderColor = Color.WhiteSmoke;
            guna2Button2.BorderRadius = 20;
            guna2Button2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Button2.BorderThickness = 2;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            guna2Button2.ForeColor = Color.DimGray;
            guna2Button2.Location = new Point(416, 16);
            guna2Button2.Margin = new Padding(2);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(128, 88);
            guna2Button2.TabIndex = 57;
            guna2Button2.Text = "Deinstall";
            guna2Button2.Click += bntDeinstall;
            // 
            // lblPluginName
            // 
            lblPluginName.AutoEllipsis = true;
            lblPluginName.BackColor = Color.Transparent;
            lblPluginName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPluginName.ForeColor = SystemColors.WindowFrame;
            lblPluginName.Location = new Point(128, 24);
            lblPluginName.Margin = new Padding(4, 0, 4, 0);
            lblPluginName.Name = "lblPluginName";
            lblPluginName.Size = new Size(312, 40);
            lblPluginName.TabIndex = 53;
            lblPluginName.Text = "Choose";
            lblPluginName.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblDescription.ForeColor = Color.Silver;
            lblDescription.Location = new Point(128, 72);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(312, 32);
            lblDescription.TabIndex = 54;
            lblDescription.Text = "a Plugin";
            // 
            // pnlPluginIcon
            // 
            pnlPluginIcon.BackColor = Color.White;
            pnlPluginIcon.BackgroundImage = Properties.Resources.Screenshot_2023_10_13_052005;
            pnlPluginIcon.BackgroundImageLayout = ImageLayout.Zoom;
            pnlPluginIcon.BorderColor = Color.Gainsboro;
            pnlPluginIcon.BorderRadius = 20;
            pnlPluginIcon.BorderSize = 0;
            pnlPluginIcon.ForeColor = Color.White;
            pnlPluginIcon.Location = new Point(16, 16);
            pnlPluginIcon.Margin = new Padding(4);
            pnlPluginIcon.Name = "pnlPluginIcon";
            pnlPluginIcon.Size = new Size(96, 88);
            pnlPluginIcon.TabIndex = 52;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            guna2Button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.DimGray;
            guna2Button1.Location = new Point(416, 24);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(128, 88);
            guna2Button1.TabIndex = 57;
            guna2Button1.Text = "Docs";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // pnlSide
            // 
            pnlSide.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSide.BackColor = Color.Transparent;
            pnlSide.BorderColor = Color.Gainsboro;
            pnlSide.BorderRadius = 15;
            pnlSide.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pnlSide.BorderThickness = 2;
            pnlSide.Controls.Add(pnlPermissions);
            pnlSide.FillColor = Color.White;
            pnlSide.Location = new Point(408, 600);
            pnlSide.Margin = new Padding(2);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(573, 408);
            pnlSide.TabIndex = 57;
            // 
            // pnlPermissions
            // 
            pnlPermissions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPermissions.AutoScroll = true;
            pnlPermissions.Location = new Point(8, 24);
            pnlPermissions.Name = "pnlPermissions";
            pnlPermissions.Size = new Size(560, 360);
            pnlPermissions.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(416, 552);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(568, 32);
            label2.TabIndex = 58;
            label2.Text = "Permissions";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(416, 336);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(568, 32);
            label3.TabIndex = 58;
            label3.Text = "Details";
            // 
            // guna2Panel2
            // 
            guna2Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.BorderColor = Color.Gainsboro;
            guna2Panel2.BorderRadius = 15;
            guna2Panel2.BorderThickness = 2;
            guna2Panel2.Controls.Add(guna2Button1);
            guna2Panel2.Controls.Add(lblVersion);
            guna2Panel2.Controls.Add(label6);
            guna2Panel2.Controls.Add(lblCompany);
            guna2Panel2.Controls.Add(label5);
            guna2Panel2.Controls.Add(lblAuthor);
            guna2Panel2.Controls.Add(label4);
            guna2Panel2.FillColor = Color.White;
            guna2Panel2.Location = new Point(416, 384);
            guna2Panel2.Margin = new Padding(2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.Size = new Size(560, 136);
            guna2Panel2.TabIndex = 56;
            // 
            // lblVersion
            // 
            lblVersion.AutoEllipsis = true;
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVersion.ForeColor = Color.DarkGray;
            lblVersion.Location = new Point(168, 96);
            lblVersion.Margin = new Padding(4, 0, 4, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(224, 32);
            lblVersion.TabIndex = 53;
            lblVersion.Text = "null";
            lblVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = SystemColors.WindowFrame;
            label6.Location = new Point(24, 96);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(144, 32);
            label6.TabIndex = 53;
            label6.Text = "Version:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCompany
            // 
            lblCompany.AutoEllipsis = true;
            lblCompany.BackColor = Color.Transparent;
            lblCompany.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCompany.ForeColor = Color.DarkGray;
            lblCompany.Location = new Point(168, 56);
            lblCompany.Margin = new Padding(4, 0, 4, 0);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(224, 32);
            lblCompany.TabIndex = 53;
            lblCompany.Text = "null";
            lblCompany.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = SystemColors.WindowFrame;
            label5.Location = new Point(24, 56);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(144, 32);
            label5.TabIndex = 53;
            label5.Text = "Company:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoEllipsis = true;
            lblAuthor.BackColor = Color.Transparent;
            lblAuthor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAuthor.ForeColor = Color.DarkGray;
            lblAuthor.Location = new Point(168, 16);
            lblAuthor.Margin = new Padding(4, 0, 4, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(224, 24);
            lblAuthor.TabIndex = 53;
            lblAuthor.Text = "null";
            lblAuthor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(24, 16);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 53;
            label4.Text = "Plugin ID:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiPluginManagerv2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1001, 1045);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pnlSide);
            Controls.Add(guna2Panel2);
            Controls.Add(guna2Panel3);
            Controls.Add(label1);
            Controls.Add(guna2Panel1);
            Controls.Add(sPanel2);
            Name = "uiPluginManagerv2";
            Text = "uiPluginManagerv2";
            Load += uiPluginManagerv2_Load;
            sPanel2.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel3.ResumeLayout(false);
            pnlSide.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sipaa.Framework.SPanel sPanel2;
        private Guna.UI2.WinForms.Guna2Button bntPlugin;
        private Label lblText;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Panel pnlPlugins;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label lblPluginName;
        private Label lblDescription;
        private Sipaa.Framework.SPanel pnlPluginIcon;
        private Guna.UI2.WinForms.Guna2Panel pnlSide;
        private Panel pnlPermissions;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label label5;
        private Label label4;
        private Label lblVersion;
        private Label label6;
        private Label lblCompany;
        private Label lblAuthor;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}