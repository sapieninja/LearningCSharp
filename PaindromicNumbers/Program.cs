using System.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PaindromicNumbers
{
    public class Program
    {
        static BigInteger mirror(List<int> digits)
        {
            for (int i = 0; i < digits.Count / 2; i++)
            {
                digits[digits.Count - i - 1] = digits[i];
            }
            string result = "";
            foreach (var element in digits)
            {
                result += element;
            }
            return BigInteger.Parse(result);
        }
        public static BigInteger NextPain(BigInteger number)
        {
            //First we check if the mirror of this number is greater if so we just use this
            BigInteger mirrorResult = mirror(number.ToString().ToCharArray().Select(c => (int)c - 48).ToList());
            if (mirrorResult > number)
            {
                return mirrorResult;
            }
            /*
            If the mirror is not greater we need to add something to our number in order to fix this.
            We will add the required amount to our number so that the mirror is greater.
            We want to staSrt on the inside of the number because this will make the mirrored part bigger.
            */
            var digits = number.ToString().ToCharArray().Select(c => (int)c - 48).ToList();
            do
            {
                int middle = (digits.Count - 1) / 2;
                while (true)
                {
                    if (digits[middle] != 9)
                    {
                        digits[middle]++;
                        break;
                    }
                    else
                    {
                        digits[middle] = 0;
                        if (middle > 0)
                        {
                            middle--;
                        }
                        else
                        {
                            digits.Insert(0, 0);
                        }
                    }
                }
            } while (mirror(digits) < number);
            return mirror(digits);
        }
        static void Main()
        {
            Console.WriteLine(NextPain(9999999999999999999));
        }
    }
}
