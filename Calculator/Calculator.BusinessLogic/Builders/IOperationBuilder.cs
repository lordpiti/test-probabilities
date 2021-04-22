using Calculator.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.BusinessLogic.Builders
{
    /// <summary>
    /// Interface which hold methods to instantiate Expression objects in an easier way
    /// </summary>
    public interface IOperationBuilder
    {
        IExpression BuildBinary<T>(double left, double right) where T : BinaryExpression;
    }
}
