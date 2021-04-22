using Calculator.BusinessLogic.Models;
using System;

namespace Calculator.BusinessLogic.Builders
{
    /// <summary>
    /// Class which hold methods to instantiate Expression objects in an easier way
    /// </summary>
    public class OperationBuilder : IOperationBuilder
    {
        /// <summary>
        /// Instantiates the given BinaryExpression with two double numbers
        /// </summary>
        /// <typeparam name="T">BinaryExpression type to instantiate</typeparam>
        /// <param name="left">first double number in the binary expression</param>
        /// <param name="right">second double number in the binary expression</param>
        /// <returns></returns>
        public IExpression BuildBinary<T>(double left, double right) where T: BinaryExpression
        {
            return (T)Activator.CreateInstance(typeof(T), new NumberExpression(left), new NumberExpression(right));
        }
    }
}
