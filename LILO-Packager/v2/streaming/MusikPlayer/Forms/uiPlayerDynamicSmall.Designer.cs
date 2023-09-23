namespace LILO_Packager.v2.streaming.MusikPlayer.Forms
{
    partial class uiPlayerDynamicSmall
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
            lblAllTime = new Label();
            lblCurrentTIme = new Label();
            bntPause = new Guna.UI2.WinForms.Guna2Button();
            trackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            lblTrack = new Label();
            lblArtist = new Label();
            pnlCover = new Guna.UI2.WinForms.Guna2Panel();
            bntPlay = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // lblAllTime
            // 
            lblAllTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAllTime.BackColor = Color.Transparent;
            lblAllTime.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAllTime.ForeColor = SystemColors.AppWorkspace;
            lblAllTime.Location = new Point(1160, 8);
            lblAllTime.Name = "lblAllTime";
            lblAllTime.Size = new Size(61, 40);
            lblAllTime.TabIndex = 39;
            lblAllTime.Text = "00:00";
            lblAllTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentTIme
            // 
            lblCurrentTIme.BackColor = Color.Transparent;
            lblCurrentTIme.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentTIme.ForeColor = SystemColors.AppWorkspace;
            lblCurrentTIme.Location = new Point(8, 8);
            lblCurrentTIme.Name = "lblCurrentTIme";
            lblCurrentTIme.Size = new Size(61, 40);
            lblCurrentTIme.TabIndex = 40;
            lblCurrentTIme.Text = "00:00";
            lblCurrentTIme.TextAlign = ContentAlignment.MiddleCenter;
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
            bntPause.Location = new Point(576, 48);
            bntPause.Name = "bntPause";
            bntPause.Size = new Size(88, 72);
            bntPause.TabIndex = 38;
            bntPause.Visible = false;
            // 
            // trackBar
            // 
            trackBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackBar.DisplayFocus = true;
            trackBar.IndicateFocus = true;
            trackBar.Location = new Point(72, 8);
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(1088, 40);
            trackBar.TabIndex = 37;
            trackBar.ThumbColor = Color.FromArgb(94, 148, 255);
            // 
            // lblTrack
            // 
            lblTrack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTrack.AutoEllipsis = true;
            lblTrack.BackColor = Color.Transparent;
            lblTrack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTrack.ForeColor = Color.Black;
            lblTrack.Location = new Point(104, 48);
            lblTrack.Margin = new Padding(4, 0, 4, 0);
            lblTrack.Name = "lblTrack";
            lblTrack.Size = new Size(296, 40);
            lblTrack.TabIndex = 35;
            lblTrack.Text = "TITLE";
            lblTrack.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblArtist
            // 
            lblArtist.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblArtist.AutoEllipsis = true;
            lblArtist.BackColor = Color.Transparent;
            lblArtist.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblArtist.ForeColor = Color.Black;
            lblArtist.Location = new Point(104, 80);
            lblArtist.Margin = new Padding(4, 0, 4, 0);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(296, 40);
            lblArtist.TabIndex = 36;
            lblArtist.Text = "ARTIST";
            lblArtist.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlCover
            // 
            pnlCover.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlCover.BackColor = Color.Transparent;
            pnlCover.BackgroundImage = Properties.Resources.image_removebg_preview__2_;
            pnlCover.BackgroundImageLayout = ImageLayout.Stretch;
            pnlCover.BorderColor = SystemColors.ActiveCaptionText;
            pnlCover.BorderRadius = 20;
            pnlCover.FillColor = Color.Transparent;
            pnlCover.Location = new Point(16, 48);
            pnlCover.Margin = new Padding(2);
            pnlCover.Name = "pnlCover";
            pnlCover.ShadowDecoration.Color = Color.DarkGray;
            pnlCover.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            pnlCover.ShadowDecoration.Depth = 50;
            pnlCover.ShadowDecoration.Enabled = true;
            pnlCover.Size = new Size(72, 72);
            pnlCover.TabIndex = 41;
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
            bntPlay.Location = new Point(584, 48);
            bntPlay.Name = "bntPlay";
            bntPlay.Size = new Size(72, 72);
            bntPlay.TabIndex = 42;
            // 
            // uiPlayerDynamicSmall
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1226, 128);
            Controls.Add(pnlCover);
            Controls.Add(lblAllTime);
            Controls.Add(lblCurrentTIme);
            Controls.Add(bntPause);
            Controls.Add(trackBar);
            Controls.Add(lblTrack);
            Controls.Add(lblArtist);
            Controls.Add(bntPlay);
            Name = "uiPlayerDynamicSmall";
            Text = "uiPlayerDynamicSmall";
            ResumeLayout(false);
        }

        #endregion

        public Label lblAllTime;
        public Label lblCurrentTIme;
        private Guna.UI2.WinForms.Guna2Button bntPause;
        private Guna.UI2.WinForms.Guna2TrackBar trackBar;
        private Label lblTrack;
        private Label lblArtist;
        private Guna.UI2.WinForms.Guna2Panel pnlCover;
        private Guna.UI2.WinForms.Guna2Button bntPlay;
    }
}