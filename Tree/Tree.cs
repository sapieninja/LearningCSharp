using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace Tree
{
    class BinaryTree<T> where T : IComparable<T>
    {
        private Node basenode;

        private class Node
        {
            public T payload;
            public Node? leftnode;
            public Node? rightnode;
        }

        private Node Basenode;

        public BinaryTree()
        {
            basenode = new Node();
        }

        public void Insert(T item)
        {
            if (Basenode.payload == null)
            {
                Basenode.payload = item;
                return;
            }

            Node workingnode = basenode;
            while (true)
                if (item.CompareTo(workingnode.payload) < 0)
                {
                    if (workingnode.leftnode == null)
                    {
                        workingnode.leftnode = new Node();
                        workingnode.leftnode.payload = item;
                        break;
                    }
                    else
                    {
                        workingnode = workingnode.leftnode;
                    }
                }
                else if (item.CompareTo(workingnode.payload) > 0)
                {
                    if (workingnode.rightnode == null)
                    {
                        workingnode.rightnode = new Node();
                        workingnode.leftnode.payload = item;
                        break;
                    }
                    else
                    {
                        workingnode = workingnode.rightnode;
                    }
                }
        }

        static void Main()
        {
            var Tree = new BinaryTree<int>();
            foreach (int x in new List<int> {100, 2, 123, 442, 15, 200, 117, 5000, 343, 200,})
            {
                Tree.Insert(x);
            }
        }
    }
}