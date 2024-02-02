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
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            bntOPen = new Guna.UI2.WinForms.Guna2Button();
            statusStrip1 = new StatusStrip();
            lblCreated = new ToolStripStatusLabel();
            lblCrashed = new ToolStripStatusLabel();
            mainText = new RichTextBox();
            progressSpinner = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            pnlLoading = new Panel();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            pnlLoading.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblSessionName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(guna2Button1);
            panel1.Controls.Add(bntOPen);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // lblSessionName
            // 
            resources.ApplyResources(lblSessionName, "lblSessionName");
            lblSessionName.AutoEllipsis = true;
            lblSessionName.Name = "lblSessionName";
            lblSessionName.Click += lblSessionName_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // guna2Button1
            // 
            resources.ApplyResources(guna2Button1, "guna2Button1");
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.Gainsboro;
            guna2Button1.BorderRadius = 5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.ForeColor = Color.DimGray;
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Click += bntAnalyze_Click;
            // 
            // bntOPen
            // 
            resources.ApplyResources(bntOPen, "bntOPen");
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
            bntOPen.ForeColor = Color.DimGray;
            bntOPen.Name = "bntOPen";
            bntOPen.Click += bntOPen_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblCreated, lblCrashed });
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.Name = "statusStrip1";
            // 
            // lblCreated
            // 
            lblCreated.Name = "lblCreated";
            resources.ApplyResources(lblCreated, "lblCreated");
            // 
            // lblCrashed
            // 
            lblCrashed.Name = "lblCrashed";
            resources.ApplyResources(lblCrashed, "lblCrashed");
            // 
            // mainText
            // 
            mainText.BorderStyle = BorderStyle.None;
            resources.ApplyResources(mainText, "mainText");
            mainText.Name = "mainText";
            // 
            // progressSpinner
            // 
            resources.ApplyResources(progressSpinner, "progressSpinner");
            progressSpinner.AutoStart = true;
            progressSpinner.BackColor = Color.White;
            progressSpinner.Name = "progressSpinner";
            // 
            // pnlLoading
            // 
            resources.ApplyResources(pnlLoading, "pnlLoading");
            pnlLoading.BackColor = Color.White;
            pnlLoading.Controls.Add(progressSpinner);
            pnlLoading.Name = "pnlLoading";
            // 
            // uiDebugSessionLogViewer
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlLoading);
            Controls.Add(mainText);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Name = "uiDebugSessionLogViewer";
            Load += uiDebugSessionLogViewer_Load;
            panel1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlLoading.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator progressSpinner;
        private Panel pnlLoading;
    }
}