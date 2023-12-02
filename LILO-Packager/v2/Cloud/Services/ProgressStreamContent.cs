using System.Net;

namespace LILO_Packager.v2.Cloud.Services
{
    public class ProgressStreamContent : StreamContent
    {
        private readonly Action<long, long> _progressCallback;

        public ProgressStreamContent(Stream stream, Action<long, long> progressCallback)
            : base(stream)
        {
            _progressCallback = progressCallback ?? throw new ArgumentNullException(nameof(progressCallback));
        }

        protected override async Task SerializeToStreamAsync(Stream stream, TransportContext context)
        {
            var length = Headers.ContentLength ?? 0;
            var buffer = new byte[4096];
            long bytesWritten = 0;

            try
            {
                using (var contentStream = await ReadAsStreamAsync())
                {
                    while (true)
                    {
                        var bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length);
                        if (bytesRead == 0)
                            break;

                        await stream.WriteAsync(buffer, 0, bytesRead);
                        bytesWritten += bytesRead;

                        _progressCallback(bytesWritten, length);
                    }
                }
            }
            catch (Exception writeException)
            {
                throw new InvalidOperationException($"Error writing into stream: {writeException.Message}", writeException);
            }
        }
    }
}
