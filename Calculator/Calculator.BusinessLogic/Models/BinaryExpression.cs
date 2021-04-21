using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.BusinessLogic.Models
{
    public abstract class BinaryExpression : IExpression
    {
        private IExpression left;
        private IExpression right;

        public BinaryExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public double evaluate()
        {
            return evaluate(left.evaluate(), right.evaluate());
        }

        abstract protected double evaluate(double left, double right);

        abstract public string getName();
    }
}
