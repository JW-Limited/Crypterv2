namespace Crypterv2.DevTool.Core.Forms
{
    partial class uiPluginPackageView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiPluginPackageView));
            pnlSucces = new Guna.UI2.WinForms.Guna2Panel();
            sPanel1 = new Sipaa.Framework.SPanel();
            label3 = new Label();
            bntPublishToStore = new Guna.UI2.WinForms.Guna2Button();
            bntStart = new Guna.UI2.WinForms.Guna2Button();
            lblDirectory = new LinkLabel();
            lblPlugin = new Label();
            label5 = new Label();
            label6 = new Label();
            lblVerison = new Label();
            label2 = new Label();
            label1 = new Label();
            bntCancel = new Guna.UI2.WinForms.Guna2Button();
            pnlSucces.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSucces
            // 
            pnlSucces.Anchor = AnchorStyles.None;
            pnlSucces.BackColor = Color.Transparent;
            pnlSucces.BorderColor = Color.Gainsboro;
            pnlSucces.BorderRadius = 15;
            pnlSucces.BorderThickness = 2;
            pnlSucces.Controls.Add(sPanel1);
            pnlSucces.Controls.Add(label3);
            pnlSucces.Controls.Add(bntPublishToStore);
            pnlSucces.Controls.Add(bntStart);
            pnlSucces.FillColor = Color.White;
            pnlSucces.Location = new Point(216, 240);
            pnlSucces.Margin = new Padding(2);
            pnlSucces.Name = "pnlSucces";
            pnlSucces.Size = new Size(512, 330);
            pnlSucces.TabIndex = 41;
            // 
            // sPanel1
            // 
            sPanel1.Anchor = AnchorStyles.None;
            sPanel1.BackColor = Color.White;
            sPanel1.BackgroundImage = (Image)resources.GetObject("sPanel1.BackgroundImage");
            sPanel1.BackgroundImageLayout = ImageLayout.Zoom;
            sPanel1.BorderColor = Color.Gainsboro;
            sPanel1.BorderRadius = 20;
            sPanel1.BorderSize = 0;
            sPanel1.ForeColor = Color.White;
            sPanel1.Location = new Point(8, 56);
            sPanel1.Margin = new Padding(4);
            sPanel1.Name = "sPanel1";
            sPanel1.Size = new Size(496, 110);
            sPanel1.TabIndex = 42;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(8, 176);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(496, 30);
            label3.TabIndex = 45;
            label3.Text = "Success";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bntPublishToStore
            // 
            bntPublishToStore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntPublishToStore.Animated = true;
            bntPublishToStore.BackColor = Color.Transparent;
            bntPublishToStore.BorderColor = Color.Gainsboro;
            bntPublishToStore.BorderRadius = 12;
            bntPublishToStore.BorderThickness = 2;
            bntPublishToStore.DisabledState.BorderColor = Color.DarkGray;
            bntPublishToStore.DisabledState.CustomBorderColor = Color.DarkGray;
            bntPublishToStore.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntPublishToStore.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntPublishToStore.FocusedColor = Color.FromArgb(100, 170, 209);
            bntPublishToStore.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bntPublishToStore.ForeColor = Color.White;
            bntPublishToStore.Location = new Point(216, 264);
            bntPublishToStore.Margin = new Padding(2);
            bntPublishToStore.Name = "bntPublishToStore";
            bntPublishToStore.Size = new Size(264, 40);
            bntPublishToStore.TabIndex = 35;
            bntPublishToStore.Text = "Publish";
            bntPublishToStore.Click += bntPublishToStore_Click;
            // 
            // bntStart
            // 
            bntStart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntStart.Animated = true;
            bntStart.BackColor = Color.Transparent;
            bntStart.BorderColor = Color.Gainsboro;
            bntStart.BorderRadius = 12;
            bntStart.BorderThickness = 2;
            bntStart.DisabledState.BorderColor = Color.DarkGray;
            bntStart.DisabledState.CustomBorderColor = Color.DarkGray;
            bntStart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntStart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntStart.FillColor = Color.White;
            bntStart.FocusedColor = Color.FromArgb(100, 170, 209);
            bntStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bntStart.ForeColor = Color.DimGray;
            bntStart.Location = new Point(40, 264);
            bntStart.Margin = new Padding(2);
            bntStart.Name = "bntStart";
            bntStart.Size = new Size(160, 40);
            bntStart.TabIndex = 35;
            bntStart.Text = "Start";
            bntStart.Click += bntStart_Click;
            // 
            // lblDirectory
            // 
            lblDirectory.AutoEllipsis = true;
            lblDirectory.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDirectory.LinkColor = Color.FromArgb(94, 148, 255);
            lblDirectory.Location = new Point(434, 638);
            lblDirectory.Name = "lblDirectory";
            lblDirectory.Size = new Size(192, 40);
            lblDirectory.TabIndex = 50;
            lblDirectory.TabStop = true;
            lblDirectory.Text = "n/a";
            lblDirectory.TextAlign = ContentAlignment.MiddleLeft;
            lblDirectory.Visible = false;
            // 
            // lblPlugin
            // 
            lblPlugin.Anchor = AnchorStyles.None;
            lblPlugin.AutoEllipsis = true;
            lblPlugin.AutoSize = true;
            lblPlugin.BackColor = Color.White;
            lblPlugin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPlugin.Location = new Point(254, 218);
            lblPlugin.Margin = new Padding(2, 0, 2, 0);
            lblPlugin.Name = "lblPlugin";
            lblPlugin.Padding = new Padding(4, 0, 4, 0);
            lblPlugin.Size = new Size(50, 28);
            lblPlugin.TabIndex = 47;
            lblPlugin.Text = "n/a";
            lblPlugin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(314, 686);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 40);
            label5.TabIndex = 48;
            label5.Text = "Plugin:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            label5.Visible = false;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(314, 638);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 40);
            label6.TabIndex = 49;
            label6.Text = "Directory:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.Visible = false;
            // 
            // lblVerison
            // 
            lblVerison.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblVerison.BackColor = Color.Transparent;
            lblVerison.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblVerison.ForeColor = Color.Silver;
            lblVerison.Location = new Point(0, 816);
            lblVerison.Margin = new Padding(4, 0, 4, 0);
            lblVerison.Name = "lblVerison";
            lblVerison.Size = new Size(200, 40);
            lblVerison.TabIndex = 44;
            lblVerison.Text = "v/n";
            lblVerison.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(402, 752);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 45;
            label2.Text = "powered by ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(369, 776);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 40);
            label1.TabIndex = 43;
            label1.Text = "JW Limited ©️ 2023";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bntCancel
            // 
            bntCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntCancel.Animated = true;
            bntCancel.BackColor = Color.Transparent;
            bntCancel.BorderColor = Color.Gainsboro;
            bntCancel.BorderRadius = 12;
            bntCancel.BorderThickness = 2;
            bntCancel.DisabledState.BorderColor = Color.DarkGray;
            bntCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            bntCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntCancel.FillColor = Color.White;
            bntCancel.FocusedColor = Color.FromArgb(100, 170, 209);
            bntCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bntCancel.ForeColor = Color.DimGray;
            bntCancel.Location = new Point(800, 24);
            bntCancel.Margin = new Padding(2);
            bntCancel.Name = "bntCancel";
            bntCancel.Size = new Size(125, 40);
            bntCancel.TabIndex = 42;
            bntCancel.Text = "Close";
            bntCancel.Click += bntCancel_Click;
            // 
            // uiPluginPackageView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(945, 852);
            ControlBox = false;
            Controls.Add(lblDirectory);
            Controls.Add(label6);
            Controls.Add(lblPlugin);
            Controls.Add(pnlSucces);
            Controls.Add(label5);
            Controls.Add(lblVerison);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bntCancel);
            MinimumSize = new Size(872, 677);
            Name = "uiPluginPackageView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Package View";
            Load += uiPluginPackageView_Load;
            pnlSucces.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlSucces;
        private Sipaa.Framework.SPanel sPanel1;
        private Guna.UI2.WinForms.Guna2Button bntStart;
        private Label lblVerison;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button bntCancel;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button bntPublishToStore;
        private Label lblPlugin;
        private Label label5;
        private Label label6;
        private LinkLabel lblDirectory;
    }
}