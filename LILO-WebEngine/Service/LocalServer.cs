using System.Net;
using System.Text;
using LILO_WebEngine.Core.Pages;
using LILO_WebEngine.Core.Handler;
using LILO_WebEngine.Core.Request;
using LILO_WebEngine.Shared;
using LILO_WebEngine.Core.Contracts;
using LILO_WebEngine.Core.Local;

namespace LILO_WebEngine.Service
{
    public partial class LocalServer : IDisposable, ILILOWebService
    {
        public string Name => ServerOptions.ServerName ?? "Not Initialized.";
        public bool IsRunning => _isRunning;
        public string SourceDirectory => _directory;
        public int ListenPort {  get; set; }
        public bool _isRunning = false;
        public Func<HttpListenerContext, Task> _requestHandler { get; set; }
        public static LocalServer Instance { get { return _lazyInstance.Value; } }
        public ILILOServerOptions Options => ServerOptions;
        public event EventHandler<LocalServerEventArgs> OnLocalServerRequest;
        public event EventHandler<LocalErrorEventArgs> OnError;

        private string _directory;
        private CommandRouter _commandRouter;
        private static Thread listenerThread;
        private static Lazy<LocalServer> _lazyInstance = new Lazy<LocalServer>(() => new LocalServer());
        private ILILOServerOptions ServerOptions { get; set; }

        public string InstanceName => "LocalServer Controller";
        public object InstanceContainer => Instance;

        private HttpListener _listener;

        public Dictionary<string, string> FileTypesLocal = new Dictionary<string, string>()
        {
            { ".txt", "textEditor" },
            { ".log", "textEditor" },
            { ".lic", "textEditor" },
            { ".xml", "textEditor" },
            { ".docx", "textEditor" },
            { ".cs", "textEditor" },
        };

        public async Task<bool> ToHostConsole(string Message,HttpListenerContext cn) 
        { 
            ArgumentNullException.ThrowIfNullOrEmpty(Message, nameof(Message));

            try
            {
                OnLocalServerRequest?.Invoke(this, new LocalServerEventArgs()
                {
                    ListenerContext = cn,
                    DateTime = DateTime.Now,
                    IsRunning = true,
                    Message = Message,
                });

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Task<InitializationResponse> Initialization(ILILOServerOptions serverOptions)
        {
            _listener = new HttpListener();
            _directory = serverOptions.SourceDirectory;
            _requestHandler = serverOptions.RequestHandler ?? RequestHandler;
            serverOptions.RequestHandler = _requestHandler;
            ServerOptions = serverOptions;
            _commandRouter = new CommandRouter(new CommandHandlerFactory(this));

            EngineEventHandler.Instance.AddEvent(new Core.Local.Types.WEB_ENGINE_EVENT()
            {
                Name = "Initialization",
                Description = "Creating the Engine.",
                NeedsToAccept = false,
                HappeningTime = DateTime.Now,
            });

            try
            {
                _listener.Prefixes.Add($"http://localhost:{serverOptions.Port.Default}/");
                ListenPort = serverOptions.Port.Default;

                return Task.FromResult(new InitializationResponse()
                {
                    SuccessFull = true,
                    Port = serverOptions.Port.Default
                });
            }
            catch ( Exception ) 
            {
                try
                {
                    _listener.Prefixes.Add($"http://localhost:{serverOptions.Port.Default}/");
                    ListenPort = serverOptions.Port.FallBack;

                    return Task.FromResult(new InitializationResponse()
                    {
                        SuccessFull = true,
                        Port = serverOptions.Port.FallBack
                    });
                }
                catch (Exception ex)
                {
                    return Task.FromResult(new InitializationResponse()
                    {
                        SuccessFull = false,
                        Exception = ex,
                        ErrorMessage = "Failed to register Default/FallBack Port."
                    });
                }
            }


        }

        public async Task<bool> Start()
        {
            try
            {
                _listener.Start();
                _isRunning = true;

                EngineEventHandler.Instance.AddEvent(new Core.Local.Types.WEB_ENGINE_EVENT()
                {
                    Name = "Creating ThreadPoolWorker",
                    Description = "Starting the WebEngine Thread to handle requests.",
                    NeedsToAccept = false,
                    HappeningTime = DateTime.Now,
                });

                if (_listener.IsListening)
                {
                    listenerThread = new Thread(async () =>
                    {
                        EngineEventHandler.Instance.AddEvent(new Core.Local.Types.WEB_ENGINE_EVENT()
                        {
                            Name = "Created ThreadPoolWorker",
                            Description = $"Thread ID: {listenerThread.ManagedThreadId},\nThreadName: {listenerThread.Name},\nThreadState: {listenerThread.ThreadState}",
                            NeedsToAccept = false,
                            HappeningTime = DateTime.Now,
                        });


                        while (true && this.IsRunning && !this.IsDisposed)
                        {
                            var context = await _listener.GetContextAsync();
                            try
                            {
                                await _requestHandler(context);
                            }
                            catch (Exception ex)
                            {

                                var error = new ErrorHandler(new ErrorHtmlDynamic());
                                await error.Handle(context, HttpStatusCode.InternalServerError);
                                OnError?.Invoke(this, new LocalErrorEventArgs(ex.Message,LocalErrorFatality.Asteriks));

                                listenerThread?.Abort();

                                Start();
                            }
                        }
                    });

                    listenerThread.Start();

                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public async Task RequestHandler(HttpListenerContext context)
        {
            var request = context.Request;
            var response = context.Response;
            var error = new ErrorHandler(new ErrorHtmlDynamic());
            var filePath = Path.Combine(_directory, request.Url.LocalPath.TrimStart('/'));
            var ErrorFilePath = Path.Combine(_directory + "\\error\\404\\index.html");
            var indexFilePath = Path.Combine(filePath, "index.html");

            OnLocalServerRequest?.Invoke(this, new LocalServerEventArgs()
            {
                ListenerContext = context,
                DateTime = DateTime.Now,
                IsRunning = true,
                Message = $"[{request.HttpMethod}] Request: " + filePath, 
            });

            EngineLogHandler.Instance.AddEntry(new EngineLogEntry($"[{request.HttpMethod}]**Request:**" + filePath));

            try
            {
                if (File.Exists(filePath))
                {
                    var info = new FileInfo(filePath);

                    if (FileTypesLocal.ContainsKey(info.Extension))
                    {
                        FileTypesLocal.TryGetValue(info.Extension, out string? openIn);

                        if (openIn != null)
                        {
                            if (openIn == "textEditor")
                            {
                                var wrapperIndex = IndexHtml.Instance().MicrosoftWordWrapper(filePath);
                                var content = Encoding.UTF8.GetBytes(wrapperIndex);
                                response.ContentLength64 = content.Length;
                                response.OutputStream.Write(content, 0, content.Length);
                                return;
                            }
                        }
                    }
                    if (info.Extension is ".mp3")
                    {
                        try
                        {
                            var handler = new MediaToStreamHandler();
                            await handler.StreamMediaAsync(request, response);

                            return;
                        }
                        catch (Exception ex)
                        {
                            await error.Handle(context, HttpStatusCode.InternalServerError);
                            OnError?.Invoke(this, new LocalErrorEventArgs(ex.Message, LocalErrorFatality.Asteriks));

                            EngineEventHandler.Instance.AddEvent(ex.Message, this);

                            return;
                        }

                    }

                    var contdent = File.ReadAllBytes(filePath);
                    response.ContentLength64 = contdent.Length;
                    await response.OutputStream.WriteAsync(contdent, 0, contdent.Length);
                }
                else if (Directory.Exists(filePath))
                {
                    if (File.Exists(indexFilePath))
                    {
                        var content = File.ReadAllBytes(indexFilePath);
                        response.ContentLength64 = content.Length;
                        response.OutputStream.Write(content, 0, content.Length);
                    }
                    else
                    {
                        var indexHtml = IndexHtml.Instance().Generate(filePath, 
                            ServerOptions.ServerName ?? "LILO_WebEngine");
                        var content = Encoding.UTF8.GetBytes(indexHtml);
                        response.ContentLength64 = content.Length;
                        response.OutputStream.Write(content, 0, content.Length);
                    }
                }
                else if (request.Url.LocalPath.TrimStart('/').Contains("api"))
                {
                    try
                    {
                        await _commandRouter.HandleRequest(request, response, context);
                    }
                    catch(Exception ex)
                    {
                        await error.Handle(context, HttpStatusCode.InternalServerError, ex);
                        EngineEventHandler.Instance.AddEvent(ex.Message, this);
                    }
                }
                else 
                {
                    await error.Handle(context, HttpStatusCode.NotFound);
                }

                response.Close();
            }
            catch (Exception ex)
            {
                OnError?.Invoke(this, new LocalErrorEventArgs($"Error while WebEngine was iddle: {ex.Message}",LocalErrorFatality.Asteriks));

                EngineEventHandler.Instance.AddEvent(new Core.Local.Types.WEB_ENGINE_EVENT()
                {
                    Name = "!!!ERROR!!!!",
                    Description = $"{ex.Message}\n\nThread ID: {listenerThread.ManagedThreadId},\nThreadName: {listenerThread.Name},\nThreadState: {listenerThread.ThreadState}",
                    NeedsToAccept = false,
                    HappeningTime = DateTime.Now,
                });
            }

            
        }

        public bool IsDisposed;

        public void Dispose()
        {
            IsDisposed = true;
            _listener.Stop();
            _listener.Close();
        }

        public Task Stop()
        {
            this.Dispose();
            return Task.CompletedTask;
        }
    }
}
