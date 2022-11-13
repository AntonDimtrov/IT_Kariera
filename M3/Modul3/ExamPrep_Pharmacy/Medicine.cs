using System;
using System.Collections.Generic;
using System.Text;

namespace ExamPrep_Pharmacy
{
    class Medicine
    {
        private string name;
        private double price;

        public Medicine(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            set { name = value; }
        }
        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0) Console.WriteLine("Invalid price");
                else price = value;
            }
        }
        public override string ToString()
        {
            return $"Medicine: {name} with price {price:f2}";
        }

    }
}
