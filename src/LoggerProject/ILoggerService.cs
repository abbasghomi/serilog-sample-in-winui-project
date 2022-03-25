using LoggerProject.Enums;

namespace LoggerProject
{
    public interface ILoggerService
    {
        string GetLogFolderPath();
        void Log(LogLevel logLevel, string log);
        void Dispose();
    }
}