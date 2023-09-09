using System.Drawing;
using System.Windows.Forms;

namespace TextPreviewLibrary.Core;

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
        sPanel1 = new Sipaa.Framework.SPanel();
        bntMenu = new Guna.UI2.WinForms.Guna2Button();
        lblTip = new Label();
        lblVersion = new Label();
        guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
        bntDesign = new Guna.UI2.WinForms.Guna2Button();
        mainTextBox = new RichTextBox();
        sPanel2 = new Sipaa.Framework.SPanel();
        lblWordCounts = new Label();
        lblErrors = new Label();
        lblLanguage = new Label();
        pnlMenu = new Sipaa.Framework.SPanel();
        guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
        label6 = new Label();
        label5 = new Label();
        guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        sPanel3 = new Sipaa.Framework.SPanel();
        pnlDesing = new Sipaa.Framework.SPanel();
        sPanel1.SuspendLayout();
        sPanel2.SuspendLayout();
        pnlMenu.SuspendLayout();
        sPanel3.SuspendLayout();
        SuspendLayout();
        // 
        // sPanel1
        // 
        sPanel1.BackColor = Color.White;
        sPanel1.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel1.BorderColor = Color.Black;
        sPanel1.BorderRadius = 0;
        sPanel1.BorderSize = 0;
        sPanel1.Controls.Add(bntMenu);
        sPanel1.Controls.Add(lblTip);
        sPanel1.Controls.Add(lblVersion);
        sPanel1.Controls.Add(guna2Button7);
        sPanel1.Controls.Add(bntDesign);
        sPanel1.Dock = DockStyle.Top;
        sPanel1.ForeColor = Color.White;
        sPanel1.Location = new Point(0, 0);
        sPanel1.Margin = new Padding(4);
        sPanel1.Name = "sPanel1";
        sPanel1.Size = new Size(1604, 88);
        sPanel1.TabIndex = 12;
        // 
        // bntMenu
        // 
        bntMenu.Animated = true;
        bntMenu.BackColor = Color.Transparent;
        bntMenu.BackgroundImageLayout = ImageLayout.Zoom;
        bntMenu.BorderColor = Color.Gainsboro;
        bntMenu.BorderRadius = 10;
        bntMenu.DisabledState.BorderColor = Color.DarkGray;
        bntMenu.DisabledState.CustomBorderColor = Color.DarkGray;
        bntMenu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntMenu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntMenu.FillColor = Color.Transparent;
        bntMenu.FocusedColor = Color.FromArgb(100, 170, 209);
        bntMenu.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        bntMenu.ForeColor = Color.White;
        bntMenu.Image = Properties.Resources.icons8_menu_240;
        bntMenu.ImageSize = new Size(35, 35);
        bntMenu.Location = new Point(16, 16);
        bntMenu.Margin = new Padding(2);
        bntMenu.Name = "bntMenu";
        bntMenu.Size = new Size(64, 58);
        bntMenu.TabIndex = 16;
        bntMenu.Click += bntPlugin_Click;
        // 
        // lblTip
        // 
        lblTip.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        lblTip.BackColor = Color.Transparent;
        lblTip.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
        lblTip.ForeColor = Color.Gray;
        lblTip.Location = new Point(520, 16);
        lblTip.Margin = new Padding(4, 0, 4, 0);
        lblTip.Name = "lblTip";
        lblTip.Size = new Size(936, 56);
        lblTip.TabIndex = 1;
        lblTip.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblVersion
        // 
        lblVersion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblVersion.BackColor = Color.Transparent;
        lblVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblVersion.ForeColor = Color.Black;
        lblVersion.Location = new Point(1464, 16);
        lblVersion.Margin = new Padding(4, 0, 4, 0);
        lblVersion.Name = "lblVersion";
        lblVersion.Size = new Size(129, 56);
        lblVersion.TabIndex = 1;
        lblVersion.Text = "n/a";
        lblVersion.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Button7
        // 
        guna2Button7.Animated = true;
        guna2Button7.BackColor = Color.Transparent;
        guna2Button7.BackgroundImageLayout = ImageLayout.Zoom;
        guna2Button7.BorderColor = Color.Gainsboro;
        guna2Button7.BorderRadius = 10;
        guna2Button7.DisabledState.BorderColor = Color.DarkGray;
        guna2Button7.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button7.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button7.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button7.FillColor = Color.Transparent;
        guna2Button7.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button7.ForeColor = Color.Black;
        guna2Button7.Image = Properties.Resources.icons8_foxit_reader_240;
        guna2Button7.ImageAlign = HorizontalAlignment.Left;
        guna2Button7.ImageSize = new Size(35, 35);
        guna2Button7.Location = new Point(296, 16);
        guna2Button7.Margin = new Padding(2);
        guna2Button7.Name = "guna2Button7";
        guna2Button7.Size = new Size(208, 58);
        guna2Button7.TabIndex = 16;
        guna2Button7.Text = "Formatting";
        guna2Button7.TextAlign = HorizontalAlignment.Left;
        guna2Button7.Click += newFile_Click;
        // 
        // bntDesign
        // 
        bntDesign.Animated = true;
        bntDesign.BackColor = Color.Transparent;
        bntDesign.BackgroundImageLayout = ImageLayout.Zoom;
        bntDesign.BorderColor = Color.Gainsboro;
        bntDesign.BorderRadius = 10;
        bntDesign.DisabledState.BorderColor = Color.DarkGray;
        bntDesign.DisabledState.CustomBorderColor = Color.DarkGray;
        bntDesign.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntDesign.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntDesign.FillColor = Color.Transparent;
        bntDesign.FocusedColor = Color.FromArgb(100, 170, 209);
        bntDesign.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        bntDesign.ForeColor = Color.Black;
        bntDesign.Image = Properties.Resources.icons8_windows_10_personalization_96;
        bntDesign.ImageAlign = HorizontalAlignment.Left;
        bntDesign.ImageSize = new Size(35, 35);
        bntDesign.Location = new Point(96, 16);
        bntDesign.Margin = new Padding(2);
        bntDesign.Name = "bntDesign";
        bntDesign.Size = new Size(184, 58);
        bntDesign.TabIndex = 16;
        bntDesign.Text = "Design";
        bntDesign.TextAlign = HorizontalAlignment.Left;
        bntDesign.Click += bntOpenDesingPop_Click;
        // 
        // mainTextBox
        // 
        mainTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        mainTextBox.BorderStyle = BorderStyle.None;
        mainTextBox.Location = new Point(40, 24);
        mainTextBox.Margin = new Padding(2);
        mainTextBox.Name = "mainTextBox";
        mainTextBox.Size = new Size(1230, 884);
        mainTextBox.TabIndex = 13;
        mainTextBox.Text = "";
        // 
        // sPanel2
        // 
        sPanel2.BackColor = Color.White;
        sPanel2.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel2.BorderColor = Color.Black;
        sPanel2.BorderRadius = 0;
        sPanel2.BorderSize = 0;
        sPanel2.Controls.Add(lblWordCounts);
        sPanel2.Controls.Add(lblErrors);
        sPanel2.Controls.Add(lblLanguage);
        sPanel2.Dock = DockStyle.Bottom;
        sPanel2.ForeColor = Color.White;
        sPanel2.Location = new Point(0, 1079);
        sPanel2.Margin = new Padding(4);
        sPanel2.Name = "sPanel2";
        sPanel2.Size = new Size(1604, 38);
        sPanel2.TabIndex = 14;
        // 
        // lblWordCounts
        // 
        lblWordCounts.BackColor = Color.Transparent;
        lblWordCounts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblWordCounts.ForeColor = Color.Black;
        lblWordCounts.Location = new Point(208, 8);
        lblWordCounts.Margin = new Padding(4, 0, 4, 0);
        lblWordCounts.Name = "lblWordCounts";
        lblWordCounts.Size = new Size(368, 24);
        lblWordCounts.TabIndex = 1;
        lblWordCounts.Text = "n/a";
        lblWordCounts.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblErrors
        // 
        lblErrors.BackColor = Color.Transparent;
        lblErrors.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblErrors.ForeColor = Color.Black;
        lblErrors.Location = new Point(584, 8);
        lblErrors.Margin = new Padding(4, 0, 4, 0);
        lblErrors.Name = "lblErrors";
        lblErrors.Size = new Size(120, 24);
        lblErrors.TabIndex = 1;
        lblErrors.Text = "n/a";
        lblErrors.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblLanguage
        // 
        lblLanguage.BackColor = Color.Transparent;
        lblLanguage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblLanguage.ForeColor = Color.Black;
        lblLanguage.Location = new Point(8, 8);
        lblLanguage.Margin = new Padding(4, 0, 4, 0);
        lblLanguage.Name = "lblLanguage";
        lblLanguage.Size = new Size(192, 24);
        lblLanguage.TabIndex = 1;
        lblLanguage.Text = "n/a";
        lblLanguage.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlMenu
        // 
        pnlMenu.BackColor = Color.White;
        pnlMenu.BackgroundImageLayout = ImageLayout.Stretch;
        pnlMenu.BorderColor = Color.DimGray;
        pnlMenu.BorderRadius = 15;
        pnlMenu.BorderSize = 1;
        pnlMenu.Controls.Add(guna2Button4);
        pnlMenu.Controls.Add(label6);
        pnlMenu.Controls.Add(label5);
        pnlMenu.Controls.Add(guna2Button3);
        pnlMenu.Controls.Add(guna2Button5);
        pnlMenu.Controls.Add(guna2Button2);
        pnlMenu.Controls.Add(guna2Button1);
        pnlMenu.ForeColor = Color.White;
        pnlMenu.Location = new Point(16, 104);
        pnlMenu.Margin = new Padding(4);
        pnlMenu.Name = "pnlMenu";
        pnlMenu.Size = new Size(328, 586);
        pnlMenu.TabIndex = 15;
        pnlMenu.Visible = false;
        // 
        // guna2Button4
        // 
        guna2Button4.Animated = true;
        guna2Button4.BackColor = Color.Transparent;
        guna2Button4.BackgroundImageLayout = ImageLayout.Zoom;
        guna2Button4.BorderColor = Color.Gainsboro;
        guna2Button4.BorderRadius = 10;
        guna2Button4.DisabledState.BorderColor = Color.DarkGray;
        guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button4.FillColor = Color.Transparent;
        guna2Button4.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button4.ForeColor = Color.Black;
        guna2Button4.Image = Properties.Resources.icons8_close_96;
        guna2Button4.ImageAlign = HorizontalAlignment.Left;
        guna2Button4.ImageSize = new Size(35, 35);
        guna2Button4.Location = new Point(24, 350);
        guna2Button4.Margin = new Padding(2);
        guna2Button4.Name = "guna2Button4";
        guna2Button4.Size = new Size(280, 58);
        guna2Button4.TabIndex = 16;
        guna2Button4.Text = "  Beenden";
        guna2Button4.TextAlign = HorizontalAlignment.Left;
        guna2Button4.Click += guna2Button4_Click;
        // 
        // label6
        // 
        label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        label6.BackColor = Color.Transparent;
        label6.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
        label6.ForeColor = Color.Gray;
        label6.Location = new Point(24, 506);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(280, 32);
        label6.TabIndex = 1;
        label6.Text = "powered by ";
        label6.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label5
        // 
        label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        label5.BackColor = Color.Transparent;
        label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label5.ForeColor = Color.Black;
        label5.Location = new Point(24, 530);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(280, 40);
        label5.TabIndex = 1;
        label5.Text = "LILO Sync ";
        label5.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Button3
        // 
        guna2Button3.Animated = true;
        guna2Button3.BackColor = Color.Transparent;
        guna2Button3.BackgroundImageLayout = ImageLayout.Zoom;
        guna2Button3.BorderColor = Color.Gainsboro;
        guna2Button3.BorderRadius = 10;
        guna2Button3.DisabledState.BorderColor = Color.DarkGray;
        guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button3.FillColor = Color.Transparent;
        guna2Button3.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button3.ForeColor = Color.Black;
        guna2Button3.Image = Properties.Resources.icons8_document_240;
        guna2Button3.ImageAlign = HorizontalAlignment.Left;
        guna2Button3.ImageSize = new Size(35, 35);
        guna2Button3.Location = new Point(24, 30);
        guna2Button3.Margin = new Padding(2);
        guna2Button3.Name = "guna2Button3";
        guna2Button3.Size = new Size(280, 58);
        guna2Button3.TabIndex = 16;
        guna2Button3.Text = "Neu";
        guna2Button3.TextAlign = HorizontalAlignment.Left;
        guna2Button3.Click += newFile_Click;
        // 
        // guna2Button5
        // 
        guna2Button5.Animated = true;
        guna2Button5.BackColor = Color.Transparent;
        guna2Button5.BackgroundImageLayout = ImageLayout.Zoom;
        guna2Button5.BorderColor = Color.Gainsboro;
        guna2Button5.BorderRadius = 10;
        guna2Button5.DisabledState.BorderColor = Color.DarkGray;
        guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button5.FillColor = Color.Transparent;
        guna2Button5.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button5.ForeColor = Color.Black;
        guna2Button5.Image = Properties.Resources.icons8_folder_240;
        guna2Button5.ImageAlign = HorizontalAlignment.Left;
        guna2Button5.ImageSize = new Size(35, 35);
        guna2Button5.Location = new Point(24, 110);
        guna2Button5.Margin = new Padding(2);
        guna2Button5.Name = "guna2Button5";
        guna2Button5.Size = new Size(280, 58);
        guna2Button5.TabIndex = 16;
        guna2Button5.Text = "Öffnen";
        guna2Button5.TextAlign = HorizontalAlignment.Left;
        guna2Button5.Click += guna2Button5_Click;
        // 
        // guna2Button2
        // 
        guna2Button2.Animated = true;
        guna2Button2.BackColor = Color.Transparent;
        guna2Button2.BackgroundImageLayout = ImageLayout.Zoom;
        guna2Button2.BorderColor = Color.Gainsboro;
        guna2Button2.BorderRadius = 10;
        guna2Button2.DisabledState.BorderColor = Color.DarkGray;
        guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button2.FillColor = Color.Transparent;
        guna2Button2.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button2.ForeColor = Color.Black;
        guna2Button2.Image = Properties.Resources.icons8_save_all_96;
        guna2Button2.ImageAlign = HorizontalAlignment.Left;
        guna2Button2.ImageSize = new Size(35, 35);
        guna2Button2.Location = new Point(24, 270);
        guna2Button2.Margin = new Padding(2);
        guna2Button2.Name = "guna2Button2";
        guna2Button2.Size = new Size(280, 58);
        guna2Button2.TabIndex = 16;
        guna2Button2.Text = "  Alles speichern";
        guna2Button2.TextAlign = HorizontalAlignment.Left;
        // 
        // guna2Button1
        // 
        guna2Button1.Animated = true;
        guna2Button1.BackColor = Color.Transparent;
        guna2Button1.BackgroundImageLayout = ImageLayout.Zoom;
        guna2Button1.BorderColor = Color.Gainsboro;
        guna2Button1.BorderRadius = 10;
        guna2Button1.DisabledState.BorderColor = Color.DarkGray;
        guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button1.FillColor = Color.Transparent;
        guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button1.ForeColor = Color.Black;
        guna2Button1.Image = Properties.Resources.icons8_save_96;
        guna2Button1.ImageAlign = HorizontalAlignment.Left;
        guna2Button1.ImageSize = new Size(35, 35);
        guna2Button1.Location = new Point(24, 190);
        guna2Button1.Margin = new Padding(2);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.Size = new Size(280, 58);
        guna2Button1.TabIndex = 16;
        guna2Button1.Text = "  Speichern";
        guna2Button1.TextAlign = HorizontalAlignment.Left;
        guna2Button1.Click += guna2Button1_Click_1;
        // 
        // sPanel3
        // 
        sPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        sPanel3.BackColor = Color.White;
        sPanel3.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel3.BorderColor = Color.DarkGray;
        sPanel3.BorderRadius = 0;
        sPanel3.BorderSize = 1;
        sPanel3.Controls.Add(mainTextBox);
        sPanel3.ForeColor = Color.White;
        sPanel3.Location = new Point(168, 120);
        sPanel3.Margin = new Padding(4);
        sPanel3.Name = "sPanel3";
        sPanel3.Size = new Size(1302, 933);
        sPanel3.TabIndex = 15;
        // 
        // pnlDesing
        // 
        pnlDesing.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pnlDesing.AutoScroll = true;
        pnlDesing.BackColor = Color.White;
        pnlDesing.BackgroundImageLayout = ImageLayout.Stretch;
        pnlDesing.BorderColor = Color.DimGray;
        pnlDesing.BorderRadius = 15;
        pnlDesing.BorderSize = 1;
        pnlDesing.ForeColor = Color.White;
        pnlDesing.Location = new Point(88, 104);
        pnlDesing.Margin = new Padding(4);
        pnlDesing.Name = "pnlDesing";
        pnlDesing.Size = new Size(1480, 224);
        pnlDesing.TabIndex = 15;
        pnlDesing.Visible = false;
        // 
        // PluginInterface
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(1604, 1117);
        Controls.Add(pnlDesing);
        Controls.Add(pnlMenu);
        Controls.Add(sPanel3);
        Controls.Add(sPanel2);
        Controls.Add(sPanel1);
        Margin = new Padding(2);
        MinimumSize = new Size(300, 498);
        Name = "PluginInterface";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "TextPreview";
        Load += ui_Load;
        Shown += PluginInterface_Shown;
        sPanel1.ResumeLayout(false);
        sPanel2.ResumeLayout(false);
        pnlMenu.ResumeLayout(false);
        sPanel3.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Sipaa.Framework.SPanel sPanel1;
    private Label lblVersion;
    private Guna.UI2.WinForms.Guna2Button bntMenu;
    private RichTextBox mainTextBox;
    private Sipaa.Framework.SPanel sPanel2;
    private Label lblLanguage;
    private Label lblWordCounts;
    private Label lblErrors;
    private Sipaa.Framework.SPanel pnlMenu;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
    private Guna.UI2.WinForms.Guna2Button guna2Button4;
    private Label label5;
    private Guna.UI2.WinForms.Guna2Button guna2Button2;
    private Label label6;
    private Sipaa.Framework.SPanel sPanel3;
    private Guna.UI2.WinForms.Guna2Button guna2Button5;
    private Guna.UI2.WinForms.Guna2Button guna2Button3;
    private Guna.UI2.WinForms.Guna2Button guna2Button7;
    private Guna.UI2.WinForms.Guna2Button bntDesign;
    private Sipaa.Framework.SPanel pnlDesing;
    private Label lblTip;
}