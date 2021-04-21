using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.BusinessLogic.Services
{
    public interface IValidationService
    {
        bool validate(double number);
    }
}
