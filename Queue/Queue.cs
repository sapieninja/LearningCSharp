using System;
namespace CustomStack
{
    public class MyQueue<T>
    {
        private T?[] TheQueue;
        private int Tail;
        private int? Head;
        public MyQueue(int length)
        {
            TheQueue = new T[length];

            Tail = 0;
        }
        public void Enqueue(T element)
        {
            if (Tail != Head)
            {
                TheQueue[Tail] = element;
                Tail++;
                if (Tail == TheQueue.Length) Tail = 0;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public T Dequeue()
        {
            int? a = Head;
            Head--;
            if (Head == -1) Head = TheQueue.Length;
            if (Head == Tail) Head = null;
            if (Head is null) throw new Exception("Head is null");
            return TheQueue[(int)Head];
        }
    };
    public class Program
    {
        public static void Main()
        {
            var NewQueue = new MyQueue<string>(5);
            while (true)
            {
                string option = Console.ReadLine();
                if (option == "a") NewQueue.Enqueue(Console.ReadLine());
                if (option == "d") Console.WriteLine(NewQueue.Dequeue());
            }
        }
    }
}

