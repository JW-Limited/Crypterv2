namespace LILO_Packager.v2.Controls
{
    partial class DynamicToggleButton
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
            pnlBackGround = new Guna.UI2.WinForms.Guna2Panel();
            label41 = new Label();
            toggleButton = new Sipaa.Framework.SToggleButton();
            pnlBackGround.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBackGround
            // 
            pnlBackGround.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBackGround.BorderColor = Color.Gainsboro;
            pnlBackGround.BorderRadius = 15;
            pnlBackGround.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            pnlBackGround.BorderThickness = 2;
            pnlBackGround.Controls.Add(label41);
            pnlBackGround.Controls.Add(toggleButton);
            pnlBackGround.Cursor = Cursors.Hand;
            pnlBackGround.FillColor = Color.White;
            pnlBackGround.Location = new Point(0, 0);
            pnlBackGround.Margin = new Padding(2);
            pnlBackGround.Name = "pnlBackGround";
            pnlBackGround.Size = new Size(251, 51);
            pnlBackGround.TabIndex = 17;
            pnlBackGround.Click += pnlBackGround_Click;
            // 
            // label41
            // 
            label41.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label41.BackColor = Color.Transparent;
            label41.Location = new Point(16, 5);
            label41.Margin = new Padding(2, 0, 2, 0);
            label41.Name = "label41";
            label41.Size = new Size(144, 40);
            label41.TabIndex = 14;
            label41.Text = "Disabled";
            label41.TextAlign = ContentAlignment.MiddleLeft;
            label41.Click += pnlBackGround_Click;
            // 
            // toggleButton
            // 
            toggleButton.Anchor = AnchorStyles.Right;
            toggleButton.AutoSize = true;
            toggleButton.BackColor = Color.White;
            toggleButton.Location = new Point(179, 13);
            toggleButton.Margin = new Padding(4);
            toggleButton.MinimumSize = new Size(56, 28);
            toggleButton.Name = "toggleButton";
            toggleButton.OffBackColor = SystemColors.GrayText;
            toggleButton.OffToggleColor = Color.Gainsboro;
            toggleButton.OnBackColor = Color.FromArgb(94, 148, 255);
            toggleButton.OnToggleColor = Color.WhiteSmoke;
            toggleButton.Size = new Size(56, 28);
            toggleButton.TabIndex = 13;
            toggleButton.UseVisualStyleBackColor = false;
            toggleButton.Click += pnlBackGround_Click;
            // 
            // DynamicToggleButton
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlBackGround);
            Name = "DynamicToggleButton";
            Size = new Size(252, 53);
            pnlBackGround.ResumeLayout(false);
            pnlBackGround.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlBackGround;
        private Label label41;
        private Sipaa.Framework.SToggleButton toggleButton;
    }
}
