using Microsoft.Extensions.Options;
using System;
using System.IO;

namespace Calculator.BusinessLogic.Services
{
    public class LoggerService : ILoggerService
    {
        private readonly string _logFilePath;

        public LoggerService(IOptions<AppSettings> options)
        {
            _logFilePath = options.Value.LogFilePath;
        }

        public void WriteLine(DateTime datetime, string description, string result)
        {
            var outputFilePath = AppDomain.CurrentDomain.BaseDirectory;

            File.AppendAllText(_logFilePath, $"{DateTime.Now} - {description}, Result:{result}{Environment.NewLine}");
        }
    }
}
