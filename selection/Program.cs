using System;

namespace selection_max
{
    class Program
    {
        static void Isequal(int a, int b)
        {
            Console.WriteLine(Convert.ToString(a == b));
        }
        static void Iseven(int a)
        {
            Console.WriteLine(Convert.ToString(Convert.ToBoolean(a % 2 + 1)));
        }
        static bool Leap(int a)
        {
            if (a % 4 == 0)
            {
                if (a % 100 != 0)
                {
                    if (a % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        static int Max(int a, int b, int c)
        {
            if (a > b && b > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        static void Coords(int x, int y, int r,int x1, int y1)
        {
            if(x>=0)
            {
                if(y>=0)
                {
                    Console.WriteLine("Upper Right");
                }
                else
                {
                    Console.WriteLine("Lower Right");
                }
            }
            else
            {
                if(y>=0)
                {
                    Console.WriteLine("Upper Left");
                }
                else
                {
                    Console.WriteLine("Lower Left");
                }
            }
            if (Math.Sqrt(x * x + y * y) <= r)
            {
                Console.WriteLine("Within radius");
            }
            else
            {
                Console.WriteLine("Not Within radius");
            }
            if(Math.Sqrt((x-x1)*(x-x1)+(y-y1)*(y-y1))<=r)
            {
                Console.WriteLine("Within Radius");
            }
            else
            {
                Console.WriteLine("Not Within radius");
            }
        }
        static void Score(int a, int b, int c)
        {
            double avg = (a+b+c)/3.0f;
            if(avg > 90f)
            {
                Console.WriteLine("A*");
            }
            else if(avg>=90f)
            {
                Console.WriteLine("A");
            }
            else if(avg>=70f)
            {
                Console.WriteLine("B");
            }
            else if(avg>=50f)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
        static void Triangle(int a,int b,int c)
        {   
            if((a+b)<c | (a+c)<b | (c+b)<a)
            {
                Console.WriteLine("Impossible");
            }
            else if(a==b && b==c && c==a)
            {
                Console.WriteLine("Equilateral");
            }
            else if((a==b ^ b==c ^ c==a))
            {
                Console.WriteLine("Isoceles");
            }
            else
            {
                Console.WriteLine("Scalene");
            }
        }
        static void Main()
        {
            Isequal(1, 1);
            Iseven(3);
            Console.WriteLine(Convert.ToString(Leap(2000)));
            Console.WriteLine(Max(1, 40, 29));
            Coords(3,4,5,5,6);
            Triangle(20,20,2);
            Score(5,10,5);
        }
    }
}
