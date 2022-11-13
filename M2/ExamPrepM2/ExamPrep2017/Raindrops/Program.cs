using System;
using System.Linq;

namespace Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                ulong[] input = Console.ReadLine().Split(' ').Select(ulong.Parse).ToArray();
                ulong rdropsCount = input[0];
                ulong squareMeters = input[1];
                sum += (double)rdropsCount / squareMeters;


            }
            sum /= density;
            Console.WriteLine($"{sum:f3}");


        }
    }
}
