using System;

namespace ComputerRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            int computerPrice = 5899;
            int deskPrice = 1789;
            int chairPrice = 1699;
            long sum = 0;
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "desk":sum += deskPrice;break;
                    case "chair":sum += chairPrice;break;
                    case "computer":sum += computerPrice;break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
