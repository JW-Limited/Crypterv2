using System;
using System.IO;
using System.Drawing;
using System.Threading.Tasks;
using System.IO;

namespace LILO_Packager.v2.streaming.MusikPlayer.Core
{
    public class MusicPlayerParameters
    {
        public string Source { get; private set; }
        public string[] Artists { get; private set; }
        public string Title { get; private set; }
        public Bitmap Cover { get; private set; }

        private MusicPlayerParameters() { }

        public static async Task<MusicPlayerParameters> Get(string musicSource)
        {
            if (string.IsNullOrWhiteSpace(musicSource))
            {
                throw new ArgumentException("Music source cannot be empty or null.", nameof(musicSource));
            }

            if (!System.IO.File.Exists(musicSource))
            {
                throw new FileNotFoundException("File not found.", musicSource);
            }

            var pp = new MusicPlayerParameters();

            try
            {
                var tag = await Task.Run(() => TagLib.File.Create(musicSource));

                pp.Cover = GetCoverImage(tag);

                pp.Artists = GetArtists(tag);

                pp.Title = GetTitle(tag);

                pp.Source = musicSource;
            }
            catch (TagLib.UnsupportedFormatException)
            {
                Console.WriteLine("Unsupported file format.");
                pp.Artists = new[] { "Unknown" };
                pp.Title = Path.GetFileNameWithoutExtension(musicSource);
                pp.Cover = Properties.Resources.no_cover;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                pp.Artists = new[] { "Unknown" };
                pp.Title = Path.GetFileNameWithoutExtension(musicSource);
                pp.Cover = Properties.Resources.no_cover;
            }

            return pp;
        }

        private static Bitmap GetCoverImage(TagLib.File tag)
        {
            if (tag.Tag.Pictures.Length >= 1 && tag.Tag.Pictures[0] != null)
            {
                var cover = tag.Tag.Pictures[0];
                return new Bitmap(new MemoryStream(cover.Data.Data));
            }

            return Properties.Resources.no_cover1; 
        }

        private static string[] GetArtists(TagLib.File tag)
        {
            return tag.Tag.Artists.Length >= 1 ? tag.Tag.Artists : new[] { "Unknown" };
        }

        private static string GetTitle(TagLib.File tag)
        {
            return !string.IsNullOrWhiteSpace(tag.Tag.Title) ? tag.Tag.Title : Path.GetFileNameWithoutExtension(tag.Name);
        }
    
    }
}
