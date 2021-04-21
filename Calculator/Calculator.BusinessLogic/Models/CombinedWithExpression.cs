namespace Calculator.BusinessLogic.Models
{
    public class CombinedWithExpression : BinaryExpression
    {
        public CombinedWithExpression(IExpression left, IExpression right) : base(left, right)
        {

        }

        protected override double evaluate(double left, double right)
        {
            return left * right;
        }

        protected override string print(string left, string right)
        {
            return "CombinedWith(" + left + "," + right + ")";
        }

        public override string getName() => "CombinedWith";
    }

}
