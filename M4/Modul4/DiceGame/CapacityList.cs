using System;

namespace ASDExam
{
    class CapacityList
    {
        private const int InitialCapacity = 2;
        private Pair[] items;

        private int startIndex = 0; //index from where sum begins
        private int nextIndex = 0; //index of first free spot

        public CapacityList(int capacity = InitialCapacity)
        {
            this.items = new Pair[capacity];
        }

        public int Count
        {
            get;
            private set;
        }

        public Pair SumIntervalPairs()
        {
            //Sum of dicePairs
            int first = 0, last = 0;
            for (int i = startIndex; i < nextIndex; i++)
            {
                first += items[i].First;
                last += items[i].Last;
            }
            return new Pair(first, last);
        }

        public Pair Sum()
        {
            //sum of all sumPairs
            int first = 0, last = 0;
            for (int i = 0; i < this.startIndex; i++)
            {
                first += items[i].First;
                last += items[i].Last;
            }
            return new Pair(first, last);
        }

        public void Add(Pair item)
        {
            
            //TODO: Добавяне на двойката
            if (this.Count == this.items.Length)
            {
                items[startIndex] = SumIntervalPairs();
                startIndex++;
                nextIndex = startIndex;
                Clear(startIndex);
                this.Count = startIndex;
            }

            if (this.Count != this.items.Length)
            {
                this.items[this.Count] = item;
                nextIndex++;
                Count++;
            }


        }
        private void Clear(int startIndex = 0)
        {   
            //clears the given spaces
            for (int i = startIndex; i < this.items.Length; i++)
            {
                items[i] = null;
            }
        }

        public void PrintCurrentState()
        {
            //Print all pairs
            for(int i = 0; i < nextIndex; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }

}