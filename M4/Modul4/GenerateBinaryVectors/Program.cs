using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            GenVector(vector, 0);
            Console.WriteLine(count);
        }
        private static void GenVector(int[] vector, int index)
        {
            if (index >= vector.Length)
            {
                PrintVector(vector);
                count++;
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i;
                    GenVector(vector, index + 1);
                }
            }
        }
        private static void PrintVector(int[] vector)
        {
            Console.WriteLine(string.Join(String.Empty, vector));
        }
    }
}
