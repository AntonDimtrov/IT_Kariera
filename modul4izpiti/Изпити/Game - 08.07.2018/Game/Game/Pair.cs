using System;

namespace Game
{
    class Pair
    {
        public int First { get; set; }
        public int Last { get; set; }

        public Pair(int first, int secondLast)
        {
            First = first;
            Last = secondLast;
        }
        public override string ToString()
        {
            return $"({First}, {Last})";
        }

        public int Difference()
        {
            return Math.Abs(this.First - this.Last);
        }
    }
}
