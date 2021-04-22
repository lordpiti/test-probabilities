using Calculator.BusinessLogic.Builders;
using Calculator.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.BusinessLogic.Tests
{
    public class CalculatorIntegrationTests
    {
        [Fact]
        public void ValidInputs_Either_ReturnsCorrectResult()
        {
            var operationBuilder = new OperationBuilder();
            var loggerService = new ConsoleLoggerService();
            var validationService = new ValidationService();
            var calculatorService = new CalculatorService(operationBuilder, loggerService, validationService);

            var result = calculatorService.getEither(0.5, 0.5);

            Assert.Equal(0.75, result);
        }

        [Fact]
        public void ValidInputs_CombinedWith_ReturnsCorrectResult()
        {
            var operationBuilder = new OperationBuilder();
            var loggerService = new ConsoleLoggerService();
            var validationService = new ValidationService();
            var calculatorService = new CalculatorService(operationBuilder, loggerService, validationService);

            var result = calculatorService.getCombinedWith(0.5, 0.5);

            Assert.Equal(0.25, result);
        }
    }
}
