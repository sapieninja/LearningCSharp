using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private class Node
        {
           public T payload;
           public Node prevnode;
           public Node nextnode;

           public Node(T? _payload, Node _prevnode, Node _nextnode)
           {
               payload = _payload;
               prevnode = _prevnode;
               nextnode = _nextnode;
           }
        }

        private readonly Node head; 
        private Node? current;

        public T CurrentValue
        {
            get { return current.payload; }
        }
        private readonly bool _cyclical; 
        private readonly bool _doubled;
        private Node? Head;
        private Node? End;
        public int Length { get; private set; }

        
        public LinkedList(bool cyclical = false, bool doubled = false) {
            _cyclical = cyclical;
            _doubled = doubled;
            if (cyclical == false)
            {
                Head = AddNode(null,default(T));
                current = Head;
                End = AddNode(Head,default(T));
            }
            Length = 0;
            //We don't define anything until the first item is generated in the event of the list being circular
        }

        public LinkedList(IEnumerable<T> enumerable, bool cyclical = false, bool doubled = false) : base()
        {
            Node startnode = Head;
            foreach (T a in enumerable)
            {
                startnode = AddNode(startnode,a);
            }
        }

        private Node AddNode(Node previous,T? payload)
        {
            Node newnode;
            if (Length == 0 && _cyclical == true)
            {
                newnode = new Node(payload, null, null);
                newnode.prevnode = newnode;
                newnode.nextnode = newnode;
                current = newnode;
            }
            if (previous == null)//in the case that Head is created which doesn't have a previous node
            {
                newnode = new Node(payload,null,null);
            }
            else
            {
                Node previousaim = previous.nextnode;
                newnode = new Node(payload, previous, previousaim);
                if (_doubled == false)
                {
                    newnode.prevnode = null;
                }
                previous.nextnode = newnode;
            }

            Length++;
            return newnode;
        }
        public List<T> GetList()
        {
            List<T> stuff = new List<T>(); //difficulty with enumerators just did a memory heavy approach for now
            if (_cyclical == true)
            {
                Node startnode = current;
                Node nextnode = current;
                do
                {
                    stuff.Add(nextnode.payload);
                    nextnode = nextnode.nextnode;
                } while (nextnode != startnode);
            }
            else
            {
                Node nextnode = Head.nextnode;
                while (nextnode != End)
                {
                    stuff.Add(nextnode.payload);
                    nextnode = nextnode.nextnode;
                }
            }

            return stuff;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return GetList().GetEnumerator();
        }

        public void Add(T item)
        {
            AddNode(current, item);
            Forward();
        }

        public void Clear()
        {
            if (_cyclical == true)//in this case we simply dereference the current node and all of the other nodes simply get lost
            {
                current = null;
                Length = 0;
            }
            else
            {
               //in this case i can just set the head pointer to end and (if doubly linked) the end pointer to head to the start
               Head.nextnode = End;
               if (_doubled)
               {
                   End.prevnode = Head;
               }

               Length = 0;
            }
        }

        private void RemoveAfter(Node node)
        {
            node.nextnode = node.nextnode.nextnode;
            //dereferences
            if (_doubled)
            {
                node.nextnode.prevnode = node;
            }
        }
        private void RemoveNode(Node node)
        {
            //if doubly linked is off we have to loop the whole way through to find the previous node so we don't do this and implement a remove next method instead
            if (_doubled == false)
            {
                throw new InvalidOperationException();
            }
            else
            {
                Node prevnode = node.prevnode;
                Node nextnode = node.nextnode;
                prevnode.nextnode = nextnode;
                nextnode.prevnode = prevnode;
                //current node has been de-referenced
                if (current == node)
                {
                    current = prevnode;
                    //we don't want to delete the whole list because of this
                }

                Length--;
            }
        }
        public bool Contains(T item)
        {
            foreach (T element in GetList())
            {
                if (element.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            Node startnode = Head;
            if (Head == null)
            {
                startnode = current;
            }

            Node worknode = startnode;
            while(true)
            {
                if (worknode.nextnode.payload!=null&&worknode.nextnode.payload.Equals(item)&&_doubled)
                {
                    RemoveAfter(worknode);
                    break;
                }
                else if (worknode.payload!=null&&worknode.payload.Equals(item) && (!_doubled))
                {
                    RemoveNode(worknode);
                }
                worknode = worknode.nextnode;
                if (worknode == startnode || startnode == null || (_cyclical==false&&worknode==End))
                {
                    break;
                }
            }

            return true;
        }

        public int Count { get; }
        public bool IsReadOnly { get; }

        public T this[int index]
        {
            get => GetList()[index];
            set => throw new NotImplementedException();
        }

        public void Forward()
        {
            current = current.nextnode;
        }

        public void Backward()
        {
            current = current.prevnode;
        }
    }
}