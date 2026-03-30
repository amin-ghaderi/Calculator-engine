namespace CalculatorEngine
{
    /// <summary>
    /// Provides basic and advanced mathematical operations.
    /// Implements ICalculator interface.
    /// </summary>
    public class Calculator : ICalculator
    {
        /// <summary>
        /// Adds two numbers together.
        /// </summary>
        public double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts the second number from the first number.
        /// </summary>
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplies two numbers.
        /// </summary>
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides the first number by the second number.
        /// </summary>
        /// <exception cref="DivideByZeroException"></exception>
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return a / b;
        }

        /// <summary>
        /// Raises a number to the power of another number.
        /// </summary>
        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        /// <summary>
        /// Calculates the square root of a number.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public double SquareRoot(double a)
        {
            if (a < 0)
                throw new ArgumentException("Cannot calculate square root of a negative number.");

            return Math.Sqrt(a);
        }

        /// <summary>
        /// Calculates the remainder of division between two numbers.
        /// </summary>
        /// <exception cref="DivideByZeroException"></exception>
        public double Modulus(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot perform modulus with zero.");

            return a % b;
        }
    }
}