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
        public static int Max(List<int> toMax)
        {
            int max = 0;
            foreach(int element in toMax)
            {
                if(element>max)
                    max = element;
            }
            return max;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
