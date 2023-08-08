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
            tbEncryption = new TabPage();
            lblName = new Label();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            label6 = new Label();
            htListView2 = new HTAlt.WinForms.HTListView();
            label5 = new Label();
            htListView1 = new HTAlt.WinForms.HTListView();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            lblSize = new Label();
            lblEncryption = new Label();
            pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)pluginEntryBindingSource).BeginInit();
            sPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pluginEntryBindingSource1).BeginInit();
            tabControl.SuspendLayout();
            tbEncryption.SuspendLayout();
            guna2Panel2.SuspendLayout();
            guna2Panel1.SuspendLayout();
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
            sPanel2.Controls.Add(bntCancel);
            sPanel2.Controls.Add(lblText);
            sPanel2.ForeColor = Color.White;
            sPanel2.Location = new Point(24, 32);
            sPanel2.Margin = new Padding(4);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(975, 88);
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
            bntCancel.Location = new Point(1657, 16);
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
            tabControl.Controls.Add(tbEncryption);
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
            tabControl.Size = new Size(976, 776);
            tabControl.TabIndex = 13;
            tabControl.TextColor = Color.Black;
            tabControl.UnderBorderTabLineColor = Color.Snow;
            tabControl.UnselectedBorderTabLineColor = Color.Snow;
            tabControl.UnselectedTabColor = Color.Snow;
            tabControl.UpDownBackColor = Color.Snow;
            tabControl.UpDownTextColor = Color.FromArgb(109, 109, 112);
            // 
            // tbEncryption
            // 
            tbEncryption.BackColor = Color.White;
            tbEncryption.Controls.Add(lblName);
            tbEncryption.Controls.Add(guna2Panel2);
            tbEncryption.Controls.Add(guna2Panel1);
            tbEncryption.Controls.Add(pnlPreview);
            tbEncryption.Location = new Point(4, 49);
            tbEncryption.Name = "tbEncryption";
            tbEncryption.Padding = new Padding(3);
            tbEncryption.Size = new Size(968, 723);
            tbEncryption.TabIndex = 0;
            tbEncryption.Text = "Encryption Library";
            // 
            // lblName
            // 
            lblName.AutoEllipsis = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(40, 48);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(376, 56);
            lblName.TabIndex = 12;
            lblName.Text = "Plugin-Name";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel2.BorderColor = SystemColors.ActiveBorder;
            guna2Panel2.BorderRadius = 15;
            guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel2.BorderThickness = 2;
            guna2Panel2.Controls.Add(label6);
            guna2Panel2.Controls.Add(htListView2);
            guna2Panel2.Controls.Add(label5);
            guna2Panel2.Controls.Add(htListView1);
            guna2Panel2.FillColor = Color.Transparent;
            guna2Panel2.Location = new Point(32, 360);
            guna2Panel2.Margin = new Padding(2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.Size = new Size(904, 336);
            guna2Panel2.TabIndex = 13;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(480, 24);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(200, 56);
            label6.TabIndex = 1;
            label6.Text = "Updates";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // htListView2
            // 
            htListView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            htListView2.HeaderBackColor = Color.FromArgb(235, 235, 235);
            htListView2.HeaderBorderThickness = 2;
            htListView2.HeaderForeColor = Color.Black;
            htListView2.Location = new Point(480, 88);
            htListView2.Name = "htListView2";
            htListView2.OverlayColor = Color.DodgerBlue;
            htListView2.Size = new Size(400, 224);
            htListView2.TabIndex = 0;
            htListView2.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(24, 24);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(200, 56);
            label5.TabIndex = 1;
            label5.Text = "Berechtigungen";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // htListView1
            // 
            htListView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            htListView1.HeaderBackColor = Color.FromArgb(235, 235, 235);
            htListView1.HeaderBorderThickness = 2;
            htListView1.HeaderForeColor = Color.Black;
            htListView1.Location = new Point(24, 88);
            htListView1.Name = "htListView1";
            htListView1.OverlayColor = Color.DodgerBlue;
            htListView1.Size = new Size(408, 224);
            htListView1.TabIndex = 0;
            htListView1.UseCompatibleStateImageBehavior = false;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderColor = SystemColors.ActiveBorder;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(lblSize);
            guna2Panel1.Controls.Add(lblEncryption);
            guna2Panel1.FillColor = Color.Transparent;
            guna2Panel1.Location = new Point(32, 120);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(544, 208);
            guna2Panel1.TabIndex = 13;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(24, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 56);
            label2.TabIndex = 1;
            label2.Text = "Size";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(24, 128);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(200, 56);
            label4.TabIndex = 1;
            label4.Text = "Auther";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(24, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 56);
            label1.TabIndex = 1;
            label1.Text = "Version";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(272, 128);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(376, 56);
            label3.TabIndex = 1;
            label3.Text = "n/a";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSize
            // 
            lblSize.BackColor = Color.Transparent;
            lblSize.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSize.ForeColor = Color.Black;
            lblSize.Location = new Point(272, 24);
            lblSize.Margin = new Padding(4, 0, 4, 0);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(376, 56);
            lblSize.TabIndex = 1;
            lblSize.Text = "n/a";
            lblSize.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEncryption
            // 
            lblEncryption.BackColor = Color.Transparent;
            lblEncryption.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblEncryption.ForeColor = Color.Black;
            lblEncryption.Location = new Point(272, 72);
            lblEncryption.Margin = new Padding(4, 0, 4, 0);
            lblEncryption.Name = "lblEncryption";
            lblEncryption.Size = new Size(376, 56);
            lblEncryption.TabIndex = 1;
            lblEncryption.Text = "n/a";
            lblEncryption.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlPreview
            // 
            pnlPreview.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlPreview.BorderColor = SystemColors.ActiveBorder;
            pnlPreview.BorderRadius = 15;
            pnlPreview.BorderThickness = 2;
            pnlPreview.FillColor = Color.Gainsboro;
            pnlPreview.Location = new Point(688, 40);
            pnlPreview.Margin = new Padding(2);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Size = new Size(248, 232);
            pnlPreview.TabIndex = 14;
            // 
            // uiPluginManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1020, 948);
            Controls.Add(tabControl);
            Controls.Add(sPanel2);
            Name = "uiPluginManager";
            Text = "uiPluginManager";
            Load += uiPluginManager_Load;
            ((System.ComponentModel.ISupportInitialize)pluginEntryBindingSource).EndInit();
            sPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pluginEntryBindingSource1).EndInit();
            tabControl.ResumeLayout(false);
            tbEncryption.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
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
        private TabPage tbEncryption;
        private Label lblName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label2;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label lblSize;
        private Label lblEncryption;
        private Guna.UI2.WinForms.Guna2Panel pnlPreview;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label label6;
        private HTAlt.WinForms.HTListView htListView2;
        private Label label5;
        private HTAlt.WinForms.HTListView htListView1;
    }
}