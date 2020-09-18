/*
Functions

For all your functions, first generate some expected values for given inputs, then compare the results with the actual values generated. 

Write quiet functions, with suitably meaningful names, that: 

… sum two integers together. 
Write a different one, with the same name, that does the same for doubles. 
… calculates the sum of the individual digits of a given integer. 
… takes an integer and returns a boolean, true if the input was prime, false otherwise.
… takes a string and counts the number of spaces in the string.
… swaps the values of two integer numbers (hint: by value vs by reference - use the ref or out keyword) , e.g. it would print True: 
             int i1 = 7;
            int i2 = 9;
            Swap(i1, i2);
            Console.WriteLine(i1 == 9 && i2 == 7);
… return a string that has the binary and hex representations of the input value 
E.g. 84 would return ‘Bin: 1010100 Hex: 54’ 

A reminder - a quiet function is one that neither reads in from Console.ReadLine(), nor does it write out via Console.WriteLine(). 

In your main function, do not use Console.ReadLine() - test your code by using explicit expected values when calling your functions. The only Console.Read() call should be the last line in the Main function to stop (Windows) terminals from quitting. 

If you finish - and have adequately tested your functions - please write (in C#) your answer to the 2004 Q1 BIO question - http://olympiad.org.uk/papers/2000/bio/bio2kr1q1.html 
*/
using System;

namespace Function_Exercises
{
    class Program
    {
        static int sum(int a, int b)
        {
            return a + b;
        }
        static double sum(double a, double b)
        {
            return a + b;
        }
        static int sumDigits(int a)
        {
            return Convert.ToString(a).Length;
        }
        static bool isPrime(int a)
        {
            if(a==1)
            {
                return false;
            }
            if(a==2)
            {
                return true;
            }
            if(a==3)
            {
                return true;
            }
            int i = 2;
            double sqrt = Math.Sqrt(a);
            do
            {
                if(a%i==0)
                {
                    return false;
                }
                i++;
            } while (i<sqrt);
            return true;
        }
        static void Main()
        {
            Console.WriteLine(Convert.ToString(sum(1,2)));
            Console.WriteLine(Convert.ToString(sum(1f,2f)));
            Console.WriteLine(Convert.ToString(sumDigits(1000)));
            Console.WriteLine(Convert.ToString(isPrime(509)));
        }

    }
}
