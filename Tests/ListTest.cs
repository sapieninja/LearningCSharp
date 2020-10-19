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
            Assert.Equal(expected,Program.negative(list)[0]);
        }
         [Fact]
        public void areSameTest()
        {
            var lista = new List<int>(){5,5,5,5,-3};
            var listb = new List<int>(){5,5,-3};
            var listc = new List<int>(){5,4,-3};
            Assert.True(Program.same(lista,listb));
            Assert.False(Program.same(lista,listc));
        }
         [Fact]
        public void linearSearchTest()
        {
            var list = new List<int>{1,6,17,24,78,954,1486};
            int inList = 78;
            int notInList = 85;
            Assert.True(Program.linearSearch(inList,list));
            Assert.False(Program.linearSearch(notInList,list));
        }
        [Fact]
        public void binarySearchTest()
        {
            var list = new List<int>{1,6,17,24,78,954,1486};
            int inList = 78;
            int notInList = 85;
            Assert.True(Program.binarySearch(inList,list));
            Assert.False(Program.binarySearch(notInList,list));
        }
        [Fact]
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
            Assert.True(valid);
        }
        [Fact]
        public void subsetTest()
        {
            var biglist = new List<int>{1,5,68,383484,388,96,57};
            var subset = new List<int>{1,5,388,57};
            Assert.True(Program.isSubset(subset,biglist));
            Assert.False(Program.isSubset(biglist,subset));
        }
        [Fact]
        public void reverseTest()
        {
            var startlist = new List<int>{1,2,3,4,5,6,7,8,9,10};
            var endlist = new List<int>{10,9,8,7,6,5,4,3,2,1};
            var result = Program.reverse(startlist);
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
        public void sortTest()
        {
            var startlist = new List<int>{10,1,5,7,8,9,6,3,2,4};
            var endlist = new List<int>{1,2,3,4,5,6,7,8,9,10};
            var result = Program.sort(startlist);
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
        public void fractionsTest(string input,string expected)
        {
            var result = Fractions.fraction(input);
            Assert.Equal(expected,result);
        }
        [Fact]
        public void uniqueTest()
        {
            var expected = 24;
            var result = Fractions.unique();
            Assert.Equal(expected,result);
        }
    }
}
