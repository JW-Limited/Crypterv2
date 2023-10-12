using Crypterv2.LogAnalyzer.Contracts;

namespace Crypterv2.LogAnalyzer.Models
{
    public class LogEntry : ILogEntry
    {
        public DateTime Timestamp { get; set; }
        public string LogLevel { get; set; }
        public string Message { get; set; }

        public LogEntry(DateTime timestamp, string logLevel, string message)
        {
            Timestamp = timestamp;
            LogLevel = logLevel;
            Message = message;
        }
    }
}
