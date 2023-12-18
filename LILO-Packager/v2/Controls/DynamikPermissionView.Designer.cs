namespace LILO_Packager.v2.Controls
{
    partial class DynamikPermissionView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblPluginName = new Label();
            toggleGrantPermission = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            lblDescription = new Label();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(lblPluginName);
            guna2Panel1.Controls.Add(toggleGrantPermission);
            guna2Panel1.Controls.Add(lblDescription);
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(568, 100);
            guna2Panel1.TabIndex = 56;
            // 
            // lblPluginName
            // 
            lblPluginName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPluginName.AutoEllipsis = true;
            lblPluginName.BackColor = Color.Transparent;
            lblPluginName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPluginName.ForeColor = SystemColors.WindowFrame;
            lblPluginName.Location = new Point(24, 24);
            lblPluginName.Margin = new Padding(4, 0, 4, 0);
            lblPluginName.Name = "lblPluginName";
            lblPluginName.Size = new Size(384, 32);
            lblPluginName.TabIndex = 53;
            lblPluginName.Text = "Cryptex Manager";
            lblPluginName.TextAlign = ContentAlignment.BottomLeft;
            // 
            // toggleGrantPermission
            // 
            toggleGrantPermission.Anchor = AnchorStyles.Right;
            toggleGrantPermission.Animated = true;
            toggleGrantPermission.Checked = true;
            toggleGrantPermission.CheckedState.BorderColor = Color.Gainsboro;
            toggleGrantPermission.CheckedState.BorderRadius = 15;
            toggleGrantPermission.CheckedState.BorderThickness = 2;
            toggleGrantPermission.CheckedState.FillColor = Color.RoyalBlue;
            toggleGrantPermission.CheckedState.InnerBorderColor = Color.Gainsboro;
            toggleGrantPermission.CheckedState.InnerBorderRadius = 10;
            toggleGrantPermission.CheckedState.InnerBorderThickness = 2;
            toggleGrantPermission.CheckedState.InnerColor = Color.White;
            toggleGrantPermission.CheckedState.InnerOffset = 2;
            toggleGrantPermission.Location = new Point(472, 30);
            toggleGrantPermission.Name = "toggleGrantPermission";
            toggleGrantPermission.Size = new Size(72, 40);
            toggleGrantPermission.TabIndex = 57;
            toggleGrantPermission.UncheckedState.BorderColor = Color.Gainsboro;
            toggleGrantPermission.UncheckedState.BorderThickness = 2;
            toggleGrantPermission.UncheckedState.InnerBorderColor = Color.Gainsboro;
            toggleGrantPermission.UncheckedState.InnerBorderThickness = 2;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescription.ForeColor = Color.Silver;
            lblDescription.Location = new Point(24, 56);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(384, 28);
            lblDescription.TabIndex = 54;
            lblDescription.Text = "Manager";
            // 
            // DynamikPermissionView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Panel1);
            Name = "DynamikPermissionView";
            Size = new Size(568, 100);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblPluginName;
        private Label lblDescription;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleGrantPermission;
    }
}
