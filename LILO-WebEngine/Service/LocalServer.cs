using System.Net;
using System.Text;
using System.Collections.Concurrent;
using LILO_WebEngine.Core.Pages;
using LILO_WebEngine.Core.Handler;
using LILO_WebEngine.Core.Request;
using LILO_WebEngine.Shared;
using LILO_WebEngine.Core.Contracts;
using LILO_WebEngine.Core.Local;
using LILO_WebEngine.Core.Security;
using LILO_WebEngine.Core.Middleware;
using System.Text.Json;
using LILO_WebEngine.Core.WebSockets;

namespace LILO_WebEngine.Service
{
    public partial class LocalServer : IDisposable, ILILOWebService
    {
        #region Properties and Fields
        public string Name => ServerOptions.ServerName ?? "Not Initialized.";
        public bool IsRunning => _isRunning;
        public string SourceDirectory => _directory;
        public int ListenPort { get; set; }
        public bool _isRunning = false;
        public Func<HttpListenerContext, Task> _requestHandler { get; set; }
        public static LocalServer Instance { get { return _lazyInstance.Value; } }
        public ILILOServerOptions Options => ServerOptions;
        public string InstanceName => "WebServer Controller";
        public object InstanceContainer => Instance;
        public bool IsSecure => _isSecure;
        public ServerMode Mode { get; private set; }
        
        public event EventHandler<LocalServerEventArgs> OnLocalServerRequest;
        public event EventHandler<LocalErrorEventArgs> OnError;
        public event EventHandler<ServerStatusEventArgs> OnServerStatusChanged;

        private string _directory;
        private bool _isSecure;
        private CommandRouter _commandRouter;
        private HttpListener _listener;
        private List<Thread> _workerThreads = new();
        private readonly int _threadPoolSize;
        private readonly ConcurrentQueue<HttpListenerContext> _requestQueue = new();
        private readonly AutoResetEvent _requestReady = new(false);
        private readonly SemaphoreSlim _maxConcurrentRequests;
        private static Lazy<LocalServer> _lazyInstance = new Lazy<LocalServer>(() => new LocalServer());
        private ILILOServerOptions ServerOptions { get; set; }
        private RequestMiddlewarePipeline _middlewarePipeline;
        private readonly IpAddressFilter _ipFilter = new();
        private readonly RequestLogger _requestLogger = new();
        private bool IsDisposed;
        #endregion

        #region File Type Handlers
        public Dictionary<string, string> FileTypesLocal = new Dictionary<string, string>()
        {
            { ".txt", "textEditor" },
            { ".log", "textEditor" },
            { ".lic", "textEditor" },
            { ".xml", "textEditor" },
            { ".docx", "textEditor" },
            { ".cs", "textEditor" },
            { ".html", "browser" },
            { ".css", "browser" },
            { ".js", "browser" },
            { ".json", "textEditor" },
            { ".svg", "browser" },
            { ".png", "imageViewer" },
            { ".jpg", "imageViewer" },
            { ".jpeg", "imageViewer" },
            { ".gif", "imageViewer" },
            { ".webp", "imageViewer" },
            { ".mp3", "audioPlayer" },
            { ".mp4", "videoPlayer" },
            { ".webm", "videoPlayer" },
        };
        #endregion

        #region Constructors
        // Private constructor - use Instance for singleton access
        private LocalServer()
        {
            _threadPoolSize = Environment.ProcessorCount * 2;
            _maxConcurrentRequests = new SemaphoreSlim(100); // Limit concurrent requests
            _middlewarePipeline = new RequestMiddlewarePipeline();
            Mode = ServerMode.Local;
        }
        #endregion

        #region Server Control Methods
        public async Task<InitializationResponse> Initialization(ILILOServerOptions serverOptions)
        {
            _listener = new HttpListener();
            _directory = serverOptions.SourceDirectory;
            _requestHandler = serverOptions.RequestHandler ?? RequestHandler;
            serverOptions.RequestHandler = _requestHandler;
            ServerOptions = serverOptions;
            _commandRouter = new CommandRouter(new CommandHandlerFactory(this));
            Mode = serverOptions.ServerMode;

            ConfigureMiddleware();

            EngineEventHandler.Instance.AddEvent(new Core.Local.Types.WEB_ENGINE_EVENT()
            {
                Name = "Initialization",
                Description = $"Creating the Engine in {Mode} mode.",
                NeedsToAccept = false,
                HappeningTime = DateTime.Now,
            });

            try
            {
                // Configure based on server mode
                switch (Mode)
                {
                    case ServerMode.Local:
                _listener.Prefixes.Add($"http://localhost:{serverOptions.Port.Default}/");
                ListenPort = serverOptions.Port.Default;
                        _isSecure = false;
                        break;

                    case ServerMode.Public:
                        if (serverOptions.UseHttps && serverOptions.Certificate != null)
                        {
                            _listener.Prefixes.Add($"https://*:{serverOptions.Port.Default}/");
                            _isSecure = true;
                        }
                        else
                        {
                            _listener.Prefixes.Add($"http://*:{serverOptions.Port.Default}/");
                            _isSecure = false;
                        }
                        ListenPort = serverOptions.Port.Default;
                        break;

                    case ServerMode.Hybrid:
                        _listener.Prefixes.Add($"http://localhost:{serverOptions.Port.Default}/");
                        
                        if (serverOptions.UseHttps && serverOptions.Certificate != null)
                        {
                            _listener.Prefixes.Add($"https://*:{serverOptions.Port.Public}/");
                            _isSecure = true;
                        }
                        else
                        {
                            _listener.Prefixes.Add($"http://*:{serverOptions.Port.Public}/");
                            _isSecure = false;
                        }
                        ListenPort = serverOptions.Port.Default;
                        break;
                }

                return new InitializationResponse()
                {
                    SuccessFull = true,
                    Port = ListenPort,
                    IsSecure = _isSecure,
                    ServerMode = Mode
                };
            }
            catch (Exception ex)
            {
                try
                {
                    _listener.Prefixes.Clear();
                    _listener.Prefixes.Add($"http://localhost:{serverOptions.Port.FallBack}/");
                    ListenPort = serverOptions.Port.FallBack;
                    _isSecure = false;
                    Mode = ServerMode.Local;

                    return new InitializationResponse()
                    {
                        SuccessFull = true,
                        Port = serverOptions.Port.FallBack,
                        IsSecure = false,
                        ServerMode = ServerMode.Local,
                        FallbackActivated = true
                    };
                }
                catch (Exception fallbackEx)
                {
                    return new InitializationResponse()
                    {
                        SuccessFull = false,
                        Exception = fallbackEx,
                        OriginalException = ex,
                        ErrorMessage = "Failed to register Default/FallBack Port."
                    };
                }
            }
        }

        private void ConfigureMiddleware()
        {
            _middlewarePipeline.Clear();
           
            _middlewarePipeline.Add(new RequestMetricsMiddleware());
            
            if (Mode != ServerMode.Local)
            {
                _middlewarePipeline.Add(new IpFilterMiddleware(_ipFilter));
            }
            
            if (ServerOptions.UseAuthentication)
            {
                _middlewarePipeline.Add(new AuthenticationMiddleware(ServerOptions.AuthenticationProvider));
            }
            
            // We're not using LiveReload middleware because we're directly injecting the script
            // into HTML responses in the ServeFile and ServeDirectory methods to avoid issues
            // with trying to modify the read-only Response.OutputStream
            
            _middlewarePipeline.Add(new RequestLoggingMiddleware(_requestLogger));
        }

        public async Task<bool> Start()
        {
            try
            {
                _listener.Start();
                _isRunning = true;

                EngineEventHandler.Instance.AddEvent(new Core.Local.Types.WEB_ENGINE_EVENT()
                {
                    Name = "Creating ThreadPool",
                    Description = $"Starting {_threadPoolSize} worker threads in {Mode} mode.",
                    NeedsToAccept = false,
                    HappeningTime = DateTime.Now,
                });

                if (_listener.IsListening)
                {
                    var acceptorThread = new Thread(AcceptConnections)
                    {
                        IsBackground = true,
                        Name = "RequestAcceptor"
                    };
                    acceptorThread.Start();
                    _workerThreads.Add(acceptorThread);

                    for (int i = 0; i < _threadPoolSize; i++)
                    {
                        var workerThread = new Thread(ProcessRequests)
                        {
                            IsBackground = true,
                            Name = $"RequestProcessor-{i}"
                        };
                        workerThread.Start();
                        _workerThreads.Add(workerThread);
                    }
                    
                    // Start file watcher for the source directory
                    FileWatcher.Instance.WatchDirectory(_directory);

                    RaiseServerStatusChanged(true, $"Server started in {Mode} mode on port {ListenPort}");
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                RaiseError(new LocalErrorEventArgs($"Failed to start server: {ex.Message}", LocalErrorFatality.Critical));
                return false;
            }
        }

        private void AcceptConnections()
        {
            try
            {
                while (_isRunning && !IsDisposed)
                {
                    try
                    {
                        var context = _listener.GetContext();
                        _requestQueue.Enqueue(context);
                        _requestReady.Set();
                    }
                    catch (HttpListenerException ex)
                    {
                        if (_isRunning && !IsDisposed)
                        {
                            RaiseError(new LocalErrorEventArgs($"Error accepting connection: {ex.Message}", LocalErrorFatality.Warning));
                        }
                    }
                    catch (Exception ex)
                    {
                        if (_isRunning && !IsDisposed)
                        {
                            RaiseError(new LocalErrorEventArgs($"Unexpected error in acceptor thread: {ex.Message}", LocalErrorFatality.Severe));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (!IsDisposed)
                {
                    RaiseError(new LocalErrorEventArgs($"Fatal error in acceptor thread: {ex.Message}", LocalErrorFatality.Critical));
                    Restart();
                }
            }
        }

        private async void ProcessRequests()
        {
            while (_isRunning && !IsDisposed)
            {
                HttpListenerContext context = null;
                
                try
                {
                    _requestReady.WaitOne();
                    
                    if (_requestQueue.TryDequeue(out context))
                    {
                        await _maxConcurrentRequests.WaitAsync();
                        
                        try
                        {
                            var middlewareContext = new MiddlewareContext(context);
                            await _middlewarePipeline.ExecuteAsync(middlewareContext);
                            
                            if (!middlewareContext.IsResponseSent)
                            {
                                await _requestHandler(context);
                            }
                        }
                        finally
                        {
                            _maxConcurrentRequests.Release();
                        }
                    }
                }
                catch (Exception ex)
                            {
                    if (context != null)
                    {
                        try
                        {
                                var error = new ErrorHandler(new ErrorHtmlDynamic());
                            await error.Handle(context, HttpStatusCode.InternalServerError, ex);
                        }
                        catch{ }
                    }
                    
                    RaiseError(new LocalErrorEventArgs($"Error processing request: {ex.Message}", LocalErrorFatality.Warning));
                }
            }
        }

        private void Restart()
        {
            if (IsDisposed) return;
            
            try
            {
                Stop();
                Thread.Sleep(1000);
                                Start();
                            }
            catch (Exception ex)
            {
                RaiseError(new LocalErrorEventArgs($"Failed to restart server: {ex.Message}", LocalErrorFatality.Critical));
                            }
                        }

        public async Task Stop()
        {
            _isRunning = false;

            try
            {
                _listener?.Stop();

                // Signal all worker threads to check _isRunning condition
                for (int i = 0; i < _workerThreads.Count; i++)
                {
                    _requestReady.Set();
                }

                // Wait a reasonable time for threads to finish
                await Task.Delay(2000);
                
                // Stop file watcher
                FileWatcher.Instance.Dispose();
                
                RaiseServerStatusChanged(false, "Server stopped");
            }
            catch (Exception ex)
            {
                RaiseError(new LocalErrorEventArgs($"Error stopping server: {ex.Message}", LocalErrorFatality.Warning));
            }
        }
        #endregion

        #region Request Handling
        public async Task RequestHandler(HttpListenerContext context)
        {
            var request = context.Request;
            var response = context.Response;
            var error = new ErrorHandler(new ErrorHtmlDynamic());
            var filePath = Path.Combine(_directory, request.Url.LocalPath.TrimStart('/'));
            var indexFilePath = Path.Combine(filePath, "index.html");

            try
            {
                // Log the request
                await LogRequest(context);
                
                // Check if this is a WebSocket request
                if (request.IsWebSocketRequest && request.Url.LocalPath.EndsWith("/ws"))
                {
                    await WebSocketServer.Instance.HandleWebSocketRequest(context);
                    return;
                }
                
                // Apply security checks for public mode
                if (Mode != ServerMode.Local)
                {
                    // Verify the request is allowed
                    if (!await VerifyRequestAccess(context))
                    {
                        await error.Handle(context, HttpStatusCode.Forbidden);
                        return;
                    }
                }

                // Handle the request based on the path
                if (File.Exists(filePath))
                {
                    await ServeFile(context, filePath);
                }
                else if (Directory.Exists(filePath))
                {
                    await ServeDirectory(context, filePath, indexFilePath);
                }
                else if (request.Url.LocalPath.TrimStart('/').Contains("api"))
                {
                    await HandleApiRequest(context);
                }
                else 
                {
                    await error.Handle(context, HttpStatusCode.NotFound);
                }
            }
            catch (Exception ex)
            {
                await HandleRequestException(context, ex);
            }
            finally
            {
                try
                {
                    // Don't close the response for WebSocket connections
                    if (!context.Request.IsWebSocketRequest && response != null)
                    {
                        response.Close();
                    }
                }
                catch { /* Ignore close errors */ }
            }
        }

        private async Task LogRequest(HttpListenerContext context)
        {
            var request = context.Request;
            var message = $"[{request.HttpMethod}] Request: {request.Url.LocalPath}";

            OnLocalServerRequest?.Invoke(this, new LocalServerEventArgs()
            {
                ListenerContext = context,
                DateTime = DateTime.Now,
                IsRunning = true,
                Message = message,
            });
            
            EngineLogHandler.Instance.AddEntry(
                new EngineLogEntry($"[{request.HttpMethod}]**Request:**{request.Url.LocalPath} from {request.RemoteEndPoint}"));
        }
        
        private async Task<bool> VerifyRequestAccess(HttpListenerContext context)
        {
            // Implementation depends on the security policies
            var request = context.Request;
            
            // Public endpoints should have explicit control
            if (Mode == ServerMode.Public || Mode == ServerMode.Hybrid)
            {
                // Check if the IP is allowed (this would be implemented in your IpFilter class)
                if (!_ipFilter.IsAllowed(request.RemoteEndPoint.Address))
                {
                    return false;
                }
            }
            
            return true;
        }

        private async Task ServeFile(HttpListenerContext context, string filePath)
        {
            var request = context.Request;
            var response = context.Response;
            var fileInfo = new FileInfo(filePath);
            
            // Set MIME type based on extension
            response.ContentType = GetMimeType(fileInfo.Extension);
            
            // Add security headers
            AddSecurityHeaders(response);
            
            // Handle special file types
            if (FileTypesLocal.TryGetValue(fileInfo.Extension, out string openIn))
            {
                switch (openIn)
                {
                    case "textEditor":
                        var wrapperIndex = IndexHtml.Instance().MicrosoftWordWrapper(filePath);
                        var content = Encoding.UTF8.GetBytes(wrapperIndex);
                        response.ContentLength64 = content.Length;
                        await response.OutputStream.WriteAsync(content, 0, content.Length);
                        return;
                        
                    case "audioPlayer":
                    case "videoPlayer":
                        try
                        {
                            var handler = new MediaToStreamHandler();
                            await handler.StreamMediaAsync(request, response);
                        }
                        catch (Exception ex)
                        {
                            var error = new ErrorHandler(new ErrorHtmlDynamic());
                            await error.Handle(context, HttpStatusCode.InternalServerError, ex);
                        }
                        return;
                }
            }
            
            // Check if this is HTML and inject LiveReload script if needed
            if (response.ContentType.Contains("text/html"))
            {
                var html = await File.ReadAllTextAsync(filePath);
                var baseUrl = $"{request.Url.Scheme}://{request.Url.Host}:{request.Url.Port}/";
                var modifiedHtml = LiveReloadScriptInjector.Instance.InjectScriptIntoHtml(html, baseUrl);
                
                var modifiedContent = Encoding.UTF8.GetBytes(modifiedHtml);
                response.ContentLength64 = modifiedContent.Length;
                await response.OutputStream.WriteAsync(modifiedContent, 0, modifiedContent.Length);
                return;
            }
            
            // For normal files, set caching headers based on file type
            SetCachingHeaders(response, fileInfo);
            
            // Send the file with proper chunking for large files
            await SendFileWithChunking(response, filePath);
        }
        
        private async Task SendFileWithChunking(HttpListenerResponse response, string filePath)
        {
            var fileInfo = new FileInfo(filePath);
            response.ContentLength64 = fileInfo.Length;
            
            const int bufferSize = 64 * 1024; // 64KB chunks
            byte[] buffer = new byte[bufferSize];
            
            using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                int bytesRead;
                while ((bytesRead = await fileStream.ReadAsync(buffer, 0, bufferSize)) > 0)
                {
                    await response.OutputStream.WriteAsync(buffer, 0, bytesRead);
                    await response.OutputStream.FlushAsync();
                }
            }
        }

        private void SetCachingHeaders(HttpListenerResponse response, FileInfo fileInfo)
        {
            // Set caching headers based on file type
            string extension = fileInfo.Extension.ToLowerInvariant();
            
            // Static assets can be cached longer
            if (extension == ".css" || extension == ".js" || 
                extension == ".jpg" || extension == ".jpeg" || 
                extension == ".png" || extension == ".gif" || 
                extension == ".svg")
            {
                response.Headers.Add("Cache-Control", "public, max-age=86400"); // 1 day
            }
            else
            {
                response.Headers.Add("Cache-Control", "no-cache, no-store, must-revalidate");
                response.Headers.Add("Pragma", "no-cache");
                response.Headers.Add("Expires", "0");
            }
        }
        
        private void AddSecurityHeaders(HttpListenerResponse response)
        {
            
        }

        private async Task ServeDirectory(HttpListenerContext context, string filePath, string indexFilePath)
        {
            var response = context.Response;
            var request = context.Request;
            
            // Add security headers
            AddSecurityHeaders(response);
            
            if (File.Exists(indexFilePath))
            {
                var html = await File.ReadAllTextAsync(indexFilePath);
                var baseUrl = $"{request.Url.Scheme}://{request.Url.Host}:{request.Url.Port}/";
                var modifiedHtml = LiveReloadScriptInjector.Instance.InjectScriptIntoHtml(html, baseUrl);
                
                response.ContentType = "text/html";
                var content = Encoding.UTF8.GetBytes(modifiedHtml);
                response.ContentLength64 = content.Length;
                await response.OutputStream.WriteAsync(content, 0, content.Length);
            }
            else
            {
                var indexHtml = IndexHtml.Instance().Generate(filePath, 
                    ServerOptions.ServerName ?? "LILO_WebEngine");
                
                var baseUrl = $"{request.Url.Scheme}://{request.Url.Host}:{request.Url.Port}/";
                var modifiedHtml = LiveReloadScriptInjector.Instance.InjectScriptIntoHtml(indexHtml, baseUrl);
                
                response.ContentType = "text/html";
                var content = Encoding.UTF8.GetBytes(modifiedHtml);
                response.ContentLength64 = content.Length;
                await response.OutputStream.WriteAsync(content, 0, content.Length);
            }
        }

        private async Task HandleApiRequest(HttpListenerContext context)
                {
                    try
                    {
                await _commandRouter.HandleRequest(context.Request, context.Response, context);
                    }
                    catch(Exception ex)
                    {
                var error = new ErrorHandler(new ErrorHtmlDynamic());
                        await error.Handle(context, HttpStatusCode.InternalServerError, ex);
                        EngineEventHandler.Instance.AddEvent(ex.Message, this);
                    }
                }

        private async Task HandleRequestException(HttpListenerContext context, Exception ex)
        {
            var errorId = Guid.NewGuid().ToString("N");
            var errorDetails = new
            {
                Id = errorId,
                Timestamp = DateTime.UtcNow,
                RequestPath = context?.Request?.Url?.PathAndQuery,
                RemoteEndpoint = context?.Request?.RemoteEndPoint?.ToString(),
                Exception = new
                {
                    Message = ex.Message,
                    StackTrace = ex.StackTrace,
                    InnerException = ex.InnerException?.Message
                }
            };

            // Strukturiertes Logging
            RaiseError(new LocalErrorEventArgs(
                $"Error ID: {errorId} - {ex.Message}",
                LocalErrorFatality.Warning));

            // Detaillierte Fehlerinfos loggen
            EngineEventHandler.Instance.AddEvent(new Core.Local.Types.WEB_ENGINE_EVENT
            {
                Name = "Request Error",
                Description = JsonSerializer.Serialize(errorDetails),
                NeedsToAccept = false,
                HappeningTime = DateTime.UtcNow
            });

            try
            {
                if (context?.Response?.OutputStream?.CanWrite == true)
                {
                    var error = new ErrorHandler(new ErrorHtmlDynamic());
                    await error.Handle(context, HttpStatusCode.InternalServerError, ex);
                }
            }
            catch { /* Ignore errors in error handling */ }
        }

        private string GetMimeType(string extension)
        {
            switch (extension.ToLowerInvariant())
            {
                case ".html": return "text/html";
                case ".css": return "text/css";
                case ".js": return "application/javascript";
                case ".json": return "application/json";
                case ".jpg":
                case ".jpeg": return "image/jpeg";
                case ".png": return "image/png";
                case ".gif": return "image/gif";
                case ".svg": return "image/svg+xml";
                case ".webp": return "image/webp";
                case ".mp3": return "audio/mpeg";
                case ".mp4": return "video/mp4";
                case ".webm": return "video/webm";
                case ".txt": return "text/plain";
                case ".xml": return "application/xml";
                case ".pdf": return "application/pdf";
                default: return "application/octet-stream";
            }
        }
        #endregion

        #region Helper Methods
        public async Task<bool> ToHostConsole(string Message, HttpListenerContext cn) 
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
            catch (Exception)
            {
                return false;
            }
        }
        
        private void RaiseError(LocalErrorEventArgs args)
        {
            OnError?.Invoke(this, args);
        }
        
        private void RaiseServerStatusChanged(bool isRunning, string message)
        {
            OnServerStatusChanged?.Invoke(this, new ServerStatusEventArgs
            {
                IsRunning = isRunning,
                Message = message,
                Port = ListenPort,
                IsSecure = _isSecure,
                ServerMode = Mode
            });
        }
        #endregion

        #region IDisposable Implementation
        public void Dispose()
        {
            if (IsDisposed) return;
            
            IsDisposed = true;
            _isRunning = false;
            
            // Signal threads to exit
            for (int i = 0; i < _workerThreads.Count; i++)
            {
                _requestReady.Set();
            }
            
            try
            {
                // Dispose file watcher
                FileWatcher.Instance.Dispose();
                
                // Dispose WebSocket server
                WebSocketServer.Instance.Dispose();
                
                _listener?.Stop();
                _listener?.Close();
            }
            catch { /* Ignore disposal errors */ }
            
            _requestReady.Dispose();
            _maxConcurrentRequests.Dispose();
            
            GC.SuppressFinalize(this);
        }
        #endregion
    }

    #region Supporting Types
    public enum ServerMode
    {
        Local,      // Localhost only
        Public,     // Public internet access
        Hybrid      // Both local and public interfaces
    }

    public class ServerStatusEventArgs : EventArgs
    {
        public bool IsRunning { get; set; }
        public string Message { get; set; }
        public int Port { get; set; }
        public bool IsSecure { get; set; }
        public ServerMode ServerMode { get; set; }
    }
    #endregion
}
