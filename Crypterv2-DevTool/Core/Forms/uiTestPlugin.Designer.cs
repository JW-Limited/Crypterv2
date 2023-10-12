namespace Crypterv2_DevTool.Core.Forms
{
    partial class uiTestPlugin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiTestPlugin));
            cmbPlugins = new ComboBox();
            pnlControls = new Guna.UI2.WinForms.Guna2Panel();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            lblDirectory = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            pnlChild = new Guna.UI2.WinForms.Guna2Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblVersion = new Label();
            lblProductName = new Label();
            lblPluginInfo = new Label();
            pnlControls.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbPlugins
            // 
            cmbPlugins.Anchor = AnchorStyles.Right;
            cmbPlugins.FormattingEnabled = true;
            cmbPlugins.Location = new Point(598, 28);
            cmbPlugins.Margin = new Padding(2);
            cmbPlugins.Name = "cmbPlugins";
            cmbPlugins.Size = new Size(270, 33);
            cmbPlugins.TabIndex = 0;
            cmbPlugins.SelectedIndexChanged += cmbPlugins_SelectedIndexChanged;
            // 
            // pnlControls
            // 
            pnlControls.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlControls.BackColor = Color.White;
            pnlControls.BorderColor = Color.Gainsboro;
            pnlControls.BorderRadius = 20;
            pnlControls.BorderThickness = 2;
            pnlControls.Controls.Add(guna2Button3);
            pnlControls.Controls.Add(lblDirectory);
            pnlControls.Controls.Add(cmbPlugins);
            pnlControls.Controls.Add(guna2Button1);
            pnlControls.FillColor = SystemColors.ButtonHighlight;
            pnlControls.Location = new Point(24, 32);
            pnlControls.Margin = new Padding(2);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new Size(894, 88);
            pnlControls.TabIndex = 25;
            // 
            // guna2Button3
            // 
            guna2Button3.Animated = true;
            guna2Button3.BackColor = Color.Transparent;
            guna2Button3.BorderColor = Color.Gainsboro;
            guna2Button3.BorderRadius = 20;
            guna2Button3.BorderThickness = 2;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.Transparent;
            guna2Button3.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Image = (Image)resources.GetObject("guna2Button3.Image");
            guna2Button3.ImageSize = new Size(35, 35);
            guna2Button3.Location = new Point(16, 16);
            guna2Button3.Margin = new Padding(2);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.Size = new Size(72, 58);
            guna2Button3.TabIndex = 27;
            guna2Button3.Click += guna2Button3_Click;
            // 
            // lblDirectory
            // 
            lblDirectory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDirectory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDirectory.Location = new Point(320, 24);
            lblDirectory.Margin = new Padding(2, 0, 2, 0);
            lblDirectory.Name = "lblDirectory";
            lblDirectory.Size = new Size(262, 40);
            lblDirectory.TabIndex = 17;
            lblDirectory.Text = "label1";
            lblDirectory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Left;
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.Gainsboro;
            guna2Button1.BorderRadius = 5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.DimGray;
            guna2Button1.Location = new Point(104, 24);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(200, 40);
            guna2Button1.TabIndex = 16;
            guna2Button1.Text = "Choose Directory";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button2.Animated = true;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderColor = Color.Gainsboro;
            guna2Button2.BorderRadius = 20;
            guna2Button2.BorderThickness = 2;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.White;
            guna2Button2.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.DimGray;
            guna2Button2.Location = new Point(742, 232);
            guna2Button2.Margin = new Padding(2);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(168, 56);
            guna2Button2.TabIndex = 16;
            guna2Button2.Text = "Initialize";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // pnlChild
            // 
            pnlChild.BackColor = Color.White;
            pnlChild.BorderColor = Color.Gainsboro;
            pnlChild.BorderRadius = 25;
            pnlChild.BorderThickness = 2;
            pnlChild.FillColor = Color.White;
            pnlChild.Location = new Point(40, 176);
            pnlChild.Margin = new Padding(2);
            pnlChild.Name = "pnlChild";
            pnlChild.Size = new Size(168, 160);
            pnlChild.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(lblPluginInfo, 0, 1);
            tableLayoutPanel2.Location = new Point(232, 216);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 17.01389F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 82.9861145F));
            tableLayoutPanel2.Size = new Size(496, 288);
            tableLayoutPanel2.TabIndex = 26;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(lblVersion, 1, 0);
            tableLayoutPanel1.Controls.Add(lblProductName, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(490, 43);
            tableLayoutPanel1.TabIndex = 34;
            // 
            // lblVersion
            // 
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Dock = DockStyle.Fill;
            lblVersion.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblVersion.Location = new Point(194, 0);
            lblVersion.Margin = new Padding(2, 0, 2, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(382, 43);
            lblVersion.TabIndex = 11;
            lblVersion.Text = "Version";
            lblVersion.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Dock = DockStyle.Fill;
            lblProductName.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductName.ForeColor = Color.Black;
            lblProductName.Location = new Point(2, 0);
            lblProductName.Margin = new Padding(2, 0, 2, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(188, 43);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "PackageName";
            lblProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPluginInfo
            // 
            lblPluginInfo.BackColor = Color.Transparent;
            lblPluginInfo.Dock = DockStyle.Fill;
            lblPluginInfo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPluginInfo.ForeColor = Color.DimGray;
            lblPluginInfo.Location = new Point(4, 49);
            lblPluginInfo.Margin = new Padding(4, 0, 4, 0);
            lblPluginInfo.Name = "lblPluginInfo";
            lblPluginInfo.Size = new Size(488, 239);
            lblPluginInfo.TabIndex = 1;
            lblPluginInfo.Text = "Plugininformation";
            // 
            // uiTestPlugin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(945, 991);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(pnlChild);
            Controls.Add(pnlControls);
            Controls.Add(guna2Button2);
            Margin = new Padding(2);
            MinimumSize = new Size(877, 687);
            Name = "uiTestPlugin";
            Text = "uiTestPlugin";
            Load += uiTestPlugin_Load;
            pnlControls.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbPlugins;
        private Guna.UI2.WinForms.Guna2Panel pnlControls;
        private Guna.UI2.WinForms.Guna2Panel pnlChild;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Label lblDirectory;
        public TableLayoutPanel tableLayoutPanel2;
        public TableLayoutPanel tableLayoutPanel1;
        public Label lblVersion;
        public Label lblProductName;
        public Label lblPluginInfo;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}