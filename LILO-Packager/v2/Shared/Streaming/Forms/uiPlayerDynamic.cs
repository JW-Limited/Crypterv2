using Guna.UI2.WinForms;
using LILO.Shell;
using LILO_Packager.v2.Core.Dialogs;
using LILO_Packager.v2.Core.Interfaces;
using LILO_Packager.v2.Forms;
using LILO_Packager.v2.Shared;
using LILO_Packager.v2.Shared.Streaming.Core;
using LILO_Packager.v2.Shared.Types;
using Microsoft.Extensions.FileProviders;
using SharpDX.MediaFoundation;
using System.Diagnostics;
using ImageProcessing = LILO_Packager.v2.Shared.ImageProcessing;

namespace LILO_Packager.v2.Streaming.MusikPlayer.Forms
{
    public partial class uiPlayerDynamic : Form, ILILOMediaHandler
    {
        public event Action<MediaEngineEvent, long, int> PlaybackCallback;
        public MusicPlayerParameters Parameters => _Parameters;
        bool ILILOMediaHandler.IsPaused => IsPaused;
        public bool IsMusicStopped => isMusicStopped;
        public TimeSpan CurrentTime => throw new NotImplementedException();
        public TimeSpan Duration => throw new NotImplementedException();
        public FileStream OpendFileStream;

        MusicPlayerParameters _Parameters;
        public Thread PlayerThread;
        public static bool IsPaused = true;
        private static bool isMusicStopped;
        private static readonly ManualResetEvent eventReadyToPlay = new ManualResetEvent(false);
        public static Stopwatch sw = new Stopwatch();
        public static MediaEngineEx mediaEngineEx;
        Form _GoBackUi;

        public enum DynamicPlayerOpendedForm
        {
            LocalHistoryQuery = 4,
            LILO_WebEngine = 8,
            BrowserQuery = 16
        }

        public uiPlayerDynamic(MusicPlayerParameters para, Form previousUI = null, DynamicPlayerOpendedForm openedFrom = DynamicPlayerOpendedForm.LocalHistoryQuery)
        {
            InitializeComponent();
            bntCollapse.Visible = config.Default.experimentsEnabled;

            if(openedFrom is not DynamicPlayerOpendedForm.LILO_WebEngine or DynamicPlayerOpendedForm.BrowserQuery)
            {
                _GoBackUi = previousUI;
            }
            else if(openedFrom is DynamicPlayerOpendedForm.LILO_WebEngine)
            {
                _GoBackUi = uiHistory.Instance();
            }

            PlayerThread = new Thread(() =>
            {
                var ofdLessfileStream = new FileStream(_Parameters.Source, FileMode.Open);
                OpendFileStream = ofdLessfileStream;
                //FileStreamObserver.ObserveFileStream(ofdLessfileStream);
                MediaManager.Startup();

                var mediaEngineFactory = new MediaEngineClassFactory();
                var mediaEngineATT = new MediaEngineAttributes();
                mediaEngineATT.AudioCategory = SharpDX.Multimedia.AudioStreamCategory.Media;
                mediaEngineATT.AudioEndpointRole = SharpDX.Multimedia.AudioEndpointRole.Multimedia;
                mediaEngineATT.ContentProtectionFlags = MediaEngineProtectionFlags.EnableProtectedContent;
                var mediaEngine = new MediaEngine(mediaEngineFactory, mediaEngineATT, MediaEngineCreateFlags.AudioOnly);
                mediaEngine.Preload = MediaEnginePreload.Automatic;
                mediaEngine.Load();
                var stream = new ByteStream(ofdLessfileStream);
                var url = new Uri(_Parameters.Source, UriKind.RelativeOrAbsolute);

                mediaEngineEx = mediaEngine.QueryInterface<MediaEngineEx>();
                mediaEngineEx.SetSourceFromByteStream(stream, url.AbsoluteUri);

                mediaEngine.PlaybackEvent += OnPlaybackCallback;

                if (!eventReadyToPlay.WaitOne(1000))
                {
                    OkDialog.Show("Unexpected error: Unable to play this file", "PlaybackError", DialogIcon.Error);

                    MainHost.Instance().OpenInApp(previousUI);
                }
                else
                {
                    this.Invoke(new Action(() =>
                    {
                        this.pnlSplashScreen.Visible = false;
                    }));
                }
            });

            _Parameters = para;
        }

        private void OnPlaybackCallback(MediaEngineEvent playEvent, long param1, int param2)
        {
            if (playEvent is not MediaEngineEvent.Error)
            {
                Console.Write("PlayBack Event received: {0}", playEvent);
                lblCurrentTIme.Text = String.Format("{0}", TimeSpan.FromMinutes(mediaEngineEx.CurrentTime).ToString().Remove(5));
                lblAllTime.Text = String.Format("{0}", TimeSpan.FromMinutes(mediaEngineEx.Duration).ToString().Remove(5));
                trackBar.Maximum = (int)mediaEngineEx.Duration;
                trackBar.Value = (int)mediaEngineEx.CurrentTime;

                switch (playEvent)
                {
                    case MediaEngineEvent.CanPlay:
                        bntPlay.Enabled = true;
                        eventReadyToPlay.Set();
                        break;
                    case MediaEngineEvent.TimeUpdate:
                        Console.Write(" {0}", TimeSpan.FromSeconds(mediaEngineEx.CurrentTime));

                        break;
                    case MediaEngineEvent.Error:
                        bntPause.Visible = false;
                        PlayerThread.Suspend();
                        break;
                    case MediaEngineEvent.Abort:
                        bntPause.Visible = false;
                        PlayerThread.Abort();
                        break;
                    case MediaEngineEvent.Ended:
                        bntPause.Visible = false;
                        isMusicStopped = true;
                        PlayerThread.Abort();
                        break;
                }

                Console.WriteLine();
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "DirectXMediaError: " + mediaEngineEx.Error;
                bntPause.Visible = false;

                ConsoleManager.Instance().WriteLineWithColor("PlackbackError received: " + mediaEngineEx.Error + mediaEngineEx.Error.GetErrorCode() + " State: " + mediaEngineEx.ReadyState.ToString());
            }
        }

        private void uiPlayerDynamic_Load(object sender, EventArgs e)
        {
            var timer = new System.Windows.Forms.Timer();
            timer.Tick += (sender, e) =>
            {
                timer.Stop();

                Task.Run(() =>
                {
                    LoadAll();
                });
            };

            this.FormClosing += (sender, e) =>
            {
                OpendFileStream?.Close();
                OpendFileStream?.Dispose();
            };

            timer.Start();

        }

        public async void LoadAll()
        {
            try
            {
                if (_Parameters.Cover is not null)
                {
                    ImageProcessing.Templates template = new ImageProcessing.Templates(_Parameters.Cover);
                    //ImageProcessing.ColorManagment.ColorDetector detectCol = new ImageProcessing.ColorManagment.ColorDetector(_Parameters.Cover);

                    var imgBlurred = await template.BlurredImage();
                    //var colorMain = await detectCol.DetectMainColor();
                    //var colorSecond = await detectCol.GetOppositeColor(colorMain);
                    this.Invoke(delegate ()
                    {
                        pnlCover_Blurred.BackgroundImage = imgBlurred;
                    });

                }

                var dbTasks = new DBTasks();
                await dbTasks.InitializeDatabaseAsync(process =>
                {

                });

                await dbTasks.InsertSongAsync(
                    new SongEntry(
                        FileIdentifier<IFileInfo>.GenerateIdentifier(
                            new AudioFile(_Parameters.Source)),
                        _Parameters.Title,
                        string.Join(", ", _Parameters.Artists), 
                        _Parameters.Source));
                pnlCover.BackgroundImage = _Parameters.Cover;
                lblTrack.Text = _Parameters.Title;
                lblArtist.Text = string.Join(", ", _Parameters.Artists);

                PlayerThread.UnsafeStart();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                this.Text = String.Format("Streaming - {0} by {1}", _Parameters.Title, string.Join(" feat. ", _Parameters.Artists));
                mediaEngineEx.Play();
                isMusicStopped = false;
                bntPause.Visible = true;
            }
            catch (Exception ex)
            {
                OkDialog.Show(ex.Message, "!ERROR!", DialogIcon.Error);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!isMusicStopped)
            {
                this.Invoke(new Action(() =>
                {
                    mediaEngineEx.Pause();
                    bntPause.Visible = false;
                }));

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

        private void bntBack_Click(object sender, EventArgs e)
        {
            MainHost.Instance().OpenInApp(_GoBackUi);
            this.Close();
        }

        private void bntCollapse_CLICK(object sender, EventArgs e)
        {

        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

}
