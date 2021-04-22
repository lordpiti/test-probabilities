using Calculator.BusinessLogic.Builders;
using Calculator.BusinessLogic.Exceptions;
using Calculator.BusinessLogic.Models;
using Calculator.BusinessLogic.Services;
using System;

namespace Calculator.BusinessLogic
{
    /// <summary>
    /// Concrete implementation on the calculator using the Expression hyerarchy model
    /// </summary>
    public class CalculatorService : ICalculatorService
    {
        private readonly IOperationBuilder _operationBuilder;
        private readonly ILoggerService _loggerService;
        private readonly IValidationService _validationService;

        public CalculatorService(IOperationBuilder operationBuilder, ILoggerService loggerService, IValidationService validationService)
        {
            _operationBuilder = operationBuilder;
            _loggerService = loggerService;
            _validationService = validationService;
        }

        public double getEither(double first, double second)
        {
            // Validate the inputs
            var firstValid = _validationService.validate(first);
            var secondValid = _validationService.validate(second);

            if (!firstValid || !secondValid)
            {
                throw new ValidationException(_validationService.Errors);
            }

            //Creates the expression object from the given parameters and evaluates its result
            var expression = _operationBuilder.BuildBinary<EitherExpression>(first, second);
            var result = expression.evaluate();

            // Logs the calculation performed along with the date and the output result
            _loggerService.WriteLine(DateTime.Now, expression.print(), result.ToString());

            return result;
        }

        public double getCombinedWith(double first, double second)
        {
            // Validate the inputs
            var firstValid = _validationService.validate(first);
            var secondValid = _validationService.validate(second);

            if (!firstValid || !secondValid)
            {
                throw new ValidationException(_validationService.Errors);
            }

            //Creates the expression object from the given parameters and evaluates its result
            var expression = _operationBuilder.BuildBinary<CombinedWithExpression>(first, second);
            var result = expression.evaluate();

            // Logs the calculation performed along with the date and the output result
            _loggerService.WriteLine(DateTime.Now, expression.print(), result.ToString());

            return result;
        }
    }
}
