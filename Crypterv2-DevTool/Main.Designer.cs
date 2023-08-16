namespace Crypterv2_DevTool
{
    partial class Main
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "12345", "State", "Library Based", "v2", "C:File", "C:File.lsf" }, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            button1 = new Button();
            lblName = new Label();
            listViewHistory = new HTAlt.WinForms.HTListView();
            ColId = new ColumnHeader();
            ColOperation = new ColumnHeader();
            label1 = new Label();
            lblCore = new Label();
            label2 = new Label();
            lblClient = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblAccess = new Label();
            lblState = new Label();
            label10 = new Label();
            lblDebug = new Label();
            label6 = new Label();
            lblVersion = new Label();
            label8 = new Label();
            label4 = new Label();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            pnlChild = new Panel();
            bntDisconnect = new Button();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            bntPlugins = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            guna2Panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(738, 20);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(128, 34);
            button1.TabIndex = 0;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(24, 24);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(164, 30);
            lblName.TabIndex = 1;
            lblName.Text = "Developer Tool";
            // 
            // listViewHistory
            // 
            listViewHistory.Alignment = ListViewAlignment.SnapToGrid;
            listViewHistory.AllowColumnReorder = true;
            listViewHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewHistory.BorderStyle = BorderStyle.None;
            listViewHistory.Columns.AddRange(new ColumnHeader[] { ColId, ColOperation });
            listViewHistory.HeaderBackColor = Color.FromArgb(235, 235, 235);
            listViewHistory.HeaderBorderThickness = 2;
            listViewHistory.HeaderForeColor = Color.Black;
            listViewHistory.HideSelection = true;
            listViewHistory.HoverSelection = true;
            listViewHistory.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listViewHistory.Location = new Point(16, 16);
            listViewHistory.Margin = new Padding(2);
            listViewHistory.MultiSelect = false;
            listViewHistory.Name = "listViewHistory";
            listViewHistory.OverlayColor = Color.DodgerBlue;
            listViewHistory.ShowItemToolTips = true;
            listViewHistory.Size = new Size(808, 376);
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
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 30);
            label1.TabIndex = 1;
            label1.Text = "Core";
            // 
            // lblCore
            // 
            lblCore.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCore.Location = new Point(128, 16);
            lblCore.Margin = new Padding(2, 0, 2, 0);
            lblCore.Name = "lblCore";
            lblCore.Size = new Size(272, 25);
            lblCore.TabIndex = 1;
            lblCore.Text = "n/a";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(640, 16);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 30);
            label2.TabIndex = 1;
            label2.Text = "via";
            // 
            // lblClient
            // 
            lblClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblClient.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblClient.Location = new Point(712, 16);
            lblClient.Margin = new Padding(2, 0, 2, 0);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(120, 25);
            lblClient.TabIndex = 1;
            lblClient.Text = "n/a";
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel1.BorderColor = SystemColors.ActiveBorder;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(lblAccess);
            guna2Panel1.Controls.Add(lblState);
            guna2Panel1.Controls.Add(lblClient);
            guna2Panel1.Controls.Add(label10);
            guna2Panel1.Controls.Add(lblDebug);
            guna2Panel1.Controls.Add(label6);
            guna2Panel1.Controls.Add(lblVersion);
            guna2Panel1.Controls.Add(label8);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(lblCore);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.FillColor = Color.Transparent;
            guna2Panel1.Location = new Point(24, 72);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(840, 120);
            guna2Panel1.TabIndex = 23;
            // 
            // lblAccess
            // 
            lblAccess.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAccess.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccess.Location = new Point(712, 80);
            lblAccess.Margin = new Padding(2, 0, 2, 0);
            lblAccess.Name = "lblAccess";
            lblAccess.Size = new Size(120, 25);
            lblAccess.TabIndex = 1;
            lblAccess.Text = "n/a";
            // 
            // lblState
            // 
            lblState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblState.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblState.Location = new Point(712, 48);
            lblState.Margin = new Padding(2, 0, 2, 0);
            lblState.Name = "lblState";
            lblState.Size = new Size(120, 25);
            lblState.TabIndex = 1;
            lblState.Text = "n/a";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(16, 80);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(96, 30);
            label10.TabIndex = 1;
            label10.Text = "Debug";
            // 
            // lblDebug
            // 
            lblDebug.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDebug.Location = new Point(128, 80);
            lblDebug.Margin = new Padding(2, 0, 2, 0);
            lblDebug.Name = "lblDebug";
            lblDebug.Size = new Size(272, 25);
            lblDebug.TabIndex = 1;
            lblDebug.Text = "n/a";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(16, 48);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 30);
            label6.TabIndex = 1;
            label6.Text = "Version";
            // 
            // lblVersion
            // 
            lblVersion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblVersion.Location = new Point(128, 48);
            lblVersion.Margin = new Padding(2, 0, 2, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(264, 25);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "n/a";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(640, 80);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(96, 30);
            label8.TabIndex = 1;
            label8.Text = "Access";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(640, 48);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 30);
            label4.TabIndex = 1;
            label4.Text = "State";
            // 
            // guna2Panel2
            // 
            guna2Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel2.BorderColor = SystemColors.ActiveBorder;
            guna2Panel2.BorderRadius = 15;
            guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel2.BorderThickness = 2;
            guna2Panel2.Controls.Add(listViewHistory);
            guna2Panel2.FillColor = Color.Transparent;
            guna2Panel2.Location = new Point(24, 288);
            guna2Panel2.Margin = new Padding(2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.Size = new Size(840, 406);
            guna2Panel2.TabIndex = 24;
            // 
            // pnlChild
            // 
            pnlChild.Location = new Point(0, 0);
            pnlChild.Margin = new Padding(2);
            pnlChild.Name = "pnlChild";
            pnlChild.Size = new Size(16, 24);
            pnlChild.TabIndex = 25;
            // 
            // bntDisconnect
            // 
            bntDisconnect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntDisconnect.Enabled = false;
            bntDisconnect.Location = new Point(600, 20);
            bntDisconnect.Margin = new Padding(2);
            bntDisconnect.Name = "bntDisconnect";
            bntDisconnect.Size = new Size(128, 34);
            bntDisconnect.TabIndex = 26;
            bntDisconnect.Text = "Disconnect";
            bntDisconnect.UseVisualStyleBackColor = true;
            bntDisconnect.Click += bntDisconnect_Click;
            // 
            // guna2Panel3
            // 
            guna2Panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel3.BorderColor = SystemColors.ActiveBorder;
            guna2Panel3.BorderRadius = 15;
            guna2Panel3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel3.BorderThickness = 2;
            guna2Panel3.Controls.Add(guna2Button4);
            guna2Panel3.Controls.Add(guna2Button2);
            guna2Panel3.Controls.Add(guna2Button1);
            guna2Panel3.Controls.Add(bntPlugins);
            guna2Panel3.FillColor = Color.Transparent;
            guna2Panel3.Location = new Point(24, 200);
            guna2Panel3.Margin = new Padding(2);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Size = new Size(840, 80);
            guna2Panel3.TabIndex = 23;
            // 
            // bntPlugins
            // 
            bntPlugins.Anchor = AnchorStyles.None;
            bntPlugins.Animated = true;
            bntPlugins.BackColor = Color.Transparent;
            bntPlugins.BorderColor = Color.Gainsboro;
            bntPlugins.BorderRadius = 20;
            bntPlugins.BorderThickness = 2;
            bntPlugins.DisabledState.BorderColor = Color.DarkGray;
            bntPlugins.DisabledState.CustomBorderColor = Color.DarkGray;
            bntPlugins.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntPlugins.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntPlugins.FillColor = Color.White;
            bntPlugins.FocusedColor = Color.FromArgb(100, 170, 209);
            bntPlugins.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            bntPlugins.ForeColor = Color.Black;
            bntPlugins.Location = new Point(80, 16);
            bntPlugins.Margin = new Padding(2);
            bntPlugins.Name = "bntPlugins";
            bntPlugins.Size = new Size(160, 48);
            bntPlugins.TabIndex = 16;
            bntPlugins.Text = "Plugins";
            bntPlugins.Click += bntPlugins_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.None;
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
            guna2Button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(256, 16);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(160, 48);
            guna2Button1.TabIndex = 16;
            guna2Button1.Text = "n/a";
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.None;
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
            guna2Button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Location = new Point(432, 16);
            guna2Button2.Margin = new Padding(2);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(160, 48);
            guna2Button2.TabIndex = 16;
            guna2Button2.Text = "n/a";
            // 
            // guna2Button4
            // 
            guna2Button4.Anchor = AnchorStyles.None;
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
            guna2Button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button4.ForeColor = Color.Black;
            guna2Button4.Location = new Point(608, 16);
            guna2Button4.Margin = new Padding(2);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.Size = new Size(160, 48);
            guna2Button4.TabIndex = 16;
            guna2Button4.Text = "n/a";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(882, 710);
            Controls.Add(guna2Panel3);
            Controls.Add(bntDisconnect);
            Controls.Add(pnlChild);
            Controls.Add(guna2Panel2);
            Controls.Add(guna2Panel1);
            Controls.Add(lblName);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MinimumSize = new Size(877, 686);
            Name = "Main";
            Text = "DevTool - Crypterv2";
            Load += Main_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            guna2Panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblName;
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
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button bntPlugins;
    }
}
