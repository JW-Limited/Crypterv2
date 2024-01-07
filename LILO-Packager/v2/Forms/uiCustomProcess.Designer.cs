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
            lblMessage = new Label();
            sPanel2 = new Sipaa.Framework.SPanel();
            bntOk = new Guna.UI2.WinForms.Guna2Button();
            progress = new Guna.UI2.WinForms.Guna2ProgressBar();
            sPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Font = new Font("Segoe UI", 10F);
            lblMessage.ForeColor = Color.Black;
            lblMessage.Location = new Point(32, 32);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(600, 32);
            lblMessage.TabIndex = 17;
            lblMessage.Text = "MessageText";
            // 
            // sPanel2
            // 
            sPanel2.BackColor = Color.WhiteSmoke;
            sPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel2.BorderColor = Color.Black;
            sPanel2.BorderRadius = 0;
            sPanel2.BorderSize = 0;
            sPanel2.Controls.Add(bntOk);
            sPanel2.Dock = DockStyle.Bottom;
            sPanel2.ForeColor = Color.White;
            sPanel2.Location = new Point(0, 152);
            sPanel2.Margin = new Padding(4);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(667, 73);
            sPanel2.TabIndex = 18;
            // 
            // bntOk
            // 
            bntOk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntOk.Animated = true;
            bntOk.BackColor = Color.Transparent;
            bntOk.BackgroundImageLayout = ImageLayout.Zoom;
            bntOk.BorderColor = Color.Gainsboro;
            bntOk.BorderRadius = 14;
            bntOk.BorderThickness = 2;
            bntOk.DisabledState.BorderColor = Color.DarkGray;
            bntOk.DisabledState.CustomBorderColor = Color.DarkGray;
            bntOk.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntOk.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntOk.FillColor = Color.White;
            bntOk.FocusedColor = Color.FromArgb(100, 170, 209);
            bntOk.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            bntOk.ForeColor = Color.Black;
            bntOk.Location = new Point(440, 16);
            bntOk.Margin = new Padding(2);
            bntOk.Name = "bntOk";
            bntOk.Size = new Size(216, 40);
            bntOk.TabIndex = 15;
            bntOk.Text = "Cancel";
            bntOk.Click += bntOk_Click;
            // 
            // progress
            // 
            progress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progress.BackColor = Color.Transparent;
            progress.BorderColor = Color.Gainsboro;
            progress.BorderRadius = 10;
            progress.BorderThickness = 2;
            progress.FillColor = Color.Transparent;
            progress.Location = new Point(32, 80);
            progress.Margin = new Padding(2);
            progress.Name = "progress";
            progress.ProgressColor = Color.DeepSkyBlue;
            progress.ProgressColor2 = Color.RoyalBlue;
            progress.ShowText = true;
            progress.Size = new Size(600, 40);
            progress.TabIndex = 19;
            progress.Text = "guna2ProgressBar1";
            progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            progress.ValueChanged += progress_ValueChanged;
            // 
            // uiCustomProcess
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(667, 225);
            ControlBox = false;
            Controls.Add(progress);
            Controls.Add(lblMessage);
            Controls.Add(sPanel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "uiCustomProcess";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "uiCustomProcess";
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