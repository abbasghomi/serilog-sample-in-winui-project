using Serilog.Core;

namespace LoggerProject.Loggers
{
    public class InformationLogger : IBaseLogger
    {
        public void Log(Logger logger, string message)
        {
            logger.Information(message);
        }
    }
}
