namespace CalculatorEngine
{
    /// <summary>
    /// Provides basic and advanced mathematical operations.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Adds two numbers together.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>The sum of a and b</returns>
        public double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts the second number from the first number.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>The result of a minus b</returns>
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplies two numbers.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>The product of a and b</returns>
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides the first number by the second number.
        /// </summary>
        /// <param name="a">Dividend</param>
        /// <param name="b">Divisor</param>
        /// <returns>The result of division</returns>
        /// <exception cref="DivideByZeroException">Thrown when b is zero</exception>
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return a / b;
        }

        /// <summary>
        /// Raises a number to the power of another number.
        /// </summary>
        /// <param name="a">Base number</param>
        /// <param name="b">Exponent</param>
        /// <returns>a raised to the power of b</returns>
        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        /// <summary>
        /// Calculates the square root of a number.
        /// </summary>
        /// <param name="a">Input number</param>
        /// <returns>The square root of a</returns>
        /// <exception cref="ArgumentException">Thrown when a is negative</exception>
        public double SquareRoot(double a)
        {
            if (a < 0)
                throw new ArgumentException("Cannot calculate square root of a negative number.");

            return Math.Sqrt(a);
        }

        /// <summary>
        /// Calculates the remainder of division between two numbers.
        /// </summary>
        /// <param name="a">Dividend</param>
        /// <param name="b">Divisor</param>
        /// <returns>The remainder of a divided by b</returns>
        /// <exception cref="DivideByZeroException">Thrown when b is zero</exception>
        public double Modulus(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot perform modulus with zero.");

            return a % b;
        }
    }
}