using System;
using System.Collections.Generic;
namespace ListExercises
{
    public class Fractions
    {
        static List<int> Simplify(int numerator,int denominator)
        {
            int minValue = numerator;
            bool doAgain = false;
            for(int i = 2;i<=minValue;i++)
            {
                if(numerator%i==0&&denominator%i==0)
                {
                    numerator /= i;
                    denominator /= i;
                    doAgain = true;
                    break;
                }
            }
            if(doAgain)
            {
                var newList = Simplify(numerator,denominator);
                numerator = newList[0];
                denominator = newList[1];
            }
            List<int> toReturn = new List<int>{numerator,denominator};
            return toReturn;
        }
        public static string Fraction(string input)
        {
            int difference = 6 - input.Length;
            for(int i = 0;i<difference;i++)
            {
                input += '0';
            }
            int numerator = Convert.ToInt32(input.Substring(2,4));
            int denominator = 10000;
            var values = Simplify(numerator,denominator);
            numerator = values[0];
            denominator = values[1];
            return Convert.ToString(numerator) + '/' + Convert.ToString(denominator);
        }
        static IEnumerable<string> Decimals()
        {   
            for(int i = 1;i<10000;i++)
            {
                string number = Convert.ToString(i);
                string output = "";
                int finish = 4-number.Length;
                for(int x=0;x<finish;x++)
                {
                    output += "0";
                }
                number = "0." + output + number;
                yield return number;
            }
            
        }
        public static int Unique()
        {   
            List<int> uniqueDenoms = new List<int>();
            foreach(string number in Decimals())
            {
                var values = Simplify(Convert.ToInt32(number.Substring(2,4)),10000);
                int denominator = values[1];
                if(!uniqueDenoms.Contains(denominator))
                {
                    uniqueDenoms.Add(denominator);
                }
            }
            return uniqueDenoms.Count;//Returns 24
        }
    }
}