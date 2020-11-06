#nullable enable
using System;

namespace CustomStack
{
    class MyStack
    {
        private int StackPointer;
        private string?[] TheStack;
        public MyStack(int size)
        {
            TheStack = new string?[size];
            StackPointer = -1;
        }
        public void push(string item)
        {
            StackPointer++;
            TheStack[StackPointer] = item;
        }
        public string pop()
        {
            StackPointer--;
            return TheStack[StackPointer + 1];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new MyStack(10);
            stack.push("m");
            stack.push("B");
            Console.WriteLine(stack.pop());
            stack.push("o");
            stack.push("o");
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
        }
    }
}
