namespace LILO_Packager.v2.Forms
{
    partial class uiPluginManager
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
            components = new System.ComponentModel.Container();
            pluginEntryBindingSource = new BindingSource(components);
            sPanel2 = new Sipaa.Framework.SPanel();
            bntCancel = new Guna.UI2.WinForms.Guna2Button();
            lblText = new Label();
            pluginEntryBindingSource1 = new BindingSource(components);
            tabControl = new HTAlt.WinForms.HTTabControl();
            tbDefault = new TabPage();
            lblName = new Label();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            listViewUpdates = new HTAlt.WinForms.HTListView();
            label6 = new Label();
            listViewBerechtigungen = new HTAlt.WinForms.HTListView();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblAuther = new Label();
            lblSize = new Label();
            lblVersion = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            imgImage = new Guna.UI2.WinForms.Guna2Panel();
            pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            bntPlugin = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pluginEntryBindingSource).BeginInit();
            sPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pluginEntryBindingSource1).BeginInit();
            tabControl.SuspendLayout();
            tbDefault.SuspendLayout();
            guna2Panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            guna2Panel1.SuspendLayout();
            guna2Panel3.SuspendLayout();
            pnlPreview.SuspendLayout();
            SuspendLayout();
            // 
            // pluginEntryBindingSource
            // 
            pluginEntryBindingSource.DataSource = typeof(plugins.Model.PluginEntry);
            pluginEntryBindingSource.CurrentChanged += pluginEntryBindingSource_CurrentChanged;
            // 
            // sPanel2
            // 
            sPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sPanel2.BackColor = Color.Black;
            sPanel2.BackgroundImage = Properties.Resources.Aqua_Marine_180degree;
            sPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel2.BorderColor = Color.Black;
            sPanel2.BorderRadius = 20;
            sPanel2.BorderSize = 0;
            sPanel2.Controls.Add(bntPlugin);
            sPanel2.Controls.Add(bntCancel);
            sPanel2.Controls.Add(lblText);
            sPanel2.ForeColor = Color.White;
            sPanel2.Location = new Point(24, 32);
            sPanel2.Margin = new Padding(4);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(920, 88);
            sPanel2.TabIndex = 12;
            // 
            // bntCancel
            // 
            bntCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntCancel.Animated = true;
            bntCancel.BackColor = Color.Transparent;
            bntCancel.BorderColor = Color.Gainsboro;
            bntCancel.BorderRadius = 20;
            bntCancel.BorderThickness = 2;
            bntCancel.DisabledState.BorderColor = Color.DarkGray;
            bntCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            bntCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntCancel.FillColor = Color.Transparent;
            bntCancel.FocusedColor = Color.FromArgb(100, 170, 209);
            bntCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            bntCancel.ForeColor = Color.White;
            bntCancel.Location = new Point(1549, 16);
            bntCancel.Margin = new Padding(2);
            bntCancel.Name = "bntCancel";
            bntCancel.Size = new Size(128, 58);
            bntCancel.TabIndex = 14;
            bntCancel.Text = "Cancel";
            bntCancel.Visible = false;
            // 
            // lblText
            // 
            lblText.BackColor = Color.Transparent;
            lblText.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblText.ForeColor = Color.White;
            lblText.Location = new Point(24, 0);
            lblText.Margin = new Padding(4, 0, 4, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(144, 88);
            lblText.TabIndex = 1;
            lblText.Text = "Plugins";
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pluginEntryBindingSource1
            // 
            pluginEntryBindingSource1.DataSource = typeof(plugins.Model.PluginEntry);
            // 
            // tabControl
            // 
            tabControl.AllowDrop = true;
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.BackgroundColor = Color.White;
            tabControl.BorderTabLineColor = Color.FromArgb(0, 122, 204);
            tabControl.Controls.Add(tbDefault);
            tabControl.DisableClose = false;
            tabControl.DisableDragging = false;
            tabControl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl.HoverTabButtonColor = Color.FromArgb(82, 176, 239);
            tabControl.HoverTabColor = Color.FromArgb(28, 151, 234);
            tabControl.HoverUnselectedTabButtonColor = Color.WhiteSmoke;
            tabControl.Location = new Point(24, 144);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(30, 13);
            tabControl.SelectedIndex = 0;
            tabControl.SelectedTabButtonColor = Color.FromArgb(28, 151, 234);
            tabControl.SelectedTabColor = Color.FromArgb(0, 122, 204);
            tabControl.Size = new Size(921, 776);
            tabControl.TabIndex = 13;
            tabControl.TextColor = Color.Black;
            tabControl.UnderBorderTabLineColor = Color.Snow;
            tabControl.UnselectedBorderTabLineColor = Color.Snow;
            tabControl.UnselectedTabColor = Color.Snow;
            tabControl.UpDownBackColor = Color.Snow;
            tabControl.UpDownTextColor = Color.FromArgb(109, 109, 112);
            // 
            // tbDefault
            // 
            tbDefault.BackColor = Color.White;
            tbDefault.Controls.Add(lblName);
            tbDefault.Controls.Add(guna2Panel2);
            tbDefault.Controls.Add(guna2Panel1);
            tbDefault.Controls.Add(guna2Panel3);
            tbDefault.Controls.Add(pnlPreview);
            tbDefault.Location = new Point(4, 49);
            tbDefault.Name = "tbDefault";
            tbDefault.Padding = new Padding(3);
            tbDefault.Size = new Size(913, 723);
            tbDefault.TabIndex = 0;
            tbDefault.Text = "Encryption Library";
            // 
            // lblName
            // 
            lblName.AutoEllipsis = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(104, 48);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(376, 56);
            lblName.TabIndex = 12;
            lblName.Text = "Plugin-Name";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel2.BorderColor = SystemColors.ActiveBorder;
            guna2Panel2.BorderRadius = 15;
            guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel2.BorderThickness = 2;
            guna2Panel2.Controls.Add(tableLayoutPanel1);
            guna2Panel2.FillColor = Color.Transparent;
            guna2Panel2.Location = new Point(32, 400);
            guna2Panel2.Margin = new Padding(2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.Size = new Size(851, 296);
            guna2Panel2.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Controls.Add(listViewUpdates, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 1, 0);
            tableLayoutPanel1.Controls.Add(listViewBerechtigungen, 0, 1);
            tableLayoutPanel1.Location = new Point(16, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(816, 248);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(4, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(400, 50);
            label5.TabIndex = 1;
            label5.Text = "Berechtigungen";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listViewUpdates
            // 
            listViewUpdates.BorderStyle = BorderStyle.None;
            listViewUpdates.Dock = DockStyle.Fill;
            listViewUpdates.HeaderBackColor = Color.FromArgb(235, 235, 235);
            listViewUpdates.HeaderBorderThickness = 2;
            listViewUpdates.HeaderForeColor = Color.Black;
            listViewUpdates.Location = new Point(411, 53);
            listViewUpdates.Name = "listViewUpdates";
            listViewUpdates.OverlayColor = Color.DodgerBlue;
            listViewUpdates.Size = new Size(402, 192);
            listViewUpdates.TabIndex = 0;
            listViewUpdates.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(412, 0);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(400, 50);
            label6.TabIndex = 1;
            label6.Text = "Updates";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listViewBerechtigungen
            // 
            listViewBerechtigungen.BorderStyle = BorderStyle.None;
            listViewBerechtigungen.Dock = DockStyle.Fill;
            listViewBerechtigungen.HeaderBackColor = Color.FromArgb(235, 235, 235);
            listViewBerechtigungen.HeaderBorderThickness = 2;
            listViewBerechtigungen.HeaderForeColor = Color.Black;
            listViewBerechtigungen.Location = new Point(3, 53);
            listViewBerechtigungen.Name = "listViewBerechtigungen";
            listViewBerechtigungen.OverlayColor = Color.DodgerBlue;
            listViewBerechtigungen.Size = new Size(402, 192);
            listViewBerechtigungen.TabIndex = 0;
            listViewBerechtigungen.UseCompatibleStateImageBehavior = false;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderColor = SystemColors.ActiveBorder;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(lblAuther);
            guna2Panel1.Controls.Add(lblSize);
            guna2Panel1.Controls.Add(lblVersion);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.FillColor = Color.Transparent;
            guna2Panel1.Location = new Point(32, 152);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(600, 208);
            guna2Panel1.TabIndex = 13;
            // 
            // lblAuther
            // 
            lblAuther.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAuther.BackColor = Color.Transparent;
            lblAuther.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuther.ForeColor = Color.Black;
            lblAuther.Location = new Point(216, 136);
            lblAuther.Margin = new Padding(4, 0, 4, 0);
            lblAuther.Name = "lblAuther";
            lblAuther.Size = new Size(219, 56);
            lblAuther.TabIndex = 1;
            lblAuther.Text = "n/a";
            lblAuther.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSize
            // 
            lblSize.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSize.BackColor = Color.Transparent;
            lblSize.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSize.ForeColor = Color.Black;
            lblSize.Location = new Point(216, 24);
            lblSize.Margin = new Padding(4, 0, 4, 0);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(211, 56);
            lblSize.TabIndex = 1;
            lblSize.Text = "n/a";
            lblSize.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVersion
            // 
            lblVersion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblVersion.ForeColor = Color.Black;
            lblVersion.Location = new Point(216, 80);
            lblVersion.Margin = new Padding(4, 0, 4, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(211, 56);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "n/a";
            lblVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(24, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 56);
            label2.TabIndex = 1;
            label2.Text = "Description";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(24, 136);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(200, 56);
            label4.TabIndex = 1;
            label4.Text = "ID";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(24, 80);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 56);
            label1.TabIndex = 1;
            label1.Text = "Version";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Panel3
            // 
            guna2Panel3.BorderColor = SystemColors.ActiveBorder;
            guna2Panel3.BorderRadius = 15;
            guna2Panel3.BorderThickness = 2;
            guna2Panel3.Controls.Add(imgImage);
            guna2Panel3.FillColor = Color.Gainsboro;
            guna2Panel3.Location = new Point(32, 48);
            guna2Panel3.Margin = new Padding(2);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Size = new Size(56, 56);
            guna2Panel3.TabIndex = 14;
            // 
            // imgImage
            // 
            imgImage.Anchor = AnchorStyles.None;
            imgImage.BackColor = Color.Transparent;
            imgImage.BackgroundImage = Properties.Resources.favico;
            imgImage.BackgroundImageLayout = ImageLayout.Zoom;
            imgImage.BorderColor = SystemColors.ActiveBorder;
            imgImage.BorderRadius = 15;
            imgImage.FillColor = Color.Transparent;
            imgImage.Location = new Point(8, 8);
            imgImage.Margin = new Padding(2);
            imgImage.Name = "imgImage";
            imgImage.Size = new Size(40, 40);
            imgImage.TabIndex = 15;
            // 
            // pnlPreview
            // 
            pnlPreview.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlPreview.BorderColor = SystemColors.ActiveBorder;
            pnlPreview.BorderRadius = 15;
            pnlPreview.BorderThickness = 2;
            pnlPreview.Controls.Add(guna2Panel4);
            pnlPreview.FillColor = Color.Gainsboro;
            pnlPreview.Location = new Point(675, 152);
            pnlPreview.Margin = new Padding(2);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Size = new Size(211, 208);
            pnlPreview.TabIndex = 14;
            // 
            // guna2Panel4
            // 
            guna2Panel4.BackColor = Color.Transparent;
            guna2Panel4.BackgroundImage = Properties.Resources.icons8_verified_badge_96;
            guna2Panel4.BackgroundImageLayout = ImageLayout.Center;
            guna2Panel4.BorderColor = SystemColors.ActiveBorder;
            guna2Panel4.BorderRadius = 15;
            guna2Panel4.FillColor = Color.Transparent;
            guna2Panel4.Location = new Point(24, 24);
            guna2Panel4.Margin = new Padding(2);
            guna2Panel4.Name = "guna2Panel4";
            guna2Panel4.Size = new Size(168, 160);
            guna2Panel4.TabIndex = 15;
            // 
            // bntPlugin
            // 
            bntPlugin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntPlugin.Animated = true;
            bntPlugin.BackColor = Color.Transparent;
            bntPlugin.BackgroundImageLayout = ImageLayout.Zoom;
            bntPlugin.BorderColor = Color.Gainsboro;
            bntPlugin.BorderRadius = 20;
            bntPlugin.BorderThickness = 2;
            bntPlugin.DisabledState.BorderColor = Color.DarkGray;
            bntPlugin.DisabledState.CustomBorderColor = Color.DarkGray;
            bntPlugin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntPlugin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntPlugin.FillColor = Color.Transparent;
            bntPlugin.FocusedColor = Color.FromArgb(100, 170, 209);
            bntPlugin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            bntPlugin.ForeColor = Color.White;
            bntPlugin.Location = new Point(792, 16);
            bntPlugin.Margin = new Padding(2);
            bntPlugin.Name = "bntPlugin";
            bntPlugin.Size = new Size(112, 58);
            bntPlugin.TabIndex = 15;
            bntPlugin.Text = "Login";
            bntPlugin.Click += bntPlugin_Click;
            // 
            // uiPluginManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(965, 948);
            Controls.Add(tabControl);
            Controls.Add(sPanel2);
            Name = "uiPluginManager";
            Text = "uiPluginManager";
            Load += uiPluginManager_Load;
            ((System.ComponentModel.ISupportInitialize)pluginEntryBindingSource).EndInit();
            sPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pluginEntryBindingSource1).EndInit();
            tabControl.ResumeLayout(false);
            tbDefault.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel3.ResumeLayout(false);
            pnlPreview.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sipaa.Framework.SPanel sPanel2;
        private Guna.UI2.WinForms.Guna2Button bntCancel;
        private Label lblText;
        private BindingSource pluginEntryBindingSource;
        private BindingSource pluginEntryBindingSource1;
        private BindingSource pluginManagerBindingSource;

        private HTAlt.WinForms.HTTabControl tabControl;
        private TabPage tbDefault;
        private Label lblName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label2;
        private Label label4;
        private Label label1;
        private Label lblAuther;
        private Label lblSize;
        private Label lblVersion;
        private Guna.UI2.WinForms.Guna2Panel pnlPreview;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label label6;
        private HTAlt.WinForms.HTListView listViewUpdates;
        private Label label5;
        private HTAlt.WinForms.HTListView listViewBerechtigungen;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel imgImage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button bntPlugin;
    }
}