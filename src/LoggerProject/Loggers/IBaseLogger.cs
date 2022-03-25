using Serilog.Core;

namespace LoggerProject.Loggers
{
    public interface IBaseLogger
    {
        void Log(Logger logger, string message);
    }
}
