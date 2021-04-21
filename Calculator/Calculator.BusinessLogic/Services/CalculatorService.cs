using Calculator.BusinessLogic.Builders;
using Calculator.BusinessLogic.Models;
using Calculator.BusinessLogic.Services;
using System;

namespace Calculator.BusinessLogic
{
    public class CalculatorService : ICalculatorService
    {
        private readonly IOperationBuilder _operationBuilder;
        private readonly ILoggerService _loggerService;

        public CalculatorService(IOperationBuilder operationBuilder, ILoggerService loggerService)
        {
            _operationBuilder = operationBuilder;
            _loggerService = loggerService;
        }

        public double getEither(double first, double second)
        {
            var expression = _operationBuilder.BuildBinary<EitherExpression>(first, second);
            var result = expression.evaluate();
            _loggerService.WriteLine(DateTime.Now, expression.print(), result.ToString());

            return result;
        }

        public double getCombinedWith(double first, double second)
        {
            var expression = _operationBuilder.BuildBinary<CombinedWithExpression>(first, second);
            var result = expression.evaluate();
            _loggerService.WriteLine(DateTime.Now, expression.print(), result.ToString());

            return result;
        }
    }
}
