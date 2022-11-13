using System;

namespace RationalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber rn = new RationalNumber(25, 35);
            rn.Rationalize();
            Console.WriteLine();
        }
    }
}
