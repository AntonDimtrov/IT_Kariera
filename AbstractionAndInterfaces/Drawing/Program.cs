using System;

namespace DrawingFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 3);
            r.Draw();
            IDrawable c = new Circle(4);
            c.Draw();
        }
    }
}
