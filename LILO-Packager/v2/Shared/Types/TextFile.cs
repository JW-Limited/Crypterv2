using LILO_Packager.v2.Shared.Interfaces;
using Microsoft.Extensions.FileProviders;

namespace LILO_Packager.v2.Shared.Types
{
    /// <summary>
    /// A class that represents a text file.
    /// </summary>
    public class TextFile<TFile> : ITextFile where TFile : IFileInfo
    {
        private readonly string _filename;

        /// <summary>
        /// Initializes a new instance of the <see cref="TextFile"/> class.
        /// </summary>
        /// <param name="filename">The path to the text file.</param>
        public TextFile(string filename)
        {
            _filename = filename;
        }

        /// <summary>
        /// Gets a value indicating whether the text file exists.
        /// </summary>
        public bool Exists => File.Exists(_filename);

        /// <summary>
        /// Gets the length of the text file in bytes.
        /// </summary>
        public long Length => new FileInfo(_filename).Length;

        /// <summary>
        /// Gets the physical path to the text file.
        /// </summary>
        public string? PhysicalPath => new FileInfo(_filename).FullName;

        /// <summary>
        /// Gets the name of the text file.
        /// </summary>
        public string Name => new FileInfo(_filename).Name;

        /// <summary>
        /// Gets the last modified time of the text file.
        /// </summary>
        public DateTimeOffset LastModified => new FileInfo(_filename).LastWriteTime;

        /// <summary>
        /// Gets a value indicating whether the text file is a directory.
        /// </summary>
        public bool IsDirectory => false;

        /// <summary>
        /// Creates a read stream to the text file.
        /// </summary>
        /// <returns>A read stream to the text file.</returns>
        public Stream CreateReadStream()
        {
            return new FileStream(_filename, FileMode.Open, FileAccess.Read);
        }

        /// <summary>
        /// Reads the entire text file into a string.
        /// </summary>
        /// <returns>The entire text file as a string.</returns>
        public string ReadAllText()
        {
            using (var stream = CreateReadStream())
            {
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// Writes the entire text file from a string.
        /// </summary>
        /// <param name="text">The text to write to the text file.</param>
        public void WriteAllText(string text)
        {
            using (var stream = CreateReadStream())
            {
                using (var writer = new StreamWriter(stream))
                {
                    writer.Write(text);
                }
            }
        }
    }

}
