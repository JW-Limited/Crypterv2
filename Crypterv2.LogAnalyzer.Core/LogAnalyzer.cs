using System.Text.RegularExpressions;
using Crypterv2.LogAnalyzer.Models;

namespace Crypterv2.LogAnalyzer
{
    public class LogAnalyzer
    {
        private readonly Regex logEntryRegex = new Regex(@"^(?<timestamp>\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2}) \[(?<logLevel>\w+)\] - (?<message>.*)$");

        public LogSummary AnalyzeLog(string log)
        {
            if (string.IsNullOrWhiteSpace(log))
            {
                return new LogSummary(new List<LogEntry>());
            }


            var logEntries = logEntryRegex.Matches(log)
                .Select(match => new LogEntry(DateTime.Parse(match.Groups["timestamp"].Value), match.Groups["logLevel"].Value, match.Groups["message"].Value))
                .ToList();

            var logSummary = new LogSummary(logEntries);

            logSummary.CategorizeLogEntries();
            logSummary.GenerateDiagnosticSummary();

            return logSummary;
        }
    }
}
