using Calculator.BusinessLogic.Builders;
using System;
using System.IO;

namespace Calculator.BusinessLogic
{
    public class CalculatorService : ICalculatorService
    {
        private readonly IOperationBuilder _operationBuilder;

        public CalculatorService(IOperationBuilder operationBuilder)
        {
            _operationBuilder = operationBuilder;
        }

        public double getEither(double first, double second)
        {
            var expression = _operationBuilder.BuildEither(first, second);

            // var gg = Assembly.GetExecutingAssembly().Location;
            //var gg = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);


            //File.AppendAllText(@"c:\Repos\file.txt", "text content" + Environment.NewLine);
            var result = expression.evaluate();

            var gg = System.AppDomain.CurrentDomain.BaseDirectory;

            File.AppendAllText($"{gg}file.txt", $"{expression.getName()} - a:{first}, b: {second}, result:{result}{Environment.NewLine}");

            return result;
        }
    }
}
