using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomQueue
{
    class MyQueue<T>
    {
        private T[] elements;
        private int count=0;
        private int capacity;
        private const int INITIAL_CAPACITY = 2;
        public MyQueue(int capacity = INITIAL_CAPACITY)
        {
            this.elements = new T[capacity];
            this.capacity = capacity;
        }
        public void Enqueue(T element)
        {
            if (count == capacity) Grow();
            elements[capacity - count - 1] = element;
            this.count++;
        }
        public T Dequeue()
        {
            if (this.count < 1) throw new ArgumentException("Queue is empty");
            T removed = this.elements[capacity - 1];
            T[] nullElement = new T[1] { default(T) };    
            this.elements = nullElement.Concat(this.elements.Take(capacity - 1).Concat(this.elements.Skip(capacity))).ToArray();
            this.count--;
            return removed;
        }
        public T Peek()
        {
            if (this.count < 1) throw new ArgumentException("Queue is empty");
            return this.elements[capacity-1];
        }
        public T[] ToArray()
        {
            T[] array = new T[this.count];
            for(int i = 0; i < this.count; i++)
            {
                array[i] = elements[capacity - 1 - i];
            }
            return array;
        }
        public void Grow()
        {
            T[] newElements = new T[this.capacity * 2];
            for(int i = 0; i < this.count; i++)
            {
                newElements[i] = elements[i];
            }
            this.elements = newElements;
        }

    }
}
