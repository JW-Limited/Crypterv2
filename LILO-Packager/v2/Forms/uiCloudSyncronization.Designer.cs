namespace LILO_Packager.v2.Forms
{
    partial class uiCloudSyncronization
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "12345", "State", "Library Based", "v2", "C:File", "C:File.lsf" }, -1);
            ListViewItem listViewItem2 = new ListViewItem("sdfsdsds");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiCloudSyncronization));
            sPanel1 = new Sipaa.Framework.SPanel();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            lblVersion = new Label();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            lblCloud = new Label();
            lblNetwork = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            sPanel2 = new Sipaa.Framework.SPanel();
            label8 = new Label();
            label9 = new Label();
            sPanel3 = new Sipaa.Framework.SPanel();
            label7 = new Label();
            label10 = new Label();
            panel2 = new Panel();
            bntSync = new Guna.UI2.WinForms.Guna2Button();
            prgSynced = new Guna.UI2.WinForms.Guna2ProgressBar();
            pnlCounter = new Guna.UI2.WinForms.Guna2Panel();
            label13 = new Label();
            lblSyncedFiles = new Label();
            lblLocalFiles = new Label();
            pnlSide = new Guna.UI2.WinForms.Guna2Panel();
            listViewFiles = new HTAlt.WinForms.HTListView();
            columnHeader1 = new ColumnHeader();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            lblAllInCloud = new Label();
            lblStatus = new Label();
            label11 = new Label();
            prgMiniProgress = new Guna.UI2.WinForms.Guna2ProgressBar();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel3.SuspendLayout();
            guna2Panel1.SuspendLayout();
            pnlCounter.SuspendLayout();
            pnlSide.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sPanel1
            // 
            sPanel1.BackColor = Color.White;
            sPanel1.BackgroundImage = Properties.Resources.Screenshot_2023_10_13_052005;
            sPanel1.BackgroundImageLayout = ImageLayout.Zoom;
            sPanel1.BorderColor = Color.Gainsboro;
            sPanel1.BorderRadius = 20;
            sPanel1.BorderSize = 0;
            sPanel1.ForeColor = Color.White;
            sPanel1.Location = new Point(24, 32);
            sPanel1.Margin = new Padding(4);
            sPanel1.Name = "sPanel1";
            sPanel1.Size = new Size(96, 88);
            sPanel1.TabIndex = 42;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(16, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 44;
            label2.Text = "powered by ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(23, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 40);
            label1.TabIndex = 43;
            label1.Text = "JW Limited ©️ 2023";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(136, 40);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(224, 40);
            label4.TabIndex = 43;
            label4.Text = "LILO Sync";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblVersion
            // 
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblVersion.ForeColor = Color.Silver;
            lblVersion.Location = new Point(136, 80);
            lblVersion.Margin = new Padding(4, 0, 4, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(184, 22);
            lblVersion.TabIndex = 44;
            lblVersion.Text = "VERSION\r\n";
            lblVersion.TextAlign = ContentAlignment.BottomLeft;
            // 
            // guna2Panel3
            // 
            guna2Panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            guna2Panel3.BackColor = Color.White;
            guna2Panel3.BorderColor = Color.Gainsboro;
            guna2Panel3.BorderRadius = 15;
            guna2Panel3.BorderThickness = 2;
            guna2Panel3.Controls.Add(label2);
            guna2Panel3.Controls.Add(label1);
            guna2Panel3.FillColor = Color.WhiteSmoke;
            guna2Panel3.Location = new Point(24, 635);
            guna2Panel3.Margin = new Padding(2);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Size = new Size(304, 80);
            guna2Panel3.TabIndex = 37;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.HighlightText;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(guna2Button2);
            guna2Panel1.Controls.Add(lblCloud);
            guna2Panel1.Controls.Add(lblNetwork);
            guna2Panel1.Controls.Add(panel1);
            guna2Panel1.Controls.Add(label6);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(24, 168);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(304, 192);
            guna2Panel1.TabIndex = 37;
            // 
            // guna2Button2
            // 
            guna2Button2.Animated = true;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderColor = Color.Gainsboro;
            guna2Button2.BorderRadius = 10;
            guna2Button2.BorderThickness = 2;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.White;
            guna2Button2.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2Button2.ForeColor = Color.DimGray;
            guna2Button2.Location = new Point(16, 136);
            guna2Button2.Margin = new Padding(2);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.BorderRadius = 15;
            guna2Button2.ShadowDecoration.Color = Color.LightGray;
            guna2Button2.ShadowDecoration.Depth = 20;
            guna2Button2.Size = new Size(272, 40);
            guna2Button2.TabIndex = 35;
            guna2Button2.Text = "Check Status";
            guna2Button2.Click += bntClick_Chekc;
            // 
            // lblCloud
            // 
            lblCloud.BackColor = Color.Transparent;
            lblCloud.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCloud.ForeColor = Color.DimGray;
            lblCloud.Location = new Point(160, 88);
            lblCloud.Margin = new Padding(4, 0, 4, 0);
            lblCloud.Name = "lblCloud";
            lblCloud.Size = new Size(112, 30);
            lblCloud.TabIndex = 44;
            lblCloud.Text = "n/a";
            lblCloud.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNetwork
            // 
            lblNetwork.BackColor = Color.Transparent;
            lblNetwork.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNetwork.ForeColor = Color.DimGray;
            lblNetwork.Location = new Point(160, 40);
            lblNetwork.Margin = new Padding(4, 0, 4, 0);
            lblNetwork.Name = "lblNetwork";
            lblNetwork.Size = new Size(112, 30);
            lblNetwork.TabIndex = 44;
            lblNetwork.Text = "n/a";
            lblNetwork.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(24, 72);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 16);
            panel1.TabIndex = 36;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(40, 88);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(136, 30);
            label6.TabIndex = 44;
            label6.Text = "Cloud";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(40, 40);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 30);
            label3.TabIndex = 44;
            label3.Text = "Internet\r\n";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(40, 152);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(136, 40);
            label5.TabIndex = 43;
            label5.Text = "    Checklist";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sPanel2
            // 
            sPanel2.BackColor = Color.RoyalBlue;
            sPanel2.BackgroundImageLayout = ImageLayout.Zoom;
            sPanel2.BorderColor = Color.Gainsboro;
            sPanel2.BorderRadius = 5;
            sPanel2.BorderSize = 2;
            sPanel2.ForeColor = Color.White;
            sPanel2.Location = new Point(40, 128);
            sPanel2.Margin = new Padding(4);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(24, 24);
            sPanel2.TabIndex = 42;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(72, 128);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(136, 24);
            label8.TabIndex = 44;
            label8.Text = "Cloud Synced";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(288, 128);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(136, 24);
            label9.TabIndex = 44;
            label9.Text = "Hard Disk";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sPanel3
            // 
            sPanel3.BackColor = Color.DarkOrange;
            sPanel3.BackgroundImageLayout = ImageLayout.Zoom;
            sPanel3.BorderColor = Color.Gainsboro;
            sPanel3.BorderRadius = 5;
            sPanel3.BorderSize = 2;
            sPanel3.ForeColor = Color.White;
            sPanel3.Location = new Point(256, 128);
            sPanel3.Margin = new Padding(4);
            sPanel3.Name = "sPanel3";
            sPanel3.Size = new Size(24, 24);
            sPanel3.TabIndex = 42;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(32, 24);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(320, 46);
            label7.TabIndex = 44;
            label7.Text = "Local Files";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(32, 224);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(448, 38);
            label10.TabIndex = 44;
            label10.Text = "Sync Query";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(24, 184);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(691, 16);
            panel2.TabIndex = 36;
            // 
            // bntSync
            // 
            bntSync.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bntSync.Animated = true;
            bntSync.BackColor = Color.Transparent;
            bntSync.BorderColor = Color.Gainsboro;
            bntSync.BorderRadius = 12;
            bntSync.BorderThickness = 2;
            bntSync.DisabledState.BorderColor = Color.DarkGray;
            bntSync.DisabledState.CustomBorderColor = Color.DarkGray;
            bntSync.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntSync.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntSync.FillColor = Color.White;
            bntSync.FocusedColor = Color.FromArgb(100, 170, 209);
            bntSync.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bntSync.ForeColor = Color.DimGray;
            bntSync.Location = new Point(579, 627);
            bntSync.Margin = new Padding(2);
            bntSync.Name = "bntSync";
            bntSync.ShadowDecoration.BorderRadius = 15;
            bntSync.ShadowDecoration.Color = Color.LightGray;
            bntSync.ShadowDecoration.Depth = 20;
            bntSync.ShadowDecoration.Enabled = true;
            bntSync.Size = new Size(136, 40);
            bntSync.TabIndex = 35;
            bntSync.Text = "Sync";
            bntSync.Click += guna2Button1_Click;
            // 
            // prgSynced
            // 
            prgSynced.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            prgSynced.BackColor = Color.Transparent;
            prgSynced.BorderColor = Color.Gainsboro;
            prgSynced.BorderRadius = 6;
            prgSynced.BorderThickness = 2;
            prgSynced.FillColor = Color.DarkOrange;
            prgSynced.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            prgSynced.Location = new Point(32, 88);
            prgSynced.Margin = new Padding(2);
            prgSynced.Name = "prgSynced";
            prgSynced.ProgressColor = Color.RoyalBlue;
            prgSynced.ProgressColor2 = Color.RoyalBlue;
            prgSynced.ShadowDecoration.Depth = 20;
            prgSynced.Size = new Size(683, 24);
            prgSynced.TabIndex = 45;
            prgSynced.Text = "guna2ProgressBar1";
            prgSynced.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            prgSynced.Value = 7;
            // 
            // pnlCounter
            // 
            pnlCounter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlCounter.BackColor = Color.Transparent;
            pnlCounter.BorderColor = Color.Gainsboro;
            pnlCounter.BorderRadius = 10;
            pnlCounter.BorderThickness = 2;
            pnlCounter.Controls.Add(label13);
            pnlCounter.Controls.Add(lblSyncedFiles);
            pnlCounter.Controls.Add(lblLocalFiles);
            pnlCounter.FillColor = Color.White;
            pnlCounter.Location = new Point(619, 32);
            pnlCounter.Margin = new Padding(2);
            pnlCounter.Name = "pnlCounter";
            pnlCounter.ShadowDecoration.BorderRadius = 10;
            pnlCounter.ShadowDecoration.Color = Color.LightGray;
            pnlCounter.ShadowDecoration.Depth = 20;
            pnlCounter.Size = new Size(96, 32);
            pnlCounter.TabIndex = 37;
            // 
            // label13
            // 
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(40, 0);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(16, 30);
            label13.TabIndex = 44;
            label13.Text = "/";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSyncedFiles
            // 
            lblSyncedFiles.BackColor = Color.Transparent;
            lblSyncedFiles.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSyncedFiles.ForeColor = Color.DimGray;
            lblSyncedFiles.Location = new Point(0, 0);
            lblSyncedFiles.Margin = new Padding(4, 0, 4, 0);
            lblSyncedFiles.Name = "lblSyncedFiles";
            lblSyncedFiles.Size = new Size(48, 30);
            lblSyncedFiles.TabIndex = 44;
            lblSyncedFiles.Text = "0";
            lblSyncedFiles.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLocalFiles
            // 
            lblLocalFiles.BackColor = Color.Transparent;
            lblLocalFiles.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLocalFiles.ForeColor = Color.DimGray;
            lblLocalFiles.Location = new Point(48, 0);
            lblLocalFiles.Margin = new Padding(4, 0, 4, 0);
            lblLocalFiles.Name = "lblLocalFiles";
            lblLocalFiles.Size = new Size(48, 30);
            lblLocalFiles.TabIndex = 44;
            lblLocalFiles.Text = "0";
            lblLocalFiles.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSide
            // 
            pnlSide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSide.BackColor = Color.Transparent;
            pnlSide.BorderColor = Color.Gainsboro;
            pnlSide.BorderRadius = 15;
            pnlSide.BorderThickness = 2;
            pnlSide.Controls.Add(listViewFiles);
            pnlSide.Controls.Add(guna2Panel2);
            pnlSide.Controls.Add(pnlCounter);
            pnlSide.Controls.Add(lblStatus);
            pnlSide.Controls.Add(label11);
            pnlSide.Controls.Add(prgMiniProgress);
            pnlSide.Controls.Add(prgSynced);
            pnlSide.Controls.Add(bntSync);
            pnlSide.Controls.Add(panel2);
            pnlSide.Controls.Add(label10);
            pnlSide.Controls.Add(label7);
            pnlSide.Controls.Add(sPanel3);
            pnlSide.Controls.Add(label9);
            pnlSide.Controls.Add(label8);
            pnlSide.Controls.Add(sPanel2);
            pnlSide.FillColor = Color.White;
            pnlSide.Location = new Point(368, 24);
            pnlSide.Margin = new Padding(2);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(739, 691);
            pnlSide.TabIndex = 16;
            pnlSide.Paint += pnlSide_Paint;
            // 
            // listViewFiles
            // 
            listViewFiles.Activation = ItemActivation.OneClick;
            listViewFiles.Alignment = ListViewAlignment.Default;
            listViewFiles.AllowColumnReorder = true;
            listViewFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewFiles.BorderStyle = BorderStyle.None;
            listViewFiles.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listViewFiles.FullRowSelect = true;
            listViewFiles.HeaderBackColor = Color.FromArgb(235, 235, 235);
            listViewFiles.HeaderBorderThickness = 2;
            listViewFiles.HeaderForeColor = Color.Black;
            listViewFiles.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewFiles.HideSelection = true;
            listViewFiles.HotTracking = true;
            listViewFiles.HoverSelection = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewFiles.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listViewFiles.Location = new Point(32, 272);
            listViewFiles.Margin = new Padding(2);
            listViewFiles.MultiSelect = false;
            listViewFiles.Name = "listViewFiles";
            listViewFiles.OverlayColor = Color.DodgerBlue;
            listViewFiles.ShowItemToolTips = true;
            listViewFiles.Size = new Size(683, 339);
            listViewFiles.TabIndex = 46;
            listViewFiles.UseCompatibleStateImageBehavior = false;
            listViewFiles.View = View.Tile;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Files";
            columnHeader1.Width = 500;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.BorderColor = Color.LightSteelBlue;
            guna2Panel2.BorderRadius = 10;
            guna2Panel2.BorderThickness = 2;
            guna2Panel2.Controls.Add(lblAllInCloud);
            guna2Panel2.FillColor = Color.RoyalBlue;
            guna2Panel2.Location = new Point(552, 32);
            guna2Panel2.Margin = new Padding(2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.BorderRadius = 10;
            guna2Panel2.ShadowDecoration.Color = Color.LightGray;
            guna2Panel2.ShadowDecoration.Depth = 20;
            guna2Panel2.Size = new Size(48, 32);
            guna2Panel2.TabIndex = 37;
            // 
            // lblAllInCloud
            // 
            lblAllInCloud.BackColor = Color.Transparent;
            lblAllInCloud.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAllInCloud.ForeColor = Color.White;
            lblAllInCloud.Location = new Point(0, 0);
            lblAllInCloud.Margin = new Padding(4, 0, 4, 0);
            lblAllInCloud.Name = "lblAllInCloud";
            lblAllInCloud.Size = new Size(48, 30);
            lblAllInCloud.TabIndex = 44;
            lblAllInCloud.Text = "0";
            lblAllInCloud.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.Silver;
            lblStatus.Location = new Point(32, 627);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(531, 40);
            lblStatus.TabIndex = 44;
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(360, 24);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(128, 48);
            label11.TabIndex = 44;
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // prgMiniProgress
            // 
            prgMiniProgress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            prgMiniProgress.BackColor = Color.Transparent;
            prgMiniProgress.BorderColor = Color.Gainsboro;
            prgMiniProgress.BorderRadius = 9;
            prgMiniProgress.BorderThickness = 2;
            prgMiniProgress.FillColor = Color.White;
            prgMiniProgress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            prgMiniProgress.Location = new Point(352, 232);
            prgMiniProgress.Margin = new Padding(2);
            prgMiniProgress.Name = "prgMiniProgress";
            prgMiniProgress.ProgressColor = Color.SteelBlue;
            prgMiniProgress.ProgressColor2 = Color.RoyalBlue;
            prgMiniProgress.ShadowDecoration.Depth = 20;
            prgMiniProgress.Size = new Size(363, 24);
            prgMiniProgress.TabIndex = 45;
            prgMiniProgress.Text = "guna2ProgressBar1";
            prgMiniProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            prgMiniProgress.Value = 70;
            prgMiniProgress.Visible = false;
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.Gainsboro;
            guna2Button1.BorderRadius = 12;
            guna2Button1.BorderThickness = 2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.DimGray;
            guna2Button1.Image = Properties.Resources.theme_manager;
            guna2Button1.ImageAlign = HorizontalAlignment.Left;
            guna2Button1.ImageOffset = new Point(10, 0);
            guna2Button1.ImageSize = new Size(25, 25);
            guna2Button1.Location = new Point(24, 384);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.BorderRadius = 15;
            guna2Button1.ShadowDecoration.Color = Color.LightGray;
            guna2Button1.ShadowDecoration.Depth = 20;
            guna2Button1.Size = new Size(304, 56);
            guna2Button1.TabIndex = 35;
            guna2Button1.Text = "    My Files";
            guna2Button1.TextAlign = HorizontalAlignment.Left;
            guna2Button1.Click += myFiles;
            // 
            // guna2Button3
            // 
            guna2Button3.Animated = true;
            guna2Button3.BackColor = Color.Transparent;
            guna2Button3.BorderColor = Color.Gainsboro;
            guna2Button3.BorderRadius = 12;
            guna2Button3.BorderThickness = 2;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.White;
            guna2Button3.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2Button3.ForeColor = Color.DimGray;
            guna2Button3.Image = Properties.Resources.icons8_share_240;
            guna2Button3.ImageAlign = HorizontalAlignment.Left;
            guna2Button3.ImageOffset = new Point(10, 0);
            guna2Button3.ImageSize = new Size(25, 25);
            guna2Button3.Location = new Point(24, 456);
            guna2Button3.Margin = new Padding(2);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.BorderRadius = 15;
            guna2Button3.ShadowDecoration.Color = Color.LightGray;
            guna2Button3.ShadowDecoration.Depth = 20;
            guna2Button3.Size = new Size(304, 56);
            guna2Button3.TabIndex = 35;
            guna2Button3.Text = "    Sharemanager";
            guna2Button3.TextAlign = HorizontalAlignment.Left;
            guna2Button3.Click += ShareManager_Click;
            // 
            // uiCloudSyncronization
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1134, 739);
            Controls.Add(guna2Button3);
            Controls.Add(guna2Button1);
            Controls.Add(lblVersion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(sPanel1);
            Controls.Add(pnlSide);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2Panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(921, 608);
            Name = "uiCloudSyncronization";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MainHost - Cloud";
            Load += uiCloudSyncronization_Load;
            guna2Panel3.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            pnlCounter.ResumeLayout(false);
            pnlSide.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sipaa.Framework.SPanel sPanel1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label lblVersion;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label lblCloud;
        private Label lblNetwork;
        private Panel panel1;
        private Sipaa.Framework.SPanel sPanel2;
        private Label label8;
        private Label label9;
        private Sipaa.Framework.SPanel sPanel3;
        private Label label7;
        private Label label10;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button bntSync;
        private Guna.UI2.WinForms.Guna2ProgressBar prgSynced;
        private Guna.UI2.WinForms.Guna2Panel pnlCounter;
        private Label label13;
        private Label lblSyncedFiles;
        private Label lblLocalFiles;
        private Guna.UI2.WinForms.Guna2Panel pnlSide;
        private HTAlt.WinForms.HTListView listViewFiles;
        private ColumnHeader columnHeader1;
        private Label label11;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label lblAllInCloud;
        private Guna.UI2.WinForms.Guna2ProgressBar prgMiniProgress;
        private Label lblStatus;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}