namespace LILO_Packager.v2.Forms
{
    partial class uiKeyManager
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
            lblText = new Label();
            sPanel2 = new Sipaa.Framework.SPanel();
            comboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            sPanel1 = new Sipaa.Framework.SPanel();
            htListView1 = new HTAlt.WinForms.HTListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            progress = new Guna.UI2.WinForms.Guna2ProgressBar();
            bntCancel = new Guna.UI2.WinForms.Guna2Button();
            sPanel2.SuspendLayout();
            sPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.BackColor = Color.Transparent;
            lblText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblText.ForeColor = Color.DimGray;
            lblText.Location = new Point(24, 0);
            lblText.Margin = new Padding(4, 0, 4, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(280, 88);
            lblText.TabIndex = 1;
            lblText.Text = "Password Manager";
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sPanel2
            // 
            sPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sPanel2.BackColor = Color.WhiteSmoke;
            sPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel2.BorderColor = Color.Gainsboro;
            sPanel2.BorderRadius = 20;
            sPanel2.BorderSize = 2;
            sPanel2.Controls.Add(lblText);
            sPanel2.ForeColor = Color.White;
            sPanel2.Location = new Point(24, 32);
            sPanel2.Margin = new Padding(4);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(1040, 88);
            sPanel2.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteSource = AutoCompleteSource.AllSystemSources;
            comboBox1.BackColor = Color.Transparent;
            comboBox1.BorderRadius = 10;
            comboBox1.BorderThickness = 2;
            comboBox1.DisplayMember = "password_history.db";
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FocusedColor = Color.Empty;
            comboBox1.Font = new Font("Segoe UI", 9F);
            comboBox1.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox1.HoverState.BorderColor = Color.Gray;
            comboBox1.HoverState.FillColor = Color.FromArgb(224, 224, 224);
            comboBox1.ItemHeight = 30;
            comboBox1.Items.AddRange(new object[] { "password_history.db" });
            comboBox1.Location = new Point(200, 176);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(256, 36);
            comboBox1.TabIndex = 15;
            comboBox1.Tag = "password_history.db";
            comboBox1.ValueMember = "password_history.db";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(48, 152);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(292, 72);
            label1.TabIndex = 1;
            label1.Text = "  Database:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sPanel1
            // 
            sPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sPanel1.BackColor = Color.White;
            sPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel1.BorderColor = Color.Gainsboro;
            sPanel1.BorderRadius = 20;
            sPanel1.BorderSize = 2;
            sPanel1.Controls.Add(htListView1);
            sPanel1.Controls.Add(progress);
            sPanel1.ForeColor = Color.White;
            sPanel1.Location = new Point(32, 192);
            sPanel1.Margin = new Padding(4);
            sPanel1.Name = "sPanel1";
            sPanel1.Size = new Size(1016, 760);
            sPanel1.TabIndex = 16;
            // 
            // htListView1
            // 
            htListView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            htListView1.BorderStyle = BorderStyle.None;
            htListView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            htListView1.FullRowSelect = true;
            htListView1.GridLines = true;
            htListView1.HeaderBackColor = Color.FromArgb(235, 235, 235);
            htListView1.HeaderBorderThickness = 2;
            htListView1.HeaderForeColor = Color.Black;
            htListView1.Location = new Point(24, 40);
            htListView1.Name = "htListView1";
            htListView1.OverlayColor = Color.DodgerBlue;
            htListView1.Size = new Size(976, 704);
            htListView1.TabIndex = 17;
            htListView1.UseCompatibleStateImageBehavior = false;
            htListView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Source";
            columnHeader1.Width = 700;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Encrypted Key";
            columnHeader2.Width = 250;
            // 
            // progress
            // 
            progress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progress.BackColor = Color.Transparent;
            progress.BorderColor = Color.Gainsboro;
            progress.BorderRadius = 20;
            progress.BorderThickness = 2;
            progress.FillColor = Color.Transparent;
            progress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            progress.Location = new Point(32, 1392);
            progress.Margin = new Padding(2);
            progress.Name = "progress";
            progress.ProgressColor = Color.White;
            progress.ProgressColor2 = Color.SlateGray;
            progress.Size = new Size(1722, 56);
            progress.TabIndex = 16;
            progress.Text = "guna2ProgressBar1";
            progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            progress.Visible = false;
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
            bntCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            bntCancel.ForeColor = Color.DimGray;
            bntCancel.Location = new Point(880, 168);
            bntCancel.Margin = new Padding(2);
            bntCancel.Name = "bntCancel";
            bntCancel.Size = new Size(136, 50);
            bntCancel.TabIndex = 17;
            bntCancel.Text = "Decrypt";
            bntCancel.Click += bntCancel_Click;
            // 
            // uiKeyManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1082, 986);
            Controls.Add(bntCancel);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(sPanel1);
            Controls.Add(sPanel2);
            Name = "uiKeyManager";
            Text = "uiKeyManager";
            Load += uiKeyManager_Load;
            sPanel2.ResumeLayout(false);
            sPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblText;
        private Sipaa.Framework.SPanel sPanel2;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox1;
        private Label label1;
        private Sipaa.Framework.SPanel sPanel1;
        private Guna.UI2.WinForms.Guna2ProgressBar progress;
        private Guna.UI2.WinForms.Guna2Button bntCancel;
        private HTAlt.WinForms.HTListView htListView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}