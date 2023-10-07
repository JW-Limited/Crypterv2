using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LILO_Packager.v2.Core.Interfaces;
using SharpDX.MediaFoundation;

namespace LILO_Packager.v2.Shared.Streaming.Core
{
    public class MediaEngineManager : IDisposable, IMediaService
    {
        private static MediaEngineManager instance;
        private MediaEngineEx mediaEngineEx;
        private readonly ManualResetEvent eventReadyToPlay = new ManualResetEvent(false);
        private MediaPlaybackStatus playbackStatus = MediaPlaybackStatus.Stopped;
        private string currentErrorMessage = "";
        public static bool ErrorHappend = false;

        public event EventHandler<MediaPlaybackEventArgs> PlaybackStateChanged;

        private MediaEngineManager()
        {
            MediaManager.Startup();
            var mediaEngineFactory = new MediaEngineClassFactory();
            var mediaEngine = new MediaEngine(mediaEngineFactory, null, MediaEngineCreateFlags.AudioOnly);
            mediaEngineEx = mediaEngine.QueryInterface<MediaEngineEx>();

            mediaEngine.PlaybackEvent += OnPlaybackEvent;
        }

        public static MediaEngineManager Instance
        {
            get
            {
                if (instance == null || ErrorHappend)
                {
                    instance = new MediaEngineManager();
                    ErrorHappend = false;
                }
                return instance;
            }
        }

        public void SetSource(string source)
        {
            try
            {
                var ofdLessfileStream = new FileStream(source, FileMode.Open);
                var stream = new ByteStream(ofdLessfileStream);
                var url = new Uri(source, UriKind.RelativeOrAbsolute);
                mediaEngineEx.SetSourceFromByteStream(stream, url.AbsoluteUri);
                mediaEngineEx.Preload = MediaEnginePreload.Automatic;
                if (!eventReadyToPlay.WaitOne(1000))
                {
                    //HandleError("Unable to play this file");
                }
            }
            catch (Exception ex)
            {
                HandleError(ex.Message);
            }
        }

        public void Dispose()
        {
            mediaEngineEx.Dispose();
            MediaManager.Shutdown();
        }

        public async Task<bool> PlayAsync()
        {
            try
            {
                mediaEngineEx.Play();
                //await Task.Delay(1000);
                playbackStatus = MediaPlaybackStatus.Playing;
                RaisePlaybackStateChanged();
                return true;
            }
            catch (Exception ex)
            {
                HandleError(ex.Message);
                return false;
            }
        }

        public async Task<bool> PauseAsync()
        {
            try
            {
                mediaEngineEx.Pause();
                //await Task.Delay(1000);
                playbackStatus = MediaPlaybackStatus.Paused;
                RaisePlaybackStateChanged();
                return true;
            }
            catch (Exception ex)
            {
                HandleError(ex.Message);
                return false;
            }
        }

        public async Task<int> GetCurrentPositionAsync()
        {
            try
            {
                long currentPosition = (long)mediaEngineEx.CurrentTime;
                int currentPositionInSeconds = (int)TimeSpan.FromMilliseconds(currentPosition).TotalSeconds;
                RaisePlaybackStateChanged();
                return currentPositionInSeconds;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public async Task<int> GetDurationAsync()
        {
            try
            {
                long duration = (long)mediaEngineEx.Duration;
                int durationInSeconds = (int)TimeSpan.FromMilliseconds(duration).TotalSeconds;
                RaisePlaybackStateChanged();
                return durationInSeconds;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        private void OnPlaybackEvent(MediaEngineEvent playEvent, long param1, int param2)
        {
            switch (playEvent)
            {
                case MediaEngineEvent.Error:
                    HandleError("Playback error occurred");
                    playbackStatus = MediaPlaybackStatus.Error;
                    break;
                case MediaEngineEvent.Play:
                    playbackStatus = MediaPlaybackStatus.Playing;
                    break;
                case MediaEngineEvent.Pause:
                    playbackStatus = MediaPlaybackStatus.Paused;
                    break;
                case MediaEngineEvent.Ended:
                    playbackStatus = MediaPlaybackStatus.Ended;
                    break;
            }

            RaisePlaybackStateChanged();
        }

        private void HandleError(string errorMessage)
        {
            currentErrorMessage = errorMessage;
            ErrorHappend = true;

            PlaybackStateChanged?.Invoke(this, new MediaPlaybackEventArgs
            {
                Status = MediaPlaybackStatus.Error,
                ErrorMessage = errorMessage
            });
        }

        private void RaisePlaybackStateChanged()
        {
            PlaybackStateChanged?.Invoke(this, new MediaPlaybackEventArgs
            {
                Status = playbackStatus,
                CurrentPositionInSeconds = GetCurrentPositionInSeconds(),
                DurationInSeconds = GetDurationInSeconds(),
                ErrorMessage = currentErrorMessage,
                DurationInSeconds_int = (int)mediaEngineEx.Duration,
                CurrentPositionInSeconds_int = (int)mediaEngineEx.CurrentTime,
            });
        }

        private string GetCurrentPositionInSeconds()
        {
            try
            {
                return string.Format("{0}", TimeSpan.FromMinutes(mediaEngineEx.CurrentTime).ToString().Remove(5));
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string GetDurationInSeconds()
        {
            try
            {
                int duration = (int)mediaEngineEx.Duration;
                return string.Format("{0}", TimeSpan.FromMinutes(mediaEngineEx.Duration).ToString().Remove(5));
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
