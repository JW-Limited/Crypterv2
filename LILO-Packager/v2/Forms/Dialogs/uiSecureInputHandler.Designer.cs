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
            lblMessage = new Label();
            sPanel2 = new Sipaa.Framework.SPanel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            bntOk = new Guna.UI2.WinForms.Guna2Button();
            gunaSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            txtPsw = new Sipaa.Framework.STextBox();
            lblTask = new Label();
            pnlLoginLoad = new Guna.UI2.WinForms.Guna2Panel();
            showPsw = new Guna.UI2.WinForms.Guna2Button();
            guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            label1 = new Label();
            sPanel2.SuspendLayout();
            pnlLoginLoad.SuspendLayout();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.None;
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.ForeColor = Color.Black;
            lblMessage.Location = new Point(64, 224);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(296, 56);
            lblMessage.TabIndex = 17;
            lblMessage.Text = "Save key to the Database.";
            lblMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sPanel2
            // 
            sPanel2.BackColor = Color.WhiteSmoke;
            sPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel2.BorderColor = Color.Black;
            sPanel2.BorderRadius = 0;
            sPanel2.BorderSize = 0;
            sPanel2.Controls.Add(guna2Button1);
            sPanel2.Controls.Add(bntOk);
            sPanel2.Dock = DockStyle.Bottom;
            sPanel2.ForeColor = Color.White;
            sPanel2.Location = new Point(0, 504);
            sPanel2.Margin = new Padding(4);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(691, 76);
            sPanel2.TabIndex = 18;
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
            guna2Button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(298, 16);
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
            bntOk.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            bntOk.ForeColor = Color.Black;
            bntOk.Location = new Point(554, 16);
            bntOk.Margin = new Padding(2);
            bntOk.Name = "bntOk";
            bntOk.Size = new Size(128, 48);
            bntOk.TabIndex = 15;
            bntOk.Text = "Cancel";
            bntOk.Click += bntOk_Click;
            // 
            // gunaSwitch
            // 
            gunaSwitch.Anchor = AnchorStyles.None;
            gunaSwitch.Animated = true;
            gunaSwitch.AutoRoundedCorners = true;
            gunaSwitch.Checked = true;
            gunaSwitch.CheckedState.BorderColor = Color.Gray;
            gunaSwitch.CheckedState.BorderRadius = 19;
            gunaSwitch.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            gunaSwitch.CheckedState.InnerBorderColor = Color.White;
            gunaSwitch.CheckedState.InnerBorderRadius = 15;
            gunaSwitch.CheckedState.InnerColor = Color.White;
            gunaSwitch.Location = new Point(474, 304);
            gunaSwitch.Name = "gunaSwitch";
            gunaSwitch.Size = new Size(72, 40);
            gunaSwitch.TabIndex = 19;
            gunaSwitch.UncheckedState.BorderRadius = 19;
            gunaSwitch.UncheckedState.InnerBorderRadius = 15;
            // 
            // txtPsw
            // 
            txtPsw.Anchor = AnchorStyles.None;
            txtPsw.BackColor = Color.White;
            txtPsw.BorderColor = Color.Silver;
            txtPsw.BorderFocusColor = Color.DimGray;
            txtPsw.BorderRadius = 20;
            txtPsw.BorderSize = 1;
            txtPsw.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPsw.ForeColor = Color.Black;
            txtPsw.Location = new Point(64, 144);
            txtPsw.Margin = new Padding(5);
            txtPsw.Multiline = false;
            txtPsw.Name = "txtPsw";
            txtPsw.Padding = new Padding(12, 9, 12, 9);
            txtPsw.PasswordChar = true;
            txtPsw.PlaceholderColor = Color.DarkGray;
            txtPsw.PlaceholderText = "Password here";
            txtPsw.Size = new Size(384, 49);
            txtPsw.TabIndex = 20;
            txtPsw.Texts = "";
            txtPsw.UnderlinedStyle = false;
            // 
            // lblTask
            // 
            lblTask.Anchor = AnchorStyles.None;
            lblTask.BackColor = Color.Transparent;
            lblTask.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblTask.ForeColor = Color.FromArgb(94, 148, 255);
            lblTask.Location = new Point(64, 40);
            lblTask.Margin = new Padding(4, 0, 4, 0);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(384, 80);
            lblTask.TabIndex = 17;
            lblTask.Text = "Please put in youre Key";
            lblTask.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLoginLoad
            // 
            pnlLoginLoad.Anchor = AnchorStyles.None;
            pnlLoginLoad.BackColor = Color.Transparent;
            pnlLoginLoad.BorderColor = Color.Gainsboro;
            pnlLoginLoad.BorderRadius = 15;
            pnlLoginLoad.BorderThickness = 2;
            pnlLoginLoad.Controls.Add(showPsw);
            pnlLoginLoad.Controls.Add(guna2ToggleSwitch1);
            pnlLoginLoad.Controls.Add(txtPsw);
            pnlLoginLoad.Controls.Add(lblTask);
            pnlLoginLoad.Controls.Add(label1);
            pnlLoginLoad.Controls.Add(lblMessage);
            pnlLoginLoad.FillColor = Color.White;
            pnlLoginLoad.Location = new Point(98, 72);
            pnlLoginLoad.Margin = new Padding(2);
            pnlLoginLoad.Name = "pnlLoginLoad";
            pnlLoginLoad.Size = new Size(512, 376);
            pnlLoginLoad.TabIndex = 21;
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
            showPsw.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            showPsw.ForeColor = Color.White;
            showPsw.Image = (Image)resources.GetObject("showPsw.Image");
            showPsw.Location = new Point(400, 152);
            showPsw.Margin = new Padding(4);
            showPsw.Name = "showPsw";
            showPsw.PressedColor = Color.DarkGray;
            showPsw.Size = new Size(38, 32);
            showPsw.TabIndex = 19;
            showPsw.UseTransparentBackground = true;
            showPsw.Click += showPsw_Click;
            // 
            // guna2ToggleSwitch1
            // 
            guna2ToggleSwitch1.Anchor = AnchorStyles.None;
            guna2ToggleSwitch1.Animated = true;
            guna2ToggleSwitch1.AutoRoundedCorners = true;
            guna2ToggleSwitch1.Checked = true;
            guna2ToggleSwitch1.CheckedState.BorderColor = Color.Gray;
            guna2ToggleSwitch1.CheckedState.BorderRadius = 19;
            guna2ToggleSwitch1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2ToggleSwitch1.CheckedState.InnerBorderColor = Color.White;
            guna2ToggleSwitch1.CheckedState.InnerBorderRadius = 15;
            guna2ToggleSwitch1.CheckedState.InnerColor = Color.White;
            guna2ToggleSwitch1.Location = new Point(376, 288);
            guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            guna2ToggleSwitch1.Size = new Size(72, 40);
            guna2ToggleSwitch1.TabIndex = 19;
            guna2ToggleSwitch1.UncheckedState.BorderRadius = 19;
            guna2ToggleSwitch1.UncheckedState.InnerBorderRadius = 15;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(64, 280);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(296, 56);
            label1.TabIndex = 17;
            label1.Text = "Upload file to the cloud";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiSecureInputHandler
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(691, 580);
            ControlBox = false;
            Controls.Add(sPanel2);
            Controls.Add(gunaSwitch);
            Controls.Add(pnlLoginLoad);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
            ResumeLayout(false);
        }

        #endregion
        private Label lblMessage;
        private Sipaa.Framework.SPanel sPanel2;
        private Guna.UI2.WinForms.Guna2Button bntOk;
        private Guna.UI2.WinForms.Guna2ToggleSwitch gunaSwitch;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Sipaa.Framework.STextBox txtPsw;
        private Label lblTask;
        private Guna.UI2.WinForms.Guna2Panel pnlLoginLoad;
        private Guna.UI2.WinForms.Guna2Button showPsw;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private Label label1;
    }
}