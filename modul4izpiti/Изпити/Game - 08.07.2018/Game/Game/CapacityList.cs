using System;

namespace Game
{
    class CapacityList
    {
        private const int InitialCapacity = 2;
        private Pair[] items;
        private int startIndex = 0; 
        private int nextIndex = 0; 

        public CapacityList(int capacity = InitialCapacity)
        {
            this.items = new Pair[capacity];
        }

        public int Count { get; private set; }

        public Pair SumIntervalPairs()
        {   //TODO: сумирайте двойките от startIndex до nextIndex
            Pair result = new Pair(0, 0);
            for (int i = startIndex; i < nextIndex; i++)
            {
                result.First = result.First + items[i].First;
                result.Last = result.Last + items[i].Last;
            }
            return result;
        }

        public Pair Sum()
        {   //TODO: сумирайте двойките от 0 до this.Count – всички двойки, които имат право да участват в класирането
            Pair result = new Pair(0, 0);
            for (int i = 0; i < this.Count; i++)
            {
                result.First = result.First + this.items[i].First;
                result.Last = result.Last + this.items[i].Last;
            }
            return result;
        }

        public void Add(Pair item)
        {   //TODO: Добавяне на двойката     
            if (nextIndex == items.Length)
            {
                items[startIndex] = SumIntervalPairs();
                startIndex++;
                nextIndex = startIndex;
                Count++;
            }
            items[nextIndex] = item;
            nextIndex++;
        }

        public void PrintCurrentState()
        {   //TODO: отпечатайте всички двойки от 0 до nextIndex
            for(int i = 0; i < nextIndex; i++)
            {
                Console.WriteLine(items[i].ToString());
            }
        }
    }
}
