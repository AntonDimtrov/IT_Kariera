using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BetterList
{
    class MyList<T>  where T : IComparable<T>
    {
        private const int DEFAULT_CAPACITY = 4;
        private T[] elements;
        private int count;
        private int capacity;

        public MyList(int capacity = DEFAULT_CAPACITY)
        {
            this.elements = new T[capacity];
            Capacity = capacity;
        }


        public int Count { get { return this.count; } private set { this.count = value; } }
        public int Capacity { get { return this.capacity; } private set { this.capacity = value; } }

        public void Add(T element)
        {
            if (Count == Capacity) Grow();
            elements[Count] = element;
            Count++;
        }
        public T Remove(int index)
        {
            T element = elements[index];
            for (int i = index; i < Count; i++)
            {
                elements[i] = elements[i + 1];
            }
            Count--;
            return element;
        }
        public bool Contains(T element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (elements[i].CompareTo(element) == 0) return true;
            }
            return false;
        }
        public void Swap(int index1, int index2)
        {
            (elements[index1], elements[index2]) = (elements[index2], elements[index1]);
        }
        public int CountGreaterThan(T element)
        {
            int counter = 0;
            foreach (T e in elements)
            {
                if (e.CompareTo(element) == 0) counter++;
            }
            return counter;
        }
        public T Max()
        {
            return elements.OrderBy(x => x).Last();
        }
        public T Min()
        {

            return elements.OrderBy(x => x).First();
        }
        public void Sort()
        {
            elements = elements.Skip(Capacity-Count).OrderBy(x => x).ToArray();
        }
        public void SortDescending()
        {
            elements = elements.OrderByDescending(x => x).ToArray();
        }
        public void Print()
        {
            Console.WriteLine(string.Join(" ", elements));
        }

        private void Grow()
        {
            T[] newElements = new T[capacity * 2];
            for (int i = 0; i < this.elements.Length; i++)
            {
                newElements[i] = elements[i];
            }
            this.elements = newElements;
            this.capacity *= 2;
        }
    }
}
