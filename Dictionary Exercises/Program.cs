using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> MyDict = new Dictionary<string, string>();
            while (true)
            {
                Console.WriteLine("Query or Add?");
                if (Console.ReadLine() == "q")
                {
                    Console.WriteLine(MyDict[Console.ReadLine()]);
                }
                else
                {
                    string input = Console.ReadLine();
                    MyDict[input.Split()[0]] = input.Split()[1];
                }
            }
        }
    }
}
