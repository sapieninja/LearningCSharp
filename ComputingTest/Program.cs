using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputingTest
{
    class Program
    {
        public static int Repeats(List<int> source) => source.Where(x => source.Count(y => y == x) == 1).Sum();
        static void Main()
        {
            Console.WriteLine(Repeats(new List<int> { 5, 5, 4, 4, 3, 2, 7 }));
        }
    }
}
