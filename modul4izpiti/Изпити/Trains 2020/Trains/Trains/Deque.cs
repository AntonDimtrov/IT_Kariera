using System;
using System.Collections.Generic;
using System.Linq;

namespace Trains
{
    class Deque<T>  //може и Train
    {
        private T[] arr;
        private const int defaultCapacity = 16;
        public int Capacity; //показва капацитета
        public int Count; //показва броя елементи

        public Deque() : this(defaultCapacity)
        {   //празен конструктор, задава капацитета на дека на стойността по подразбиране (16)
            arr = new T[defaultCapacity];
            Capacity = defaultCapacity;
        }

        public Deque(int capacity)
        {   //създава дека с точно зададен капацитет
            arr = new T[capacity];
            Capacity = capacity;
        }

        public Deque(IEnumerable<T> collection) : this(collection.Count())
        {   //създава дека с капацитет съответстващ на посочената колекция и прехвърля елементите от колекцията в дека
            arr = collection.ToArray();
            Capacity = collection.Count();
            Count = collection.Count();
        }

        private void Grow()
        {
            Array.Resize(ref arr, Capacity * 2);
            Capacity = Capacity * 2;
        }

        public void AddFront(T item)
        {
            if (this.Count == this.Capacity) Grow();
            for (int i = Count; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = item;
            Count++;
        }

        public void AddBack(T item)
        {
            if (this.Count == this.Capacity) Grow();
            this.arr[this.Count] = item;
            this.Count++;
        }

        public T RemoveFront()
        {
            T item = arr[0];
            for (int i = 0; i < Count - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Count--;
            return item;
        }

        public T RemoveBack()
        {
            T item = arr[Count - 1];
            Count--;
            return item;
        }

        public T GetFront()
        {
            return arr[0];
        }

        public T GetBack()
        {
            return arr[Count - 1];
        }
    }
}