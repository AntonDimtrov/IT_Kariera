using System;
using System.Collections.Generic;
using System.Text;

namespace Modul3_test_carshop
{
    class Car
    {
        private int number;
        private double price;

        public Car(int number, double price)
        {
            this.Number = number;
            this.Price = price;
        }

        public int Number { get => number; set => number = value; }
        public double Price
        {
            get => price;
            set
            {
                if (value < 1000)
                {
                    Console.WriteLine("Invalid car price!");
                }
                else { price = value; }
            }
        }

        public override string ToString()
        {
            return $"Car number{this.number} costs { this.price}";
        }
    }
}
