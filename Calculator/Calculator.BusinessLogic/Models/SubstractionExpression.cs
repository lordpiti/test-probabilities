namespace Calculator.BusinessLogic.Models
{
    public class SubstractionExpression : BinaryExpression
    {
        public SubstractionExpression(IExpression left, IExpression right) : base(left, right)
        {

        }

        protected override double evaluate(double left, double right)
        {
            return left - right;
        }

        protected override string print(string left, string right)
        {
            return left + "-" + right;
        }

        public override string getName() => "Substraction";
    }
}
