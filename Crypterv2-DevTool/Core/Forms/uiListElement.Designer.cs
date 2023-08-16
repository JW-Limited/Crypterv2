namespace Crypterv2_DevTool.Core.Forms
{
    partial class uiListElement
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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            bntChange = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            lblDescription = new Label();
            label1 = new Label();
            lblFeatureState = new Label();
            label3 = new Label();
            lblFeature = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.None;
            guna2Panel1.BackColor = SystemColors.ButtonHighlight;
            guna2Panel1.BorderColor = SystemColors.ActiveBorder;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(bntChange);
            guna2Panel1.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(lblFeatureState);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(lblFeature);
            guna2Panel1.FillColor = SystemColors.Control;
            guna2Panel1.Location = new Point(80, 64);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(680, 512);
            guna2Panel1.TabIndex = 24;
            // 
            // bntChange
            // 
            bntChange.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntChange.Animated = true;
            bntChange.BackColor = Color.Transparent;
            bntChange.BorderColor = Color.Gainsboro;
            bntChange.BorderRadius = 20;
            bntChange.BorderThickness = 2;
            bntChange.DisabledState.BorderColor = Color.DarkGray;
            bntChange.DisabledState.CustomBorderColor = Color.DarkGray;
            bntChange.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntChange.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntChange.FillColor = Color.White;
            bntChange.FocusedColor = Color.FromArgb(100, 170, 209);
            bntChange.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            bntChange.ForeColor = Color.Black;
            bntChange.Location = new Point(45, 424);
            bntChange.Margin = new Padding(2);
            bntChange.Name = "bntChange";
            bntChange.Size = new Size(584, 48);
            bntChange.TabIndex = 15;
            bntChange.Text = "?";
            bntChange.Click += bntChange_Click;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Anchor = AnchorStyles.None;
            guna2Panel2.BackColor = SystemColors.Control;
            guna2Panel2.BorderColor = SystemColors.ActiveBorder;
            guna2Panel2.BorderRadius = 15;
            guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel2.BorderThickness = 2;
            guna2Panel2.Controls.Add(lblDescription);
            guna2Panel2.FillColor = Color.White;
            guna2Panel2.Location = new Point(48, 200);
            guna2Panel2.Margin = new Padding(2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.Size = new Size(584, 184);
            guna2Panel2.TabIndex = 24;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.White;
            lblDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(24, 24);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(536, 144);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Function";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 56);
            label1.Name = "label1";
            label1.Size = new Size(128, 40);
            label1.TabIndex = 1;
            label1.Text = "Feature:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFeatureState
            // 
            lblFeatureState.BackColor = SystemColors.Control;
            lblFeatureState.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFeatureState.Location = new Point(272, 112);
            lblFeatureState.Name = "lblFeatureState";
            lblFeatureState.Size = new Size(248, 40);
            lblFeatureState.TabIndex = 1;
            lblFeatureState.Text = "n/a";
            lblFeatureState.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(64, 112);
            label3.Name = "label3";
            label3.Size = new Size(560, 40);
            label3.TabIndex = 1;
            label3.Text = "The feature is currently:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFeature
            // 
            lblFeature.BackColor = SystemColors.Control;
            lblFeature.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblFeature.Location = new Point(184, 56);
            lblFeature.Name = "lblFeature";
            lblFeature.Size = new Size(440, 40);
            lblFeature.TabIndex = 1;
            lblFeature.Text = "n/a";
            lblFeature.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.Gainsboro;
            guna2Button1.BorderRadius = 15;
            guna2Button1.BorderThickness = 2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.DimGray;
            guna2Button1.Location = new Point(800, 16);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(40, 40);
            guna2Button1.TabIndex = 15;
            guna2Button1.Text = "X";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // uiListElement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(856, 632);
            Controls.Add(guna2Button1);
            Controls.Add(guna2Panel1);
            MinimumSize = new Size(878, 688);
            Name = "uiListElement";
            Text = "uiListElement";
            Load += uiListElement_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private Label label3;
        private Label lblFeature;
        private Label lblFeatureState;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label lblDescription;
        private Guna.UI2.WinForms.Guna2Button bntChange;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}