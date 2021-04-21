using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.BusinessLogic.Exceptions
{
    public class ValidationException : Exception
    {
        private readonly IEnumerable<string> _validationErrors;

        public ValidationException(IEnumerable<string> errorList)
        {
            _validationErrors = errorList;
        }

        public IEnumerable<string> ValidationErrors => _validationErrors;
    }
}
