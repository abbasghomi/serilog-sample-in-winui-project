using LoggerProject.Enums;
using LoggerProject.Loggers;
using Serilog;
using Serilog.Core;
using System.IO;

namespace LoggerProject
{
    public class LoggerService : ILoggerService
    {
        private Logger _logger;

        public LoggerService()
        {
            _logger = new LoggerConfiguration()
                    .WriteTo.File(Path.Combine(GetLogFolderPath(), "log.txt"),
                                         rollingInterval: RollingInterval.Day, //Set Log file creation interval to daily
                                         rollOnFileSizeLimit: true, //Apply log file size limit policy
                                         fileSizeLimitBytes: 104857600, //100MB log files limit
                                         retainedFileCountLimit: 30 //Keep only last 30 days logs
                                         )
                    .CreateLogger();
        }

        public string GetLogFolderPath()
        {
            var userProfileFolder = System.Environment.GetEnvironmentVariable("USERPROFILE");
            return Path.Combine(userProfileFolder, "CRM_AppLogs");
        }

        public void Log(LogLevel logLevel, string log)
        {
            LogHandler.Log(_logger, logLevel, log);
        }

        public void Dispose()
        {
            _logger?.Dispose();
        }
    }
}
