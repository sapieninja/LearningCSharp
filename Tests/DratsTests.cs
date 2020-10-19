using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Drats
{
    [TestClass]
    public class DratsTests
    {
        [DataTestMethod]
        [DataRow(7,3,6)]
        [DataRow(33,1,0)]
        [DataRow(101,4,0)]
        [DataRow(8,7,1)]
        [DataRow(28,1,1)]
        [DataRow(18,2,8)]
        [DataRow(9,4,22)]
        [DataRow(36,3,191)]
        [DataRow(33,4,2075)]
        [DataRow(83,5,40000)]
        [DataRow(73,6,1402584)]
        [DataRow(95,8,515725220)]
        public void TestDrats(int scoreToMake,int noDrats,int expected)
        {
            var result = Drats.noSolutions(scoreToMake,noDrats,true);
            Assert.AreEqual(expected,result);
        }
    }
}