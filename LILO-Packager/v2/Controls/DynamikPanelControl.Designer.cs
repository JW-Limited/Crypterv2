namespace LILO_Packager.v2.Controls
{
    partial class DynamikPanelControl
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
            pnlBackground = new Guna.UI2.WinForms.Guna2Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblSubTitle = new Label();
            lblTitle = new Label();
            chbControl = new DynamicToggleButton();
            lblMiddleText = new Label();
            pnlBackground.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBackground.BorderColor = Color.Gainsboro;
            pnlBackground.BorderRadius = 15;
            pnlBackground.BorderThickness = 2;
            pnlBackground.Controls.Add(tableLayoutPanel1);
            pnlBackground.Controls.Add(chbControl);
            pnlBackground.Controls.Add(lblMiddleText);
            pnlBackground.FillColor = Color.White;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Margin = new Padding(2);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(296, 224);
            pnlBackground.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(lblSubTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Location = new Point(20, 20);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(260, 35);
            tableLayoutPanel1.TabIndex = 35;
            // 
            // lblSubTitle
            // 
            lblSubTitle.BackColor = Color.Transparent;
            lblSubTitle.Dock = DockStyle.Fill;
            lblSubTitle.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblSubTitle.ForeColor = SystemColors.ControlDarkDark;
            lblSubTitle.Location = new Point(74, 0);
            lblSubTitle.Margin = new Padding(2, 0, 2, 0);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(410, 35);
            lblSubTitle.TabIndex = 11;
            lblSubTitle.Text = "sub";
            lblSubTitle.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(2, 0);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(68, 35);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Title";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chbControl
            // 
            chbControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chbControl.BorderColor = Color.Gainsboro;
            chbControl.BorderRadius = 15;
            chbControl.Checked = true;
            chbControl.CheckedColor = Color.FromArgb(94, 148, 255);
            chbControl.CheckedText = "Enabled";
            chbControl.DisabledText = "Not Changable";
            chbControl.EnabledState = true;
            chbControl.Location = new Point(16, 152);
            chbControl.Margin = new Padding(2);
            chbControl.Name = "chbControl";
            chbControl.Size = new Size(264, 56);
            chbControl.TabIndex = 16;
            chbControl.UnCheckedText = "Disabled";
            // 
            // lblMiddleText
            // 
            lblMiddleText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMiddleText.BackColor = Color.Transparent;
            lblMiddleText.ForeColor = Color.DimGray;
            lblMiddleText.Location = new Point(30, 70);
            lblMiddleText.Margin = new Padding(2, 0, 2, 0);
            lblMiddleText.Name = "lblMiddleText";
            lblMiddleText.Size = new Size(250, 70);
            lblMiddleText.TabIndex = 14;
            lblMiddleText.Text = "n/a";
            lblMiddleText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DynamikPanelControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlBackground);
            Margin = new Padding(4, 4, 4, 4);
            Name = "DynamikPanelControl";
            Size = new Size(299, 224);
            pnlBackground.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlBackground;
        private DynamicToggleButton chbControl;
        private Label lblMiddleText;
        public TableLayoutPanel tableLayoutPanel1;
        public Label lblSubTitle;
        public Label lblTitle;
    }
}
