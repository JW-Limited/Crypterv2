using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.shared
{
    public class Logger
    {
        private static readonly Lazy<Logger> lazyInstance = new Lazy<Logger>(() => new Logger());
        private static readonly object padlock = new object();
        private readonly string logFilePath;
        private readonly ConcurrentQueue<string> logQueue = new ConcurrentQueue<string>();
        private readonly SemaphoreSlim semaphore = new SemaphoreSlim(1);

        private Logger()
        {
            var _sessionId = GenerateSessionId();
            logFilePath = Path.Combine(Application.ExecutablePath.Replace("crypterv2.exe", ""), "log") + "\\" + $"log_session_{_sessionId}.dbgsl";
        }


        private string GenerateSessionId()
        {
            return $"{DateTime.Now:yyyyMMdd_HHmmss}_{Guid.NewGuid():N}";
        }

        public static Logger Instance => lazyInstance.Value;

        public void Log(string message, LogLevel logLevel = LogLevel.Info)
        {
            string logLine = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} [{logLevel.ToString().ToUpper()}] - {message}";
            logQueue.Enqueue(logLine);
            _ = WriteLogAsync();
        }

        public async Task<List<string>> ReadLogAsync()
        {
            List<string> log = new List<string>();
            if (File.Exists(logFilePath))
            {
                using (StreamReader sr = File.OpenText(logFilePath))
                {
                    string line;
                    while ((line = await sr.ReadLineAsync()) != null)
                    {
                        log.Add(line);
                    }
                }
            }
            return log;
        }

        public void LogConsoleOutput()
        {
            TextWriter writer = new StringWriter();
            Console.SetOut(writer);

            Console.CancelKeyPress += (sender, args) =>
            {
                string consoleOutput = writer.ToString();
                Log(consoleOutput, LogLevel.Info);
                Console.SetOut(Console.Out);
            };
        }

        private async Task WriteLogAsync()
        {
            await semaphore.WaitAsync();
            try
            {
                using (StreamWriter sw = File.AppendText(logFilePath))
                {
                    while (logQueue.TryDequeue(out string logLine))
                    {
                        await sw.WriteLineAsync(logLine);
                    }
                }
            }
            finally
            {
                semaphore.Release();
            }
        }

        public void ClearLog()
        {
            File.Delete(logFilePath);
        }

        public enum LogLevel
        {
            Error,
            Warning,
            Info
        }
    }
}
