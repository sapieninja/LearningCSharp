using System.Reflection;
using System;
using Xunit;

namespace Tests
{
    public class ReversePolishTests
    {
        [Theory]
        [InlineData("3 4 +", 7)]
        [InlineData("1 2 + 3/", 1)]
        [InlineData("3 4 -", -1)]
        [InlineData("5 5 5 5 * * *", 625)]
        [InlineData("238482832 238 +", 238483070)]
        public void ReversePolishTest(string equation, int expected)
        {
            CustomStack.ReversePolish Equation = new CustomStack.ReversePolish(equation);
            Assert.Equal(expected, Equation.Value);
        }
        [Fact]
        public void TestError()
        {
            Assert.Throws<InvalidOperationException>(() => new CustomStack.ReversePolish("5 4 3 +"));
        }
    }
}
