namespace LILO_Packager.v2.Core.BugBarrier.Types
{
    public interface ICustomError
    {
        string ApplicationVersion { get; set; }
        Exception Exception { get; set; }
        string InnerExceptionMessage { get; set; }
        string MachineName { get; set; }
        string Message { get; set; }
        ErrorMessageParser ParsedMessage { get; set; }
        ErrorCatcher.ErrorRank Rank { get; set; }
        string Source { get; set; }
        string StackTrace { get; set; }
        DateTime Timestamp { get; set; }
        string Username { get; set; }
    }
}