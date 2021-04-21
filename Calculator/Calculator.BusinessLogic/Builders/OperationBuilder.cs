using Calculator.BusinessLogic.Models;
using System;

namespace Calculator.BusinessLogic.Builders
{
    public class OperationBuilder : IOperationBuilder
    {
        public IExpression BuildBinary<T>(double left, double right) where T: BinaryExpression
        {
            return (T)Activator.CreateInstance(typeof(T), new NumberExpression(left), new NumberExpression(right));
        }
    }
}
