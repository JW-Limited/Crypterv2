using LILO_Packager.v2.Core.Interfaces;
using SharpDX.MediaFoundation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Playlists;

namespace LILO_Packager.v2.streaming.MusikPlayer.Core
{
    public class ComplexPlayerParameters : ILILOMediaHandler
    {
        public event Action<MediaEngineEvent, long, int> PlaybackCallback;
        public MusicPlayerParameters Parameters => _Parameters;
        bool ILILOMediaHandler.IsPaused => IsPaused;
        public bool IsMusicStopped => isMusicStopped;
        public TimeSpan CurrentTime => TimeSpan.FromMinutes(mediaEngineEx.CurrentTime);
        public TimeSpan Duration => TimeSpan.FromMinutes(mediaEngineEx.Duration);

        private Core.MusicPlayerParameters _Parameters;
        private static bool IsPaused = true;
        private static bool isMusicStopped;
        private static Stopwatch sw = new Stopwatch();
        private static MediaEngineEx mediaEngineEx;
        private Form _GoBackUi;

        public ComplexPlayerParameters(Core.MusicPlayerParameters para, Form previousUI = null)
        {
            _Parameters = para;
            _GoBackUi = previousUI;
        }


        public void LoadAll()
        {
            
        }

        public void Play()
        {
            
        }

        public void Stop()
        {
            
        }

        public void Pause()
        {
            
        }

        public void SetColor(Color mainColor, Color secondColor)
        {
            
        }

        public void Close()
        {
            
        }

    }
}
