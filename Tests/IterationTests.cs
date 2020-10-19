using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Iteration
{
    [TestClass]
    public class IterationTests
    {
        [DataTestMethod]
        [DataRow(1,1)]
        [DataRow(0,0)]
        [DataRow(100,5050)]
        public void TestTriangular(int n,int expected)
        {   
            var result = Program.triangular(n);
            Assert.AreEqual(expected,result);
        }
        [DataTestMethod,TestCategory("BIO")]
        [DataRow("15688?111X","1")]
        [DataRow("812071988?","3")]
        [DataRow("020161586?","X")]
        [DataRow("?131103628","0")]
        [DataRow("?86046324X","1")]
        [DataRow("1?68811306","5")]
        [DataRow("951?451570","4")]
        [DataRow("0393020?31","2")]
        [DataRow("01367440?5","9")]
        public void TestISBN(string ISBNcode, string expected)
        {
            string answer = Program.ISBNfindMissing(ISBNcode);
            Assert.AreEqual(expected,answer);
        }
        [DataTestMethod]
        [DataRow(120,12)]
        [DataRow(0,0)]
        [DataRow(1,1)]
        [DataRow(10,1)]
        public void TestToFront(int number,int expected)
        {
            int answer = Program.toFront(number);
            Assert.AreEqual(expected,answer);
        }
    }
}
