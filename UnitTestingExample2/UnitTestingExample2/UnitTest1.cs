using System;
using Xunit;

namespace UnitTestingExample2
{

    public class CalculatorTests
    {
        //list of parameterized tests
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(-4,-6,-10)]
        [InlineData(-2,2,0)]
        [InlineData(int.MinValue, -1, int.MaxValue)]

        //unit test receives two values to add together, plus the expected value for the addition operation
        public void CanAddTheory(int value1, int value2, int expected)
        {
            //arrange
            var calculator = new Calculator();

            //act
            var result = calculator.Add(value1, value2);

            //assert
            Assert.Equal(expected, result);
        }
    }
}
