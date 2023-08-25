namespace LILO_Packager.v2.Forms
{
    partial class uiFeatureNullException
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
            lblName = new Label();
            imgImage = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblMes = new Label();
            lblExc = new Label();
            pnlPreview.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPreview
            // 
            pnlPreview.Anchor = AnchorStyles.None;
            pnlPreview.BackColor = Color.White;
            pnlPreview.BorderColor = SystemColors.ActiveBorder;
            pnlPreview.BorderRadius = 15;
            pnlPreview.Controls.Add(lblName);
            pnlPreview.Controls.Add(imgImage);
            pnlPreview.FillColor = Color.White;
            pnlPreview.Location = new Point(288, 112);
            pnlPreview.Margin = new Padding(2);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Size = new Size(488, 416);
            pnlPreview.TabIndex = 12;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoEllipsis = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(-8, 352);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(488, 56);
            lblName.TabIndex = 13;
            lblName.Text = "Ohh, Ohh";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imgImage
            // 
            imgImage.Anchor = AnchorStyles.None;
            imgImage.BackColor = Color.Transparent;
            imgImage.BackgroundImage = Properties.Resources.pngwing_com__19_;
            imgImage.BackgroundImageLayout = ImageLayout.Zoom;
            imgImage.BorderColor = SystemColors.ActiveBorder;
            imgImage.BorderRadius = 20;
            imgImage.FillColor = Color.Transparent;
            imgImage.Location = new Point(80, 32);
            imgImage.Margin = new Padding(2);
            imgImage.Name = "imgImage";
            imgImage.Size = new Size(320, 312);
            imgImage.TabIndex = 11;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.None;
            guna2Panel1.BorderColor = SystemColors.ActiveBorder;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(lblMes);
            guna2Panel1.Controls.Add(lblExc);
            guna2Panel1.FillColor = Color.Transparent;
            guna2Panel1.Location = new Point(280, 560);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(496, 122);
            guna2Panel1.TabIndex = 14;
            // 
            // lblMes
            // 
            lblMes.AutoEllipsis = true;
            lblMes.BackColor = Color.Transparent;
            lblMes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMes.ForeColor = Color.Black;
            lblMes.Location = new Point(0, 64);
            lblMes.Margin = new Padding(4, 0, 4, 0);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(488, 48);
            lblMes.TabIndex = 13;
            lblMes.Text = "The Feature isnt activated right now";
            lblMes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblExc
            // 
            lblExc.BackColor = Color.Transparent;
            lblExc.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblExc.ForeColor = Color.Black;
            lblExc.Location = new Point(16, 16);
            lblExc.Margin = new Padding(4, 0, 4, 0);
            lblExc.Name = "lblExc";
            lblExc.Size = new Size(464, 40);
            lblExc.TabIndex = 1;
            lblExc.Text = "(FeatureNullException)";
            lblExc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiFeatureNullException
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1083, 826);
            Controls.Add(guna2Panel1);
            Controls.Add(pnlPreview);
            Name = "uiFeatureNullException";
            Text = "uiFeatureNullException";
            Load += uiFeatureNullException_Load;
            pnlPreview.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlPreview;
        private Guna.UI2.WinForms.Guna2Panel imgImage;
        private Label lblName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblMes;
        private Label lblExc;
    }
}