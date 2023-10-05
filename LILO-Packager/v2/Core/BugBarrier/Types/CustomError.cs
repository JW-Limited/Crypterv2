using static LILO_Packager.v2.Core.BugBarrier.ErrorCatcher;

namespace LILO_Packager.v2.Core.BugBarrier.Types
{
    public class CustomError : ICustomError
    {
        public ErrorRank Rank { get; set; }
        public Exception Exception { get; set; }
        public DateTime Timestamp { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
        public string StackTrace { get; set; }
        public string InnerExceptionMessage { get; set; }
        public string MachineName { get; set; }
        public string Username { get; set; }
        public ErrorMessageParser ParsedMessage { get; set; }
        public string ApplicationVersion { get; set; }

        public CustomError(ErrorRank rank, Exception exception, DateTime timestamp, string message)
        {
            Rank = rank;
            Exception = exception;
            Timestamp = timestamp;
            Message = message;

            Source = exception.Source ?? "N/A";
            ParsedMessage = new ErrorMessageParser("Unhandled Exception:\n\n" + exception.ToString(),exception);
            StackTrace = exception.StackTrace ?? "N/A";
            InnerExceptionMessage = exception.InnerException?.Message ?? "N/A";
            MachineName = Environment.MachineName ?? "N/A";
            Username = Environment.UserName ?? "N/A";
            ApplicationVersion = Program.Version;
        }
    }
}
