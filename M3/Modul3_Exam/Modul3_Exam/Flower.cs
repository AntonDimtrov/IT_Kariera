using System;
using System.Collections.Generic;
using System.Text;

namespace RegularExam
{
    class Flower
    {
        private string type;
        private string color;
        private double price;

        public Flower(string type, string color, double price)
        {
            this.Type = type;
            this.Color = color;
            this.Price = price;
        }

        public string Type
        {
            get { return this.type; }
            set { type = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { color = value; }
        }
        public double Price
        {
            get { return this.price; }
            set
            {
                if (value > 100) throw new ArgumentException("Invalid flower price!");
                else { price = value; }
            }
        }

        public override string ToString()
        {
            return $"Flower {Type} with color {Color} costs {Price:F2}";
        }
    }
}
