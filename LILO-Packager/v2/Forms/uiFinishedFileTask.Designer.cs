namespace LILO_Packager.v2.Forms
{
    partial class uiFinishedFileTask
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
            sPanel1 = new Sipaa.Framework.SPanel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            sPanel2 = new Sipaa.Framework.SPanel();
            lblType = new Label();
            lblFile = new Label();
            pnlPluginIcon = new Sipaa.Framework.SPanel();
            sPanel1.SuspendLayout();
            sPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // sPanel1
            // 
            sPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sPanel1.BackColor = Color.WhiteSmoke;
            sPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel1.BorderColor = Color.Gainsboro;
            sPanel1.BorderRadius = 20;
            sPanel1.BorderSize = 2;
            sPanel1.Controls.Add(guna2Button1);
            sPanel1.Controls.Add(guna2Button2);
            sPanel1.ForeColor = Color.White;
            sPanel1.Location = new Point(24, 24);
            sPanel1.Margin = new Padding(4);
            sPanel1.Name = "sPanel1";
            sPanel1.Size = new Size(403, 576);
            sPanel1.TabIndex = 15;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2Button1.BorderColor = Color.Gainsboro;
            guna2Button1.BorderRadius = 20;
            guna2Button1.BorderThickness = 2;
            guna2Button1.CustomizableEdges.BottomLeft = false;
            guna2Button1.CustomizableEdges.TopLeft = false;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.DimGray;
            guna2Button1.HoverState.BorderColor = Color.LightGray;
            guna2Button1.HoverState.FillColor = Color.Gainsboro;
            guna2Button1.HoverState.ForeColor = SystemColors.ControlDark;
            guna2Button1.Image = Properties.Resources.icons8_share_240;
            guna2Button1.ImageSize = new Size(30, 30);
            guna2Button1.Location = new Point(296, 480);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(72, 64);
            guna2Button1.TabIndex = 16;
            guna2Button1.Click += bntShare;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button2.Animated = true;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BackgroundImageLayout = ImageLayout.Zoom;
            guna2Button2.BorderColor = Color.Gainsboro;
            guna2Button2.BorderRadius = 20;
            guna2Button2.BorderThickness = 2;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.White;
            guna2Button2.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            guna2Button2.ForeColor = Color.DimGray;
            guna2Button2.HoverState.BorderColor = Color.LightGray;
            guna2Button2.HoverState.FillColor = Color.Gainsboro;
            guna2Button2.HoverState.ForeColor = SystemColors.ControlDark;
            guna2Button2.Location = new Point(32, 480);
            guna2Button2.Margin = new Padding(2);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(296, 64);
            guna2Button2.TabIndex = 16;
            guna2Button2.Text = "Done";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // sPanel2
            // 
            sPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sPanel2.BackColor = Color.White;
            sPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel2.BorderColor = Color.Gainsboro;
            sPanel2.BorderRadius = 20;
            sPanel2.BorderSize = 2;
            sPanel2.Controls.Add(lblType);
            sPanel2.Controls.Add(lblFile);
            sPanel2.Controls.Add(pnlPluginIcon);
            sPanel2.ForeColor = Color.White;
            sPanel2.Location = new Point(56, 56);
            sPanel2.Margin = new Padding(4);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(339, 352);
            sPanel2.TabIndex = 15;
            // 
            // lblType
            // 
            lblType.AutoEllipsis = true;
            lblType.BackColor = Color.Transparent;
            lblType.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblType.ForeColor = SystemColors.WindowFrame;
            lblType.ImeMode = ImeMode.NoControl;
            lblType.Location = new Point(48, 224);
            lblType.Margin = new Padding(4, 0, 4, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(240, 40);
            lblType.TabIndex = 56;
            lblType.Text = "Cryptex Manager";
            lblType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFile
            // 
            lblFile.BackColor = Color.Transparent;
            lblFile.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblFile.ForeColor = Color.Silver;
            lblFile.ImeMode = ImeMode.NoControl;
            lblFile.Location = new Point(48, 272);
            lblFile.Margin = new Padding(4, 0, 4, 0);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(240, 56);
            lblFile.TabIndex = 57;
            lblFile.Text = "Manager";
            lblFile.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlPluginIcon
            // 
            pnlPluginIcon.BackColor = SystemColors.Window;
            pnlPluginIcon.BackgroundImage = Properties.Resources.Screenshot_2023_10_13_052005;
            pnlPluginIcon.BackgroundImageLayout = ImageLayout.Zoom;
            pnlPluginIcon.BorderColor = Color.Gainsboro;
            pnlPluginIcon.BorderRadius = 20;
            pnlPluginIcon.BorderSize = 0;
            pnlPluginIcon.ForeColor = Color.White;
            pnlPluginIcon.Location = new Point(104, 64);
            pnlPluginIcon.Margin = new Padding(4);
            pnlPluginIcon.Name = "pnlPluginIcon";
            pnlPluginIcon.Size = new Size(128, 120);
            pnlPluginIcon.TabIndex = 55;
            // 
            // uiFinishedFileTask
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(457, 623);
            Controls.Add(sPanel2);
            Controls.Add(sPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "uiFinishedFileTask";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Finished Task";
            Load += uiFinishedFileTask_Load;
            sPanel1.ResumeLayout(false);
            sPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sipaa.Framework.SPanel sPanel1;
        private Sipaa.Framework.SPanel sPanel2;
        private Label lblType;
        private Label lblFile;
        private Sipaa.Framework.SPanel pnlPluginIcon;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}