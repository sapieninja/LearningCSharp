using System;

namespace Iteration
{
    public class Program
    {   
        static void CountDown(int n)
        {
            for(int x = 1; x<n; x++)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Blast Off");
        }
        static void timesTable(int table,int amount)
        {   
            int x = 1;
            do
            {
                Console.WriteLine(String.Format("{0,3} + {1,3} = {2,3}",table,x,x*table));
                x++;
            } while (x<amount);
        }
        static void askN(int n)
        {
            double sum = 0;
            Console.WriteLine("Enter" + n + "values");
            for(int i = 0;i<n;i++)
            {
                sum +=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Total" + sum);
            Console.WriteLine("Total" + (sum/n));
        }
        public static int triangular(int n)
        {
            return (n*n+n)/2;
        }
        static int findUnknown(int[] numbers,int location)
        {
            // Gets passed a ten digit array with a negative 1 to represent the unknown value
            // Turns this into a corrected array with the unknown found
            int sum = 0;
            int x = 10;
            int multiplier = 0;
            int answer = 0;
            foreach(int number in numbers)
            {   
                if(number>=0)
                {
                    sum += x*number;
                }
                else
                {
                multiplier = x;
                }
                x--;
            }
            for(int y = 0;y<=10;y++)
            {
                if((y*multiplier+sum)%11==0)
                {
                    answer = y;
                }
            }
            return answer;
        }
        public static string ISBNfindMissing(string ISBNcode)
        {
            int[] numbers = new int[10];
            int x = 0;
            int location = ISBNcode.IndexOf('?');
            foreach(char element in ISBNcode)
            {   
                numbers[x] = element-48;
                if(element>58)
                {
                    if(element=='?')
                    {
                        numbers[x] = -1;
                    }
                    else
                    {
                        numbers[x] = 10;
                    }
                }
                x++;
            }
            int answer = findUnknown(numbers,location);
            string stringAnswer = "";
            if(answer==10)
            {
                stringAnswer = "X";
            }
            else{
                stringAnswer = Convert.ToString(answer);
            }
            return stringAnswer;
        }
        public static int toFront(int a)
        {
            string aString = Convert.ToString(a);
            aString = aString[aString.Length-1] + aString.Substring(0,aString.Length-1);
            return Convert.ToInt32(aString);
        }
        static void Main()
        {
            Console.WriteLine("hello world");
        }
        
    }
}
