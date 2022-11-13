using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainStation
{
    public class Deque<T> : IList<T>
    {
        private const int INITIAL_CAPACITY = 16;

        private Stack<T> pTrains;
        private Stack<T> fTrains;
        private Stack<T> history;

        public int Capacity=INITIAL_CAPACITY;
        public int Count = 0;


        public Deque() : this(INITIAL_CAPACITY) { }
        public Deque(int capacity)
        {
            this.pTrains = new Stack<T>(capacity);
            this.pTrains = new Stack<T>(capacity);
            this.pTrains = new Stack<T>(capacity);
            this.Capacity = capacity;
        }
        public Deque(IEnumerable<T> collection) : this(collection.Count())
        {

            foreach(var item in collection)
            {
                if(item is Train)
                {
                    Train train = (Train)Convert.ChangeType(item, typeof(Train));
                    if (train.Type == 'P')
                    {
                        pTrains.Push(item);
                    }
                    else fTrains.Push(item);
                }
            } 

        }

        int ICollection<T>.Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddFront(T item)
        {
            pTrains.Push(item);
            Count++;
        }

        public void AddBack(T item)
        {
            fTrains.Push(item);
            Count++;
        }

        public T RemoveFront()
        {
            Count--;
            this.history.Push(this.pTrains.Peek());
            return pTrains.Pop();
        }

        public T RemoveBack()
        {
            Count--;
            this.history.Push(this.fTrains.Peek());
            return fTrains.Pop();
        }

        public T GetFront()
        {
            return pTrains.Peek();
        }

        public T GetBack()
        {
            return fTrains.Peek();
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
