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
        Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainHost));
        hider = new Sipaa.Framework.SPanel();
        bntAccount = new Guna.UI2.WinForms.Guna2Button();
        bntMenu_c = new Guna.UI2.WinForms.Guna2Button();
        guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
        bntOpen = new Guna.UI2.WinForms.Guna2Button();
        sPanel1 = new Sipaa.Framework.SPanel();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        lblText = new Label();
        pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
        guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
        bntChoose_File = new Guna.UI2.WinForms.Guna2Button();
        guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
        pnlChild = new Panel();
        pnlSide = new Sipaa.Framework.SPanel();
        pnlNotifications = new Panel();
        pnlMes1 = new Guna.UI2.WinForms.Guna2Panel();
        Mes1_Message = new Label();
        Mes1_bnt = new Guna.UI2.WinForms.Guna2Button();
        Mes1_Title = new Label();
        guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
        label1 = new Label();
        label2 = new Label();
        guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
        bntCloseSideBoard = new Guna.UI2.WinForms.Guna2Button();
        pnlNothing = new Sipaa.Framework.SPanel();
        lblMessage = new Label();
        sPanel3 = new Sipaa.Framework.SPanel();
        pnlLoading = new Panel();
        progressSpinner = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
        hider.SuspendLayout();
        sPanel1.SuspendLayout();
        pnlMenu.SuspendLayout();
        pnlChild.SuspendLayout();
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
        hider.Controls.Add(bntMenu_c);
        hider.Controls.Add(guna2Button2);
        hider.Controls.Add(guna2Button5);
        hider.Controls.Add(guna2Button4);
        hider.Controls.Add(guna2Button3);
        hider.Controls.Add(bntOpen);
        hider.Controls.Add(sPanel1);
        guna2Transition1.SetDecoration(hider, Guna.UI2.AnimatorNS.DecorationType.None);
        hider.Dock = DockStyle.Left;
        hider.ForeColor = Color.White;
        hider.Location = new Point(0, 0);
        hider.Margin = new Padding(4);
        hider.Name = "hider";
        hider.Size = new Size(336, 1055);
        hider.TabIndex = 10;
        // 
        // bntAccount
        // 
        bntAccount.Anchor = AnchorStyles.Bottom;
        bntAccount.Animated = true;
        bntAccount.BorderColor = Color.Gainsboro;
        bntAccount.BorderRadius = 20;
        bntAccount.BorderThickness = 2;
        guna2Transition1.SetDecoration(bntAccount, Guna.UI2.AnimatorNS.DecorationType.None);
        bntAccount.DisabledState.BorderColor = Color.DarkGray;
        bntAccount.DisabledState.CustomBorderColor = Color.DarkGray;
        bntAccount.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntAccount.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntAccount.FillColor = Color.Empty;
        bntAccount.FocusedColor = Color.FromArgb(100, 170, 209);
        bntAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        bntAccount.ForeColor = Color.Black;
        bntAccount.Image = Properties.Resources.icons8_male_user_96;
        bntAccount.ImageAlign = HorizontalAlignment.Left;
        bntAccount.ImageOffset = new Point(15, 0);
        bntAccount.ImageSize = new Size(40, 40);
        bntAccount.Location = new Point(24, 946);
        bntAccount.Margin = new Padding(2);
        bntAccount.Name = "bntAccount";
        bntAccount.Size = new Size(272, 80);
        bntAccount.TabIndex = 15;
        bntAccount.Text = "    Account";
        bntAccount.TextAlign = HorizontalAlignment.Left;
        bntAccount.Click += guna2Button6_Click;
        bntAccount.DoubleClick += bntAccount_DoubleClick;
        bntAccount.MouseLeave += bntAccount_MouseLeave;
        bntAccount.MouseHover += guna2Button6_MouseHover;
        // 
        // bntMenu_c
        // 
        bntMenu_c.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        bntMenu_c.Animated = true;
        bntMenu_c.BackColor = Color.Transparent;
        bntMenu_c.BorderColor = Color.Transparent;
        bntMenu_c.BorderRadius = 16;
        bntMenu_c.CheckedState.BorderColor = Color.Transparent;
        guna2Transition1.SetDecoration(bntMenu_c, Guna.UI2.AnimatorNS.DecorationType.None);
        bntMenu_c.DisabledState.BorderColor = Color.DarkGray;
        bntMenu_c.DisabledState.CustomBorderColor = Color.DarkGray;
        bntMenu_c.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntMenu_c.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntMenu_c.FillColor = Color.Transparent;
        bntMenu_c.FocusedColor = Color.FromArgb(100, 170, 209);
        bntMenu_c.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        bntMenu_c.ForeColor = Color.White;
        bntMenu_c.Image = Properties.Resources.icons8_menu_240__1_;
        bntMenu_c.ImageSize = new Size(40, 40);
        bntMenu_c.Location = new Point(224, 960);
        bntMenu_c.Margin = new Padding(2);
        bntMenu_c.Name = "bntMenu_c";
        bntMenu_c.Size = new Size(56, 56);
        bntMenu_c.TabIndex = 1;
        bntMenu_c.Click += bntMenu;
        // 
        // guna2Button2
        // 
        guna2Button2.Anchor = AnchorStyles.None;
        guna2Button2.Animated = true;
        guna2Button2.BorderColor = Color.Gainsboro;
        guna2Button2.BorderRadius = 20;
        guna2Button2.BorderThickness = 2;
        guna2Transition1.SetDecoration(guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button2.DisabledState.BorderColor = Color.DarkGray;
        guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button2.FillColor = Color.Empty;
        guna2Button2.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button2.ForeColor = Color.Black;
        guna2Button2.Image = Properties.Resources.icons8_bursts_96;
        guna2Button2.ImageAlign = HorizontalAlignment.Left;
        guna2Button2.ImageOffset = new Point(15, 0);
        guna2Button2.ImageSize = new Size(40, 40);
        guna2Button2.Location = new Point(24, 595);
        guna2Button2.Margin = new Padding(2);
        guna2Button2.Name = "guna2Button2";
        guna2Button2.Size = new Size(272, 80);
        guna2Button2.TabIndex = 15;
        guna2Button2.Text = "    Plugins";
        guna2Button2.TextAlign = HorizontalAlignment.Left;
        guna2Button2.Click += bntPlugin_Clicked;
        // 
        // guna2Button5
        // 
        guna2Button5.Anchor = AnchorStyles.None;
        guna2Button5.Animated = true;
        guna2Button5.BorderColor = Color.Gainsboro;
        guna2Button5.BorderRadius = 20;
        guna2Button5.BorderThickness = 2;
        guna2Transition1.SetDecoration(guna2Button5, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button5.DisabledState.BorderColor = Color.DarkGray;
        guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button5.FillColor = Color.Empty;
        guna2Button5.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button5.ForeColor = Color.Black;
        guna2Button5.Image = Properties.Resources.Info;
        guna2Button5.ImageAlign = HorizontalAlignment.Left;
        guna2Button5.ImageOffset = new Point(15, 0);
        guna2Button5.ImageSize = new Size(40, 40);
        guna2Button5.Location = new Point(24, 691);
        guna2Button5.Margin = new Padding(2);
        guna2Button5.Name = "guna2Button5";
        guna2Button5.Size = new Size(272, 80);
        guna2Button5.TabIndex = 15;
        guna2Button5.Text = "    Help";
        guna2Button5.TextAlign = HorizontalAlignment.Left;
        guna2Button5.Click += guna2Button5_Click;
        // 
        // guna2Button4
        // 
        guna2Button4.Anchor = AnchorStyles.None;
        guna2Button4.Animated = true;
        guna2Button4.BorderColor = Color.Gainsboro;
        guna2Button4.BorderRadius = 20;
        guna2Button4.BorderThickness = 2;
        guna2Transition1.SetDecoration(guna2Button4, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button4.DisabledState.BorderColor = Color.DarkGray;
        guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button4.FillColor = Color.Empty;
        guna2Button4.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button4.ForeColor = Color.Black;
        guna2Button4.Image = Properties.Resources.Bookmark;
        guna2Button4.ImageAlign = HorizontalAlignment.Left;
        guna2Button4.ImageOffset = new Point(15, 0);
        guna2Button4.ImageSize = new Size(40, 40);
        guna2Button4.Location = new Point(24, 496);
        guna2Button4.Margin = new Padding(2);
        guna2Button4.Name = "guna2Button4";
        guna2Button4.Size = new Size(272, 80);
        guna2Button4.TabIndex = 15;
        guna2Button4.Text = "    History";
        guna2Button4.TextAlign = HorizontalAlignment.Left;
        guna2Button4.Click += guna2Button4_Click;
        // 
        // guna2Button3
        // 
        guna2Button3.Anchor = AnchorStyles.None;
        guna2Button3.Animated = true;
        guna2Button3.BorderColor = Color.Gainsboro;
        guna2Button3.BorderRadius = 20;
        guna2Button3.BorderThickness = 2;
        guna2Transition1.SetDecoration(guna2Button3, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button3.DisabledState.BorderColor = Color.DarkGray;
        guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button3.FillColor = Color.Empty;
        guna2Button3.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button3.ForeColor = Color.Black;
        guna2Button3.Image = Properties.Resources.Padlock;
        guna2Button3.ImageAlign = HorizontalAlignment.Left;
        guna2Button3.ImageOffset = new Point(15, 0);
        guna2Button3.ImageSize = new Size(40, 40);
        guna2Button3.Location = new Point(24, 401);
        guna2Button3.Margin = new Padding(2);
        guna2Button3.Name = "guna2Button3";
        guna2Button3.Size = new Size(272, 80);
        guna2Button3.TabIndex = 15;
        guna2Button3.Text = "    Decrypt";
        guna2Button3.TextAlign = HorizontalAlignment.Left;
        guna2Button3.Click += guna2Button3_Click;
        // 
        // bntOpen
        // 
        bntOpen.Anchor = AnchorStyles.None;
        bntOpen.Animated = true;
        bntOpen.BorderColor = Color.Gainsboro;
        bntOpen.BorderRadius = 20;
        bntOpen.BorderThickness = 2;
        guna2Transition1.SetDecoration(bntOpen, Guna.UI2.AnimatorNS.DecorationType.None);
        bntOpen.DisabledState.BorderColor = Color.DarkGray;
        bntOpen.DisabledState.CustomBorderColor = Color.DarkGray;
        bntOpen.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntOpen.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntOpen.FillColor = Color.Empty;
        bntOpen.FocusedColor = Color.FromArgb(100, 170, 209);
        bntOpen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        bntOpen.ForeColor = Color.Black;
        bntOpen.Image = Properties.Resources.Lock;
        bntOpen.ImageAlign = HorizontalAlignment.Left;
        bntOpen.ImageOffset = new Point(15, 0);
        bntOpen.ImageSize = new Size(40, 40);
        bntOpen.Location = new Point(24, 305);
        bntOpen.Margin = new Padding(2);
        bntOpen.Name = "bntOpen";
        bntOpen.Size = new Size(272, 80);
        bntOpen.TabIndex = 15;
        bntOpen.Text = "    Encrypt";
        bntOpen.TextAlign = HorizontalAlignment.Left;
        bntOpen.Click += bntOpen_Click;
        // 
        // sPanel1
        // 
        sPanel1.BackColor = Color.Black;
        sPanel1.BackgroundImage = Properties.Resources.Aqua_Marine;
        sPanel1.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel1.BorderColor = Color.Black;
        sPanel1.BorderRadius = 20;
        sPanel1.BorderSize = 0;
        sPanel1.Controls.Add(guna2Button1);
        sPanel1.Controls.Add(lblText);
        guna2Transition1.SetDecoration(sPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
        sPanel1.ForeColor = Color.White;
        sPanel1.Location = new Point(24, 32);
        sPanel1.Margin = new Padding(4);
        sPanel1.Name = "sPanel1";
        sPanel1.Size = new Size(288, 88);
        sPanel1.TabIndex = 9;
        sPanel1.Paint += sPanel1_Paint;
        // 
        // guna2Button1
        // 
        guna2Button1.Animated = true;
        guna2Button1.BackColor = Color.Transparent;
        guna2Button1.BorderColor = Color.Gainsboro;
        guna2Button1.BorderRadius = 20;
        guna2Button1.BorderThickness = 2;
        guna2Transition1.SetDecoration(guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button1.DisabledState.BorderColor = Color.DarkGray;
        guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button1.FillColor = Color.Transparent;
        guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button1.ForeColor = Color.White;
        guna2Button1.ImageSize = new Size(40, 40);
        guna2Button1.Location = new Point(200, 16);
        guna2Button1.Margin = new Padding(2);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.Size = new Size(64, 58);
        guna2Button1.TabIndex = 1;
        guna2Button1.Text = "v2";
        guna2Button1.Click += lblText_Click;
        // 
        // lblText
        // 
        lblText.BackColor = Color.Transparent;
        guna2Transition1.SetDecoration(lblText, Guna.UI2.AnimatorNS.DecorationType.None);
        lblText.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        lblText.ForeColor = Color.White;
        lblText.Location = new Point(24, 0);
        lblText.Margin = new Padding(4, 0, 4, 0);
        lblText.Name = "lblText";
        lblText.Size = new Size(144, 88);
        lblText.TabIndex = 1;
        lblText.Text = "Crypter ";
        lblText.TextAlign = ContentAlignment.MiddleCenter;
        lblText.Click += guna2Button1_Click;
        // 
        // pnlMenu
        // 
        pnlMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        pnlMenu.BorderColor = SystemColors.ButtonFace;
        pnlMenu.BorderRadius = 15;
        pnlMenu.BorderThickness = 2;
        pnlMenu.Controls.Add(guna2Button10);
        pnlMenu.Controls.Add(guna2Button9);
        guna2Transition1.SetDecoration(pnlMenu, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlMenu.FillColor = Color.White;
        pnlMenu.Location = new Point(24, 872);
        pnlMenu.Margin = new Padding(2);
        pnlMenu.Name = "pnlMenu";
        pnlMenu.Size = new Size(272, 152);
        pnlMenu.TabIndex = 4;
        pnlMenu.Visible = false;
        // 
        // guna2Button10
        // 
        guna2Button10.Animated = true;
        guna2Button10.BackColor = Color.Transparent;
        guna2Button10.BackgroundImageLayout = ImageLayout.Zoom;
        guna2Button10.BorderColor = Color.Gainsboro;
        guna2Button10.BorderRadius = 10;
        guna2Button10.BorderThickness = 2;
        guna2Transition1.SetDecoration(guna2Button10, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button10.DisabledState.BorderColor = Color.DarkGray;
        guna2Button10.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button10.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button10.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button10.FillColor = Color.Transparent;
        guna2Button10.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button10.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button10.ForeColor = Color.Black;
        guna2Button10.ImageAlign = HorizontalAlignment.Left;
        guna2Button10.ImageSize = new Size(35, 35);
        guna2Button10.Location = new Point(16, 24);
        guna2Button10.Margin = new Padding(2);
        guna2Button10.Name = "guna2Button10";
        guna2Button10.Size = new Size(240, 48);
        guna2Button10.TabIndex = 17;
        guna2Button10.Text = "Developer App";
        guna2Button10.Click += bntOpenDevApp;
        // 
        // guna2Button9
        // 
        guna2Button9.Animated = true;
        guna2Button9.BackColor = Color.Transparent;
        guna2Button9.BackgroundImageLayout = ImageLayout.Zoom;
        guna2Button9.BorderColor = Color.Gainsboro;
        guna2Button9.BorderRadius = 10;
        guna2Button9.BorderThickness = 2;
        guna2Transition1.SetDecoration(guna2Button9, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button9.DisabledState.BorderColor = Color.DarkGray;
        guna2Button9.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button9.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button9.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button9.FillColor = Color.Transparent;
        guna2Button9.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button9.ForeColor = Color.Black;
        guna2Button9.ImageAlign = HorizontalAlignment.Left;
        guna2Button9.ImageSize = new Size(35, 35);
        guna2Button9.Location = new Point(16, 88);
        guna2Button9.Margin = new Padding(2);
        guna2Button9.Name = "guna2Button9";
        guna2Button9.Size = new Size(240, 48);
        guna2Button9.TabIndex = 17;
        guna2Button9.Text = "About";
        guna2Button9.Click += bntOpenAboutPage;
        // 
        // bntChoose_File
        // 
        bntChoose_File.Animated = true;
        bntChoose_File.BorderRadius = 17;
        bntChoose_File.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        guna2Transition1.SetDecoration(bntChoose_File, Guna.UI2.AnimatorNS.DecorationType.None);
        bntChoose_File.DisabledState.BorderColor = Color.DarkGray;
        bntChoose_File.DisabledState.CustomBorderColor = Color.DarkGray;
        bntChoose_File.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntChoose_File.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntChoose_File.FillColor = Color.DarkGray;
        bntChoose_File.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        bntChoose_File.ForeColor = Color.White;
        bntChoose_File.Location = new Point(704, 144);
        bntChoose_File.Margin = new Padding(2);
        bntChoose_File.Name = "bntChoose_File";
        bntChoose_File.Size = new Size(0, 0);
        bntChoose_File.TabIndex = 14;
        bntChoose_File.Text = "Datein Auswählen";
        // 
        // guna2Transition1
        // 
        guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Custom;
        guna2Transition1.Cursor = null;
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
        guna2Transition1.DefaultAnimation = animation1;
        guna2Transition1.Interval = 1;
        // 
        // pnlChild
        // 
        pnlChild.Controls.Add(pnlMenu);
        guna2Transition1.SetDecoration(pnlChild, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlChild.Dock = DockStyle.Fill;
        pnlChild.Location = new Point(336, 0);
        pnlChild.Margin = new Padding(2);
        pnlChild.Name = "pnlChild";
        pnlChild.Size = new Size(922, 1055);
        pnlChild.TabIndex = 15;
        // 
        // pnlSide
        // 
        pnlSide.BackColor = Color.White;
        pnlSide.BackgroundImageLayout = ImageLayout.Stretch;
        pnlSide.BorderColor = Color.DimGray;
        pnlSide.BorderRadius = 0;
        pnlSide.BorderSize = 1;
        pnlSide.Controls.Add(pnlNotifications);
        pnlSide.Controls.Add(guna2Button6);
        pnlSide.Controls.Add(label1);
        pnlSide.Controls.Add(label2);
        pnlSide.Controls.Add(guna2Button7);
        pnlSide.Controls.Add(bntCloseSideBoard);
        pnlSide.Controls.Add(pnlNothing);
        pnlSide.Controls.Add(pnlLoading);
        guna2Transition1.SetDecoration(pnlSide, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlSide.Dock = DockStyle.Right;
        pnlSide.ForeColor = Color.White;
        pnlSide.Location = new Point(1258, 0);
        pnlSide.Margin = new Padding(4);
        pnlSide.Name = "pnlSide";
        pnlSide.Size = new Size(328, 1055);
        pnlSide.TabIndex = 16;
        pnlSide.Visible = false;
        // 
        // pnlNotifications
        // 
        pnlNotifications.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlNotifications.BackColor = Color.White;
        pnlNotifications.Controls.Add(pnlMes1);
        guna2Transition1.SetDecoration(pnlNotifications, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlNotifications.Location = new Point(8, 72);
        pnlNotifications.Name = "pnlNotifications";
        pnlNotifications.Size = new Size(312, 904);
        pnlNotifications.TabIndex = 18;
        pnlNotifications.Visible = false;
        // 
        // pnlMes1
        // 
        pnlMes1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pnlMes1.BorderColor = SystemColors.ButtonFace;
        pnlMes1.BorderRadius = 15;
        pnlMes1.BorderThickness = 2;
        pnlMes1.Controls.Add(Mes1_Message);
        pnlMes1.Controls.Add(Mes1_bnt);
        pnlMes1.Controls.Add(Mes1_Title);
        guna2Transition1.SetDecoration(pnlMes1, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlMes1.FillColor = Color.White;
        pnlMes1.Location = new Point(8, 24);
        pnlMes1.Margin = new Padding(2);
        pnlMes1.Name = "pnlMes1";
        pnlMes1.Size = new Size(296, 272);
        pnlMes1.TabIndex = 4;
        pnlMes1.Visible = false;
        // 
        // Mes1_Message
        // 
        Mes1_Message.BackColor = Color.Transparent;
        guna2Transition1.SetDecoration(Mes1_Message, Guna.UI2.AnimatorNS.DecorationType.None);
        Mes1_Message.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        Mes1_Message.ForeColor = Color.DimGray;
        Mes1_Message.Location = new Point(24, 64);
        Mes1_Message.Margin = new Padding(4, 0, 4, 0);
        Mes1_Message.Name = "Mes1_Message";
        Mes1_Message.Size = new Size(248, 136);
        Mes1_Message.TabIndex = 1;
        Mes1_Message.Text = "n/a";
        // 
        // Mes1_bnt
        // 
        Mes1_bnt.Animated = true;
        Mes1_bnt.BackColor = Color.Transparent;
        Mes1_bnt.BackgroundImageLayout = ImageLayout.Zoom;
        Mes1_bnt.BorderColor = Color.Gainsboro;
        Mes1_bnt.BorderRadius = 10;
        Mes1_bnt.BorderThickness = 2;
        guna2Transition1.SetDecoration(Mes1_bnt, Guna.UI2.AnimatorNS.DecorationType.None);
        Mes1_bnt.DisabledState.BorderColor = Color.DarkGray;
        Mes1_bnt.DisabledState.CustomBorderColor = Color.DarkGray;
        Mes1_bnt.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        Mes1_bnt.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        Mes1_bnt.FillColor = Color.Transparent;
        Mes1_bnt.FocusedColor = Color.FromArgb(100, 170, 209);
        Mes1_bnt.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        Mes1_bnt.ForeColor = Color.Black;
        Mes1_bnt.ImageAlign = HorizontalAlignment.Left;
        Mes1_bnt.ImageSize = new Size(35, 35);
        Mes1_bnt.Location = new Point(24, 208);
        Mes1_bnt.Margin = new Padding(2);
        Mes1_bnt.Name = "Mes1_bnt";
        Mes1_bnt.Size = new Size(248, 40);
        Mes1_bnt.TabIndex = 17;
        Mes1_bnt.Text = "n/a";
        Mes1_bnt.Click += bntUpdate;
        // 
        // Mes1_Title
        // 
        Mes1_Title.BackColor = Color.Transparent;
        guna2Transition1.SetDecoration(Mes1_Title, Guna.UI2.AnimatorNS.DecorationType.None);
        Mes1_Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        Mes1_Title.ForeColor = Color.Black;
        Mes1_Title.Location = new Point(24, 16);
        Mes1_Title.Margin = new Padding(4, 0, 4, 0);
        Mes1_Title.Name = "Mes1_Title";
        Mes1_Title.Size = new Size(176, 48);
        Mes1_Title.TabIndex = 1;
        Mes1_Title.Text = "n/a";
        Mes1_Title.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Button6
        // 
        guna2Button6.Animated = true;
        guna2Button6.BackColor = Color.Transparent;
        guna2Button6.BackgroundImageLayout = ImageLayout.Zoom;
        guna2Button6.BorderColor = Color.Gainsboro;
        guna2Button6.BorderRadius = 10;
        guna2Button6.BorderThickness = 2;
        guna2Transition1.SetDecoration(guna2Button6, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button6.DisabledState.BorderColor = Color.DarkGray;
        guna2Button6.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button6.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button6.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button6.FillColor = Color.Transparent;
        guna2Button6.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button6.ForeColor = Color.Black;
        guna2Button6.ImageAlign = HorizontalAlignment.Left;
        guna2Button6.ImageSize = new Size(35, 35);
        guna2Button6.Location = new Point(16, 16);
        guna2Button6.Margin = new Padding(2);
        guna2Button6.Name = "guna2Button6";
        guna2Button6.Size = new Size(184, 48);
        guna2Button6.TabIndex = 17;
        guna2Button6.Text = " Notifications";
        guna2Button6.TextAlign = HorizontalAlignment.Left;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        label1.BackColor = Color.Transparent;
        guna2Transition1.SetDecoration(label1, Guna.UI2.AnimatorNS.DecorationType.None);
        label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
        label1.ForeColor = Color.Gray;
        label1.Location = new Point(24, 975);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(288, 32);
        label1.TabIndex = 2;
        label1.Text = "powered by ";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        label2.BackColor = Color.Transparent;
        guna2Transition1.SetDecoration(label2, Guna.UI2.AnimatorNS.DecorationType.None);
        label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label2.ForeColor = Color.Black;
        label2.Location = new Point(24, 999);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(288, 40);
        label2.TabIndex = 3;
        label2.Text = "LILO Sync ";
        label2.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // guna2Button7
        // 
        guna2Button7.Animated = true;
        guna2Button7.BackColor = Color.Transparent;
        guna2Button7.BorderColor = Color.Gainsboro;
        guna2Button7.BorderRadius = 10;
        guna2Button7.BorderThickness = 2;
        guna2Transition1.SetDecoration(guna2Button7, Guna.UI2.AnimatorNS.DecorationType.None);
        guna2Button7.DisabledState.BorderColor = Color.DarkGray;
        guna2Button7.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button7.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button7.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button7.FillColor = Color.Transparent;
        guna2Button7.FocusedColor = Color.FromArgb(100, 170, 209);
        guna2Button7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        guna2Button7.ForeColor = Color.White;
        guna2Button7.Image = Properties.Resources.icons8_synchronize_240;
        guna2Button7.ImageSize = new Size(30, 30);
        guna2Button7.Location = new Point(208, 16);
        guna2Button7.Margin = new Padding(2);
        guna2Button7.Name = "guna2Button7";
        guna2Button7.Size = new Size(48, 48);
        guna2Button7.TabIndex = 1;
        guna2Button7.Click += guna2Button6_Click_1;
        // 
        // bntCloseSideBoard
        // 
        bntCloseSideBoard.Animated = true;
        bntCloseSideBoard.BackColor = Color.Transparent;
        bntCloseSideBoard.BorderColor = Color.Gainsboro;
        bntCloseSideBoard.BorderRadius = 10;
        bntCloseSideBoard.BorderThickness = 2;
        guna2Transition1.SetDecoration(bntCloseSideBoard, Guna.UI2.AnimatorNS.DecorationType.None);
        bntCloseSideBoard.DisabledState.BorderColor = Color.DarkGray;
        bntCloseSideBoard.DisabledState.CustomBorderColor = Color.DarkGray;
        bntCloseSideBoard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntCloseSideBoard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntCloseSideBoard.FillColor = Color.Transparent;
        bntCloseSideBoard.FocusedColor = Color.FromArgb(100, 170, 209);
        bntCloseSideBoard.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        bntCloseSideBoard.ForeColor = Color.White;
        bntCloseSideBoard.Image = Properties.Resources.Close;
        bntCloseSideBoard.ImageSize = new Size(25, 25);
        bntCloseSideBoard.Location = new Point(264, 16);
        bntCloseSideBoard.Margin = new Padding(2);
        bntCloseSideBoard.Name = "bntCloseSideBoard";
        bntCloseSideBoard.Size = new Size(48, 48);
        bntCloseSideBoard.TabIndex = 1;
        bntCloseSideBoard.Click += bntCloseSideBoard_Click;
        // 
        // pnlNothing
        // 
        pnlNothing.Anchor = AnchorStyles.None;
        pnlNothing.BackColor = Color.White;
        pnlNothing.BackgroundImageLayout = ImageLayout.Stretch;
        pnlNothing.BorderColor = Color.Black;
        pnlNothing.BorderRadius = 20;
        pnlNothing.BorderSize = 0;
        pnlNothing.Controls.Add(lblMessage);
        pnlNothing.Controls.Add(sPanel3);
        guna2Transition1.SetDecoration(pnlNothing, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlNothing.ForeColor = Color.White;
        pnlNothing.Location = new Point(16, 376);
        pnlNothing.Margin = new Padding(4);
        pnlNothing.Name = "pnlNothing";
        pnlNothing.Size = new Size(296, 288);
        pnlNothing.TabIndex = 9;
        pnlNothing.Paint += sPanel1_Paint;
        // 
        // lblMessage
        // 
        lblMessage.BackColor = Color.Transparent;
        guna2Transition1.SetDecoration(lblMessage, Guna.UI2.AnimatorNS.DecorationType.None);
        lblMessage.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        lblMessage.ForeColor = Color.DimGray;
        lblMessage.Location = new Point(24, 184);
        lblMessage.Margin = new Padding(4, 0, 4, 0);
        lblMessage.Name = "lblMessage";
        lblMessage.Size = new Size(248, 56);
        lblMessage.TabIndex = 1;
        lblMessage.Text = "Nothing to Display";
        lblMessage.TextAlign = ContentAlignment.MiddleCenter;
        lblMessage.Click += lblText_Click;
        // 
        // sPanel3
        // 
        sPanel3.BackColor = Color.White;
        sPanel3.BackgroundImage = Properties.Resources.nothing;
        sPanel3.BackgroundImageLayout = ImageLayout.Zoom;
        sPanel3.BorderColor = Color.Black;
        sPanel3.BorderRadius = 20;
        sPanel3.BorderSize = 0;
        guna2Transition1.SetDecoration(sPanel3, Guna.UI2.AnimatorNS.DecorationType.None);
        sPanel3.ForeColor = Color.White;
        sPanel3.Location = new Point(56, 40);
        sPanel3.Margin = new Padding(4);
        sPanel3.Name = "sPanel3";
        sPanel3.Size = new Size(176, 128);
        sPanel3.TabIndex = 9;
        sPanel3.Paint += sPanel1_Paint;
        // 
        // pnlLoading
        // 
        pnlLoading.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlLoading.BackColor = Color.White;
        pnlLoading.Controls.Add(progressSpinner);
        guna2Transition1.SetDecoration(pnlLoading, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlLoading.Location = new Point(16, 96);
        pnlLoading.Name = "pnlLoading";
        pnlLoading.Size = new Size(296, 880);
        pnlLoading.TabIndex = 18;
        pnlLoading.Visible = false;
        // 
        // progressSpinner
        // 
        progressSpinner.Anchor = AnchorStyles.None;
        progressSpinner.AutoStart = true;
        progressSpinner.BackColor = Color.White;
        guna2Transition1.SetDecoration(progressSpinner, Guna.UI2.AnimatorNS.DecorationType.None);
        progressSpinner.Location = new Point(80, 364);
        progressSpinner.Name = "progressSpinner";
        progressSpinner.Size = new Size(135, 143);
        progressSpinner.TabIndex = 8;
        // 
        // MainHost
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1586, 1055);
        Controls.Add(pnlChild);
        Controls.Add(pnlSide);
        Controls.Add(hider);
        Controls.Add(bntChoose_File);
        guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
        HelpButton = true;
        Icon = (Icon)resources.GetObject("$this.Icon");
        IsMdiContainer = true;
        Margin = new Padding(2);
        MinimumSize = new Size(1400, 1057);
        Name = "MainHost";
        Text = "MainHost";
        Load += MainHost_Load;
        hider.ResumeLayout(false);
        sPanel1.ResumeLayout(false);
        pnlMenu.ResumeLayout(false);
        pnlChild.ResumeLayout(false);
        pnlSide.ResumeLayout(false);
        pnlNotifications.ResumeLayout(false);
        pnlMes1.ResumeLayout(false);
        pnlNothing.ResumeLayout(false);
        pnlLoading.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Sipaa.Framework.SPanel hider;
    private Sipaa.Framework.SPanel sPanel1;
    private Guna.UI2.WinForms.Guna2Button bntChoose_File;
    private Guna.UI2.WinForms.Guna2Button guna2Button5;
    private Guna.UI2.WinForms.Guna2Button guna2Button4;
    private Guna.UI2.WinForms.Guna2Button guna2Button3;
    private Guna.UI2.WinForms.Guna2Button bntOpen;
    private Guna.UI2.WinForms.Guna2Button bntAccount;
    private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
    private Label lblText;
    private Panel pnlChild;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
    private Guna.UI2.WinForms.Guna2Button guna2Button2;
    private Sipaa.Framework.SPanel pnlSide;
    private Guna.UI2.WinForms.Guna2Button bntCloseSideBoard;
    private Label label1;
    private Label label2;
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
}