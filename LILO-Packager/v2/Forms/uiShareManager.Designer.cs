namespace LILO_Packager.v2.Forms
{
    partial class uiShareManager
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
            sPanel2 = new Sipaa.Framework.SPanel();
            listView1 = new ListView();
            colFileName = new ColumnHeader();
            colUploadDate = new ColumnHeader();
            bntShare = new Guna.UI2.WinForms.Guna2Button();
            bntPlugin = new Guna.UI2.WinForms.Guna2Button();
            lblText = new Label();
            label4 = new Label();
            sPanel1 = new Sipaa.Framework.SPanel();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            lblVersion = new Label();
            sPanel2.SuspendLayout();
            guna2Panel3.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sPanel2
            // 
            sPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sPanel2.BackColor = Color.WhiteSmoke;
            sPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel2.BorderColor = Color.Gainsboro;
            sPanel2.BorderRadius = 20;
            sPanel2.BorderSize = 2;
            sPanel2.Controls.Add(listView1);
            sPanel2.Controls.Add(bntShare);
            sPanel2.Controls.Add(bntPlugin);
            sPanel2.Controls.Add(lblText);
            sPanel2.ForeColor = Color.White;
            sPanel2.Location = new Point(400, 40);
            sPanel2.Margin = new Padding(4);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(870, 768);
            sPanel2.TabIndex = 14;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.BackColor = Color.WhiteSmoke;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Columns.AddRange(new ColumnHeader[] { colFileName, colUploadDate });
            listView1.ForeColor = Color.DimGray;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(40, 96);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(782, 568);
            listView1.TabIndex = 51;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // colFileName
            // 
            colFileName.Text = "Name";
            colFileName.Width = 550;
            // 
            // colUploadDate
            // 
            colUploadDate.Text = "Uploaded";
            colUploadDate.Width = 180;
            // 
            // bntShare
            // 
            bntShare.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bntShare.Animated = true;
            bntShare.BackColor = Color.Transparent;
            bntShare.BackgroundImageLayout = ImageLayout.Zoom;
            bntShare.BorderColor = Color.Gainsboro;
            bntShare.BorderRadius = 10;
            bntShare.BorderThickness = 2;
            bntShare.CheckedState.FillColor = Color.White;
            bntShare.DisabledState.BorderColor = Color.Gainsboro;
            bntShare.DisabledState.CustomBorderColor = Color.Gainsboro;
            bntShare.DisabledState.FillColor = Color.WhiteSmoke;
            bntShare.DisabledState.ForeColor = Color.DimGray;
            bntShare.Enabled = false;
            bntShare.FillColor = Color.White;
            bntShare.FocusedColor = Color.FromArgb(100, 170, 209);
            bntShare.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            bntShare.ForeColor = Color.SteelBlue;
            bntShare.Location = new Point(40, 696);
            bntShare.Margin = new Padding(2);
            bntShare.Name = "bntShare";
            bntShare.Size = new Size(792, 48);
            bntShare.TabIndex = 15;
            bntShare.Text = "Export";
            bntShare.Click += bntShare_Click;
            // 
            // bntPlugin
            // 
            bntPlugin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntPlugin.Animated = true;
            bntPlugin.BackColor = Color.Transparent;
            bntPlugin.BackgroundImageLayout = ImageLayout.Zoom;
            bntPlugin.BorderColor = Color.Gainsboro;
            bntPlugin.BorderRadius = 10;
            bntPlugin.BorderThickness = 2;
            bntPlugin.DisabledState.BorderColor = Color.DarkGray;
            bntPlugin.DisabledState.CustomBorderColor = Color.DarkGray;
            bntPlugin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntPlugin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntPlugin.FillColor = Color.Transparent;
            bntPlugin.FocusedColor = Color.FromArgb(100, 170, 209);
            bntPlugin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            bntPlugin.ForeColor = Color.DimGray;
            bntPlugin.Location = new Point(702, 24);
            bntPlugin.Margin = new Padding(2);
            bntPlugin.Name = "bntPlugin";
            bntPlugin.Size = new Size(128, 48);
            bntPlugin.TabIndex = 15;
            bntPlugin.Text = "Import";
            bntPlugin.Click += bntPlugin_Click;
            // 
            // lblText
            // 
            lblText.BackColor = Color.Transparent;
            lblText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblText.ForeColor = Color.DimGray;
            lblText.Location = new Point(24, 24);
            lblText.Margin = new Padding(4, 0, 4, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(104, 48);
            lblText.TabIndex = 1;
            lblText.Text = "Files";
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(152, 48);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(224, 40);
            label4.TabIndex = 47;
            label4.Text = "LILO Share";
            label4.TextAlign = ContentAlignment.BottomLeft;
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
            sPanel1.Location = new Point(40, 40);
            sPanel1.Margin = new Padding(4);
            sPanel1.Name = "sPanel1";
            sPanel1.Size = new Size(96, 88);
            sPanel1.TabIndex = 46;
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
            guna2Panel3.Location = new Point(40, 728);
            guna2Panel3.Margin = new Padding(2);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Size = new Size(304, 80);
            guna2Panel3.TabIndex = 45;
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
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(56, 152);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(136, 40);
            label5.TabIndex = 50;
            label5.Text = "    Selected";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.HighlightText;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(listView2);
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(40, 168);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(304, 240);
            guna2Panel1.TabIndex = 49;
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView2.BackColor = Color.White;
            listView2.BorderStyle = BorderStyle.None;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView2.ForeColor = Color.DimGray;
            listView2.FullRowSelect = true;
            listView2.Location = new Point(24, 0);
            listView2.Margin = new Padding(2);
            listView2.Name = "listView2";
            listView2.Size = new Size(264, 216);
            listView2.TabIndex = 52;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            columnHeader1.Width = 260;
            // 
            // lblVersion
            // 
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblVersion.ForeColor = Color.Silver;
            lblVersion.Location = new Point(152, 88);
            lblVersion.Margin = new Padding(4, 0, 4, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(184, 22);
            lblVersion.TabIndex = 52;
            lblVersion.Text = "VERSION\r\n";
            lblVersion.TextAlign = ContentAlignment.BottomLeft;
            // 
            // uiShareManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1301, 844);
            Controls.Add(lblVersion);
            Controls.Add(label5);
            Controls.Add(guna2Panel1);
            Controls.Add(label4);
            Controls.Add(sPanel1);
            Controls.Add(guna2Panel3);
            Controls.Add(sPanel2);
            Name = "uiShareManager";
            StartPosition = FormStartPosition.CenterParent;
            Text = "uiShareManager";
            Load += uiShareManager_Load;
            sPanel2.ResumeLayout(false);
            guna2Panel3.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sipaa.Framework.SPanel sPanel2;
        private Guna.UI2.WinForms.Guna2Button bntPlugin;
        private Label lblText;
        private Label label4;
        private Sipaa.Framework.SPanel sPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button bntShare;
        private ListView listView1;
        private ColumnHeader colFileName;
        private ColumnHeader colUploadDate;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private Label lblVersion;
    }
}