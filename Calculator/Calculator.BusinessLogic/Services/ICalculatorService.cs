using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.BusinessLogic
{
    public interface ICalculatorService
    {
        double getEither(double first, double second);

        double getCombinedWith(double first, double second);
    }
}
