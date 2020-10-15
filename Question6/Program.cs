using System.Diagnostics.Contracts;
using System;
using System.Collections.Generic;
namespace Question6
{
    public class Program
    {
        public static string toBinary(string convertBinary)
        {
            int toConvert = Convert.ToInt32(convertBinary);
            var digits = new List<int>();
            while(toConvert!=0)
            {
                digits.Add(toConvert%2);
                toConvert = toConvert/2;
            }
            string output = "";
            foreach(int element in digits)
            {
                output = Convert.ToString(element) + output;
            }
            return output;
        }
        static void Main()
        {   
            Console.WriteLine("Insert Number:");
            Console.WriteLine(toBinary(Console.ReadLine()));
        }
    }
}
