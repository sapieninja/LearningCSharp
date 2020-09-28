using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Normalisation.tests
{
    [TestClass]
    public class NormalisationTests
    {
        [TestMethod]
        public void TestNormaliser()
        {
            Assert.AreEqual("0111101100",Program.normaliser("0000111100001111"));
        }
    }
}
