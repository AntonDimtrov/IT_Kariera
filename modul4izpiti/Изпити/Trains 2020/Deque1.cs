using System;
using System.Collections.Generic;
using System.Text;

namespace TrainsSkeleton
{
    class Deque<T>
    {
        private Stack<Train> stack;

        public Stack<Train> Stack
        {
            get { return stack; }
            set { stack = value; }
        }
        public int Count; //показва броят елементи
        public Deque()
        {
            this.Stack = new Stack<Train>();
        }
        private Train head;
        private Train tail;

        public void AddFront(int number, string name, string type, int cars)
        {
            Train newNode = new Train(number, name, type, cars);
            if (Count == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
            Count++;
        }
        public void AddBack(int number, string name, string type, int cars)
        {
            Train newNode = new Train(number, name, type, cars);
            if (Count == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
            Count++;
        }

        public Train RemoveFront()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            Train item = head;
            head = head.Next;
            Stack.Push(item);
            if (head == null) tail = null;
            Count--;
            return item;
        }

        public Train RemoveBack()
        {
            Train item = tail;
            stack.Push(item);
            if (Count == 1)
            {
                head = null;
                tail = null;
            }
            else
            {
                Train parent = head;
                while (parent.Next != tail)
                    parent = parent.Next;
                parent.Next = null;
                tail = parent;
                
            }
            Count--;
            return item;
        }

        public Train GetFront()
        {
            return head;
        }

        public Train GetBack()
        {
            return tail;
        }
        public void Traveled()
        {
            foreach(var item in Stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}


