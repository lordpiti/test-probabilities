using Calculator.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.BusinessLogic.Services
{
    public interface ILoggerService
    {
        void WriteLine(DateTime datetime, string description, string result);
    }
}
