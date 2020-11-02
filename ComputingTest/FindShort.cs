using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class FindShort
    {
        public static int shortest(string s)
        {
            List<string> words = s.Split(' ').ToList();
            int shortest = words[0].Count();
            foreach (var word in words)
            {
                if (word.Count() < shortest)
                {
                    shortest = word.Count();
                }
            }
            return shortest;
        }
    }
}