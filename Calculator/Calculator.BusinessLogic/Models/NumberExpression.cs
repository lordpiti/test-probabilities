using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.BusinessLogic.Models
{
    /// <summary>
    /// Represents a number, which would be the most elemental expression. A leaf on an expression tree
    /// </summary>
    public class NumberExpression : IExpression
    {
        private double number;

        public NumberExpression(double number)
        {
            this.number = number;
        }

        public double evaluate()
        {
            return number;
        }

        public string print()
        {
            return number.ToString();
        }

        public string getName() => "Number";
    }
}
