using System;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using LILO_WebEngine.Core.Handler;
using LILO_WebEngine.Core.Local;
using LILO_WebEngine.Core.Security;

namespace LILO_WebEngine.Core.Middleware
{
    /// <summary>
    /// Middleware for tracking request metrics (timing, etc.)
    /// </summary>
    public class RequestMetricsMiddleware : RequestMiddlewareBase
    {
        private const string TimerKey = "RequestMetrics.Timer";
        
        protected override Task HandleRequestAsync(MiddlewareContext context)
        {
            // Start a stopwatch to measure request duration
            var stopwatch = Stopwatch.StartNew();
            context.Items[TimerKey] = stopwatch;
            
            return Task.CompletedTask;
        }
        
        protected override Task AfterRequestAsync(MiddlewareContext context)
        {
            if (context.Items.TryGetValue(TimerKey, out var timerObj) && timerObj is Stopwatch stopwatch)
            {
                stopwatch.Stop();
                var requestDuration = stopwatch.ElapsedMilliseconds;
                
                // Add request duration to response headers
                try
                {
                    context.Context.Response.Headers.Add("X-Request-Duration-Ms", requestDuration.ToString());
                }
                catch
                {
                    // Ignore if headers already sent
                }
                
                // Log request timing
                EngineLogHandler.Instance.AddEntry(
                    new EngineLogEntry($"Request timing: {context.Context.Request.HttpMethod} {context.Context.Request.Url.AbsolutePath} - {requestDuration}ms"));
            }
            
            return Task.CompletedTask;
        }
    }
    
    /// <summary>
    /// Middleware for IP filtering
    /// </summary>
    public class IpFilterMiddleware : RequestMiddlewareBase
    {
        private readonly IpAddressFilter _ipFilter;
        
        public IpFilterMiddleware(IpAddressFilter ipFilter)
        {
            _ipFilter = ipFilter ?? throw new ArgumentNullException(nameof(ipFilter));
        }
        
        protected override Task HandleRequestAsync(MiddlewareContext context)
        {
            var request = context.Context.Request;
            var ipAddress = request.RemoteEndPoint.Address;
            
            if (!_ipFilter.IsAllowed(ipAddress))
            {
                // IP is blocked, return 403 Forbidden
                var response = context.Context.Response;
                response.StatusCode = (int)HttpStatusCode.Forbidden;
                response.ContentType = "text/plain";
                
                string message = "Access denied by IP filter.";
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.Close();
                
                // Mark response as sent
                context.IsResponseSent = true;
                
                // Log blocked request
                EngineLogHandler.Instance.AddEntry(
                    new EngineLogEntry($"Blocked request from {ipAddress}: {request.HttpMethod} {request.Url.AbsolutePath}"));
            }
            
            return Task.CompletedTask;
        }
    }
    
    /// <summary>
    /// Middleware for rate limiting
    /// </summary>
    
    
    /// <summary>
    /// Middleware for request logging
    /// </summary>
    public class RequestLoggingMiddleware : RequestMiddlewareBase
    {
        private readonly RequestLogger _logger;
        
        public RequestLoggingMiddleware(RequestLogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        
        protected override Task HandleRequestAsync(MiddlewareContext context)
        {
            var request = context.Context.Request;
            
            // Log the incoming request
            _logger.LogRequest(request);
            
            return Task.CompletedTask;
        }
        
        protected override Task AfterRequestAsync(MiddlewareContext context)
        {
            var response = context.Context.Response;
            
            // Log the response
            _logger.LogResponse(context.Context.Request, response);
            
            return Task.CompletedTask;
        }
    }
    
    /// <summary>
    /// Middleware for authentication
    /// </summary>
    public class AuthenticationMiddleware : RequestMiddlewareBase
    {
        private readonly IAuthenticationProvider _authProvider;
        
        public AuthenticationMiddleware(IAuthenticationProvider authProvider)
        {
            _authProvider = authProvider ?? throw new ArgumentNullException(nameof(authProvider));
        }
        
        protected override async Task HandleRequestAsync(MiddlewareContext context)
        {
            var request = context.Context.Request;
            
            // Check if this route requires authentication
            if (_authProvider.RequiresAuthentication(request.Url.AbsolutePath))
            {
                // Extract credentials from the request
                var authResult = await _authProvider.AuthenticateAsync(request);
                
                if (!authResult.IsAuthenticated)
                {
                    // Authentication failed, return 401 Unauthorized
                    var response = context.Context.Response;
                    response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    response.Headers.Add("WWW-Authenticate", "Basic realm=\"LILO Web Engine\"");
                    response.ContentType = "text/plain";
                    
                    string message = "Authentication required.";
                    byte[] buffer = Encoding.UTF8.GetBytes(message);
                    response.ContentLength64 = buffer.Length;
                    response.OutputStream.Write(buffer, 0, buffer.Length);
                    response.Close();
                    
                    // Mark response as sent
                    context.IsResponseSent = true;
                    
                    // Log authentication failure
                    EngineLogHandler.Instance.AddEntry(
                        new EngineLogEntry($"Authentication failed for {request.RemoteEndPoint.Address}: {request.HttpMethod} {request.Url.AbsolutePath}"));
                }
                else
                {
                    // Authentication successful, store user info in context
                    context.Items["User"] = authResult.User;
                    
                    // Log successful authentication
                    EngineLogHandler.Instance.AddEntry(
                        new EngineLogEntry($"Authentication successful for user {authResult.User.Identity.Name}"));
                }
            }
        }
    }
} 