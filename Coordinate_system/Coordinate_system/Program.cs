using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordinate_system
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.Write("Enter a value for x1:");
            float x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a value for y1:");
            float y1 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Enter a value for x2:");
            float x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a value for y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a value for x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a value for y:");
            double y = Convert.ToDouble(Console.ReadLine());
            string location = "";
            //Border
            if (x == x1 || x == x2 || y == y1 || y == y2)
            {
                location = "Border: ";
                if (y == Math.Min(y1, y2))
                {
                    location += "Bottom ";
                }
                if (y == Math.Max(y1, y2))
                {
                    location += "Top ";
                }
                
                if (x==Math.Min(x1, x2))
                {
                    location += "Left ";
                }
                if (x == Math.Max(x1, x2))
                {
                    location += "Right ";
                }
                Console.WriteLine(location);

            }
            //Inside
            else if( ((x1<x && x<x2 )||(x1>x &&x>x2)) && ((y1>y&&y>y2)||(y1<y&&y<y2)))
            {
                location = "Inside: ";
                
                //Middle
                if (((Math.Max(x1, x2)) - x == x - (Math.Min(x1, x2))) && ((Math.Max(y1, y2)) - y == y - (Math.Min(y1, y2))))
                {
                    location += "Middle";
                }
                //Top
                else if ((Math.Max(y1, y2)) - y < y - (Math.Min(y1, y2)))
                {
                    location += "Top ";
                    if (((Math.Max(x1, x2)) - x == x - (Math.Min(x1, x2))))
                    {
                        location += "Middle";
                    }
                    else if (((Math.Max(x1, x2)) - x < x - (Math.Min(x1, x2)))){
                        location += "Right";
                    }
                    else { 
                        location += "Left";
                    }
                }
                //Bottom
                else /*if ((Math.Max(y1, y2)) - y > y - (Math.Min(y1, y2)))*/
                {
                    location += "Bottom ";
                    if (((Math.Max(x1, x2)) - x == x - (Math.Min(x1, x2))))
                    {
                        location += "Middle";
                    }
                    else if (((Math.Max(x1, x2)) - x < x - (Math.Min(x1, x2))))
                    {
                        location += "Right";
                    }
                    else
                    {
                        location += "Left";
                    }
                }

                

                Console.WriteLine(location);
            }
            //Outside
            else
            {
                location = "Outside";
                Console.WriteLine(location);
            }
            Console.ReadLine();

            








        }
    }
}
