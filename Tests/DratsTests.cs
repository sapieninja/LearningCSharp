using Xunit;
namespace Drats
{
    public class DratsTests
    {
        [Theory]
        [InlineData(7,3,6)]
        [InlineData(33,1,0)]
        [InlineData(101,4,0)]
        [InlineData(8,7,1)]
        [InlineData(28,1,1)]
        [InlineData(18,2,8)]
        [InlineData(9,4,22)]
        [InlineData(36,3,191)]
        [InlineData(33,4,2075)]
        [InlineData(83,5,40000)]
        [InlineData(73,6,1402584)]
        [InlineData(95,8,515725220)]
        public void TestDrats(int scoreToMake,int noDrats,int expected)
        {
            var result = Drats.noSolutions(scoreToMake,noDrats);
            Assert.Equal(expected,result);
        }
    }
}