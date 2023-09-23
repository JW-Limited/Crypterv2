using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.streaming.MusikPlayer.Core
{
    internal class Sound
    {
        public async void Play(string source)
        {
            //".wav" windows 

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = source;
            player.LoadAsync();
            player.Play();
        }
    }
}
