namespace Calculator.BusinessLogic.Models
{
    public class EitherExpression: BinaryExpression
    {
        public EitherExpression(IExpression left, IExpression right) : base(left, right)
        {

        }
        
        protected override double evaluate(double left, double right)
        {
            // As this expression can be represented as a composition of existing ones, where the evaluate method has already
            // been defined. To evaluate this one we can just create the right expression object and evaluate it.
            var eitherExpression = new SubstractionExpression(new AdditionExpression(
                new NumberExpression(left),
                new NumberExpression(right)
                ), new CombinedWithExpression(new NumberExpression(left), new NumberExpression(right)));

            return eitherExpression.evaluate();
        }

        protected override string print(string left, string right)
        {
            return "Either("+left + "," + right+")";
        }

        public override string getName() => "Either";
    }
}
