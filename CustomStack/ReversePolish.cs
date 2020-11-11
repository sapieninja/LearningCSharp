using System;
using System.Collections.Generic;
namespace CustomStack
{
    public class ReversePolish
    {
        List<string> EvaluateList { get; set; }
        public int Value { get; set; }
        static readonly List<string> elements = new List<string> { "*", "/", "+", "-", " " };
        public ReversePolish(string equation)
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
                {
                    int result = 0;
                    switch (part)
                    {
                        case "*":
                            result = ProcessStack.Pop() * ProcessStack.Pop();
                            break;
                        case "/":
                            result = ProcessStack.Pop() / ProcessStack.Pop();
                            break;
                        case "+":
                            result = ProcessStack.Pop() + ProcessStack.Pop();
                            break;
                        case "-":
                            result = -ProcessStack.Pop() + ProcessStack.Pop();
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
            ReversePolish equation = new ReversePolish("3 4 -");
            Console.WriteLine(equation.Value);
        }
    }
}