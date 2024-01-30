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
            pnlPermission = new Guna.UI2.WinForms.Guna2Panel();
            pnlIcon = new Sipaa.Framework.SPanel();
            lblPermissionName = new Label();
            lblDescription = new Label();
            bntGrant = new Guna.UI2.WinForms.Guna2Button();
            pnlMain.SuspendLayout();
            pnlPermission.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.HighlightText;
            pnlMain.BorderColor = Color.Gainsboro;
            pnlMain.Controls.Add(bntDeny);
            pnlMain.Controls.Add(pnlPermission);
            pnlMain.Controls.Add(bntGrant);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.FillColor = Color.White;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(2);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(365, 459);
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
            bntDeny.Location = new Point(219, 383);
            bntDeny.Margin = new Padding(2);
            bntDeny.Name = "bntDeny";
            bntDeny.Size = new Size(120, 48);
            bntDeny.TabIndex = 51;
            bntDeny.Text = "Deny";
            bntDeny.Click += bntDeny_Click;
            // 
            // pnlPermission
            // 
            pnlPermission.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPermission.BackColor = SystemColors.HighlightText;
            pnlPermission.BorderColor = Color.WhiteSmoke;
            pnlPermission.BorderRadius = 15;
            pnlPermission.BorderThickness = 2;
            pnlPermission.Controls.Add(pnlIcon);
            pnlPermission.Controls.Add(lblPermissionName);
            pnlPermission.Controls.Add(lblDescription);
            pnlPermission.CustomBorderColor = Color.Gainsboro;
            pnlPermission.FillColor = Color.WhiteSmoke;
            pnlPermission.Location = new Point(24, 32);
            pnlPermission.Margin = new Padding(2);
            pnlPermission.Name = "pnlPermission";
            pnlPermission.Size = new Size(315, 320);
            pnlPermission.TabIndex = 45;
            // 
            // pnlIcon
            // 
            pnlIcon.BackColor = Color.White;
            pnlIcon.BackgroundImageLayout = ImageLayout.Zoom;
            pnlIcon.BorderColor = Color.Gainsboro;
            pnlIcon.BorderRadius = 20;
            pnlIcon.BorderSize = 0;
            pnlIcon.ForeColor = Color.White;
            pnlIcon.Location = new Point(96, 40);
            pnlIcon.Margin = new Padding(4);
            pnlIcon.Name = "pnlIcon";
            pnlIcon.Size = new Size(120, 112);
            pnlIcon.TabIndex = 47;
            // 
            // lblPermissionName
            // 
            lblPermissionName.AutoEllipsis = true;
            lblPermissionName.BackColor = Color.Transparent;
            lblPermissionName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPermissionName.ForeColor = Color.DimGray;
            lblPermissionName.Location = new Point(24, 176);
            lblPermissionName.Margin = new Padding(4, 0, 4, 0);
            lblPermissionName.Name = "lblPermissionName";
            lblPermissionName.Size = new Size(272, 30);
            lblPermissionName.TabIndex = 44;
            lblPermissionName.Text = "n/a";
            lblPermissionName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescription.ForeColor = Color.DarkGray;
            lblDescription.Location = new Point(32, 224);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(256, 72);
            lblDescription.TabIndex = 44;
            lblDescription.Text = "Description";
            lblDescription.TextAlign = ContentAlignment.TopCenter;
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
            bntGrant.Location = new Point(24, 383);
            bntGrant.Margin = new Padding(2);
            bntGrant.Name = "bntGrant";
            bntGrant.Size = new Size(203, 48);
            bntGrant.TabIndex = 52;
            bntGrant.Text = "Grant";
            bntGrant.Click += bntGrant_Click;
            // 
            // uiPermissionRequest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 459);
            ControlBox = false;
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "uiPermissionRequest";
            Text = "Permission Request";
            Load += uiPermissionRequest_Load;
            pnlMain.ResumeLayout(false);
            pnlPermission.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Panel pnlPermission;
        private Sipaa.Framework.SPanel pnlIcon;
        private Label lblDescription;
        private Label lblPermissionName;
        private Guna.UI2.WinForms.Guna2Button bntDeny;
        private Guna.UI2.WinForms.Guna2Button bntGrant;
    }
}