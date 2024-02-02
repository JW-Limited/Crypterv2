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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiShareManager));
            sPanel2 = new Sipaa.Framework.SPanel();
            listView1 = new ListView();
            colFileName = new ColumnHeader();
            colUploadDate = new ColumnHeader();
            bntAdvanced = new Guna.UI2.WinForms.Guna2Button();
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
            pswDialog = new Ookii.Dialogs.WinForms.InputDialog(components);
            sPanel2.SuspendLayout();
            guna2Panel3.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sPanel2
            // 
            resources.ApplyResources(sPanel2, "sPanel2");
            sPanel2.BackColor = Color.WhiteSmoke;
            sPanel2.BorderColor = Color.Gainsboro;
            sPanel2.BorderRadius = 20;
            sPanel2.BorderSize = 2;
            sPanel2.Controls.Add(listView1);
            sPanel2.Controls.Add(bntAdvanced);
            sPanel2.Controls.Add(bntShare);
            sPanel2.Controls.Add(bntPlugin);
            sPanel2.Controls.Add(lblText);
            sPanel2.ForeColor = Color.White;
            sPanel2.Name = "sPanel2";
            // 
            // listView1
            // 
            resources.ApplyResources(listView1, "listView1");
            listView1.BackColor = Color.White;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Columns.AddRange(new ColumnHeader[] { colFileName, colUploadDate });
            listView1.ForeColor = Color.DimGray;
            listView1.FullRowSelect = true;
            listView1.Name = "listView1";
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // colFileName
            // 
            resources.ApplyResources(colFileName, "colFileName");
            // 
            // colUploadDate
            // 
            resources.ApplyResources(colUploadDate, "colUploadDate");
            // 
            // bntAdvanced
            // 
            resources.ApplyResources(bntAdvanced, "bntAdvanced");
            bntAdvanced.Animated = true;
            bntAdvanced.BackColor = Color.Transparent;
            bntAdvanced.BorderColor = Color.Gainsboro;
            bntAdvanced.BorderRadius = 10;
            bntAdvanced.BorderThickness = 2;
            bntAdvanced.CheckedState.FillColor = Color.White;
            bntAdvanced.CustomizableEdges.BottomLeft = false;
            bntAdvanced.CustomizableEdges.TopLeft = false;
            bntAdvanced.DisabledState.BorderColor = Color.Gainsboro;
            bntAdvanced.DisabledState.CustomBorderColor = Color.Gainsboro;
            bntAdvanced.DisabledState.FillColor = Color.WhiteSmoke;
            bntAdvanced.DisabledState.ForeColor = Color.DimGray;
            bntAdvanced.FillColor = Color.White;
            bntAdvanced.FocusedColor = Color.FromArgb(100, 170, 209);
            bntAdvanced.ForeColor = Color.DarkGray;
            bntAdvanced.Name = "bntAdvanced";
            bntAdvanced.Click += bntAdvanced_Click;
            // 
            // bntShare
            // 
            resources.ApplyResources(bntShare, "bntShare");
            bntShare.Animated = true;
            bntShare.BackColor = Color.Transparent;
            bntShare.BorderColor = Color.Gainsboro;
            bntShare.BorderRadius = 10;
            bntShare.BorderThickness = 2;
            bntShare.CheckedState.FillColor = Color.White;
            bntShare.DisabledState.BorderColor = Color.Gainsboro;
            bntShare.DisabledState.CustomBorderColor = Color.Gainsboro;
            bntShare.DisabledState.FillColor = Color.WhiteSmoke;
            bntShare.DisabledState.ForeColor = Color.DimGray;
            bntShare.FillColor = Color.White;
            bntShare.FocusedColor = Color.FromArgb(100, 170, 209);
            bntShare.ForeColor = Color.SteelBlue;
            bntShare.Name = "bntShare";
            bntShare.Click += bntShare_Click;
            // 
            // bntPlugin
            // 
            resources.ApplyResources(bntPlugin, "bntPlugin");
            bntPlugin.Animated = true;
            bntPlugin.BackColor = Color.Transparent;
            bntPlugin.BorderColor = Color.Gainsboro;
            bntPlugin.BorderRadius = 10;
            bntPlugin.BorderThickness = 2;
            bntPlugin.DisabledState.BorderColor = Color.DarkGray;
            bntPlugin.DisabledState.CustomBorderColor = Color.DarkGray;
            bntPlugin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntPlugin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntPlugin.FillColor = Color.White;
            bntPlugin.FocusedColor = Color.FromArgb(100, 170, 209);
            bntPlugin.ForeColor = Color.DimGray;
            bntPlugin.Name = "bntPlugin";
            bntPlugin.Click += bntPlugin_Click;
            // 
            // lblText
            // 
            lblText.BackColor = Color.Transparent;
            resources.ApplyResources(lblText, "lblText");
            lblText.ForeColor = Color.DimGray;
            lblText.Name = "lblText";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Name = "label4";
            // 
            // sPanel1
            // 
            sPanel1.BackColor = Color.White;
            sPanel1.BackgroundImage = Properties.Resources.Screenshot_2023_10_13_052005;
            resources.ApplyResources(sPanel1, "sPanel1");
            sPanel1.BorderColor = Color.Gainsboro;
            sPanel1.BorderRadius = 20;
            sPanel1.BorderSize = 0;
            sPanel1.ForeColor = Color.White;
            sPanel1.Name = "sPanel1";
            // 
            // guna2Panel3
            // 
            resources.ApplyResources(guna2Panel3, "guna2Panel3");
            guna2Panel3.BackColor = Color.White;
            guna2Panel3.BorderColor = Color.Gainsboro;
            guna2Panel3.BorderRadius = 15;
            guna2Panel3.BorderThickness = 2;
            guna2Panel3.Controls.Add(label2);
            guna2Panel3.Controls.Add(label1);
            guna2Panel3.FillColor = Color.WhiteSmoke;
            guna2Panel3.Name = "guna2Panel3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Silver;
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Name = "label1";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = SystemColors.ControlDark;
            label5.Name = "label5";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.HighlightText;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(listView2);
            guna2Panel1.FillColor = Color.White;
            resources.ApplyResources(guna2Panel1, "guna2Panel1");
            guna2Panel1.Name = "guna2Panel1";
            // 
            // listView2
            // 
            resources.ApplyResources(listView2, "listView2");
            listView2.BackColor = Color.White;
            listView2.BorderStyle = BorderStyle.None;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView2.ForeColor = Color.DimGray;
            listView2.FullRowSelect = true;
            listView2.Name = "listView2";
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(columnHeader1, "columnHeader1");
            // 
            // lblVersion
            // 
            lblVersion.BackColor = Color.Transparent;
            resources.ApplyResources(lblVersion, "lblVersion");
            lblVersion.ForeColor = Color.Silver;
            lblVersion.Name = "lblVersion";
            // 
            // pswDialog
            // 
            resources.ApplyResources(pswDialog, "pswDialog");
            // 
            // uiShareManager
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblVersion);
            Controls.Add(label5);
            Controls.Add(guna2Panel1);
            Controls.Add(label4);
            Controls.Add(sPanel1);
            Controls.Add(guna2Panel3);
            Controls.Add(sPanel2);
            Name = "uiShareManager";
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
        private ListView listView1;
        private ColumnHeader colFileName;
        private ColumnHeader colUploadDate;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private Label lblVersion;
        private Ookii.Dialogs.WinForms.InputDialog pswDialog;
        private Guna.UI2.WinForms.Guna2Button bntAdvanced;
        private Guna.UI2.WinForms.Guna2Button bntShare;
    }
}