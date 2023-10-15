using Microsoft.Extensions.FileProviders;

namespace LILO_Packager.v2.Shared.Streaming.Core
{
    public class AudioFile : IFileInfo
    {
        private readonly string _filename;

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioFile<TFile>"/> class.
        /// </summary>
        /// <param name="file">The file to represent.</param>
        public AudioFile(string filename)
        {
            _filename = filename;
        }

        /// <inheritdoc/>
        public bool Exists => File.Exists(_filename);

        /// <inheritdoc/>
        public long Length => new FileInfo(_filename).Length;

        /// <inheritdoc/>
        public string? PhysicalPath => new FileInfo(_filename).FullName;

        /// <inheritdoc/>
        public string Name => new FileInfo(_filename).Name;

        /// <inheritdoc/>
        public DateTimeOffset LastModified => new FileInfo(_filename).LastWriteTime;

        /// <inheritdoc/>
        public bool IsDirectory => false;

        /// <inheritdoc/>
        public Stream CreateReadStream()
        {
            return new FileStream(_filename, FileMode.Open, FileAccess.Read);
        }
    }

}
