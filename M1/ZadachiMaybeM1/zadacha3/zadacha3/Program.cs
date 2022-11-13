using System;

namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
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
    }
}
