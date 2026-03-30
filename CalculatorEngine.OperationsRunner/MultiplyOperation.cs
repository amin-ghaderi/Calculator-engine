namespace CalculatorEngine.Operations
{
    /// <summary>
    /// Performs multiplication.
    /// </summary>
    public class MultiplyOperation : IOperation
    {
        public double Execute(double a, double b)
        {
            return a * b;
        }
    }
}