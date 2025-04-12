using Calculator = Learning.DotNet.Actions.Core.Calculator;

namespace Learning.DotNet.Actions.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
    }

    public class CalculatorTests
    {
        private readonly Calculator _calculator;
        public CalculatorTests()
        {
            _calculator = new Calculator();
        }
        [Fact]
        public void Add_ShouldReturnSum_WhenGivenTwoIntegers()
        {
            // Arrange
            int a = 5;
            int b = 3;
            // Act
            int result = _calculator.Add(a, b);
            // Assert
            Assert.Equal(8, result);
        }
        [Fact]
        public void Subtract_ShouldReturnDifference_WhenGivenTwoIntegers()
        {
            // Arrange
            int a = 5;
            int b = 3;
            // Act
            int result = _calculator.Subtract(a, b);
            // Assert
            Assert.Equal(2, result);
        }
        [Fact]
        public void Multiply_ShouldReturnProduct_WhenGivenTwoIntegers()
        {
            // Arrange
            int a = 5;
            int b = 3;
            // Act
            int result = _calculator.Multiply(a, b);
            // Assert
            Assert.Equal(15, result);
        }
        [Fact]
        public void Divide_ShouldReturnQuotient_WhenGivenTwoIntegers()
        {
            // Arrange
            int a = 6;
            int b = 3;
            // Act
            double result = _calculator.Divide(a, b);
            // Assert
            Assert.Equal(2.0, result);
        }
    }
}
