using System;
using System.Collections.Concurrent;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LILO_WebEngine.Core.Handler;
using LILO_WebEngine.Core.Local;

namespace LILO_WebEngine.Core.Security
{
    /// <summary>
    /// Logs HTTP requests and responses to facilitate security monitoring
    /// </summary>
    public class RequestLogger
    {
        private readonly ConcurrentQueue<LogEntry> _logQueue = new ConcurrentQueue<LogEntry>();
        private readonly Timer _flushTimer;
        private readonly string _logDirectory;
        private readonly string _requestLogPath;
        private readonly string _errorLogPath;
        private readonly object _logFileLock = new object();
        private bool _isEnabled = true;
        private LogLevel _logLevel = LogLevel.Info;
        
        /// <summary>
        /// Creates a new request logger
        /// </summary>
        public RequestLogger()
        {
            // Set up log directory
            _logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");
            Directory.CreateDirectory(_logDirectory);
            
            // Set up log files
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd");
            _requestLogPath = Path.Combine(_logDirectory, $"requests_{timestamp}.log");
            _errorLogPath = Path.Combine(_logDirectory, $"errors_{timestamp}.log");
            
            // Initialize a timer to flush logs periodically
            _flushTimer = new Timer(_ => FlushLogs(), null, TimeSpan.FromSeconds(10), TimeSpan.FromSeconds(10));
        }
        
        /// <summary>
        /// Gets or sets whether logging is enabled
        /// </summary>
        public bool IsEnabled
        {
            get => _isEnabled;
            set => _isEnabled = value;
        }
        
        /// <summary>
        /// Gets or sets the logging level
        /// </summary>
        public LogLevel LogLevel
        {
            get => _logLevel;
            set => _logLevel = value;
        }
        
        /// <summary>
        /// Logs an HTTP request
        /// </summary>
        public void LogRequest(HttpListenerRequest request)
        {
            if (!_isEnabled || _logLevel < LogLevel.Info)
            {
                return;
            }
            
            var entry = new LogEntry
            {
                Type = LogEntryType.Request,
                Timestamp = DateTime.UtcNow,
                RemoteAddress = request.RemoteEndPoint.ToString(),
                Method = request.HttpMethod,
                Path = request.Url.AbsolutePath,
                QueryString = request.Url.Query,
                UserAgent = request.UserAgent,
                Referrer = request.UrlReferrer?.ToString(),
                Protocol = request.ProtocolVersion.ToString()
            };
            
            _logQueue.Enqueue(entry);
        }
        
        /// <summary>
        /// Logs an HTTP response
        /// </summary>
        public void LogResponse(HttpListenerRequest request, HttpListenerResponse response)
        {
            if (!_isEnabled || _logLevel < LogLevel.Info)
            {
                return;
            }
            
            var entry = new LogEntry
            {
                Type = LogEntryType.Response,
                Timestamp = DateTime.UtcNow,
                RemoteAddress = request.RemoteEndPoint.ToString(),
                Method = request.HttpMethod,
                Path = request.Url.AbsolutePath,
                StatusCode = response.StatusCode,
                ContentType = response.ContentType,
                ContentLength = response.ContentLength64
            };
            
            _logQueue.Enqueue(entry);
        }
        
        /// <summary>
        /// Logs an error
        /// </summary>
        public void LogError(string message, Exception exception = null)
        {
            if (!_isEnabled || _logLevel < LogLevel.Error)
            {
                return;
            }
            
            var entry = new LogEntry
            {
                Type = LogEntryType.Error,
                Timestamp = DateTime.UtcNow,
                Message = message,
                Exception = exception?.ToString()
            };
            
            _logQueue.Enqueue(entry);
            
            // Also log to engine log handler
            EngineLogHandler.Instance.AddEntry(new EngineLogEntry(message));
        }
        
        /// <summary>
        /// Flushes buffered logs to disk
        /// </summary>
        public void FlushLogs()
        {
            if (_logQueue.IsEmpty)
            {
                return;
            }
            
            // Process request logs
            var requestBuilder = new StringBuilder();
            var errorBuilder = new StringBuilder();
            
            // Dequeue all entries and format them for writing
            while (_logQueue.TryDequeue(out var entry))
            {
                string formattedEntry = FormatLogEntry(entry);
                
                if (entry.Type == LogEntryType.Error)
                {
                    errorBuilder.AppendLine(formattedEntry);
                }
                else
                {
                    requestBuilder.AppendLine(formattedEntry);
                }
            }
            
            // Write to log files
            try
            {
                lock (_logFileLock)
                {
                    if (requestBuilder.Length > 0)
                    {
                        File.AppendAllText(_requestLogPath, requestBuilder.ToString());
                    }
                    
                    if (errorBuilder.Length > 0)
                    {
                        File.AppendAllText(_errorLogPath, errorBuilder.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error to engine
                EngineLogHandler.Instance.AddEntry(
                    new EngineLogEntry($"Failed to write to log file: {ex.Message}"));
            }
        }
        
        /// <summary>
        /// Formats a log entry for writing to a log file
        /// </summary>
        private string FormatLogEntry(LogEntry entry)
        {
            string timestamp = entry.Timestamp.ToString("yyyy-MM-dd HH:mm:ss.fff");
            
            switch (entry.Type)
            {
                case LogEntryType.Request:
                    return $"[{timestamp}] REQUEST {entry.RemoteAddress} {entry.Method} {entry.Path}{entry.QueryString} " +
                           $"({entry.Protocol}) User-Agent: {entry.UserAgent}";
                    
                case LogEntryType.Response:
                    return $"[{timestamp}] RESPONSE {entry.RemoteAddress} {entry.Method} {entry.Path} " +
                           $"Status: {entry.StatusCode} Content-Type: {entry.ContentType} Length: {entry.ContentLength}";
                    
                case LogEntryType.Error:
                    return $"[{timestamp}] ERROR {entry.Message}" +
                           (string.IsNullOrEmpty(entry.Exception) ? "" : $"\n{entry.Exception}");
                    
                default:
                    return $"[{timestamp}] {entry.Message}";
            }
        }
    }
    
    /// <summary>
    /// Represents a log entry
    /// </summary>
    public class LogEntry
    {
        public LogEntryType Type { get; set; }
        public DateTime Timestamp { get; set; }
        public string RemoteAddress { get; set; }
        public string Method { get; set; }
        public string Path { get; set; }
        public string QueryString { get; set; }
        public string UserAgent { get; set; }
        public string Referrer { get; set; }
        public string Protocol { get; set; }
        public int StatusCode { get; set; }
        public string ContentType { get; set; }
        public long ContentLength { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
    }
    
    /// <summary>
    /// Types of log entries
    /// </summary>
    public enum LogEntryType
    {
        Request,
        Response,
        Error,
        Info
    }
    
    /// <summary>
    /// Log levels
    /// </summary>
    public enum LogLevel
    {
        None = 0,
        Error = 1,
        Warning = 2,
        Info = 3,
        Debug = 4
    }
} 