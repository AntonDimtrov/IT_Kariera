using System;

namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n= int.Parse(Console.ReadLine());
            double light = 0, moderate = 0, strong = 0, veryStrong = 0;
            for (int i = 0; i < n; i++)
            {
                double strength = double.Parse(Console.ReadLine());
                if (strength <= 4)
                {
                    light += 1;
                }
                else if(strength<=6){
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
            Console.WriteLine($"Light: {light/n*100:f2}%");
            Console.WriteLine($"Moderate: {moderate / n*100:f2}%");
            Console.WriteLine($"Strong: {strong / n*100:f2}%");
            Console.WriteLine($"Very Strong: {veryStrong / n*100:f2}%");
        }
    }
}
