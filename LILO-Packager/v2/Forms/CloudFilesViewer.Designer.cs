namespace LILO_Packager.v2.Forms
{
    partial class CloudFilesViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloudFilesViewer));
            lblVersion = new Label();
            label5 = new Label();
            label4 = new Label();
            sPanel1 = new Sipaa.Framework.SPanel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblCloud = new Label();
            lblNetwork = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label3 = new Label();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            label1 = new Label();
            pnlSide = new Guna.UI2.WinForms.Guna2Panel();
            prgMiniProgress = new Guna.UI2.WinForms.Guna2ProgressBar();
            label7 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            lblMatrix = new Label();
            label10 = new Label();
            panel3 = new Panel();
            lblMatrixVersion = new Label();
            guna2Panel1.SuspendLayout();
            guna2Panel3.SuspendLayout();
            pnlSide.SuspendLayout();
            SuspendLayout();
            // 
            // lblVersion
            // 
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblVersion.ForeColor = Color.Silver;
            lblVersion.Location = new Point(136, 72);
            lblVersion.Margin = new Padding(4, 0, 4, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(184, 22);
            lblVersion.TabIndex = 50;
            lblVersion.Text = "VERSION\r\n";
            lblVersion.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(40, 144);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(136, 40);
            label5.TabIndex = 48;
            label5.Text = "    Checklist";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(136, 32);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(224, 40);
            label4.TabIndex = 49;
            label4.Text = "LILO Sync";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // sPanel1
            // 
            sPanel1.BackColor = Color.White;
            sPanel1.BackgroundImage = Properties.Resources.Screenshot_2023_10_13_052005;
            sPanel1.BackgroundImageLayout = ImageLayout.Zoom;
            sPanel1.BorderColor = Color.Gainsboro;
            sPanel1.BorderRadius = 20;
            sPanel1.BorderSize = 0;
            sPanel1.ForeColor = Color.White;
            sPanel1.Location = new Point(24, 24);
            sPanel1.Margin = new Padding(4);
            sPanel1.Name = "sPanel1";
            sPanel1.Size = new Size(96, 88);
            sPanel1.TabIndex = 47;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.HighlightText;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(lblMatrixVersion);
            guna2Panel1.Controls.Add(lblMatrix);
            guna2Panel1.Controls.Add(lblCloud);
            guna2Panel1.Controls.Add(lblNetwork);
            guna2Panel1.Controls.Add(panel3);
            guna2Panel1.Controls.Add(panel2);
            guna2Panel1.Controls.Add(label10);
            guna2Panel1.Controls.Add(panel1);
            guna2Panel1.Controls.Add(label8);
            guna2Panel1.Controls.Add(label6);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(24, 160);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(304, 240);
            guna2Panel1.TabIndex = 45;
            // 
            // lblCloud
            // 
            lblCloud.BackColor = Color.Transparent;
            lblCloud.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCloud.ForeColor = Color.DimGray;
            lblCloud.Location = new Point(160, 88);
            lblCloud.Margin = new Padding(4, 0, 4, 0);
            lblCloud.Name = "lblCloud";
            lblCloud.Size = new Size(112, 30);
            lblCloud.TabIndex = 44;
            lblCloud.Text = "n/a";
            lblCloud.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNetwork
            // 
            lblNetwork.BackColor = Color.Transparent;
            lblNetwork.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNetwork.ForeColor = Color.DimGray;
            lblNetwork.Location = new Point(160, 40);
            lblNetwork.Margin = new Padding(4, 0, 4, 0);
            lblNetwork.Name = "lblNetwork";
            lblNetwork.Size = new Size(112, 30);
            lblNetwork.TabIndex = 44;
            lblNetwork.Text = "n/a";
            lblNetwork.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(24, 72);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 16);
            panel1.TabIndex = 36;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(40, 88);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(136, 30);
            label6.TabIndex = 44;
            label6.Text = "Cloud";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(40, 40);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 30);
            label3.TabIndex = 44;
            label3.Text = "Internet\r\n";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Panel3
            // 
            guna2Panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            guna2Panel3.BackColor = Color.White;
            guna2Panel3.BorderColor = Color.Gainsboro;
            guna2Panel3.BorderRadius = 15;
            guna2Panel3.BorderThickness = 2;
            guna2Panel3.Controls.Add(label2);
            guna2Panel3.Controls.Add(label1);
            guna2Panel3.FillColor = Color.WhiteSmoke;
            guna2Panel3.Location = new Point(24, 784);
            guna2Panel3.Margin = new Padding(2);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Size = new Size(304, 80);
            guna2Panel3.TabIndex = 46;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(16, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 44;
            label2.Text = "powered by ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(23, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 40);
            label1.TabIndex = 43;
            label1.Text = "JW Limited ©️ 2023";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSide
            // 
            pnlSide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSide.BackColor = Color.Transparent;
            pnlSide.BorderColor = Color.Gainsboro;
            pnlSide.BorderRadius = 15;
            pnlSide.BorderThickness = 2;
            pnlSide.Controls.Add(prgMiniProgress);
            pnlSide.Controls.Add(label7);
            pnlSide.FillColor = Color.White;
            pnlSide.Location = new Point(352, 32);
            pnlSide.Margin = new Padding(2);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(984, 832);
            pnlSide.TabIndex = 51;
            // 
            // prgMiniProgress
            // 
            prgMiniProgress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            prgMiniProgress.BackColor = Color.Transparent;
            prgMiniProgress.BorderColor = Color.Gainsboro;
            prgMiniProgress.BorderRadius = 2;
            prgMiniProgress.BorderThickness = 2;
            prgMiniProgress.FillColor = Color.White;
            prgMiniProgress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            prgMiniProgress.Location = new Point(144, 40);
            prgMiniProgress.Margin = new Padding(2);
            prgMiniProgress.Name = "prgMiniProgress";
            prgMiniProgress.ProgressColor = Color.SteelBlue;
            prgMiniProgress.ProgressColor2 = Color.RoyalBlue;
            prgMiniProgress.ShadowDecoration.Depth = 20;
            prgMiniProgress.Size = new Size(808, 8);
            prgMiniProgress.Style = ProgressBarStyle.Marquee;
            prgMiniProgress.TabIndex = 45;
            prgMiniProgress.Text = "guna2ProgressBar1";
            prgMiniProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(24, 8);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(320, 64);
            label7.TabIndex = 46;
            label7.Text = "My Files";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(24, 120);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 16);
            panel2.TabIndex = 36;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(40, 136);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(136, 30);
            label8.TabIndex = 44;
            label8.Text = "Matrix";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMatrix
            // 
            lblMatrix.BackColor = Color.Transparent;
            lblMatrix.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMatrix.ForeColor = Color.DimGray;
            lblMatrix.Location = new Point(160, 136);
            lblMatrix.Margin = new Padding(4, 0, 4, 0);
            lblMatrix.Name = "lblMatrix";
            lblMatrix.Size = new Size(112, 30);
            lblMatrix.TabIndex = 44;
            lblMatrix.Text = "n/a";
            lblMatrix.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(40, 184);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(136, 30);
            label10.TabIndex = 44;
            label10.Text = "Mtx Version";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(24, 168);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(248, 16);
            panel3.TabIndex = 36;
            // 
            // lblMatrixVersion
            // 
            lblMatrixVersion.BackColor = Color.Transparent;
            lblMatrixVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMatrixVersion.ForeColor = Color.DimGray;
            lblMatrixVersion.Location = new Point(160, 184);
            lblMatrixVersion.Margin = new Padding(4, 0, 4, 0);
            lblMatrixVersion.Name = "lblMatrixVersion";
            lblMatrixVersion.Size = new Size(112, 30);
            lblMatrixVersion.TabIndex = 44;
            lblMatrixVersion.Text = "n/a";
            lblMatrixVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CloudFilesViewer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1359, 892);
            Controls.Add(pnlSide);
            Controls.Add(lblVersion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(sPanel1);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2Panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CloudFilesViewer";
            Text = "MainHost - Cloud";
            Load += CloudFilesViewer_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel3.ResumeLayout(false);
            pnlSide.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblVersion;
        private Label label5;
        private Label label4;
        private Sipaa.Framework.SPanel sPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblCloud;
        private Label lblNetwork;
        private Panel panel1;
        private Label label6;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnlSide;
        private Guna.UI2.WinForms.Guna2ProgressBar prgMiniProgress;
        private Label label7;
        private Label lblMatrixVersion;
        private Label lblMatrix;
        private Panel panel3;
        private Panel panel2;
        private Label label10;
        private Label label8;
    }
}