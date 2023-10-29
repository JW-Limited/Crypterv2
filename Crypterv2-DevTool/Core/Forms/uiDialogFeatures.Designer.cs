namespace Crypterv2.DevTool.Core.Forms
{
    partial class uiDialogFeatures
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
            pnlBroadCasting = new LILO_Packager.v2.Controls.DynamikPanelControl();
            pnlLLSHandle = new LILO_Packager.v2.Controls.DynamikPanelControl();
            pnlOSRes = new LILO_Packager.v2.Controls.DynamikPanelControl();
            pnlMultimedia = new LILO_Packager.v2.Controls.DynamikPanelControl();
            pnlFileHandle = new LILO_Packager.v2.Controls.DynamikPanelControl();
            pnlUI = new LILO_Packager.v2.Controls.DynamikPanelControl();
            sPanel2.SuspendLayout();
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
            sPanel2.Location = new Point(0, 490);
            sPanel2.Margin = new Padding(4);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(994, 82);
            sPanel2.TabIndex = 20;
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
            bntOk.Location = new Point(854, 20);
            bntOk.Margin = new Padding(2);
            bntOk.Name = "bntOk";
            bntOk.Size = new Size(116, 48);
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
            bntCancel.Location = new Point(654, 20);
            bntCancel.Margin = new Padding(2);
            bntCancel.Name = "bntCancel";
            bntCancel.Size = new Size(180, 48);
            bntCancel.TabIndex = 15;
            bntCancel.Text = "Submit";
            bntCancel.Click += bntCancel_Click;
            // 
            // pnlBroadCasting
            // 
            pnlBroadCasting.Anchor = AnchorStyles.Top;
            pnlBroadCasting.Checked = true;
            pnlBroadCasting.EnabledState = false;
            pnlBroadCasting.Location = new Point(30, 30);
            pnlBroadCasting.Margin = new Padding(5);
            pnlBroadCasting.MiddleText = "Mainhost - Broadcasting";
            pnlBroadCasting.Name = "pnlBroadCasting";
            pnlBroadCasting.Size = new Size(298, 210);
            pnlBroadCasting.SubText = "(Required)";
            pnlBroadCasting.TabIndex = 21;
            pnlBroadCasting.Title = "Broadcast";
            // 
            // pnlLLSHandle
            // 
            pnlLLSHandle.Anchor = AnchorStyles.Top;
            pnlLLSHandle.Checked = true;
            pnlLLSHandle.EnabledState = true;
            pnlLLSHandle.Location = new Point(344, 30);
            pnlLLSHandle.Margin = new Padding(5);
            pnlLLSHandle.MiddleText = "En-and Decrypt LSS ";
            pnlLLSHandle.Name = "pnlLLSHandle";
            pnlLLSHandle.Size = new Size(312, 210);
            pnlLLSHandle.SubText = "lvl01";
            pnlLLSHandle.TabIndex = 21;
            pnlLLSHandle.Title = "LLS Handle";
            // 
            // pnlOSRes
            // 
            pnlOSRes.Anchor = AnchorStyles.Top;
            pnlOSRes.Checked = true;
            pnlOSRes.EnabledState = false;
            pnlOSRes.Location = new Point(670, 30);
            pnlOSRes.Margin = new Padding(5);
            pnlOSRes.MiddleText = "Provide functionalty";
            pnlOSRes.Name = "pnlOSRes";
            pnlOSRes.Size = new Size(306, 210);
            pnlOSRes.SubText = "(Required)";
            pnlOSRes.TabIndex = 21;
            pnlOSRes.Title = "OSRes";
            // 
            // pnlMultimedia
            // 
            pnlMultimedia.Anchor = AnchorStyles.Top;
            pnlMultimedia.Checked = true;
            pnlMultimedia.EnabledState = true;
            pnlMultimedia.Location = new Point(30, 264);
            pnlMultimedia.Margin = new Padding(5);
            pnlMultimedia.MiddleText = "Multimedia Handling";
            pnlMultimedia.Name = "pnlMultimedia";
            pnlMultimedia.Size = new Size(298, 200);
            pnlMultimedia.SubText = "lvl02";
            pnlMultimedia.TabIndex = 21;
            pnlMultimedia.Title = "Multimedia";
            // 
            // pnlFileHandle
            // 
            pnlFileHandle.Anchor = AnchorStyles.Top;
            pnlFileHandle.Checked = true;
            pnlFileHandle.EnabledState = true;
            pnlFileHandle.Location = new Point(350, 264);
            pnlFileHandle.Margin = new Padding(5);
            pnlFileHandle.MiddleText = "Providing a Library";
            pnlFileHandle.Name = "pnlFileHandle";
            pnlFileHandle.Size = new Size(298, 200);
            pnlFileHandle.SubText = "lvl02";
            pnlFileHandle.TabIndex = 21;
            pnlFileHandle.Title = "File Handler";
            // 
            // pnlUI
            // 
            pnlUI.Anchor = AnchorStyles.Top;
            pnlUI.Checked = true;
            pnlUI.EnabledState = true;
            pnlUI.Location = new Point(670, 264);
            pnlUI.Margin = new Padding(5);
            pnlUI.MiddleText = "Provide UI enhancement";
            pnlUI.Name = "pnlUI";
            pnlUI.Size = new Size(298, 200);
            pnlUI.SubText = "lvl01";
            pnlUI.TabIndex = 21;
            pnlUI.Title = "Ui Library";
            // 
            // uiDialogFeatures
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(994, 572);
            ControlBox = false;
            Controls.Add(sPanel2);
            Controls.Add(pnlUI);
            Controls.Add(pnlOSRes);
            Controls.Add(pnlFileHandle);
            Controls.Add(pnlLLSHandle);
            Controls.Add(pnlMultimedia);
            Controls.Add(pnlBroadCasting);
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(1016, 628);
            MinimizeBox = false;
            MinimumSize = new Size(1016, 628);
            Name = "uiDialogFeatures";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Select Features";
            Load += uiDialogFeatures_Load;
            sPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sipaa.Framework.SPanel sPanel2;
        private Guna.UI2.WinForms.Guna2Button bntOk;
        private Guna.UI2.WinForms.Guna2Button bntCancel;
        private LILO_Packager.v2.Controls.DynamikPanelControl pnlBroadCasting;
        private LILO_Packager.v2.Controls.DynamikPanelControl pnlLLSHandle;
        private LILO_Packager.v2.Controls.DynamikPanelControl pnlOSRes;
        private LILO_Packager.v2.Controls.DynamikPanelControl pnlMultimedia;
        private LILO_Packager.v2.Controls.DynamikPanelControl pnlFileHandle;
        private LILO_Packager.v2.Controls.DynamikPanelControl pnlUI;
    }
}