using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Question6.tests
{
    [TestClass]
    public class Question6Tests
    {
        [TestMethod]
        public void Question6Test()
        {  
            Assert.AreEqual(Program.toBinary("210"),"11010010");
            Assert.AreEqual(Program.toBinary("-1"),"11111111");
        }
    }
}
