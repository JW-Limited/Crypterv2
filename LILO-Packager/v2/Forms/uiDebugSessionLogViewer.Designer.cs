namespace LILO_Packager.v2.Forms
{
    partial class uiDebugSessionLogViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiDebugSessionLogViewer));
            panel1 = new Panel();
            lblSessionName = new Label();
            label1 = new Label();
            bntOPen = new Guna.UI2.WinForms.Guna2Button();
            statusStrip1 = new StatusStrip();
            lblCreated = new ToolStripStatusLabel();
            lblCrashed = new ToolStripStatusLabel();
            mainText = new RichTextBox();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblSessionName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bntOPen);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(995, 72);
            panel1.TabIndex = 0;
            // 
            // lblSessionName
            // 
            lblSessionName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSessionName.AutoEllipsis = true;
            lblSessionName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSessionName.Location = new Point(112, 16);
            lblSessionName.Margin = new Padding(2, 0, 2, 0);
            lblSessionName.Name = "lblSessionName";
            lblSessionName.Size = new Size(756, 40);
            lblSessionName.TabIndex = 21;
            lblSessionName.Text = "label1";
            lblSessionName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 40);
            label1.TabIndex = 21;
            label1.Text = "Session:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bntOPen
            // 
            bntOPen.Anchor = AnchorStyles.Right;
            bntOPen.Animated = true;
            bntOPen.BackColor = Color.Transparent;
            bntOPen.BorderColor = Color.Gainsboro;
            bntOPen.BorderRadius = 5;
            bntOPen.DisabledState.BorderColor = Color.DarkGray;
            bntOPen.DisabledState.CustomBorderColor = Color.DarkGray;
            bntOPen.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntOPen.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntOPen.FillColor = Color.White;
            bntOPen.FocusedColor = Color.FromArgb(100, 170, 209);
            bntOPen.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            bntOPen.ForeColor = Color.DimGray;
            bntOPen.Location = new Point(876, 16);
            bntOPen.Margin = new Padding(2);
            bntOPen.Name = "bntOPen";
            bntOPen.Size = new Size(104, 40);
            bntOPen.TabIndex = 20;
            bntOPen.Text = "Report";
            bntOPen.Click += bntOPen_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblCreated, lblCrashed });
            statusStrip1.Location = new Point(0, 776);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(995, 32);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblCreated
            // 
            lblCreated.Name = "lblCreated";
            lblCreated.Size = new Size(38, 25);
            lblCreated.Text = "n/a";
            // 
            // lblCrashed
            // 
            lblCrashed.Name = "lblCrashed";
            lblCrashed.Size = new Size(38, 25);
            lblCrashed.Text = "n/a";
            // 
            // mainText
            // 
            mainText.BorderStyle = BorderStyle.None;
            mainText.Dock = DockStyle.Fill;
            mainText.Location = new Point(0, 72);
            mainText.Name = "mainText";
            mainText.Size = new Size(995, 704);
            mainText.TabIndex = 2;
            mainText.Text = "";
            // 
            // uiDebugSessionLogViewer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 808);
            Controls.Add(mainText);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "uiDebugSessionLogViewer";
            Text = "Debug Session Viewer";
            Load += uiDebugSessionLogViewer_Load;
            panel1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblSessionName;
        private ComboBox cmbPlugins;
        private Guna.UI2.WinForms.Guna2Button bntOPen;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblCreated;
        private ToolStripStatusLabel lblCrashed;
        private RichTextBox mainText;
    }
}