namespace LILO_Packager.v2.Controls
{
    partial class DynamikFileListItem
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
            lblDescription = new Label();
            lblPluginName = new Label();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(lblDescription);
            guna2Panel1.Controls.Add(lblPluginName);
            guna2Panel1.Controls.Add(guna2Button4);
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(242, 60);
            guna2Panel1.TabIndex = 58;
            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Left;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 8F);
            lblDescription.ForeColor = Color.Silver;
            lblDescription.Location = new Point(16, 32);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(160, 19);
            lblDescription.TabIndex = 54;
            lblDescription.Text = "Manager";
            // 
            // lblPluginName
            // 
            lblPluginName.Anchor = AnchorStyles.Left;
            lblPluginName.AutoEllipsis = true;
            lblPluginName.BackColor = Color.Transparent;
            lblPluginName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPluginName.ForeColor = SystemColors.WindowFrame;
            lblPluginName.Location = new Point(16, 6);
            lblPluginName.Name = "lblPluginName";
            lblPluginName.Size = new Size(160, 32);
            lblPluginName.TabIndex = 53;
            lblPluginName.Text = "Cryptex Manager";
            lblPluginName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Button4
            // 
            guna2Button4.Anchor = AnchorStyles.Right;
            guna2Button4.Animated = true;
            guna2Button4.BackColor = Color.Transparent;
            guna2Button4.BackgroundImageLayout = ImageLayout.Zoom;
            guna2Button4.BorderColor = Color.Gainsboro;
            guna2Button4.BorderRadius = 10;
            guna2Button4.BorderThickness = 2;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.Transparent;
            guna2Button4.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            guna2Button4.ForeColor = Color.White;
            guna2Button4.ImageSize = new Size(25, 25);
            guna2Button4.Location = new Point(183, 16);
            guna2Button4.Margin = new Padding(2);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.Size = new Size(46, 27);
            guna2Button4.TabIndex = 55;
            guna2Button4.Click += guna2Button4_Click;
            // 
            // DynamikFileListItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Panel1);
            Name = "DynamikFileListItem";
            Size = new Size(242, 60);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblDescription;
        private Label lblPluginName;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
    }
}
