
using System.Drawing;
using System.Windows.Forms;

namespace DeezerPlugin.Controls
{
    partial class SearchItem
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            pnlPluginEntry = new Sipaa.Framework.SPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblVersion = new Label();
            lblProductName = new Label();
            lblPluginInfo = new Label();
            pnlInstalled = new Sipaa.Framework.SPanel();
            pnlIcon = new Sipaa.Framework.SPanel();
            bntDownload = new Guna.UI2.WinForms.Guna2Button();
            pnlPluginEntry.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPluginEntry
            // 
            pnlPluginEntry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPluginEntry.BackColor = Color.LightGray;
            pnlPluginEntry.BackgroundImageLayout = ImageLayout.Stretch;
            pnlPluginEntry.BorderColor = Color.Black;
            pnlPluginEntry.BorderRadius = 20;
            pnlPluginEntry.BorderSize = 0;
            pnlPluginEntry.Controls.Add(tableLayoutPanel2);
            pnlPluginEntry.Controls.Add(pnlInstalled);
            pnlPluginEntry.Controls.Add(pnlIcon);
            pnlPluginEntry.Controls.Add(bntDownload);
            pnlPluginEntry.ForeColor = Color.White;
            pnlPluginEntry.Location = new Point(0, 0);
            pnlPluginEntry.Margin = new Padding(4);
            pnlPluginEntry.Name = "pnlPluginEntry";
            pnlPluginEntry.Size = new Size(920, 120);
            pnlPluginEntry.TabIndex = 14;
            pnlPluginEntry.Paint += pnlPluginEntry_Paint;
            pnlPluginEntry.MouseEnter += pnlPluginEntry_MouseEnter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(lblPluginInfo, 0, 1);
            tableLayoutPanel2.Location = new Point(128, 24);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 46.5909081F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 53.4090919F));
            tableLayoutPanel2.Size = new Size(584, 88);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(lblVersion, 1, 0);
            tableLayoutPanel1.Controls.Add(lblProductName, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(578, 35);
            tableLayoutPanel1.TabIndex = 34;
            // 
            // lblVersion
            // 
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Dock = DockStyle.Fill;
            lblVersion.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblVersion.Location = new Point(194, 0);
            lblVersion.Margin = new Padding(2, 0, 2, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(382, 35);
            lblVersion.TabIndex = 11;
            lblVersion.Text = "Version";
            lblVersion.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Dock = DockStyle.Fill;
            lblProductName.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductName.ForeColor = Color.White;
            lblProductName.Location = new Point(2, 0);
            lblProductName.Margin = new Padding(2, 0, 2, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(188, 35);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "PackageName";
            lblProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPluginInfo
            // 
            lblPluginInfo.BackColor = Color.Transparent;
            lblPluginInfo.Dock = DockStyle.Fill;
            lblPluginInfo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPluginInfo.ForeColor = Color.White;
            lblPluginInfo.Location = new Point(4, 41);
            lblPluginInfo.Margin = new Padding(4, 0, 4, 0);
            lblPluginInfo.Name = "lblPluginInfo";
            lblPluginInfo.Size = new Size(576, 47);
            lblPluginInfo.TabIndex = 1;
            lblPluginInfo.Text = "Plugininformation";
            // 
            // pnlInstalled
            // 
            pnlInstalled.Anchor = AnchorStyles.Right;
            pnlInstalled.BackColor = Color.White;
            pnlInstalled.BackgroundImageLayout = ImageLayout.Zoom;
            pnlInstalled.BorderColor = Color.Black;
            pnlInstalled.BorderRadius = 20;
            pnlInstalled.BorderSize = 0;
            pnlInstalled.ForeColor = Color.White;
            pnlInstalled.Location = new Point(736, 32);
            pnlInstalled.Margin = new Padding(4);
            pnlInstalled.Name = "pnlInstalled";
            pnlInstalled.Size = new Size(160, 56);
            pnlInstalled.TabIndex = 13;
            pnlInstalled.Visible = false;
            // 
            // pnlIcon
            // 
            pnlIcon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlIcon.BackColor = Color.White;
            pnlIcon.BackgroundImageLayout = ImageLayout.Zoom;
            pnlIcon.BorderColor = Color.Black;
            pnlIcon.BorderRadius = 20;
            pnlIcon.BorderSize = 0;
            pnlIcon.ForeColor = Color.White;
            pnlIcon.Location = new Point(16, 16);
            pnlIcon.Margin = new Padding(4);
            pnlIcon.Name = "pnlIcon";
            pnlIcon.Size = new Size(96, 88);
            pnlIcon.TabIndex = 13;
            // 
            // bntDownload
            // 
            bntDownload.Anchor = AnchorStyles.Right;
            bntDownload.Animated = true;
            bntDownload.BackColor = Color.Transparent;
            bntDownload.BorderColor = Color.Gainsboro;
            bntDownload.BorderRadius = 20;
            bntDownload.BorderThickness = 2;
            bntDownload.DisabledState.BorderColor = Color.DarkGray;
            bntDownload.DisabledState.CustomBorderColor = Color.DarkGray;
            bntDownload.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntDownload.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntDownload.FillColor = Color.White;
            bntDownload.FocusedColor = Color.FromArgb(100, 170, 209);
            bntDownload.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            bntDownload.ForeColor = Color.DarkGray;
            bntDownload.Location = new Point(738, 33);
            bntDownload.Margin = new Padding(2);
            bntDownload.Name = "bntDownload";
            bntDownload.Size = new Size(160, 58);
            bntDownload.TabIndex = 14;
            bntDownload.Text = "Download";
            bntDownload.Click += bntDownload_Click;
            // 
            // DynamicPluginListItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlPluginEntry);
            Name = "DynamicPluginListItem";
            Size = new Size(921, 121);
            pnlPluginEntry.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Sipaa.Framework.SPanel pnlPluginEntry;
        public TableLayoutPanel tableLayoutPanel2;
        public TableLayoutPanel tableLayoutPanel1;
        public Label lblVersion;
        public Label lblProductName;
        public Label lblPluginInfo;
        public Sipaa.Framework.SPanel pnlIcon;
        public Guna.UI2.WinForms.Guna2Button bntDownload;
        public Sipaa.Framework.SPanel pnlInstalled;
    }
}
