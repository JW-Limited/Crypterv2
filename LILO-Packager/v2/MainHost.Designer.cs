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
        Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainHost));
        hider = new Sipaa.Framework.SPanel();
        bntAccount = new Guna.UI2.WinForms.Guna2Button();
        guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
        bntOpen = new Guna.UI2.WinForms.Guna2Button();
        sPanel1 = new Sipaa.Framework.SPanel();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        lblText = new Label();
        bntChoose_File = new Guna.UI2.WinForms.Guna2Button();
        guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
        pnlChild = new Panel();
        hider.SuspendLayout();
        sPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // hider
        // 
        hider.BackColor = Color.Gainsboro;
        hider.BorderColor = Color.Black;
        hider.BorderRadius = 0;
        hider.BorderSize = 0;
        hider.Controls.Add(bntAccount);
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
        bntAccount.MouseLeave += bntAccount_MouseLeave;
        bntAccount.MouseHover += guna2Button6_MouseHover;
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
        guna2Button1.Location = new Point(200, 16);
        guna2Button1.Margin = new Padding(2);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.Size = new Size(64, 58);
        guna2Button1.TabIndex = 1;
        guna2Button1.Text = "v2";
        guna2Button1.Click += guna2Button1_Click;
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
        lblText.Click += lblText_Click;
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
        animation2.AnimateOnlyDifferences = true;
        animation2.BlindCoeff = (PointF)resources.GetObject("animation2.BlindCoeff");
        animation2.LeafCoeff = 0F;
        animation2.MaxTime = 1F;
        animation2.MinTime = 0F;
        animation2.MosaicCoeff = (PointF)resources.GetObject("animation2.MosaicCoeff");
        animation2.MosaicShift = (PointF)resources.GetObject("animation2.MosaicShift");
        animation2.MosaicSize = 0;
        animation2.Padding = new Padding(0);
        animation2.RotateCoeff = 0F;
        animation2.RotateLimit = 0F;
        animation2.ScaleCoeff = (PointF)resources.GetObject("animation2.ScaleCoeff");
        animation2.SlideCoeff = (PointF)resources.GetObject("animation2.SlideCoeff");
        animation2.TimeCoeff = 0F;
        animation2.TransparencyCoeff = 1F;
        guna2Transition1.DefaultAnimation = animation2;
        guna2Transition1.Interval = 1;
        // 
        // pnlChild
        // 
        guna2Transition1.SetDecoration(pnlChild, Guna.UI2.AnimatorNS.DecorationType.None);
        pnlChild.Dock = DockStyle.Fill;
        pnlChild.Location = new Point(336, 0);
        pnlChild.Margin = new Padding(2);
        pnlChild.Name = "pnlChild";
        pnlChild.Size = new Size(1250, 1055);
        pnlChild.TabIndex = 15;
        // 
        // MainHost
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1586, 1055);
        Controls.Add(pnlChild);
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
}