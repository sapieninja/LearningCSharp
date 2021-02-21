using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using NuGet.Frameworks;
using Xunit;
namespace LinkedList
{
    public class LinkedListTest
    {
        [Fact] 
        public void InstantiationTest()
        {
            var LL = new LinkedList<int>();
            var CLL = new LinkedList<int>(true, false);
            var DCLL = new LinkedList<int>(true, true);
        }

        [Fact]
        public void SinglyLinkedTest()
        {
            var SLL = new LinkedList<int>();
            SLL.Add(1);
            SLL.Add(2);
            Assert.Equal(new List<int>{1,2},SLL.GetList());
            Assert.Equal(2,SLL.Length);
        }

        [Fact]
        public void DoublyLinkedTest()
        {
            var DLL = new LinkedList<string>(false, true);
            DLL.Add("cheeseburger");
            DLL.Add("Cucumber");
            DLL.Add("Florida");
            DLL.Remove("Cucumber");
            Assert.Equal(new List<string>{"cheeseburger","Florida"},DLL.GetList());
            Assert.Equal("Florida", DLL.CurrentValue); //testing that current is moved away from a removed item
        }

        [Fact]
        public void CyclicalTest()
        {
            var CLL = new LinkedList<int>(true, false);
            CLL.Add(1);
            CLL.Add(2);
            Assert.Equal(new List<int>{2,1},CLL.GetList());
            CLL.Forward();
            Assert.Equal(new List<int>{1,2},CLL.GetList());
        }
    }
}