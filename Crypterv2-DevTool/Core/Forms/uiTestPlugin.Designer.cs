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
            pnlIcon = new Guna.UI2.WinForms.Guna2Panel();
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
            togglePirate = new LILO_Packager.v2.Controls.DynamicToggleButton();
            label3 = new Label();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            togglePublish = new LILO_Packager.v2.Controls.DynamicToggleButton();
            bntBuild = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            progress = new Guna.UI2.WinForms.Guna2ProgressBar();
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
            cmbPlugins.Location = new Point(478, 22);
            cmbPlugins.Margin = new Padding(2);
            cmbPlugins.Name = "cmbPlugins";
            cmbPlugins.Size = new Size(217, 28);
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
            pnlControls.Location = new Point(19, 26);
            pnlControls.Margin = new Padding(2);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new Size(715, 70);
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
            guna2Button3.Location = new Point(13, 13);
            guna2Button3.Margin = new Padding(2);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.Size = new Size(58, 46);
            guna2Button3.TabIndex = 27;
            guna2Button3.Click += guna2Button3_Click;
            // 
            // lblDirectory
            // 
            lblDirectory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDirectory.Font = new Font("Segoe UI", 10F);
            lblDirectory.Location = new Point(243, 19);
            lblDirectory.Margin = new Padding(2, 0, 2, 0);
            lblDirectory.Name = "lblDirectory";
            lblDirectory.Size = new Size(222, 32);
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
            guna2Button1.Location = new Point(77, 19);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(160, 32);
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
            guna2Button2.Location = new Point(659, 186);
            guna2Button2.Margin = new Padding(2);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(69, 45);
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
            pnlChild.Location = new Point(32, 141);
            pnlChild.Margin = new Padding(2);
            pnlChild.Name = "pnlChild";
            pnlChild.Size = new Size(134, 128);
            pnlChild.TabIndex = 24;
            pnlChild.Click += c;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(lblPluginInfo, 0, 1);
            tableLayoutPanel2.Location = new Point(186, 173);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 17.01389F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 82.9861145F));
            tableLayoutPanel2.Size = new Size(397, 230);
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
            tableLayoutPanel1.Location = new Point(2, 2);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(393, 35);
            tableLayoutPanel1.TabIndex = 34;
            // 
            // lblVersion
            // 
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Dock = DockStyle.Fill;
            lblVersion.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblVersion.Location = new Point(166, 0);
            lblVersion.Margin = new Padding(2, 0, 2, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(306, 35);
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
            lblProductName.Size = new Size(160, 35);
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
            lblPluginInfo.Location = new Point(3, 39);
            lblPluginInfo.Name = "lblPluginInfo";
            lblPluginInfo.Size = new Size(391, 191);
            lblPluginInfo.TabIndex = 1;
            lblPluginInfo.Text = "Plugininformation";
            // 
            // pnlIcon
            // 
            pnlIcon.BackColor = Color.Transparent;
            pnlIcon.BackgroundImage = Crypterv2.DevTool.Properties.Resources.nothing;
            pnlIcon.BackgroundImageLayout = ImageLayout.Zoom;
            pnlIcon.BorderColor = Color.Gainsboro;
            pnlIcon.BorderRadius = 25;
            pnlIcon.FillColor = Color.Transparent;
            pnlIcon.Location = new Point(45, 154);
            pnlIcon.Margin = new Padding(2);
            pnlIcon.Name = "pnlIcon";
            pnlIcon.Size = new Size(109, 102);
            pnlIcon.TabIndex = 24;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel2.BackColor = Color.White;
            guna2Panel2.BorderColor = Color.Gainsboro;
            guna2Panel2.BorderRadius = 25;
            guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel2.BorderThickness = 2;
            guna2Panel2.Controls.Add(guna2Panel6);
            guna2Panel2.Controls.Add(guna2Panel5);
            guna2Panel2.Controls.Add(guna2Panel7);
            guna2Panel2.FillColor = Color.White;
            guna2Panel2.Location = new Point(26, 435);
            guna2Panel2.Margin = new Padding(2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.Size = new Size(710, 211);
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
            guna2Panel6.Location = new Point(480, 32);
            guna2Panel6.Margin = new Padding(2);
            guna2Panel6.Name = "guna2Panel6";
            guna2Panel6.Size = new Size(198, 147);
            guna2Panel6.TabIndex = 24;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(19, 19);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(154, 26);
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
            guna2Button7.Location = new Point(13, 102);
            guna2Button7.Margin = new Padding(2);
            guna2Button7.Name = "guna2Button7";
            guna2Button7.Size = new Size(173, 32);
            guna2Button7.TabIndex = 16;
            guna2Button7.Text = "Choose";
            guna2Button7.Click += bntDependiecies;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 9F);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(19, 45);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(154, 51);
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
            guna2Panel5.Location = new Point(256, 32);
            guna2Panel5.Margin = new Padding(2);
            guna2Panel5.Name = "guna2Panel5";
            guna2Panel5.Size = new Size(198, 147);
            guna2Panel5.TabIndex = 24;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(19, 19);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(154, 26);
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
            guna2Button6.Location = new Point(13, 102);
            guna2Button6.Margin = new Padding(2);
            guna2Button6.Name = "guna2Button6";
            guna2Button6.Size = new Size(173, 32);
            guna2Button6.TabIndex = 16;
            guna2Button6.Text = "Add";
            guna2Button6.Click += guna2Button6_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(19, 45);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(154, 51);
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
            guna2Panel7.Location = new Point(32, 32);
            guna2Panel7.Margin = new Padding(2);
            guna2Panel7.Name = "guna2Panel7";
            guna2Panel7.Size = new Size(198, 147);
            guna2Panel7.TabIndex = 24;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(19, 19);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(154, 26);
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
            guna2Button5.Location = new Point(13, 102);
            guna2Button5.Margin = new Padding(2);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.Size = new Size(173, 32);
            guna2Button5.TabIndex = 16;
            guna2Button5.Text = "Choose";
            guna2Button5.Click += guna2Button5_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(19, 45);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(154, 51);
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
            guna2Panel4.Controls.Add(togglePirate);
            guna2Panel4.Controls.Add(label3);
            guna2Panel4.FillColor = Color.White;
            guna2Panel4.Location = new Point(19, 282);
            guna2Panel4.Margin = new Padding(2);
            guna2Panel4.Name = "guna2Panel4";
            guna2Panel4.Size = new Size(717, 51);
            guna2Panel4.TabIndex = 24;
            // 
            // togglePirate
            // 
            togglePirate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            togglePirate.BorderColor = Color.Gainsboro;
            togglePirate.BorderRadius = 15;
            togglePirate.Checked = false;
            togglePirate.CheckedColor = Color.FromArgb(94, 148, 255);
            togglePirate.CheckedText = "Agreed";
            togglePirate.DisabledText = "Not Changable";
            togglePirate.EnabledState = true;
            togglePirate.Location = new Point(544, 6);
            togglePirate.Margin = new Padding(2, 2, 2, 2);
            togglePirate.Name = "togglePirate";
            togglePirate.Size = new Size(160, 38);
            togglePirate.TabIndex = 0;
            togglePirate.UnCheckedText = "Disagreed";
            togglePirate.Clicked += dynamicToggleButton2_Clicked;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(13, 10);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(550, 32);
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
            guna2Panel3.Controls.Add(label2);
            guna2Panel3.FillColor = Color.White;
            guna2Panel3.Location = new Point(19, 326);
            guna2Panel3.Margin = new Padding(2);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Size = new Size(717, 51);
            guna2Panel3.TabIndex = 24;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(13, 10);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(557, 32);
            label2.TabIndex = 17;
            label2.Text = " I am authorised to distribute and publish this plugin as creator.";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // togglePublish
            // 
            togglePublish.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            togglePublish.BorderColor = Color.Gainsboro;
            togglePublish.BorderRadius = 15;
            togglePublish.Checked = false;
            togglePublish.CheckedColor = Color.FromArgb(94, 148, 255);
            togglePublish.CheckedText = "Agreed";
            togglePublish.DisabledText = "Not Changable";
            togglePublish.EnabledState = true;
            togglePublish.Location = new Point(563, 336);
            togglePublish.Margin = new Padding(2, 2, 2, 2);
            togglePublish.Name = "togglePublish";
            togglePublish.Size = new Size(160, 42);
            togglePublish.TabIndex = 0;
            togglePublish.UnCheckedText = "Disagreed";
            togglePublish.Clicked += togglePublish_Clicked;
            // 
            // bntBuild
            // 
            bntBuild.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntBuild.Animated = true;
            bntBuild.BackColor = Color.Transparent;
            bntBuild.BorderColor = Color.Gainsboro;
            bntBuild.BorderRadius = 20;
            bntBuild.BorderThickness = 2;
            bntBuild.DisabledState.BorderColor = Color.Gainsboro;
            bntBuild.DisabledState.CustomBorderColor = Color.DarkGray;
            bntBuild.DisabledState.FillColor = Color.White;
            bntBuild.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntBuild.Enabled = false;
            bntBuild.FillColor = Color.White;
            bntBuild.FocusedColor = Color.FromArgb(100, 170, 209);
            bntBuild.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bntBuild.ForeColor = Color.DimGray;
            bntBuild.Location = new Point(563, 186);
            bntBuild.Margin = new Padding(2);
            bntBuild.Name = "bntBuild";
            bntBuild.Size = new Size(83, 45);
            bntBuild.TabIndex = 16;
            bntBuild.Text = "Build";
            bntBuild.Click += Pack_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(45, 416);
            label1.Name = "label1";
            label1.Size = new Size(141, 32);
            label1.TabIndex = 2;
            label1.Text = "   Packager";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // progress
            // 
            progress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progress.BackColor = Color.Transparent;
            progress.BorderColor = Color.Gainsboro;
            progress.BorderRadius = 10;
            progress.BorderThickness = 2;
            progress.FillColor = Color.Transparent;
            progress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            progress.Location = new Point(192, 424);
            progress.Margin = new Padding(2);
            progress.Name = "progress";
            progress.ProgressColor = Color.White;
            progress.ProgressColor2 = Color.SlateGray;
            progress.Size = new Size(528, 24);
            progress.TabIndex = 27;
            progress.Text = "guna2ProgressBar1";
            progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            progress.Visible = false;
            // 
            // uiTestPlugin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(756, 682);
            Controls.Add(togglePublish);
            Controls.Add(progress);
            Controls.Add(guna2Panel4);
            Controls.Add(label1);
            Controls.Add(guna2Panel3);
            Controls.Add(bntBuild);
            Controls.Add(guna2Panel2);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(pnlIcon);
            Controls.Add(pnlChild);
            Controls.Add(pnlControls);
            Controls.Add(guna2Button2);
            Margin = new Padding(2);
            MinimumSize = new Size(704, 557);
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
        private Guna.UI2.WinForms.Guna2Panel pnlIcon;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private LILO_Packager.v2.Controls.DynamicToggleButton togglePublish;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private LILO_Packager.v2.Controls.DynamicToggleButton togglePirate;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button bntBuild;
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
        private Guna.UI2.WinForms.Guna2ProgressBar progress;
    }
}