using static LILO_Packager.v2.Shared.Logger;

namespace LILO_Packager.v2.Shared
{
    public interface ILILOLogger
    {
        public string logFilePath { get; }
        public void Log(string message, LogLevel logLevel = LogLevel.Info);
    }
}
