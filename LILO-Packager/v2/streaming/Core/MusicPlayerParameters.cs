using LILO_Packager.v2.Forms;
using SharpDX.DXGI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace LILO_Packager.v2.streaming.Core
{
    public class MusicPlayerParameters
    {
        public string Source { get; set; }

        public string[] Artists { get; set; }

        public string Title { get; set; }

        public Bitmap Cover { get; set; }

        public static async Task<MusicPlayerParameters> Get(string musicSource) 
        {
            var pp = new MusicPlayerParameters();

            if (string.IsNullOrEmpty(musicSource)) throw new FileNotFoundException();

            using (var file3 = TagLib.File.Create(musicSource))
            {
                if (file3.Tag.Pictures.Length >= 1)
                {
                    var cover = file3.Tag.Pictures[0];
                    var image = new System.Drawing.Bitmap(new System.IO.MemoryStream(cover.Data.Data));
                    pp.Cover = image;
                }
                else
                {
                    pp.Cover = Properties.Resources.Lock;
                }

                if (file3.Tag.Artists.Length >= 1)
                {
                    pp.Artists = file3.Tag.Artists;
                }
                else
                {
                    pp.Artists[0] = "Unknown";
                }

                if(file3.Tag.Title is not null or "")
                {
                    pp.Title = file3.Tag.Title;
                }
                else
                {
                    FileInfo var = new FileInfo(musicSource);

                    pp.Title = var.Name;
                }

                pp.Source = musicSource;

                return pp;
            }
        }
    }
}
