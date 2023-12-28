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
        lblVersion = new Label();
        lblText = new Label();
        sPanel2 = new Sipaa.Framework.SPanel();
        guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
        label13 = new Label();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        label2 = new Label();
        label1 = new Label();
        sPanel3 = new Sipaa.Framework.SPanel();
        guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
        label3 = new Label();
        label4 = new Label();
        sPanel4 = new Sipaa.Framework.SPanel();
        guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
        label5 = new Label();
        label6 = new Label();
        pnlFiles = new Guna.UI2.WinForms.Guna2Panel();
        progress = new Guna.UI2.WinForms.Guna2ProgressBar();
        sPanel11 = new Sipaa.Framework.SPanel();
        label7 = new Label();
        guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
        lblCloud = new Label();
        lblNetwork = new Label();
        panel1 = new Panel();
        label8 = new Label();
        label9 = new Label();
        label10 = new Label();
        guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
        guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
        label11 = new Label();
        guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
        label12 = new Label();
        label14 = new Label();
        label15 = new Label();
        label16 = new Label();
        sPanel2.SuspendLayout();
        guna2Panel4.SuspendLayout();
        sPanel3.SuspendLayout();
        sPanel4.SuspendLayout();
        pnlFiles.SuspendLayout();
        guna2Panel1.SuspendLayout();
        guna2Panel2.SuspendLayout();
        guna2Panel3.SuspendLayout();
        SuspendLayout();
        // 
        // lblVersion
        // 
        lblVersion.BackColor = Color.Transparent;
        lblVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblVersion.ForeColor = Color.Silver;
        lblVersion.Location = new Point(144, 88);
        lblVersion.Margin = new Padding(4, 0, 4, 0);
        lblVersion.Name = "lblVersion";
        lblVersion.Size = new Size(128, 24);
        lblVersion.TabIndex = 1;
        lblVersion.Text = "n/a";
        lblVersion.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblText
        // 
        lblText.BackColor = Color.Transparent;
        lblText.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblText.ForeColor = Color.DimGray;
        lblText.Location = new Point(144, 56);
        lblText.Margin = new Padding(4, 0, 4, 0);
        lblText.Name = "lblText";
        lblText.Size = new Size(256, 32);
        lblText.TabIndex = 1;
        lblText.Text = "Encryption Models";
        lblText.TextAlign = ContentAlignment.MiddleLeft;
        lblText.Click += lblText_Click;
        // 
        // sPanel2
        // 
        sPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        sPanel2.BackColor = Color.WhiteSmoke;
        sPanel2.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel2.BorderColor = Color.Gainsboro;
        sPanel2.BorderRadius = 20;
        sPanel2.BorderSize = 2;
        sPanel2.Controls.Add(guna2Panel4);
        sPanel2.Controls.Add(guna2Button1);
        sPanel2.Controls.Add(label2);
        sPanel2.Controls.Add(label1);
        sPanel2.ForeColor = Color.White;
        sPanel2.Location = new Point(24, 24);
        sPanel2.Margin = new Padding(4);
        sPanel2.Name = "sPanel2";
        sPanel2.Size = new Size(552, 88);
        sPanel2.TabIndex = 12;
        // 
        // guna2Panel4
        // 
        guna2Panel4.BackColor = Color.Transparent;
        guna2Panel4.BorderColor = Color.Gainsboro;
        guna2Panel4.BorderRadius = 15;
        guna2Panel4.BorderThickness = 2;
        guna2Panel4.Controls.Add(label13);
        guna2Panel4.FillColor = Color.ForestGreen;
        guna2Panel4.Location = new Point(192, 16);
        guna2Panel4.Margin = new Padding(2);
        guna2Panel4.Name = "guna2Panel4";
        guna2Panel4.Size = new Size(96, 32);
        guna2Panel4.TabIndex = 44;
        // 
        // label13
        // 
        label13.BackColor = Color.Transparent;
        label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label13.ForeColor = Color.White;
        label13.Location = new Point(0, 0);
        label13.Margin = new Padding(4, 0, 4, 0);
        label13.Name = "label13";
        label13.Size = new Size(96, 32);
        label13.TabIndex = 44;
        label13.Text = "Selected";
        label13.TextAlign = ContentAlignment.MiddleCenter;
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
        guna2Button1.FillColor = Color.White;
        guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        guna2Button1.ForeColor = Color.SlateGray;
        guna2Button1.Location = new Point(376, 16);
        guna2Button1.Margin = new Padding(2);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.Size = new Size(160, 58);
        guna2Button1.TabIndex = 14;
        guna2Button1.Text = "Deinstall";
        guna2Button1.Click += guna2Button1_Click;
        // 
        // label2
        // 
        label2.BackColor = Color.Transparent;
        label2.Font = new Font("Segoe UI", 8F);
        label2.ForeColor = Color.DarkGray;
        label2.Location = new Point(32, 48);
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
        label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        label1.ForeColor = Color.Gray;
        label1.Location = new Point(0, 0);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(216, 64);
        label1.TabIndex = 1;
        label1.Text = "LFS-Encryption";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // sPanel3
        // 
        sPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        sPanel3.BackColor = Color.WhiteSmoke;
        sPanel3.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel3.BorderColor = Color.Gainsboro;
        sPanel3.BorderRadius = 20;
        sPanel3.BorderSize = 2;
        sPanel3.Controls.Add(guna2Button2);
        sPanel3.Controls.Add(label3);
        sPanel3.Controls.Add(label4);
        sPanel3.ForeColor = Color.White;
        sPanel3.Location = new Point(24, 32);
        sPanel3.Margin = new Padding(4);
        sPanel3.Name = "sPanel3";
        sPanel3.Size = new Size(552, 88);
        sPanel3.TabIndex = 12;
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
        guna2Button2.FillColor = Color.White;
        guna2Button2.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        guna2Button2.ForeColor = Color.SlateGray;
        guna2Button2.Location = new Point(376, 16);
        guna2Button2.Margin = new Padding(2);
        guna2Button2.Name = "guna2Button2";
        guna2Button2.Size = new Size(160, 58);
        guna2Button2.TabIndex = 14;
        guna2Button2.Text = "Install";
        guna2Button2.Click += guna2Button2_Click;
        // 
        // label3
        // 
        label3.BackColor = Color.Transparent;
        label3.Font = new Font("Segoe UI", 8F);
        label3.ForeColor = Color.DarkGray;
        label3.Location = new Point(32, 48);
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
        label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        label4.ForeColor = Color.Gray;
        label4.Location = new Point(0, 0);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(216, 64);
        label4.TabIndex = 1;
        label4.Text = "AIZI-Encryption";
        label4.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // sPanel4
        // 
        sPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        sPanel4.BackColor = Color.WhiteSmoke;
        sPanel4.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel4.BorderColor = Color.Gainsboro;
        sPanel4.BorderRadius = 20;
        sPanel4.BorderSize = 2;
        sPanel4.Controls.Add(guna2Button3);
        sPanel4.Controls.Add(label5);
        sPanel4.Controls.Add(label6);
        sPanel4.ForeColor = Color.White;
        sPanel4.Location = new Point(24, 136);
        sPanel4.Margin = new Padding(4);
        sPanel4.Name = "sPanel4";
        sPanel4.Size = new Size(552, 88);
        sPanel4.TabIndex = 12;
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
        guna2Button3.FillColor = Color.White;
        guna2Button3.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        guna2Button3.ForeColor = Color.SlateGray;
        guna2Button3.Location = new Point(376, 16);
        guna2Button3.Margin = new Padding(2);
        guna2Button3.Name = "guna2Button3";
        guna2Button3.Size = new Size(160, 58);
        guna2Button3.TabIndex = 14;
        guna2Button3.Text = "Install";
        guna2Button3.Click += guna2Button2_Click;
        // 
        // label5
        // 
        label5.BackColor = Color.Transparent;
        label5.Font = new Font("Segoe UI", 8F);
        label5.ForeColor = Color.DarkGray;
        label5.Location = new Point(32, 48);
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
        label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        label6.ForeColor = Color.Gray;
        label6.Location = new Point(24, 0);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(192, 64);
        label6.TabIndex = 1;
        label6.Text = "Cloud-Encryption";
        label6.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnlFiles
        // 
        pnlFiles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlFiles.BorderColor = Color.Gainsboro;
        pnlFiles.BorderRadius = 15;
        pnlFiles.BorderThickness = 2;
        pnlFiles.Controls.Add(progress);
        pnlFiles.Controls.Add(label16);
        pnlFiles.Controls.Add(label15);
        pnlFiles.FillColor = Color.White;
        pnlFiles.Location = new Point(32, 344);
        pnlFiles.Margin = new Padding(2);
        pnlFiles.Name = "pnlFiles";
        pnlFiles.Size = new Size(304, 176);
        pnlFiles.TabIndex = 16;
        // 
        // progress
        // 
        progress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        progress.BackColor = Color.Transparent;
        progress.BorderColor = Color.Gainsboro;
        progress.BorderRadius = 10;
        progress.BorderThickness = 2;
        progress.FillColor = Color.White;
        progress.Location = new Point(24, 112);
        progress.Name = "progress";
        progress.ProgressColor = Color.DeepSkyBlue;
        progress.ProgressColor2 = Color.Navy;
        progress.ShowText = true;
        progress.Size = new Size(256, 40);
        progress.TabIndex = 17;
        progress.Text = "guna2ProgressBar1";
        progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
        progress.Visible = false;
        // 
        // sPanel11
        // 
        sPanel11.BackColor = Color.White;
        sPanel11.BackgroundImage = (Image)resources.GetObject("sPanel11.BackgroundImage");
        sPanel11.BackgroundImageLayout = ImageLayout.Zoom;
        sPanel11.BorderColor = Color.Gainsboro;
        sPanel11.BorderRadius = 20;
        sPanel11.BorderSize = 0;
        sPanel11.ForeColor = Color.White;
        sPanel11.Location = new Point(32, 40);
        sPanel11.Margin = new Padding(4);
        sPanel11.Name = "sPanel11";
        sPanel11.Size = new Size(96, 88);
        sPanel11.TabIndex = 43;
        // 
        // label7
        // 
        label7.BackColor = Color.Transparent;
        label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        label7.ForeColor = SystemColors.ControlDark;
        label7.Location = new Point(48, 152);
        label7.Margin = new Padding(4, 0, 4, 0);
        label7.Name = "label7";
        label7.Size = new Size(136, 40);
        label7.TabIndex = 45;
        label7.Text = "    Checklist";
        label7.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Panel1
        // 
        guna2Panel1.BackColor = SystemColors.HighlightText;
        guna2Panel1.BorderColor = Color.Gainsboro;
        guna2Panel1.BorderRadius = 15;
        guna2Panel1.BorderThickness = 2;
        guna2Panel1.Controls.Add(lblCloud);
        guna2Panel1.Controls.Add(lblNetwork);
        guna2Panel1.Controls.Add(panel1);
        guna2Panel1.Controls.Add(label8);
        guna2Panel1.Controls.Add(label9);
        guna2Panel1.FillColor = Color.White;
        guna2Panel1.Location = new Point(32, 168);
        guna2Panel1.Margin = new Padding(2);
        guna2Panel1.Name = "guna2Panel1";
        guna2Panel1.Size = new Size(304, 144);
        guna2Panel1.TabIndex = 44;
        // 
        // lblCloud
        // 
        lblCloud.BackColor = Color.Transparent;
        lblCloud.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblCloud.ForeColor = Color.DimGray;
        lblCloud.Location = new Point(160, 88);
        lblCloud.Margin = new Padding(4, 0, 4, 0);
        lblCloud.Name = "lblCloud";
        lblCloud.Size = new Size(112, 30);
        lblCloud.TabIndex = 44;
        lblCloud.Text = "n/a";
        lblCloud.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblNetwork
        // 
        lblNetwork.BackColor = Color.Transparent;
        lblNetwork.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblNetwork.ForeColor = Color.DimGray;
        lblNetwork.Location = new Point(160, 40);
        lblNetwork.Margin = new Padding(4, 0, 4, 0);
        lblNetwork.Name = "lblNetwork";
        lblNetwork.Size = new Size(112, 30);
        lblNetwork.TabIndex = 44;
        lblNetwork.Text = "n/a";
        lblNetwork.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // panel1
        // 
        panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
        panel1.BackgroundImageLayout = ImageLayout.Stretch;
        panel1.Location = new Point(24, 72);
        panel1.Margin = new Padding(2);
        panel1.Name = "panel1";
        panel1.Size = new Size(248, 16);
        panel1.TabIndex = 36;
        // 
        // label8
        // 
        label8.BackColor = Color.Transparent;
        label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label8.ForeColor = Color.Silver;
        label8.Location = new Point(40, 88);
        label8.Margin = new Padding(4, 0, 4, 0);
        label8.Name = "label8";
        label8.Size = new Size(136, 30);
        label8.TabIndex = 44;
        label8.Text = "Cloud";
        label8.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label9
        // 
        label9.BackColor = Color.Transparent;
        label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label9.ForeColor = Color.Silver;
        label9.Location = new Point(40, 40);
        label9.Margin = new Padding(4, 0, 4, 0);
        label9.Name = "label9";
        label9.Size = new Size(136, 30);
        label9.TabIndex = 44;
        label9.Text = "Internet\r\n";
        label9.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label10
        // 
        label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        label10.BackColor = Color.Transparent;
        label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        label10.ForeColor = SystemColors.ControlDark;
        label10.Location = new Point(56, 320);
        label10.Margin = new Padding(4, 0, 4, 0);
        label10.Name = "label10";
        label10.Size = new Size(128, 40);
        label10.TabIndex = 45;
        label10.Text = "    Prozess";
        label10.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Button4
        // 
        guna2Button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2Button4.Animated = true;
        guna2Button4.BackColor = Color.Transparent;
        guna2Button4.BorderColor = Color.Gainsboro;
        guna2Button4.BorderRadius = 15;
        guna2Button4.BorderThickness = 2;
        guna2Button4.DisabledState.BorderColor = Color.DarkGray;
        guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button4.FillColor = Color.White;
        guna2Button4.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        guna2Button4.ForeColor = Color.SlateGray;
        guna2Button4.ImageSize = new Size(25, 25);
        guna2Button4.Location = new Point(864, 56);
        guna2Button4.Margin = new Padding(2);
        guna2Button4.Name = "guna2Button4";
        guna2Button4.Size = new Size(104, 50);
        guna2Button4.TabIndex = 14;
        guna2Button4.Text = "Sync";
        guna2Button4.Click += Sync_Click;
        // 
        // guna2Panel2
        // 
        guna2Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        guna2Panel2.BorderColor = Color.Gainsboro;
        guna2Panel2.BorderRadius = 15;
        guna2Panel2.BorderThickness = 2;
        guna2Panel2.Controls.Add(sPanel3);
        guna2Panel2.Controls.Add(sPanel4);
        guna2Panel2.FillColor = Color.White;
        guna2Panel2.Location = new Point(384, 336);
        guna2Panel2.Margin = new Padding(2);
        guna2Panel2.Name = "guna2Panel2";
        guna2Panel2.Size = new Size(600, 248);
        guna2Panel2.TabIndex = 16;
        // 
        // label11
        // 
        label11.BackColor = Color.Transparent;
        label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        label11.ForeColor = SystemColors.ControlDark;
        label11.Location = new Point(408, 320);
        label11.Margin = new Padding(4, 0, 4, 0);
        label11.Name = "label11";
        label11.Size = new Size(144, 40);
        label11.TabIndex = 45;
        label11.Text = "    Availlabel";
        label11.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Panel3
        // 
        guna2Panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        guna2Panel3.BorderColor = Color.Gainsboro;
        guna2Panel3.BorderRadius = 15;
        guna2Panel3.BorderThickness = 2;
        guna2Panel3.Controls.Add(sPanel2);
        guna2Panel3.FillColor = Color.White;
        guna2Panel3.Location = new Point(384, 160);
        guna2Panel3.Margin = new Padding(2);
        guna2Panel3.Name = "guna2Panel3";
        guna2Panel3.Size = new Size(600, 144);
        guna2Panel3.TabIndex = 16;
        // 
        // label12
        // 
        label12.BackColor = Color.Transparent;
        label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        label12.ForeColor = SystemColors.ControlDark;
        label12.Location = new Point(416, 136);
        label12.Margin = new Padding(4, 0, 4, 0);
        label12.Name = "label12";
        label12.Size = new Size(136, 40);
        label12.TabIndex = 45;
        label12.Text = "    Installed";
        label12.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label14
        // 
        label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label14.BackColor = Color.Transparent;
        label14.ForeColor = Color.Gray;
        label14.Location = new Point(760, 64);
        label14.Name = "label14";
        label14.Size = new Size(93, 33);
        label14.TabIndex = 46;
        label14.Text = "All Synced";
        label14.TextAlign = ContentAlignment.MiddleLeft;
        label14.Visible = false;
        // 
        // label15
        // 
        label15.BackColor = Color.Transparent;
        label15.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        label15.ForeColor = Color.Gray;
        label15.Location = new Point(32, 32);
        label15.Margin = new Padding(4, 0, 4, 0);
        label15.Name = "label15";
        label15.Size = new Size(184, 40);
        label15.TabIndex = 1;
        label15.Text = "Model";
        label15.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label16
        // 
        label16.BackColor = Color.Transparent;
        label16.Font = new Font("Segoe UI", 8F);
        label16.ForeColor = Color.DarkGray;
        label16.Location = new Point(32, 80);
        label16.Margin = new Padding(4, 0, 4, 0);
        label16.Name = "label16";
        label16.Size = new Size(232, 32);
        label16.TabIndex = 1;
        label16.Text = "details\r\n\r\n";
        label16.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PluginInterface
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1008, 796);
        Controls.Add(label14);
        Controls.Add(label10);
        Controls.Add(guna2Button4);
        Controls.Add(label12);
        Controls.Add(label11);
        Controls.Add(label7);
        Controls.Add(guna2Panel1);
        Controls.Add(lblText);
        Controls.Add(sPanel11);
        Controls.Add(lblVersion);
        Controls.Add(guna2Panel3);
        Controls.Add(guna2Panel2);
        Controls.Add(pnlFiles);
        MinimumSize = new Size(300, 500);
        Name = "PluginInterface";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "Plugin: Encryption Models";
        Load += uiSettings_Load;
        sPanel2.ResumeLayout(false);
        guna2Panel4.ResumeLayout(false);
        sPanel3.ResumeLayout(false);
        sPanel4.ResumeLayout(false);
        pnlFiles.ResumeLayout(false);
        guna2Panel1.ResumeLayout(false);
        guna2Panel2.ResumeLayout(false);
        guna2Panel3.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Label lblText;
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
    private Label lblVersion;
    private Sipaa.Framework.SPanel sPanel11;
    private Label label7;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    private Label lblCloud;
    private Label lblNetwork;
    private Panel panel1;
    private Label label8;
    private Label label9;
    private Label label10;
    private Guna.UI2.WinForms.Guna2Button guna2Button4;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    private Label label11;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
    private Label label12;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
    private Label label13;
    private Label label14;
    private Label label16;
    private Label label15;
}