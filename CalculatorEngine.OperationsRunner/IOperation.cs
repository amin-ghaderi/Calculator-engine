namespace CalculatorEngine.Operations
{
    /// <summary>
    /// Represents a generic mathematical operation.
    /// </summary>
    public interface IOperation
    {
        /// <summary>
        /// Executes the operation on two numbers.
        /// </summary>
        double Execute(double a, double b);
    }
}
