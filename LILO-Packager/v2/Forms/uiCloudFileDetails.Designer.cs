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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiCloudFileDetails));
            lblDescription = new Label();
            lblFileName = new Label();
            pnlImage = new Sipaa.Framework.SPanel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            bntCopy = new Guna.UI2.WinForms.Guna2Button();
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
            resources.ApplyResources(lblDescription, "lblDescription");
            lblDescription.ForeColor = Color.Silver;
            lblDescription.Name = "lblDescription";
            // 
            // lblFileName
            // 
            lblFileName.AutoEllipsis = true;
            lblFileName.BackColor = Color.Transparent;
            resources.ApplyResources(lblFileName, "lblFileName");
            lblFileName.ForeColor = SystemColors.WindowFrame;
            lblFileName.Name = "lblFileName";
            // 
            // pnlImage
            // 
            pnlImage.BackColor = Color.White;
            pnlImage.BackgroundImage = Properties.Resources.Screenshot_2023_10_13_052005;
            resources.ApplyResources(pnlImage, "pnlImage");
            pnlImage.BorderColor = Color.Gainsboro;
            pnlImage.BorderRadius = 20;
            pnlImage.BorderSize = 0;
            pnlImage.ForeColor = Color.White;
            pnlImage.Name = "pnlImage";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.HighlightText;
            guna2Panel1.BorderColor = Color.Gainsboro;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(bntCopy);
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
            resources.ApplyResources(guna2Panel1, "guna2Panel1");
            guna2Panel1.Name = "guna2Panel1";
            // 
            // bntCopy
            // 
            resources.ApplyResources(bntCopy, "bntCopy");
            bntCopy.Animated = true;
            bntCopy.BackColor = Color.Transparent;
            bntCopy.BorderColor = Color.Gainsboro;
            bntCopy.BorderRadius = 12;
            bntCopy.BorderThickness = 2;
            bntCopy.DisabledState.BorderColor = Color.DarkGray;
            bntCopy.DisabledState.CustomBorderColor = Color.DarkGray;
            bntCopy.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntCopy.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntCopy.FillColor = Color.White;
            bntCopy.FocusedColor = Color.FromArgb(100, 170, 209);
            bntCopy.ForeColor = Color.DimGray;
            bntCopy.Image = Properties.Resources.icons8_copy_96;
            bntCopy.ImageSize = new Size(24, 24);
            bntCopy.Name = "bntCopy";
            bntCopy.ShadowDecoration.BorderRadius = 15;
            bntCopy.ShadowDecoration.Color = Color.LightGray;
            bntCopy.ShadowDecoration.Depth = 20;
            bntCopy.Click += bntCopy_Click;
            // 
            // lblMimeType
            // 
            lblMimeType.BackColor = Color.Transparent;
            resources.ApplyResources(lblMimeType, "lblMimeType");
            lblMimeType.ForeColor = Color.DimGray;
            lblMimeType.Name = "lblMimeType";
            // 
            // lblDateUploaded
            // 
            lblDateUploaded.BackColor = Color.Transparent;
            resources.ApplyResources(lblDateUploaded, "lblDateUploaded");
            lblDateUploaded.ForeColor = Color.DimGray;
            lblDateUploaded.Name = "lblDateUploaded";
            // 
            // lblCanBeEdited
            // 
            lblCanBeEdited.BackColor = Color.Transparent;
            resources.ApplyResources(lblCanBeEdited, "lblCanBeEdited");
            lblCanBeEdited.ForeColor = Color.DimGray;
            lblCanBeEdited.Name = "lblCanBeEdited";
            // 
            // lblDownloads
            // 
            lblDownloads.BackColor = Color.Transparent;
            resources.ApplyResources(lblDownloads, "lblDownloads");
            lblDownloads.ForeColor = Color.DimGray;
            lblDownloads.Name = "lblDownloads";
            // 
            // lblHash
            // 
            lblHash.BackColor = Color.Transparent;
            resources.ApplyResources(lblHash, "lblHash");
            lblHash.ForeColor = Color.DimGray;
            lblHash.Name = "lblHash";
            // 
            // lblSize
            // 
            lblSize.BackColor = Color.Transparent;
            resources.ApplyResources(lblSize, "lblSize");
            lblSize.ForeColor = Color.DimGray;
            lblSize.Name = "lblSize";
            // 
            // lblID
            // 
            lblID.BackColor = Color.Transparent;
            resources.ApplyResources(lblID, "lblID");
            lblID.ForeColor = Color.DimGray;
            lblID.Name = "lblID";
            // 
            // panel6
            // 
            panel6.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            resources.ApplyResources(panel6, "panel6");
            panel6.Name = "panel6";
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            resources.ApplyResources(panel5, "panel5");
            panel5.Name = "panel5";
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = Color.Silver;
            label7.Name = "label7";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            resources.ApplyResources(label10, "label10");
            label10.ForeColor = Color.Silver;
            label10.Name = "label10";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.Silver;
            label5.Name = "label5";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Screenshot_2023_10_12_222907;
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            resources.ApplyResources(label8, "label8");
            label8.ForeColor = Color.Silver;
            label8.Name = "label8";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Silver;
            label1.Name = "label1";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.Silver;
            label3.Name = "label3";
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = Color.Silver;
            label6.Name = "label6";
            // 
            // pnlLoading
            // 
            pnlLoading.BackColor = Color.White;
            pnlLoading.BackgroundImage = Properties.Resources.Info;
            resources.ApplyResources(pnlLoading, "pnlLoading");
            pnlLoading.BorderColor = Color.Gainsboro;
            pnlLoading.BorderRadius = 0;
            pnlLoading.BorderSize = 0;
            pnlLoading.Controls.Add(label2);
            pnlLoading.ForeColor = Color.White;
            pnlLoading.Name = "pnlLoading";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.Gray;
            label2.Name = "label2";
            // 
            // uiCloudFileDetails
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlLoading);
            Controls.Add(lblDescription);
            Controls.Add(lblFileName);
            Controls.Add(pnlImage);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "uiCloudFileDetails";
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
        private Guna.UI2.WinForms.Guna2Button bntCopy;
    }
}