namespace CalculatorEngine.Operations
{
    /// <summary>
    /// Performs addition.
    /// </summary>
    public class AddOperation : IOperation
    {
        public double Execute(double a, double b)
        {
            return a + b;
        }
    }
}