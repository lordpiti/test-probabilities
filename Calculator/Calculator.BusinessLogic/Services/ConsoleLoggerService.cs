using System;

namespace Calculator.BusinessLogic.Services
{
    public class ConsoleLoggerService : ILoggerService
    {
        public void WriteLine(DateTime datetime, string description, string result)
        {
            Console.WriteLine($"{DateTime.Now} - {description}, Result:{result}{Environment.NewLine}");
        }
    }
}
