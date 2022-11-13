using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {   //                                                  PERFECT
        private class Node
        {
            private object element;
            private Node next;
            public Node(object element, Node prevNode)
            {
                this.Element = element;
                prevNode.Next = this;

            }
            public Node(object element)
            {
                this.Element = element;
            }
            public object Element
            {
                get { return this.element; }
                set { this.element = value; }
            }
            public Node Next
            {
                get { return this.next; }
                set { this.next = value; }
            }
        }

        private Node head;
        private Node tail;
        private int count = 0;

        public int Count { get => count; private set => count = value; }
        public object this[int index]
        {
            get
            {
                CheckIndexOutOfRange(index);
                Node currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }
                return currentNode.Element;
            }
            set
            {
                CheckIndexOutOfRange(index);
                Node current = this.head;
                if (index == 0)
                {
                    current.Element = value;
                }
                else
                {
                    for (int i = 0; i < index; i++)
                    {
                        current = current.Next;
                    }
                    current.Element = value;
                }

            }
        }
        public void Add(object element)
        {
            if (Count == 0)
            {
                Node current = new Node(element);
                this.head = current;
                this.tail = current;
            }
            else
            {
                Node newNode = new Node(element, this.tail);
                this.tail = newNode;
            }
            Count++;

        }
        public int Remove(object element)
        {
            if (Contains(element))
            {
                int index = 0;
                if (this.head.Element.Equals(element))
                {
                    this.head = this.head.Next;
                }
                else
                {
                    Node current = this.head;
                    while (current.Next != null)
                    {
                        if (current.Next.Element == element)//remove element
                        {
                            if (current.Next.Next == null) this.tail = current;
                            current.Next = current.Next.Next;
                            break;
                        }

                        current = current.Next;
                        index++;
                    }

                }
                Count--;
                return index;
            }
            return -1;
        }
        public object RemoveAt(int index)
        {
            CheckIndexOutOfRange(index);
            int x = index;
            Node current = this.head;
            Node removed;
            if (index == 0)//remove head
            {
                removed = this.head;
                this.head = this.head.Next;
            }           
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                if (index == Count-1)//if removed is tail
                {
                    this.tail = current;
                }
                removed = current.Next;
                current.Next = current.Next.Next;
            }
            Count--;
            return removed;
        }
        public int IndexOf(object element)
        {
            int index = 0;
            Node current = this.head;
            if (current.Element == element) return 0;
            while (current.Next != null)
            {
                if (current.Element == element) return index;
                current = current.Next;
                index++;
            }
            return -1;
        }
        public bool Contains(object element)
        {
            Node current = this.head;
            if (current.Element == element) return true;
            else
            {
                while (current.Next != null)
                {
                    if (current.Element == element) return true;//maybe current=>current.Next
                    current = current.Next;
                }
                if (current.Element == element) return true;
                return false;
            }
        }
        public void Reverse()
        {
            Node[] nodes = new Node[Count];
            Node current = this.head;

            for (int i = 0; i < Count; i++)
            {
                nodes[i] = current;
                current = current.Next;
            }

            this.head = nodes[Count - 1];

            current = this.head;
            for (int i = Count - 2; i >= 0; i--)
            {
                current.Next = nodes[i];
                current = current.Next;
            }
            current.Next = null;

            this.tail = current;
        }
        public void CheckIndexOutOfRange(int index)
        {
            if (index < 0 || index > Count - 1) { throw new IndexOutOfRangeException(); }
        }
    }
}
