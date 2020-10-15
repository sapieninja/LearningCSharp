using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Question6.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {  
            Assert.AreEqual(Program.toBinary("210"),"11010010");
        }
    }
}
