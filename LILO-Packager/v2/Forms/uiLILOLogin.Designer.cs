namespace LILO_Packager.v2.Forms
{
    partial class uiLILOLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiLILOLogin));
            lblVerison = new Label();
            label2 = new Label();
            label1 = new Label();
            bntCancel = new Guna.UI2.WinForms.Guna2Button();
            pnlImg = new Sipaa.Framework.SPanel();
            pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
            pnlLoginLoad = new Guna.UI2.WinForms.Guna2Panel();
            progressSpinner = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            bntLogin = new Guna.UI2.WinForms.Guna2Button();
            label5 = new Label();
            showPsw = new Guna.UI2.WinForms.Guna2Button();
            txtPsw = new Sipaa.Framework.STextBox();
            txtUsr = new Sipaa.Framework.STextBox();
            pnlSucces = new Guna.UI2.WinForms.Guna2Panel();
            sPanel1 = new Sipaa.Framework.SPanel();
            label3 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            linkLabel1 = new LinkLabel();
            pnlPreview.SuspendLayout();
            pnlLoginLoad.SuspendLayout();
            pnlSucces.SuspendLayout();
            SuspendLayout();
            // 
            // lblVerison
            // 
            lblVerison.BackColor = Color.Transparent;
            resources.ApplyResources(lblVerison, "lblVerison");
            lblVerison.ForeColor = Color.Silver;
            lblVerison.Name = "lblVerison";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Silver;
            label2.Name = "label2";
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
            // pnlImg
            // 
            resources.ApplyResources(pnlImg, "pnlImg");
            pnlImg.BackColor = Color.White;
            pnlImg.BackgroundImage = Properties.Resources.Screenshot_2023_10_13_052005;
            pnlImg.BorderColor = Color.Gainsboro;
            pnlImg.BorderRadius = 20;
            pnlImg.BorderSize = 2;
            pnlImg.ForeColor = Color.White;
            pnlImg.Name = "pnlImg";
            // 
            // pnlPreview
            // 
            resources.ApplyResources(pnlPreview, "pnlPreview");
            pnlPreview.BackColor = Color.Transparent;
            pnlPreview.BorderColor = Color.Gainsboro;
            pnlPreview.BorderRadius = 15;
            pnlPreview.BorderThickness = 2;
            pnlPreview.Controls.Add(pnlLoginLoad);
            pnlPreview.Controls.Add(bntLogin);
            pnlPreview.Controls.Add(label5);
            pnlPreview.Controls.Add(showPsw);
            pnlPreview.Controls.Add(txtPsw);
            pnlPreview.Controls.Add(txtUsr);
            pnlPreview.FillColor = Color.White;
            pnlPreview.Name = "pnlPreview";
            // 
            // pnlLoginLoad
            // 
            resources.ApplyResources(pnlLoginLoad, "pnlLoginLoad");
            pnlLoginLoad.BackColor = Color.Transparent;
            pnlLoginLoad.BorderColor = Color.Gainsboro;
            pnlLoginLoad.BorderRadius = 15;
            pnlLoginLoad.BorderThickness = 2;
            pnlLoginLoad.Controls.Add(progressSpinner);
            pnlLoginLoad.FillColor = Color.White;
            pnlLoginLoad.Name = "pnlLoginLoad";
            // 
            // progressSpinner
            // 
            resources.ApplyResources(progressSpinner, "progressSpinner");
            progressSpinner.AutoStart = true;
            progressSpinner.BackColor = Color.White;
            progressSpinner.Name = "progressSpinner";
            // 
            // bntLogin
            // 
            bntLogin.Animated = true;
            bntLogin.BackColor = Color.Transparent;
            bntLogin.BorderColor = Color.Gainsboro;
            bntLogin.BorderRadius = 15;
            bntLogin.BorderThickness = 2;
            bntLogin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            bntLogin.DisabledState.BorderColor = Color.DarkGray;
            bntLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            bntLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntLogin.FillColor = Color.White;
            resources.ApplyResources(bntLogin, "bntLogin");
            bntLogin.ForeColor = Color.Black;
            bntLogin.HoverState.FillColor = Color.FromArgb(94, 148, 255);
            bntLogin.HoverState.ForeColor = Color.White;
            bntLogin.Name = "bntLogin";
            bntLogin.PressedColor = Color.DarkGray;
            bntLogin.UseTransparentBackground = true;
            bntLogin.Click += bntLogin_Click;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Name = "label5";
            // 
            // showPsw
            // 
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
            resources.ApplyResources(showPsw, "showPsw");
            showPsw.ForeColor = Color.White;
            showPsw.Image = (Image)resources.GetObject("showPsw.Image");
            showPsw.Name = "showPsw";
            showPsw.PressedColor = Color.DarkGray;
            showPsw.UseTransparentBackground = true;
            showPsw.Click += pswVisible_Click;
            // 
            // txtPsw
            // 
            txtPsw.BackColor = Color.White;
            txtPsw.BorderColor = Color.Gainsboro;
            txtPsw.BorderFocusColor = Color.DimGray;
            txtPsw.BorderRadius = 20;
            txtPsw.BorderSize = 1;
            resources.ApplyResources(txtPsw, "txtPsw");
            txtPsw.ForeColor = Color.Black;
            txtPsw.Multiline = false;
            txtPsw.Name = "txtPsw";
            txtPsw.PasswordChar = true;
            txtPsw.PlaceholderColor = Color.DarkGray;
            txtPsw.PlaceholderText = "Password";
            txtPsw.Texts = "";
            txtPsw.UnderlinedStyle = false;
            // 
            // txtUsr
            // 
            txtUsr.BackColor = Color.White;
            txtUsr.BorderColor = Color.Gainsboro;
            txtUsr.BorderFocusColor = Color.DimGray;
            txtUsr.BorderRadius = 20;
            txtUsr.BorderSize = 1;
            resources.ApplyResources(txtUsr, "txtUsr");
            txtUsr.ForeColor = Color.Black;
            txtUsr.Multiline = false;
            txtUsr.Name = "txtUsr";
            txtUsr.PasswordChar = false;
            txtUsr.PlaceholderColor = Color.DarkGray;
            txtUsr.PlaceholderText = "Email";
            txtUsr.Texts = "";
            txtUsr.UnderlinedStyle = false;
            // 
            // pnlSucces
            // 
            resources.ApplyResources(pnlSucces, "pnlSucces");
            pnlSucces.BackColor = Color.Transparent;
            pnlSucces.BorderColor = Color.Gainsboro;
            pnlSucces.BorderRadius = 15;
            pnlSucces.BorderThickness = 2;
            pnlSucces.Controls.Add(sPanel1);
            pnlSucces.Controls.Add(label3);
            pnlSucces.Controls.Add(guna2Button1);
            pnlSucces.FillColor = Color.White;
            pnlSucces.Name = "pnlSucces";
            // 
            // sPanel1
            // 
            resources.ApplyResources(sPanel1, "sPanel1");
            sPanel1.BackColor = Color.White;
            sPanel1.BackgroundImage = Properties.Resources.icons8_verified_badge_96;
            sPanel1.BorderColor = Color.Gainsboro;
            sPanel1.BorderRadius = 20;
            sPanel1.BorderSize = 0;
            sPanel1.ForeColor = Color.White;
            sPanel1.Name = "sPanel1";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Name = "label3";
            // 
            // guna2Button1
            // 
            resources.ApplyResources(guna2Button1, "guna2Button1");
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.Gainsboro;
            guna2Button1.BorderRadius = 12;
            guna2Button1.BorderThickness = 2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.ForeColor = Color.DimGray;
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.BorderRadius = 15;
            guna2Button1.ShadowDecoration.Color = Color.LightGray;
            guna2Button1.ShadowDecoration.Depth = 20;
            guna2Button1.ShadowDecoration.Enabled = true;
            guna2Button1.Click += bntGo;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(linkLabel1, "linkLabel1");
            linkLabel1.LinkColor = Color.FromArgb(94, 148, 255);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.TabStop = true;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // uiLILOLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(linkLabel1);
            Controls.Add(pnlImg);
            Controls.Add(pnlSucces);
            Controls.Add(lblVerison);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bntCancel);
            Controls.Add(pnlPreview);
            Name = "uiLILOLogin";
            Load += uiLILOLogin_Load;
            pnlPreview.ResumeLayout(false);
            pnlLoginLoad.ResumeLayout(false);
            pnlSucces.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVerison;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button bntCancel;
        private Sipaa.Framework.SPanel pnlImg;
        private Guna.UI2.WinForms.Guna2Panel pnlPreview;
        private Guna.UI2.WinForms.Guna2Panel pnlLoginLoad;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator progressSpinner;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button bntLogin;
        private Guna.UI2.WinForms.Guna2Button showPsw;
        private Sipaa.Framework.STextBox txtPsw;
        private Sipaa.Framework.STextBox txtUsr;
        private Guna.UI2.WinForms.Guna2Panel pnlSucces;
        private Label label3;
        private Sipaa.Framework.SPanel sPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private LinkLabel linkLabel1;
    }
}