using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsSkeleton
{
    class Deque<T>
    {
        private T[] frontBuffer = new T[16];
        private T[] backBuffer = new T[16];

        public int BackCount { get; private set; }
        public int FrontCount { get; private set; }
        public int Count
        {
            get
            {
                return BackCount + FrontCount;
            }
        }

        public void AddBack(T item)
        {
            if (BackCount == backBuffer.Length)
                GrowBack();
            backBuffer[BackCount] = item;
            BackCount++;
        }

        private void GrowBack()
        {
            Array.Resize(ref backBuffer, backBuffer.Length * 2);
        }



        public void AddFront(T item)
        {
            if (FrontCount == frontBuffer.Length)
                GrowFront();
            frontBuffer[FrontCount] = item;
            FrontCount++;
        }
        private void GrowFront()
        {
            Array.Resize(ref frontBuffer, frontBuffer.Length * 2);
        }

        public T GetFront()
        {
            if (FrontCount == 0) return default(T);
            return frontBuffer[FrontCount - 1];
        }

        public T GetBack()
        {
            if (BackCount == 0) return default(T);
           return backBuffer[BackCount-1];
        }

        public T RemoveBack()
        {
            if (BackCount == 0)
            {
                throw new InvalidOperationException("The Deque is empty");
            } ;
            T item = backBuffer[BackCount - 1];
            BackCount--;
            return item;
        }

        public T RemoveFront()
        {
            if (FrontCount == 0)
            {
                throw new InvalidOperationException("The Deque is empty");
            }
            T item = frontBuffer[FrontCount - 1];
            FrontCount--;
            return item;
        }
    }
}
