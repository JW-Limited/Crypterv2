using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.streaming.MusikPlayer.Core
{
    public class SongEntry : ISongEntry
    {
        public SongEntry(int id, string Title, string artist, string place)
        {
            Id = id;
            this.Title = Title ?? throw new ArgumentNullException(nameof(Title));
            Artist = artist ?? throw new ArgumentNullException(nameof(artist));
            Place = place ?? throw new ArgumentNullException(nameof(place));
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Place { get; set; }
    }
}
