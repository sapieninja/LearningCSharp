using Xunit;

namespace Question6.tests
{
  
    public class Question6Tests
    {
        [Fact]
        public void Question6Test()
        {  
            Assert.Equal("11010010",Program.toBinary("210"));
            Assert.Equal("11111111",Program.toBinary("-1"));
        }
    }
}
