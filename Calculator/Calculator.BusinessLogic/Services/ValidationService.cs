using System.Collections.Generic;

namespace Calculator.BusinessLogic.Services
{
    public class ValidationService : IValidationService
    {
        private readonly List<string> _errors;

        public ValidationService()
        {
            _errors = new List<string>();
        }

        /// <summary>
        /// Validates if a number is between 0 and 1
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool validate(double number)
        {
            var isValid =  number >= 0 && number <= 1;

            // If the number is not valid, add a string to the error list to be used later if required
            if (!isValid)
            {
                _errors.Add($"{number} is not a value between 0 and 1");
            }

            return isValid;
        }

        /// <summary>
        /// Returns the list of validation errors
        /// </summary>
        public List<string> Errors => _errors;
    }
}
