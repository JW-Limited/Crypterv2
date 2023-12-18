namespace LILO_Packager.v2.Forms;

partial class uiLILOAccountLogin
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiLILOAccountLogin));
        FormManger = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
        sPanel2 = new Sipaa.Framework.SPanel();
        label1 = new Label();
        conClose = new Guna.UI2.WinForms.Guna2ControlBox();
        sPanel1 = new Sipaa.Framework.SPanel();
        sPanel4 = new Sipaa.Framework.SPanel();
        txtUsr = new Sipaa.Framework.STextBox();
        txtPsw = new Sipaa.Framework.STextBox();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        pnlTop = new Sipaa.Framework.SPanel();
        showPsw = new Guna.UI2.WinForms.Guna2Button();
        Drager = new Guna.UI2.WinForms.Guna2DragControl(components);
        pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
        pnlLoginLoad = new Guna.UI2.WinForms.Guna2Panel();
        progressSpinner = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
        label5 = new Label();
        bntLogin = new Guna.UI2.WinForms.Guna2Button();
        guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
        sPanel1.SuspendLayout();
        pnlTop.SuspendLayout();
        pnlPreview.SuspendLayout();
        pnlLoginLoad.SuspendLayout();
        guna2Panel1.SuspendLayout();
        SuspendLayout();
        // 
        // FormManger
        // 
        FormManger.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_POSITIVE;
        FormManger.BorderRadius = 20;
        FormManger.ContainerControl = this;
        FormManger.DockForm = false;
        FormManger.DockIndicatorTransparencyValue = 0.6D;
        FormManger.DragStartTransparencyValue = 1D;
        FormManger.ResizeForm = false;
        FormManger.ShadowColor = Color.White;
        FormManger.TransparentWhileDrag = true;
        // 
        // sPanel2
        // 
        sPanel2.BackColor = Color.Transparent;
        sPanel2.BackgroundImage = Properties.Resources.favico;
        sPanel2.BackgroundImageLayout = ImageLayout.Zoom;
        sPanel2.BorderColor = Color.PaleVioletRed;
        sPanel2.BorderRadius = 6;
        sPanel2.BorderSize = 0;
        sPanel2.ForeColor = Color.White;
        sPanel2.Location = new Point(332, 20);
        sPanel2.Margin = new Padding(4);
        sPanel2.Name = "sPanel2";
        sPanel2.Size = new Size(48, 46);
        sPanel2.TabIndex = 7;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
        label1.ForeColor = SystemColors.Control;
        label1.Location = new Point(392, 28);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(123, 30);
        label1.TabIndex = 6;
        label1.Text = "JW Limited";
        // 
        // conClose
        // 
        conClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        conClose.BackColor = Color.Transparent;
        conClose.BorderColor = Color.FromArgb(10, 10, 10);
        conClose.BorderRadius = 15;
        conClose.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
        conClose.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
        conClose.CustomIconSize = 11F;
        conClose.FillColor = Color.FromArgb(10, 10, 10);
        conClose.ForeColor = Color.FromArgb(10, 10, 10);
        conClose.HoverState.FillColor = Color.Black;
        conClose.HoverState.IconColor = Color.Silver;
        conClose.IconColor = Color.White;
        conClose.Location = new Point(792, 9);
        conClose.Margin = new Padding(4);
        conClose.Name = "conClose";
        conClose.PressedColor = Color.FromArgb(10, 10, 10);
        conClose.ShadowDecoration.Color = Color.FromArgb(10, 10, 10);
        conClose.ShadowDecoration.Enabled = true;
        conClose.Size = new Size(70, 39);
        conClose.TabIndex = 13;
        conClose.UseTransparentBackground = true;
        // 
        // sPanel1
        // 
        sPanel1.BackColor = Color.FromArgb(23, 23, 23);
        sPanel1.BorderColor = Color.PaleVioletRed;
        sPanel1.BorderRadius = 6;
        sPanel1.BorderSize = 0;
        sPanel1.Controls.Add(sPanel2);
        sPanel1.Controls.Add(label1);
        sPanel1.Dock = DockStyle.Bottom;
        sPanel1.ForeColor = Color.White;
        sPanel1.Location = new Point(0, 729);
        sPanel1.Margin = new Padding(2);
        sPanel1.Name = "sPanel1";
        sPanel1.Size = new Size(881, 82);
        sPanel1.TabIndex = 12;
        // 
        // sPanel4
        // 
        sPanel4.BackColor = Color.FromArgb(17, 17, 17);
        sPanel4.BackgroundImage = (Image)resources.GetObject("sPanel4.BackgroundImage");
        sPanel4.BackgroundImageLayout = ImageLayout.Zoom;
        sPanel4.BorderColor = Color.PaleVioletRed;
        sPanel4.BorderRadius = 10;
        sPanel4.BorderSize = 0;
        sPanel4.ForeColor = Color.White;
        sPanel4.Location = new Point(19, 15);
        sPanel4.Margin = new Padding(4);
        sPanel4.Name = "sPanel4";
        sPanel4.Size = new Size(101, 31);
        sPanel4.TabIndex = 4;
        // 
        // txtUsr
        // 
        txtUsr.BackColor = Color.FromArgb(224, 224, 224);
        txtUsr.BorderColor = Color.Silver;
        txtUsr.BorderFocusColor = Color.DimGray;
        txtUsr.BorderRadius = 20;
        txtUsr.BorderSize = 1;
        txtUsr.Font = new Font("Century Gothic", 12F);
        txtUsr.ForeColor = Color.Black;
        txtUsr.Location = new Point(64, 109);
        txtUsr.Margin = new Padding(5);
        txtUsr.Multiline = false;
        txtUsr.Name = "txtUsr";
        txtUsr.Padding = new Padding(12, 9, 12, 9);
        txtUsr.PasswordChar = false;
        txtUsr.PlaceholderColor = Color.DarkGray;
        txtUsr.PlaceholderText = "";
        txtUsr.Size = new Size(398, 49);
        txtUsr.TabIndex = 15;
        txtUsr.Texts = "";
        txtUsr.UnderlinedStyle = false;
        // 
        // txtPsw
        // 
        txtPsw.BackColor = Color.FromArgb(224, 224, 224);
        txtPsw.BorderColor = Color.Silver;
        txtPsw.BorderFocusColor = Color.DimGray;
        txtPsw.BorderRadius = 20;
        txtPsw.BorderSize = 1;
        txtPsw.Font = new Font("Century Gothic", 12F);
        txtPsw.ForeColor = Color.Black;
        txtPsw.Location = new Point(64, 227);
        txtPsw.Margin = new Padding(5);
        txtPsw.Multiline = false;
        txtPsw.Name = "txtPsw";
        txtPsw.Padding = new Padding(12, 9, 12, 9);
        txtPsw.PasswordChar = true;
        txtPsw.PlaceholderColor = Color.DarkGray;
        txtPsw.PlaceholderText = "";
        txtPsw.Size = new Size(398, 49);
        txtPsw.TabIndex = 15;
        txtPsw.Texts = "";
        txtPsw.UnderlinedStyle = false;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.BackColor = Color.White;
        label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
        label2.ForeColor = SystemColors.ActiveCaptionText;
        label2.Location = new Point(72, 71);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(130, 25);
        label2.TabIndex = 17;
        label2.Text = "Name / E-Mail";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.BackColor = Color.White;
        label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
        label3.ForeColor = SystemColors.ActiveCaptionText;
        label3.Location = new Point(72, 191);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(86, 25);
        label3.TabIndex = 17;
        label3.Text = "Passwort";
        // 
        // label4
        // 
        label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        label4.ForeColor = SystemColors.Control;
        label4.Location = new Point(120, 0);
        label4.Margin = new Padding(2, 0, 2, 0);
        label4.Name = "label4";
        label4.Size = new Size(128, 64);
        label4.TabIndex = 17;
        label4.Text = "Authorization";
        label4.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlTop
        // 
        pnlTop.BackColor = Color.FromArgb(17, 17, 17);
        pnlTop.BorderColor = Color.PaleVioletRed;
        pnlTop.BorderRadius = 6;
        pnlTop.BorderSize = 0;
        pnlTop.Controls.Add(sPanel4);
        pnlTop.Controls.Add(conClose);
        pnlTop.Controls.Add(label4);
        pnlTop.Dock = DockStyle.Top;
        pnlTop.ForeColor = Color.White;
        pnlTop.Location = new Point(0, 0);
        pnlTop.Margin = new Padding(2);
        pnlTop.Name = "pnlTop";
        pnlTop.Size = new Size(881, 60);
        pnlTop.TabIndex = 19;
        // 
        // showPsw
        // 
        showPsw.Animated = true;
        showPsw.BackColor = Color.Transparent;
        showPsw.BorderColor = Color.FromArgb(224, 224, 224);
        showPsw.BorderRadius = 15;
        showPsw.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
        showPsw.CheckedState.Image = (Image)resources.GetObject("resource.Image");
        showPsw.DisabledState.BorderColor = Color.DarkGray;
        showPsw.DisabledState.CustomBorderColor = Color.DarkGray;
        showPsw.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        showPsw.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        showPsw.FillColor = Color.Transparent;
        showPsw.Font = new Font("Segoe UI", 9F);
        showPsw.ForeColor = Color.White;
        showPsw.Image = (Image)resources.GetObject("showPsw.Image");
        showPsw.Location = new Point(416, 232);
        showPsw.Margin = new Padding(4);
        showPsw.Name = "showPsw";
        showPsw.PressedColor = Color.DarkGray;
        showPsw.Size = new Size(38, 40);
        showPsw.TabIndex = 18;
        showPsw.UseTransparentBackground = true;
        showPsw.Click += pswVisible_Click;
        // 
        // Drager
        // 
        Drager.DockIndicatorTransparencyValue = 0.6D;
        Drager.DragStartTransparencyValue = 1D;
        Drager.TargetControl = pnlTop;
        Drager.UseTransparentDrag = true;
        // 
        // pnlPreview
        // 
        pnlPreview.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        pnlPreview.BackColor = Color.Transparent;
        pnlPreview.BorderColor = Color.Silver;
        pnlPreview.BorderRadius = 15;
        pnlPreview.BorderThickness = 2;
        pnlPreview.Controls.Add(pnlLoginLoad);
        pnlPreview.Controls.Add(bntLogin);
        pnlPreview.Controls.Add(showPsw);
        pnlPreview.Controls.Add(label2);
        pnlPreview.Controls.Add(txtPsw);
        pnlPreview.Controls.Add(label3);
        pnlPreview.Controls.Add(txtUsr);
        pnlPreview.FillColor = Color.White;
        pnlPreview.Location = new Point(184, 184);
        pnlPreview.Margin = new Padding(2);
        pnlPreview.Name = "pnlPreview";
        pnlPreview.Size = new Size(512, 432);
        pnlPreview.TabIndex = 15;
        // 
        // pnlLoginLoad
        // 
        pnlLoginLoad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        pnlLoginLoad.BackColor = Color.Transparent;
        pnlLoginLoad.BorderColor = Color.Silver;
        pnlLoginLoad.BorderRadius = 15;
        pnlLoginLoad.BorderThickness = 2;
        pnlLoginLoad.Controls.Add(progressSpinner);
        pnlLoginLoad.Controls.Add(label5);
        pnlLoginLoad.FillColor = Color.White;
        pnlLoginLoad.Location = new Point(0, 0);
        pnlLoginLoad.Margin = new Padding(2);
        pnlLoginLoad.Name = "pnlLoginLoad";
        pnlLoginLoad.Size = new Size(512, 432);
        pnlLoginLoad.TabIndex = 15;
        pnlLoginLoad.Visible = false;
        // 
        // progressSpinner
        // 
        progressSpinner.Anchor = AnchorStyles.None;
        progressSpinner.AutoStart = true;
        progressSpinner.BackColor = Color.White;
        progressSpinner.Location = new Point(189, 128);
        progressSpinner.Name = "progressSpinner";
        progressSpinner.Size = new Size(135, 135);
        progressSpinner.TabIndex = 8;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
        label5.ForeColor = SystemColors.ActiveCaptionText;
        label5.Location = new Point(184, 296);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(147, 30);
        label5.TabIndex = 6;
        label5.Text = "Anmeldung...";
        // 
        // bntLogin
        // 
        bntLogin.Animated = true;
        bntLogin.BackColor = Color.Transparent;
        bntLogin.BorderColor = Color.FromArgb(94, 148, 255);
        bntLogin.BorderRadius = 15;
        bntLogin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
        bntLogin.DisabledState.BorderColor = Color.DarkGray;
        bntLogin.DisabledState.CustomBorderColor = Color.DarkGray;
        bntLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntLogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        bntLogin.ForeColor = Color.White;
        bntLogin.Location = new Point(64, 328);
        bntLogin.Margin = new Padding(4);
        bntLogin.Name = "bntLogin";
        bntLogin.PressedColor = Color.DarkGray;
        bntLogin.Size = new Size(400, 48);
        bntLogin.TabIndex = 18;
        bntLogin.Text = "Anmeldung";
        bntLogin.UseTransparentBackground = true;
        bntLogin.Click += bntLogin_Click;
        // 
        // guna2Panel1
        // 
        guna2Panel1.BackgroundImage = Properties.Resources.pexels_johannes_plenio_1103970;
        guna2Panel1.BackgroundImageLayout = ImageLayout.Stretch;
        guna2Panel1.BorderColor = SystemColors.ActiveBorder;
        guna2Panel1.BorderRadius = 15;
        guna2Panel1.BorderThickness = 2;
        guna2Panel1.Controls.Add(pnlPreview);
        guna2Panel1.Dock = DockStyle.Fill;
        guna2Panel1.Location = new Point(0, 0);
        guna2Panel1.Margin = new Padding(2);
        guna2Panel1.Name = "guna2Panel1";
        guna2Panel1.Size = new Size(881, 811);
        guna2Panel1.TabIndex = 15;
        guna2Panel1.Paint += guna2Panel1_Paint;
        // 
        // uiLILOAccountLogin
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(881, 811);
        Controls.Add(pnlTop);
        Controls.Add(sPanel1);
        Controls.Add(guna2Panel1);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        MaximumSize = new Size(881, 811);
        MinimumSize = new Size(881, 811);
        Name = "uiLILOAccountLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "MainHost";
        FormClosing += SimplifiedLogin_FormClosing;
        Load += SimplifiedLogin_Load;
        sPanel1.ResumeLayout(false);
        sPanel1.PerformLayout();
        pnlTop.ResumeLayout(false);
        pnlPreview.ResumeLayout(false);
        pnlPreview.PerformLayout();
        pnlLoginLoad.ResumeLayout(false);
        pnlLoginLoad.PerformLayout();
        guna2Panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Guna.UI2.WinForms.Guna2ControlBox conClose;
    private Sipaa.Framework.SPanel sPanel1;
    private Sipaa.Framework.SPanel sPanel2;
    private Label label1;
    private Sipaa.Framework.SPanel sPanel4;
    private Sipaa.Framework.STextBox txtUsr;
    private Sipaa.Framework.SPanel pnlTop;
    private Label label4;
    private Label label3;
    private Label label2;
    private Sipaa.Framework.STextBox txtPsw;
    private Guna.UI2.WinForms.Guna2DragControl Drager;
    public Guna.UI2.WinForms.Guna2BorderlessForm FormManger;
    private Guna.UI2.WinForms.Guna2Button showPsw;
    private Guna.UI2.WinForms.Guna2Panel pnlPreview;
    private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    private Guna.UI2.WinForms.Guna2Button bntLogin;
    private Guna.UI2.WinForms.Guna2Panel pnlLoginLoad;
    private Guna.UI2.WinForms.Guna2WinProgressIndicator progressSpinner;
    private Label label5;
}