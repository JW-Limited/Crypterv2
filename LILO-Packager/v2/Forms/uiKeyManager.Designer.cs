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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiKeyManager));
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
            resources.ApplyResources(lblText, "lblText");
            lblText.ForeColor = Color.DimGray;
            lblText.Name = "lblText";
            // 
            // sPanel2
            // 
            resources.ApplyResources(sPanel2, "sPanel2");
            sPanel2.BackColor = Color.WhiteSmoke;
            sPanel2.BorderColor = Color.Gainsboro;
            sPanel2.BorderRadius = 20;
            sPanel2.BorderSize = 2;
            sPanel2.Controls.Add(lblText);
            sPanel2.ForeColor = Color.White;
            sPanel2.Name = "sPanel2";
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
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.ForeColor = Color.FromArgb(64, 64, 64);
            comboBox1.HoverState.BorderColor = Color.Gray;
            comboBox1.HoverState.FillColor = Color.FromArgb(224, 224, 224);
            comboBox1.Items.AddRange(new object[] { resources.GetString("comboBox1.Items") });
            comboBox1.Name = "comboBox1";
            comboBox1.Tag = "password_history.db";
            comboBox1.ValueMember = "password_history.db";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.DimGray;
            label1.Name = "label1";
            // 
            // sPanel1
            // 
            resources.ApplyResources(sPanel1, "sPanel1");
            sPanel1.BackColor = Color.White;
            sPanel1.BorderColor = Color.Gainsboro;
            sPanel1.BorderRadius = 20;
            sPanel1.BorderSize = 2;
            sPanel1.Controls.Add(htListView1);
            sPanel1.Controls.Add(progress);
            sPanel1.ForeColor = Color.White;
            sPanel1.Name = "sPanel1";
            // 
            // htListView1
            // 
            resources.ApplyResources(htListView1, "htListView1");
            htListView1.BorderStyle = BorderStyle.None;
            htListView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            htListView1.FullRowSelect = true;
            htListView1.GridLines = true;
            htListView1.HeaderBackColor = Color.FromArgb(235, 235, 235);
            htListView1.HeaderBorderThickness = 2;
            htListView1.HeaderForeColor = Color.Black;
            htListView1.Name = "htListView1";
            htListView1.OverlayColor = Color.DodgerBlue;
            htListView1.UseCompatibleStateImageBehavior = false;
            htListView1.View = View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(columnHeader2, "columnHeader2");
            // 
            // progress
            // 
            resources.ApplyResources(progress, "progress");
            progress.BackColor = Color.Transparent;
            progress.BorderColor = Color.Gainsboro;
            progress.BorderRadius = 20;
            progress.BorderThickness = 2;
            progress.FillColor = Color.Transparent;
            progress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            progress.Name = "progress";
            progress.ProgressColor = Color.White;
            progress.ProgressColor2 = Color.SlateGray;
            progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // bntCancel
            // 
            resources.ApplyResources(bntCancel, "bntCancel");
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
            bntCancel.ForeColor = Color.DimGray;
            bntCancel.Name = "bntCancel";
            bntCancel.Click += bntCancel_Click;
            // 
            // uiKeyManager
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(bntCancel);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(sPanel1);
            Controls.Add(sPanel2);
            Name = "uiKeyManager";
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