using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.BusinessLogic.Services
{
    /// <summary>
    /// Represents a validation service which also stores a list of validation errors
    /// </summary>
    public interface IValidationService
    {
        bool validate(double number);

        public List<string> Errors { get; }
    }
}
