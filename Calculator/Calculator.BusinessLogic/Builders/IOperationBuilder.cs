using Calculator.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.BusinessLogic.Builders
{
    public interface IOperationBuilder
    {
        IExpression BuildBinary<T>(double left, double right) where T : BinaryExpression;
    }
}
