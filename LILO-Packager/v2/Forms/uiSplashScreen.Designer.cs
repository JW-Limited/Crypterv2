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
            sPanel1 = new Sipaa.Framework.SPanel();
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
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
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
            bntTrouble.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
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
            lblAddtional.Font = new Font("Segoe UI", 10F);
            lblAddtional.ForeColor = Color.Black;
            lblAddtional.Location = new Point(32, 24);
            lblAddtional.Margin = new Padding(4, 0, 4, 0);
            lblAddtional.Name = "lblAddtional";
            lblAddtional.Size = new Size(176, 40);
            lblAddtional.TabIndex = 31;
            lblAddtional.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sPanel1
            // 
            sPanel1.BackColor = Color.Black;
            sPanel1.BackgroundImage = Properties.Resources.Screenshot_2023_10_13_052005;
            sPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel1.BorderColor = Color.Black;
            sPanel1.BorderRadius = 20;
            sPanel1.BorderSize = 0;
            sPanel1.ForeColor = Color.White;
            sPanel1.Location = new Point(248, 88);
            sPanel1.Margin = new Padding(4);
            sPanel1.Name = "sPanel1";
            sPanel1.Size = new Size(184, 176);
            sPanel1.TabIndex = 32;
            // 
            // uiSplashScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(689, 394);
            Controls.Add(sPanel1);
            Controls.Add(lblAddtional);
            Controls.Add(label1);
            Controls.Add(bntTrouble);
            FormBorderStyle = FormBorderStyle.None;
            Name = "uiSplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "uiSplashScreen";
            Load += uiSplashScreen_Load;
            ResumeLayout(false);
        }



        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm gunaForm1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button bntTrouble;
        private Label lblAddtional;
        private Sipaa.Framework.SPanel sPanel1;
    }
}