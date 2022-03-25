using Serilog.Core;

namespace LoggerProject.Loggers
{
    public class ErrorLogger : IBaseLogger
    {
        public void Log(Logger logger, string message)
        {
            logger.Error(message);
        }
    }
}
