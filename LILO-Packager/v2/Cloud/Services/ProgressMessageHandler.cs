namespace LILO_Packager.v2.Cloud.Services
{
    public class ProgressMessageHandler : DelegatingHandler
    {
        private readonly Action<long, long> _progressCallback;

        public ProgressMessageHandler(HttpMessageHandler innerHandler, Action<long, long> progressCallback)
            : base(innerHandler)
        {
            _progressCallback = progressCallback ?? throw new ArgumentNullException(nameof(progressCallback));
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var content = request.Content;
            if (content != null)
            {
                var progressContent = new ProgressStreamContent(await content.ReadAsStreamAsync(), _progressCallback);
                request.Content = progressContent;
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
