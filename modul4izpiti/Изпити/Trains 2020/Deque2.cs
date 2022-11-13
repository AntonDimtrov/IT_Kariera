using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainsSkeleton
{
    public class Deque<T>
    {
        private const int defaultCapacity = 100;

        private Stack<T> front = new Stack<T>();
        private Stack<T> back = new Stack<T>();

        public Deque()
            : this(defaultCapacity)
        {
        }

        public Deque(int capacity)
        {
            this.Capacity = defaultCapacity;
        }
        public Deque(IEnumerable<T> collection) : this(collection.Count())
        {

            //създава дека с капацитет съответстващ на посочената колекция и прехвърля елементите от колекцията в дека

        }
        public int Capacity { get; set; } //показва капацитета
        public int Count
        {
            get
            {
                return front.Count + back.Count;
            }
        }

        //показва броят елементи

        public void AddFront(T item)
        {
            //добавя елемент отпред
            front.Push(item);
        }

        public void AddBack(T item)
        {
            //добавя елемент отзад
            back.Push(item);
        }

        public T RemoveFront()
        {
            //връща и премахва елемента отпред
            if (front.Count == 0)
            {
                return default(T);
            }

            return front.Pop();
        }

        public T RemoveBack()
        {
            //връща и премахва елемента отзад
            if (back.Count == 0)
            {
                return default(T);
            }

            return back.Pop();
        }

        public T GetFront()
        {
            //връща, без да премахва, елемента отпред
            if (front.Count == 0)
            {
                return default(T);
            }

            return front.Peek();
        }

        public T GetBack()
        {
            //връща, без да премахва, елемента отзад
            if (back.Count == 0)
            {
                return default(T);
            }

            return back.Peek();
        }

    }
}