using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    public class Program
    {
        public static int Sum(List<int> toSum)
        {
            int total = 0;
            foreach(int element in toSum)
            {
                total+=element;
            }
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
