using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Shared.Streaming.Core
{
    /// <summary>
    /// Represents a unique identifier for a song.
    /// </summary>
    public class SongID
    {
        private readonly string _filename;

        /// <summary>
        /// Initializes a new instance of the <see cref="SongID"/> class.
        /// </summary>
        /// <param name="filename">The path to the song file.</param>
        /// <exception cref="ArgumentNullException">If the filename is null.</exception>
        public SongID(string filename)
        {
            if (filename == null)
            {
                throw new ArgumentNullException(nameof(filename));
            }

            _filename = filename;
        }

        /// <summary>
        /// Gets the unique identifier for the song.
        /// </summary>
        /// <returns>A unique integer value that can be used to identify the song.</returns>
        public int GetId()
        {
            /*MusicFingerprintingAlgorithm musicFingerprintingAlgorithm = new MusicFingerprintingAlgorithm();
            string fingerprint = musicFingerprintingAlgorithm.GetFingerprint(this._FileName);
            int songId = musicFingerprintingAlgorithm.IdentifySong(fingerprint);
            return songId;*/

            using (var sha256 = SHA256.Create())
            using (var fileStream = File.OpenRead(_filename))
            {
                var hash = sha256.ComputeHash(fileStream);
                return BitConverter.ToInt32(hash, 0);
            }
        }

        /// <summary>
        /// Implicitly converts a <see cref="SongID"/> object to an integer value.
        /// </summary>
        /// <param name="songID">The <see cref="SongID"/> object to convert.</param>
        /// <returns>The integer value of the <see cref="SongID"/> object.</returns>
        public static implicit operator int(SongID songID)
        {
            return songID.GetId();
        }
    }
}
