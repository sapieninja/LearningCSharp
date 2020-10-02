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
            int max = toMax[0];
            foreach(int element in toMax)
            {
                if(element>max)
                    max = element;
            }
            return max;

        }
        public static int Min(List<int> toMin)
        {
            int min = toMin[0];
            foreach(int element in toMin)
            {
                if(element<min)
                    min = element;
            }
            return min;
        }
        public static List<int> negative(List<int> toNegative)
        {
            List<int> listNegative = new List<int>();
            foreach(int element in toNegative)
            {
                if(element<0)
                    listNegative.Add(element);
            }
            return listNegative;        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
