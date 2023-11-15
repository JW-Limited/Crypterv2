namespace LILO_WebEngine.Core.Handler
{
    public class EngineLogEntry
    {
        public EngineLogEntry()
        {

        }

        public EngineLogEntry(string log, LogEntryType type = LogEntryType.Info) 
        { 
            this.Log = log;
            this.Type = type;   
        }

        public enum LogEntryType
        {
            Info = 1,
            Error = 2,
            FatalError = 4
        }

        public string Log { get; set; } = string.Empty;
        public LogEntryType Type { get; set; } 
        public DateTime TimeStamp { get ; set; } = DateTime.Now;
    }
}
