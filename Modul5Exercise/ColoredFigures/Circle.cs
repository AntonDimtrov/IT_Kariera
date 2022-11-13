using System;
using System.Collections.Generic;
using System.Text;

namespace ColoredFigures
{
    class Circle : ColoredFigure
    {
        public Circle(int size, string color) : base(size, color)
        {
            Name = "Circle";
            Area = Math.Round(Math.PI * Size * Size, 2);
        }
    }
}
