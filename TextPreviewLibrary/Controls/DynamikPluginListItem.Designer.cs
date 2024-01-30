using System.Drawing;
using System.Windows.Forms;

namespace TextPreviewLibrary.Controls
{
    partial class DynamikPluginListItem
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
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            lblPluginName = new Label();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(guna2Button4);
            guna2Panel1.Controls.Add(lblPluginName);
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(357, 64);
            guna2Panel1.TabIndex = 57;
            guna2Panel1.Paint += guna2Panel1_Paint;
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
            guna2Button4.Image = Properties.Resources.icons8_document_240;
            guna2Button4.ImageSize = new Size(25, 25);
            guna2Button4.Location = new Point(264, 16);
            guna2Button4.Margin = new Padding(2);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.Size = new Size(80, 34);
            guna2Button4.TabIndex = 54;
            guna2Button4.Click += guna2Button4_Click;
            // 
            // lblPluginName
            // 
            lblPluginName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPluginName.AutoEllipsis = true;
            lblPluginName.BackColor = Color.Transparent;
            lblPluginName.Font = new Font("Segoe UI", 9F);
            lblPluginName.ForeColor = SystemColors.WindowFrame;
            lblPluginName.Location = new Point(16, 8);
            lblPluginName.Margin = new Padding(4, 0, 4, 0);
            lblPluginName.Name = "lblPluginName";
            lblPluginName.Size = new Size(232, 48);
            lblPluginName.TabIndex = 53;
            lblPluginName.Text = "Name";
            lblPluginName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DynamikPluginListItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Panel1);
            Name = "DynamikPluginListItem";
            Size = new Size(357, 64);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblPluginName;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
    }
}
