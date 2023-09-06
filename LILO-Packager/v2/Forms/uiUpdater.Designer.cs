namespace LILO_Packager.v2.Forms
{
    partial class uiUpdater
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
            progress = new Guna.UI2.WinForms.Guna2ProgressBar();
            label1 = new Label();
            bntCancel = new Guna.UI2.WinForms.Guna2Button();
            lblExc = new Label();
            pnlImg = new Sipaa.Framework.SPanel();
            label2 = new Label();
            lblVerison = new Label();
            bntRestart = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // progress
            // 
            progress.Anchor = AnchorStyles.None;
            progress.BackColor = Color.Transparent;
            progress.BorderColor = Color.DarkGray;
            progress.BorderRadius = 20;
            progress.BorderThickness = 2;
            progress.FillColor = Color.White;
            progress.Location = new Point(196, 480);
            progress.Margin = new Padding(2);
            progress.Name = "progress";
            progress.ProgressColor = Color.DeepSkyBlue;
            progress.ProgressColor2 = Color.RoyalBlue;
            progress.ShowText = true;
            progress.Size = new Size(704, 45);
            progress.TabIndex = 18;
            progress.Text = "guna2ProgressBar1";
            progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(448, 744);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 40);
            label1.TabIndex = 32;
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
            bntCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bntCancel.ForeColor = Color.DimGray;
            bntCancel.Location = new Point(940, 24);
            bntCancel.Margin = new Padding(2);
            bntCancel.Name = "bntCancel";
            bntCancel.Size = new Size(124, 40);
            bntCancel.TabIndex = 31;
            bntCancel.Text = "Cancel";
            bntCancel.Click += bntCancel_Click;
            // 
            // lblExc
            // 
            lblExc.Anchor = AnchorStyles.None;
            lblExc.BackColor = Color.Transparent;
            lblExc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblExc.ForeColor = Color.Black;
            lblExc.Location = new Point(316, 424);
            lblExc.Margin = new Padding(4, 0, 4, 0);
            lblExc.Name = "lblExc";
            lblExc.Size = new Size(464, 40);
            lblExc.TabIndex = 29;
            lblExc.Text = "Please dont close the Application";
            lblExc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlImg
            // 
            pnlImg.Anchor = AnchorStyles.None;
            pnlImg.BackColor = Color.White;
            pnlImg.BackgroundImage = Properties.Resources.icons8_synchronize_240;
            pnlImg.BackgroundImageLayout = ImageLayout.Zoom;
            pnlImg.BorderColor = Color.Black;
            pnlImg.BorderRadius = 20;
            pnlImg.BorderSize = 0;
            pnlImg.ForeColor = Color.White;
            pnlImg.Location = new Point(432, 280);
            pnlImg.Margin = new Padding(4);
            pnlImg.Name = "pnlImg";
            pnlImg.Size = new Size(232, 120);
            pnlImg.TabIndex = 33;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(480, 720);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 34;
            label2.Text = "powered by ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVerison
            // 
            lblVerison.BackColor = Color.Transparent;
            lblVerison.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblVerison.ForeColor = Color.Silver;
            lblVerison.Location = new Point(32, 24);
            lblVerison.Margin = new Padding(4, 0, 4, 0);
            lblVerison.Name = "lblVerison";
            lblVerison.Size = new Size(120, 40);
            lblVerison.TabIndex = 34;
            lblVerison.Text = "v/n";
            lblVerison.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bntRestart
            // 
            bntRestart.Anchor = AnchorStyles.None;
            bntRestart.Animated = true;
            bntRestart.BackColor = Color.Transparent;
            bntRestart.BorderColor = Color.Gainsboro;
            bntRestart.BorderRadius = 12;
            bntRestart.BorderThickness = 2;
            bntRestart.DisabledState.BorderColor = Color.DarkGray;
            bntRestart.DisabledState.CustomBorderColor = Color.DarkGray;
            bntRestart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntRestart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntRestart.FillColor = Color.White;
            bntRestart.FocusedColor = Color.FromArgb(100, 170, 209);
            bntRestart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bntRestart.ForeColor = Color.DimGray;
            bntRestart.Location = new Point(432, 488);
            bntRestart.Margin = new Padding(2);
            bntRestart.Name = "bntRestart";
            bntRestart.Size = new Size(232, 40);
            bntRestart.TabIndex = 31;
            bntRestart.Text = "Restart now!";
            bntRestart.Visible = false;
            bntRestart.Click += bntRestart_Click;
            // 
            // uiUpdater
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1082, 826);
            Controls.Add(lblVerison);
            Controls.Add(label2);
            Controls.Add(pnlImg);
            Controls.Add(label1);
            Controls.Add(bntRestart);
            Controls.Add(bntCancel);
            Controls.Add(lblExc);
            Controls.Add(progress);
            Margin = new Padding(2);
            Name = "uiUpdater";
            Text = "uiUpdater";
            Load += uiUpdater_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar progress;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button bntCancel;
        private Label lblExc;
        private Sipaa.Framework.SPanel pnlImg;
        private Label label2;
        private Label lblVerison;
        private Guna.UI2.WinForms.Guna2Button bntRestart;
    }
}