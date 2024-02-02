namespace LILO_Packager.v2.Forms
{
    partial class uiSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiSetup));
            lblVersion = new Label();
            label4 = new Label();
            sPanel1 = new Sipaa.Framework.SPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            CheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            richText = new RichTextBox();
            bntSync = new Guna.UI2.WinForms.Guna2Button();
            lblVersion_left = new Label();
            sPanel1.SuspendLayout();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblVersion
            // 
            lblVersion.BackColor = Color.Transparent;
            resources.ApplyResources(lblVersion, "lblVersion");
            lblVersion.ForeColor = Color.Silver;
            lblVersion.Name = "lblVersion";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.DimGray;
            label4.Name = "label4";
            // 
            // sPanel1
            // 
            sPanel1.BackColor = Color.White;
            sPanel1.BackgroundImage = Properties.Resources.pexels_johannes_plenio_1103970;
            resources.ApplyResources(sPanel1, "sPanel1");
            sPanel1.BorderColor = Color.Gainsboro;
            sPanel1.BorderRadius = 0;
            sPanel1.BorderSize = 0;
            sPanel1.Controls.Add(panel1);
            sPanel1.Controls.Add(panel2);
            sPanel1.ForeColor = Color.White;
            sPanel1.Name = "sPanel1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.favico;
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.HighlightText;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel1.Controls.Add(CheckBox);
            guna2Panel1.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(bntSync);
            guna2Panel1.Controls.Add(lblVersion_left);
            guna2Panel1.Controls.Add(lblVersion);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.CustomizableEdges.BottomLeft = false;
            guna2Panel1.CustomizableEdges.BottomRight = false;
            guna2Panel1.CustomizableEdges.TopLeft = false;
            guna2Panel1.CustomizableEdges.TopRight = false;
            resources.ApplyResources(guna2Panel1, "guna2Panel1");
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Name = "guna2Panel1";
            // 
            // CheckBox
            // 
            CheckBox.CheckedState.BorderRadius = 0;
            CheckBox.CheckedState.BorderThickness = 0;
            resources.ApplyResources(CheckBox, "CheckBox");
            CheckBox.Name = "CheckBox";
            CheckBox.UncheckedState.BorderRadius = 0;
            CheckBox.UncheckedState.BorderThickness = 0;
            CheckBox.CheckStateChanged += CheckBox_CheckStateChanged;
            // 
            // guna2Panel2
            // 
            resources.ApplyResources(guna2Panel2, "guna2Panel2");
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.BorderColor = Color.FromArgb(218, 218, 218);
            guna2Panel2.BorderRadius = 15;
            guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            guna2Panel2.BorderThickness = 2;
            guna2Panel2.Controls.Add(richText);
            guna2Panel2.FillColor = Color.White;
            guna2Panel2.Name = "guna2Panel2";
            // 
            // richText
            // 
            resources.ApplyResources(richText, "richText");
            richText.BackColor = Color.White;
            richText.BorderStyle = BorderStyle.None;
            richText.ForeColor = Color.Gray;
            richText.Name = "richText";
            // 
            // bntSync
            // 
            resources.ApplyResources(bntSync, "bntSync");
            bntSync.Animated = true;
            bntSync.BackColor = Color.Transparent;
            bntSync.BorderColor = Color.Gainsboro;
            bntSync.BorderRadius = 12;
            bntSync.BorderThickness = 2;
            bntSync.DisabledState.BorderColor = Color.Gainsboro;
            bntSync.DisabledState.CustomBorderColor = Color.Gainsboro;
            bntSync.DisabledState.FillColor = Color.White;
            bntSync.DisabledState.ForeColor = Color.Silver;
            bntSync.FillColor = Color.White;
            bntSync.FocusedColor = Color.FromArgb(100, 170, 209);
            bntSync.ForeColor = Color.DimGray;
            bntSync.Name = "bntSync";
            bntSync.ShadowDecoration.BorderRadius = 15;
            bntSync.ShadowDecoration.Color = Color.LightGray;
            bntSync.ShadowDecoration.Depth = 20;
            bntSync.ShadowDecoration.Enabled = true;
            bntSync.Click += bntSync_Click;
            // 
            // lblVersion_left
            // 
            resources.ApplyResources(lblVersion_left, "lblVersion_left");
            lblVersion_left.BackColor = Color.Transparent;
            lblVersion_left.ForeColor = Color.Silver;
            lblVersion_left.Name = "lblVersion_left";
            // 
            // uiSetup
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2Panel1);
            Controls.Add(sPanel1);
            Name = "uiSetup";
            Load += uiSetup_Load;
            sPanel1.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblVersion;
        private Label label4;
        private Sipaa.Framework.SPanel sPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button bntSync;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private RichTextBox richText;
        private Guna.UI2.WinForms.Guna2CheckBox CheckBox;
        private Label lblVersion_left;
    }
}