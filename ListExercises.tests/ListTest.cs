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
        [TestMethod]
        public void binarySearchTest()
        {
            var list = new List<int>{1,6,17,24,78,954,1486};
            int inList = 78;
            int notInList = 85;
            Assert.IsTrue(Program.binarySearch(inList,list));
            Assert.IsFalse(Program.binarySearch(notInList,list));
        }
        [TestMethod]
        public void duplicatesTest()
        {
            var list = new List<int>{1,1,6,17,954,17,24,78,954,1486};
            var duplicates = new List<int>{1,17,954};
            var result = Program.duplications(list);
            bool valid = true;
            for(int i = 0;i<duplicates.Count;i++)
            {
                if(duplicates[i]!=result[i])
                    valid = false;
            }
            if(duplicates.Count!=result.Count)
                valid = false;
            Assert.IsTrue(valid);
        }
        [TestMethod]
        public void subsetTest()
        {
            var biglist = new List<int>{1,5,68,383484,388,96,57};
            var subset = new List<int>{1,5,388,57};
            Assert.IsTrue(Program.isSubset(subset,biglist));
            Assert.IsFalse(Program.isSubset(biglist,subset));
        }
    }
}
