using LoggerProject.Enums;
using Serilog.Core;

namespace LoggerProject.Loggers
{
    public class LogHandler
    {
        public static void Log(Logger logger, LogLevel logLevel, string Message)
        {
            IBaseLogger baseLogger = new InformationLogger();

            switch (logLevel)
            {
                case LogLevel.Information:
                    baseLogger = new InformationLogger();
                    break;
                case LogLevel.Warning:
                    baseLogger = new WarningLogger();
                    break;
                case LogLevel.Error:
                    baseLogger = new ErrorLogger();
                    break;
                case LogLevel.Fatal:
                    baseLogger = new FatalLogger();
                    break;
            }

            baseLogger.Log(logger, Message);
        }
    }
}
