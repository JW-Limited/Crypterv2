namespace LILO_Packager.v2.Forms
{
    partial class uiCustomProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiCustomProcess));
            lblMessage = new Label();
            sPanel2 = new Sipaa.Framework.SPanel();
            bntOk = new Guna.UI2.WinForms.Guna2Button();
            progress = new Guna.UI2.WinForms.Guna2ProgressBar();
            sPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblMessage
            // 
            resources.ApplyResources(lblMessage, "lblMessage");
            lblMessage.BackColor = Color.Transparent;
            lblMessage.ForeColor = Color.Black;
            lblMessage.Name = "lblMessage";
            // 
            // sPanel2
            // 
            sPanel2.BackColor = Color.WhiteSmoke;
            resources.ApplyResources(sPanel2, "sPanel2");
            sPanel2.BorderColor = Color.Black;
            sPanel2.BorderRadius = 0;
            sPanel2.BorderSize = 0;
            sPanel2.Controls.Add(bntOk);
            sPanel2.ForeColor = Color.White;
            sPanel2.Name = "sPanel2";
            // 
            // bntOk
            // 
            resources.ApplyResources(bntOk, "bntOk");
            bntOk.Animated = true;
            bntOk.BackColor = Color.Transparent;
            bntOk.BorderColor = Color.Gainsboro;
            bntOk.BorderRadius = 14;
            bntOk.BorderThickness = 2;
            bntOk.DisabledState.BorderColor = Color.DarkGray;
            bntOk.DisabledState.CustomBorderColor = Color.DarkGray;
            bntOk.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntOk.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntOk.FillColor = Color.White;
            bntOk.FocusedColor = Color.FromArgb(100, 170, 209);
            bntOk.ForeColor = Color.Black;
            bntOk.Name = "bntOk";
            bntOk.Click += bntOk_Click;
            // 
            // progress
            // 
            resources.ApplyResources(progress, "progress");
            progress.BackColor = Color.Transparent;
            progress.BorderColor = Color.Gainsboro;
            progress.BorderRadius = 10;
            progress.BorderThickness = 2;
            progress.FillColor = Color.Transparent;
            progress.Name = "progress";
            progress.ProgressColor = Color.DeepSkyBlue;
            progress.ProgressColor2 = Color.RoyalBlue;
            progress.ShowText = true;
            progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            progress.ValueChanged += progress_ValueChanged;
            // 
            // uiCustomProcess
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ControlBox = false;
            Controls.Add(progress);
            Controls.Add(lblMessage);
            Controls.Add(sPanel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "uiCustomProcess";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += uiCustomProcess_Load;
            sPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblMessage;
        private Sipaa.Framework.SPanel sPanel2;
        private Guna.UI2.WinForms.Guna2Button bntOk;
        private Guna.UI2.WinForms.Guna2ProgressBar progress;
    }
}