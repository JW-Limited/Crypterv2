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
using LILO_Packager.v2.streaming.Core;

namespace LILO_Packager.v2.Forms
{
    public partial class uiPlayer : Form
    {
        #region Form Designer



        #endregion



        #region Variables / Instances

        public string connectionString = "Server=localhost;Database=playlist;Trusted_Connection=True;";

        public static bool IsPaused = true;
        private static bool isMusicStopped;

        public Thread PlayerThread;
        public MusicPlayerParameters playerParameters;

        private static readonly ManualResetEvent eventReadyToPlay = new ManualResetEvent(false);
        public static Stopwatch sw = new Stopwatch();
        public static MediaEngineEx mediaEngineEx;
        private SoundPlayer player;

        #endregion


        private static uiPlayer _instance;

        public static uiPlayer Instance(MusicPlayerParameters parameters)
        {
            if (_instance == null)
            {
                _instance = new uiPlayer(parameters);
            }


            return _instance;
        }

        public uiPlayer(MusicPlayerParameters parameters)
        {
            InitializeComponent();
            playerParameters = parameters;

            PlayerThread = new Thread(() =>
            {
                var ofdLessfileStream = new FileStream(playerParameters.Source, FileMode.Open);

                MediaManager.Startup();

                var mediaEngineFactory = new MediaEngineClassFactory();
                var mediaEngine = new MediaEngine(mediaEngineFactory, null, MediaEngineCreateFlags.AudioOnly);
                var stream = new ByteStream(ofdLessfileStream);
                var url = new Uri(playerParameters.Source, UriKind.RelativeOrAbsolute);

                mediaEngineEx = mediaEngine.QueryInterface<MediaEngineEx>();
                mediaEngineEx.SetSourceFromByteStream(stream, url.AbsoluteUri);

                mediaEngine.PlaybackEvent += OnPlaybackCallback;

                if (!eventReadyToPlay.WaitOne(1000))
                {
                    MessageBox.Show("Unexpected error: Unable to play this file", "PlaybackError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            });

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
                if (PlayerThread.IsAlive)
                {
                    ;
                }


                this.Text = String.Format("Streaming - {0} by {1}", playerParameters.Title, string.Join(" feat. ", playerParameters.Artists));

                mediaEngineEx.Play();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "!ERROR!");
            }
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
            lblAllTime.Text = String.Format("{0}", TimeSpan.FromMinutes(mediaEngineEx.Duration));
            lblMoreInfo.Text = String.Format("{0}", mediaEngineEx.PlaybackRate);

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

            try
            {


                ImageProcessing.Templates template = new ImageProcessing.Templates(playerParameters.Cover);
                ImageProcessing.ColorManagment.ColorDetector detectCol = new ImageProcessing.ColorManagment.ColorDetector(playerParameters.Cover);

                var imgBlurred = await template.BlurredImage();
                var colorMain = await detectCol.DetectMainColor();
                var colorSecond = await detectCol.GetOppositeColor(colorMain);

                progTurner.ProgressColor = colorMain;
                this.BackgroundImage = imgBlurred;
                SetColor(colorMain, colorSecond);

                player = new SoundPlayer(playerParameters.Source);
                sPanel6.BackgroundImage = playerParameters.Cover;
                lblTitle.Text = playerParameters.Title;
                lblArtist.Text = string.Join(", ", playerParameters.Artists);

                pnlSplash.Visible = false;

                PlayerThread.UnsafeStart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        public void SetColor(Color mainColor, Color secondColor)
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
            Task.Run(() =>
            {
                LoadAll();
            });
        }
    }
}
