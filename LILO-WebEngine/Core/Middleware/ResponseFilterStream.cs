using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LILO_WebEngine.Core.Middleware
{
    /// <summary>
    /// Stream filter that captures and allows rewriting of captured output
    /// which is used by the LiveReloadMiddleware.
    /// </summary>
    public class ResponseFilterStream : Stream
    {
        private readonly Stream _baseStream;
        private readonly MemoryStream _captureStream;
        private bool _closed;
        private Func<byte[], byte[]> _transformer;

        public ResponseFilterStream(Stream baseStream)
        {
            _baseStream = baseStream ?? throw new ArgumentNullException(nameof(baseStream));
            _captureStream = new MemoryStream();
            _closed = false;
        }

        public void SetTransformer(Func<byte[], byte[]> transformer)
        {
            _transformer = transformer;
        }

        public override bool CanRead => _baseStream.CanRead;
        public override bool CanSeek => _baseStream.CanSeek;
        public override bool CanWrite => _baseStream.CanWrite;
        public override long Length => _captureStream.Length;
        public override long Position
        {
            get => _captureStream.Position;
            set => _captureStream.Position = value;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return _baseStream.Read(buffer, offset, count);
        }

        public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            return _baseStream.ReadAsync(buffer, offset, count, cancellationToken);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return _captureStream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            _captureStream.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            _captureStream.Write(buffer, offset, count);
        }

        public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            return _captureStream.WriteAsync(buffer, offset, count, cancellationToken);
        }

        public override void Flush()
        {
            // Don't flush to the output stream yet
            _captureStream.Flush();
        }

        public override Task FlushAsync(CancellationToken cancellationToken)
        {
            return _captureStream.FlushAsync(cancellationToken);
        }

        public override void Close()
        {
            if (_closed) return;
            
            _closed = true;
            _captureStream.Position = 0;

            try
            {
                byte[] data = new byte[_captureStream.Length];
                _captureStream.Read(data, 0, data.Length);
                
                // Transform content if a transformer is set
                if (_transformer != null)
                {
                    data = _transformer(data);
                }
                
                // Write transformed content to the base stream
                _baseStream.Write(data, 0, data.Length);
                _baseStream.Flush();
            }
            finally
            {
                _captureStream.Close();
                _baseStream.Close();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!_closed)
                {
                    Close();
                }
                
                _captureStream.Dispose();
            }
            
            base.Dispose(disposing);
        }
    }
} 