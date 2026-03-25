using Xunit;
using CalculatorEngine;
using System;

namespace CalculatorEngine.Tests
{
    /// <summary>
    /// Contains unit tests for the Calculator class.
    /// Verifies correctness of all basic and advanced mathematical operations.
    /// </summary>
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        /// <summary>
        /// Initializes a new instance of Calculator for testing.
        /// </summary>
        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        // -------------------- ADD --------------------

        /// <summary>
        /// Verifies that Add returns correct result for positive numbers.
        /// </summary>
        [Fact]
        public void Add_ShouldReturnCorrectResult_WhenNumbersArePositive()
        {
            // Arrange
            double a = 2, b = 3;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(5, result);
        }

        /// <summary>
        /// Verifies that Add works correctly with negative numbers.
        /// </summary>
        [Fact]
        public void Add_ShouldWorkWithNegativeNumbers()
        {
            double a = -2, b = -3;

            var result = _calculator.Add(a, b);

            Assert.Equal(-5, result);
        }

        /// <summary>
        /// Verifies that adding zero returns the original number.
        /// </summary>
        [Fact]
        public void Add_ShouldReturnSameNumber_WhenAddingZero()
        {
            double a = 5, b = 0;

            var result = _calculator.Add(a, b);

            Assert.Equal(5, result);
        }

        // -------------------- SUBTRACT --------------------

        /// <summary>
        /// Verifies that Subtract returns correct result.
        /// </summary>
        [Fact]
        public void Subtract_ShouldReturnCorrectResult()
        {
            double a = 5, b = 3;

            var result = _calculator.Subtract(a, b);

            Assert.Equal(2, result);
        }

        /// <summary>
        /// Verifies that Subtract handles negative results correctly.
        /// </summary>
        [Fact]
        public void Subtract_ShouldHandleNegativeResult()
        {
            double a = 3, b = 5;

            var result = _calculator.Subtract(a, b);

            Assert.Equal(-2, result);
        }

        // -------------------- MULTIPLY --------------------

        /// <summary>
        /// Verifies that Multiply returns correct result.
        /// </summary>
        [Fact]
        public void Multiply_ShouldReturnCorrectResult()
        {
            double a = 4, b = 3;

            var result = _calculator.Multiply(a, b);

            Assert.Equal(12, result);
        }

        /// <summary>
        /// Verifies that multiplying by zero returns zero.
        /// </summary>
        [Fact]
        public void Multiply_ShouldReturnZero_WhenOneOperandIsZero()
        {
            double a = 5, b = 0;

            var result = _calculator.Multiply(a, b);

            Assert.Equal(0, result);
        }

        /// <summary>
        /// Verifies that Multiply works with negative numbers.
        /// </summary>
        [Fact]
        public void Multiply_ShouldWorkWithNegativeNumbers()
        {
            double a = -2, b = 3;

            var result = _calculator.Multiply(a, b);

            Assert.Equal(-6, result);
        }

        // -------------------- DIVIDE --------------------

        /// <summary>
        /// Verifies that Divide returns correct result.
        /// </summary>
        [Fact]
        public void Divide_ShouldReturnCorrectResult()
        {
            double a = 10, b = 2;

            var result = _calculator.Divide(a, b);

            Assert.Equal(5, result);
        }

        /// <summary>
        /// Verifies that Divide handles decimal results correctly.
        /// </summary>
        [Fact]
        public void Divide_ShouldHandleDecimalResult()
        {
            double a = 5, b = 2;

            var result = _calculator.Divide(a, b);

            Assert.Equal(2.5, result);
        }

        /// <summary>
        /// Verifies that Divide throws DivideByZeroException when dividing by zero.
        /// </summary>
        [Fact]
        public void Divide_ShouldThrowException_WhenDividingByZero()
        {
            double a = 10, b = 0;

            Action act = () => _calculator.Divide(a, b);

            Assert.Throws<DivideByZeroException>(act);
        }

        // -------------------- POWER --------------------

        /// <summary>
        /// Verifies that Power returns correct result.
        /// </summary>
        [Fact]
        public void Power_ShouldReturnCorrectResult()
        {
            double a = 2, b = 3;

            var result = _calculator.Power(a, b);

            Assert.Equal(8, result);
        }

        /// <summary>
        /// Verifies that Power returns 1 when exponent is zero.
        /// </summary>
        [Fact]
        public void Power_ShouldReturnOne_WhenExponentIsZero()
        {
            double a = 5, b = 0;

            var result = _calculator.Power(a, b);

            Assert.Equal(1, result);
        }

        // -------------------- SQUARE ROOT --------------------

        /// <summary>
        /// Verifies that SquareRoot returns correct result.
        /// </summary>
        [Fact]
        public void SquareRoot_ShouldReturnCorrectResult()
        {
            double a = 16;

            var result = _calculator.SquareRoot(a);

            Assert.Equal(4, result);
        }

        /// <summary>
        /// Verifies that SquareRoot throws exception for negative input.
        /// </summary>
        [Fact]
        public void SquareRoot_ShouldThrowException_WhenNegative()
        {
            double a = -4;

            Action act = () => _calculator.SquareRoot(a);

            Assert.Throws<ArgumentException>(act);
        }

        // -------------------- MODULUS --------------------

        /// <summary>
        /// Verifies that Modulus returns correct remainder.
        /// </summary>
        [Fact]
        public void Modulus_ShouldReturnCorrectResult()
        {
            double a = 10, b = 3;

            var result = _calculator.Modulus(a, b);

            Assert.Equal(1, result);
        }

        /// <summary>
        /// Verifies that Modulus throws exception when dividing by zero.
        /// </summary>
        [Fact]
        public void Modulus_ShouldThrowException_WhenDividingByZero()
        {
            double a = 10, b = 0;

            Action act = () => _calculator.Modulus(a, b);

            Assert.Throws<DivideByZeroException>(act);
        }
    }
}