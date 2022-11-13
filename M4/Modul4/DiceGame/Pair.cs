using System;

namespace ASDExam
{
    class Pair
    {
        public int First { get; set; }
        public int Last { get; set; }

        public Pair(int first, int last)
        {
            First = first;
            Last = last;
        }

        public override string ToString()
        {
            return $"({First}, {Last})";
        }

        public int Difference()
        {
            return (int)Math.Abs(First - Last);
        }
    }

}