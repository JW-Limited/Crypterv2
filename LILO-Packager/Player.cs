using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Diagnostics;
using SharpDX.MediaFoundation;
using LILO.Shell;
using Guna.UI2.WinForms;
using System.Data.SqlClient;

namespace LILO.UI.Forms
{
    public partial class Player : Form
    {
        #region Form Designer

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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            lblCurrentTIme = new System.Windows.Forms.Label();
            lblArtist = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            bntPlay = new Guna2Button();
            bntPause = new Guna2Button();
            sPanel6 = new Sipaa.Framework.SPanel();
            pnlSplash = new Sipaa.Framework.SPanel();
            progTurner = new Guna2WinProgressIndicator();
            lblLoading = new System.Windows.Forms.Label();
            tmWaiter = new System.Windows.Forms.Timer(components);
            pnlSplash.SuspendLayout();
            SuspendLayout();
            // 
            // lblCurrentTIme
            // 
            lblCurrentTIme.BackColor = System.Drawing.Color.Transparent;
            lblCurrentTIme.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentTIme.ForeColor = SystemColors.AppWorkspace;
            lblCurrentTIme.Location = new Point(84, 232);
            lblCurrentTIme.Name = "lblCurrentTIme";
            lblCurrentTIme.Size = new Size(65, 24);
            lblCurrentTIme.TabIndex = 6;
            lblCurrentTIme.Text = "00:00";
            // 
            // lblArtist
            // 
            lblArtist.BackColor = System.Drawing.Color.Transparent;
            lblArtist.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblArtist.ForeColor = System.Drawing.Color.White;
            lblArtist.Location = new Point(84, 137);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(459, 71);
            lblArtist.TabIndex = 4;
            lblArtist.Text = "titleInformation";
            // 
            // lblTitle
            // 
            lblTitle.AutoEllipsis = true;
            lblTitle.BackColor = System.Drawing.Color.Transparent;
            lblTitle.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new Point(82, 64);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(461, 34);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "musicTitle";
            // 
            // bntPlay
            // 
            bntPlay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntPlay.Animated = true;
            bntPlay.BackColor = System.Drawing.Color.Transparent;
            bntPlay.BorderRadius = 15;
            bntPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            bntPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            bntPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            bntPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            bntPlay.FillColor = System.Drawing.Color.MediumSlateBlue;
            bntPlay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bntPlay.ForeColor = System.Drawing.Color.White;
            bntPlay.Location = new Point(84, 302);
            bntPlay.Name = "bntPlay";
            bntPlay.Size = new Size(145, 48);
            bntPlay.TabIndex = 7;
            bntPlay.Text = "Play";
            bntPlay.Click += btnPlay_Click;
            // 
            // bntPause
            // 
            bntPause.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntPause.Animated = true;
            bntPause.BackColor = System.Drawing.Color.Transparent;
            bntPause.BorderRadius = 15;
            bntPause.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            bntPause.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            bntPause.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            bntPause.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            bntPause.FillColor = System.Drawing.Color.MediumSlateBlue;
            bntPause.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bntPause.ForeColor = System.Drawing.Color.White;
            bntPause.Location = new Point(273, 302);
            bntPause.Name = "bntPause";
            bntPause.Size = new Size(145, 48);
            bntPause.TabIndex = 7;
            bntPause.Text = "Pause";
            bntPause.Click += btnStop_Click;
            // 
            // sPanel6
            // 
            sPanel6.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            sPanel6.BackgroundImageLayout = ImageLayout.Zoom;
            sPanel6.BorderColor = System.Drawing.Color.PaleVioletRed;
            sPanel6.BorderRadius = 14;
            sPanel6.BorderSize = 0;
            sPanel6.ForeColor = System.Drawing.Color.White;
            sPanel6.Location = new Point(604, 64);
            sPanel6.Margin = new Padding(2);
            sPanel6.Name = "sPanel6";
            sPanel6.Size = new Size(338, 286);
            sPanel6.TabIndex = 8;
            // 
            // pnlSplash
            // 
            pnlSplash.BackColor = System.Drawing.Color.Black;
            pnlSplash.BackgroundImageLayout = ImageLayout.Zoom;
            pnlSplash.BorderColor = System.Drawing.Color.PaleVioletRed;
            pnlSplash.BorderRadius = 14;
            pnlSplash.BorderSize = 0;
            pnlSplash.Controls.Add(progTurner);
            pnlSplash.Controls.Add(lblLoading);
            pnlSplash.ForeColor = System.Drawing.Color.White;
            pnlSplash.Location = new Point(0, 0);
            pnlSplash.Margin = new Padding(2);
            pnlSplash.Name = "pnlSplash";
            pnlSplash.Size = new Size(1003, 422);
            pnlSplash.TabIndex = 9;
            // 
            // progTurner
            // 
            progTurner.Anchor = AnchorStyles.None;
            progTurner.AutoStart = true;
            progTurner.BackColor = System.Drawing.Color.Transparent;
            progTurner.Location = new Point(434, 76);
            progTurner.Name = "progTurner";
            progTurner.Size = new Size(135, 135);
            progTurner.TabIndex = 6;
            progTurner.UseTransparentBackground = true;
            // 
            // lblLoading
            // 
            lblLoading.Anchor = AnchorStyles.None;
            lblLoading.AutoSize = true;
            lblLoading.BackColor = System.Drawing.Color.Transparent;
            lblLoading.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoading.ForeColor = System.Drawing.Color.White;
            lblLoading.Location = new Point(428, 301);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(148, 34);
            lblLoading.TabIndex = 5;
            lblLoading.Text = "Loading...";
            // 
            // tmWaiter
            // 
            tmWaiter.Enabled = true;
            tmWaiter.Interval = 500;
            tmWaiter.Tick += tmWaiter_Hits;
            // 
            // Player
            // 
            AcceptButton = bntPlay;
            AllowDrop = true;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = bntPause;
            ClientSize = new Size(1003, 422);
            Controls.Add(pnlSplash);
            Controls.Add(sPanel6);
            Controls.Add(bntPause);
            Controls.Add(bntPlay);
            Controls.Add(lblCurrentTIme);
            Controls.Add(lblArtist);
            Controls.Add(lblTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Player";
            Text = "Player";
            Load += Player_Load_1;
            pnlSplash.ResumeLayout(false);
            pnlSplash.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna2Button bntPlay;
        private Guna2Button bntPause;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblTitle;


        #endregion

        #region Variables / Instances

        public Bitmap cover = null;

        public string source = null;
        public string title = null;
        public string artist = null;
        public string id = null;

        public static bool IsPaused = true;
        private static bool isMusicStopped;

        public Thread PlayerThread;


        private static readonly ManualResetEvent eventReadyToPlay = new ManualResetEvent(false);
        public static Stopwatch sw = new Stopwatch();
        public static MediaEngineEx mediaEngineEx;
        private SoundPlayer player;

        #endregion

        public Player(string mediaSource)
        {
            InitializeComponent();

            PlayerThread = new Thread(new ThreadStart(InitPlayer));

            source = mediaSource;

        }

        public string connectionString = "Server=localhost;Database=playlist;Trusted_Connection=True;";

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                Playlist(title + " - " + artist, id);
                ShowPlaylist();

                if (PlayerThread.ThreadState == System.Threading.ThreadState.Suspended) PlayerThread.Resume();
                PlayerThread.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "!ERROR!");
            }
        }

        public void InitPlayer()
        {


            if (string.IsNullOrEmpty(source)) return;
            var ofdLessfileStream = new FileStream(source, FileMode.Open);
            MediaManager.Startup();
            var mediaEngineFactory = new MediaEngineClassFactory();
            var mediaEngine = new MediaEngine(mediaEngineFactory, null, MediaEngineCreateFlags.AudioOnly);

            mediaEngine.PlaybackEvent += OnPlaybackCallback;
            mediaEngineEx = mediaEngine.QueryInterface<MediaEngineEx>();
            var stream = new ByteStream(ofdLessfileStream);
            var url = new Uri(source, UriKind.RelativeOrAbsolute);
            mediaEngineEx.SetSourceFromByteStream(stream, url.AbsoluteUri);
            if (!eventReadyToPlay.WaitOne(1000))
            {
                Console.WriteLine("Unexpected error: Unable to play this file");
            }


            this.Text = String.Format("Player - {0}", title);

            mediaEngineEx.Play();

        }

        public void Playlist(string titleInsert, string id)
        {
            if (!File.Exists(".\\playlist.db"))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand createDatabaseCommand = new SqlCommand(
                        "CREATE DATABASE playlist",
                        connection);

                    createDatabaseCommand.ExecuteNonQuery();
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    SqlCommand createTableCommand = new SqlCommand(
                        "CREATE TABLE PlayedSongs (Id INT, Name NVARCHAR(50))",
                        connection);

                    createTableCommand.ExecuteNonQuery();

                    SqlCommand insertRowCommand = new SqlCommand(
                        $"INSERT INTO PlayedSongs (Id, Name) VALUES ({id}, '{titleInsert}')",
                        connection);
                    insertRowCommand.ExecuteNonQuery();


                }
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand insertRowCommand = new SqlCommand(
                                            $"INSERT INTO PlayedSongs (Id, Name) VALUES ({id}, '{titleInsert}')",
                                            connection);
                    insertRowCommand.ExecuteNonQuery();
                }
            }


        }

        public void ShowPlaylist()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand selectRowsCommand = new SqlCommand(
                "SELECT * FROM MyTable",
                connection);

                using (SqlDataReader reader = selectRowsCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        Console.WriteLine("{0}: {1}", id, name);
                    }
                }
            }
        }

        private void OnPlaybackCallback(MediaEngineEvent playEvent, long param1, int param2)
        {
            Console.Write("PlayBack Event received: {0}", playEvent);
            lblCurrentTIme.Text = String.Format("{0}", TimeSpan.FromMinutes(mediaEngineEx.CurrentTime));

            switch (playEvent)
            {
                case MediaEngineEvent.CanPlay:
                    eventReadyToPlay.Set();
                    break;
                case MediaEngineEvent.TimeUpdate:
                    Console.Write(" {0}", TimeSpan.FromSeconds(mediaEngineEx.CurrentTime));
                    break;
                case MediaEngineEvent.Error:
                    PlayerThread.Suspend();
                    break;
                case MediaEngineEvent.Abort:
                    PlayerThread.Abort();
                    break;
                case MediaEngineEvent.Ended:
                    PlayerThread.Abort();
                    isMusicStopped = true;
                    break;
            }

            Console.WriteLine();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!isMusicStopped)
            {
                mediaEngineEx.Pause();
            }
        }

        public async void LoadAll()
        {
            ImageProcessing.Templates template = new ImageProcessing.Templates(cover);
            ImageProcessing.ColorManagment.ColorDetector detectCol = new ImageProcessing.ColorManagment.ColorDetector(cover);

            progTurner.ProgressColor = await detectCol.DetectMainColor();

            player = new SoundPlayer(source);
            sPanel6.BackgroundImage = cover;
            lblTitle.Text = title;
            lblArtist.Text = artist;


            this.BackgroundImage = template.BlurredImage().Result;
            SetColor(await detectCol.DetectMainColor(), await detectCol.GetOppositeColor(detectCol.DetectMainColor().Result));
        }

        private void Player_Load_1(object sender, EventArgs e)
        {

        }

        public void SetColor(System.Drawing.Color mainColor, System.Drawing.Color secondColor)
        {
            Guna2Button[] buttons = { bntPlay, bntPause };

            foreach (var button in buttons)
            {
                button.FillColor = secondColor;
                button.ForeColor = mainColor;
            }
        }

        private void tmWaiter_Hits(object sender, EventArgs e)
        {
            tmWaiter.Stop();
            LoadAll();
            pnlSplash.Visible = false;
        }
    }
}
