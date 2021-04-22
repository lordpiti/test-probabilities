namespace Calculator.BusinessLogic
{
    /// <summary>
    /// Represents a calculator with performs different operations
    /// </summary>
    public interface ICalculatorService
    {
        double getEither(double first, double second);

        double getCombinedWith(double first, double second);
    }
}
