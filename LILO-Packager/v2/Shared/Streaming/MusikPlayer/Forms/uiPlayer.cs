using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Diagnostics;
using SharpDX.MediaFoundation;
using LILO.Shell;
using Guna.UI2.WinForms;
using LILO_Packager.v2.streaming.MusikPlayer.Core;
using System.Runtime.InteropServices;
using LILO_Packager.v2.shared;
using Windows.UI.Popups;

namespace LILO_Packager.v2.streaming.MusikPlayer.Forms
{
    public partial class uiPlayer : Form
    {
        #region Form Designer



        #endregion

        #region Variables / Instances

        public static bool IsPaused = true;
        private static bool isMusicStopped;

        public static MusicPlayerParameters playerParameters;

        private static readonly ManualResetEvent eventReadyToPlay = new ManualResetEvent(false);
        public static Stopwatch sw = new Stopwatch();
        public static MediaEngineEx mediaEngineEx;
        private SoundPlayer player;

        #endregion


        private static uiPlayer _instance;

        public static uiPlayer Instance(MusicPlayerParameters parameters,bool back_)
        {
            if (_instance == null || _instance.IsDisposed || parameters.Source != playerParameters.Source)
            {
                _instance = new uiPlayer(parameters,back_);
            }


            return _instance;
        }

        public MediaEngineManager mediaEngineManager;


        public uiPlayer(MusicPlayerParameters parameters,bool back)
        {
            InitializeComponent();
            bntBack.Visible = back;
            playerParameters = parameters;

            mediaEngineManager = MediaEngineManager.Instance;
            mediaEngineManager.PlaybackStateChanged += OnPlaybackCallback;
            mediaEngineManager.SetSource(parameters.Source);

            this.FormClosing += (sender, e) =>
            {
                e.Cancel = true;
                this.Hide();
            };
        }

        private void Player_Load_1(object sender, EventArgs e)
        {

        }

        private async void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                isMusicStopped = false;
                this.Text = String.Format("Streaming - {0} by {1}", playerParameters.Title, string.Join(" feat. ", playerParameters.Artists));
                await mediaEngineManager.PlayAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "!ERROR!");
            }
        }

        private async void btnStop_Click(object sender, EventArgs e)
        {
            if (!isMusicStopped)
            {
                await mediaEngineManager.PauseAsync();
                isMusicStopped = true;
            }
        }

        private void OnPlaybackCallback(object sender, MediaPlaybackEventArgs e)
        {
            Console.Write("PlayBack Event received: {0}", e.Status.ToString());
            lblCurrentTIme.Text = "" + e.CurrentPositionInSeconds;
            lblAllTime.Text = "" + e.DurationInSeconds;
            progressBar.Maximum = e.DurationInSeconds_int;
            progressBar.Value = e.CurrentPositionInSeconds_int;
            timeSlider.Maximum = e.DurationInSeconds_int;
            timeSlider.Value = e.CurrentPositionInSeconds_int;

            switch (e.Status)
            {
                case MediaPlaybackStatus.Playing:
                    isMusicStopped = false;
                    break;
                case MediaPlaybackStatus.Paused:
                    isMusicStopped = true;
                    break;
                case MediaPlaybackStatus.Stopped:
                    isMusicStopped = true;
                    break;
                case MediaPlaybackStatus.Ended:
                    isMusicStopped = true;
                    break;
                case MediaPlaybackStatus.Error:
                    //MessageBox.Show($"Error: {e.ErrorMessage}", "Playback Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isMusicStopped = true;
                    lblMoreInfo.Text = "DirectXMediaError: " + e.ErrorMessage;
                    ConsoleManager.Instance().WriteLineWithColor("PlackbackError received: " + e.ErrorMessage);
                    break;
            }

            Console.WriteLine();
            
        }

        public async void LoadAll()
        {
            try
            {
                ImageProcessing.Templates template = new ImageProcessing.Templates(playerParameters.Cover);
                var imgBlurred = await template.BlurredImage();
                this.BackgroundImage = imgBlurred;
                sPanel6.BackgroundImage = playerParameters.Cover;
                lblTitle.Text = playerParameters.Title;
                lblArtist.Text = string.Join(", ", playerParameters.Artists);

                var dbTasks = new DBTasks();
                await dbTasks.InitializeDatabaseAsync(process =>
                {
                    
                });

                var info = new FileInfo(playerParameters.Source);
                await dbTasks.InsertSongAsync(new SongEntry(int.Parse(info.Name.Remove(5)), playerParameters.Title, string.Join(", ", playerParameters.Artists), playerParameters.Source));
                pnlSplash.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void tmWaiter_Hits(object sender, EventArgs e)
        {
            tmWaiter.Stop();
            Task.Run(() =>
            {
                LoadAll();
            });
        }

        private void progressBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isMusicStopped)
            {
                mediaEngineEx.Pause();
            }
        }

        private void progressBar_MouseUp(object sender, MouseEventArgs e)
        {
            mediaEngineEx.CurrentTime = timeSlider.Value;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MainHost.Instance().OpenInApp(v2.Forms.uiHistory.Instance());
        }
    }
}
 