using System;
using System.Collections.Generic;
namespace Question6
{
    public class Program
    {
        public static string PositiveToBinary(string convertBinary)
        {
            int toConvert = Convert.ToInt32(convertBinary);
            var digits = new List<int>();
            while(toConvert!=0)
            {
                digits.Add(toConvert%2);
                toConvert /= 2;
            }
            string output = "";
            foreach(int element in digits)
            {
                output = Convert.ToString(element) + output;
            }
            return output;
        }
        public static string ToBinary(string convertBinary)
        {
            int toConvert = Convert.ToInt32(convertBinary);
            if(toConvert>=0)
            {
                string positivePart = PositiveToBinary(Convert.ToString(toConvert));
                int noZeros = 8-positivePart.Length;
                string zeros = "";
                for(int i = 0;i<noZeros;i++) 
                {
                    zeros += "0";
                }
                return zeros + positivePart;
            }
            else
            {
                string negativePart = PositiveToBinary(Convert.ToString(toConvert+128));
                int noOnes = 8-negativePart.Length;
                string ones = "";
                for(int i = 0;i<noOnes;i++) 
                {
                    ones += "1";
                }
                return ones + negativePart;
            }
        }
        static void Main()
        {   
            Console.WriteLine("Insert Number:");
            Console.WriteLine(ToBinary(Console.ReadLine()));
        }
    }
}
