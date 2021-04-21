namespace Calculator.BusinessLogic.Models
{
    public class EitherExpression: BinaryExpression
    {
        public EitherExpression(IExpression left, IExpression right) : base(left, right)
        {

        }
        
        protected override double evaluate(double left, double right)
        {
            var eitherExpression = new SubstractionExpression(new AdditionExpression(
                new NumberExpression(left),
                new NumberExpression(right)
                ), new CombinedWithExpression(new NumberExpression(left), new NumberExpression(right)));

            return eitherExpression.evaluate();
        }

        public override string getName() => "Either";
    }
}
