using Xunit;

namespace Normalisation.tests
{

    public class NormalisationTests
    {
        [Fact]
        public void TestNormaliser()
        {
            Assert.Equal("0111101100",Program.normaliser("0000111100001111"));
        }
    }
}
