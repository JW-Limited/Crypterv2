using System.Drawing;
using System.Windows.Forms;

namespace EncryptionLibary.Core;

partial class PluginInterface
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginInterface));
        sPanel1 = new Sipaa.Framework.SPanel();
        bntVersion = new Guna.UI2.WinForms.Guna2Button();
        lblText = new Label();
        windows11Theme1 = new Telerik.WinControls.Themes.Windows11Theme();
        sPanel2 = new Sipaa.Framework.SPanel();
        label2 = new Label();
        label1 = new Label();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        sPanel3 = new Sipaa.Framework.SPanel();
        label3 = new Label();
        label4 = new Label();
        guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
        sPanel4 = new Sipaa.Framework.SPanel();
        label5 = new Label();
        label6 = new Label();
        guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
        pnlFiles = new Guna.UI2.WinForms.Guna2Panel();
        progress = new Guna.UI2.WinForms.Guna2ProgressBar();
        sPanel1.SuspendLayout();
        sPanel2.SuspendLayout();
        sPanel3.SuspendLayout();
        sPanel4.SuspendLayout();
        pnlFiles.SuspendLayout();
        SuspendLayout();
        // 
        // sPanel1
        // 
        sPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        sPanel1.BackColor = Color.Black;
        sPanel1.BackgroundImage = (Image)resources.GetObject("sPanel1.BackgroundImage");
        sPanel1.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel1.BorderColor = Color.Black;
        sPanel1.BorderRadius = 20;
        sPanel1.BorderSize = 0;
        sPanel1.Controls.Add(bntVersion);
        sPanel1.Controls.Add(lblText);
        sPanel1.ForeColor = Color.White;
        sPanel1.Location = new Point(24, 32);
        sPanel1.Margin = new Padding(4);
        sPanel1.Name = "sPanel1";
        sPanel1.Size = new Size(584, 88);
        sPanel1.TabIndex = 12;
        // 
        // bntVersion
        // 
        bntVersion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        bntVersion.Animated = true;
        bntVersion.BackColor = Color.Transparent;
        bntVersion.BorderColor = Color.Gainsboro;
        bntVersion.BorderRadius = 20;
        bntVersion.BorderThickness = 2;
        bntVersion.DisabledState.BorderColor = Color.DarkGray;
        bntVersion.DisabledState.CustomBorderColor = Color.DarkGray;
        bntVersion.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntVersion.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntVersion.FillColor = Color.Transparent;
        bntVersion.FocusedColor = Color.FromArgb(100, 170, 209);
        bntVersion.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        bntVersion.ForeColor = Color.White;
        bntVersion.Location = new Point(408, 16);
        bntVersion.Margin = new Padding(2);
        bntVersion.Name = "bntVersion";
        bntVersion.Size = new Size(160, 58);
        bntVersion.TabIndex = 14;
        bntVersion.Text = "Version";
        // 
        // lblText
        // 
        lblText.BackColor = Color.Transparent;
        lblText.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        lblText.ForeColor = Color.White;
        lblText.Location = new Point(24, 0);
        lblText.Margin = new Padding(4, 0, 4, 0);
        lblText.Name = "lblText";
        lblText.Size = new Size(280, 88);
        lblText.TabIndex = 1;
        lblText.Text = "Encryption Models";
        lblText.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // sPanel2
        // 
        sPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        sPanel2.BackColor = Color.Black;
        sPanel2.BackgroundImage = Properties.Resources.Royal_Blue;
        sPanel2.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel2.BorderColor = Color.Black;
        sPanel2.BorderRadius = 20;
        sPanel2.BorderSize = 0;
        sPanel2.Controls.Add(label2);
        sPanel2.Controls.Add(label1);
        sPanel2.Controls.Add(guna2Button1);
        sPanel2.ForeColor = Color.White;
        sPanel2.Location = new Point(24, 144);
        sPanel2.Margin = new Padding(4);
        sPanel2.Name = "sPanel2";
        sPanel2.Size = new Size(584, 88);
        sPanel2.TabIndex = 12;
        // 
        // label2
        // 
        label2.BackColor = Color.Transparent;
        label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
        label2.ForeColor = Color.White;
        label2.Location = new Point(40, 48);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(312, 32);
        label2.TabIndex = 1;
        label2.Text = "The Basic model that comes pre-installed.";
        label2.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label1
        // 
        label1.BackColor = Color.Transparent;
        label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        label1.ForeColor = Color.White;
        label1.Location = new Point(8, 0);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(216, 64);
        label1.TabIndex = 1;
        label1.Text = "LFS-Encryption";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // guna2Button1
        // 
        guna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2Button1.Animated = true;
        guna2Button1.BackColor = Color.Transparent;
        guna2Button1.BorderColor = Color.Gainsboro;
        guna2Button1.BorderRadius = 20;
        guna2Button1.BorderThickness = 2;
        guna2Button1.DisabledState.BorderColor = Color.DarkGray;
        guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button1.FillColor = Color.Transparent;
        guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button1.ForeColor = Color.White;
        guna2Button1.Location = new Point(408, 16);
        guna2Button1.Margin = new Padding(2);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.Size = new Size(160, 58);
        guna2Button1.TabIndex = 14;
        guna2Button1.Text = "Deinstall";
        guna2Button1.Click += guna2Button1_Click;
        // 
        // sPanel3
        // 
        sPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        sPanel3.BackColor = Color.Black;
        sPanel3.BackgroundImage = Properties.Resources.Royal_Blue;
        sPanel3.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel3.BorderColor = Color.Black;
        sPanel3.BorderRadius = 20;
        sPanel3.BorderSize = 0;
        sPanel3.Controls.Add(label3);
        sPanel3.Controls.Add(label4);
        sPanel3.Controls.Add(guna2Button2);
        sPanel3.ForeColor = Color.White;
        sPanel3.Location = new Point(24, 248);
        sPanel3.Margin = new Padding(4);
        sPanel3.Name = "sPanel3";
        sPanel3.Size = new Size(584, 88);
        sPanel3.TabIndex = 12;
        // 
        // label3
        // 
        label3.BackColor = Color.Transparent;
        label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
        label3.ForeColor = Color.White;
        label3.Location = new Point(40, 48);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(312, 32);
        label3.TabIndex = 1;
        label3.Text = "A model for fast encryption for big files\r\n";
        label3.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label4
        // 
        label4.BackColor = Color.Transparent;
        label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        label4.ForeColor = Color.White;
        label4.Location = new Point(8, 0);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(216, 64);
        label4.TabIndex = 1;
        label4.Text = "AIZI-Encryption";
        label4.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // guna2Button2
        // 
        guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2Button2.Animated = true;
        guna2Button2.BackColor = Color.Transparent;
        guna2Button2.BorderColor = Color.Gainsboro;
        guna2Button2.BorderRadius = 20;
        guna2Button2.BorderThickness = 2;
        guna2Button2.DisabledState.BorderColor = Color.DarkGray;
        guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button2.FillColor = Color.Transparent;
        guna2Button2.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button2.ForeColor = Color.White;
        guna2Button2.Location = new Point(408, 16);
        guna2Button2.Margin = new Padding(2);
        guna2Button2.Name = "guna2Button2";
        guna2Button2.Size = new Size(160, 58);
        guna2Button2.TabIndex = 14;
        guna2Button2.Text = "Install";
        // 
        // sPanel4
        // 
        sPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        sPanel4.BackColor = Color.Black;
        sPanel4.BackgroundImage = Properties.Resources.Royal_Blue;
        sPanel4.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel4.BorderColor = Color.Black;
        sPanel4.BorderRadius = 20;
        sPanel4.BorderSize = 0;
        sPanel4.Controls.Add(label5);
        sPanel4.Controls.Add(label6);
        sPanel4.Controls.Add(guna2Button3);
        sPanel4.ForeColor = Color.White;
        sPanel4.Location = new Point(24, 352);
        sPanel4.Margin = new Padding(4);
        sPanel4.Name = "sPanel4";
        sPanel4.Size = new Size(584, 88);
        sPanel4.TabIndex = 12;
        // 
        // label5
        // 
        label5.BackColor = Color.Transparent;
        label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
        label5.ForeColor = Color.White;
        label5.Location = new Point(40, 48);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(328, 32);
        label5.TabIndex = 1;
        label5.Text = "Loads it up in the cloud and do it there\r\n";
        label5.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label6
        // 
        label6.BackColor = Color.Transparent;
        label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        label6.ForeColor = Color.White;
        label6.Location = new Point(32, 0);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(192, 64);
        label6.TabIndex = 1;
        label6.Text = "Cloud-Encryption";
        label6.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // guna2Button3
        // 
        guna2Button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2Button3.Animated = true;
        guna2Button3.BackColor = Color.Transparent;
        guna2Button3.BorderColor = Color.Gainsboro;
        guna2Button3.BorderRadius = 20;
        guna2Button3.BorderThickness = 2;
        guna2Button3.DisabledState.BorderColor = Color.DarkGray;
        guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button3.FillColor = Color.Transparent;
        guna2Button3.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button3.ForeColor = Color.White;
        guna2Button3.Location = new Point(408, 16);
        guna2Button3.Margin = new Padding(2);
        guna2Button3.Name = "guna2Button3";
        guna2Button3.Size = new Size(160, 58);
        guna2Button3.TabIndex = 14;
        guna2Button3.Text = "Install";
        // 
        // pnlFiles
        // 
        pnlFiles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlFiles.BorderColor = SystemColors.ActiveBorder;
        pnlFiles.BorderRadius = 15;
        pnlFiles.BorderThickness = 2;
        pnlFiles.Controls.Add(progress);
        pnlFiles.FillColor = Color.Gainsboro;
        pnlFiles.Location = new Point(24, 816);
        pnlFiles.Margin = new Padding(2);
        pnlFiles.Name = "pnlFiles";
        pnlFiles.Size = new Size(584, 104);
        pnlFiles.TabIndex = 16;
        // 
        // progress
        // 
        progress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        progress.BackColor = Color.Transparent;
        progress.BorderColor = Color.DarkGray;
        progress.BorderRadius = 20;
        progress.BorderThickness = 2;
        progress.FillColor = Color.White;
        progress.Location = new Point(24, 24);
        progress.Name = "progress";
        progress.ProgressColor = Color.DeepSkyBlue;
        progress.ProgressColor2 = Color.Navy;
        progress.ShowText = true;
        progress.Size = new Size(536, 56);
        progress.TabIndex = 17;
        progress.Text = "guna2ProgressBar1";
        progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
        progress.Visible = false;
        // 
        // PluginInterface
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(628, 944);
        Controls.Add(pnlFiles);
        Controls.Add(sPanel4);
        Controls.Add(sPanel3);
        Controls.Add(sPanel2);
        Controls.Add(sPanel1);
        MinimumSize = new Size(300, 500);
        Name = "PluginInterface";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "Plugin: Encryption Models";
        Load += uiSettings_Load;
        sPanel1.ResumeLayout(false);
        sPanel2.ResumeLayout(false);
        sPanel3.ResumeLayout(false);
        sPanel4.ResumeLayout(false);
        pnlFiles.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Sipaa.Framework.SPanel sPanel1;
    private Guna.UI2.WinForms.Guna2Button bntVersion;
    private Label lblText;
    private Telerik.WinControls.Themes.Windows11Theme windows11Theme1;
    private Sipaa.Framework.SPanel sPanel2;
    private Label label2;
    private Label label1;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
    private Sipaa.Framework.SPanel sPanel3;
    private Label label3;
    private Label label4;
    private Guna.UI2.WinForms.Guna2Button guna2Button2;
    private Sipaa.Framework.SPanel sPanel4;
    private Label label5;
    private Label label6;
    private Guna.UI2.WinForms.Guna2Button guna2Button3;
    private Guna.UI2.WinForms.Guna2Panel pnlFiles;
    private Guna.UI2.WinForms.Guna2ProgressBar progress;
}