using System;

namespace ExamPrep2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {   
                ulong totalLength = ulong.Parse(Console.ReadLine());
                double totalWidth = double.Parse(Console.ReadLine());
                ulong wingLength = ulong.Parse(Console.ReadLine());

                decimal totalYears = (decimal) (totalLength * totalLength * (totalWidth + 2 * wingLength));
                Console.WriteLine(totalYears);
            }
        }
    }
}
