using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class DoubleLinkedList<T>
    {
        private class Node
        {
            private T element;
            private Node next;
            private Node prev;
            public Node(T element, Node prevNode)
            {
                this.Element = element;
                this.prev = prevNode;
                prevNode.Next = this;

            }
            public Node(T element)
            {
                this.Element = element;
            }
            public Node() { }
            public T Element
            {
                get { return this.element; }
                set { this.element = value; }
            }
            public Node Next
            {
                get { return this.next; }
                set { this.next = value; }
            }
            public Node Prev
            {
                get { return this.prev; }
                set { this.prev = value; }
            }
        }

        private Node head;
        private Node tail;
        private int count = 0;

        public int Count { get => count; set => count = value; }

        public T this[int index]
        {
            get
            {
                CheckIndexOutOfRange(index);
                Node current = this.head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                return current.Element;
            }
            set
            {
                Node current = this.head;
                if (Count == 0) current.Element = value;
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
        public void Add(T element)
        {
            if (Count == 0)
            {
                this.head = new Node(element);

            }
            else
            {
                Node current = this.head;
                for (int i = 0; i < Count - 1; i++)
                {
                    current = current.Next;
                }
                Node newNode = new Node(element, current);
                this.tail = newNode;
            }
            Count++;
        }
        public T RemoveAt(int index)
        {
            CheckIndexOutOfRange(index);
            Node removed;
            if (index == 0)//remove head
            {
                removed = this.head;
                this.head = this.head.Next;
            }
            else if (index == Count - 1)//remove tail
            {
                removed = this.tail;
                this.tail.Prev.Next = null;
                this.tail = this.tail.Prev;

            }
            else
            {
                Node current = this.head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                removed = current.Next;
                current.Next = current.Next.Next;
                current.Next.Prev = current;
            }
            Count--;
            return removed.Element;
        }
        public int Remove(T element)
        {
            if (Count < 1) throw new ArgumentException("List is empty");
            if (Contains(element))
            {
                Node current = this.head;
                int index = 0;
                if (current.Next == null)
                {
                    this.head = this.head.Next;
                }
                else
                {
                    while (current.Next != null)
                    {
                        if (current.Next.Element.Equals(element))
                        {
                            current.Next = current.Next.Next;
                            if (current.Next != null) current.Next.Prev = current;//element removed wasnt tail
                            else this.tail = current; //element removed was tail

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
        public void Replace(T element, int index)
        {
            Node replacement = new Node(element);
            Node current = this.head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            //order is important!
            replacement.Prev = current;
            replacement.Next = current.Next.Next;
            current.Next.Next.Prev = replacement;
            current.Next = replacement;
        }
        public void Insert(T element, int index)
        {
            Node insertment = new Node(element);
            Node current = this.head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            //order is important!
            current.Next.Prev = insertment;
            insertment.Next = current.Next;
            insertment.Prev = current;
            current.Next = insertment;
            Count++;
        }
        public int IndexOf(T element)
        {
            Node current = this.head;
            int index = 0;
            if (current.Element.Equals(element)) return 0;
            while (current.Next != null)
            {
                if (current.Element.Equals(element)) return index;
                current = current.Next;
                index++;
            }
            return -1;
        }
        public bool Contains(T element)
        {
            if (Count > 0)
            {
                Node current = this.head;
                if (current.Element.Equals(element)) return true;
                while (current.Next != null)
                {
                    if (current.Element.Equals(element)) return true;
                    current = current.Next;
                }
                if (current.Element.Equals(element)) return true;
            }
            return false;
        }
        public void Reverse()
        { 
        }
        private Node[] ToNodeArray()
        {
            Node[] nodes = new Node[Count];
            Node current = this.head;

            for (int i = 0; i < Count; i++)
            {            
                nodes[i] = current;
                current = current.Next;
            }
            return nodes;
        }
        public T[] ToArray()
        {
            T[] array = new T[Count];
            Node current = this.head;
            for (int i = 0; i < Count; i++)
            {
                array[i] = current.Element;
                current = current.Next;
            }
            return array;
        }
        public void CheckIndexOutOfRange(int index)
        {
            if (index < 0 || index > Count - 1) throw new IndexOutOfRangeException();
        }
    }
}
