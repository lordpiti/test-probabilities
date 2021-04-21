using Calculator.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.BusinessLogic.Builders
{
    public interface IOperationBuilder
    {
        IExpression BuildCombinedWith(double left, double right);

        IExpression BuildEither(double left, double right);
    }
}
