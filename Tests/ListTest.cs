using Xunit;
using System.Collections.Generic;
namespace ListExercises
{
    public class ListTests
    {
        [Fact]
        public void ToSumTest()
        {
            var list = new List<int>(){5,5,5,5,5};
            int expected = 25;
            Assert.Equal(expected,Program.Sum((list)));
        }
        [Fact]
        public void ToMaxTest()
        {
            var list = new List<int>(){5,5,5,5,5};
            int expected = 5;
            Assert.Equal(expected,Program.Max((list)));
        }
        [Fact]
        public void ToMinTest()
        {
            var list = new List<int>(){5,5,5,5,4};
            int expected = 4;
            Assert.Equal(expected,Program.Min((list)));
        }
         [Fact]
        public void ToNegativeTest()
        {
            var list = new List<int>(){5,5,5,5,-3};
            int expected = -3;
            Assert.Equal(expected,Program.Negative(list)[0]);
        }
         [Fact]
        public void AreSameTest()
        {
            var lista = new List<int>(){5,5,5,5,-3};
            var listb = new List<int>(){5,5,-3};
            var listc = new List<int>(){5,4,-3};
            Assert.True(Program.Same(lista,listb));
            Assert.False(Program.Same(lista,listc));
        }
         [Fact]
        public void LinearSearchTest()
        {
            var list = new List<int>{1,6,17,24,78,954,1486};
            int inList = 78;
            int notInList = 85;
            Assert.True(Program.LinearSearch(inList,list));
            Assert.False(Program.LinearSearch(notInList,list));
        }
        [Fact]
        public void BinarySearchTest()
        {
            var list = new List<int>{1,6,17,24,78,954,1486};
            int inList = 78;
            int notInList = 85;
            Assert.True(Program.BinarySearch(inList,list));
            Assert.False(Program.BinarySearch(notInList,list));
        }
        [Fact]
        public void DuplicatesTest()
        {
            var list = new List<int>{1,1,6,17,954,17,24,78,954,1486};
            var duplicates = new List<int>{1,17,954};
            var result = Program.Duplications(list);
            bool valid = true;
            for(int i = 0;i<duplicates.Count;i++)
            {
                if(duplicates[i]!=result[i])
                    valid = false;
            }
            if(duplicates.Count!=result.Count)
                valid = false;
            Assert.True(valid);
        }
        [Fact]
        public void SubsetTest()
        {
            var biglist = new List<int>{1,5,68,383484,388,96,57};
            var subset = new List<int>{1,5,388,57};
            Assert.True(Program.IsSubset(subset,biglist));
            Assert.False(Program.IsSubset(biglist,subset));
        }
        [Fact]
        public void ReverseTest()
        {
            var startlist = new List<int>{1,2,3,4,5,6,7,8,9,10};
            var endlist = new List<int>{10,9,8,7,6,5,4,3,2,1};
            var result = Program.Reverse(startlist);
             bool valid = true;
            for(int i = 0;i<endlist.Count;i++)
            {
                if(endlist[i]!=result[i])
                    valid = false;
            }
            if(endlist.Count!=result.Count)
                valid = false;
            Assert.True(valid);
        }
        [Fact]
        public void SortTest()
        {
            var startlist = new List<int>{10,1,5,7,8,9,6,3,2,4};
            var endlist = new List<int>{1,2,3,4,5,6,7,8,9,10};
            var result = Program.Sort(startlist);
            bool valid = true;
            for(int i = 0;i<endlist.Count;i++)
            {
                if(endlist[i]!=result[i])
                    valid = false;
            }
            if(endlist.Count!=result.Count)
                valid = false;
            Assert.True(valid);
        }
        [Theory]
        [InlineData("0.125","1/8")]
        [InlineData("0.9","9/10")]
        [InlineData("0.0008","1/1250")]
        [InlineData("0.49","49/100")]
        [InlineData("0.2005","401/2000")]
        [InlineData("0.1418","709/5000")]
        [InlineData("0.7525","301/400")]
        [InlineData("0.9952","622/625")]
        [InlineData("0.016","2/125")]
        public void FractionsTest(string input,string expected)
        {
            var result = Fractions.Fraction(input);
            Assert.Equal(expected,result);
        }
        [Fact]
        public void UniqueTest()
        {
            var expected = 24;
            var result = Fractions.Unique();
            Assert.Equal(expected,result);
        }
    }
}
