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
            sPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel2.BorderColor = Color.Black;
            sPanel2.BorderRadius = 0;
            sPanel2.BorderSize = 0;
            sPanel2.Controls.Add(bntOk);
            sPanel2.Controls.Add(bntCancel);
            sPanel2.Dock = DockStyle.Bottom;
            sPanel2.ForeColor = Color.White;
            sPanel2.Location = new Point(0, 152);
            sPanel2.Margin = new Padding(4);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(619, 82);
            sPanel2.TabIndex = 14;
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
            bntOk.Location = new Point(332, 16);
            bntOk.Margin = new Padding(2);
            bntOk.Name = "bntOk";
            bntOk.Size = new Size(136, 48);
            bntOk.TabIndex = 15;
            bntOk.Text = "text";
            bntOk.Click += bntOk_Click;
            // 
            // bntCancel
            // 
            bntCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntCancel.Animated = true;
            bntCancel.BackColor = Color.Transparent;
            bntCancel.BackgroundImageLayout = ImageLayout.Zoom;
            bntCancel.BorderColor = Color.Gainsboro;
            bntCancel.BorderRadius = 14;
            bntCancel.BorderThickness = 2;
            bntCancel.DisabledState.BorderColor = Color.DarkGray;
            bntCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            bntCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntCancel.FillColor = Color.Transparent;
            bntCancel.FocusedColor = Color.FromArgb(100, 170, 209);
            bntCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            bntCancel.ForeColor = Color.Black;
            bntCancel.Location = new Point(484, 16);
            bntCancel.Margin = new Padding(2);
            bntCancel.Name = "bntCancel";
            bntCancel.Size = new Size(120, 48);
            bntCancel.TabIndex = 15;
            bntCancel.Text = "text";
            bntCancel.Click += bntCancel_Click;
            // 
            // lblMessageText
            // 
            lblMessageText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMessageText.BackColor = Color.Transparent;
            lblMessageText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessageText.ForeColor = Color.Black;
            lblMessageText.Location = new Point(128, 56);
            lblMessageText.Margin = new Padding(4, 0, 4, 0);
            lblMessageText.Name = "lblMessageText";
            lblMessageText.Size = new Size(465, 72);
            lblMessageText.TabIndex = 1;
            lblMessageText.Text = "MessageText";
            // 
            // pnlIcon
            // 
            pnlIcon.Anchor = AnchorStyles.None;
            pnlIcon.BackColor = Color.Transparent;
            pnlIcon.BackgroundImage = Properties.Resources.Close;
            pnlIcon.BackgroundImageLayout = ImageLayout.Zoom;
            pnlIcon.BorderColor = SystemColors.ActiveBorder;
            pnlIcon.BorderRadius = 15;
            pnlIcon.FillColor = Color.Transparent;
            pnlIcon.Location = new Point(40, 40);
            pnlIcon.Margin = new Padding(2);
            pnlIcon.Name = "pnlIcon";
            pnlIcon.Size = new Size(72, 72);
            pnlIcon.TabIndex = 16;
            // 
            // uiCustomDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(619, 234);
            Controls.Add(pnlIcon);
            Controls.Add(lblMessageText);
            Controls.Add(sPanel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(669, 338);
            MinimizeBox = false;
            Name = "uiCustomDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "title";
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