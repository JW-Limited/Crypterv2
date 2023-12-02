namespace LILO_Packager.v2.Forms
{
    partial class uiCloudFileDetails
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
            lblDescription = new Label();
            lblFileName = new Label();
            pnlImage = new Sipaa.Framework.SPanel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblMimeType = new Label();
            lblDateUploaded = new Label();
            lblCanBeEdited = new Label();
            lblDownloads = new Label();
            lblHash = new Label();
            lblSize = new Label();
            lblID = new Label();
            panel6 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            label10 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            label1 = new Label();
            label3 = new Label();
            label6 = new Label();
            pnlLoading = new Sipaa.Framework.SPanel();
            label2 = new Label();
            guna2Panel1.SuspendLayout();
            pnlLoading.SuspendLayout();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblDescription.ForeColor = Color.Silver;
            lblDescription.Location = new Point(168, 88);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(352, 40);
            lblDescription.TabIndex = 55;
            lblDescription.Text = "VERSION\r\n";
            // 
            // lblFileName
            // 
            lblFileName.AutoEllipsis = true;
            lblFileName.BackColor = Color.Transparent;
            lblFileName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFileName.ForeColor = SystemColors.WindowFrame;
            lblFileName.Location = new Point(168, 48);
            lblFileName.Margin = new Padding(4, 0, 4, 0);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(352, 40);
            lblFileName.TabIndex = 54;
            lblFileName.Text = "LILO Sync";
            lblFileName.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlImage
            // 
            pnlImage.BackColor = Color.White;
            pnlImage.BackgroundImage = Properties.Resources.Screenshot_2023_10_13_052005;
            pnlImage.BackgroundImageLayout = ImageLayout.Zoom;
            pnlImage.BorderColor = Color.Gainsboro;
            pnlImage.BorderRadius = 20;
            pnlImage.BorderSize = 0;
            pnlImage.ForeColor = Color.White;
            pnlImage.Location = new Point(48, 40);
            pnlImage.Margin = new Padding(4);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(96, 88);
            pnlImage.TabIndex = 52;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.HighlightText;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(lblMimeType);
            guna2Panel1.Controls.Add(lblDateUploaded);
            guna2Panel1.Controls.Add(lblCanBeEdited);
            guna2Panel1.Controls.Add(lblDownloads);
            guna2Panel1.Controls.Add(lblHash);
            guna2Panel1.Controls.Add(lblSize);
            guna2Panel1.Controls.Add(lblID);
            guna2Panel1.Controls.Add(panel6);
            guna2Panel1.Controls.Add(panel3);
            guna2Panel1.Controls.Add(panel5);
            guna2Panel1.Controls.Add(label7);
            guna2Panel1.Controls.Add(panel2);
            guna2Panel1.Controls.Add(panel4);
            guna2Panel1.Controls.Add(label10);
            guna2Panel1.Controls.Add(label5);
            guna2Panel1.Controls.Add(panel1);
            guna2Panel1.Controls.Add(label8);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(label6);
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(40, 176);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(496, 392);
            guna2Panel1.TabIndex = 51;
            // 
            // lblMimeType
            // 
            lblMimeType.BackColor = Color.Transparent;
            lblMimeType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMimeType.ForeColor = Color.DimGray;
            lblMimeType.Location = new Point(288, 328);
            lblMimeType.Margin = new Padding(4, 0, 4, 0);
            lblMimeType.Name = "lblMimeType";
            lblMimeType.Size = new Size(176, 48);
            lblMimeType.TabIndex = 44;
            lblMimeType.Text = "n/a";
            // 
            // lblDateUploaded
            // 
            lblDateUploaded.BackColor = Color.Transparent;
            lblDateUploaded.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDateUploaded.ForeColor = Color.DimGray;
            lblDateUploaded.Location = new Point(288, 176);
            lblDateUploaded.Margin = new Padding(4, 0, 4, 0);
            lblDateUploaded.Name = "lblDateUploaded";
            lblDateUploaded.Size = new Size(160, 30);
            lblDateUploaded.TabIndex = 44;
            lblDateUploaded.Text = "n/a";
            lblDateUploaded.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCanBeEdited
            // 
            lblCanBeEdited.BackColor = Color.Transparent;
            lblCanBeEdited.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCanBeEdited.ForeColor = Color.DimGray;
            lblCanBeEdited.Location = new Point(288, 272);
            lblCanBeEdited.Margin = new Padding(4, 0, 4, 0);
            lblCanBeEdited.Name = "lblCanBeEdited";
            lblCanBeEdited.Size = new Size(160, 30);
            lblCanBeEdited.TabIndex = 44;
            lblCanBeEdited.Text = "n/a";
            lblCanBeEdited.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDownloads
            // 
            lblDownloads.BackColor = Color.Transparent;
            lblDownloads.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDownloads.ForeColor = Color.DimGray;
            lblDownloads.Location = new Point(288, 128);
            lblDownloads.Margin = new Padding(4, 0, 4, 0);
            lblDownloads.Name = "lblDownloads";
            lblDownloads.Size = new Size(160, 30);
            lblDownloads.TabIndex = 44;
            lblDownloads.Text = "n/a";
            lblDownloads.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHash
            // 
            lblHash.BackColor = Color.Transparent;
            lblHash.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHash.ForeColor = Color.DimGray;
            lblHash.Location = new Point(288, 224);
            lblHash.Margin = new Padding(4, 0, 4, 0);
            lblHash.Name = "lblHash";
            lblHash.Size = new Size(160, 30);
            lblHash.TabIndex = 44;
            lblHash.Text = "n/a";
            lblHash.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSize
            // 
            lblSize.BackColor = Color.Transparent;
            lblSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSize.ForeColor = Color.DimGray;
            lblSize.Location = new Point(288, 80);
            lblSize.Margin = new Padding(4, 0, 4, 0);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(160, 30);
            lblSize.TabIndex = 44;
            lblSize.Text = "n/a";
            lblSize.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblID
            // 
            lblID.BackColor = Color.Transparent;
            lblID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblID.ForeColor = Color.DimGray;
            lblID.Location = new Point(288, 32);
            lblID.Margin = new Padding(4, 0, 4, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(160, 30);
            lblID.TabIndex = 44;
            lblID.Text = "n/a";
            lblID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            panel6.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(24, 304);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(440, 16);
            panel6.TabIndex = 36;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(24, 160);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(440, 16);
            panel3.TabIndex = 36;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(24, 256);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(440, 16);
            panel5.TabIndex = 36;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(40, 320);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(136, 30);
            label7.TabIndex = 44;
            label7.Text = "Mime Type";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(24, 112);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 16);
            panel2.TabIndex = 36;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(24, 208);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(440, 16);
            panel4.TabIndex = 36;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(40, 176);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(168, 30);
            label10.TabIndex = 44;
            label10.Text = "Date Uploaded";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(40, 272);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(136, 30);
            label5.TabIndex = 44;
            label5.Text = "Can Edit";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(24, 64);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 16);
            panel1.TabIndex = 36;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(40, 128);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(136, 30);
            label8.TabIndex = 44;
            label8.Text = "Downloads";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(40, 224);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 30);
            label1.TabIndex = 44;
            label1.Text = "Hash Sha256";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(40, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 30);
            label3.TabIndex = 44;
            label3.Text = "File ID";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(40, 80);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(136, 30);
            label6.TabIndex = 44;
            label6.Text = "Size";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlLoading
            // 
            pnlLoading.BackColor = Color.White;
            pnlLoading.BackgroundImage = Properties.Resources.Info;
            pnlLoading.BackgroundImageLayout = ImageLayout.Center;
            pnlLoading.BorderColor = Color.Gainsboro;
            pnlLoading.BorderRadius = 0;
            pnlLoading.BorderSize = 0;
            pnlLoading.Controls.Add(label2);
            pnlLoading.ForeColor = Color.White;
            pnlLoading.Location = new Point(0, 0);
            pnlLoading.Margin = new Padding(4);
            pnlLoading.Name = "pnlLoading";
            pnlLoading.Size = new Size(573, 609);
            pnlLoading.TabIndex = 52;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(224, 536);
            label2.Name = "label2";
            label2.Size = new Size(128, 38);
            label2.TabIndex = 0;
            label2.Text = "Loading...";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiCloudFileDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(573, 609);
            Controls.Add(pnlLoading);
            Controls.Add(lblDescription);
            Controls.Add(lblFileName);
            Controls.Add(pnlImage);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "uiCloudFileDetails";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MainHost -  Cloud";
            Load += uiCloudFileDetails_Load;
            guna2Panel1.ResumeLayout(false);
            pnlLoading.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblDescription;
        private Label lblFileName;
        private Sipaa.Framework.SPanel pnlImage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblDateUploaded;
        private Label lblDownloads;
        private Label lblSize;
        private Label lblID;
        private Panel panel3;
        private Panel panel2;
        private Label label10;
        private Panel panel1;
        private Label label8;
        private Label label3;
        private Label label6;
        private Label lblMimeType;
        private Label lblCanBeEdited;
        private Label lblHash;
        private Panel panel6;
        private Panel panel5;
        private Label label7;
        private Panel panel4;
        private Label label5;
        private Label label1;
        private Sipaa.Framework.SPanel pnlLoading;
        private Label label2;
    }
}