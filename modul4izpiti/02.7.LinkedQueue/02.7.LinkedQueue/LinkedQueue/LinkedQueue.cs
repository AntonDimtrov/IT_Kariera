using System;

namespace LinkedQueue
{
    class LinkedQueue<T>
    {
        private QueueNode<T> head;
        private QueueNode<T> tail;
        public int Count { get; private set; }
        public LinkedQueue()
        {
            head = null;
            tail = null;
        }
        public void Enqueue(T element)
        {
            QueueNode<T> node = new QueueNode<T>(element);
            if (Count == 0)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.NextNode = node;
                node.PrevNode = tail;
                tail = node;
            }
            Count++;
        }

        public T Dequeue()
        {
            if (Count == 0)
                throw new InvalidOperationException();
            T element = head.Value;
            head = head.NextNode;
            if (head == null) tail = null;
            else head.PrevNode = null;
            Count--;
            return element;
        }

        public T[] ToArray()
        {
            T[] arr = new T[Count];
            QueueNode<T> t = head;
            int i = 0;
            while (t != null)
            {
                arr[i] = t.Value;
                i++;
                t = t.NextNode;
            }
            return arr;
        }

        private class QueueNode<T>
        {
            public T Value { get; private set; }
            public QueueNode<T> NextNode { get; set; }
            public QueueNode<T> PrevNode { get; set; }
            public QueueNode(T value)
            {
                Value = value;
                NextNode = null;
                PrevNode = null;
            }
        }
    }
}
