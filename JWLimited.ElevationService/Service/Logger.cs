namespace JWLimited.ElevationService.Service
{
    public class Logger : ILogger
    {
        private readonly string logFilePath;
        private readonly LogLevel minimumLogLevel;

        public Logger(string logFilePath, LogLevel minimumLogLevel)
        {
            this.logFilePath = logFilePath;
            this.minimumLogLevel = minimumLogLevel;
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            // In a more complex implementation, you might implement logic for logging scopes
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel >= minimumLogLevel;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
            }

            string logEntry = $"{DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ")} [{logLevel}] [{eventId}] - {formatter(state, exception)}";

            // Log to console
            Console.WriteLine(logEntry);

            // Log to file
            WriteToFile(logEntry);
        }

        private void WriteToFile(string logEntry)
        {
            try
            {
                // In a more complex scenario, you might want to handle file writing asynchronously or using a dedicated logging library
                System.IO.File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
            }
            catch (Exception ex)
            {
                // Handle file writing errors
                Console.WriteLine($"Error writing to log file: {ex.Message}");
            }
        }
    }

}
