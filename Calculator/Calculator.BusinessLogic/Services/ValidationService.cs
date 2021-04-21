using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.BusinessLogic.Services
{
    public class ValidationService : IValidationService
    {
        private readonly List<string> _errors;

        public ValidationService()
        {
            _errors = new List<string>();
        }

        public bool validate(double number)
        {
            var isValid =  number >= 0 && number <= 1;

            if (!isValid)
            {
                _errors.Add($"{number} is not a value between 0 and 1");
            }

            return isValid;
        }

        public List<string> Errors => _errors;
    }
}
