
namespace LILO_Packager.v2.Shared
{
    public interface ILILOConsoleManager
    {
        void EndSession();
        void HideConsoleWindow();
        void InitializeLogger();
        void Log(string message, Logger.LogLevel level = Logger.LogLevel.Info);
        void SetConsoleColors(ConsoleColor foregroundColor, ConsoleColor backgroundColor);
        void ShowConsoleWindow(string header = "Debug Console");
        void WriteLineWithColor(string text, ConsoleColor color = ConsoleColor.Yellow);
    }
}