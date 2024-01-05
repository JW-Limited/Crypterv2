namespace LILO_Packager.v2.Forms.Dialogs
{
    partial class uiDialogCreateCdex
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
            label1 = new Label();
            txtPsw = new Sipaa.Framework.STextBox();
            label2 = new Label();
            sTextBox1 = new Sipaa.Framework.STextBox();
            bntPlugin = new Guna.UI2.WinForms.Guna2Button();
            bntShare = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            lblDescription = new Label();
            lblLILOSecure = new Label();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label3 = new Label();
            label4 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel3.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(40, 48);
            label1.Name = "label1";
            label1.Size = new Size(120, 46);
            label1.TabIndex = 57;
            label1.Text = "Name:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPsw
            // 
            txtPsw.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPsw.BackColor = Color.White;
            txtPsw.BorderColor = Color.Gainsboro;
            txtPsw.BorderFocusColor = Color.DimGray;
            txtPsw.BorderRadius = 15;
            txtPsw.BorderSize = 2;
            txtPsw.Font = new Font("Century Gothic", 12F);
            txtPsw.ForeColor = Color.Black;
            txtPsw.Location = new Point(160, 48);
            txtPsw.Margin = new Padding(5);
            txtPsw.Multiline = false;
            txtPsw.Name = "txtPsw";
            txtPsw.Padding = new Padding(12, 9, 12, 9);
            txtPsw.PasswordChar = false;
            txtPsw.PlaceholderColor = Color.DarkGray;
            txtPsw.PlaceholderText = "";
            txtPsw.Size = new Size(496, 49);
            txtPsw.TabIndex = 58;
            txtPsw.Texts = "";
            txtPsw.UnderlinedStyle = false;
            txtPsw._TextChanged += txtPsw__TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(40, 120);
            label2.Name = "label2";
            label2.Size = new Size(120, 46);
            label2.TabIndex = 57;
            label2.Text = "Directory";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sTextBox1
            // 
            sTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sTextBox1.BackColor = Color.White;
            sTextBox1.BorderColor = Color.Gainsboro;
            sTextBox1.BorderFocusColor = Color.DimGray;
            sTextBox1.BorderRadius = 15;
            sTextBox1.BorderSize = 2;
            sTextBox1.Font = new Font("Century Gothic", 12F);
            sTextBox1.ForeColor = Color.Black;
            sTextBox1.Location = new Point(160, 120);
            sTextBox1.Margin = new Padding(5);
            sTextBox1.Multiline = false;
            sTextBox1.Name = "sTextBox1";
            sTextBox1.Padding = new Padding(12, 9, 12, 9);
            sTextBox1.PasswordChar = false;
            sTextBox1.PlaceholderColor = Color.DarkGray;
            sTextBox1.PlaceholderText = "";
            sTextBox1.Size = new Size(432, 49);
            sTextBox1.TabIndex = 58;
            sTextBox1.Texts = "";
            sTextBox1.UnderlinedStyle = false;
            sTextBox1._TextChanged += sTextBox1__TextChanged;
            // 
            // bntPlugin
            // 
            bntPlugin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntPlugin.Animated = true;
            bntPlugin.BackColor = Color.Transparent;
            bntPlugin.BackgroundImageLayout = ImageLayout.Zoom;
            bntPlugin.BorderColor = Color.Gainsboro;
            bntPlugin.BorderRadius = 10;
            bntPlugin.BorderThickness = 2;
            bntPlugin.DisabledState.BorderColor = Color.DarkGray;
            bntPlugin.DisabledState.CustomBorderColor = Color.DarkGray;
            bntPlugin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntPlugin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntPlugin.FillColor = Color.Transparent;
            bntPlugin.FocusedColor = Color.FromArgb(100, 170, 209);
            bntPlugin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            bntPlugin.ForeColor = Color.DimGray;
            bntPlugin.Image = Properties.Resources.icons8_external_link_240;
            bntPlugin.Location = new Point(608, 120);
            bntPlugin.Margin = new Padding(2);
            bntPlugin.Name = "bntPlugin";
            bntPlugin.Size = new Size(46, 48);
            bntPlugin.TabIndex = 59;
            bntPlugin.Click += bntPlugin_Click;
            // 
            // bntShare
            // 
            bntShare.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bntShare.Animated = true;
            bntShare.BackColor = Color.Transparent;
            bntShare.BackgroundImageLayout = ImageLayout.Zoom;
            bntShare.BorderColor = Color.Gainsboro;
            bntShare.BorderRadius = 10;
            bntShare.BorderThickness = 2;
            bntShare.CheckedState.FillColor = Color.White;
            bntShare.DisabledState.BorderColor = Color.Gainsboro;
            bntShare.DisabledState.CustomBorderColor = Color.Gainsboro;
            bntShare.DisabledState.FillColor = Color.WhiteSmoke;
            bntShare.DisabledState.ForeColor = Color.DimGray;
            bntShare.Enabled = false;
            bntShare.FillColor = Color.White;
            bntShare.FocusedColor = Color.FromArgb(100, 170, 209);
            bntShare.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            bntShare.ForeColor = Color.SteelBlue;
            bntShare.Location = new Point(40, 536);
            bntShare.Margin = new Padding(2);
            bntShare.Name = "bntShare";
            bntShare.Size = new Size(456, 48);
            bntShare.TabIndex = 60;
            bntShare.Text = "Export";
            bntShare.Click += bntShare_Click;
            // 
            // guna2Panel3
            // 
            guna2Panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel3.BackColor = SystemColors.HighlightText;
            guna2Panel3.BorderColor = Color.Gainsboro;
            guna2Panel3.BorderRadius = 15;
            guna2Panel3.BorderThickness = 2;
            guna2Panel3.Controls.Add(lblDescription);
            guna2Panel3.Controls.Add(lblLILOSecure);
            guna2Panel3.Controls.Add(guna2Button4);
            guna2Panel3.FillColor = Color.White;
            guna2Panel3.Location = new Point(40, 208);
            guna2Panel3.Margin = new Padding(2);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Size = new Size(616, 80);
            guna2Panel3.TabIndex = 61;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Left;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 8F);
            lblDescription.ForeColor = Color.Silver;
            lblDescription.Location = new Point(24, 44);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(352, 24);
            lblDescription.TabIndex = 57;
            lblDescription.Text = "A Method to protect youre file with a AxKey.";
            // 
            // lblLILOSecure
            // 
            lblLILOSecure.Anchor = AnchorStyles.Left;
            lblLILOSecure.AutoEllipsis = true;
            lblLILOSecure.BackColor = Color.Transparent;
            lblLILOSecure.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblLILOSecure.ForeColor = Color.IndianRed;
            lblLILOSecure.Location = new Point(24, 12);
            lblLILOSecure.Margin = new Padding(4, 0, 4, 0);
            lblLILOSecure.Name = "lblLILOSecure";
            lblLILOSecure.Size = new Size(352, 40);
            lblLILOSecure.TabIndex = 56;
            lblLILOSecure.Text = "LILO Secure";
            lblLILOSecure.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Button4
            // 
            guna2Button4.Anchor = AnchorStyles.Right;
            guna2Button4.Animated = true;
            guna2Button4.BackColor = Color.Transparent;
            guna2Button4.BackgroundImageLayout = ImageLayout.Zoom;
            guna2Button4.BorderColor = Color.Gainsboro;
            guna2Button4.BorderRadius = 10;
            guna2Button4.BorderThickness = 2;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.Transparent;
            guna2Button4.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            guna2Button4.ForeColor = Color.White;
            guna2Button4.ImageSize = new Size(25, 25);
            guna2Button4.Location = new Point(536, 24);
            guna2Button4.Margin = new Padding(2);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.Size = new Size(58, 34);
            guna2Button4.TabIndex = 58;
            guna2Button4.Click += guna2Button4_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel1.BackColor = SystemColors.HighlightText;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(guna2Button1);
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(40, 312);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(616, 80);
            guna2Panel1.TabIndex = 61;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 8F);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(24, 44);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(384, 24);
            label3.TabIndex = 57;
            label3.Text = "A Utility to allow only choosen users to open this file";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoEllipsis = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = Color.IndianRed;
            label4.Location = new Point(24, 12);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(352, 40);
            label4.TabIndex = 56;
            label4.Text = "User Control";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Right;
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2Button1.BorderColor = Color.Gainsboro;
            guna2Button1.BorderRadius = 10;
            guna2Button1.BorderThickness = 2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.ImageSize = new Size(25, 25);
            guna2Button1.Location = new Point(536, 24);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(58, 34);
            guna2Button1.TabIndex = 58;
            guna2Button1.Click += guna2Button4_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            guna2Button2.Animated = true;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BackgroundImageLayout = ImageLayout.Zoom;
            guna2Button2.BorderColor = Color.Gainsboro;
            guna2Button2.BorderRadius = 10;
            guna2Button2.BorderThickness = 2;
            guna2Button2.CheckedState.FillColor = Color.White;
            guna2Button2.CustomizableEdges.BottomLeft = false;
            guna2Button2.CustomizableEdges.TopLeft = false;
            guna2Button2.DisabledState.BorderColor = Color.Gainsboro;
            guna2Button2.DisabledState.CustomBorderColor = Color.Gainsboro;
            guna2Button2.DisabledState.FillColor = Color.WhiteSmoke;
            guna2Button2.DisabledState.ForeColor = Color.DimGray;
            guna2Button2.FillColor = Color.White;
            guna2Button2.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            guna2Button2.ForeColor = Color.Gray;
            guna2Button2.Location = new Point(488, 536);
            guna2Button2.Margin = new Padding(2);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(168, 48);
            guna2Button2.TabIndex = 60;
            guna2Button2.Text = "Abort";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // uiDialogCreateCdex
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(698, 623);
            ControlBox = false;
            Controls.Add(guna2Button2);
            Controls.Add(bntShare);
            Controls.Add(bntPlugin);
            Controls.Add(sTextBox1);
            Controls.Add(txtPsw);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2Panel3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "uiDialogCreateCdex";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "CDEX Creator";
            Load += uiDialogCreateCdex_Load;
            guna2Panel3.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Sipaa.Framework.STextBox txtPsw;
        private Label label2;
        private Sipaa.Framework.STextBox sTextBox1;
        private Guna.UI2.WinForms.Guna2Button bntPlugin;
        private Guna.UI2.WinForms.Guna2Button bntShare;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Label lblDescription;
        private Label lblLILOSecure;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}