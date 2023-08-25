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
            pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            bntLogin = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            pnlPreview.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPreview
            // 
            pnlPreview.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlPreview.BackColor = Color.Transparent;
            pnlPreview.BorderColor = Color.Silver;
            pnlPreview.BorderRadius = 15;
            pnlPreview.BorderThickness = 2;
            pnlPreview.Controls.Add(label2);
            pnlPreview.Controls.Add(label1);
            pnlPreview.FillColor = Color.White;
            pnlPreview.Location = new Point(24, 23);
            pnlPreview.Margin = new Padding(2);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Size = new Size(632, 73);
            pnlPreview.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(24, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 36);
            label1.TabIndex = 17;
            label1.Text = "Secured Dialog";
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
            guna2Button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(504, 272);
            guna2Button1.Margin = new Padding(4);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.DarkGray;
            guna2Button1.Size = new Size(152, 48);
            guna2Button1.TabIndex = 20;
            guna2Button1.Text = "Cancel";
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
            bntLogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            bntLogin.ForeColor = Color.Black;
            bntLogin.Location = new Point(24, 272);
            bntLogin.Margin = new Padding(4);
            bntLogin.Name = "bntLogin";
            bntLogin.PressedColor = Color.DarkGray;
            bntLogin.Size = new Size(464, 48);
            bntLogin.TabIndex = 21;
            bntLogin.Text = "n/a";
            bntLogin.UseTransparentBackground = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(424, 24);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 25);
            label2.TabIndex = 17;
            label2.Text = "powered by LILO Sync";
            // 
            // uiKeyInput
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(679, 358);
            Controls.Add(guna2Button1);
            Controls.Add(bntLogin);
            Controls.Add(pnlPreview);
            Name = "uiKeyInput";
            Text = "uiKeyInput";
            pnlPreview.ResumeLayout(false);
            pnlPreview.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlPreview;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button bntLogin;
        private Label label2;
    }
}