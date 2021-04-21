using Calculator.BusinessLogic.Builders;
using Calculator.BusinessLogic.Models;
using Calculator.BusinessLogic.Services;
using Moq;
using System;
using Xunit;

namespace Calculator.BusinessLogic.Tests
{
    public class ExpressionTests
    {
        [Fact]
        public void AdditionExpression_EvaluatesCorrectly()
        {
            var additionExpression = new AdditionExpression(new NumberExpression(0.5), new NumberExpression(0.5));

            Assert.Equal(1, additionExpression.evaluate());
        }

        [Fact]
        public void CombinedWithExpression_EvaluatesCorrectly()
        {
            var combinedWithExpression = new CombinedWithExpression(new NumberExpression(0.5), new NumberExpression(0.5));

            Assert.Equal(0.25, combinedWithExpression.evaluate());
        }

        [Fact]
        public void EitherExpression_EvaluatesCorrectly()
        {
            var eitherExpression = new EitherExpression(new NumberExpression(0.5), new NumberExpression(0.5));

            Assert.Equal(0.75, eitherExpression.evaluate());
        }
    }
}
