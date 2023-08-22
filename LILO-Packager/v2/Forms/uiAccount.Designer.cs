namespace LILO_Packager.v2.Forms
{
    partial class uiAccount
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
            sPanel2 = new Sipaa.Framework.SPanel();
            bntSettings = new Guna.UI2.WinForms.Guna2Button();
            lblText = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            lblUsername = new Label();
            lblEmail = new Label();
            lblUser = new Label();
            sPanel1 = new Sipaa.Framework.SPanel();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            label8 = new Label();
            label3 = new Label();
            sPanel3 = new Sipaa.Framework.SPanel();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            label7 = new Label();
            label4 = new Label();
            sPanel4 = new Sipaa.Framework.SPanel();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            label6 = new Label();
            label5 = new Label();
            videoPanel = new Sipaa.Framework.SPanel();
            sPanel2.SuspendLayout();
            sPanel1.SuspendLayout();
            sPanel3.SuspendLayout();
            sPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // sPanel2
            // 
            sPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sPanel2.BackColor = Color.Black;
            sPanel2.BackgroundImage = Properties.Resources.Aqua_Marine_180degree;
            sPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel2.BorderColor = Color.Black;
            sPanel2.BorderRadius = 20;
            sPanel2.BorderSize = 0;
            sPanel2.Controls.Add(bntSettings);
            sPanel2.Controls.Add(lblText);
            sPanel2.ForeColor = Color.White;
            sPanel2.Location = new Point(24, 32);
            sPanel2.Margin = new Padding(4);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(968, 88);
            sPanel2.TabIndex = 14;
            // 
            // bntSettings
            // 
            bntSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntSettings.Animated = true;
            bntSettings.BackColor = Color.Transparent;
            bntSettings.BorderColor = Color.Gainsboro;
            bntSettings.BorderRadius = 20;
            bntSettings.BorderThickness = 2;
            bntSettings.DisabledState.BorderColor = Color.DarkGray;
            bntSettings.DisabledState.CustomBorderColor = Color.DarkGray;
            bntSettings.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntSettings.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntSettings.FillColor = Color.Transparent;
            bntSettings.FocusedColor = Color.FromArgb(100, 170, 209);
            bntSettings.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            bntSettings.ForeColor = Color.White;
            bntSettings.Location = new Point(824, 16);
            bntSettings.Margin = new Padding(2);
            bntSettings.Name = "bntSettings";
            bntSettings.Size = new Size(128, 58);
            bntSettings.TabIndex = 14;
            bntSettings.Text = "Settings";
            bntSettings.Click += bntSettings_Click;
            // 
            // lblText
            // 
            lblText.BackColor = Color.Transparent;
            lblText.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblText.ForeColor = Color.White;
            lblText.Location = new Point(24, 0);
            lblText.Margin = new Padding(4, 0, 4, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(144, 88);
            lblText.TabIndex = 1;
            lblText.Text = "Account";
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button1.BorderColor = SystemColors.Control;
            guna2Button1.BorderRadius = 15;
            guna2Button1.BorderThickness = 2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Red;
            guna2Button1.Font = new Font("Open Sans SemiBold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(848, 216);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(128, 58);
            guna2Button1.TabIndex = 17;
            guna2Button1.Text = "Abmelden";
            guna2Button1.Click += bntCancel_Click;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Open Sans", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(182, 196);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(464, 32);
            lblUsername.TabIndex = 16;
            lblUsername.Text = "n/a";
            lblUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Open Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(184, 232);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(462, 32);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "n/a";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUser
            // 
            lblUser.Font = new Font("Open Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(184, 264);
            lblUser.Margin = new Padding(2, 0, 2, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(462, 32);
            lblUser.TabIndex = 16;
            lblUser.Text = "n/a";
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sPanel1
            // 
            sPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sPanel1.BackColor = Color.Black;
            sPanel1.BackgroundImage = Properties.Resources.Royal_Blue;
            sPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel1.BorderColor = Color.Black;
            sPanel1.BorderRadius = 20;
            sPanel1.BorderSize = 0;
            sPanel1.Controls.Add(guna2Button2);
            sPanel1.Controls.Add(label8);
            sPanel1.Controls.Add(label3);
            sPanel1.ForeColor = Color.White;
            sPanel1.Location = new Point(24, 352);
            sPanel1.Margin = new Padding(4);
            sPanel1.Name = "sPanel1";
            sPanel1.Size = new Size(968, 104);
            sPanel1.TabIndex = 14;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button2.Animated = true;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderColor = Color.Gainsboro;
            guna2Button2.BorderRadius = 20;
            guna2Button2.BorderThickness = 2;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(848, 24);
            guna2Button2.Margin = new Padding(2);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(104, 58);
            guna2Button2.TabIndex = 14;
            guna2Button2.Text = "More";
            guna2Button2.Click += bntSettings_Click;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(48, 48);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(456, 40);
            label8.TabIndex = 1;
            label8.Text = "Profilbild, Name, usw.";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(48, -8);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(232, 88);
            label3.TabIndex = 1;
            label3.Text = "Ihre Infos";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sPanel3
            // 
            sPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sPanel3.BackColor = Color.Black;
            sPanel3.BackgroundImage = Properties.Resources.Royal_Blue;
            sPanel3.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel3.BorderColor = Color.Black;
            sPanel3.BorderRadius = 20;
            sPanel3.BorderSize = 0;
            sPanel3.Controls.Add(guna2Button3);
            sPanel3.Controls.Add(label7);
            sPanel3.Controls.Add(label4);
            sPanel3.ForeColor = Color.White;
            sPanel3.Location = new Point(24, 472);
            sPanel3.Margin = new Padding(4);
            sPanel3.Name = "sPanel3";
            sPanel3.Size = new Size(968, 104);
            sPanel3.TabIndex = 14;
            // 
            // guna2Button3
            // 
            guna2Button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button3.Animated = true;
            guna2Button3.BackColor = Color.Transparent;
            guna2Button3.BorderColor = Color.Gainsboro;
            guna2Button3.BorderRadius = 20;
            guna2Button3.BorderThickness = 2;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.Transparent;
            guna2Button3.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Location = new Point(848, 24);
            guna2Button3.Margin = new Padding(2);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.Size = new Size(104, 58);
            guna2Button3.TabIndex = 14;
            guna2Button3.Text = "More";
            guna2Button3.Click += bntSettings_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(48, 56);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(448, 40);
            label7.TabIndex = 1;
            label7.Text = "Sicherheitsschlüssel, Kennwort, 2nd Authorization\r\n";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(48, -8);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(232, 88);
            label4.TabIndex = 1;
            label4.Text = "Anmeldung";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sPanel4
            // 
            sPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sPanel4.BackColor = Color.Black;
            sPanel4.BackgroundImage = Properties.Resources.Royal_Blue;
            sPanel4.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel4.BorderColor = Color.Black;
            sPanel4.BorderRadius = 20;
            sPanel4.BorderSize = 0;
            sPanel4.Controls.Add(guna2Button4);
            sPanel4.Controls.Add(label6);
            sPanel4.Controls.Add(label5);
            sPanel4.ForeColor = Color.White;
            sPanel4.Location = new Point(24, 592);
            sPanel4.Margin = new Padding(4);
            sPanel4.Name = "sPanel4";
            sPanel4.Size = new Size(968, 104);
            sPanel4.TabIndex = 14;
            // 
            // guna2Button4
            // 
            guna2Button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button4.Animated = true;
            guna2Button4.BackColor = Color.Transparent;
            guna2Button4.BorderColor = Color.Gainsboro;
            guna2Button4.BorderRadius = 20;
            guna2Button4.BorderThickness = 2;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.Transparent;
            guna2Button4.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button4.ForeColor = Color.White;
            guna2Button4.Location = new Point(848, 24);
            guna2Button4.Margin = new Padding(2);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.Size = new Size(104, 58);
            guna2Button4.TabIndex = 14;
            guna2Button4.Text = "More";
            guna2Button4.Click += bntSettings_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(48, 48);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(448, 40);
            label6.TabIndex = 1;
            label6.Text = "Verwalten sie Dienste und Services";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(48, -8);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(232, 88);
            label5.TabIndex = 1;
            label5.Text = "Abonomments";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // videoPanel
            // 
            videoPanel.BackColor = Color.White;
            videoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            videoPanel.BorderColor = Color.Black;
            videoPanel.BorderRadius = 20;
            videoPanel.BorderSize = 0;
            videoPanel.ForeColor = Color.White;
            videoPanel.Location = new Point(32, 176);
            videoPanel.Margin = new Padding(4);
            videoPanel.Name = "videoPanel";
            videoPanel.Size = new Size(140, 140);
            videoPanel.TabIndex = 14;
            // 
            // uiAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1020, 948);
            Controls.Add(guna2Button1);
            Controls.Add(lblUser);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(sPanel4);
            Controls.Add(sPanel3);
            Controls.Add(sPanel1);
            Controls.Add(videoPanel);
            Controls.Add(sPanel2);
            Name = "uiAccount";
            Text = "uiAccount";
            Load += uiAccount_Load;
            sPanel2.ResumeLayout(false);
            sPanel1.ResumeLayout(false);
            sPanel3.ResumeLayout(false);
            sPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sipaa.Framework.SPanel sPanel2;
        private Label lblText;
        private Guna.UI2.WinForms.Guna2Button bntSettings;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label lblUsername;
        private Label lblEmail;
        private Label lblUser;
        private Sipaa.Framework.SPanel sPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Label label3;
        private Sipaa.Framework.SPanel sPanel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Label label4;
        private Sipaa.Framework.SPanel sPanel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private Sipaa.Framework.SPanel videoPanel;
    }
}