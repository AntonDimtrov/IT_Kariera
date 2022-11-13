using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReversedList
{
    class ReversedList<T> : IEnumerable<T>
    {

        //private T[] elements;
        private T[] elementsR;
        private const int INITIAL_CAPACITY = 2;
        public int Count { get; private set; }

        public int Capacity
        {
            get { return this.elementsR.Length; }
            private set { Capacity = value; }
        }
        public ReversedList(int capacity = INITIAL_CAPACITY)
        {
            //this.elements = new T[capacity];
            this.elementsR = new T[capacity];
        }
        public T this[int index]
        {
            get { return elementsR[Capacity - Count + index]; }
            set { elementsR[Capacity - Count + index] = value; }
        }
        public void Add(T element)
        {
            if (Count == Capacity) Grow();
            //elements[Count] = element;
            elementsR[Capacity - Count - 1] = element;
            Count++;
        }
        public T RemoveAt(int index)
        {
            CheckIndexOutOfRange(index);
            index = index + Capacity - Count;
            T removed = elementsR[index];


            RemoveElement(index);
            return removed;
        }
        public int Remove(T element)
        {
            int index = IndexOf(element);
            if (index == -1) return index;

            RemoveElement(index);
            return index;

        }
        public bool Contains(T element)
        {
            for (int i = Capacity - Count; i < Capacity; i++)
            {
                if (elementsR[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }
        public int IndexOf(T element)
        {
            for (int i = Capacity - Count; i < Capacity; i++)
            {
                if (elementsR[i].Equals(element))
                {
                    return i - (Capacity - Count);//without 0's infront( 0023.indexOf(2)->0)
                }
            }
            return -1;
        }
        public void PrintR()
        {
            int startIndex = Capacity - Count;
            for (int i = startIndex; i < Capacity; i++)
            {
                Console.Write(elementsR[i] + " ");
            }
            Console.WriteLine();
        }
        /*public void Print()
        {

            for (int i = 0; i < Count; i++)
            {
                Console.Write(elements[i] + " ");
            }
            Console.WriteLine();
        }*/
        public void RemoveElement(int index)
        {
            ShowRemovedElementPosition(index);

            var nullElement = new T[1] { default(T) };

            //this.elements = this.elements.Take(index).Concat(this.elements.Skip(index + 1)).Concat(nullElement).ToArray();
            this.elementsR = nullElement.Concat(this.elementsR.Take(index).Concat(this.elementsR.Skip(index + 1))).ToArray();

            Count--;
        }
        private void ShowRemovedElementPosition(int index)
        {
            /*Console.Write("Elements: ");
            for (int i = 0; i < Count; i++)
            {
                if (i == index) Console.Write("X ");
                else Console.Write(elements[i] + " ");
            }
            Console.WriteLine();*/

            Console.Write("ElementsReversed: ");
            for (int i = Capacity - Count; i < Capacity; i++)
            {
                if (i == index) Console.Write("X ");
                else Console.Write(elementsR[i] + " ");
            }
            Console.WriteLine();
        }
        public void Grow()
        {
            int newCapacity = Capacity * 2;
            //T[] newElements = new T[newCapacity];
            T[] newElementsR = new T[newCapacity];

            for (int i = 0; i < Count; i++)
            {
                //newElements[i] = elements[i];
                newElementsR[(newCapacity - 1) - i] = elementsR[(Capacity - 1) - i];
            }
            //this.elements = newElements;
            this.elementsR = newElementsR;
        }
        private void CheckIndexOutOfRange(int index)
        {
            if (index < 0 || index >= Capacity) throw new ArgumentException("Index out of range");
        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
