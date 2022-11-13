using System;
using System.Collections.Generic;
using System.Linq;

namespace ColoredFigures
{
    class Program
    {
        static List<ColoredFigure> figures = new List<ColoredFigure>();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string color = input[1];
                int size = int.Parse(input[2]);
                ColoredFigure figure;
                switch (input[0])
                {
                    case "Triangle":
                        figure = new Triangle(size, color);
                        break;
                    case "Circle":
                        figure = new Circle(size, color);
                        break;
                    case "Square":
                        figure = new Square(size, color);
                        break;
                    default: throw new ArgumentException("Unknown Figure!");
                }
                figures.Add(figure);
            }
            foreach(ColoredFigure f in figures)
            {
                f.Show();
            }
        }       
    }
}
