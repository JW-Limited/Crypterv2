namespace LILO_Packager.v2.Forms
{
    partial class uiCustomDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiCustomDialog));
            sPanel2 = new Sipaa.Framework.SPanel();
            bntOk = new Guna.UI2.WinForms.Guna2Button();
            bntCancel = new Guna.UI2.WinForms.Guna2Button();
            lblMessageText = new Label();
            pnlIcon = new Guna.UI2.WinForms.Guna2Panel();
            sPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // sPanel2
            // 
            sPanel2.BackColor = Color.WhiteSmoke;
            resources.ApplyResources(sPanel2, "sPanel2");
            sPanel2.BorderColor = Color.Black;
            sPanel2.BorderRadius = 0;
            sPanel2.BorderSize = 0;
            sPanel2.Controls.Add(bntOk);
            sPanel2.Controls.Add(bntCancel);
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
            bntOk.FillColor = Color.Transparent;
            bntOk.FocusedColor = Color.FromArgb(100, 170, 209);
            bntOk.ForeColor = Color.Black;
            bntOk.Name = "bntOk";
            bntOk.Click += bntOk_Click;
            // 
            // bntCancel
            // 
            resources.ApplyResources(bntCancel, "bntCancel");
            bntCancel.Animated = true;
            bntCancel.BackColor = Color.Transparent;
            bntCancel.BorderColor = Color.Gainsboro;
            bntCancel.BorderRadius = 14;
            bntCancel.BorderThickness = 2;
            bntCancel.DisabledState.BorderColor = Color.DarkGray;
            bntCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            bntCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntCancel.FillColor = Color.Transparent;
            bntCancel.FocusedColor = Color.FromArgb(100, 170, 209);
            bntCancel.ForeColor = Color.Black;
            bntCancel.Name = "bntCancel";
            bntCancel.Click += bntCancel_Click;
            // 
            // lblMessageText
            // 
            resources.ApplyResources(lblMessageText, "lblMessageText");
            lblMessageText.BackColor = Color.Transparent;
            lblMessageText.ForeColor = Color.Black;
            lblMessageText.Name = "lblMessageText";
            // 
            // pnlIcon
            // 
            resources.ApplyResources(pnlIcon, "pnlIcon");
            pnlIcon.BackColor = Color.Transparent;
            pnlIcon.BackgroundImage = Properties.Resources.Close;
            pnlIcon.BorderColor = SystemColors.ActiveBorder;
            pnlIcon.BorderRadius = 15;
            pnlIcon.FillColor = Color.Transparent;
            pnlIcon.Name = "pnlIcon";
            // 
            // uiCustomDialog
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlIcon);
            Controls.Add(lblMessageText);
            Controls.Add(sPanel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "uiCustomDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += uiCustomDialog_Load;
            sPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sipaa.Framework.SPanel sPanel2;
        private Guna.UI2.WinForms.Guna2Button bntCancel;
        private Label lblMessageText;
        private Guna.UI2.WinForms.Guna2Button bntOk;
        private Guna.UI2.WinForms.Guna2Panel pnlIcon;
    }
}