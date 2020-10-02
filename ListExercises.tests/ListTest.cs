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
         [TestMethod]
        public void areSameTest()
        {
            var lista = new List<int>(){5,5,5,5,-3};
            var listb = new List<int>(){5,5,-3};
            var listc = new List<int>(){5,4,-3};
            Assert.IsTrue(Program.same(lista,listb));
            Assert.IsFalse(Program.same(lista,listc));
        }
         [TestMethod]
        public void linearSearchTest()
        {
            var list = new List<int>{1,6,17,24,78,954,1486};
            int inList = 78;
            int notInList = 85;
            Assert.IsTrue(Program.linearSearch(inList,list));
            Assert.IsFalse(Program.linearSearch(notInList,list));
        }
        public void binarySearchTest()
        {
            var list = new List<int>{1,6,17,24,78,954,1486};
            int inList = 78;
            int notInList = 85;
            Assert.IsTrue(Program.binarySearch(inList,list));
            Assert.IsFalse(Program.binarySearch(notInList,list));
        }
    }
}
