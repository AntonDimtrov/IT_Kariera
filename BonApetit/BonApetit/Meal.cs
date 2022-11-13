using System;
using System.Collections.Generic;
using System.Text;

namespace BonApetit
{
    class Meal
    {
        private string name;
        private string type;
        private List<Product> products = new List<Product>();
        private int ordered;

        public Meal(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        public Meal(string name, string type, List<Product> products)
        {
            this.Name = name;
            this.Type = type;
            this.Products = products;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3) throw new ArgumentException("Meal needs a name of atleast 3 ");
                name = value;
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                if (value.Length < 1) throw new ArgumentException("Type needs a name of atleast 1 ");
                type = value;
            }
        }
        public int Ordered { get => ordered; set => ordered = value; }
        internal List<Product> Products { get => products; set => products = value; }



        public void AddProduct(Product p)
        {
            //TODO: Добавете вашия код тук …
        }

        public bool ContainsProduct(string name)
        {
            foreach (Product product in products)
            {
                if (product.Name == name) return true;
            }
            return false;
        }

        public void PrintMealRecipe(string name)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine($"{name} RECIPE");
            Console.WriteLine("-------------------------");
            foreach(Product product in this.products)
            {
                Console.WriteLine(product);
            }


        }

        public void Order()
        {
            //TODO: Добавете вашия код тук …
        }

        public override string ToString()
        {
            return $"{this.name} - {this.type} ";
        }

        /*public static Meal GetSpecialty(Dictionary<string, Meal> meals)
        {
            //TODO: Добавете вашия код тук …
        }

        public static Meal RecommendByPrice(double price, Product<string, Meal> meals)
        {
            //TODO: Добавете вашия код тук …
        }

        public static Meal RecommendByPriceAndType(double price, string type, Product<string, Meal> meals)
        {
            //TODO: Добавете вашия код тук …
        }*/


    }
}
