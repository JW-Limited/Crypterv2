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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            label8 = new Label();
            guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            label9 = new Label();
            guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            label6 = new Label();
            guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            label7 = new Label();
            guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            label4 = new Label();
            guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            label5 = new Label();
            guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            dynamicToggleButton2 = new LILO_Packager.v2.Controls.DynamicToggleButton();
            label3 = new Label();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            dynamicToggleButton1 = new LILO_Packager.v2.Controls.DynamicToggleButton();
            label2 = new Label();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            pnlControls.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            guna2Panel6.SuspendLayout();
            guna2Panel5.SuspendLayout();
            guna2Panel7.SuspendLayout();
            guna2Panel4.SuspendLayout();
            guna2Panel3.SuspendLayout();
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
            guna2Button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
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
            lblDirectory.Font = new Font("Segoe UI", 10F);
            lblDirectory.Location = new Point(304, 24);
            lblDirectory.Margin = new Padding(2, 0, 2, 0);
            lblDirectory.Name = "lblDirectory";
            lblDirectory.Size = new Size(278, 40);
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
            guna2Button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.DimGray;
            guna2Button1.Location = new Point(96, 24);
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
            guna2Button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            guna2Button2.ForeColor = Color.DimGray;
            guna2Button2.Location = new Point(824, 232);
            guna2Button2.Margin = new Padding(2);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(86, 56);
            guna2Button2.TabIndex = 16;
            guna2Button2.Text = "Test";
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
            lblVersion.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
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
            lblProductName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
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
            lblPluginInfo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPluginInfo.ForeColor = Color.DimGray;
            lblPluginInfo.Location = new Point(4, 49);
            lblPluginInfo.Margin = new Padding(4, 0, 4, 0);
            lblPluginInfo.Name = "lblPluginInfo";
            lblPluginInfo.Size = new Size(488, 239);
            lblPluginInfo.TabIndex = 1;
            lblPluginInfo.Text = "Plugininformation";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BackgroundImage = Crypterv2.DevTool.Properties.Resources.nothing;
            guna2Panel1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 25;
            guna2Panel1.FillColor = Color.Transparent;
            guna2Panel1.Location = new Point(56, 192);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(136, 128);
            guna2Panel1.TabIndex = 24;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel2.BackColor = Color.White;
            guna2Panel2.BorderColor = Color.Gainsboro;
            guna2Panel2.BorderRadius = 25;
            guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel2.BorderThickness = 2;
            guna2Panel2.Controls.Add(guna2Panel6);
            guna2Panel2.Controls.Add(guna2Panel5);
            guna2Panel2.Controls.Add(guna2Panel7);
            guna2Panel2.FillColor = Color.White;
            guna2Panel2.Location = new Point(32, 544);
            guna2Panel2.Margin = new Padding(2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.Size = new Size(888, 264);
            guna2Panel2.TabIndex = 24;
            // 
            // guna2Panel6
            // 
            guna2Panel6.Anchor = AnchorStyles.Top;
            guna2Panel6.BackColor = Color.White;
            guna2Panel6.BorderColor = Color.Gainsboro;
            guna2Panel6.BorderRadius = 25;
            guna2Panel6.BorderThickness = 2;
            guna2Panel6.Controls.Add(label8);
            guna2Panel6.Controls.Add(guna2Button7);
            guna2Panel6.Controls.Add(label9);
            guna2Panel6.FillColor = Color.White;
            guna2Panel6.Location = new Point(600, 40);
            guna2Panel6.Margin = new Padding(2);
            guna2Panel6.Name = "guna2Panel6";
            guna2Panel6.Size = new Size(248, 184);
            guna2Panel6.TabIndex = 24;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(24, 24);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(192, 32);
            label8.TabIndex = 17;
            label8.Text = "Dependencies";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Button7
            // 
            guna2Button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button7.Animated = true;
            guna2Button7.BackColor = Color.Transparent;
            guna2Button7.BorderColor = Color.Gainsboro;
            guna2Button7.BorderRadius = 15;
            guna2Button7.BorderThickness = 2;
            guna2Button7.DisabledState.BorderColor = Color.DarkGray;
            guna2Button7.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button7.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button7.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button7.FillColor = Color.White;
            guna2Button7.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            guna2Button7.ForeColor = Color.DimGray;
            guna2Button7.Location = new Point(16, 128);
            guna2Button7.Margin = new Padding(2);
            guna2Button7.Name = "guna2Button7";
            guna2Button7.Size = new Size(216, 40);
            guna2Button7.TabIndex = 16;
            guna2Button7.Text = "Choose";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 9F);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(24, 56);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(192, 64);
            label9.TabIndex = 17;
            label9.Text = "Choose .ddls, Icons or Audio Files needed.";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Panel5
            // 
            guna2Panel5.Anchor = AnchorStyles.Top;
            guna2Panel5.BackColor = Color.White;
            guna2Panel5.BorderColor = Color.Gainsboro;
            guna2Panel5.BorderRadius = 25;
            guna2Panel5.BorderThickness = 2;
            guna2Panel5.Controls.Add(label6);
            guna2Panel5.Controls.Add(guna2Button6);
            guna2Panel5.Controls.Add(label7);
            guna2Panel5.FillColor = Color.White;
            guna2Panel5.Location = new Point(320, 40);
            guna2Panel5.Margin = new Padding(2);
            guna2Panel5.Name = "guna2Panel5";
            guna2Panel5.Size = new Size(248, 184);
            guna2Panel5.TabIndex = 24;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(24, 24);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(192, 32);
            label6.TabIndex = 17;
            label6.Text = "Informations";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Button6
            // 
            guna2Button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button6.Animated = true;
            guna2Button6.BackColor = Color.Transparent;
            guna2Button6.BorderColor = Color.Gainsboro;
            guna2Button6.BorderRadius = 15;
            guna2Button6.BorderThickness = 2;
            guna2Button6.DisabledState.BorderColor = Color.DarkGray;
            guna2Button6.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button6.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button6.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button6.FillColor = Color.White;
            guna2Button6.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            guna2Button6.ForeColor = Color.DimGray;
            guna2Button6.Location = new Point(16, 128);
            guna2Button6.Margin = new Padding(2);
            guna2Button6.Name = "guna2Button6";
            guna2Button6.Size = new Size(216, 40);
            guna2Button6.TabIndex = 16;
            guna2Button6.Text = "Add";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(24, 56);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(192, 64);
            label7.TabIndex = 17;
            label7.Text = "Provide information about you/the plugin.";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Panel7
            // 
            guna2Panel7.Anchor = AnchorStyles.Top;
            guna2Panel7.BackColor = Color.White;
            guna2Panel7.BorderColor = Color.Gainsboro;
            guna2Panel7.BorderRadius = 25;
            guna2Panel7.BorderThickness = 2;
            guna2Panel7.Controls.Add(label4);
            guna2Panel7.Controls.Add(guna2Button5);
            guna2Panel7.Controls.Add(label5);
            guna2Panel7.FillColor = Color.White;
            guna2Panel7.Location = new Point(40, 40);
            guna2Panel7.Margin = new Padding(2);
            guna2Panel7.Name = "guna2Panel7";
            guna2Panel7.Size = new Size(248, 184);
            guna2Panel7.TabIndex = 24;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(24, 24);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(192, 32);
            label4.TabIndex = 17;
            label4.Text = "Icon\r\n";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Button5
            // 
            guna2Button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button5.Animated = true;
            guna2Button5.BackColor = Color.Transparent;
            guna2Button5.BorderColor = Color.Gainsboro;
            guna2Button5.BorderRadius = 15;
            guna2Button5.BorderThickness = 2;
            guna2Button5.DisabledState.BorderColor = Color.DarkGray;
            guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button5.FillColor = Color.White;
            guna2Button5.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            guna2Button5.ForeColor = Color.DimGray;
            guna2Button5.Location = new Point(16, 128);
            guna2Button5.Margin = new Padding(2);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.Size = new Size(216, 40);
            guna2Button5.TabIndex = 16;
            guna2Button5.Text = "Choose";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(24, 56);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(192, 64);
            label5.TabIndex = 17;
            label5.Text = "Choose an Icon for the plugin.";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Panel4
            // 
            guna2Panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel4.BackColor = Color.White;
            guna2Panel4.BorderColor = Color.Gainsboro;
            guna2Panel4.BorderRadius = 25;
            guna2Panel4.Controls.Add(dynamicToggleButton2);
            guna2Panel4.Controls.Add(label3);
            guna2Panel4.FillColor = Color.White;
            guna2Panel4.Location = new Point(24, 352);
            guna2Panel4.Margin = new Padding(2);
            guna2Panel4.Name = "guna2Panel4";
            guna2Panel4.Size = new Size(896, 64);
            guna2Panel4.TabIndex = 24;
            // 
            // dynamicToggleButton2
            // 
            dynamicToggleButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dynamicToggleButton2.BorderColor = Color.Gainsboro;
            dynamicToggleButton2.BorderRadius = 15;
            dynamicToggleButton2.Checked = false;
            dynamicToggleButton2.CheckedColor = Color.FromArgb(94, 148, 255);
            dynamicToggleButton2.CheckedText = "Agreed";
            dynamicToggleButton2.DisabledText = "Not Changable";
            dynamicToggleButton2.EnabledState = true;
            dynamicToggleButton2.Location = new Point(680, 8);
            dynamicToggleButton2.Name = "dynamicToggleButton2";
            dynamicToggleButton2.Size = new Size(208, 48);
            dynamicToggleButton2.TabIndex = 0;
            dynamicToggleButton2.UnCheckedText = "Disagreed";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(16, 12);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(688, 40);
            label3.TabIndex = 17;
            label3.Text = " I dont use code thats pirated or copyright protected.";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Panel3
            // 
            guna2Panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel3.BackColor = Color.White;
            guna2Panel3.BorderColor = Color.Gainsboro;
            guna2Panel3.BorderRadius = 25;
            guna2Panel3.Controls.Add(dynamicToggleButton1);
            guna2Panel3.Controls.Add(label2);
            guna2Panel3.FillColor = Color.White;
            guna2Panel3.Location = new Point(24, 408);
            guna2Panel3.Margin = new Padding(2);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Size = new Size(896, 64);
            guna2Panel3.TabIndex = 24;
            // 
            // dynamicToggleButton1
            // 
            dynamicToggleButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dynamicToggleButton1.BorderColor = Color.Gainsboro;
            dynamicToggleButton1.BorderRadius = 15;
            dynamicToggleButton1.Checked = false;
            dynamicToggleButton1.CheckedColor = Color.FromArgb(94, 148, 255);
            dynamicToggleButton1.CheckedText = "Agreed";
            dynamicToggleButton1.DisabledText = "Not Changable";
            dynamicToggleButton1.EnabledState = true;
            dynamicToggleButton1.Location = new Point(680, 8);
            dynamicToggleButton1.Name = "dynamicToggleButton1";
            dynamicToggleButton1.Size = new Size(208, 48);
            dynamicToggleButton1.TabIndex = 0;
            dynamicToggleButton1.UnCheckedText = "Disagreed";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(16, 12);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(696, 40);
            label2.TabIndex = 17;
            label2.Text = " I am authorised to distribute and publish this plugin as creator.";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Button4
            // 
            guna2Button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button4.Animated = true;
            guna2Button4.BackColor = Color.Transparent;
            guna2Button4.BorderColor = Color.Gainsboro;
            guna2Button4.BorderRadius = 20;
            guna2Button4.BorderThickness = 2;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.White;
            guna2Button4.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            guna2Button4.ForeColor = Color.DimGray;
            guna2Button4.Location = new Point(704, 232);
            guna2Button4.Margin = new Padding(2);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.Size = new Size(104, 56);
            guna2Button4.TabIndex = 16;
            guna2Button4.Text = "Build";
            guna2Button4.Click += guna2Button2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(56, 520);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 40);
            label1.TabIndex = 2;
            label1.Text = "   Packager";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiTestPlugin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(945, 853);
            Controls.Add(guna2Panel4);
            Controls.Add(label1);
            Controls.Add(guna2Panel3);
            Controls.Add(guna2Button4);
            Controls.Add(guna2Panel2);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(guna2Panel1);
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
            guna2Panel2.ResumeLayout(false);
            guna2Panel6.ResumeLayout(false);
            guna2Panel5.ResumeLayout(false);
            guna2Panel7.ResumeLayout(false);
            guna2Panel4.ResumeLayout(false);
            guna2Panel3.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private LILO_Packager.v2.Controls.DynamicToggleButton dynamicToggleButton1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private LILO_Packager.v2.Controls.DynamicToggleButton dynamicToggleButton2;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Label label5;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Label label8;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Label label9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Label label7;
    }
}