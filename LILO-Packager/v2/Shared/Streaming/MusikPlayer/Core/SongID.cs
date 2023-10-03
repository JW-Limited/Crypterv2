using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using LILO_Packager.v2.streaming.MusikPlayer.Core.Indexer;

namespace LILO_Packager.v2.streaming.MusikPlayer.Core
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

    public class FileIdentifier
    {
        private static readonly int FILE_IDENTIFIER_LENGTH = 7;

        public static int GenerateIdentifier(string filename)
        {
            // Get the file's size in bytes.
            var fileSize = new FileInfo(filename).Length;

            // Create a list to store the file's bytes.
            var fileBytes = new List<byte>();

            // Read the file's bytes into the list.
            using (var fileStream = File.OpenRead(filename))
            {
                while (true)
                {
                    var byteRead = fileStream.ReadByte();
                    if (byteRead == -1)
                    {
                        break;
                    }

                    fileBytes.Add((byte)byteRead);
                }
            }

            // Calculate the file's checksum.
            var checksum = CalculateChecksum(fileBytes);

            // Convert the checksum to a 7-digit integer value.
            var identifier = ConvertChecksumToIdentifier(checksum);

            // Return the 7-digit integer value.
            return int.Parse(identifier);
        }

        private static int CalculateChecksum(List<byte> fileBytes)
        {
            // Create a checksum variable.
            int checksum = 0;

            // Iterate over the file's bytes and add them to the checksum.
            foreach (var bytee in fileBytes)
            {
                checksum += bytee;
            }

            // Return the checksum.
            return checksum;
        }

        private static string ConvertChecksumToIdentifier(int checksum)
        {
            // Convert the checksum to a string.
            var checksumString = checksum.ToString();

            // Pad the checksum string with leading zeros to make it 7 digits long.
            checksumString = checksumString.PadLeft(FILE_IDENTIFIER_LENGTH, '0');

            // Return the 7-digit checksum string.
            return checksumString;
        }
    }
}
