using Microsoft.Extensions.FileProviders;
using System.Security.Cryptography;

namespace LILO_Packager.v2.Shared.Streaming.Core
{
    /// <summary>
    /// A class for generating identifiers for files.
    /// </summary>
    public class FileIdentifier<TFile> where TFile : IFileInfo
    {
        private static readonly int FILE_IDENTIFIER_LENGTH = 7;


        /// <summary>
        /// Generates an identifier for the specified file.
        /// </summary>
        /// <param name="file">The file to generate an identifier for.</param>
        /// <returns>A 7-digit integer identifier for the file.</returns>
        public static int GenerateIdentifier(TFile filename)
        {

            var fileSize = filename.Length;

            var fileBytes = new List<byte>();

            using (var fileStream = filename.CreateReadStream())
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
            var checksum = CalculateChecksum(fileBytes);

            var identifier = ConvertChecksumToIdentifier(checksum);

            return int.Parse(identifier);
        }

        /// <summary>
        /// Checks if two files have the same identifier.
        /// </summary>
        /// <param name="file1">The first file to check.</param>
        /// <param name="file2">The second file to check.</param>
        /// <returns>True if the two files have the same identifier, false otherwise.</returns>
        public static bool CompareIdentifiers(TFile file1, TFile file2)
        {
            int identifier1 = GenerateIdentifier(file1);
            int identifier2 = GenerateIdentifier(file2);

            return identifier1 == identifier2;
        }
        /// <summary>
        /// Proves that a file has not been modified since a given timestamp.
        /// </summary>
        /// <param name="file">The file to check.</param>
        /// <param name="timestamp">The timestamp to compare the file's last modified time against.</param>
        /// <returns>True if the file has not been modified since the given timestamp, false otherwise.</returns>
        public static bool ProveFileIntegrity(TFile file, DateTime timestamp)
        {
            int identifier = GenerateIdentifier(file);
            int identifierAtTimestamp = GenerateIdentifierFromFileHash(file.PhysicalPath, timestamp);

            return identifier == identifierAtTimestamp;
        }

        /// <summary>
        /// Generates an identifier for a file from its hash at a given timestamp.
        /// </summary>
        /// <param name="filename">The path to the file.</param>
        /// <param name="timestamp">The timestamp to compare the file's last modified time against.</param>
        /// <returns>An identifier for the file from its hash at a given timestamp.</returns>
        private static int GenerateIdentifierFromFileHash(string filename, DateTime timestamp)
        {
            var fileHash = CalculateFileHash(filename, timestamp);
            var identifier = ConvertChecksumToIdentifier((int)BitConverter.ToInt64(fileHash));

            return int.Parse(identifier);
        }

        /// <summary>
        /// Calculates the hash of a file at a given timestamp.
        /// </summary>
        /// <param name="filename">The path to the file.</param>
        /// <param name="timestamp">The timestamp to compare the file's last modified time against.</param>
        /// <returns>The hash of the file at a given timestamp.</returns>
        private static byte[] CalculateFileHash(string filename, DateTime timestamp)
        {
            var lastModifiedTime = new FileInfo(filename).LastWriteTime;
            File.SetLastWriteTime(filename, timestamp);
            using (var fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                using (var hashAlgorithm = SHA256.Create())
                {
                    File.SetLastWriteTime(filename, lastModifiedTime);
                    return hashAlgorithm.ComputeHash(fileStream);
                }
            }
        }
        private static int CalculateChecksum(List<byte> fileBytes)
        {
            int checksum = 0;

            foreach (var bytee in fileBytes)
            {
                checksum += bytee;
            }
            return checksum;
        }

        private static string ConvertChecksumToIdentifier(int checksum)
        {
            var checksumString = checksum.ToString();

            checksumString = checksumString.PadLeft(FILE_IDENTIFIER_LENGTH, '0');

            return checksumString;
        }
    }
}
