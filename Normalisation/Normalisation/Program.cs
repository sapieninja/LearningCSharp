using System;
/*
Implement the normalisation algorithm in a programming language of your choice.  Pseudocode is attached.  It works the same for both positive and negative mantissas.  
You have freedom to implement this in any way that you want (for example you do not need to use strings) but here are some minimum requirements/guidelines:

Write a FUNCTION/METHOD to implement the algorithm  There is no need for user input from a keyboard or console output.  Your function should take a string as an argument and return a string.

Input:  a string representing 16 bits, which represents a floating point number (that could be in un-normalised form) where the first 12 bits are the mantissa and the last 4 bits are the exponent.
Example: "0000111100001111".  This is meant to represent a floating point number where the mantissa is "000011110000" and the exponent is "1111"

Output: a string of 10 bits, representing the normalised version of the input number, where the mantissa uses 6 bits, and the exponent uses 4 bits.*/

namespace Normalisation
{
    public class Program
    {   
        public static string normaliser(string unnormalised)
        {
            string mantissa = unnormalised.Substring(0,12);
            string exponent = unnormalised.Substring(12,4);
            while(mantissa[0] == mantissa[1])
            {
                mantissa = mantissa[0] + mantissa.Substring(2,10) + "0";
                exponent = Convert.ToString(Convert.ToInt32(exponent,2)-1,2);
            }
            return mantissa.Substring(0,6) + exponent;
        }
        static void Main(string[] args)
        {   
            Console.WriteLine(normaliser("0000111100001111"));
        }
    }
}
