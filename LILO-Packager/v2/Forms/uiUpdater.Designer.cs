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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiUpdater));
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
            resources.ApplyResources(progress, "progress");
            progress.BackColor = Color.Transparent;
            progress.BorderColor = Color.DarkGray;
            progress.BorderRadius = 20;
            progress.BorderThickness = 2;
            progress.FillColor = Color.White;
            progress.Name = "progress";
            progress.ProgressColor = Color.DeepSkyBlue;
            progress.ProgressColor2 = Color.RoyalBlue;
            progress.ShowText = true;
            progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Name = "label1";
            // 
            // bntCancel
            // 
            resources.ApplyResources(bntCancel, "bntCancel");
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
            bntCancel.ForeColor = Color.DimGray;
            bntCancel.Name = "bntCancel";
            bntCancel.Click += bntCancel_Click;
            // 
            // lblExc
            // 
            resources.ApplyResources(lblExc, "lblExc");
            lblExc.BackColor = Color.Transparent;
            lblExc.ForeColor = Color.Black;
            lblExc.Name = "lblExc";
            // 
            // pnlImg
            // 
            resources.ApplyResources(pnlImg, "pnlImg");
            pnlImg.BackColor = Color.White;
            pnlImg.BackgroundImage = Properties.Resources.icons8_synchronize_240;
            pnlImg.BorderColor = Color.Black;
            pnlImg.BorderRadius = 20;
            pnlImg.BorderSize = 0;
            pnlImg.ForeColor = Color.White;
            pnlImg.Name = "pnlImg";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Silver;
            label2.Name = "label2";
            // 
            // lblVerison
            // 
            lblVerison.BackColor = Color.Transparent;
            resources.ApplyResources(lblVerison, "lblVerison");
            lblVerison.ForeColor = Color.Silver;
            lblVerison.Name = "lblVerison";
            // 
            // bntRestart
            // 
            resources.ApplyResources(bntRestart, "bntRestart");
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
            bntRestart.ForeColor = Color.DimGray;
            bntRestart.Name = "bntRestart";
            bntRestart.Click += bntRestart_Click;
            // 
            // uiUpdater
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblVerison);
            Controls.Add(label2);
            Controls.Add(pnlImg);
            Controls.Add(label1);
            Controls.Add(bntRestart);
            Controls.Add(bntCancel);
            Controls.Add(lblExc);
            Controls.Add(progress);
            Name = "uiUpdater";
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