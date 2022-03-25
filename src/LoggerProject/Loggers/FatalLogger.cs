using Serilog.Core;

namespace LoggerProject.Loggers
{
    public class FatalLogger : IBaseLogger
    {
        public void Log(Logger logger, string message)
        {
            logger.Fatal(message);
        }
    }
}
