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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiPermissionRequest));
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
            resources.ApplyResources(pnlMain, "pnlMain");
            pnlMain.FillColor = Color.White;
            pnlMain.Name = "pnlMain";
            pnlMain.Paint += pnlMain_Paint;
            // 
            // bntDeny
            // 
            resources.ApplyResources(bntDeny, "bntDeny");
            bntDeny.Animated = true;
            bntDeny.BackColor = Color.Transparent;
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
            bntDeny.ForeColor = Color.DarkGray;
            bntDeny.Name = "bntDeny";
            bntDeny.Click += bntDeny_Click;
            // 
            // pnlPermission
            // 
            resources.ApplyResources(pnlPermission, "pnlPermission");
            pnlPermission.BackColor = SystemColors.HighlightText;
            pnlPermission.BorderColor = Color.WhiteSmoke;
            pnlPermission.BorderRadius = 15;
            pnlPermission.BorderThickness = 2;
            pnlPermission.Controls.Add(pnlIcon);
            pnlPermission.Controls.Add(lblPermissionName);
            pnlPermission.Controls.Add(lblDescription);
            pnlPermission.CustomBorderColor = Color.Gainsboro;
            pnlPermission.FillColor = Color.WhiteSmoke;
            pnlPermission.Name = "pnlPermission";
            // 
            // pnlIcon
            // 
            pnlIcon.BackColor = Color.White;
            resources.ApplyResources(pnlIcon, "pnlIcon");
            pnlIcon.BorderColor = Color.Gainsboro;
            pnlIcon.BorderRadius = 20;
            pnlIcon.BorderSize = 0;
            pnlIcon.ForeColor = Color.White;
            pnlIcon.Name = "pnlIcon";
            // 
            // lblPermissionName
            // 
            lblPermissionName.AutoEllipsis = true;
            lblPermissionName.BackColor = Color.Transparent;
            resources.ApplyResources(lblPermissionName, "lblPermissionName");
            lblPermissionName.ForeColor = Color.DimGray;
            lblPermissionName.Name = "lblPermissionName";
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.Transparent;
            resources.ApplyResources(lblDescription, "lblDescription");
            lblDescription.ForeColor = Color.DarkGray;
            lblDescription.Name = "lblDescription";
            // 
            // bntGrant
            // 
            resources.ApplyResources(bntGrant, "bntGrant");
            bntGrant.Animated = true;
            bntGrant.BackColor = Color.Transparent;
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
            bntGrant.ForeColor = Color.SteelBlue;
            bntGrant.Name = "bntGrant";
            bntGrant.Click += bntGrant_Click;
            // 
            // uiPermissionRequest
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            ControlBox = false;
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "uiPermissionRequest";
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