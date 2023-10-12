using Crypterv2.LogAnalyzer.Models;

namespace Crypterv2.LogAnalyzer.Contracts
{
    public interface ILogSummary
    {
        Dictionary<string, int> CategoryCounts { get; }
        string DiagnosticSummary { get; }
        List<LogEntry> LogEntries { get; }
    }
}