using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_price_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Distance: ");
            string distance_input = Console.ReadLine();
            double distance = 0;
            double price = 0;
            string vehicle = "";
            string day_or_night = "";
            double day_price = 0.79;
            double night_price = 0.90;
            while(!Double.TryParse(distance_input, out distance)){
                Console.WriteLine("Inalid Input, Try Again!");
                Console.Write("Distance: ");
                 distance_input = Console.ReadLine();
            }
            distance = Double.Parse(distance_input);
            //TAXI
            if (distance < 20)
            {
                vehicle = "Taxi";
                Console.WriteLine("When are you traveling? Day or Night");
                day_or_night = Console.ReadLine();
                while (day_or_night.ToLower() != "day" && day_or_night.ToLower() != "night")
                {
                    Console.WriteLine("Inalid Input, Try Again!");
                    Console.WriteLine("When are you traveling? Day or Night");
                    day_or_night = Console.ReadLine();

                }
                if (day_or_night.ToLower() == "day")
                {
                    price = 0.70 + distance * day_price;
                }
                else
                {
                    price = 0.70 + distance * night_price;
                }
                
            }
            //BUS
            else if (distance >= 20 && distance < 100)
            {
                vehicle = "Bus";
                price = distance * 0.09;

            }
            else if (distance >= 100)
            {
                vehicle = "Tarin";
                price = distance * 0.06;

            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("Distance: " + distance);
            Console.WriteLine("Vehicle: "+vehicle);
            Console.WriteLine("Price:" +Math.Round(price, 2));
            Console.ReadLine();
        }
    }
}
