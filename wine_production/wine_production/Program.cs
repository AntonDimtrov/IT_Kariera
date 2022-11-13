using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wine_production
{
    class Program
    {
        static void Main(string[] args)
        {
            double z=0, x=0, y =-1, workers=0;
            

            //X
            while (x < 10 || x > 5000)
            {
                Console.Write("Size of field in m*m(10-5000): ");
                string x_input = Console.ReadLine();
                while (!Double.TryParse(x_input, out x))
                {
                    Console.WriteLine("Inalid Input, Try Again!");
                    Console.Write("Size of field in m*m(10-5000): ");
                    x_input = Console.ReadLine();
                }
                x = double.Parse(x_input);
            }
            //Y
            while (y < 0 || y > 10)
            {
                Console.Write("Liters of wine per m*m(0-10): ");
                string y_input = Console.ReadLine();
                while (!Double.TryParse(y_input, out y))
                {
                    Console.WriteLine("Inalid Input, Try Again!");
                    Console.Write("Liters of wine per m*m(0-10): ");
                    y_input = Console.ReadLine();
                }
                y = double.Parse(y_input);
            }
            //Z
            while (z < 10 || z > 600)
            {
                Console.Write("Needed liters of wine(10-600): ");
                string z_input = Console.ReadLine();
                while (!Double.TryParse(z_input, out z))
                {
                    Console.WriteLine("Inalid Input, Try Again!");
                    Console.Write("Needed liters of wine(10-600): ");
                    z_input = Console.ReadLine();
                }
                z = double.Parse(z_input);
            }
            //WORKERS
            while (workers < 1 || workers > 10)
            {
                Console.Write("Workers(1-10): ");
                string worker_input = Console.ReadLine();
                while (!Double.TryParse(worker_input, out workers))
                {
                    Console.WriteLine("Inalid Input, Try Again!");
                    Console.Write("Workers(1-10): ");
                    worker_input = Console.ReadLine();
                }
                workers = double.Parse(worker_input);
            }
            double produced_wine = 0.4 * x * y / 2.5;
            if (produced_wine >= z)
            {
                if(produced_wine > z)
                {
                    Console.WriteLine("Enough wine is produced.There is some left for the workers(" + Math.Round((produced_wine - z)/workers, 1) + "L) per worker");
                }
                if (produced_wine == z)
                {
                    Console.WriteLine("Enough wine is produced. There  is none left for the workers");
                }
            }
            else
            {
                Console.WriteLine("Not enough wine is produced");
            }
            Console.ReadLine();
            





        }
    }
}
