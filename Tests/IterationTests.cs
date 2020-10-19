using Xunit;

namespace Iteration
{
    public class IterationTests
    {
        [Theory]
        [InlineData(1,1)]
        [InlineData(0,0)]
        [InlineData(100,5050)]
        public void TestTriangular(int n,int expected)
        {   
            var result = Program.triangular(n);
            Assert.Equal(expected,result);
        }
        [Theory]
        [InlineData("15688?111X","1")]
        [InlineData("812071988?","3")]
        [InlineData("020161586?","X")]
        [InlineData("?131103628","0")]
        [InlineData("?86046324X","1")]
        [InlineData("1?68811306","5")]
        [InlineData("951?451570","4")]
        [InlineData("0393020?31","2")]
        [InlineData("01367440?5","9")]
        public void TestISBN(string ISBNcode, string expected)
        {
            string answer = Program.ISBNfindMissing(ISBNcode);
            Assert.Equal(expected,answer);
        }
        [Theory]
        [InlineData(120,12)]
        [InlineData(0,0)]
        [InlineData(1,1)]
        [InlineData(10,1)]
        public void TestToFront(int number,int expected)
        {
            int answer = Program.toFront(number);
            Assert.Equal(expected,answer);
        }
    }
}
