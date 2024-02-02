namespace LILO_Packager.v2.Forms
{
    partial class uiKeyInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiKeyInput));
            pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            bntLogin = new Guna.UI2.WinForms.Guna2Button();
            pnlPreview.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPreview
            // 
            resources.ApplyResources(pnlPreview, "pnlPreview");
            pnlPreview.BackColor = Color.Transparent;
            pnlPreview.BorderColor = Color.Silver;
            pnlPreview.BorderRadius = 15;
            pnlPreview.BorderThickness = 2;
            pnlPreview.Controls.Add(label1);
            pnlPreview.FillColor = Color.White;
            pnlPreview.Name = "pnlPreview";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.White;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Name = "label1";
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.Silver;
            guna2Button1.BorderRadius = 15;
            guna2Button1.BorderThickness = 2;
            guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            resources.ApplyResources(guna2Button1, "guna2Button1");
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.DarkGray;
            guna2Button1.UseTransparentBackground = true;
            // 
            // bntLogin
            // 
            bntLogin.Animated = true;
            bntLogin.BackColor = Color.Transparent;
            bntLogin.BorderColor = Color.Silver;
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
            bntLogin.Name = "bntLogin";
            bntLogin.PressedColor = Color.DarkGray;
            bntLogin.UseTransparentBackground = true;
            // 
            // uiKeyInput
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2Button1);
            Controls.Add(bntLogin);
            Controls.Add(pnlPreview);
            Name = "uiKeyInput";
            pnlPreview.ResumeLayout(false);
            pnlPreview.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlPreview;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button bntLogin;
    }
}