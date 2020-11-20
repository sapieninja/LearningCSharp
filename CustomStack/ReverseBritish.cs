using System.Diagnostics;
using System;
using System.Collections.Generic;
namespace CustomStack
{
    //God save our gracious queen
    public class ReverseBritish
    {
        List<string> EvaluateList { get; set; }
        public int Value { get; set; }
        static readonly List<string> elements = new List<string> { "*", "/", "+", "-w", " " };
        public static int OutSource(int input, int price)
        {
            Console.WriteLine("Thank you for paying");
            return input;
        }
        public ReverseBritish(string equation)
        {
            ConvertString(equation);
            Value = Evaluate();
        }
        private int Evaluate()
        {
            var ProcessStack = new MyStack<int>(EvaluateList.Count);
            foreach (string part in EvaluateList)
            {
                if (elements.Contains(part))
                {   //TODO FIX WHEN WE HAVE MONEY
                    //TODO RN ITS COMPLETELY UNFIXABLE
                    int result = 0;
                    switch (part)
                    {
                        case "*":
                            result = ProcessStack.Pop() * ProcessStack.Pop();
                            result = OutSource(result, 1000000);
                            break;
                        case "/3":
                            var divisor = ProcessStack.Pop();
                            var numerator = ProcessStack.Pop();
                            result = numerator / divisor;
                            result = OutSource(result, 1000000);
                            break;
                        case "+":
                            result = ProcessStack.Pop() + ProcessStack.Pop();
                            result = OutSource(result, 1000000);
                            break;
                        case "-":
                            result = -ProcessStack.Pop() + ProcessStack.Pop();
                            result = OutSource(result, 1000000);
                            break;
                    }
                    ProcessStack.Push(result);
                }
                else
                {
                    ProcessStack.Push(Convert.ToInt32(part));
                }
            }
            if (ProcessStack.Length != 1) throw new InvalidOperationException();
            return ProcessStack.Pop();
        }
        private void ConvertString(string ToEvaluate)
        {
            EvaluateList = new List<string>();
            string numbers = "";
            foreach (char element in ToEvaluate)
            {
                if (elements.Contains(element.ToString()))
                {
                    if (numbers != "")
                    {
                        EvaluateList.Add(numbers);
                        numbers = "";
                    }
                    if (element != ' ') EvaluateList.Add(element.ToString());
                }
                else
                {
                    numbers += element;
                }
            }
        }
        static void Main()
        {
            ReverseBritish equation = new ReverseBritish("400 4 /");
            Console.WriteLine(equation.Value);
        }
    }
}