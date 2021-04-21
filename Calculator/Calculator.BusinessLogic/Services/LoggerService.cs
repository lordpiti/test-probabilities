using System;
using System.IO;

namespace Calculator.BusinessLogic.Services
{
    public class LoggerService : ILoggerService
    {
        public void WriteLine(DateTime datetime, string description, string result)
        {
            var outputFilePath = AppDomain.CurrentDomain.BaseDirectory;

            File.AppendAllText($"{outputFilePath}file.txt", $"{DateTime.Now} - {description}, Result:{result}{Environment.NewLine}");
        }
    }
}
