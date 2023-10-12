namespace Crypterv2.LogAnalyzer.Contracts
{
    public interface ILogEntry
    {
        string LogLevel { get; set; }
        string Message { get; set; }
        DateTime Timestamp { get; set; }
    }
}