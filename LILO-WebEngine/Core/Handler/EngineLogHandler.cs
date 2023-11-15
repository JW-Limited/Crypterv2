using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_WebEngine.Core.Handler
{
    public class EngineLogHandler
    {
        private static Lazy<EngineLogHandler> instance = new Lazy<EngineLogHandler>(() => new EngineLogHandler());
        
        public static EngineLogHandler Instance => instance.Value;

        public List<EngineLogEntry> LogEntries { get; private set; } = new List<EngineLogEntry>();

        public void AddEntry(EngineLogEntry entry)
        {
            ArgumentNullException.ThrowIfNull(entry);

            if(entry.Log is not null or "")
            {
                LogEntries.Add(entry);
            }
        }
    }
}
