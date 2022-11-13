using System;
using System.Collections.Generic;
using System.Text;

namespace ColoredFigures
{
    abstract class ColoredFigure
    {
        private string name;
        private double size;
        private string color;
        private double area;


        public ColoredFigure(double size, string color)
        {
            Size = size;
            Color = color;
        }

        public double Size { get => size; private set => size = value; }
        public string Color { get => color; private set => color = value; }
        public string Name { get => name; protected set => name = value; }
        public double Area { get => area; protected set => area = value; }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Area: {Area}");
        }

    }
}
