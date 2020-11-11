using System;

namespace CustomStack
{
    public class MyStack<T>
    {
        private int StackPointer;
        private T[] TheStack;
        public int Length { get => StackPointer + 1; }
        public MyStack(int size)
        {
            TheStack = new T[size];
            StackPointer = -1;
        }
        public void Push(T item)
        {
            StackPointer++;
            TheStack[StackPointer] = item;
        }
        public T Pop()
        {
            StackPointer--;
            return TheStack[StackPointer + 1];
        }
    }
}
