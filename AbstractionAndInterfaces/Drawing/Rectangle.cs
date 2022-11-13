using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingFigures
{
    class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        public void Draw()
        {
            DrawLine(Width, '*', '*');
            for(int h = 0; h < Height-2; h++)
            {
                DrawLine(Width, ' ', '*');
            }
            DrawLine(Width, '*', '*');
        }
        private void DrawLine(int width, char middle, char end)
        {
            Console.Write(end);
            for(int i = 0; i < width - 2; i++)
            {
                Console.Write(middle);
            }
            Console.WriteLine(end);
        }
    }
}
