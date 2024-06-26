﻿using System.Runtime.InteropServices;

namespace LILO_Packager.v2.Shared
{

    public class ConsoleManager : ILILOConsoleManager
    {
        private string _sessionId;
        private static bool _consoleAllocated = false;
        private static StreamWriter _writer;
        private bool SessionIdGenerated = false;
        private string SessionId = string.Empty;

        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();

        private static ConsoleManager _instance;
        private StreamWriter _logWriter;

        public static ConsoleManager Instance()
        {
            if (_instance == null)
            {
                _instance = new ConsoleManager();
            }

            return _instance;
        }

        /// <inheritdoc[cref = "link-ref"][select = "filter-expr"] />
        public void InitializeLogger()
        {
            if (!Directory.Exists(Path.Combine(Application.ExecutablePath.Replace("crypterv2.exe", ""), "log")))
            {
                Directory.CreateDirectory(Path.Combine(Application.ExecutablePath.Replace("crypterv2.exe", ""), "log"));
            }
            _sessionId = GetSessionID();
            Program.InstanceCacheContainer.Register<ILILOConsoleManager>(() => _instance);

            WriteLineWithColor("Initialized Logger Instance.");
        }

        /// <inheritdoc/>
        private string GetSessionID()
        {
            if (!SessionIdGenerated)
            {
                var id = $"{DateTime.Now:yyyyMMdd_HHmmss}_{Guid.NewGuid():N}";

                WriteLineWithColor($"Generated Session ID - {id}.");

                SessionId = id;
                return id;
            }
            return SessionId;
        }


        /// <inheritdoc[cref = "link-ref"][select = "filter-expr"] />
        public void ShowConsoleWindow(string header = "Debug Console")
        {
            if (!_consoleAllocated)
            {
                AllocConsole();
                _writer = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
                Console.SetOut(_writer);
                Console.SetError(_writer);
                _consoleAllocated = true;
            }

            Console.Clear();
            Console.Title = header;
        }

        /// <inheritdoc/>
        public void HideConsoleWindow()
        {
            if (_consoleAllocated)
            {
                _writer.Flush();
                _writer.Close();
                FreeConsole();
                _consoleAllocated = false;
            }
        }

        /// <inheritdoc/>
        public void SetConsoleColors(ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;
        }

        /// <inheritdoc/>
        public void WriteLineWithColor(string text, ConsoleColor color = ConsoleColor.Yellow)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"[{DateTime.Now}] - " + text);
            Console.ResetColor();
            Log(text);
        }

        public void Log(string message, Logger.LogLevel level = Logger.LogLevel.Info)
        {
            Logger.Instance.Log($"{message}", level);
        }

        public void EndSession()
        {
            _logWriter?.Close();
            _logWriter = null;
        }
    }

}
