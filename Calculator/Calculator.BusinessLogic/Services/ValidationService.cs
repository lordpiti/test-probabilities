using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.BusinessLogic.Services
{
    public class ValidationService : IValidationService
    {
        public bool validate(double number)
        {
            return number > 0 && number < 1;
        }
    }
}
