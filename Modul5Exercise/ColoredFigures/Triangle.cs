using System;
using System.Collections.Generic;
using System.Text;

namespace ColoredFigures
{
    class Triangle : ColoredFigure
    {
        public Triangle(int size, string color) : base(size, color)
        {
            Area=Math.Round(((size*size*Math.Sqrt(3))/4), 2);
            Name = "Triangle";
        }

    }
}
