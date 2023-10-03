using static LILO_Packager.v2.shared.Logger;

namespace LILO_Packager.v2.shared
{
    public interface ILILOLogger
    {
        public string logFilePath { get; }
        public void Log(string message, LogLevel logLevel = LogLevel.Info);
    }
}
