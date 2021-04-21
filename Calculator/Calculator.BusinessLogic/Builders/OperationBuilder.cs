using Calculator.BusinessLogic.Models;

namespace Calculator.BusinessLogic.Builders
{
    public class OperationBuilder : IOperationBuilder
    {
        public IExpression BuildCombinedWith(double left, double right)
        {
            return new CombinedWithExpression(new NumberExpression(left), new NumberExpression(right));
        }

        public IExpression BuildEither(double left, double right)
        {
            //return new SubstractionExpression(new AdditionExpression(
            //    new NumberExpression(left),
            //    new NumberExpression(right)
            //    ), this.BuildCombinedWith(left, right));
            return new EitherExpression(new NumberExpression(left), new NumberExpression(right));
        }
    }
}
