using Serilog.Core;

namespace LoggerProject.Loggers
{
    public class WarningLogger : IBaseLogger
    {
        public void Log(Logger logger, string message)
        {
            logger.Warning(message);
        }
    }
}
