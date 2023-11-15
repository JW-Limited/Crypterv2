using LILO_WebEngine.Core.Contracts;
using LILO_WebEngine.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LILO_WebEngine.Service
{
    public class LocalMediaServer : IDisposable, ILILOWebService
    {
        private bool _isRunning = false;
        private string? _mediaFolder = null;
        private HttpListener _listener;
        private ILILOServerOptions _options;
        private Func<HttpListenerContext, Task> _requestHandler;

        public static LocalMediaServer Instance => _lazyInstance.Value;
        public string Name => _options.ServerName ?? "Not Initialized";
        public bool IsRunning => _isRunning;
        public string SourceDirectory => _options.SourceDirectory;

        public ILILOServerOptions Options => _options;

        public string InstanceName => "CDN Controler";

        public object InstanceContainer => Instance;

        private static Lazy<LocalMediaServer> _lazyInstance = new Lazy<LocalMediaServer>();


        public Task<bool> Start()
        {
            _listener.Start();
            _isRunning = _listener.IsListening;

            Thread thread = new Thread(HandleRequests);
            thread.Start();

            return Task.FromResult(true);
        }

        public Task<InitializationResponse> Initialization(ILILOServerOptions serverOptions)
        {
            _listener = new HttpListener();
            _mediaFolder = serverOptions.SourceDirectory;
            _options = serverOptions;
            _requestHandler = serverOptions.RequestHandler ?? DefaultRequestHandler;

            try
            {
                _listener.Prefixes.Add($"http://localhost:{serverOptions.Port.Default}/");

                return Task.FromResult(new InitializationResponse()
                {
                    Port = serverOptions.Port.Default,
                    SuccessFull = true,
                });
            }
            catch (Exception)
            {
                try
                {
                    _listener.Prefixes.Add($"http://localhost:{serverOptions.Port.FallBack}/");

                    return Task.FromResult(new InitializationResponse()
                    {
                        Port = serverOptions.Port.FallBack,
                        SuccessFull = true,
                    });
                }
                catch (Exception ex)
                {

                    return Task.FromResult(new InitializationResponse()
                    {
                        SuccessFull = false,
                        ErrorMessage = ex.Message,
                        Exception = ex
                    });
                }
            }
        }


        public Task Stop()
        {
            _listener.Stop();
            _isRunning = false;

            return Task.CompletedTask;
        }

        private async void HandleRequests()
        {
            while (_isRunning)
            {
                try
                {
                    var context = await _listener.GetContextAsync();
                    await _requestHandler(context);
                }
                catch (Exception)
                {

                }
            }
        }

        private async Task DefaultRequestHandler(HttpListenerContext context)
        {
            try
            {
                HttpListenerRequest request = context.Request;
                HttpListenerResponse response = context.Response;
                var filePath = Path.Combine(_mediaFolder, request.Url.LocalPath.TrimStart('/'));
                var mediaEngine = new Core.Request.MediaToStreamHandler();
                var indexHtml = new Core.Handler.ErrorHandler(new Core.Pages.ErrorHtmlDynamic());
                string filename = request.Url.AbsolutePath;

                filename = filename.Substring(1);

                if (request.HttpMethod != "GET")
                {
                    byte[] buffer = Encoding.UTF8.GetBytes("This server only accept GET requests.");
                    response.ContentLength64 = buffer.Length;
                    response.OutputStream.Write(buffer, 0, buffer.Length);
                    response.OutputStream.Close();
                    return;
                }

                if (File.Exists(_mediaFolder + filename))
                {
                    if (request.Url.LocalPath.EndsWith(".mp3") ||
                        request.Url.LocalPath.EndsWith(".wav") ||
                        request.Url.LocalPath.EndsWith(".ogg"))
                    {
                        var streaming = await mediaEngine.StreamMediaAsync(request, response);
                        if (!streaming)
                        {
                            await indexHtml.Handle(context, HttpStatusCode.InternalServerError);
                        }
                    }
                    else
                    {
                        byte[] buffer = File.ReadAllBytes(_mediaFolder + filename);
                        response.ContentLength64 = buffer.Length;
                        response.OutputStream.Write(buffer, 0, buffer.Length);
                    }
                }
                else
                {
                    await indexHtml.Handle(context, HttpStatusCode.NotFound);
                }

                response.OutputStream.Close();
            }
            catch (Exception ex)
            {
                var handler = new Core.Handler.ErrorHandler(new Core.Pages.ErrorHtmlDynamic());
                await handler.Handle(context, HttpStatusCode.InternalServerError, ex);
            }
        }

        public void Dispose()
        {
            Stop();
        }


    }
}
