using LILO_Packager.v2.Forms;
using LILO_Packager.v2.shared;
using SharpDX.DXGI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;
using Telerik.WinControls.UI;

namespace LILO_Packager.v2.streaming.MusikPlayer.Core
{
    public class MusicPlayerParameters
    {
        public string Source { get; set; }

        public string[] Artists { get; set; }

        public string Title { get; set; }

        public Bitmap Cover { get; set; }

        public static async Task<MusicPlayerParameters> Get(string musicSource)
        {
            if (string.IsNullOrEmpty(musicSource)) throw new ArgumentNullException("musicSource");
            if (!System.IO.File.Exists(musicSource)) throw new FileNotFoundException();

            var pp = new MusicPlayerParameters();

            try
            {
                using (var file3 = TagLib.File.Create(musicSource))
                {

                    if (file3.Tag.Pictures.Length >= 1)
                    {
                        if (file3.Tag.Pictures[0] is not null)
                        {
                            var cover = file3.Tag.Pictures[0];
                            var image = new Bitmap(new MemoryStream(cover.Data.Data));
                            pp.Cover = image;
                        }
                        else
                        {
                            pp.Cover = Properties.Resources.Lock;
                        }
                    }

                    if (file3.Tag.Artists.Length >= 1)
                    {
                        pp.Artists = file3.Tag.Artists;
                    }
                    else
                    {
                        pp.Artists[0] = "Unknown";
                    }

                    if (file3.Tag.Title is not null or "")
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
            catch (Exception ex)
            {
                ConsoleManager.Instance().WriteLineWithColor(ex.Message + ex.Source + "\n\nError: MusicParametering");
                FileInfo var = new FileInfo(musicSource);

                return new MusicPlayerParameters()
                {
                    Source = musicSource,
                    Artists = new string[] { "Unknown" },
                    Title = var.Name,
                    Cover = Properties.Resources.no_cover
                };
            }


        }
    }
}
