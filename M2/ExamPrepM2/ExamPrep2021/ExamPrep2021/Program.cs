using System;
using System.Linq;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] robg = new int[4];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "red": robg[0]++; break;
                    case "orange": robg[1]++; break;
                    case "blue": robg[2]++; break;
                    case "green": robg[3]++; break;
                    default: break;
                }
            }
            int maxNum = robg.Max();
            int maxIndex = Array.IndexOf(robg, maxNum);
            string maxColor = maxIndex == 0 ? "red" : (maxIndex == 1 ? "orange" : (maxIndex == 2 ? "blue" : "green"));
            Console.WriteLine(
                $"Red eggs: {robg[0]}\n" +
                $"Orange eggs: {robg[1]}\n" +
                $"Blue eggs: {robg[2]}\n" +
                $"Green eggs: {robg[3]}");

            Console.WriteLine($"Max eggs: {maxNum} -> {maxColor}");
        }
    }
}
