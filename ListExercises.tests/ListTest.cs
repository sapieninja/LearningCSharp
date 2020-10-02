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
            Assert.AreEqual(expected,ListExercises.Program.Sum((list)));
        }
        [TestMethod]
        public void ToMaxTest()
        {
            var list = new List<int>(){5,5,5,5,5};
            int expected = 5;
            Assert.AreEqual(expected,ListExercises.Program.Max((list)));
        }
        [TestMethod]
        public void ToMinTest()
        {
            var list = new List<int>(){5,5,5,5,4};
            int expected = 4;
            Assert.AreEqual(expected,ListExercises.Program.Min((list)));
        }
         [TestMethod]
        public void ToNegativeTest()
        {
            var list = new List<int>(){5,5,5,5,-3};
            int expected = -3;
            Assert.AreEqual(expected,Program.negative(list)[0]);
        }
    }
}
