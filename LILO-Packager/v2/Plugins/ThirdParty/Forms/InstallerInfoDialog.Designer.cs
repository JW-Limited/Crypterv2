namespace LILO_Packager.v2.Plugins.ThirdParty.Forms
{
    partial class InstallerInfoDialog
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
            pnlChild = new Guna.UI2.WinForms.Guna2Panel();
            sPanel1 = new Sipaa.Framework.SPanel();
            label1 = new Label();
            label2 = new Label();
            lblProgVers = new Label();
            lblName = new Label();
            pnlChild.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChild
            // 
            pnlChild.Anchor = AnchorStyles.None;
            pnlChild.BackColor = Color.Transparent;
            pnlChild.BorderColor = Color.Gainsboro;
            pnlChild.BorderRadius = 25;
            pnlChild.BorderThickness = 2;
            pnlChild.Controls.Add(sPanel1);
            pnlChild.Controls.Add(label1);
            pnlChild.Controls.Add(label2);
            pnlChild.Controls.Add(lblProgVers);
            pnlChild.Controls.Add(lblName);
            pnlChild.FillColor = Color.White;
            pnlChild.Location = new Point(136, 72);
            pnlChild.Margin = new Padding(2);
            pnlChild.Name = "pnlChild";
            pnlChild.Size = new Size(536, 288);
            pnlChild.TabIndex = 25;
            pnlChild.Click += pnlChild_Click;
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
            sPanel1.Location = new Point(32, 32);
            sPanel1.Name = "sPanel1";
            sPanel1.Size = new Size(128, 120);
            sPanel1.TabIndex = 28;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(32, 160);
            label1.Name = "label1";
            label1.Size = new Size(480, 56);
            label1.TabIndex = 26;
            label1.Text = "The Cryptex technologie was developed by Joe Valentino Lengefeld and is beeing used under an exclusive license by JW Limited.";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(32, 232);
            label2.Name = "label2";
            label2.Size = new Size(224, 32);
            label2.TabIndex = 26;
            label2.Text = "Copyright: JW Limited 2023";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblProgVers
            // 
            lblProgVers.BackColor = Color.Transparent;
            lblProgVers.Font = new Font("Segoe UI", 10F);
            lblProgVers.ForeColor = Color.DimGray;
            lblProgVers.Location = new Point(184, 96);
            lblProgVers.Name = "lblProgVers";
            lblProgVers.Size = new Size(368, 40);
            lblProgVers.TabIndex = 26;
            lblProgVers.Text = "Verison";
            lblProgVers.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            lblName.AutoEllipsis = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(184, 48);
            lblName.Name = "lblName";
            lblName.Size = new Size(301, 64);
            lblName.TabIndex = 27;
            lblName.Text = "LILO® Cryptex";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // InstallerInfoDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImage = Properties.Resources.Moonlit_Asteroid;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlChild);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InstallerInfoDialog";
            Opacity = 0.5D;
            Text = "s";
            Load += InstallerInfoDialog_Load;
            Click += InstallerInfoDialog_Click;
            pnlChild.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlChild;
        private Label lblProgVers;
        private Label lblName;
        private Sipaa.Framework.SPanel sPanel1;
        private Label label2;
        private Label label1;
    }
}