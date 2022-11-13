using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factoriel(5));
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(ArraySum(array));
        }
        public static int ArraySum(int[] array, int index=0)
        {
            if (index == array.Length) return 0;
            return array[index] + ArraySum(array, index+1);
        }
        public static int Factoriel(int n)
        {
            if (n == 0) return 1;
            return n * Factoriel(n - 1);
        }

    }
}
