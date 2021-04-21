using Calculator.BusinessLogic.Builders;
using Calculator.BusinessLogic.Models;
using Calculator.BusinessLogic.Services;
using Moq;
using System;
using Xunit;

namespace Calculator.BusinessLogic.Tests
{
    public class CalculatorServiceTests
    {
        private ICalculatorService _calculatorService;
        private Mock<IExpression> _expressionMock;
        private Mock<IOperationBuilder> _operationBuilderMock;
        private Mock<ILoggerService> _writerMock;
        private Mock<IValidationService> _validationService;

        [Fact]
        public void ValidInputs_Either_ReturnsCorrectResult()
        {
            // Arrange
            var expectedResult = 0.75;
            var expectedPrint = "test";

            Setup(expectedResult, expectedPrint);

            // Act
            var result = _calculatorService.getEither(0.5, 0.5);

            //Assert
            _operationBuilderMock.Verify(mock => mock.BuildBinary<EitherExpression>(0.5, 0.5), Times.Once);
            _expressionMock.Verify(mock => mock.evaluate(), Times.Once());
            _writerMock.Verify(mock => mock.WriteLine(It.IsAny<DateTime>(), expectedPrint, expectedResult.ToString()), Times.Once);

            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void ValidInputs_CombinedWith_ReturnsCorrectResult()
        {
            // Arrange
            var expectedResult = 0.25;
            var expectedPrint = "test";

            Setup(expectedResult, expectedPrint);

            // Act
            var result = _calculatorService.getCombinedWith(0.5, 0.5);

            //Assert
            _operationBuilderMock.Verify(mock => mock.BuildBinary<CombinedWithExpression>(0.5, 0.5), Times.Once);
            _expressionMock.Verify(mock => mock.evaluate(), Times.Once());
            _writerMock.Verify(mock => mock.WriteLine(It.IsAny<DateTime>(), expectedPrint, expectedResult.ToString()), Times.Once);

            Assert.Equal(result, expectedResult);
        }

        private void Setup(double expectedResult, string expectedPrint)
        {
            _expressionMock = new Mock<IExpression>();
            _expressionMock.Setup(x => x.evaluate()).Returns(expectedResult);
            _expressionMock.Setup(x => x.print()).Returns(expectedPrint);

            _operationBuilderMock = new Mock<IOperationBuilder>();
            _operationBuilderMock.Setup(x => x.BuildBinary<BinaryExpression>(It.IsAny<double>(), It.IsAny<double>())).Returns(_expressionMock.Object);

            _writerMock = new Mock<ILoggerService>();
            _writerMock.Setup(x => x.WriteLine(It.IsAny<DateTime>(), It.IsAny<string>(), It.IsAny<string>()));

            _validationService = new Mock<IValidationService>();
            _validationService.Setup(x => x.validate(It.IsAny<double>())).Returns(true);

            _calculatorService = new CalculatorService(_operationBuilderMock.Object, _writerMock.Object, _validationService.Object);
        }
    }
}
