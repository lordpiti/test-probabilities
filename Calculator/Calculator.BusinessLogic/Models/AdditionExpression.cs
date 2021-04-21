using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.BusinessLogic.Models
{
    public class AdditionExpression : BinaryExpression
    {
        public AdditionExpression(IExpression left, IExpression right) : base(left, right)
        {

        }

        protected override double evaluate(double left, double right)
        {
            return left + right;
        }

        public override string getName() => "Addition";
    }
}
