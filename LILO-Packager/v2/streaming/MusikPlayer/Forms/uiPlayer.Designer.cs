using Guna.UI2.WinForms;

namespace LILO_Packager.v2.streaming.MusikPlayer.Forms;

partial class uiPlayer
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiPlayer));
        lblCurrentTIme = new Label();
        lblArtist = new Label();
        lblTitle = new Label();
        bntPlay = new Guna2Button();
        bntPause = new Guna2Button();
        sPanel6 = new Sipaa.Framework.SPanel();
        pnlSplash = new Sipaa.Framework.SPanel();
        imgImage = new Guna2Panel();
        progTurner = new Guna2WinProgressIndicator();
        lblLoading = new Label();
        tmWaiter = new System.Windows.Forms.Timer(components);
        progressBar = new Guna2ProgressBar();
        lblAllTime = new Label();
        lblMoreInfo = new Label();
        timeSlider = new HTAlt.WinForms.HTSlider();
        pnlSplash.SuspendLayout();
        SuspendLayout();
        // 
        // lblCurrentTIme
        // 
        lblCurrentTIme.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblCurrentTIme.BackColor = Color.Transparent;
        lblCurrentTIme.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblCurrentTIme.ForeColor = SystemColors.AppWorkspace;
        lblCurrentTIme.Location = new Point(83, 600);
        lblCurrentTIme.Name = "lblCurrentTIme";
        lblCurrentTIme.Size = new Size(61, 32);
        lblCurrentTIme.TabIndex = 6;
        lblCurrentTIme.Text = "00:00";
        lblCurrentTIme.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblArtist
        // 
        lblArtist.BackColor = Color.Transparent;
        lblArtist.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
        lblArtist.ForeColor = Color.White;
        lblArtist.Location = new Point(66, 209);
        lblArtist.Name = "lblArtist";
        lblArtist.Size = new Size(459, 71);
        lblArtist.TabIndex = 4;
        lblArtist.Text = "titleInformation";
        // 
        // lblTitle
        // 
        lblTitle.AutoEllipsis = true;
        lblTitle.BackColor = Color.Transparent;
        lblTitle.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(64, 136);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(461, 34);
        lblTitle.TabIndex = 5;
        lblTitle.Text = "musicTitle";
        // 
        // bntPlay
        // 
        bntPlay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        bntPlay.Animated = true;
        bntPlay.BackColor = Color.Transparent;
        bntPlay.BorderRadius = 15;
        bntPlay.DisabledState.BorderColor = Color.DarkGray;
        bntPlay.DisabledState.CustomBorderColor = Color.DarkGray;
        bntPlay.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntPlay.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntPlay.FillColor = Color.MediumSlateBlue;
        bntPlay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        bntPlay.ForeColor = Color.White;
        bntPlay.Location = new Point(83, 680);
        bntPlay.Name = "bntPlay";
        bntPlay.Size = new Size(145, 48);
        bntPlay.TabIndex = 7;
        bntPlay.Text = "Play";
        bntPlay.Click += btnPlay_Click;
        // 
        // bntPause
        // 
        bntPause.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        bntPause.Animated = true;
        bntPause.BackColor = Color.Transparent;
        bntPause.BorderRadius = 15;
        bntPause.DisabledState.BorderColor = Color.DarkGray;
        bntPause.DisabledState.CustomBorderColor = Color.DarkGray;
        bntPause.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        bntPause.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        bntPause.FillColor = Color.MediumSlateBlue;
        bntPause.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        bntPause.ForeColor = Color.White;
        bntPause.Location = new Point(272, 680);
        bntPause.Name = "bntPause";
        bntPause.Size = new Size(145, 48);
        bntPause.TabIndex = 7;
        bntPause.Text = "Pause";
        bntPause.Click += btnStop_Click;
        // 
        // sPanel6
        // 
        sPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        sPanel6.BackColor = Color.FromArgb(30, 30, 30);
        sPanel6.BackgroundImageLayout = ImageLayout.Stretch;
        sPanel6.BorderColor = Color.PaleVioletRed;
        sPanel6.BorderRadius = 14;
        sPanel6.BorderSize = 0;
        sPanel6.ForeColor = Color.White;
        sPanel6.Location = new Point(624, 72);
        sPanel6.Margin = new Padding(2);
        sPanel6.Name = "sPanel6";
        sPanel6.Size = new Size(322, 320);
        sPanel6.TabIndex = 8;
        // 
        // pnlSplash
        // 
        pnlSplash.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlSplash.BackColor = Color.Black;
        pnlSplash.BackgroundImageLayout = ImageLayout.Zoom;
        pnlSplash.BorderColor = Color.PaleVioletRed;
        pnlSplash.BorderRadius = 14;
        pnlSplash.BorderSize = 0;
        pnlSplash.Controls.Add(imgImage);
        pnlSplash.Controls.Add(progTurner);
        pnlSplash.Controls.Add(lblLoading);
        pnlSplash.ForeColor = Color.White;
        pnlSplash.Location = new Point(0, 0);
        pnlSplash.Margin = new Padding(2);
        pnlSplash.Name = "pnlSplash";
        pnlSplash.Size = new Size(1003, 784);
        pnlSplash.TabIndex = 9;
        // 
        // imgImage
        // 
        imgImage.Anchor = AnchorStyles.None;
        imgImage.BackColor = Color.Transparent;
        imgImage.BackgroundImage = Properties.Resources.favico;
        imgImage.BackgroundImageLayout = ImageLayout.Zoom;
        imgImage.BorderColor = SystemColors.ActiveBorder;
        imgImage.BorderRadius = 15;
        imgImage.FillColor = Color.Transparent;
        imgImage.Location = new Point(472, 296);
        imgImage.Margin = new Padding(2);
        imgImage.Name = "imgImage";
        imgImage.Size = new Size(56, 56);
        imgImage.TabIndex = 12;
        // 
        // progTurner
        // 
        progTurner.Anchor = AnchorStyles.None;
        progTurner.AutoStart = true;
        progTurner.BackColor = Color.Transparent;
        progTurner.Location = new Point(424, 248);
        progTurner.Name = "progTurner";
        progTurner.Size = new Size(160, 152);
        progTurner.TabIndex = 6;
        progTurner.UseTransparentBackground = true;
        // 
        // lblLoading
        // 
        lblLoading.Anchor = AnchorStyles.None;
        lblLoading.BackColor = Color.Transparent;
        lblLoading.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
        lblLoading.ForeColor = Color.White;
        lblLoading.Location = new Point(416, 482);
        lblLoading.Name = "lblLoading";
        lblLoading.Size = new Size(168, 34);
        lblLoading.TabIndex = 5;
        lblLoading.Text = "Loading...";
        lblLoading.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tmWaiter
        // 
        tmWaiter.Enabled = true;
        tmWaiter.Interval = 500;
        tmWaiter.Tick += tmWaiter_Hits;
        // 
        // progressBar
        // 
        progressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        progressBar.BackColor = Color.Transparent;
        progressBar.BorderColor = Color.Silver;
        progressBar.BorderRadius = 10;
        progressBar.BorderThickness = 2;
        progressBar.FillColor = Color.Black;
        progressBar.ForeColor = Color.Transparent;
        progressBar.Location = new Point(152, 608);
        progressBar.Margin = new Padding(2);
        progressBar.Name = "progressBar";
        progressBar.ProgressColor = Color.LightCoral;
        progressBar.ProgressColor2 = Color.MediumSlateBlue;
        progressBar.Size = new Size(704, 24);
        progressBar.TabIndex = 11;
        progressBar.Text = "guna2ProgressBar1";
        progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
        // 
        // lblAllTime
        // 
        lblAllTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblAllTime.BackColor = Color.Transparent;
        lblAllTime.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblAllTime.ForeColor = SystemColors.AppWorkspace;
        lblAllTime.Location = new Point(872, 600);
        lblAllTime.Name = "lblAllTime";
        lblAllTime.Size = new Size(61, 32);
        lblAllTime.TabIndex = 6;
        lblAllTime.Text = "00:00";
        lblAllTime.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblMoreInfo
        // 
        lblMoreInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblMoreInfo.BackColor = Color.Transparent;
        lblMoreInfo.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
        lblMoreInfo.ForeColor = Color.White;
        lblMoreInfo.Location = new Point(448, 680);
        lblMoreInfo.Name = "lblMoreInfo";
        lblMoreInfo.Size = new Size(456, 48);
        lblMoreInfo.TabIndex = 4;
        lblMoreInfo.Text = "titleInformation";
        lblMoreInfo.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // timeSlider
        // 
        timeSlider.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        timeSlider.BackColor = Color.Transparent;
        timeSlider.BorderRoundRectSize = new Size(16, 16);
        timeSlider.DrawSemitransparentThumb = false;
        timeSlider.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point);
        timeSlider.ForeColor = Color.White;
        timeSlider.LargeChange = 5U;
        timeSlider.Location = new Point(152, 576);
        timeSlider.Name = "timeSlider";
        timeSlider.OverlayColor = Color.FromArgb(20, 157, 204);
        timeSlider.Size = new Size(704, 80);
        timeSlider.SmallChange = 1U;
        timeSlider.TabIndex = 12;
        timeSlider.Text = "htSlider1";
        timeSlider.ThumbRoundRectSize = new Size(16, 16);
        timeSlider.ThumbSize = new Size(16, 16);
        // 
        // uiPlayer
        // 
        AcceptButton = bntPlay;
        AllowDrop = true;
        BackColor = SystemColors.ActiveCaptionText;
        BackgroundImageLayout = ImageLayout.Stretch;
        CancelButton = bntPause;
        ClientSize = new Size(1003, 783);
        Controls.Add(pnlSplash);
        Controls.Add(timeSlider);
        Controls.Add(sPanel6);
        Controls.Add(bntPause);
        Controls.Add(bntPlay);
        Controls.Add(lblAllTime);
        Controls.Add(lblCurrentTIme);
        Controls.Add(lblMoreInfo);
        Controls.Add(lblArtist);
        Controls.Add(lblTitle);
        Controls.Add(progressBar);
        Icon = (Icon)resources.GetObject("$this.Icon");
        KeyPreview = true;
        MaximizeBox = false;
        MinimizeBox = false;
        MinimumSize = new Size(1000, 800);
        Name = "uiPlayer";
        Text = "Player";
        Load += Player_Load_1;
        pnlSplash.ResumeLayout(false);
        ResumeLayout(false);
    }

    public Sipaa.Framework.SPanel sPanel6;
    public Label lblCurrentTIme;
    public Sipaa.Framework.SPanel pnlSplash;
    private Guna2WinProgressIndicator progTurner;
    private Label lblLoading;
    private System.Windows.Forms.Timer tmWaiter;
    private Guna2Button bntPlay;
    private Guna2Button bntPause;
    private Label lblArtist;
    private Label lblTitle;
    private Guna2Panel imgImage;
    private Guna2ProgressBar progressBar;
    public Label lblAllTime;
    private Label lblMoreInfo;
    private HTAlt.WinForms.HTSlider timeSlider;
}
#endregion