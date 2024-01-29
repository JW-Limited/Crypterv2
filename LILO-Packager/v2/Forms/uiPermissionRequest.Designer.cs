namespace LILO_Packager.v2.Forms
{
    partial class uiPermissionRequest
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
            pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            bntDeny = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblPluginName = new Label();
            pnlPermission = new Guna.UI2.WinForms.Guna2Panel();
            pnlIcon = new Sipaa.Framework.SPanel();
            lblPermissionName = new Label();
            lblDescription = new Label();
            lblVersion = new Label();
            bntGrant = new Guna.UI2.WinForms.Guna2Button();
            pnlMain.SuspendLayout();
            guna2Panel1.SuspendLayout();
            pnlPermission.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.HighlightText;
            pnlMain.BorderColor = Color.Gainsboro;
            pnlMain.Controls.Add(bntDeny);
            pnlMain.Controls.Add(guna2Panel1);
            pnlMain.Controls.Add(bntGrant);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.FillColor = Color.White;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(2);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(443, 327);
            pnlMain.TabIndex = 46;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // bntDeny
            // 
            bntDeny.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bntDeny.Animated = true;
            bntDeny.BackColor = Color.Transparent;
            bntDeny.BackgroundImageLayout = ImageLayout.Zoom;
            bntDeny.BorderColor = Color.Gainsboro;
            bntDeny.BorderRadius = 10;
            bntDeny.BorderThickness = 2;
            bntDeny.CheckedState.FillColor = Color.White;
            bntDeny.CustomizableEdges.BottomLeft = false;
            bntDeny.CustomizableEdges.TopLeft = false;
            bntDeny.DisabledState.BorderColor = Color.Gainsboro;
            bntDeny.DisabledState.CustomBorderColor = Color.Gainsboro;
            bntDeny.DisabledState.FillColor = Color.WhiteSmoke;
            bntDeny.DisabledState.ForeColor = Color.DimGray;
            bntDeny.FillColor = Color.White;
            bntDeny.FocusedColor = Color.FromArgb(100, 170, 209);
            bntDeny.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            bntDeny.ForeColor = Color.DarkGray;
            bntDeny.Location = new Point(296, 253);
            bntDeny.Margin = new Padding(2);
            bntDeny.Name = "bntDeny";
            bntDeny.Size = new Size(120, 48);
            bntDeny.TabIndex = 51;
            bntDeny.Text = "Deny";
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel1.BackColor = SystemColors.HighlightText;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(lblPluginName);
            guna2Panel1.Controls.Add(pnlPermission);
            guna2Panel1.Controls.Add(lblVersion);
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(24, 24);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(392, 200);
            guna2Panel1.TabIndex = 45;
            guna2Panel1.Visible = false;
            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // lblPluginName
            // 
            lblPluginName.BackColor = Color.Transparent;
            lblPluginName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPluginName.ForeColor = Color.DimGray;
            lblPluginName.Location = new Point(24, 24);
            lblPluginName.Margin = new Padding(4, 0, 4, 0);
            lblPluginName.Name = "lblPluginName";
            lblPluginName.Size = new Size(200, 32);
            lblPluginName.TabIndex = 50;
            lblPluginName.Text = "Productname";
            lblPluginName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlPermission
            // 
            pnlPermission.BackColor = SystemColors.HighlightText;
            pnlPermission.BorderColor = Color.Gainsboro;
            pnlPermission.BorderRadius = 15;
            pnlPermission.BorderThickness = 2;
            pnlPermission.Controls.Add(pnlIcon);
            pnlPermission.Controls.Add(lblPermissionName);
            pnlPermission.Controls.Add(lblDescription);
            pnlPermission.FillColor = Color.WhiteSmoke;
            pnlPermission.Location = new Point(24, 96);
            pnlPermission.Margin = new Padding(2);
            pnlPermission.Name = "pnlPermission";
            pnlPermission.Size = new Size(344, 80);
            pnlPermission.TabIndex = 45;
            pnlPermission.Visible = false;
            // 
            // pnlIcon
            // 
            pnlIcon.BackColor = Color.White;
            pnlIcon.BackgroundImageLayout = ImageLayout.Zoom;
            pnlIcon.BorderColor = Color.Gainsboro;
            pnlIcon.BorderRadius = 20;
            pnlIcon.BorderSize = 0;
            pnlIcon.ForeColor = Color.White;
            pnlIcon.Location = new Point(16, 16);
            pnlIcon.Margin = new Padding(4);
            pnlIcon.Name = "pnlIcon";
            pnlIcon.Size = new Size(48, 48);
            pnlIcon.TabIndex = 47;
            // 
            // lblPermissionName
            // 
            lblPermissionName.AutoEllipsis = true;
            lblPermissionName.BackColor = Color.Transparent;
            lblPermissionName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPermissionName.ForeColor = Color.DimGray;
            lblPermissionName.Location = new Point(80, 16);
            lblPermissionName.Margin = new Padding(4, 0, 4, 0);
            lblPermissionName.Name = "lblPermissionName";
            lblPermissionName.Size = new Size(176, 30);
            lblPermissionName.TabIndex = 44;
            lblPermissionName.Text = "n/a";
            lblPermissionName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblDescription.ForeColor = Color.LightGray;
            lblDescription.Location = new Point(80, 48);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(248, 32);
            lblDescription.TabIndex = 44;
            lblDescription.Text = "Description";
            // 
            // lblVersion
            // 
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblVersion.ForeColor = Color.Silver;
            lblVersion.Location = new Point(24, 56);
            lblVersion.Margin = new Padding(4, 0, 4, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(216, 24);
            lblVersion.TabIndex = 44;
            lblVersion.Text = "version";
            lblVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bntGrant
            // 
            bntGrant.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bntGrant.Animated = true;
            bntGrant.BackColor = Color.Transparent;
            bntGrant.BackgroundImageLayout = ImageLayout.Zoom;
            bntGrant.BorderColor = Color.Gainsboro;
            bntGrant.BorderRadius = 10;
            bntGrant.BorderThickness = 2;
            bntGrant.CheckedState.FillColor = Color.White;
            bntGrant.DisabledState.BorderColor = Color.Gainsboro;
            bntGrant.DisabledState.CustomBorderColor = Color.Gainsboro;
            bntGrant.DisabledState.FillColor = Color.WhiteSmoke;
            bntGrant.DisabledState.ForeColor = Color.DimGray;
            bntGrant.FillColor = Color.White;
            bntGrant.FocusedColor = Color.FromArgb(100, 170, 209);
            bntGrant.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            bntGrant.ForeColor = Color.SteelBlue;
            bntGrant.Location = new Point(24, 253);
            bntGrant.Margin = new Padding(2);
            bntGrant.Name = "bntGrant";
            bntGrant.Size = new Size(280, 48);
            bntGrant.TabIndex = 52;
            bntGrant.Text = "Grant";
            // 
            // uiPermissionRequest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 327);
            ControlBox = false;
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "uiPermissionRequest";
            Text = " ";
            Load += uiPermissionRequest_Load;
            pnlMain.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            pnlPermission.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Panel pnlPermission;
        private Sipaa.Framework.SPanel pnlIcon;
        private Label lblDescription;
        private Label lblPermissionName;
        private Label lblVersion;
        private Label lblPluginName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button bntDeny;
        private Guna.UI2.WinForms.Guna2Button bntGrant;
    }
}