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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiFileDropDialog));
            lblTask = new Label();
            pnlFileDrop = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            bntShare = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // lblTask
            // 
            lblTask.BackColor = Color.Transparent;
            resources.ApplyResources(lblTask, "lblTask");
            lblTask.ForeColor = Color.Black;
            lblTask.Name = "lblTask";
            // 
            // pnlFileDrop
            // 
            pnlFileDrop.AllowDrop = true;
            resources.ApplyResources(pnlFileDrop, "pnlFileDrop");
            pnlFileDrop.BackColor = Color.Transparent;
            pnlFileDrop.BorderColor = Color.Gainsboro;
            pnlFileDrop.BorderRadius = 15;
            pnlFileDrop.BorderThickness = 2;
            pnlFileDrop.FillColor = Color.WhiteSmoke;
            pnlFileDrop.Name = "pnlFileDrop";
            pnlFileDrop.DragDrop += pnlFileDrop_DragDrop;
            pnlFileDrop.DragEnter += pnlFileDrop_DragEnter;
            pnlFileDrop.MouseEnter += pnlFileDrop_MouseEnter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.DimGray;
            label1.Name = "label1";
            // 
            // bntShare
            // 
            resources.ApplyResources(bntShare, "bntShare");
            bntShare.Animated = true;
            bntShare.BackColor = Color.Transparent;
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
            bntShare.ForeColor = Color.SteelBlue;
            bntShare.Name = "bntShare";
            bntShare.Click += bntShare_Click;
            // 
            // uiFileDropDialog
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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