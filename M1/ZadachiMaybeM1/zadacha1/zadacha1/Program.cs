using System;

namespace Modul1
{
    class Program
    {
        static void Main(string[] args) { }
        private static void Zadacha1()
        {
            //zadacha 1
            double priceLaminate = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double pricePad = double.Parse(Console.ReadLine());

            double area = width * length;
            double totalPrice = Math.Round(area * (priceLaminate + pricePad) * 1.4, 2);
            Console.WriteLine($"{totalPrice:f2}");
        }
        private static void Zadacha2()
        {
            //zadacha2

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
            else { Console.WriteLine($"No! {Math.Round(total - budget, 2):f2} leva needed."); }
        }
        private static void Zadacha3()
        {
            //zadacha 3

            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            int numberOfCams = int.Parse(Console.ReadLine());
            string companyName = Console.ReadLine();
            int camPrice = 0;

            double area = width * length;
            switch (companyName)
            {
                case "Dogramichka4You":
                    if (numberOfCams == 3) { camPrice = 12; }
                    else if (numberOfCams == 4) { camPrice = 15; }
                    else if (numberOfCams == 5) { camPrice = 20; }
                    break;

                case "ChukChuk":
                    if (numberOfCams == 3) { camPrice = 14; }
                    else if (numberOfCams == 4) { camPrice = 20; }
                    else if (numberOfCams == 5) { camPrice = 22; }
                    break;

                case "TihoToplo":
                    if (numberOfCams == 3) { camPrice = 15; }
                    else if (numberOfCams == 4) { camPrice = 14; }
                    else if (numberOfCams == 5) { camPrice = 18; }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Goshko has to spend {Math.Round(area * camPrice, 2):f2} leva.");
        }
        private static void Zadacha4()
        {
            //zadacha4

            int n = int.Parse(Console.ReadLine());
            double light = 0, moderate = 0, strong = 0, veryStrong = 0;
            for (int i = 0; i < n; i++)
            {
                double strength = double.Parse(Console.ReadLine());
                if (strength <= 4)
                {
                    light += 1;
                }
                else if (strength <= 6)
                {
                    moderate += 1;
                }
                else if (strength <= 7)
                {
                    strong += 1;
                }
                else if (strength > 7)
                {
                    veryStrong += 1;
                }
            }
            Console.WriteLine($"Light: {light / n * 100:f2}%");
            Console.WriteLine($"Moderate: {moderate / n * 100:f2}%");
            Console.WriteLine($"Strong: {strong / n * 100:f2}%");
            Console.WriteLine($"Very Strong: {veryStrong / n * 100:f2}%");
        }
        private static void Zadacha5()
        { 
            //zadacha 5

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 9999; i++)
            {
                if (i / 1000 + i % 10 == n)
                {
                    if (((i % 1000) / 100) % 2 == 1)
                    {
                        if ((((i % 100) / 10) == 4) || (((i % 100) / 10) == 7))
                        {
                            Console.Write($"{i:D4} ");
                        }
                    }
                }
            }
        }
    }
}
