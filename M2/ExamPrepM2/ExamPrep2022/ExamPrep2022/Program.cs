using System;

namespace ComputerRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "desk":sum += 1789;break;
                    case "chair":sum += 1699;break;
                    case "computer":sum += 5899;break;
                    default:break;
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
