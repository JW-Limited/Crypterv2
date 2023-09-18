namespace LILO_Packager.v2.Forms
{
    partial class uiSplashScreen
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
            components = new System.ComponentModel.Container();
            gunaForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            label1 = new Label();
            bntTrouble = new Guna.UI2.WinForms.Guna2Button();
            lblAddtional = new Label();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            imgImage = new Guna.UI2.WinForms.Guna2Panel();
            lblName = new Label();
            guna2Panel3.SuspendLayout();
            SuspendLayout();
            // 
            // gunaForm1
            // 
            gunaForm1.BorderRadius = 20;
            gunaForm1.ContainerControl = this;
            gunaForm1.DockForm = false;
            gunaForm1.DockIndicatorTransparencyValue = 0.6D;
            gunaForm1.DragForm = false;
            gunaForm1.ResizeForm = false;
            gunaForm1.TransparentWhileDrag = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(240, 320);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 40);
            label1.TabIndex = 30;
            label1.Text = "JW Limited ©️ 2023";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bntTrouble
            // 
            bntTrouble.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntTrouble.Animated = true;
            bntTrouble.BackColor = Color.Transparent;
            bntTrouble.BorderColor = Color.Gainsboro;
            bntTrouble.BorderRadius = 12;
            bntTrouble.BorderThickness = 2;
            bntTrouble.DisabledState.BorderColor = Color.DarkGray;
            bntTrouble.DisabledState.CustomBorderColor = Color.DarkGray;
            bntTrouble.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntTrouble.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntTrouble.FillColor = Color.White;
            bntTrouble.FocusedColor = Color.FromArgb(100, 170, 209);
            bntTrouble.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bntTrouble.ForeColor = Color.DimGray;
            bntTrouble.Location = new Point(544, 24);
            bntTrouble.Margin = new Padding(2);
            bntTrouble.Name = "bntTrouble";
            bntTrouble.Size = new Size(120, 40);
            bntTrouble.TabIndex = 29;
            bntTrouble.Text = "JW Hub";
            // 
            // lblAddtional
            // 
            lblAddtional.BackColor = Color.Transparent;
            lblAddtional.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddtional.ForeColor = Color.Black;
            lblAddtional.Location = new Point(32, 24);
            lblAddtional.Margin = new Padding(4, 0, 4, 0);
            lblAddtional.Name = "lblAddtional";
            lblAddtional.Size = new Size(176, 40);
            lblAddtional.TabIndex = 31;
            lblAddtional.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Panel3
            // 
            guna2Panel3.Anchor = AnchorStyles.None;
            guna2Panel3.BorderColor = SystemColors.ActiveBorder;
            guna2Panel3.BorderRadius = 15;
            guna2Panel3.BorderThickness = 2;
            guna2Panel3.Controls.Add(guna2Panel5);
            guna2Panel3.Controls.Add(imgImage);
            guna2Panel3.FillColor = Color.Gainsboro;
            guna2Panel3.Location = new Point(168, 152);
            guna2Panel3.Margin = new Padding(2);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Size = new Size(80, 80);
            guna2Panel3.TabIndex = 33;
            // 
            // guna2Panel5
            // 
            guna2Panel5.Anchor = AnchorStyles.None;
            guna2Panel5.BackColor = Color.Transparent;
            guna2Panel5.BackgroundImage = Properties.Resources.favico;
            guna2Panel5.BackgroundImageLayout = ImageLayout.Zoom;
            guna2Panel5.BorderColor = SystemColors.ActiveBorder;
            guna2Panel5.BorderRadius = 15;
            guna2Panel5.FillColor = Color.Transparent;
            guna2Panel5.Location = new Point(8, 8);
            guna2Panel5.Margin = new Padding(2);
            guna2Panel5.Name = "guna2Panel5";
            guna2Panel5.Size = new Size(64, 67);
            guna2Panel5.TabIndex = 16;
            // 
            // imgImage
            // 
            imgImage.Anchor = AnchorStyles.None;
            imgImage.BackColor = Color.Transparent;
            imgImage.BackgroundImage = Properties.Resources.favico;
            imgImage.BackgroundImageLayout = ImageLayout.Zoom;
            imgImage.BorderColor = SystemColors.ActiveBorder;
            imgImage.BorderRadius = 15;
            imgImage.FillColor = Color.Transparent;
            imgImage.Location = new Point(-112, -12);
            imgImage.Margin = new Padding(2);
            imgImage.Name = "imgImage";
            imgImage.Size = new Size(40, 40);
            imgImage.TabIndex = 15;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoEllipsis = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(272, 152);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(248, 80);
            lblName.TabIndex = 32;
            lblName.Text = "LILO® Crypterv2";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiSplashScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(689, 394);
            Controls.Add(guna2Panel3);
            Controls.Add(lblName);
            Controls.Add(lblAddtional);
            Controls.Add(label1);
            Controls.Add(bntTrouble);
            FormBorderStyle = FormBorderStyle.None;
            Name = "uiSplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "uiSplashScreen";
            Load += uiSplashScreen_Load;
            guna2Panel3.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm gunaForm1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button bntTrouble;
        private Label lblAddtional;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel imgImage;
        private Label lblName;
    }
}