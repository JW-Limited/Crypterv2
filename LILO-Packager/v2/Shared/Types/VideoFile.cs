using Microsoft.Extensions.FileProviders;

namespace LILO_Packager.v2.Shared.Types
{
    public class VideoFile : IFileInfo
    {
        private readonly string _filename;

        public VideoFile(string filename)
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

        /// <inheritdoc/>
        public TimeSpan Duration { get; }

        /// <inheritdoc/>
        public int Width { get; }

        /// <inheritdoc/>
        public int Height { get; }

        /// <inheritdoc/>
        public int FrameRate { get; }
    }

}
