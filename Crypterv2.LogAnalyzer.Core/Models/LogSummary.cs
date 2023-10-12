using Crypterv2.LogAnalyzer.Contracts;

namespace Crypterv2.LogAnalyzer.Models
{
    public class LogSummary : ILogSummary
    {
        private readonly List<LogEntry> logEntries;

        public LogSummary(List<LogEntry> logEntries)
        {
            this.logEntries = logEntries;
        }

        public List<LogEntry> LogEntries => logEntries;

        public Dictionary<string, int> CategoryCounts { get; private set; }

        public string DiagnosticSummary { get; private set; }

        public void CategorizeLogEntries()
        {
            CategoryCounts = new Dictionary<string, int>();

            foreach (var logEntry in logEntries)
            {
                var category = logEntry.LogLevel;

                if (!CategoryCounts.ContainsKey(category))
                {
                    CategoryCounts.Add(category, 0);
                }

                CategoryCounts[category]++;
            }
        }

        public void GenerateDiagnosticSummary()
        {
            DiagnosticSummary = $"Log summary:\n";

            foreach (var category in CategoryCounts.Keys)
            {
                DiagnosticSummary += $"{category}: {CategoryCounts[category]}\n";
            }
        }
    }
}
