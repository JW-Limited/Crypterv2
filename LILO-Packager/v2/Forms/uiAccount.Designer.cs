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
            pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
            bntSettings = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            lblUsername = new Label();
            lblEmail = new Label();
            lblUser = new Label();
            sPanel1 = new Sipaa.Framework.SPanel();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            label8 = new Label();
            label3 = new Label();
            sPanel5 = new Sipaa.Framework.SPanel();
            sPanel8 = new Sipaa.Framework.SPanel();
            sPanel3 = new Sipaa.Framework.SPanel();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            label7 = new Label();
            label4 = new Label();
            sPanel6 = new Sipaa.Framework.SPanel();
            sPanel9 = new Sipaa.Framework.SPanel();
            sPanel4 = new Sipaa.Framework.SPanel();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            label6 = new Label();
            label5 = new Label();
            sPanel7 = new Sipaa.Framework.SPanel();
            sPanel10 = new Sipaa.Framework.SPanel();
            videoPanel = new Sipaa.Framework.SPanel();
            label1 = new Label();
            label2 = new Label();
            sPanel11 = new Sipaa.Framework.SPanel();
            pnlLoading = new Sipaa.Framework.SPanel();
            sPanel2.SuspendLayout();
            sPanel1.SuspendLayout();
            sPanel5.SuspendLayout();
            sPanel3.SuspendLayout();
            sPanel6.SuspendLayout();
            sPanel4.SuspendLayout();
            sPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // sPanel2
            // 
            sPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sPanel2.BackColor = Color.White;
            sPanel2.BackgroundImage = Properties.Resources.Royal_Blue;
            sPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel2.BorderColor = Color.Black;
            sPanel2.BorderRadius = 20;
            sPanel2.BorderSize = 0;
            sPanel2.Controls.Add(pnlPreview);
            sPanel2.Controls.Add(bntSettings);
            sPanel2.ForeColor = Color.White;
            sPanel2.Location = new Point(24, 32);
            sPanel2.Margin = new Padding(4);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(968, 88);
            sPanel2.TabIndex = 14;
            // 
            // pnlPreview
            // 
            pnlPreview.BackColor = Color.Transparent;
            pnlPreview.BackgroundImage = Properties.Resources.lilo_white;
            pnlPreview.BackgroundImageLayout = ImageLayout.Zoom;
            pnlPreview.BorderColor = Color.Silver;
            pnlPreview.BorderRadius = 15;
            pnlPreview.Location = new Point(24, 16);
            pnlPreview.Margin = new Padding(2);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Size = new Size(288, 56);
            pnlPreview.TabIndex = 20;
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
            guna2Button1.Location = new Point(848, 224);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(128, 40);
            guna2Button1.TabIndex = 17;
            guna2Button1.Text = "Abmelden";
            guna2Button1.Click += bntCancel_Click;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Open Sans", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(182, 188);
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
            lblEmail.Location = new Point(184, 224);
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
            lblUser.Location = new Point(184, 256);
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
            sPanel1.BackColor = Color.FromArgb(17, 17, 17);
            sPanel1.BackgroundImage = Properties.Resources.Royal_Blue;
            sPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel1.BorderColor = Color.Black;
            sPanel1.BorderRadius = 20;
            sPanel1.BorderSize = 0;
            sPanel1.Controls.Add(guna2Button2);
            sPanel1.Controls.Add(label8);
            sPanel1.Controls.Add(label3);
            sPanel1.Controls.Add(sPanel5);
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
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(120, 48);
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
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(120, -8);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(232, 88);
            label3.TabIndex = 1;
            label3.Text = "Ihre Infos";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sPanel5
            // 
            sPanel5.BackColor = Color.White;
            sPanel5.BackgroundImageLayout = ImageLayout.Zoom;
            sPanel5.BorderColor = Color.Black;
            sPanel5.BorderRadius = 20;
            sPanel5.BorderSize = 0;
            sPanel5.Controls.Add(sPanel8);
            sPanel5.ForeColor = Color.White;
            sPanel5.Location = new Point(16, 16);
            sPanel5.Margin = new Padding(4);
            sPanel5.Name = "sPanel5";
            sPanel5.Size = new Size(80, 72);
            sPanel5.TabIndex = 14;
            // 
            // sPanel8
            // 
            sPanel8.BackColor = Color.White;
            sPanel8.BackgroundImage = Properties.Resources.Info;
            sPanel8.BackgroundImageLayout = ImageLayout.Zoom;
            sPanel8.BorderColor = Color.Transparent;
            sPanel8.BorderRadius = 20;
            sPanel8.BorderSize = 0;
            sPanel8.ForeColor = Color.White;
            sPanel8.Location = new Point(8, 8);
            sPanel8.Margin = new Padding(4);
            sPanel8.Name = "sPanel8";
            sPanel8.Size = new Size(64, 56);
            sPanel8.TabIndex = 14;
            // 
            // sPanel3
            // 
            sPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sPanel3.BackColor = Color.FromArgb(17, 17, 17);
            sPanel3.BackgroundImage = Properties.Resources.Royal_Blue;
            sPanel3.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel3.BorderColor = Color.Black;
            sPanel3.BorderRadius = 20;
            sPanel3.BorderSize = 0;
            sPanel3.Controls.Add(guna2Button3);
            sPanel3.Controls.Add(label7);
            sPanel3.Controls.Add(label4);
            sPanel3.Controls.Add(sPanel6);
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
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(120, 56);
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
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(120, -8);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(232, 88);
            label4.TabIndex = 1;
            label4.Text = "Anmeldung";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sPanel6
            // 
            sPanel6.BackColor = Color.White;
            sPanel6.BackgroundImageLayout = ImageLayout.Zoom;
            sPanel6.BorderColor = Color.Black;
            sPanel6.BorderRadius = 20;
            sPanel6.BorderSize = 0;
            sPanel6.Controls.Add(sPanel9);
            sPanel6.ForeColor = Color.White;
            sPanel6.Location = new Point(16, 16);
            sPanel6.Margin = new Padding(4);
            sPanel6.Name = "sPanel6";
            sPanel6.Size = new Size(80, 72);
            sPanel6.TabIndex = 14;
            // 
            // sPanel9
            // 
            sPanel9.BackColor = Color.White;
            sPanel9.BackgroundImage = Properties.Resources.icons8_male_user_96;
            sPanel9.BackgroundImageLayout = ImageLayout.Zoom;
            sPanel9.BorderColor = Color.Transparent;
            sPanel9.BorderRadius = 20;
            sPanel9.BorderSize = 0;
            sPanel9.ForeColor = Color.White;
            sPanel9.Location = new Point(8, 8);
            sPanel9.Margin = new Padding(4);
            sPanel9.Name = "sPanel9";
            sPanel9.Size = new Size(64, 56);
            sPanel9.TabIndex = 14;
            // 
            // sPanel4
            // 
            sPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sPanel4.BackColor = Color.FromArgb(17, 17, 17);
            sPanel4.BackgroundImage = Properties.Resources.Royal_Blue;
            sPanel4.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel4.BorderColor = Color.Black;
            sPanel4.BorderRadius = 20;
            sPanel4.BorderSize = 0;
            sPanel4.Controls.Add(guna2Button4);
            sPanel4.Controls.Add(label6);
            sPanel4.Controls.Add(label5);
            sPanel4.Controls.Add(sPanel7);
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
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(120, 48);
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
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(120, -8);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(232, 88);
            label5.TabIndex = 1;
            label5.Text = "Abonomments";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sPanel7
            // 
            sPanel7.BackColor = Color.White;
            sPanel7.BackgroundImageLayout = ImageLayout.Zoom;
            sPanel7.BorderColor = Color.Black;
            sPanel7.BorderRadius = 20;
            sPanel7.BorderSize = 0;
            sPanel7.Controls.Add(sPanel10);
            sPanel7.ForeColor = Color.White;
            sPanel7.Location = new Point(16, 16);
            sPanel7.Margin = new Padding(4);
            sPanel7.Name = "sPanel7";
            sPanel7.Size = new Size(80, 72);
            sPanel7.TabIndex = 14;
            // 
            // sPanel10
            // 
            sPanel10.BackColor = Color.White;
            sPanel10.BackgroundImage = Properties.Resources.Settings;
            sPanel10.BackgroundImageLayout = ImageLayout.Zoom;
            sPanel10.BorderColor = Color.Transparent;
            sPanel10.BorderRadius = 20;
            sPanel10.BorderSize = 0;
            sPanel10.ForeColor = Color.White;
            sPanel10.Location = new Point(8, 8);
            sPanel10.Margin = new Padding(4);
            sPanel10.Name = "sPanel10";
            sPanel10.Size = new Size(64, 56);
            sPanel10.TabIndex = 14;
            // 
            // videoPanel
            // 
            videoPanel.BackColor = Color.White;
            videoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            videoPanel.BorderColor = Color.Black;
            videoPanel.BorderRadius = 20;
            videoPanel.BorderSize = 0;
            videoPanel.ForeColor = Color.White;
            videoPanel.Location = new Point(32, 168);
            videoPanel.Margin = new Padding(4);
            videoPanel.Name = "videoPanel";
            videoPanel.Size = new Size(140, 140);
            videoPanel.TabIndex = 14;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(880, 864);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 18;
            label1.Text = "powered by ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(880, 888);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 40);
            label2.TabIndex = 19;
            label2.Text = "LILO Sync ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sPanel11
            // 
            sPanel11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            sPanel11.BackColor = Color.White;
            sPanel11.BackgroundImage = Properties.Resources.logo_sync;
            sPanel11.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel11.BorderColor = Color.Black;
            sPanel11.BorderRadius = 20;
            sPanel11.BorderSize = 0;
            sPanel11.ForeColor = Color.White;
            sPanel11.Location = new Point(800, 856);
            sPanel11.Margin = new Padding(4);
            sPanel11.Name = "sPanel11";
            sPanel11.Size = new Size(80, 80);
            sPanel11.TabIndex = 14;
            // 
            // pnlLoading
            // 
            pnlLoading.BackColor = Color.White;
            pnlLoading.BackgroundImageLayout = ImageLayout.Zoom;
            pnlLoading.BorderColor = Color.Black;
            pnlLoading.BorderRadius = 20;
            pnlLoading.BorderSize = 0;
            pnlLoading.ForeColor = Color.White;
            pnlLoading.Location = new Point(16, 16);
            pnlLoading.Margin = new Padding(4);
            pnlLoading.Name = "pnlLoading";
            pnlLoading.Size = new Size(992, 912);
            pnlLoading.TabIndex = 14;
            // 
            // uiAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1020, 948);
            Controls.Add(pnlLoading);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(sPanel11);
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
            sPanel5.ResumeLayout(false);
            sPanel3.ResumeLayout(false);
            sPanel6.ResumeLayout(false);
            sPanel4.ResumeLayout(false);
            sPanel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sipaa.Framework.SPanel sPanel2;
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
        private Label label1;
        private Label label2;
        private Sipaa.Framework.SPanel sPanel5;
        private Sipaa.Framework.SPanel sPanel6;
        private Sipaa.Framework.SPanel sPanel7;
        private Sipaa.Framework.SPanel sPanel9;
        private Sipaa.Framework.SPanel sPanel10;
        private Sipaa.Framework.SPanel sPanel8;
        private Guna.UI2.WinForms.Guna2Panel pnlPreview;
        private Sipaa.Framework.SPanel sPanel11;
        private Sipaa.Framework.SPanel pnlLoading;
    }
}