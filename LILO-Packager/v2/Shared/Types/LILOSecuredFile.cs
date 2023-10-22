using LILO_Packager.v2.Plugins.PluginCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;
using RestSharp.Extensions;
using Telerik.WinControls;

namespace LILO_Packager.v2.Shared.Types
{
    public class LILOSecuredFile : ILILOSecuredFile, IDisposable, IFileProvider
    {
        private string _filename;
        private bool disposedValue;

        public LILOSecuredFile(string filename)
        {
            _filename = filename;
        }

        public bool IsDisposed => _filename != null;

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

        public int ID => throw new NotImplementedException();

        /// <inheritdoc/>
        public PluginID PreviewPlugin_ID => PluginID.GetID("Crypter","MainHost","lvl0");

        /// <inheritdoc/>
        public Stream CreateReadStream()
        {
            return new FileStream(_filename, FileMode.Open, FileAccess.Read);
        }

        protected string GetSizeString(long size)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            while (size >= 1024 && order < sizes.Length - 1)
            {
                order++;
                size /= 1024;
            }
            return $"{size} {sizes[order]}";
        }

        /// <inheritdoc/>
        public string GetSizeInReadableForm()
        {
            return GetSizeString(Length);
        }

        /// <inheritdoc/>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _filename = null;
                }

                disposedValue = true;
            }
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        /// <inheritdoc/>
        public IFileInfo GetFileInfo(string subpath)
        {
            return this;
        }

        /// <inheritdoc/>
        public IDirectoryContents GetDirectoryContents(string subpath)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public IChangeToken Watch(string filter)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public async Task CopyToAsync(string destination)
        {
            using (var source = CreateReadStream())
            using (var destinationStream = new FileStream(destination, FileMode.Create, FileAccess.Write))
            {
                await source.CopyToAsync(destinationStream);
            }
        }

        /// <inheritdoc/>
        public async Task MoveToAsync(string destination)
        {
            await CopyToAsync(destination);
            await DeleteAsync();
        }

        /// <inheritdoc/>
        public async Task DeleteAsync()
        {
            if (Exists)
            {
                File.Delete(_filename);
            }
        }

        /// <inheritdoc/>
        [Obsolete]
        public async Task<byte[]> ReadAllBytesAsync()
        {
            using (var stream = CreateReadStream())
            {
                return stream.ReadAsBytes();
            }
        }
    }
}
