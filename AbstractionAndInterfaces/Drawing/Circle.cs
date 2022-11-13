using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingFigures
{

    class Circle : IDrawable
    {
        private int radius;

        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get => radius; set => radius = value; }

        public void Draw()
        {
            Console.WriteLine("Drawing Circle...");
        }
    }
}
