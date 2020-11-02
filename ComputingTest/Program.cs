using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputingTest
{
    class Program
    {
        public static int Repeats(List<int> source)
        {
            var notrepeated =
                            from x in source
                            where (source.Count(y => y == x) == 1)
                            select x;
            return notrepeated.Sum();
        }
    }
}
