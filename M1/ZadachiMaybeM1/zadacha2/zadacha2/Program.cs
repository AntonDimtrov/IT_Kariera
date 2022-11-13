using System;

namespace zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double firstGiftPrice = price;
            double secondGiftPrice = firstGiftPrice * 20 / 100;
            double thirdAndFourthGiftPrice = secondGiftPrice * (70 + 50) / 100;

            double total = firstGiftPrice + secondGiftPrice + thirdAndFourthGiftPrice;
            if (budget >= total)
            {
                Console.WriteLine($"Yes! {Math.Round(budget - total, 2):f2} leva left.");
            }
            else { Console.WriteLine($"No! {Math.Round(total-budget, 2):f2} leva needed."); }



        }
    }
}
