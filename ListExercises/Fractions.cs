using System;
using System.Collections.Generic;
namespace ListExercises
{
    public class Fractions
    {
        static List<int> simplify(int numerator,int denominator)
        {
            int minValue = numerator;
            bool doAgain = false;
            for(int i = 2;i<=minValue;i++)
            {
                if(numerator%i==0&&denominator%i==0)
                {
                    numerator = numerator/i;
                    denominator = denominator/i;
                    doAgain = true;
                    break;
                }
            }
            if(doAgain)
            {
                var newList = simplify(numerator,denominator);
                numerator = newList[0];
                denominator = newList[1];
            }
            List<int> toReturn = new List<int>{numerator,denominator};
            return toReturn;
        }
        public static string fraction(string input)
        {
            int difference = 6 - input.Length;
            for(int i = 0;i<difference;i++)
            {
                input += '0';
            }
            int numerator = Convert.ToInt32(input.Substring(2,4));
            int denominator = 10000;
            var values = simplify(numerator,denominator);
            numerator = values[0];
            denominator = values[1];
            return Convert.ToString(numerator) + '/' + Convert.ToString(denominator);
        }
    }
}