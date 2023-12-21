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
            lblDescription.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblDescription.ForeColor = Color.Silver;
            lblDescription.Location = new Point(128, 64);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(312, 32);
            lblDescription.TabIndex = 54;
            lblDescription.Text = "Manager";
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
            lblPluginName.Text = "Cryptex Manager";
            lblPluginName.TextAlign = ContentAlignment.BottomLeft;
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
            // pnlSide
            // 
            pnlSide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSide.BackColor = Color.Transparent;
            pnlSide.BorderColor = Color.Gainsboro;
            pnlSide.BorderRadius = 15;
            pnlSide.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pnlSide.BorderThickness = 2;
            pnlSide.Controls.Add(pnlPermissions);
            pnlSide.FillColor = Color.White;
            pnlSide.Location = new Point(32, 240);
            pnlSide.Margin = new Padding(2);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(573, 408);
            pnlSide.TabIndex = 55;
            // 
            // pnlPermissions
            // 
            pnlPermissions.AutoScroll = true;
            pnlPermissions.Location = new Point(8, 24);
            pnlPermissions.Name = "pnlPermissions";
            pnlPermissions.Size = new Size(568, 360);
            pnlPermissions.TabIndex = 0;
            // 
            // guna2Button5
            // 
            guna2Button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            guna2Button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            guna2Button5.ForeColor = Color.White;
            guna2Button5.HoverState.FillColor = Color.RoyalBlue;
            guna2Button5.HoverState.ForeColor = Color.White;
            guna2Button5.Location = new Point(32, 680);
            guna2Button5.Margin = new Padding(2);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.Size = new Size(384, 58);
            guna2Button5.TabIndex = 56;
            guna2Button5.Text = "Allow";
            guna2Button5.Click += guna2Button5_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            guna2Button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            guna2Button2.ForeColor = Color.DimGray;
            guna2Button2.Location = new Point(432, 680);
            guna2Button2.Margin = new Padding(2);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(168, 58);
            guna2Button2.TabIndex = 56;
            guna2Button2.Text = "Deny";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(32, 192);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(568, 32);
            label1.TabIndex = 54;
            label1.Text = "Permissions";
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(guna2Button1);
            guna2Panel1.Controls.Add(lblPluginName);
            guna2Panel1.Controls.Add(lblDescription);
            guna2Panel1.Controls.Add(pnlPluginIcon);
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(32, 32);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(568, 120);
            guna2Panel1.TabIndex = 55;
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
            guna2Button1.Location = new Point(464, 16);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(88, 88);
            guna2Button1.TabIndex = 57;
            guna2Button1.Text = "Docs";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // uiPluginInformation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(635, 763);
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
            StartPosition = FormStartPosition.CenterParent;
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