namespace LILO_Packager.v2.Forms
{
    partial class uiFileDropDialog
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
            lblTask = new Label();
            pnlFileDrop = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            bntShare = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // lblTask
            // 
            lblTask.BackColor = Color.Transparent;
            lblTask.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTask.ForeColor = Color.Black;
            lblTask.Location = new Point(32, 32);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(304, 32);
            lblTask.TabIndex = 50;
            lblTask.Text = "lblTask";
            lblTask.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlFileDrop
            // 
            pnlFileDrop.AllowDrop = true;
            pnlFileDrop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlFileDrop.BackColor = Color.Transparent;
            pnlFileDrop.BorderColor = Color.Gainsboro;
            pnlFileDrop.BorderRadius = 15;
            pnlFileDrop.BorderThickness = 2;
            pnlFileDrop.FillColor = Color.WhiteSmoke;
            pnlFileDrop.Location = new Point(24, 120);
            pnlFileDrop.Margin = new Padding(2);
            pnlFileDrop.Name = "pnlFileDrop";
            pnlFileDrop.Size = new Size(448, 357);
            pnlFileDrop.TabIndex = 49;
            pnlFileDrop.DragDrop += pnlFileDrop_DragDrop;
            pnlFileDrop.DragEnter += pnlFileDrop_DragEnter;
            pnlFileDrop.MouseEnter += pnlFileDrop_MouseEnter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(32, 64);
            label1.Name = "label1";
            label1.Size = new Size(304, 24);
            label1.TabIndex = 50;
            label1.Text = "lblDescription";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bntShare
            // 
            bntShare.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bntShare.Animated = true;
            bntShare.BackColor = Color.Transparent;
            bntShare.BackgroundImageLayout = ImageLayout.Zoom;
            bntShare.BorderColor = Color.Gainsboro;
            bntShare.BorderRadius = 10;
            bntShare.BorderThickness = 2;
            bntShare.CheckedState.FillColor = Color.White;
            bntShare.DisabledState.BorderColor = Color.Gainsboro;
            bntShare.DisabledState.CustomBorderColor = Color.Gainsboro;
            bntShare.DisabledState.FillColor = Color.WhiteSmoke;
            bntShare.DisabledState.ForeColor = Color.DimGray;
            bntShare.FillColor = Color.White;
            bntShare.FocusedColor = Color.FromArgb(100, 170, 209);
            bntShare.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            bntShare.ForeColor = Color.SteelBlue;
            bntShare.Location = new Point(368, 40);
            bntShare.Margin = new Padding(2);
            bntShare.Name = "bntShare";
            bntShare.Size = new Size(104, 46);
            bntShare.TabIndex = 51;
            bntShare.Text = "Select";
            bntShare.Click += bntShare_Click;
            // 
            // uiFileDropDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(498, 502);
            Controls.Add(bntShare);
            Controls.Add(label1);
            Controls.Add(lblTask);
            Controls.Add(pnlFileDrop);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "uiFileDropDialog";
            ShowIcon = false;
            Load += uiFileDropDialog_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTask;
        private Guna.UI2.WinForms.Guna2Panel pnlFileDrop;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button bntShare;
    }
}