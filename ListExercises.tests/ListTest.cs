using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace ListExercises
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void ToSumTest()
        {
            var list = new List<int>(){5,5,5,5,5};
            int expected = 25;
            Assert.AreEqual(expected,ListExercises.Program.Sum(list));
        }
    }
}
