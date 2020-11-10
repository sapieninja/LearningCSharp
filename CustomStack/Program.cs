#pragma warning disable
using System;

namespace CustomStack
{
    class MyStack<T>
    {
        private int StackPointer;
        private T?[] TheStack;
        public MyStack(int size)
        {
            TheStack = new T?[size];
            StackPointer = -1;
        }
        public void push(T item)
        {
            StackPointer++;
            TheStack[StackPointer] = item;
        }
        public T pop()
        {
            StackPointer--;
            return TheStack[StackPointer + 1];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new MyStack<string>(10);
            stack.push("m");
            stack.push("B");
            Console.WriteLine(stack.pop());
            stack.push("o");
            stack.push("o");
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
        }
    }
}
