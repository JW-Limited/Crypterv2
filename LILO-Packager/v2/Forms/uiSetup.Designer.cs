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
            lblVersion = new Label();
            label4 = new Label();
            sPanel1 = new Sipaa.Framework.SPanel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            bntSync = new Guna.UI2.WinForms.Guna2Button();
            dynamikFileListItem3 = new Controls.DynamikFileListItem();
            sPanel1.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblVersion
            // 
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVersion.ForeColor = Color.Silver;
            lblVersion.Location = new Point(192, 56);
            lblVersion.Margin = new Padding(4, 0, 4, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(192, 30);
            lblVersion.TabIndex = 49;
            lblVersion.Text = "to Crypterv2";
            lblVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(48, 48);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(224, 40);
            label4.TabIndex = 48;
            label4.Text = "Welcome,";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // sPanel1
            // 
            sPanel1.BackColor = Color.White;
            sPanel1.BackgroundImage = Properties.Resources.pexels_johannes_plenio_1103970;
            sPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel1.BorderColor = Color.Gainsboro;
            sPanel1.BorderRadius = 0;
            sPanel1.BorderSize = 0;
            sPanel1.Controls.Add(panel1);
            sPanel1.Controls.Add(panel2);
            sPanel1.Dock = DockStyle.Fill;
            sPanel1.ForeColor = Color.White;
            sPanel1.Location = new Point(0, 0);
            sPanel1.Margin = new Padding(4);
            sPanel1.Name = "sPanel1";
            sPanel1.Size = new Size(472, 723);
            sPanel1.TabIndex = 46;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.HighlightText;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(dynamikFileListItem3);
            guna2Panel1.Controls.Add(bntSync);
            guna2Panel1.Controls.Add(lblVersion);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.CustomizableEdges.BottomLeft = false;
            guna2Panel1.CustomizableEdges.BottomRight = false;
            guna2Panel1.CustomizableEdges.TopLeft = false;
            guna2Panel1.CustomizableEdges.TopRight = false;
            guna2Panel1.Dock = DockStyle.Right;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(472, 0);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(657, 723);
            guna2Panel1.TabIndex = 45;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.favico;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(80, 288);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 144);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(192, 312);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 96);
            panel2.TabIndex = 1;
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
            bntSync.Location = new Point(424, 656);
            bntSync.Margin = new Padding(2);
            bntSync.Name = "bntSync";
            bntSync.ShadowDecoration.BorderRadius = 15;
            bntSync.ShadowDecoration.Color = Color.LightGray;
            bntSync.ShadowDecoration.Depth = 20;
            bntSync.ShadowDecoration.Enabled = true;
            bntSync.Size = new Size(192, 40);
            bntSync.TabIndex = 51;
            bntSync.Text = "Continue";
            // 
            // dynamikFileListItem3
            // 
            dynamikFileListItem3.Entry = null;
            dynamikFileListItem3.Location = new Point(48, 552);
            dynamikFileListItem3.Margin = new Padding(4, 4, 4, 4);
            dynamikFileListItem3.Name = "dynamikFileListItem3";
            dynamikFileListItem3.PluginName = "Developer";
            dynamikFileListItem3.PluginVersion = "Enables the developer Mode";
            dynamikFileListItem3.ShowedInstance = null;
            dynamikFileListItem3.Size = new Size(568, 80);
            dynamikFileListItem3.TabIndex = 52;
            // 
            // uiSetup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1129, 723);
            Controls.Add(sPanel1);
            Controls.Add(guna2Panel1);
            Name = "uiSetup";
            Text = "uiSetup";
            sPanel1.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblVersion;
        private Label label4;
        private Sipaa.Framework.SPanel sPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Panel panel1;
        private Panel panel2;
        private Controls.DynamikFileListItem dynamikFileListItem3;
        private Guna.UI2.WinForms.Guna2Button bntSync;
    }
}