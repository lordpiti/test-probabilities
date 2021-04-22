namespace Calculator.BusinessLogic.Models
{
    /// <summary>
    /// Represents any kind of expression
    /// </summary>
    public interface IExpression
    {
        /// <summary>
        /// Evaluates the numeric value of the expression
        /// </summary>
        /// <returns></returns>
        double evaluate();

        /// <summary>
        /// Returns the expression as a string
        /// </summary>
        /// <returns></returns>
        string print();


        /// <summary>
        /// Gets the name of the expression type
        /// </summary>
        /// <returns></returns>
        string getName();
    }
}
