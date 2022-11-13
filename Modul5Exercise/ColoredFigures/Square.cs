using System;
using System.Collections.Generic;
using System.Text;

namespace ColoredFigures
{
    class Square : ColoredFigure
    {
        public Square(int size, string color) : base(size, color)
        {
            Name = "Square";
            Area = Size * Size;
        }             
    }
}
