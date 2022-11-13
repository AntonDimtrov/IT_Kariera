using System;
using System.Collections.Generic;
using System.Text;

namespace CustomQueue
{
    class LinkedQueue<T>
    {
        private class Node
        {
            private T element;
            private Node next;
            public T Element { get => element; set => element = value; }
            public Node Next { get { return this.next; } set { this.next = value; } }

            public Node(T element)
            {
                this.Element = element;
            }
            public Node(T element, Node prevNode)
            {
                this.Element = element;
                prevNode.Next = this;

            }

        }
        private Node head;
        private Node tail;

        private int Count;
        public void Enqueue(T element)
        {
            if (Count == 0)
            {
                Node newNode = new Node(element);
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                Node newNode = new Node(element, this.tail);
                this.tail = newNode;
            }
            Count++;
        }
        public T Dequeue()
        {
            if (Count < 1) throw new AggregateException("Queue is Empty!");
            T returned = this.head.Element;
            this.head = this.head.Next;
            Count--;

            return returned;

        }
        public T Peek()
        {
            if (Count < 1) throw new AggregateException("Queue is Empty!");
            return this.head.Element;
        }
        public bool Contains(T element)
        {
            if (Count > 0)
            {
                Node current = this.head;
                if (current.Element.Equals(element)) return true;
                while (current.Next != null)
                {
                    if (current.Next.Element.Equals(element)) return true;
                    current = current.Next;
                }
            }
            return false; ;

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
        } //
        public void Clear()
        {
            if (Count >= 1)
            {
                this.head = null;
                this.tail = null;
                Count = 0;
            }
        }
    }
}
