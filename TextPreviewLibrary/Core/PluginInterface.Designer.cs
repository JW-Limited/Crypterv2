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
        lblVersion = new Label();
        mainTextBox = new RichTextBox();
        sPanel2 = new Sipaa.Framework.SPanel();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        pnlMenu = new Sipaa.Framework.SPanel();
        guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
        label6 = new Label();
        label5 = new Label();
        guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        sPanel3 = new Sipaa.Framework.SPanel();
        guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
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
        sPanel1.Controls.Add(lblVersion);
        sPanel1.Dock = DockStyle.Top;
        sPanel1.ForeColor = Color.White;
        sPanel1.Location = new Point(0, 0);
        sPanel1.Margin = new Padding(4);
        sPanel1.Name = "sPanel1";
        sPanel1.Size = new Size(2016, 88);
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
        // lblVersion
        // 
        lblVersion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblVersion.BackColor = Color.Transparent;
        lblVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblVersion.ForeColor = Color.Black;
        lblVersion.Location = new Point(1918, 16);
        lblVersion.Margin = new Padding(4, 0, 4, 0);
        lblVersion.Name = "lblVersion";
        lblVersion.Size = new Size(88, 56);
        lblVersion.TabIndex = 1;
        lblVersion.Text = "n/a";
        lblVersion.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // mainTextBox
        // 
        mainTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        mainTextBox.BorderStyle = BorderStyle.None;
        mainTextBox.Location = new Point(40, 24);
        mainTextBox.Name = "mainTextBox";
        mainTextBox.Size = new Size(1624, 1064);
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
        sPanel2.Controls.Add(label3);
        sPanel2.Controls.Add(label2);
        sPanel2.Controls.Add(label1);
        sPanel2.Dock = DockStyle.Bottom;
        sPanel2.ForeColor = Color.White;
        sPanel2.Location = new Point(0, 1251);
        sPanel2.Margin = new Padding(4);
        sPanel2.Name = "sPanel2";
        sPanel2.Size = new Size(2016, 38);
        sPanel2.TabIndex = 14;
        // 
        // label3
        // 
        label3.BackColor = Color.Transparent;
        label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label3.ForeColor = Color.Black;
        label3.Location = new Point(280, 8);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(104, 24);
        label3.TabIndex = 1;
        label3.Text = "n/a";
        label3.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.BackColor = Color.Transparent;
        label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label2.ForeColor = Color.Black;
        label2.Location = new Point(144, 8);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(104, 24);
        label2.TabIndex = 1;
        label2.Text = "n/a";
        label2.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label1
        // 
        label1.BackColor = Color.Transparent;
        label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label1.ForeColor = Color.Black;
        label1.Location = new Point(8, 8);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(104, 24);
        label1.TabIndex = 1;
        label1.Text = "n/a";
        label1.TextAlign = ContentAlignment.MiddleLeft;
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
        pnlMenu.Size = new Size(328, 504);
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
        guna2Button4.Location = new Point(24, 264);
        guna2Button4.Margin = new Padding(2);
        guna2Button4.Name = "guna2Button4";
        guna2Button4.Size = new Size(280, 58);
        guna2Button4.TabIndex = 16;
        guna2Button4.Text = "  Beenden";
        guna2Button4.TextAlign = HorizontalAlignment.Left;
        // 
        // label6
        // 
        label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label6.BackColor = Color.Transparent;
        label6.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
        label6.ForeColor = Color.Gray;
        label6.Location = new Point(24, 424);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(280, 32);
        label6.TabIndex = 1;
        label6.Text = "powered by ";
        label6.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label5
        // 
        label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label5.BackColor = Color.Transparent;
        label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label5.ForeColor = Color.Black;
        label5.Location = new Point(24, 448);
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
        guna2Button3.Image = Properties.Resources.icons8_delete_96;
        guna2Button3.ImageAlign = HorizontalAlignment.Left;
        guna2Button3.ImageSize = new Size(35, 35);
        guna2Button3.Location = new Point(24, 184);
        guna2Button3.Margin = new Padding(2);
        guna2Button3.Name = "guna2Button3";
        guna2Button3.Size = new Size(280, 58);
        guna2Button3.TabIndex = 16;
        guna2Button3.Text = "  Löschen";
        guna2Button3.TextAlign = HorizontalAlignment.Left;
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
        guna2Button2.Location = new Point(24, 104);
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
        guna2Button1.Location = new Point(24, 24);
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
        sPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
        sPanel3.Size = new Size(1696, 1112);
        sPanel3.TabIndex = 15;
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
        guna2Button5.Image = Properties.Resources.icons8_save_all_96;
        guna2Button5.ImageAlign = HorizontalAlignment.Left;
        guna2Button5.ImageSize = new Size(35, 35);
        guna2Button5.Location = new Point(24, 344);
        guna2Button5.Margin = new Padding(2);
        guna2Button5.Name = "guna2Button5";
        guna2Button5.Size = new Size(280, 58);
        guna2Button5.TabIndex = 16;
        guna2Button5.Text = "Öffnen";
        guna2Button5.TextAlign = HorizontalAlignment.Left;
        guna2Button5.Click += guna2Button5_Click;
        // 
        // PluginInterface
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(2016, 1289);
        Controls.Add(pnlMenu);
        Controls.Add(sPanel3);
        Controls.Add(sPanel2);
        Controls.Add(sPanel1);
        MinimumSize = new Size(300, 500);
        Name = "PluginInterface";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "TextPreview";
        Load += ui_Load;
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
    private Label label1;
    private Label label3;
    private Label label2;
    private Sipaa.Framework.SPanel pnlMenu;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
    private Guna.UI2.WinForms.Guna2Button guna2Button4;
    private Label label5;
    private Guna.UI2.WinForms.Guna2Button guna2Button3;
    private Guna.UI2.WinForms.Guna2Button guna2Button2;
    private Label label6;
    private Sipaa.Framework.SPanel sPanel3;
    private Guna.UI2.WinForms.Guna2Button guna2Button5;
}