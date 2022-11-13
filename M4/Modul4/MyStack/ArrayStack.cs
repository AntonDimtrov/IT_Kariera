using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack
{
    class ArrayStack<T>
    {
        private T[] elements;
        public int Count { get; private set; }
        private const int InitialCapacity=2;
        public ArrayStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
        }

        public int GetCapacity()
        {
            return this.elements.Length;
        }
        public void Push( T element)
        {
            if (Count == this.elements.Length) Grow();

            this.elements[Count] = element;
            Count++;
        }
        public T Pop()
        {   if (Count < 1) throw new ArgumentException("Stack is empty");
            T removed = this.elements[Count];
            this.elements[Count] = default(T);
            Count--;
            return removed;
        }
        public T Peek()
        {
            if (Count < 1) throw new ArgumentException("Stack is empty");
            return this.elements[Count-1];
        }
        public T[] ToArray()
        {
            T[] array = new T[Count];
            for(int i = 0; i < Count; i++)
            {
                array[i] = this.elements[i];
            }
            return array;
        }
        public void Grow()
        {
            T[] newElements = new T[2 * this.elements.Length];
            for(int i = 0; i < this.elements.Length; i++)
            {
                newElements[i] = this.elements[i];
            }
            this.elements = newElements;
        }
    }
}
