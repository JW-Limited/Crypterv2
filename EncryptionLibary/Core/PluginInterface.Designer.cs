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
        sPanel1.SuspendLayout();
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
        sPanel1.Size = new Size(976, 88);
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
        bntVersion.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        bntVersion.ForeColor = Color.White;
        bntVersion.Location = new Point(800, 16);
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
        // uiSettings
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1020, 948);
        Controls.Add(sPanel1);
        Name = "uiSettings";
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "Plugin: Encryption Models";
        Load += uiSettings_Load;
        sPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Sipaa.Framework.SPanel sPanel1;
    private Guna.UI2.WinForms.Guna2Button bntVersion;
    private Label lblText;
    private Telerik.WinControls.Themes.Windows11Theme windows11Theme1;
}