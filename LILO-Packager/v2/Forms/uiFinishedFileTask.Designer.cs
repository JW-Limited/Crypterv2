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
            progress1 = new Guna.UI2.WinForms.Guna2ProgressBar();
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
            sPanel1.Controls.Add(progress1);
            sPanel1.ForeColor = Color.White;
            sPanel1.Location = new Point(24, 24);
            sPanel1.Margin = new Padding(4);
            sPanel1.Name = "sPanel1";
            sPanel1.Size = new Size(403, 576);
            sPanel1.TabIndex = 15;
            // 
            // progress1
            // 
            progress1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progress1.BackColor = Color.Transparent;
            progress1.BorderColor = Color.Gainsboro;
            progress1.BorderRadius = 20;
            progress1.BorderThickness = 2;
            progress1.FillColor = Color.White;
            progress1.ForeColor = Color.Black;
            progress1.Location = new Point(32, 480);
            progress1.Margin = new Padding(2);
            progress1.Name = "progress1";
            progress1.ProgressColor = Color.DeepSkyBlue;
            progress1.ProgressColor2 = Color.RoyalBlue;
            progress1.ShowText = true;
            progress1.Size = new Size(339, 56);
            progress1.TabIndex = 17;
            progress1.Text = "guna2ProgressBar1";
            progress1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
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
            Name = "uiFinishedFileTask";
            StartPosition = FormStartPosition.CenterParent;
            Text = "uiFinishedFileTask";
            Load += uiFinishedFileTask_Load;
            sPanel1.ResumeLayout(false);
            sPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sipaa.Framework.SPanel sPanel1;
        private Sipaa.Framework.SPanel sPanel2;
        private Guna.UI2.WinForms.Guna2ProgressBar progress1;
        private Label lblType;
        private Label lblFile;
        private Sipaa.Framework.SPanel pnlPluginIcon;
    }
}