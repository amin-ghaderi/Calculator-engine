namespace CalculatorEngine
{
    /// <summary>
    /// Defines a contract for basic and advanced mathematical operations.
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Adds two numbers.
        /// </summary>
        double Add(double a, double b);

        /// <summary>
        /// Subtracts the second number from the first.
        /// </summary>
        double Subtract(double a, double b);

        /// <summary>
        /// Multiplies two numbers.
        /// </summary>
        double Multiply(double a, double b);

        /// <summary>
        /// Divides the first number by the second.
        /// </summary>
        /// <exception cref="DivideByZeroException"></exception>
        double Divide(double a, double b);

        /// <summary>
        /// Raises a number to a specified power.
        /// </summary>
        double Power(double a, double b);

        /// <summary>
        /// Calculates the square root of a number.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        double SquareRoot(double a);

        /// <summary>
        /// Calculates the remainder of division.
        /// </summary>
        /// <exception cref="DivideByZeroException"></exception>
        double Modulus(double a, double b);
    }
}