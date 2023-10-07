using LILO_Packager.v2.Shared.Streaming.Core;
using SharpDX.MediaFoundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.Interfaces
{
    public interface ILILOMediaHandler
    {
        MusicPlayerParameters Parameters { get; }
        bool IsPaused { get; }
        bool IsMusicStopped { get; }
        TimeSpan CurrentTime { get; }
        TimeSpan Duration { get; }

        event Action<MediaEngineEvent, long, int> PlaybackCallback;

        void LoadAll();
        void Play();
        void Stop();
        void SetColor(Color mainColor, Color secondColor);
        void Close();
    }
}
