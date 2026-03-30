using Xunit;
using CalculatorEngine;
using System;

namespace CalculatorEngine.Tests
{
    /// <summary>
    /// Contains unit tests for ICalculator implementation.
    /// Ensures correctness of all mathematical operations.
    /// </summary>
    public class CalculatorTests
    {
        private readonly ICalculator _calculator;

        /// <summary>
        /// Initializes a new instance of Calculator for testing.
        /// </summary>
        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_ShouldReturnCorrectResult()
        {
            Assert.Equal(5, _calculator.Add(2, 3));
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectResult()
        {
            Assert.Equal(2, _calculator.Subtract(5, 3));
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectResult()
        {
            Assert.Equal(12, _calculator.Multiply(4, 3));
        }

        [Fact]
        public void Divide_ShouldReturnCorrectResult()
        {
            Assert.Equal(5, _calculator.Divide(10, 2));
        }

        [Fact]
        public void Divide_ShouldThrow_WhenDivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }

        [Fact]
        public void Power_ShouldReturnCorrectResult()
        {
            Assert.Equal(8, _calculator.Power(2, 3));
        }

        [Fact]
        public void SquareRoot_ShouldReturnCorrectResult()
        {
            Assert.Equal(4, _calculator.SquareRoot(16));
        }

        [Fact]
        public void SquareRoot_ShouldThrow_WhenNegative()
        {
            Assert.Throws<ArgumentException>(() => _calculator.SquareRoot(-4));
        }

        [Fact]
        public void Modulus_ShouldReturnCorrectResult()
        {
            Assert.Equal(1, _calculator.Modulus(10, 3));
        }

        [Fact]
        public void Modulus_ShouldThrow_WhenDivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Modulus(10, 0));
        }
    }
}