using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.BusinessLogic.Models
{
    public class NumberExpression : IExpression
    {
        private double number;

        public NumberExpression(double number)
        {
            this.number = number;
        }

        public double evaluate()
        {
            return (double)number;
        }

        public string getName() => "Number";
    }
}
