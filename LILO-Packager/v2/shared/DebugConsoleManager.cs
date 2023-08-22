using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.shared
{
    public class ConsoleManager
    {
        private static bool _consoleAllocated = false;
        private static StreamWriter _writer;

        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();

        private static ConsoleManager _instance;

        public static ConsoleManager Instance()
        {
            if (_instance == null)
            {
                _instance = new ConsoleManager();
            }

            return _instance;
        }


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

        public void SetConsoleColors(ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;
        }

        public void WriteLineWithColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"[{DateTime.Now}] - " + text);
            Console.ResetColor();
        }
    }
}
