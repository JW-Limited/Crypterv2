namespace LILO_Packager.v2.streaming.MusikPlayer.Forms
{
    partial class uiPlayerDynamic
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
            lblArtist = new Label();
            pnlCover_Blurred = new Guna.UI2.WinForms.Guna2Panel();
            bntCollapse = new Guna.UI2.WinForms.Guna2Button();
            bntBack = new Guna.UI2.WinForms.Guna2Button();
            pnlCover = new Guna.UI2.WinForms.Guna2Panel();
            lblError = new Label();
            lblTrack = new Label();
            trackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            bntPause = new Guna.UI2.WinForms.Guna2Button();
            bntPlay = new Guna.UI2.WinForms.Guna2Button();
            lblAllTime = new Label();
            lblCurrentTIme = new Label();
            pnlSplashScreen = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            imgImage = new Guna.UI2.WinForms.Guna2Panel();
            progTurner = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            pnlCover_Blurred.SuspendLayout();
            pnlSplashScreen.SuspendLayout();
            SuspendLayout();
            // 
            // lblArtist
            // 
            lblArtist.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblArtist.AutoEllipsis = true;
            lblArtist.BackColor = Color.Transparent;
            lblArtist.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblArtist.ForeColor = Color.Black;
            lblArtist.Location = new Point(16, 680);
            lblArtist.Margin = new Padding(4, 0, 4, 0);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(296, 40);
            lblArtist.TabIndex = 29;
            lblArtist.Text = "ARTIST";
            lblArtist.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlCover_Blurred
            // 
            pnlCover_Blurred.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCover_Blurred.BackColor = Color.White;
            pnlCover_Blurred.BackgroundImageLayout = ImageLayout.Stretch;
            pnlCover_Blurred.BorderColor = SystemColors.ActiveBorder;
            pnlCover_Blurred.BorderRadius = 15;
            pnlCover_Blurred.Controls.Add(bntCollapse);
            pnlCover_Blurred.Controls.Add(bntBack);
            pnlCover_Blurred.Controls.Add(pnlCover);
            pnlCover_Blurred.Controls.Add(lblError);
            pnlCover_Blurred.FillColor = Color.Transparent;
            pnlCover_Blurred.Location = new Point(0, 0);
            pnlCover_Blurred.Margin = new Padding(2);
            pnlCover_Blurred.Name = "pnlCover_Blurred";
            pnlCover_Blurred.Size = new Size(984, 584);
            pnlCover_Blurred.TabIndex = 28;
            // 
            // bntCollapse
            // 
            bntCollapse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntCollapse.Animated = true;
            bntCollapse.BackColor = Color.Transparent;
            bntCollapse.BorderRadius = 15;
            bntCollapse.DisabledState.BorderColor = Color.DarkGray;
            bntCollapse.DisabledState.CustomBorderColor = Color.DarkGray;
            bntCollapse.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntCollapse.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntCollapse.FillColor = Color.White;
            bntCollapse.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bntCollapse.ForeColor = Color.White;
            bntCollapse.Image = Properties.Resources.icons8_expand_arrow_96;
            bntCollapse.ImageSize = new Size(25, 25);
            bntCollapse.Location = new Point(890, 24);
            bntCollapse.Margin = new Padding(2);
            bntCollapse.Name = "bntCollapse";
            bntCollapse.ShadowDecoration.BorderRadius = 15;
            bntCollapse.ShadowDecoration.Color = Color.DarkGray;
            bntCollapse.ShadowDecoration.Depth = 10;
            bntCollapse.ShadowDecoration.Enabled = true;
            bntCollapse.ShadowDecoration.Shadow = new Padding(7);
            bntCollapse.Size = new Size(64, 40);
            bntCollapse.TabIndex = 32;
            bntCollapse.Visible = false;
            bntCollapse.Click += bntCollapse_CLICK;
            // 
            // bntBack
            // 
            bntBack.Animated = true;
            bntBack.BackColor = Color.Transparent;
            bntBack.BorderColor = Color.Gainsboro;
            bntBack.BorderRadius = 12;
            bntBack.BorderThickness = 2;
            bntBack.DisabledState.BorderColor = Color.DarkGray;
            bntBack.DisabledState.CustomBorderColor = Color.DarkGray;
            bntBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntBack.FillColor = Color.White;
            bntBack.FocusedColor = Color.FromArgb(100, 170, 209);
            bntBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bntBack.ForeColor = Color.Black;
            bntBack.Image = Properties.Resources.icons8_back_96;
            bntBack.ImageAlign = HorizontalAlignment.Left;
            bntBack.Location = new Point(24, 24);
            bntBack.Margin = new Padding(2);
            bntBack.Name = "bntBack";
            bntBack.ShadowDecoration.BorderRadius = 20;
            bntBack.ShadowDecoration.Color = Color.DarkGray;
            bntBack.ShadowDecoration.Depth = 10;
            bntBack.ShadowDecoration.Enabled = true;
            bntBack.ShadowDecoration.Shadow = new Padding(7);
            bntBack.Size = new Size(104, 40);
            bntBack.TabIndex = 30;
            bntBack.Text = "   Back";
            bntBack.Click += bntBack_Click;
            // 
            // pnlCover
            // 
            pnlCover.Anchor = AnchorStyles.None;
            pnlCover.BackColor = Color.Transparent;
            pnlCover.BackgroundImage = Properties.Resources.image_removebg_preview__2_;
            pnlCover.BackgroundImageLayout = ImageLayout.Stretch;
            pnlCover.BorderColor = SystemColors.ActiveCaptionText;
            pnlCover.BorderRadius = 20;
            pnlCover.FillColor = Color.Transparent;
            pnlCover.Location = new Point(336, 112);
            pnlCover.Margin = new Padding(2);
            pnlCover.Name = "pnlCover";
            pnlCover.ShadowDecoration.Color = Color.DarkGray;
            pnlCover.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            pnlCover.ShadowDecoration.Depth = 50;
            pnlCover.ShadowDecoration.Enabled = true;
            pnlCover.Size = new Size(320, 320);
            pnlCover.TabIndex = 11;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.Black;
            lblError.Location = new Point(136, 24);
            lblError.Margin = new Padding(4, 0, 4, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(734, 40);
            lblError.TabIndex = 29;
            lblError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTrack
            // 
            lblTrack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTrack.AutoEllipsis = true;
            lblTrack.BackColor = Color.Transparent;
            lblTrack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTrack.ForeColor = Color.Black;
            lblTrack.Location = new Point(16, 648);
            lblTrack.Margin = new Padding(4, 0, 4, 0);
            lblTrack.Name = "lblTrack";
            lblTrack.Size = new Size(296, 40);
            lblTrack.TabIndex = 29;
            lblTrack.Text = "TITLE";
            lblTrack.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trackBar
            // 
            trackBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trackBar.LargeChange = 1;
            trackBar.Location = new Point(80, 600);
            trackBar.Margin = new Padding(2);
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(824, 40);
            trackBar.TabIndex = 30;
            trackBar.ThumbColor = Color.FromArgb(94, 148, 255);
            // 
            // bntPause
            // 
            bntPause.Anchor = AnchorStyles.Bottom;
            bntPause.Animated = true;
            bntPause.BackColor = Color.Transparent;
            bntPause.BorderRadius = 15;
            bntPause.DisabledState.BorderColor = Color.DarkGray;
            bntPause.DisabledState.CustomBorderColor = Color.DarkGray;
            bntPause.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntPause.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntPause.FillColor = Color.White;
            bntPause.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bntPause.ForeColor = Color.White;
            bntPause.Image = Properties.Resources.icons8_pause_button_96;
            bntPause.ImageSize = new Size(55, 55);
            bntPause.Location = new Point(448, 648);
            bntPause.Margin = new Padding(2);
            bntPause.Name = "bntPause";
            bntPause.Size = new Size(88, 72);
            bntPause.TabIndex = 31;
            bntPause.Visible = false;
            bntPause.Click += btnStop_Click;
            // 
            // bntPlay
            // 
            bntPlay.Anchor = AnchorStyles.Bottom;
            bntPlay.Animated = true;
            bntPlay.BackColor = Color.Transparent;
            bntPlay.BorderRadius = 15;
            bntPlay.DisabledState.BorderColor = Color.DarkGray;
            bntPlay.DisabledState.CustomBorderColor = Color.DarkGray;
            bntPlay.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntPlay.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntPlay.Enabled = false;
            bntPlay.FillColor = Color.White;
            bntPlay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bntPlay.ForeColor = Color.White;
            bntPlay.Image = Properties.Resources.icons8_circled_play_96;
            bntPlay.ImageSize = new Size(55, 55);
            bntPlay.Location = new Point(456, 648);
            bntPlay.Margin = new Padding(2);
            bntPlay.Name = "bntPlay";
            bntPlay.Size = new Size(72, 72);
            bntPlay.TabIndex = 32;
            bntPlay.Click += btnPlay_Click;
            // 
            // lblAllTime
            // 
            lblAllTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblAllTime.BackColor = Color.Transparent;
            lblAllTime.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAllTime.ForeColor = SystemColors.AppWorkspace;
            lblAllTime.Location = new Point(904, 600);
            lblAllTime.Margin = new Padding(2, 0, 2, 0);
            lblAllTime.Name = "lblAllTime";
            lblAllTime.Size = new Size(61, 40);
            lblAllTime.TabIndex = 33;
            lblAllTime.Text = "00:00";
            lblAllTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentTIme
            // 
            lblCurrentTIme.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCurrentTIme.BackColor = Color.Transparent;
            lblCurrentTIme.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentTIme.ForeColor = SystemColors.AppWorkspace;
            lblCurrentTIme.Location = new Point(16, 600);
            lblCurrentTIme.Margin = new Padding(2, 0, 2, 0);
            lblCurrentTIme.Name = "lblCurrentTIme";
            lblCurrentTIme.Size = new Size(61, 40);
            lblCurrentTIme.TabIndex = 34;
            lblCurrentTIme.Text = "00:00";
            lblCurrentTIme.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSplashScreen
            // 
            pnlSplashScreen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSplashScreen.BackColor = Color.White;
            pnlSplashScreen.BorderColor = SystemColors.ActiveBorder;
            pnlSplashScreen.BorderRadius = 15;
            pnlSplashScreen.Controls.Add(label1);
            pnlSplashScreen.Controls.Add(imgImage);
            pnlSplashScreen.Controls.Add(progTurner);
            pnlSplashScreen.Controls.Add(guna2Panel1);
            pnlSplashScreen.FillColor = Color.Transparent;
            pnlSplashScreen.Location = new Point(0, 0);
            pnlSplashScreen.Margin = new Padding(2);
            pnlSplashScreen.Name = "pnlSplashScreen";
            pnlSplashScreen.Size = new Size(984, 754);
            pnlSplashScreen.TabIndex = 31;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(388, 666);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 40);
            label1.TabIndex = 32;
            label1.Text = "JW Limited ©️ 2023";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            imgImage.Location = new Point(461, 293);
            imgImage.Margin = new Padding(2);
            imgImage.Name = "imgImage";
            imgImage.ShadowDecoration.BorderRadius = 100;
            imgImage.ShadowDecoration.Color = Color.DarkGray;
            imgImage.ShadowDecoration.Depth = 60;
            imgImage.ShadowDecoration.Enabled = true;
            imgImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            imgImage.ShadowDecoration.Shadow = new Padding(7);
            imgImage.Size = new Size(56, 56);
            imgImage.TabIndex = 31;
            imgImage.Visible = false;
            // 
            // progTurner
            // 
            progTurner.Anchor = AnchorStyles.None;
            progTurner.AutoStart = true;
            progTurner.BackColor = Color.Transparent;
            progTurner.Location = new Point(412, 246);
            progTurner.Margin = new Padding(2);
            progTurner.Name = "progTurner";
            progTurner.Size = new Size(160, 152);
            progTurner.TabIndex = 30;
            progTurner.UseTransparentBackground = true;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.None;
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BackgroundImage = Properties.Resources.image_removebg_preview__2_;
            guna2Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2Panel1.BorderColor = SystemColors.ActiveCaptionText;
            guna2Panel1.BorderRadius = 30;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(381, 206);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.BorderRadius = 30;
            guna2Panel1.ShadowDecoration.Color = Color.DarkGray;
            guna2Panel1.ShadowDecoration.Depth = 10;
            guna2Panel1.ShadowDecoration.Enabled = true;
            guna2Panel1.ShadowDecoration.Shadow = new Padding(7);
            guna2Panel1.Size = new Size(216, 224);
            guna2Panel1.TabIndex = 42;
            // 
            // uiPlayerDynamic
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 752);
            Controls.Add(pnlSplashScreen);
            Controls.Add(lblAllTime);
            Controls.Add(lblCurrentTIme);
            Controls.Add(bntPause);
            Controls.Add(bntPlay);
            Controls.Add(trackBar);
            Controls.Add(lblTrack);
            Controls.Add(lblArtist);
            Controls.Add(pnlCover_Blurred);
            Margin = new Padding(2);
            MinimumSize = new Size(1000, 797);
            Name = "uiPlayerDynamic";
            Text = "uiPlayerDynamic";
            Load += uiPlayerDynamic_Load;
            pnlCover_Blurred.ResumeLayout(false);
            pnlSplashScreen.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblArtist;
        private Guna.UI2.WinForms.Guna2TrackBar trackBar;
        private Guna.UI2.WinForms.Guna2Panel pnlCover_Blurred;
        private Guna.UI2.WinForms.Guna2Panel pnlCover;
        private Label lblTrack;
        private Label lblError;
        private Guna.UI2.WinForms.Guna2Button bntPause;
        private Guna.UI2.WinForms.Guna2Button bntPlay;
        public Label lblAllTime;
        public Label lblCurrentTIme;
        private Guna.UI2.WinForms.Guna2Button bntBack;
        private Guna.UI2.WinForms.Guna2Panel pnlSplashScreen;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel imgImage;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator progTurner;
        private Guna.UI2.WinForms.Guna2Button bntCollapse;
        private Guna.UI2.WinForms.Guna2Button bntCollapse_1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}