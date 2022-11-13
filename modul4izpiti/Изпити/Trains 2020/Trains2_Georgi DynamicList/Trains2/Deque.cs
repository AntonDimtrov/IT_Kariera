using System.Collections.Generic;
using System.Linq;

namespace Trains2
{
    class Deque<T>
    {
        private class Node
        {
            public T value { get; set; }
            public Node next { get; set; }
            public Node(T value, Node next = null)
            {
                this.value = value;
                this.next = next;
            }
        }

        private Node head;
        private Node tail;
        public int Count { get; set; }
        public int Capacity { get; set; }

        public Deque() : this(16)  { }

        public Deque(int capacity)
        {
            head = null;
            tail = null;
            Capacity = capacity;
        }

        public Deque(IEnumerable<T> collection) : this(collection.Count())
        {
            int b = 0;
            Node temp = head;
            foreach (T a in collection)
            {
                if(b == 0)
                    head = new Node(a);
                temp.next = new Node(a);
                temp = temp.next;
                b++;
            }
            tail = temp;
            Capacity = collection.Count();
            Count = collection.Count();
        }

        public void AddFront(T item)
        {
            if (Count == 0)
            {
                head = new Node(item);
                tail = head;
            }
            else
            {
                Node temp = new Node(item,head);
                head = temp;
            }
            Count++;
        }

        public void AddBack(T item)
        {
            if (Count == 0)
            {
                head = new Node(item);
                tail = head;
            }
            else
            {
                tail.next = new Node(item);
                tail = tail.next;
            }
            Count++;
        }

        public T RemoveFront()
        {
            Node temp = head;
            head = head.next;
            Count--;
            return temp.value;
        }

        public T RemoveBack()
        {
            T a = tail.value;
            Node temp = head;
            for (int i = 1; i < Count - 1; i++)
                temp = temp.next;
            temp.next = null;
            tail = temp;
            Count--;
            return a;
        }

        public T GetFront()
        {
            return head.value;
        }

        public T GetBack()
        {
            return tail.value;
        }
    }  
}
