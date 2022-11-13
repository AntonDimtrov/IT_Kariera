using System;

namespace FitnessEquipment_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long sum = 0;
            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine(); //: treadmill, cross trainer, exercise bike, dumbbells
                int price = 0;
                switch (input)
                {
                    case "treadmill":price = 5899;break;
                    case "cross trainer": price = 1699; break;
                    case "exercise bike": price = 1789; break;
                    case "dumbbells": price = 579; break;
                    default:
                        break;
                }
                sum += price;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
