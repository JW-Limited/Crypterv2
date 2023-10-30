namespace Crypterv2.DevTool.Core.Forms
{
    partial class uiDialogInfos
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
            cmbState = new Guna.UI2.WinForms.Guna2ComboBox();
            txtName = new Sipaa.Framework.STextBox();
            label3 = new Label();
            label1 = new Label();
            txtVersion = new Sipaa.Framework.STextBox();
            label2 = new Label();
            txtReadMe = new RichTextBox();
            pnlLoad = new Guna.UI2.WinForms.Guna2Panel();
            label4 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            sPanel2.SuspendLayout();
            pnlLoad.SuspendLayout();
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
            sPanel2.Location = new Point(0, 471);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(552, 66);
            sPanel2.TabIndex = 19;
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
            bntOk.DisabledState.BorderColor = Color.Gainsboro;
            bntOk.DisabledState.CustomBorderColor = Color.DarkGray;
            bntOk.DisabledState.FillColor = Color.White;
            bntOk.DisabledState.ForeColor = Color.Gray;
            bntOk.FillColor = Color.Transparent;
            bntOk.FocusedColor = Color.FromArgb(100, 170, 209);
            bntOk.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            bntOk.ForeColor = Color.Black;
            bntOk.Location = new Point(447, 16);
            bntOk.Margin = new Padding(2);
            bntOk.Name = "bntOk";
            bntOk.Size = new Size(93, 38);
            bntOk.TabIndex = 15;
            bntOk.Text = "Cancel";
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
            bntCancel.DisabledState.BorderColor = Color.Gainsboro;
            bntCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            bntCancel.DisabledState.FillColor = Color.White;
            bntCancel.DisabledState.ForeColor = Color.Gray;
            bntCancel.FocusedColor = Color.FromArgb(100, 170, 209);
            bntCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            bntCancel.ForeColor = Color.White;
            bntCancel.Location = new Point(287, 16);
            bntCancel.Margin = new Padding(2);
            bntCancel.Name = "bntCancel";
            bntCancel.Size = new Size(144, 38);
            bntCancel.TabIndex = 15;
            bntCancel.Text = "Submit";
            bntCancel.Click += bntCancel_Click;
            // 
            // cmbState
            // 
            cmbState.BackColor = Color.Transparent;
            cmbState.BorderRadius = 10;
            cmbState.DrawMode = DrawMode.OwnerDrawFixed;
            cmbState.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbState.FocusedColor = Color.Empty;
            cmbState.Font = new Font("Segoe UI", 10.2F);
            cmbState.ForeColor = Color.FromArgb(68, 88, 112);
            cmbState.HoverState.BorderColor = Color.Gray;
            cmbState.ItemHeight = 30;
            cmbState.Items.AddRange(new object[] { "stable", "beta", "alpha", "dev" });
            cmbState.ItemsAppearance.ForeColor = Color.Gray;
            cmbState.Location = new Point(424, 96);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(100, 36);
            cmbState.TabIndex = 23;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.BackColor = Color.White;
            txtName.BorderColor = Color.Gainsboro;
            txtName.BorderFocusColor = Color.DimGray;
            txtName.BorderRadius = 10;
            txtName.BorderSize = 1;
            txtName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(160, 40);
            txtName.Margin = new Padding(4, 4, 4, 4);
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Padding = new Padding(10, 7, 10, 7);
            txtName.PasswordChar = false;
            txtName.PlaceholderColor = Color.DarkGray;
            txtName.PlaceholderText = "";
            txtName.Size = new Size(366, 38);
            txtName.TabIndex = 16;
            txtName.Texts = "";
            txtName.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(24, 40);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 40);
            label3.TabIndex = 20;
            label3.Text = "Name:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(24, 96);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 40);
            label1.TabIndex = 20;
            label1.Text = "Version:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtVersion
            // 
            txtVersion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtVersion.BackColor = Color.White;
            txtVersion.BorderColor = Color.Gainsboro;
            txtVersion.BorderFocusColor = Color.DimGray;
            txtVersion.BorderRadius = 10;
            txtVersion.BorderSize = 1;
            txtVersion.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtVersion.ForeColor = Color.Black;
            txtVersion.Location = new Point(160, 96);
            txtVersion.Margin = new Padding(4, 4, 4, 4);
            txtVersion.Multiline = false;
            txtVersion.Name = "txtVersion";
            txtVersion.Padding = new Padding(10, 7, 10, 7);
            txtVersion.PasswordChar = false;
            txtVersion.PlaceholderColor = Color.DarkGray;
            txtVersion.PlaceholderText = "";
            txtVersion.Size = new Size(256, 38);
            txtVersion.TabIndex = 16;
            txtVersion.Texts = "";
            txtVersion.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(24, 152);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 40);
            label2.TabIndex = 20;
            label2.Text = "Release Notes:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtReadMe
            // 
            txtReadMe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtReadMe.BorderStyle = BorderStyle.None;
            txtReadMe.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtReadMe.Location = new Point(16, 16);
            txtReadMe.Name = "txtReadMe";
            txtReadMe.Size = new Size(336, 184);
            txtReadMe.TabIndex = 21;
            txtReadMe.Text = "";
            // 
            // pnlLoad
            // 
            pnlLoad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLoad.BackColor = Color.Transparent;
            pnlLoad.BorderColor = Color.Gainsboro;
            pnlLoad.BorderRadius = 10;
            pnlLoad.BorderThickness = 1;
            pnlLoad.Controls.Add(txtReadMe);
            pnlLoad.FillColor = Color.White;
            pnlLoad.Location = new Point(160, 152);
            pnlLoad.Margin = new Padding(2);
            pnlLoad.Name = "pnlLoad";
            pnlLoad.Size = new Size(368, 216);
            pnlLoad.TabIndex = 22;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(24, 392);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 40);
            label4.TabIndex = 20;
            label4.Text = "Features:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2Button1.BorderColor = Color.Gainsboro;
            guna2Button1.BorderRadius = 14;
            guna2Button1.BorderThickness = 2;
            guna2Button1.DisabledState.BorderColor = Color.Gainsboro;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.White;
            guna2Button1.DisabledState.ForeColor = Color.Gray;
            guna2Button1.FillColor = Color.White;
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.FromArgb(94, 148, 255);
            guna2Button1.Location = new Point(160, 393);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(368, 38);
            guna2Button1.TabIndex = 15;
            guna2Button1.Text = "Customize";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // uiDialogInfos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(552, 537);
            ControlBox = false;
            Controls.Add(pnlLoad);
            Controls.Add(guna2Button1);
            Controls.Add(txtVersion);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(cmbState);
            Controls.Add(sPanel2);
            HelpButton = true;
            MaximizeBox = false;
            MaximumSize = new Size(570, 584);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(570, 584);
            Name = "uiDialogInfos";
            Text = "Plugin Information";
            Load += uiDialogInfos_Load;
            sPanel2.ResumeLayout(false);
            pnlLoad.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sipaa.Framework.SPanel sPanel2;
        private Guna.UI2.WinForms.Guna2Button bntOk;
        private Guna.UI2.WinForms.Guna2Button bntCancel;
        private Sipaa.Framework.STextBox txtName;
        private Label label3;
        private Label label1;
        private Sipaa.Framework.STextBox txtVersion;
        private Label label2;
        private RichTextBox txtReadMe;
        private Guna.UI2.WinForms.Guna2Panel pnlLoad;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbState;
    }
}