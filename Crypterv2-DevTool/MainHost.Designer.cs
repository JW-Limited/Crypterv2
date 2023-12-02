namespace Crypterv2_DevTool
{
    partial class MainHost
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "12345", "State", "Library Based", "v2", "C:File", "C:File.lsf" }, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainHost));
            button1 = new Button();
            listViewHistory = new HTAlt.WinForms.HTListView();
            ColId = new ColumnHeader();
            ColOperation = new ColumnHeader();
            label1 = new Label();
            lblCore = new Label();
            label2 = new Label();
            lblClient = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            panel1 = new Panel();
            lblAccess = new Label();
            lblDebug = new Label();
            lblVersion = new Label();
            lblState = new Label();
            label10 = new Label();
            label6 = new Label();
            label8 = new Label();
            label4 = new Label();
            bntDisconnect = new Button();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            pnlChild = new Panel();
            guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            sPanel1 = new Sipaa.Framework.SPanel();
            lblText = new Label();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            lblBottom = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            pnlControls = new Guna.UI2.WinForms.Guna2Panel();
            lblDirectory = new Label();
            label11 = new Label();
            pnlErrorConnection = new Panel();
            label9 = new Label();
            label5 = new Label();
            label3 = new Label();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            guna2Panel5.SuspendLayout();
            sPanel1.SuspendLayout();
            guna2Panel3.SuspendLayout();
            pnlControls.SuspendLayout();
            pnlErrorConnection.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(750, 24);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(240, 34);
            button1.TabIndex = 0;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listViewHistory
            // 
            listViewHistory.Alignment = ListViewAlignment.SnapToGrid;
            listViewHistory.AllowColumnReorder = true;
            listViewHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewHistory.BorderStyle = BorderStyle.None;
            listViewHistory.Columns.AddRange(new ColumnHeader[] { ColId, ColOperation });
            listViewHistory.FullRowSelect = true;
            listViewHistory.HeaderBackColor = Color.FromArgb(235, 235, 235);
            listViewHistory.HeaderBorderThickness = 2;
            listViewHistory.HeaderForeColor = Color.Black;
            listViewHistory.HideSelection = true;
            listViewHistory.HoverSelection = true;
            listViewHistory.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listViewHistory.Location = new Point(16, 16);
            listViewHistory.Margin = new Padding(2);
            listViewHistory.MultiSelect = false;
            listViewHistory.Name = "listViewHistory";
            listViewHistory.OverlayColor = Color.DodgerBlue;
            listViewHistory.ShowItemToolTips = true;
            listViewHistory.Size = new Size(976, 774);
            listViewHistory.Sorting = SortOrder.Ascending;
            listViewHistory.TabIndex = 2;
            listViewHistory.UseCompatibleStateImageBehavior = false;
            listViewHistory.View = View.Details;
            listViewHistory.DoubleClick += listViewHistory_DoubleClick;
            // 
            // ColId
            // 
            ColId.Tag = "ID";
            ColId.Text = "Feature";
            ColId.Width = 590;
            // 
            // ColOperation
            // 
            ColOperation.Tag = "State";
            ColOperation.Text = "State";
            ColOperation.Width = 160;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(24, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 30);
            label1.TabIndex = 1;
            label1.Text = "Core";
            // 
            // lblCore
            // 
            lblCore.AutoEllipsis = true;
            lblCore.BackColor = Color.White;
            lblCore.Font = new Font("Segoe UI", 9F);
            lblCore.Location = new Point(104, 24);
            lblCore.Margin = new Padding(2, 0, 2, 0);
            lblCore.Name = "lblCore";
            lblCore.Size = new Size(168, 25);
            lblCore.TabIndex = 1;
            lblCore.Text = "n/a";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(24, 144);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 30);
            label2.TabIndex = 1;
            label2.Text = "via";
            // 
            // lblClient
            // 
            lblClient.BackColor = Color.White;
            lblClient.Font = new Font("Segoe UI", 9F);
            lblClient.Location = new Point(104, 144);
            lblClient.Margin = new Padding(2, 0, 2, 0);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(168, 25);
            lblClient.TabIndex = 1;
            lblClient.Text = "n/a";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.Control;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(panel1);
            guna2Panel1.Controls.Add(lblAccess);
            guna2Panel1.Controls.Add(lblDebug);
            guna2Panel1.Controls.Add(lblVersion);
            guna2Panel1.Controls.Add(lblState);
            guna2Panel1.Controls.Add(lblCore);
            guna2Panel1.Controls.Add(lblClient);
            guna2Panel1.Controls.Add(label10);
            guna2Panel1.Controls.Add(label6);
            guna2Panel1.Controls.Add(label8);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(24, 144);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(288, 256);
            guna2Panel1.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Crypterv2.DevTool.Properties.Resources.seüerater;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(24, 120);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 16);
            panel1.TabIndex = 27;
            // 
            // lblAccess
            // 
            lblAccess.BackColor = Color.White;
            lblAccess.Font = new Font("Segoe UI", 9F);
            lblAccess.Location = new Point(104, 208);
            lblAccess.Margin = new Padding(2, 0, 2, 0);
            lblAccess.Name = "lblAccess";
            lblAccess.Size = new Size(168, 25);
            lblAccess.TabIndex = 1;
            lblAccess.Text = "n/a";
            // 
            // lblDebug
            // 
            lblDebug.AutoEllipsis = true;
            lblDebug.BackColor = Color.White;
            lblDebug.Font = new Font("Segoe UI", 9F);
            lblDebug.Location = new Point(104, 88);
            lblDebug.Margin = new Padding(2, 0, 2, 0);
            lblDebug.Name = "lblDebug";
            lblDebug.Size = new Size(168, 25);
            lblDebug.TabIndex = 1;
            lblDebug.Text = "n/a";
            // 
            // lblVersion
            // 
            lblVersion.AutoEllipsis = true;
            lblVersion.BackColor = Color.White;
            lblVersion.Font = new Font("Segoe UI", 9F);
            lblVersion.Location = new Point(104, 56);
            lblVersion.Margin = new Padding(2, 0, 2, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(168, 25);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "n/a";
            // 
            // lblState
            // 
            lblState.BackColor = Color.White;
            lblState.Font = new Font("Segoe UI", 9F);
            lblState.Location = new Point(104, 176);
            lblState.Margin = new Padding(2, 0, 2, 0);
            lblState.Name = "lblState";
            lblState.Size = new Size(168, 25);
            lblState.TabIndex = 1;
            lblState.Text = "n/a";
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label10.Location = new Point(24, 88);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(96, 30);
            label10.TabIndex = 1;
            label10.Text = "Debug";
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(24, 56);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 30);
            label6.TabIndex = 1;
            label6.Text = "Version";
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(24, 208);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(152, 30);
            label8.TabIndex = 1;
            label8.Text = "Access";
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(24, 176);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 30);
            label4.TabIndex = 1;
            label4.Text = "State";
            // 
            // bntDisconnect
            // 
            bntDisconnect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntDisconnect.Location = new Point(750, 24);
            bntDisconnect.Margin = new Padding(2);
            bntDisconnect.Name = "bntDisconnect";
            bntDisconnect.Size = new Size(240, 34);
            bntDisconnect.TabIndex = 26;
            bntDisconnect.Text = "Disconnect";
            bntDisconnect.UseVisualStyleBackColor = true;
            bntDisconnect.Click += bntDisconnect_Click;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.BorderColor = Color.Gainsboro;
            guna2Panel2.BorderRadius = 15;
            guna2Panel2.BorderThickness = 2;
            guna2Panel2.Controls.Add(listViewHistory);
            guna2Panel2.FillColor = Color.Transparent;
            guna2Panel2.Location = new Point(360, 144);
            guna2Panel2.Margin = new Padding(2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.Size = new Size(1008, 804);
            guna2Panel2.TabIndex = 24;
            // 
            // pnlChild
            // 
            pnlChild.Location = new Point(344, 8);
            pnlChild.Margin = new Padding(2);
            pnlChild.Name = "pnlChild";
            pnlChild.Size = new Size(16, 24);
            pnlChild.TabIndex = 25;
            // 
            // guna2Panel5
            // 
            guna2Panel5.BackColor = SystemColors.Control;
            guna2Panel5.BorderColor = SystemColors.ActiveBorder;
            guna2Panel5.BorderRadius = 15;
            guna2Panel5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel5.Controls.Add(sPanel1);
            guna2Panel5.Controls.Add(guna2Panel3);
            guna2Panel5.Controls.Add(guna2Panel1);
            guna2Panel5.Controls.Add(guna2Button1);
            guna2Panel5.Controls.Add(guna2Button5);
            guna2Panel5.Dock = DockStyle.Left;
            guna2Panel5.FillColor = Color.Transparent;
            guna2Panel5.Location = new Point(0, 0);
            guna2Panel5.Margin = new Padding(2);
            guna2Panel5.Name = "guna2Panel5";
            guna2Panel5.Size = new Size(336, 972);
            guna2Panel5.TabIndex = 23;
            // 
            // sPanel1
            // 
            sPanel1.BackColor = Color.Black;
            sPanel1.BackgroundImage = (Image)resources.GetObject("sPanel1.BackgroundImage");
            sPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel1.BorderColor = Color.Black;
            sPanel1.BorderRadius = 20;
            sPanel1.BorderSize = 0;
            sPanel1.Controls.Add(lblText);
            sPanel1.ForeColor = Color.White;
            sPanel1.Location = new Point(24, 32);
            sPanel1.Margin = new Padding(4);
            sPanel1.Name = "sPanel1";
            sPanel1.Size = new Size(288, 88);
            sPanel1.TabIndex = 27;
            // 
            // lblText
            // 
            lblText.BackColor = Color.Transparent;
            lblText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblText.ForeColor = Color.White;
            lblText.Location = new Point(8, 0);
            lblText.Margin = new Padding(4, 0, 4, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(160, 88);
            lblText.TabIndex = 1;
            lblText.Text = "DevTool";
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel3
            // 
            guna2Panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            guna2Panel3.BackColor = SystemColors.Control;
            guna2Panel3.BorderColor = Color.Gainsboro;
            guna2Panel3.BorderRadius = 15;
            guna2Panel3.BorderThickness = 2;
            guna2Panel3.Controls.Add(lblBottom);
            guna2Panel3.FillColor = Color.White;
            guna2Panel3.Location = new Point(24, 872);
            guna2Panel3.Margin = new Padding(2);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Size = new Size(288, 80);
            guna2Panel3.TabIndex = 23;
            // 
            // lblBottom
            // 
            lblBottom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblBottom.BackColor = Color.Transparent;
            lblBottom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBottom.ForeColor = Color.DarkGray;
            lblBottom.Location = new Point(24, 8);
            lblBottom.Margin = new Padding(4, 0, 4, 0);
            lblBottom.Name = "lblBottom";
            lblBottom.Size = new Size(280, 64);
            lblBottom.TabIndex = 1;
            lblBottom.Text = "Version: 0.11-dev_build\r\nJW Limited © 2023";
            lblBottom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top;
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.Gainsboro;
            guna2Button1.BorderRadius = 20;
            guna2Button1.BorderThickness = 2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Image = Crypterv2.DevTool.Properties.Resources.icons8_u_shaped_style_96;
            guna2Button1.ImageAlign = HorizontalAlignment.Left;
            guna2Button1.ImageOffset = new Point(10, 0);
            guna2Button1.ImageSize = new Size(35, 35);
            guna2Button1.Location = new Point(24, 520);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(288, 80);
            guna2Button1.TabIndex = 16;
            guna2Button1.Text = "  Packages";
            guna2Button1.TextAlign = HorizontalAlignment.Left;
            guna2Button1.Click += bntPackages_Click;
            // 
            // guna2Button5
            // 
            guna2Button5.Anchor = AnchorStyles.Top;
            guna2Button5.Animated = true;
            guna2Button5.BackColor = Color.Transparent;
            guna2Button5.BorderColor = Color.Gainsboro;
            guna2Button5.BorderRadius = 20;
            guna2Button5.BorderThickness = 2;
            guna2Button5.DisabledState.BorderColor = Color.DarkGray;
            guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button5.FillColor = Color.White;
            guna2Button5.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            guna2Button5.ForeColor = Color.Black;
            guna2Button5.Image = Crypterv2.DevTool.Properties.Resources.icons8_bursts_96;
            guna2Button5.ImageAlign = HorizontalAlignment.Left;
            guna2Button5.ImageOffset = new Point(10, 0);
            guna2Button5.ImageSize = new Size(35, 35);
            guna2Button5.Location = new Point(24, 424);
            guna2Button5.Margin = new Padding(2);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.Size = new Size(288, 80);
            guna2Button5.TabIndex = 16;
            guna2Button5.Text = "  Plugins";
            guna2Button5.TextAlign = HorizontalAlignment.Left;
            guna2Button5.Click += bntPlugins_Click;
            // 
            // pnlControls
            // 
            pnlControls.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlControls.BackColor = Color.White;
            pnlControls.BorderColor = Color.Gainsboro;
            pnlControls.BorderRadius = 20;
            pnlControls.BorderThickness = 2;
            pnlControls.Controls.Add(lblDirectory);
            pnlControls.Controls.Add(label11);
            pnlControls.Controls.Add(bntDisconnect);
            pnlControls.Controls.Add(button1);
            pnlControls.FillColor = SystemColors.ButtonHighlight;
            pnlControls.Location = new Point(360, 32);
            pnlControls.Margin = new Padding(2);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new Size(1008, 80);
            pnlControls.TabIndex = 26;
            // 
            // lblDirectory
            // 
            lblDirectory.Anchor = AnchorStyles.Left;
            lblDirectory.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDirectory.ForeColor = SystemColors.ControlDark;
            lblDirectory.Location = new Point(264, 16);
            lblDirectory.Margin = new Padding(2, 0, 2, 0);
            lblDirectory.Name = "lblDirectory";
            lblDirectory.Size = new Size(344, 48);
            lblDirectory.TabIndex = 28;
            lblDirectory.Text = "En/Disable features in Crypterv2.";
            lblDirectory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(0, 0);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(256, 80);
            label11.TabIndex = 1;
            label11.Text = "FeatureManager";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlErrorConnection
            // 
            pnlErrorConnection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlErrorConnection.Controls.Add(label9);
            pnlErrorConnection.Controls.Add(label5);
            pnlErrorConnection.Controls.Add(label3);
            pnlErrorConnection.Location = new Point(350, 128);
            pnlErrorConnection.Margin = new Padding(2);
            pnlErrorConnection.Name = "pnlErrorConnection";
            pnlErrorConnection.Size = new Size(1020, 822);
            pnlErrorConnection.TabIndex = 25;
            pnlErrorConnection.Visible = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.AppWorkspace;
            label9.Location = new Point(152, 364);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(776, 240);
            label9.TabIndex = 28;
            label9.Text = resources.GetString("label9.Text");
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(152, 308);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(768, 32);
            label5.TabIndex = 28;
            label5.Text = "Error: Failed to establish a TCP connection to the Crypter-DevPort service.";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(152, 268);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(552, 48);
            label3.TabIndex = 28;
            label3.Text = "DevTools Connection Failure";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainHost
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1389, 972);
            Controls.Add(pnlControls);
            Controls.Add(guna2Panel5);
            Controls.Add(pnlErrorConnection);
            Controls.Add(pnlChild);
            Controls.Add(guna2Panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MinimumSize = new Size(1406, 1017);
            Name = "MainHost";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DevTool - Crypterv2";
            Load += Main_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            guna2Panel5.ResumeLayout(false);
            sPanel1.ResumeLayout(false);
            guna2Panel3.ResumeLayout(false);
            pnlControls.ResumeLayout(false);
            pnlErrorConnection.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private HTAlt.WinForms.HTListView listViewHistory;
        private ColumnHeader ColId;
        private ColumnHeader ColOperation;
        private Label label1;
        private Label lblCore;
        private Label label2;
        private Label lblClient;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblAccess;
        private Label lblState;
        private Label label10;
        private Label lblDebug;
        private Label label6;
        private Label lblVersion;
        private Label label8;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Panel pnlChild;
        private Button bntDisconnect;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Sipaa.Framework.SPanel sPanel1;
        private Label lblText;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel pnlControls;
        private Label lblDirectory;
        private Panel pnlErrorConnection;
        private Label label5;
        private Label label3;
        private Label label9;
        private Label lblBottom;
        private Label label11;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
