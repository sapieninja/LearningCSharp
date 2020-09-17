using System;

namespace selection_max
{
    class Program
    {   
        static void isequal(int a,int b)
        {
        Console.WriteLine(Convert.ToString(a==b));
        }
        static void iseven(int a)
        {
        Console.WriteLine(Convert.ToString(Convert.ToBoolean(a%2+1)));
        }
        static bool leap(int a)
        {
        if (a%4==0)
        {
            if(a%100!=0)
            {
                if(a%400==0)
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
        else{
            return false;
        }
        }
        static int max(int a,int b,int c)
        {
        if(a>b && b > c){
            return a;
        }
        else if(b > a && b > c){
            return b;
        }
        else{
            return c;
        }
        }
        static void Main(string[] args)
        {
        isequal(1,1);
        iseven(3);
        Console.WriteLine(Convert.ToString(leap(2000)));
        Console.WriteLine(max(1,40,29));
        }
    }
}
