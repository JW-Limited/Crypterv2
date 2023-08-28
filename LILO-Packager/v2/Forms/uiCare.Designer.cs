namespace LILO_Packager.v2.Forms
{
    partial class uiCare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiCare));
            guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            progressSpinner = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            bntCancel = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            lblInfos = new Label();
            lanb = new Label();
            guna2Panel6.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel6
            // 
            guna2Panel6.Anchor = AnchorStyles.Top;
            guna2Panel6.BackColor = Color.Transparent;
            guna2Panel6.BorderColor = SystemColors.ActiveBorder;
            guna2Panel6.BorderRadius = 15;
            guna2Panel6.BorderThickness = 2;
            guna2Panel6.Controls.Add(progressSpinner);
            guna2Panel6.Controls.Add(bntCancel);
            guna2Panel6.Controls.Add(label1);
            guna2Panel6.Controls.Add(lblInfos);
            guna2Panel6.Controls.Add(lanb);
            guna2Panel6.FillColor = Color.White;
            guna2Panel6.Location = new Point(64, 56);
            guna2Panel6.Margin = new Padding(2);
            guna2Panel6.Name = "guna2Panel6";
            guna2Panel6.Size = new Size(752, 328);
            guna2Panel6.TabIndex = 17;
            // 
            // progressSpinner
            // 
            progressSpinner.Anchor = AnchorStyles.None;
            progressSpinner.AutoStart = true;
            progressSpinner.BackColor = Color.White;
            progressSpinner.Location = new Point(336, 104);
            progressSpinner.Name = "progressSpinner";
            progressSpinner.Size = new Size(96, 96);
            progressSpinner.TabIndex = 19;
            progressSpinner.Visible = false;
            // 
            // bntCancel
            // 
            bntCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntCancel.Animated = true;
            bntCancel.AnimatedGIF = true;
            bntCancel.BackColor = Color.Transparent;
            bntCancel.BorderColor = Color.Gainsboro;
            bntCancel.BorderRadius = 20;
            bntCancel.BorderThickness = 2;
            bntCancel.DisabledState.BorderColor = Color.DarkGray;
            bntCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            bntCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntCancel.FillColor = Color.Transparent;
            bntCancel.FocusedColor = Color.FromArgb(100, 170, 209);
            bntCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            bntCancel.ForeColor = Color.Black;
            bntCancel.Location = new Point(40, 248);
            bntCancel.Margin = new Padding(2);
            bntCancel.Name = "bntCancel";
            bntCancel.Size = new Size(680, 48);
            bntCancel.TabIndex = 18;
            bntCancel.Text = "Start";
            bntCancel.Click += bntCancel_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(672, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 56);
            label1.TabIndex = 15;
            label1.Text = "v0.2";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblInfos
            // 
            lblInfos.BackColor = Color.Transparent;
            lblInfos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfos.Location = new Point(48, 88);
            lblInfos.Margin = new Padding(2, 0, 2, 0);
            lblInfos.Name = "lblInfos";
            lblInfos.Size = new Size(552, 152);
            lblInfos.TabIndex = 15;
            // 
            // lanb
            // 
            lanb.BackColor = Color.Transparent;
            lanb.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lanb.Location = new Point(40, 24);
            lanb.Margin = new Padding(2, 0, 2, 0);
            lanb.Name = "lanb";
            lanb.Size = new Size(272, 64);
            lanb.TabIndex = 15;
            lanb.Text = "Troubleshooter";
            lanb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiCare
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Moonlit_Asteroid;
            ClientSize = new Size(871, 452);
            ControlBox = false;
            Controls.Add(guna2Panel6);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(893, 508);
            MinimumSize = new Size(893, 508);
            Name = "uiCare";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += uiCare_Load;
            guna2Panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Label lanb;
        private Guna.UI2.WinForms.Guna2Button bntCancel;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator progressSpinner;
        private Label lblInfos;
        private Label label1;
    }
}