using System;

namespace zadacha5
{
    class Program
    {
        static void Main(string[] args) 
        {
            int n = int.Parse(Console.ReadLine()); 
            for (int i = 0; i <= 9999; i++)
            {
                if (i / 1000 + i % 10 == n) 
                {
                    if (((i % 1000) / 100) % 2 == 1) 
                    {
                        if(  (((i%100)/10)==4) || (((i % 100) / 10) ==7))
                        {
                            Console.Write($"{i:D4} ");
                        }
                    }
                }
            }
        }
    }
}
