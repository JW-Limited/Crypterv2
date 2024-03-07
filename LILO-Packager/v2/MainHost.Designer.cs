namespace LILO_Packager.v2;

partial class MainHost
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainHost));
        Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
        hider = new Sipaa.Framework.SPanel();
        bntAccount = new Guna.UI2.WinForms.Guna2Button();
        pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
        guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
        bntMenu_c = new Guna.UI2.WinForms.Guna2Button();
        guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
        bntOpen = new Guna.UI2.WinForms.Guna2Button();
        sPanel1 = new Sipaa.Framework.SPanel();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        lblText = new Label();
        bntChoose_File = new Guna.UI2.WinForms.Guna2Button();
        Transition = new Guna.UI2.WinForms.Guna2Transition();
        pnlChild = new Panel();
        lblCurrentState = new Label();
        prgMiniProgress = new Guna.UI2.WinForms.Guna2ProgressBar();
        splash_Panel = new Sipaa.Framework.SPanel();
        pnlNoti = new Guna.UI2.WinForms.Guna2Panel();
        guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
        lblMessage_Noti = new Label();
        label4 = new Label();
        pnlSide = new Sipaa.Framework.SPanel();
        pnlNotifications = new Panel();
        pnlMes1 = new Guna.UI2.WinForms.Guna2Panel();
        Mes1_Message = new Label();
        Mes1_bnt = new Guna.UI2.WinForms.Guna2Button();
        Mes1_Title = new Label();
        guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
        bntCloseSideBoard = new Guna.UI2.WinForms.Guna2Button();
        pnlNothing = new Sipaa.Framework.SPanel();
        lblMessage = new Label();
        sPanel3 = new Sipaa.Framework.SPanel();
        pnlLoading = new Panel();
        progressSpinner = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
        panel1 = new Panel();
        taskBarProgress = new Guna.UI2.WinForms.Guna2TaskBarProgress(components);
        hider.SuspendLayout();
        pnlMenu.SuspendLayout();
        sPanel1.SuspendLayout();
        pnlChild.SuspendLayout();
        pnlNoti.SuspendLayout();
        pnlSide.SuspendLayout();
        pnlNotifications.SuspendLayout();
        pnlMes1.SuspendLayout();
        pnlNothing.SuspendLayout();
        pnlLoading.SuspendLayout();
        SuspendLayout();
        // 
        // hider
        // 
        hider.BackColor = Color.Gainsboro;
        hider.BorderColor = Color.Black;
        hider.BorderRadius = 0;
        hider.BorderSize = 0;
        hider.Controls.Add(bntAccount);
        hider.Controls.Add(pnlMenu);
        hider.Controls.Add(bntMenu_c);
        hider.Controls.Add(guna2Button2);
        hider.Controls.Add(guna2Button5);
        hider.Controls.Add(guna2Button4);
        hider.Controls.Add(guna2Button3);
        hider.Controls.Add(bntOpen);
        hider.Controls.Add(sPanel1);
        Transition.SetDecoration(hider, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(hider, "hider");
        hider.ForeColor = Color.White;
        hider.Name = "hider";
        hider.Paint += hider_Paint;
        // 
        // bntAccount
        // 
        resources.ApplyResources(bntAccount, "bntAccount");
        bntAccount.Animated = true;
        bntAccount.BorderColor = Color.Gainsboro;
        bntAccount.BorderRadius = 20;
        bntAccount.BorderThickness = 2;
        bntAccount.CheckedState.BorderColor = Color.Gainsboro;
        bntAccount.CheckedState.FillColor = Color.WhiteSmoke;
        bntAccount.CheckedState.ForeColor = Color.DimGray;
        Transition.SetDecoration(bntAccount, Guna.UI2.AnimatorNS.DecorationType.None);
        bntAccount.DisabledState.BorderColor = Color.Gainsboro;
        bntAccount.DisabledState.CustomBorderColor = Color.Gainsboro;
        bntAccount.DisabledState.FillColor = Color.Transparent;
        bntAccount.DisabledState.ForeColor = Color.Black;
        bntAccount.FillColor = Color.Empty;
        bntAccount.FocusedColor = Color.FromArgb(100, 170, 209);
        bntAccount.ForeColor = Color.Black;
        bntAccount.Image = Properties.Resources.icons8_male_user_96;
        bntAccount.ImageAlign = HorizontalAlignment.Left;
        bntAccount.ImageOffset = new Point(15, 0);
        bntAccount.ImageSize = new Size(40, 40);
        bntAccount.Name = "bntAccount";
        bntAccount.TextAlign = HorizontalAlignment.Left;
        bntAccount.Click += guna2Button6_Click;
        bntAccount.DoubleClick += bntAccount_DoubleClick;
        bntAccount.MouseLeave += bntAccount_MouseLeave;
        bntAccount.MouseHover += guna2Button6_MouseHover;
        // 
        // pnlMenu
        // 
        resources.ApplyResources(pnlMenu, "pnlMenu");
        pnlMenu.BackColor = Color.Transparent;
        pnlMenu.BorderColor = Color.LightGray;
        pnlMenu.BorderRadius = 15;
        pnlMenu.BorderThickness = 2;
        pnlMenu.Controls.Add(guna2Button10);
        pnlMenu.Controls.Add(guna2Button9);
        Transition.SetDecoration(pnlMenu, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlMenu.FillColor = Color.White;
        pnlMenu.Name = "pnlMenu";
        pnlMenu.ShadowDecoration.BorderRadius = 20;
        pnlMenu.ShadowDecoration.Color = Color.DarkGray;
        pnlMenu.ShadowDecoration.Depth = 10;
        pnlMenu.ShadowDecoration.Shadow = new Padding(7);
        // 
        // guna2Button10
        // 
        guna2Button10.Animated = true;
        guna2Button10.BackColor = Color.Transparent;
        resources.ApplyResources(guna2Button10, "guna2Button10");
        guna2Button10.BorderColor = Color.Gainsboro;
        guna2Button10.BorderRadius = 10;
        guna2Button10.BorderThickness = 2;
        Transition.SetDecoration(guna2Button10, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button10.DisabledState.BorderColor = Color.DarkGray;
        guna2Button10.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button10.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button10.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button10.FillColor = Color.White;
        guna2Button10.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button10.ForeColor = Color.Black;
        guna2Button10.ImageAlign = HorizontalAlignment.Left;
        guna2Button10.ImageSize = new Size(35, 35);
        guna2Button10.Name = "guna2Button10";
        guna2Button10.ShadowDecoration.BorderRadius = 20;
        guna2Button10.ShadowDecoration.Color = Color.DarkGray;
        guna2Button10.ShadowDecoration.Depth = 10;
        guna2Button10.ShadowDecoration.Enabled = true;
        guna2Button10.ShadowDecoration.Shadow = new Padding(7);
        guna2Button10.Click += bntOpenDevApp;
        // 
        // guna2Button9
        // 
        guna2Button9.Animated = true;
        guna2Button9.BackColor = Color.Transparent;
        resources.ApplyResources(guna2Button9, "guna2Button9");
        guna2Button9.BorderColor = Color.Gainsboro;
        guna2Button9.BorderRadius = 10;
        guna2Button9.BorderThickness = 2;
        Transition.SetDecoration(guna2Button9, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button9.DisabledState.BorderColor = Color.DarkGray;
        guna2Button9.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button9.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button9.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button9.FillColor = Color.White;
        guna2Button9.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button9.ForeColor = Color.Black;
        guna2Button9.ImageAlign = HorizontalAlignment.Left;
        guna2Button9.ImageSize = new Size(35, 35);
        guna2Button9.Name = "guna2Button9";
        guna2Button9.ShadowDecoration.BorderRadius = 20;
        guna2Button9.ShadowDecoration.Color = Color.DarkGray;
        guna2Button9.ShadowDecoration.Depth = 10;
        guna2Button9.ShadowDecoration.Enabled = true;
        guna2Button9.ShadowDecoration.Shadow = new Padding(7);
        guna2Button9.Click += bntOpenAboutPage;
        // 
        // bntMenu_c
        // 
        resources.ApplyResources(bntMenu_c, "bntMenu_c");
        bntMenu_c.Animated = true;
        bntMenu_c.BackColor = Color.Transparent;
        bntMenu_c.BorderColor = Color.Transparent;
        bntMenu_c.BorderRadius = 16;
        bntMenu_c.CheckedState.BorderColor = Color.Transparent;
        Transition.SetDecoration(bntMenu_c, Guna.UI2.AnimatorNS.DecorationType.None);
        bntMenu_c.DisabledState.BorderColor = Color.DarkGray;
        bntMenu_c.DisabledState.CustomBorderColor = Color.DarkGray;
        bntMenu_c.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntMenu_c.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntMenu_c.FillColor = Color.Transparent;
        bntMenu_c.FocusedColor = Color.FromArgb(100, 170, 209);
        bntMenu_c.ForeColor = Color.White;
        bntMenu_c.Image = Properties.Resources.icons8_menu_240__1_;
        bntMenu_c.ImageSize = new Size(40, 40);
        bntMenu_c.Name = "bntMenu_c";
        bntMenu_c.Click += bntMenu;
        // 
        // guna2Button2
        // 
        resources.ApplyResources(guna2Button2, "guna2Button2");
        guna2Button2.Animated = true;
        guna2Button2.BorderColor = Color.Gainsboro;
        guna2Button2.BorderRadius = 20;
        guna2Button2.BorderThickness = 2;
        guna2Button2.CheckedState.BorderColor = Color.Gainsboro;
        guna2Button2.CheckedState.FillColor = Color.WhiteSmoke;
        guna2Button2.CheckedState.ForeColor = Color.DimGray;
        Transition.SetDecoration(guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button2.DisabledState.BorderColor = Color.Gainsboro;
        guna2Button2.DisabledState.CustomBorderColor = Color.Gainsboro;
        guna2Button2.DisabledState.FillColor = Color.Transparent;
        guna2Button2.DisabledState.ForeColor = Color.Black;
        guna2Button2.FillColor = Color.Empty;
        guna2Button2.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button2.ForeColor = Color.Black;
        guna2Button2.Image = Properties.Resources.icons8_bursts_96;
        guna2Button2.ImageAlign = HorizontalAlignment.Left;
        guna2Button2.ImageOffset = new Point(15, 0);
        guna2Button2.ImageSize = new Size(40, 40);
        guna2Button2.Name = "guna2Button2";
        guna2Button2.TextAlign = HorizontalAlignment.Left;
        guna2Button2.Click += bntPlugin_Clicked;
        // 
        // guna2Button5
        // 
        resources.ApplyResources(guna2Button5, "guna2Button5");
        guna2Button5.Animated = true;
        guna2Button5.BorderColor = Color.Gainsboro;
        guna2Button5.BorderRadius = 20;
        guna2Button5.BorderThickness = 2;
        guna2Button5.CheckedState.BorderColor = Color.Gainsboro;
        guna2Button5.CheckedState.FillColor = Color.WhiteSmoke;
        guna2Button5.CheckedState.ForeColor = Color.DimGray;
        Transition.SetDecoration(guna2Button5, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button5.DisabledState.BorderColor = Color.Gainsboro;
        guna2Button5.DisabledState.CustomBorderColor = Color.Gainsboro;
        guna2Button5.DisabledState.FillColor = Color.Transparent;
        guna2Button5.DisabledState.ForeColor = Color.Black;
        guna2Button5.FillColor = Color.Empty;
        guna2Button5.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button5.ForeColor = Color.Black;
        guna2Button5.Image = Properties.Resources.Info;
        guna2Button5.ImageAlign = HorizontalAlignment.Left;
        guna2Button5.ImageOffset = new Point(15, 0);
        guna2Button5.ImageSize = new Size(40, 40);
        guna2Button5.Name = "guna2Button5";
        guna2Button5.TextAlign = HorizontalAlignment.Left;
        guna2Button5.Click += guna2Button5_Click;
        // 
        // guna2Button4
        // 
        resources.ApplyResources(guna2Button4, "guna2Button4");
        guna2Button4.Animated = true;
        guna2Button4.BorderColor = Color.Gainsboro;
        guna2Button4.BorderRadius = 20;
        guna2Button4.BorderThickness = 2;
        guna2Button4.CheckedState.BorderColor = Color.Gainsboro;
        guna2Button4.CheckedState.FillColor = Color.WhiteSmoke;
        guna2Button4.CheckedState.ForeColor = Color.DimGray;
        Transition.SetDecoration(guna2Button4, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button4.DisabledState.BorderColor = Color.Gainsboro;
        guna2Button4.DisabledState.CustomBorderColor = Color.Gainsboro;
        guna2Button4.DisabledState.FillColor = Color.Transparent;
        guna2Button4.DisabledState.ForeColor = Color.Black;
        guna2Button4.FillColor = Color.Empty;
        guna2Button4.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button4.ForeColor = Color.Black;
        guna2Button4.Image = Properties.Resources.Bookmark;
        guna2Button4.ImageAlign = HorizontalAlignment.Left;
        guna2Button4.ImageOffset = new Point(15, 0);
        guna2Button4.ImageSize = new Size(40, 40);
        guna2Button4.Name = "guna2Button4";
        guna2Button4.TextAlign = HorizontalAlignment.Left;
        guna2Button4.Click += guna2Button4_Click;
        // 
        // guna2Button3
        // 
        resources.ApplyResources(guna2Button3, "guna2Button3");
        guna2Button3.Animated = true;
        guna2Button3.BorderColor = Color.Gainsboro;
        guna2Button3.BorderRadius = 20;
        guna2Button3.BorderThickness = 2;
        guna2Button3.CheckedState.BorderColor = Color.Gainsboro;
        guna2Button3.CheckedState.FillColor = Color.WhiteSmoke;
        guna2Button3.CheckedState.ForeColor = Color.DimGray;
        Transition.SetDecoration(guna2Button3, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button3.DisabledState.BorderColor = Color.Gainsboro;
        guna2Button3.DisabledState.CustomBorderColor = Color.Gainsboro;
        guna2Button3.DisabledState.FillColor = Color.Transparent;
        guna2Button3.DisabledState.ForeColor = Color.Black;
        guna2Button3.FillColor = Color.Empty;
        guna2Button3.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button3.ForeColor = Color.Black;
        guna2Button3.Image = Properties.Resources.Padlock;
        guna2Button3.ImageAlign = HorizontalAlignment.Left;
        guna2Button3.ImageOffset = new Point(15, 0);
        guna2Button3.ImageSize = new Size(40, 40);
        guna2Button3.Name = "guna2Button3";
        guna2Button3.TextAlign = HorizontalAlignment.Left;
        guna2Button3.Click += guna2Button3_Click;
        // 
        // bntOpen
        // 
        resources.ApplyResources(bntOpen, "bntOpen");
        bntOpen.Animated = true;
        bntOpen.BorderColor = Color.Gainsboro;
        bntOpen.BorderRadius = 20;
        bntOpen.BorderThickness = 2;
        bntOpen.CheckedState.BorderColor = Color.Gainsboro;
        bntOpen.CheckedState.FillColor = Color.WhiteSmoke;
        bntOpen.CheckedState.ForeColor = Color.DimGray;
        Transition.SetDecoration(bntOpen, Guna.UI2.AnimatorNS.DecorationType.None);
        bntOpen.DisabledState.BorderColor = Color.Gainsboro;
        bntOpen.DisabledState.CustomBorderColor = Color.Gainsboro;
        bntOpen.DisabledState.FillColor = Color.Transparent;
        bntOpen.DisabledState.ForeColor = Color.Black;
        bntOpen.FillColor = Color.Transparent;
        bntOpen.FocusedColor = Color.FromArgb(100, 170, 209);
        bntOpen.ForeColor = Color.Black;
        bntOpen.Image = Properties.Resources.Lock;
        bntOpen.ImageAlign = HorizontalAlignment.Left;
        bntOpen.ImageOffset = new Point(15, 0);
        bntOpen.ImageSize = new Size(40, 40);
        bntOpen.Name = "bntOpen";
        bntOpen.TextAlign = HorizontalAlignment.Left;
        bntOpen.Click += bntOpen_Click;
        // 
        // sPanel1
        // 
        sPanel1.BackColor = Color.Black;
        sPanel1.BackgroundImage = Properties.Resources.Aqua_Marine;
        resources.ApplyResources(sPanel1, "sPanel1");
        sPanel1.BorderColor = Color.Black;
        sPanel1.BorderRadius = 20;
        sPanel1.BorderSize = 0;
        sPanel1.Controls.Add(guna2Button1);
        sPanel1.Controls.Add(lblText);
        Transition.SetDecoration(sPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
        sPanel1.ForeColor = Color.White;
        sPanel1.Name = "sPanel1";
        sPanel1.Paint += sPanel1_Paint;
        // 
        // guna2Button1
        // 
        guna2Button1.Animated = true;
        guna2Button1.BackColor = Color.Transparent;
        guna2Button1.BorderColor = Color.Gainsboro;
        guna2Button1.BorderRadius = 20;
        guna2Button1.BorderThickness = 2;
        Transition.SetDecoration(guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button1.DisabledState.BorderColor = Color.Gainsboro;
        guna2Button1.DisabledState.CustomBorderColor = Color.Gainsboro;
        guna2Button1.DisabledState.FillColor = Color.Transparent;
        guna2Button1.DisabledState.ForeColor = Color.Black;
        guna2Button1.FillColor = Color.Transparent;
        guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
        resources.ApplyResources(guna2Button1, "guna2Button1");
        guna2Button1.ForeColor = Color.White;
        guna2Button1.ImageSize = new Size(40, 40);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.ShadowDecoration.BorderRadius = 20;
        guna2Button1.ShadowDecoration.Color = SystemColors.ScrollBar;
        guna2Button1.ShadowDecoration.Depth = 10;
        guna2Button1.ShadowDecoration.Enabled = true;
        guna2Button1.Click += lblText_Click;
        // 
        // lblText
        // 
        lblText.BackColor = Color.Transparent;
        Transition.SetDecoration(lblText, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(lblText, "lblText");
        lblText.ForeColor = Color.White;
        lblText.Name = "lblText";
        lblText.Click += guna2Button1_Click;
        // 
        // bntChoose_File
        // 
        bntChoose_File.Animated = true;
        bntChoose_File.BorderRadius = 17;
        bntChoose_File.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        Transition.SetDecoration(bntChoose_File, Guna.UI2.AnimatorNS.DecorationType.None);
        bntChoose_File.DisabledState.BorderColor = Color.DarkGray;
        bntChoose_File.DisabledState.CustomBorderColor = Color.DarkGray;
        bntChoose_File.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntChoose_File.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntChoose_File.FillColor = Color.DarkGray;
        resources.ApplyResources(bntChoose_File, "bntChoose_File");
        bntChoose_File.ForeColor = Color.White;
        bntChoose_File.Name = "bntChoose_File";
        // 
        // Transition
        // 
        Transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
        Transition.Cursor = null;
        animation1.AnimateOnlyDifferences = true;
        animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
        animation1.LeafCoeff = 0F;
        animation1.MaxTime = 1F;
        animation1.MinTime = 0F;
        animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
        animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
        animation1.MosaicSize = 0;
        animation1.Padding = new Padding(0);
        animation1.RotateCoeff = 0F;
        animation1.RotateLimit = 0F;
        animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
        animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
        animation1.TimeCoeff = 0F;
        animation1.TransparencyCoeff = 1F;
        Transition.DefaultAnimation = animation1;
        Transition.Interval = 1;
        // 
        // pnlChild
        // 
        resources.ApplyResources(pnlChild, "pnlChild");
        pnlChild.Controls.Add(lblCurrentState);
        pnlChild.Controls.Add(prgMiniProgress);
        pnlChild.Controls.Add(splash_Panel);
        pnlChild.Controls.Add(pnlNoti);
        Transition.SetDecoration(pnlChild, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlChild.Name = "pnlChild";
        // 
        // lblCurrentState
        // 
        resources.ApplyResources(lblCurrentState, "lblCurrentState");
        Transition.SetDecoration(lblCurrentState, Guna.UI2.AnimatorNS.DecorationType.None);
        lblCurrentState.ForeColor = SystemColors.ActiveBorder;
        lblCurrentState.Name = "lblCurrentState";
        // 
        // prgMiniProgress
        // 
        resources.ApplyResources(prgMiniProgress, "prgMiniProgress");
        prgMiniProgress.BackColor = Color.Transparent;
        prgMiniProgress.BorderColor = Color.Gainsboro;
        prgMiniProgress.BorderRadius = 1;
        prgMiniProgress.BorderThickness = 2;
        Transition.SetDecoration(prgMiniProgress, Guna.UI2.AnimatorNS.DecorationType.None);
        prgMiniProgress.FillColor = Color.White;
        prgMiniProgress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
        prgMiniProgress.Name = "prgMiniProgress";
        prgMiniProgress.ProgressColor = Color.SteelBlue;
        prgMiniProgress.ProgressColor2 = Color.RoyalBlue;
        prgMiniProgress.ShadowDecoration.Depth = 20;
        prgMiniProgress.Style = ProgressBarStyle.Marquee;
        prgMiniProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
        // 
        // splash_Panel
        // 
        resources.ApplyResources(splash_Panel, "splash_Panel");
        splash_Panel.BackColor = Color.White;
        splash_Panel.BackgroundImage = Properties.Resources.Screenshot_2023_10_13_052005;
        splash_Panel.BorderColor = Color.Black;
        splash_Panel.BorderRadius = 45;
        splash_Panel.BorderSize = 0;
        Transition.SetDecoration(splash_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
        splash_Panel.ForeColor = Color.White;
        splash_Panel.Name = "splash_Panel";
        // 
        // pnlNoti
        // 
        resources.ApplyResources(pnlNoti, "pnlNoti");
        pnlNoti.BackColor = Color.Transparent;
        pnlNoti.BorderColor = Color.LightGray;
        pnlNoti.BorderRadius = 15;
        pnlNoti.BorderThickness = 2;
        pnlNoti.Controls.Add(guna2Button11);
        pnlNoti.Controls.Add(lblMessage_Noti);
        pnlNoti.Controls.Add(label4);
        Transition.SetDecoration(pnlNoti, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlNoti.FillColor = Color.FromArgb(94, 148, 255);
        pnlNoti.Name = "pnlNoti";
        pnlNoti.ShadowDecoration.BorderRadius = 20;
        pnlNoti.ShadowDecoration.Color = Color.DarkGray;
        pnlNoti.ShadowDecoration.Depth = 10;
        pnlNoti.ShadowDecoration.Shadow = new Padding(7);
        // 
        // guna2Button11
        // 
        resources.ApplyResources(guna2Button11, "guna2Button11");
        guna2Button11.Animated = true;
        guna2Button11.BackColor = Color.Transparent;
        guna2Button11.BorderColor = Color.Gainsboro;
        guna2Button11.BorderRadius = 10;
        Transition.SetDecoration(guna2Button11, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button11.DisabledState.BorderColor = Color.DarkGray;
        guna2Button11.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button11.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button11.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button11.FillColor = Color.Transparent;
        guna2Button11.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button11.ForeColor = Color.White;
        guna2Button11.ImageAlign = HorizontalAlignment.Left;
        guna2Button11.ImageSize = new Size(35, 35);
        guna2Button11.Name = "guna2Button11";
        guna2Button11.ShadowDecoration.BorderRadius = 20;
        guna2Button11.ShadowDecoration.Color = Color.DarkGray;
        guna2Button11.ShadowDecoration.Depth = 10;
        guna2Button11.ShadowDecoration.Shadow = new Padding(7);
        guna2Button11.Click += bntCloseNoti;
        // 
        // lblMessage_Noti
        // 
        lblMessage_Noti.BackColor = Color.Transparent;
        Transition.SetDecoration(lblMessage_Noti, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(lblMessage_Noti, "lblMessage_Noti");
        lblMessage_Noti.ForeColor = Color.White;
        lblMessage_Noti.Name = "lblMessage_Noti";
        // 
        // label4
        // 
        resources.ApplyResources(label4, "label4");
        label4.BackColor = Color.Transparent;
        Transition.SetDecoration(label4, Guna.UI2.AnimatorNS.DecorationType.None);
        label4.ForeColor = Color.LightGray;
        label4.Name = "label4";
        // 
        // pnlSide
        // 
        pnlSide.BackColor = Color.White;
        resources.ApplyResources(pnlSide, "pnlSide");
        pnlSide.BorderColor = Color.DimGray;
        pnlSide.BorderRadius = 0;
        pnlSide.BorderSize = 1;
        pnlSide.Controls.Add(pnlNotifications);
        pnlSide.Controls.Add(guna2Button6);
        pnlSide.Controls.Add(guna2Button7);
        pnlSide.Controls.Add(bntCloseSideBoard);
        pnlSide.Controls.Add(pnlNothing);
        pnlSide.Controls.Add(pnlLoading);
        Transition.SetDecoration(pnlSide, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlSide.ForeColor = Color.White;
        pnlSide.Name = "pnlSide";
        // 
        // pnlNotifications
        // 
        resources.ApplyResources(pnlNotifications, "pnlNotifications");
        pnlNotifications.BackColor = Color.White;
        pnlNotifications.Controls.Add(pnlMes1);
        Transition.SetDecoration(pnlNotifications, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlNotifications.Name = "pnlNotifications";
        // 
        // pnlMes1
        // 
        resources.ApplyResources(pnlMes1, "pnlMes1");
        pnlMes1.BorderColor = SystemColors.ButtonFace;
        pnlMes1.BorderRadius = 15;
        pnlMes1.BorderThickness = 2;
        pnlMes1.Controls.Add(Mes1_Message);
        pnlMes1.Controls.Add(Mes1_bnt);
        pnlMes1.Controls.Add(Mes1_Title);
        Transition.SetDecoration(pnlMes1, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlMes1.FillColor = Color.White;
        pnlMes1.Name = "pnlMes1";
        // 
        // Mes1_Message
        // 
        Mes1_Message.BackColor = Color.Transparent;
        Transition.SetDecoration(Mes1_Message, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(Mes1_Message, "Mes1_Message");
        Mes1_Message.ForeColor = Color.DimGray;
        Mes1_Message.Name = "Mes1_Message";
        // 
        // Mes1_bnt
        // 
        Mes1_bnt.Animated = true;
        Mes1_bnt.BackColor = Color.Transparent;
        resources.ApplyResources(Mes1_bnt, "Mes1_bnt");
        Mes1_bnt.BorderColor = Color.Gainsboro;
        Mes1_bnt.BorderRadius = 10;
        Mes1_bnt.BorderThickness = 2;
        Transition.SetDecoration(Mes1_bnt, Guna.UI2.AnimatorNS.DecorationType.None);
        Mes1_bnt.DisabledState.BorderColor = Color.DarkGray;
        Mes1_bnt.DisabledState.CustomBorderColor = Color.DarkGray;
        Mes1_bnt.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        Mes1_bnt.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        Mes1_bnt.FillColor = Color.Transparent;
        Mes1_bnt.FocusedColor = Color.FromArgb(100, 170, 209);
        Mes1_bnt.ForeColor = Color.Black;
        Mes1_bnt.ImageAlign = HorizontalAlignment.Left;
        Mes1_bnt.ImageSize = new Size(35, 35);
        Mes1_bnt.Name = "Mes1_bnt";
        Mes1_bnt.Click += bntUpdate;
        // 
        // Mes1_Title
        // 
        Mes1_Title.BackColor = Color.Transparent;
        Transition.SetDecoration(Mes1_Title, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(Mes1_Title, "Mes1_Title");
        Mes1_Title.ForeColor = Color.Black;
        Mes1_Title.Name = "Mes1_Title";
        // 
        // guna2Button6
        // 
        guna2Button6.Animated = true;
        guna2Button6.BackColor = Color.Transparent;
        resources.ApplyResources(guna2Button6, "guna2Button6");
        guna2Button6.BorderColor = Color.Gainsboro;
        guna2Button6.BorderRadius = 10;
        guna2Button6.BorderThickness = 2;
        Transition.SetDecoration(guna2Button6, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button6.DisabledState.BorderColor = Color.DarkGray;
        guna2Button6.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button6.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button6.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button6.FillColor = Color.WhiteSmoke;
        guna2Button6.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button6.ForeColor = Color.DimGray;
        guna2Button6.ImageAlign = HorizontalAlignment.Left;
        guna2Button6.ImageSize = new Size(35, 35);
        guna2Button6.Name = "guna2Button6";
        guna2Button6.TextAlign = HorizontalAlignment.Left;
        // 
        // guna2Button7
        // 
        guna2Button7.Animated = true;
        guna2Button7.BackColor = Color.Transparent;
        guna2Button7.BorderColor = Color.Gainsboro;
        guna2Button7.BorderRadius = 10;
        guna2Button7.BorderThickness = 2;
        Transition.SetDecoration(guna2Button7, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button7.DisabledState.BorderColor = Color.DarkGray;
        guna2Button7.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button7.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button7.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button7.FillColor = Color.WhiteSmoke;
        guna2Button7.FocusedColor = Color.FromArgb(100, 170, 209);
        resources.ApplyResources(guna2Button7, "guna2Button7");
        guna2Button7.ForeColor = Color.White;
        guna2Button7.Image = Properties.Resources.icons8_synchronize_240;
        guna2Button7.ImageSize = new Size(30, 30);
        guna2Button7.Name = "guna2Button7";
        guna2Button7.Click += guna2Button6_Click_1;
        // 
        // bntCloseSideBoard
        // 
        bntCloseSideBoard.Animated = true;
        bntCloseSideBoard.BackColor = Color.Transparent;
        bntCloseSideBoard.BorderColor = Color.Gainsboro;
        bntCloseSideBoard.BorderRadius = 10;
        bntCloseSideBoard.BorderThickness = 2;
        Transition.SetDecoration(bntCloseSideBoard, Guna.UI2.AnimatorNS.DecorationType.None);
        bntCloseSideBoard.DisabledState.BorderColor = Color.DarkGray;
        bntCloseSideBoard.DisabledState.CustomBorderColor = Color.DarkGray;
        bntCloseSideBoard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntCloseSideBoard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntCloseSideBoard.FillColor = Color.WhiteSmoke;
        bntCloseSideBoard.FocusedColor = Color.FromArgb(100, 170, 209);
        resources.ApplyResources(bntCloseSideBoard, "bntCloseSideBoard");
        bntCloseSideBoard.ForeColor = Color.White;
        bntCloseSideBoard.Image = Properties.Resources.Close;
        bntCloseSideBoard.ImageSize = new Size(25, 25);
        bntCloseSideBoard.Name = "bntCloseSideBoard";
        bntCloseSideBoard.Click += bntCloseSideBoard_Click;
        // 
        // pnlNothing
        // 
        resources.ApplyResources(pnlNothing, "pnlNothing");
        pnlNothing.BackColor = Color.White;
        pnlNothing.BorderColor = Color.Black;
        pnlNothing.BorderRadius = 20;
        pnlNothing.BorderSize = 0;
        pnlNothing.Controls.Add(lblMessage);
        pnlNothing.Controls.Add(sPanel3);
        Transition.SetDecoration(pnlNothing, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlNothing.ForeColor = Color.White;
        pnlNothing.Name = "pnlNothing";
        pnlNothing.Paint += sPanel1_Paint;
        // 
        // lblMessage
        // 
        lblMessage.BackColor = Color.Transparent;
        Transition.SetDecoration(lblMessage, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(lblMessage, "lblMessage");
        lblMessage.ForeColor = Color.DimGray;
        lblMessage.Name = "lblMessage";
        lblMessage.Click += lblText_Click;
        // 
        // sPanel3
        // 
        sPanel3.BackColor = Color.White;
        sPanel3.BackgroundImage = Properties.Resources.nothing;
        resources.ApplyResources(sPanel3, "sPanel3");
        sPanel3.BorderColor = Color.Black;
        sPanel3.BorderRadius = 20;
        sPanel3.BorderSize = 0;
        Transition.SetDecoration(sPanel3, Guna.UI2.AnimatorNS.DecorationType.None);
        sPanel3.ForeColor = Color.White;
        sPanel3.Name = "sPanel3";
        sPanel3.Paint += sPanel1_Paint;
        // 
        // pnlLoading
        // 
        resources.ApplyResources(pnlLoading, "pnlLoading");
        pnlLoading.BackColor = Color.White;
        pnlLoading.Controls.Add(progressSpinner);
        Transition.SetDecoration(pnlLoading, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlLoading.Name = "pnlLoading";
        // 
        // progressSpinner
        // 
        resources.ApplyResources(progressSpinner, "progressSpinner");
        progressSpinner.AutoStart = true;
        progressSpinner.BackColor = Color.White;
        Transition.SetDecoration(progressSpinner, Guna.UI2.AnimatorNS.DecorationType.None);
        progressSpinner.Name = "progressSpinner";
        // 
        // panel1
        // 
        Transition.SetDecoration(panel1, Guna.UI2.AnimatorNS.DecorationType.None);
        resources.ApplyResources(panel1, "panel1");
        panel1.Name = "panel1";
        // 
        // taskBarProgress
        // 
        taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.NoProgress;
        taskBarProgress.TargetForm = null;
        // 
        // MainHost
        // 
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        Controls.Add(pnlChild);
        Controls.Add(pnlSide);
        Controls.Add(panel1);
        Controls.Add(hider);
        Controls.Add(bntChoose_File);
        Transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
        HelpButton = true;
        IsMdiContainer = true;
        Name = "MainHost";
        Load += MainHost_Load;
        hider.ResumeLayout(false);
        pnlMenu.ResumeLayout(false);
        sPanel1.ResumeLayout(false);
        pnlChild.ResumeLayout(false);
        pnlChild.PerformLayout();
        pnlNoti.ResumeLayout(false);
        pnlSide.ResumeLayout(false);
        pnlNotifications.ResumeLayout(false);
        pnlMes1.ResumeLayout(false);
        pnlNothing.ResumeLayout(false);
        pnlLoading.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Sipaa.Framework.SPanel sPanel1;
    private Guna.UI2.WinForms.Guna2Button bntChoose_File;
    private Guna.UI2.WinForms.Guna2Button guna2Button5;
    private Guna.UI2.WinForms.Guna2Button guna2Button4;
    private Guna.UI2.WinForms.Guna2Button guna2Button3;
    private Guna.UI2.WinForms.Guna2Button bntOpen;
    private Guna.UI2.WinForms.Guna2Button bntAccount;
    private Label lblText;
    private Panel pnlChild;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
    private Guna.UI2.WinForms.Guna2Button guna2Button2;
    private Guna.UI2.WinForms.Guna2Button bntCloseSideBoard;
    private Guna.UI2.WinForms.Guna2Button guna2Button6;
    private Sipaa.Framework.SPanel pnlNothing;
    private Label lblMessage;
    private Sipaa.Framework.SPanel sPanel3;
    private Panel pnlLoading;
    private Guna.UI2.WinForms.Guna2WinProgressIndicator progressSpinner;
    private Panel pnlNotifications;
    private Guna.UI2.WinForms.Guna2Panel pnlMes1;
    private Label Mes1_Title;
    private Label Mes1_Message;
    private Guna.UI2.WinForms.Guna2Button Mes1_bnt;
    private Guna.UI2.WinForms.Guna2Button guna2Button7;
    private Guna.UI2.WinForms.Guna2Button bntMenu_c;
    private Guna.UI2.WinForms.Guna2Panel pnlMenu;
    private Guna.UI2.WinForms.Guna2Button guna2Button10;
    private Guna.UI2.WinForms.Guna2Button guna2Button9;
    public Sipaa.Framework.SPanel hider;
    public Sipaa.Framework.SPanel pnlSide;
    private Guna.UI2.WinForms.Guna2Panel pnlNoti;
    private Guna.UI2.WinForms.Guna2Button guna2Button11;
    private Label lblMessage_Noti;
    private Label label4;
    private Panel panel1;
    public Guna.UI2.WinForms.Guna2Transition Transition;
    public Guna.UI2.WinForms.Guna2TaskBarProgress taskBarProgress;
    private Sipaa.Framework.SPanel splash_Panel;
    private Guna.UI2.WinForms.Guna2ProgressBar prgMiniProgress;
    public Label lblCurrentState;
}