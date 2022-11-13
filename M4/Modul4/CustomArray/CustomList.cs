using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomList
{
    class CustomList<T> : IEnumerable<T>
    {
        //                                                  PERFECT
        private const int INITIAL_CAPACITY = 2;
        private T[] items;
        public int Count { get; private set; }
        public int Capacity { get; private set; }
        public CustomList(int capacity = INITIAL_CAPACITY)
        {
            this.items = new T[capacity];
            Capacity = capacity;
        }

        public T this[int index]
        {
            get { return Get(index); }
            set { Set(index, value); }
        }
        public void Add(T item)
        {
            if (Count == Capacity)
            {
                DoubleCapacity();
            }
            items[Count] = item;
            Count++;
        }
        public void Remove(int index)
        {
            CheckIfIndexOutOfRange(index);
            items = items.Take(index).Concat(items.Skip(index + 1)).ToArray();
            Count--;
        }
        public T Get(int index)
        {
            CheckIfIndexOutOfRange(index);
            return items[index];
        }
        public void Set(int index, T item)
        {
            CheckIfIndexOutOfRange(index);

            if (items[index].Equals(null)) Count++;
            items[index] = item;
        }
        private void DoubleCapacity()
        {
            Capacity *= 2;
            T[] temp = new T[Capacity];
            for (int i = 0; i < items.Length; i++)
            {
                temp[i] = items[i];
            }
            items = temp;
        }
        private void CheckIfIndexOutOfRange(int index)
        {
            if (index < 0 || index >= items.Length)
            {
                throw new IndexOutOfRangeException();
            }
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
