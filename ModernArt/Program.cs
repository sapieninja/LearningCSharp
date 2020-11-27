using System.Numerics;
using System;

namespace ModernArt
{
    public class Program
    {
        static BigInteger Factorial(int n)
        {
            BigInteger output = 1;
            for (BigInteger i = 1; i <= n; i++)
            {
                output *= i;
            }
            return output;
        }
        static BigInteger NoWays(int a, int b, int c, int d)
        {
            BigInteger factorial = Factorial(a + b + c + d);
            if (a == 0) a = 1;
            if (b == 0) b = 1;
            if (c == 0) c = 1;
            if (d == 0) d = 1;
            return factorial / (Factorial(a) * Factorial(b) * Factorial(c) * Factorial(d));
        }

        public static string Arrangement(int a, int b, int c, int d, BigInteger n)
        {
            // I could iterate but that would be too slow (hopefully)
            BigInteger addition;
            BigInteger sum = 0;
            if (a != 0)
            {
                sum += NoWays(a - 1, b, c, d);
                if (n <= sum)
                {
                    if (a + b + c + d >= 1)
                    {
                        return "A" + Arrangement(a - 1, b, c, d, n);
                    }
                    else return "A";
                }
            }
            if (b != 0)
            {
                addition = NoWays(a, b - 1, c, d);
                sum += addition;
                if (n <= sum)
                {
                    if (a + b + c + d >= 1)
                    {
                        return "B" + Arrangement(a, b - 1, c, d, n - (sum - addition));
                    }
                    else return "B";
                }
            }
            if (c != 0)
            {
                addition = NoWays(a, b, c - 1, d);
                sum += addition;
                if (n <= sum)
                {
                    if (a + b + c + d >= 1)
                    {
                        return "C" + Arrangement(a, b, c - 1, d, n - (sum - addition));
                    }
                    else return "C";
                }
            }
            if (d != 0)
            {
                addition = NoWays(a, b, c, d - 1);
                sum += addition;
                if (n <= sum)
                {
                    if (a + b + c + d >= 1)
                    {
                        return "D" + Arrangement(a, b, c, d - 1, n - (sum - addition));
                    }
                    else return "D";
                }
            }
            return "";
        }
        static void Main(string[] args)
        {
            string input;
            string[] parts;
            while (true)
            {
                input = Console.ReadLine();
                parts = input.Split();
                int a = Convert.ToInt32(parts[0]);
                int b = Convert.ToInt32(parts[1]);
                int c = Convert.ToInt32(parts[2]);
                int d = Convert.ToInt32(parts[3]);
                BigInteger n = BigInteger.Parse(parts[4]);
                Console.WriteLine(Arrangement(a, b, c, d, n));
            }
        }
    }
}
