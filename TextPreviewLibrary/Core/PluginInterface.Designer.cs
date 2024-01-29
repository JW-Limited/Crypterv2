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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginInterface));
        Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
        sPanel1 = new Sipaa.Framework.SPanel();
        pnlTabs = new Panel();
        bntMenu = new Guna.UI2.WinForms.Guna2Button();
        lblVersion = new Label();
        guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
        bntDesign = new Guna.UI2.WinForms.Guna2Button();
        mainTextBox = new RichTextBox();
        sPanel2 = new Sipaa.Framework.SPanel();
        lblWordCounts = new Label();
        lblErrors = new Label();
        lblLanguage = new Label();
        pnlMenu = new Sipaa.Framework.SPanel();
        guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
        lblBottom = new Label();
        pnlDesing = new Sipaa.Framework.SPanel();
        dynamikPermissionView1 = new LILO_Packager.v2.Controls.DynamikPermissionView();
        guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
        label1 = new Label();
        panel3 = new Panel();
        panel2 = new Panel();
        panel1 = new Panel();
        guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        sPanel3 = new Sipaa.Framework.SPanel();
        Transition = new Guna.UI2.WinForms.Guna2Transition();
        sPanel1.SuspendLayout();
        sPanel2.SuspendLayout();
        pnlMenu.SuspendLayout();
        guna2Panel3.SuspendLayout();
        pnlDesing.SuspendLayout();
        sPanel3.SuspendLayout();
        SuspendLayout();
        // 
        // sPanel1
        // 
        sPanel1.BackColor = Color.White;
        resources.ApplyResources(sPanel1, "sPanel1");
        sPanel1.BorderColor = Color.Black;
        sPanel1.BorderRadius = 0;
        sPanel1.BorderSize = 0;
        sPanel1.Controls.Add(pnlTabs);
        sPanel1.Controls.Add(bntMenu);
        Transition.SetDecoration(sPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
        sPanel1.ForeColor = Color.White;
        sPanel1.Name = "sPanel1";
        // 
        // pnlTabs
        // 
        resources.ApplyResources(pnlTabs, "pnlTabs");
        Transition.SetDecoration(pnlTabs, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlTabs.Name = "pnlTabs";
        // 
        // bntMenu
        // 
        bntMenu.Animated = true;
        bntMenu.BackColor = Color.Transparent;
        resources.ApplyResources(bntMenu, "bntMenu");
        bntMenu.BorderColor = Color.Gainsboro;
        bntMenu.BorderRadius = 10;
        bntMenu.CheckedState.Image = Properties.Resources.icons8_close_96;
        Transition.SetDecoration(bntMenu, Guna.UI2.AnimatorNS.DecorationType.None);
        bntMenu.DisabledState.BorderColor = Color.DarkGray;
        bntMenu.DisabledState.CustomBorderColor = Color.DarkGray;
        bntMenu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntMenu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntMenu.FillColor = Color.Transparent;
        bntMenu.FocusedColor = Color.FromArgb(100, 170, 209);
        bntMenu.ForeColor = Color.White;
        bntMenu.Image = Properties.Resources.icons8_menu_240;
        bntMenu.ImageSize = new Size(35, 35);
        bntMenu.Name = "bntMenu";
        bntMenu.Click += bntPlugin_Click;
        // 
        // lblVersion
        // 
        resources.ApplyResources(lblVersion, "lblVersion");
        lblVersion.BackColor = Color.Transparent;
        Transition.SetDecoration(lblVersion, Guna.UI2.AnimatorNS.DecorationType.None);
        lblVersion.ForeColor = Color.DimGray;
        lblVersion.Name = "lblVersion";
        // 
        // guna2Button7
        // 
        guna2Button7.Animated = true;
        guna2Button7.BackColor = Color.Transparent;
        resources.ApplyResources(guna2Button7, "guna2Button7");
        guna2Button7.BorderColor = Color.Gainsboro;
        guna2Button7.BorderRadius = 10;
        Transition.SetDecoration(guna2Button7, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button7.DisabledState.BorderColor = Color.DarkGray;
        guna2Button7.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button7.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button7.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button7.FillColor = Color.Transparent;
        guna2Button7.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button7.ForeColor = Color.Black;
        guna2Button7.Image = Properties.Resources.icons8_foxit_reader_240;
        guna2Button7.ImageAlign = HorizontalAlignment.Left;
        guna2Button7.ImageSize = new Size(35, 35);
        guna2Button7.Name = "guna2Button7";
        guna2Button7.TextAlign = HorizontalAlignment.Left;
        guna2Button7.Click += bntFormating;
        // 
        // bntDesign
        // 
        bntDesign.Animated = true;
        bntDesign.BackColor = Color.Transparent;
        resources.ApplyResources(bntDesign, "bntDesign");
        bntDesign.BorderColor = Color.Gainsboro;
        bntDesign.BorderRadius = 10;
        Transition.SetDecoration(bntDesign, Guna.UI2.AnimatorNS.DecorationType.None);
        bntDesign.DisabledState.BorderColor = Color.DarkGray;
        bntDesign.DisabledState.CustomBorderColor = Color.DarkGray;
        bntDesign.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntDesign.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntDesign.FillColor = Color.Transparent;
        bntDesign.FocusedColor = Color.FromArgb(100, 170, 209);
        bntDesign.ForeColor = Color.Black;
        bntDesign.Image = Properties.Resources.icons8_windows_10_personalization_96;
        bntDesign.ImageAlign = HorizontalAlignment.Left;
        bntDesign.ImageSize = new Size(35, 35);
        bntDesign.Name = "bntDesign";
        bntDesign.TextAlign = HorizontalAlignment.Left;
        bntDesign.Click += bntOpenDesingPop_Click;
        // 
        // mainTextBox
        // 
        resources.ApplyResources(mainTextBox, "mainTextBox");
        mainTextBox.BorderStyle = BorderStyle.None;
        Transition.SetDecoration(mainTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
        mainTextBox.Name = "mainTextBox";
        // 
        // sPanel2
        // 
        sPanel2.BackColor = Color.White;
        resources.ApplyResources(sPanel2, "sPanel2");
        sPanel2.BorderColor = Color.Black;
        sPanel2.BorderRadius = 0;
        sPanel2.BorderSize = 0;
        sPanel2.Controls.Add(lblWordCounts);
        sPanel2.Controls.Add(lblErrors);
        sPanel2.Controls.Add(lblLanguage);
        Transition.SetDecoration(sPanel2, Guna.UI2.AnimatorNS.DecorationType.None);
        sPanel2.ForeColor = Color.White;
        sPanel2.Name = "sPanel2";
        // 
        // lblWordCounts
        // 
        lblWordCounts.BackColor = Color.Transparent;
        Transition.SetDecoration(lblWordCounts, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(lblWordCounts, "lblWordCounts");
        lblWordCounts.ForeColor = Color.Black;
        lblWordCounts.Name = "lblWordCounts";
        // 
        // lblErrors
        // 
        lblErrors.BackColor = Color.Transparent;
        Transition.SetDecoration(lblErrors, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(lblErrors, "lblErrors");
        lblErrors.ForeColor = Color.Black;
        lblErrors.Name = "lblErrors";
        // 
        // lblLanguage
        // 
        lblLanguage.BackColor = Color.Transparent;
        Transition.SetDecoration(lblLanguage, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(lblLanguage, "lblLanguage");
        lblLanguage.ForeColor = Color.Black;
        lblLanguage.Name = "lblLanguage";
        // 
        // pnlMenu
        // 
        pnlMenu.BackColor = Color.White;
        resources.ApplyResources(pnlMenu, "pnlMenu");
        pnlMenu.BorderColor = Color.Gainsboro;
        pnlMenu.BorderRadius = 15;
        pnlMenu.BorderSize = 1;
        pnlMenu.Controls.Add(guna2Panel3);
        pnlMenu.Controls.Add(pnlDesing);
        pnlMenu.Controls.Add(panel2);
        pnlMenu.Controls.Add(panel1);
        pnlMenu.Controls.Add(guna2Button7);
        pnlMenu.Controls.Add(guna2Button3);
        pnlMenu.Controls.Add(guna2Button5);
        pnlMenu.Controls.Add(bntDesign);
        pnlMenu.Controls.Add(guna2Button2);
        pnlMenu.Controls.Add(guna2Button1);
        Transition.SetDecoration(pnlMenu, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlMenu.ForeColor = Color.White;
        pnlMenu.Name = "pnlMenu";
        // 
        // guna2Panel3
        // 
        resources.ApplyResources(guna2Panel3, "guna2Panel3");
        guna2Panel3.BackColor = Color.Transparent;
        guna2Panel3.BorderColor = Color.Gainsboro;
        guna2Panel3.BorderRadius = 15;
        guna2Panel3.BorderThickness = 2;
        guna2Panel3.Controls.Add(lblVersion);
        guna2Panel3.Controls.Add(lblBottom);
        Transition.SetDecoration(guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Panel3.FillColor = Color.White;
        guna2Panel3.Name = "guna2Panel3";
        // 
        // lblBottom
        // 
        resources.ApplyResources(lblBottom, "lblBottom");
        lblBottom.BackColor = Color.Transparent;
        Transition.SetDecoration(lblBottom, Guna.UI2.AnimatorNS.DecorationType.None);
        lblBottom.ForeColor = Color.DarkGray;
        lblBottom.Name = "lblBottom";
        // 
        // pnlDesing
        // 
        resources.ApplyResources(pnlDesing, "pnlDesing");
        pnlDesing.BackColor = Color.White;
        pnlDesing.BorderColor = Color.Transparent;
        pnlDesing.BorderRadius = 15;
        pnlDesing.BorderSize = 1;
        pnlDesing.Controls.Add(dynamikPermissionView1);
        pnlDesing.Controls.Add(guna2Button4);
        pnlDesing.Controls.Add(label1);
        pnlDesing.Controls.Add(panel3);
        Transition.SetDecoration(pnlDesing, Guna.UI2.AnimatorNS.DecorationType.BottomMirror);
        pnlDesing.ForeColor = Color.White;
        pnlDesing.Name = "pnlDesing";
        // 
        // dynamikPermissionView1
        // 
        Transition.SetDecoration(dynamikPermissionView1, Guna.UI2.AnimatorNS.DecorationType.None);
        dynamikPermissionView1.EnabledState = true;
        resources.ApplyResources(dynamikPermissionView1, "dynamikPermissionView1");
        dynamikPermissionView1.Name = "dynamikPermissionView1";
        dynamikPermissionView1.PermissionDescription = "Manager";
        dynamikPermissionView1.PermissionName = "Color";
        // 
        // guna2Button4
        // 
        guna2Button4.Animated = true;
        guna2Button4.BackColor = Color.Transparent;
        resources.ApplyResources(guna2Button4, "guna2Button4");
        guna2Button4.BorderColor = Color.Gainsboro;
        guna2Button4.BorderRadius = 10;
        Transition.SetDecoration(guna2Button4, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button4.DisabledState.BorderColor = Color.DarkGray;
        guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button4.FillColor = Color.Transparent;
        guna2Button4.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button4.ForeColor = Color.White;
        guna2Button4.Image = Properties.Resources.icons8_close_96;
        guna2Button4.ImageSize = new Size(35, 35);
        guna2Button4.Name = "guna2Button4";
        guna2Button4.Click += bntCloseDesign;
        // 
        // label1
        // 
        resources.ApplyResources(label1, "label1");
        label1.BackColor = Color.Transparent;
        Transition.SetDecoration(label1, Guna.UI2.AnimatorNS.DecorationType.None);
        label1.ForeColor = Color.DimGray;
        label1.Name = "label1";
        // 
        // panel3
        // 
        resources.ApplyResources(panel3, "panel3");
        Transition.SetDecoration(panel3, Guna.UI2.AnimatorNS.DecorationType.None);
        panel3.Name = "panel3";
        // 
        // panel2
        // 
        resources.ApplyResources(panel2, "panel2");
        Transition.SetDecoration(panel2, Guna.UI2.AnimatorNS.DecorationType.None);
        panel2.Name = "panel2";
        // 
        // panel1
        // 
        resources.ApplyResources(panel1, "panel1");
        Transition.SetDecoration(panel1, Guna.UI2.AnimatorNS.DecorationType.None);
        panel1.Name = "panel1";
        // 
        // guna2Button3
        // 
        guna2Button3.Animated = true;
        guna2Button3.BackColor = Color.Transparent;
        resources.ApplyResources(guna2Button3, "guna2Button3");
        guna2Button3.BorderColor = Color.Gainsboro;
        guna2Button3.BorderRadius = 10;
        Transition.SetDecoration(guna2Button3, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button3.DisabledState.BorderColor = Color.DarkGray;
        guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button3.FillColor = Color.Transparent;
        guna2Button3.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button3.ForeColor = Color.Black;
        guna2Button3.Image = Properties.Resources.icons8_document_240;
        guna2Button3.ImageAlign = HorizontalAlignment.Left;
        guna2Button3.ImageSize = new Size(35, 35);
        guna2Button3.Name = "guna2Button3";
        guna2Button3.TextAlign = HorizontalAlignment.Left;
        guna2Button3.Click += newFile_Click;
        // 
        // guna2Button5
        // 
        guna2Button5.Animated = true;
        guna2Button5.BackColor = Color.Transparent;
        resources.ApplyResources(guna2Button5, "guna2Button5");
        guna2Button5.BorderColor = Color.Gainsboro;
        guna2Button5.BorderRadius = 10;
        Transition.SetDecoration(guna2Button5, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button5.DisabledState.BorderColor = Color.DarkGray;
        guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button5.FillColor = Color.Transparent;
        guna2Button5.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button5.ForeColor = Color.Black;
        guna2Button5.Image = Properties.Resources.icons8_folder_240;
        guna2Button5.ImageAlign = HorizontalAlignment.Left;
        guna2Button5.ImageSize = new Size(35, 35);
        guna2Button5.Name = "guna2Button5";
        guna2Button5.TextAlign = HorizontalAlignment.Left;
        guna2Button5.Click += OpenButtonClicked;
        // 
        // guna2Button2
        // 
        guna2Button2.Animated = true;
        guna2Button2.BackColor = Color.Transparent;
        resources.ApplyResources(guna2Button2, "guna2Button2");
        guna2Button2.BorderColor = Color.Gainsboro;
        guna2Button2.BorderRadius = 10;
        Transition.SetDecoration(guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button2.DisabledState.BorderColor = Color.DarkGray;
        guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button2.FillColor = Color.Transparent;
        guna2Button2.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button2.ForeColor = Color.Black;
        guna2Button2.Image = Properties.Resources.icons8_save_all_96;
        guna2Button2.ImageAlign = HorizontalAlignment.Left;
        guna2Button2.ImageSize = new Size(35, 35);
        guna2Button2.Name = "guna2Button2";
        guna2Button2.TextAlign = HorizontalAlignment.Left;
        // 
        // guna2Button1
        // 
        guna2Button1.Animated = true;
        guna2Button1.BackColor = Color.Transparent;
        resources.ApplyResources(guna2Button1, "guna2Button1");
        guna2Button1.BorderColor = Color.Gainsboro;
        guna2Button1.BorderRadius = 10;
        Transition.SetDecoration(guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button1.DisabledState.BorderColor = Color.DarkGray;
        guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button1.FillColor = Color.Transparent;
        guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button1.ForeColor = Color.Black;
        guna2Button1.Image = Properties.Resources.icons8_save_96;
        guna2Button1.ImageAlign = HorizontalAlignment.Left;
        guna2Button1.ImageSize = new Size(35, 35);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.TextAlign = HorizontalAlignment.Left;
        guna2Button1.Click += SaveButton_Clicked;
        // 
        // sPanel3
        // 
        resources.ApplyResources(sPanel3, "sPanel3");
        sPanel3.BackColor = Color.White;
        sPanel3.BorderColor = Color.Gainsboro;
        sPanel3.BorderRadius = 20;
        sPanel3.BorderSize = 2;
        sPanel3.Controls.Add(mainTextBox);
        Transition.SetDecoration(sPanel3, Guna.UI2.AnimatorNS.DecorationType.None);
        sPanel3.ForeColor = Color.White;
        sPanel3.Name = "sPanel3";
        // 
        // Transition
        // 
        Transition.Cursor = null;
        animation1.AnimateOnlyDifferences = true;
        animation1.LeafCoeff = 0F;
        animation1.MaxTime = 1F;
        animation1.MinTime = 0F;
        animation1.MosaicSize = 0;
        animation1.Padding = new Padding(0);
        animation1.RotateCoeff = 0F;
        animation1.RotateLimit = 0F;
        animation1.TimeCoeff = 0F;
        animation1.TransparencyCoeff = 0F;
        Transition.DefaultAnimation = animation1;
        Transition.Interval = 1;
        // 
        // PluginInterface
        // 
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        Controls.Add(pnlMenu);
        Controls.Add(sPanel3);
        Controls.Add(sPanel2);
        Controls.Add(sPanel1);
        Transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
        //Name = "PluginInterface";
        ShowIcon = false;
        ShowInTaskbar = false;
        Load += ui_Load;
        Shown += PluginInterface_Shown;
        sPanel1.ResumeLayout(false);
        sPanel2.ResumeLayout(false);
        pnlMenu.ResumeLayout(false);
        guna2Panel3.ResumeLayout(false);
        pnlDesing.ResumeLayout(false);
        sPanel3.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Sipaa.Framework.SPanel sPanel1;
    private Label lblVersion;
    private Guna.UI2.WinForms.Guna2Button bntMenu;
    private Sipaa.Framework.SPanel sPanel2;
    private Label lblLanguage;
    private Label lblWordCounts;
    private Label lblErrors;
    private Sipaa.Framework.SPanel pnlMenu;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
    private Guna.UI2.WinForms.Guna2Button guna2Button2;
    private Sipaa.Framework.SPanel sPanel3;
    private Guna.UI2.WinForms.Guna2Button guna2Button5;
    private Guna.UI2.WinForms.Guna2Button guna2Button3;
    private Guna.UI2.WinForms.Guna2Button guna2Button7;
    private Guna.UI2.WinForms.Guna2Button bntDesign;
    private Sipaa.Framework.SPanel pnlDesing;
    private Panel panel1;
    private Panel panel2;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
    private Label lblBottom;
    public Guna.UI2.WinForms.Guna2Transition Transition;
    private Guna.UI2.WinForms.Guna2Button guna2Button4;
    private Label label1;
    private Panel panel3;
    public RichTextBox mainTextBox;
    private LILO_Packager.v2.Controls.DynamikPermissionView dynamikPermissionView1;
    public Panel pnlTabs;
}