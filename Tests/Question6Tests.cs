using Xunit;

namespace Question6.tests
{
  
    public class Question6Tests
    {
        [Fact]
        public void Question6Test()
        {  
            Assert.Equal(Program.toBinary("210"),"11010010");
            Assert.Equal(Program.toBinary("-1"),"11111111");
        }
    }
}
