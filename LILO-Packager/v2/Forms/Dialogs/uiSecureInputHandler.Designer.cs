namespace LILO_Packager.v2.Forms
{
    partial class uiSecureInputHandler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiSecureInputHandler));
            sPanel2 = new Sipaa.Framework.SPanel();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            bntOk = new Guna.UI2.WinForms.Guna2Button();
            txtPsw = new Sipaa.Framework.STextBox();
            lblTask = new Label();
            pnlLoginLoad = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            dynamicToggleButton2 = new Controls.DynamicToggleButton();
            dynamicToggleButton1 = new Controls.DynamicToggleButton();
            showPsw = new Guna.UI2.WinForms.Guna2Button();
            sPanel2.SuspendLayout();
            pnlLoginLoad.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sPanel2
            // 
            sPanel2.BackColor = Color.WhiteSmoke;
            sPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel2.BorderColor = Color.Black;
            sPanel2.BorderRadius = 0;
            sPanel2.BorderSize = 0;
            sPanel2.Controls.Add(guna2Button3);
            sPanel2.Controls.Add(guna2Button1);
            sPanel2.Controls.Add(bntOk);
            sPanel2.Dock = DockStyle.Bottom;
            sPanel2.ForeColor = Color.White;
            sPanel2.Location = new Point(0, 495);
            sPanel2.Margin = new Padding(4, 4, 4, 4);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(682, 76);
            sPanel2.TabIndex = 18;
            // 
            // guna2Button3
            // 
            guna2Button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            guna2Button3.Animated = true;
            guna2Button3.BackColor = Color.Transparent;
            guna2Button3.BorderColor = Color.Gainsboro;
            guna2Button3.BorderRadius = 12;
            guna2Button3.BorderThickness = 2;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.White;
            guna2Button3.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2Button3.ForeColor = Color.DimGray;
            guna2Button3.Image = Properties.Resources.Info;
            guna2Button3.ImageSize = new Size(25, 25);
            guna2Button3.Location = new Point(20, 20);
            guna2Button3.Margin = new Padding(2);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.Size = new Size(40, 38);
            guna2Button3.TabIndex = 26;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2Button1.BorderColor = Color.Gainsboro;
            guna2Button1.BorderRadius = 14;
            guna2Button1.BorderThickness = 2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(288, 16);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(240, 48);
            guna2Button1.TabIndex = 15;
            guna2Button1.Text = "Submit";
            guna2Button1.Click += guna2Button1_Click;
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
            bntOk.FillColor = Color.Transparent;
            bntOk.FocusedColor = Color.FromArgb(100, 170, 209);
            bntOk.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            bntOk.ForeColor = Color.Black;
            bntOk.Location = new Point(544, 16);
            bntOk.Margin = new Padding(2);
            bntOk.Name = "bntOk";
            bntOk.Size = new Size(128, 48);
            bntOk.TabIndex = 15;
            bntOk.Text = "Cancel";
            bntOk.Click += bntOk_Click;
            // 
            // txtPsw
            // 
            txtPsw.Anchor = AnchorStyles.None;
            txtPsw.BackColor = Color.White;
            txtPsw.BorderColor = Color.Silver;
            txtPsw.BorderFocusColor = Color.DimGray;
            txtPsw.BorderRadius = 15;
            txtPsw.BorderSize = 1;
            txtPsw.Font = new Font("Century Gothic", 12F);
            txtPsw.ForeColor = Color.Black;
            txtPsw.Location = new Point(50, 144);
            txtPsw.Margin = new Padding(5, 5, 5, 5);
            txtPsw.Multiline = false;
            txtPsw.Name = "txtPsw";
            txtPsw.Padding = new Padding(12, 9, 12, 9);
            txtPsw.PasswordChar = true;
            txtPsw.PlaceholderColor = Color.DarkGray;
            txtPsw.PlaceholderText = "";
            txtPsw.Size = new Size(420, 49);
            txtPsw.TabIndex = 20;
            txtPsw.Texts = "";
            txtPsw.UnderlinedStyle = false;
            // 
            // lblTask
            // 
            lblTask.Anchor = AnchorStyles.None;
            lblTask.BackColor = Color.Transparent;
            lblTask.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblTask.ForeColor = Color.Black;
            lblTask.Location = new Point(45, 10);
            lblTask.Margin = new Padding(4, 0, 4, 0);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(310, 50);
            lblTask.TabIndex = 17;
            lblTask.Text = "AcKex Dialog";
            lblTask.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLoginLoad
            // 
            pnlLoginLoad.Anchor = AnchorStyles.None;
            pnlLoginLoad.BackColor = Color.Transparent;
            pnlLoginLoad.BorderColor = Color.Gainsboro;
            pnlLoginLoad.BorderRadius = 15;
            pnlLoginLoad.BorderThickness = 2;
            pnlLoginLoad.Controls.Add(guna2Panel1);
            pnlLoginLoad.Controls.Add(dynamicToggleButton2);
            pnlLoginLoad.Controls.Add(dynamicToggleButton1);
            pnlLoginLoad.Controls.Add(showPsw);
            pnlLoginLoad.Controls.Add(txtPsw);
            pnlLoginLoad.FillColor = Color.White;
            pnlLoginLoad.Location = new Point(90, 60);
            pnlLoginLoad.Margin = new Padding(2);
            pnlLoginLoad.Name = "pnlLoginLoad";
            pnlLoginLoad.Size = new Size(512, 376);
            pnlLoginLoad.TabIndex = 21;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(lblTask);
            guna2Panel1.FillColor = Color.WhiteSmoke;
            guna2Panel1.Location = new Point(60, 40);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(400, 70);
            guna2Panel1.TabIndex = 22;
            // 
            // dynamicToggleButton2
            // 
            dynamicToggleButton2.BorderColor = Color.Gainsboro;
            dynamicToggleButton2.BorderRadius = 10;
            dynamicToggleButton2.Checked = true;
            dynamicToggleButton2.CheckedColor = Color.FromArgb(94, 148, 255);
            dynamicToggleButton2.CheckedText = "Save to Cloud";
            dynamicToggleButton2.DisabledText = "Not Changable";
            dynamicToggleButton2.EnabledState = true;
            dynamicToggleButton2.Location = new Point(50, 290);
            dynamicToggleButton2.Margin = new Padding(2);
            dynamicToggleButton2.Name = "dynamicToggleButton2";
            dynamicToggleButton2.Size = new Size(422, 50);
            dynamicToggleButton2.TabIndex = 21;
            dynamicToggleButton2.UnCheckedText = "Cloud disabled";
            // 
            // dynamicToggleButton1
            // 
            dynamicToggleButton1.BorderColor = Color.Gainsboro;
            dynamicToggleButton1.BorderRadius = 10;
            dynamicToggleButton1.Checked = true;
            dynamicToggleButton1.CheckedColor = Color.FromArgb(94, 148, 255);
            dynamicToggleButton1.CheckedText = "Storing Password";
            dynamicToggleButton1.DisabledText = "Password unsafed";
            dynamicToggleButton1.EnabledState = true;
            dynamicToggleButton1.Location = new Point(50, 220);
            dynamicToggleButton1.Margin = new Padding(2);
            dynamicToggleButton1.Name = "dynamicToggleButton1";
            dynamicToggleButton1.Size = new Size(422, 50);
            dynamicToggleButton1.TabIndex = 21;
            dynamicToggleButton1.UnCheckedText = "Disabled";
            // 
            // showPsw
            // 
            showPsw.Anchor = AnchorStyles.None;
            showPsw.Animated = true;
            showPsw.BackColor = Color.Transparent;
            showPsw.BorderColor = Color.FromArgb(224, 224, 224);
            showPsw.BorderRadius = 15;
            showPsw.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            showPsw.CheckedState.Image = (Image)resources.GetObject("resource.Image");
            showPsw.DisabledState.BorderColor = Color.DarkGray;
            showPsw.DisabledState.CustomBorderColor = Color.DarkGray;
            showPsw.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            showPsw.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            showPsw.FillColor = Color.Transparent;
            showPsw.Font = new Font("Segoe UI", 9F);
            showPsw.ForeColor = Color.White;
            showPsw.Image = (Image)resources.GetObject("showPsw.Image");
            showPsw.Location = new Point(420, 152);
            showPsw.Margin = new Padding(4, 4, 4, 4);
            showPsw.Name = "showPsw";
            showPsw.PressedColor = Color.DarkGray;
            showPsw.Size = new Size(40, 32);
            showPsw.TabIndex = 19;
            showPsw.UseTransparentBackground = true;
            showPsw.Click += showPsw_Click;
            // 
            // uiSecureInputHandler
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(682, 571);
            ControlBox = false;
            Controls.Add(sPanel2);
            Controls.Add(pnlLoginLoad);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "uiSecureInputHandler";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "uiCustomProcess";
            Load += uiCustomProcess_Load;
            sPanel2.ResumeLayout(false);
            pnlLoginLoad.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sipaa.Framework.SPanel sPanel2;
        private Guna.UI2.WinForms.Guna2Button bntOk;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Sipaa.Framework.STextBox txtPsw;
        private Label lblTask;
        private Guna.UI2.WinForms.Guna2Panel pnlLoginLoad;
        private Guna.UI2.WinForms.Guna2Button showPsw;
        private Controls.DynamicToggleButton dynamicToggleButton2;
        private Controls.DynamicToggleButton dynamicToggleButton1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}