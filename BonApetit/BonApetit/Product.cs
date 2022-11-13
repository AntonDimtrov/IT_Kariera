using System;
using System.Collections.Generic;
using System.Text;

namespace BonApetit
{
    class Product
    {
        private string name;
        private double price;
        private int weight;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3) throw new ArgumentException("Product needs a name of atleast 3 ");
                name = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0.01) throw new ArgumentException("Product price needs to be atleast 0.01");
                price = value;
            }
        }
        public int Weight
        {
            get { return weight; }
            set
            {
                if (value <=0) throw new ArgumentException("Product weigth needs to be a positive number");
                weight = value;
            }
        }

        public Product(string name, double price, int weight)
        {
            this.Name = name;
            this.Price = price;
            this.Weight = weight;
        }


        public static Product GetCheapestProduct(Dictionary<string, Product> products)
        {
            double x = 0;
            string cheapestProduct = "";
            foreach (var pair in products)
            {
                if (pair.Value.price > x)
                {
                    x = pair.Value.price;
                    cheapestProduct = pair.Value.name;
                }
            }
            return products[cheapestProduct];
        }


        public override string ToString()
        {
            return $"{this.name} - {this.weight}";
        }
    }
}
