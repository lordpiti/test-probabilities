using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.BusinessLogic.Models
{
    public interface IExpression
    {
        double evaluate();

        string print();

        string getName();
    }
}
