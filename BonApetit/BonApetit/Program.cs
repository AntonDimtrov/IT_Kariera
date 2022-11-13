using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace BonApetit
{
    class Program
    {
        public static  Dictionary<string, Product> products = new Dictionary<string, Product>();
        public static Dictionary<string, Meal> meals = new Dictionary<string, Meal>();

        static void Main(string[] args)
        {
            string command = "";
            
            
            while (command != "END")
            {
                command = Console.ReadLine();
                string[] commandArgs = command.Split(" ").Where(x => x != "").ToArray();
                switch (commandArgs[0])
                {
                    case "AddProduct":
                        AddProduct(commandArgs[1], double.Parse(commandArgs[2]), int.Parse(commandArgs[3]));
                        break;

                    case "AddMultiProducts":
                        AddMultiProducts(int.Parse(commandArgs[1]));
                        break;

                    case "PrintProduct":
                        PrintProduct(commandArgs[1]);
                        break;

                    case "AddMeal":
                        AddMeal(commandArgs[1], commandArgs[2]);
                        break;
                    case "AddMealProducts": break;
                    case "PrintMeal": break;
                    default:
                        if(command!="END")Console.WriteLine("Unkown command");
                        break;
                }
            }
        }





        static public void AddProduct(string name, double price, int weight)
        {
            products.Add(name, new Product(name, price, weight));
        }
        static public void AddMultiProducts(int numberOfProducts)
        {
            for (int i = 0; i < numberOfProducts; i++)
            {
                string[] a = Console.ReadLine().Split(" ").Where(x => x != "").ToArray();
                AddProduct(a[0], double.Parse(a[1]), int.Parse(a[2]));
            }
        }
        public static void PrintProduct(string name)
        {   if(products.ContainsKey(name)) Console.WriteLine(products[name]);
            else Console.WriteLine("Product doen't exist");

        }
        public static void AddMeal(string name, string type)
        {
            meals.Add(name, new Meal(name, type));
        }
        public static void AddMealProducts(string name, string type, int numberOfProducts)
        {   string[] x = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();
            if (x.Length > numberOfProducts)
            {
                Console.WriteLine("Error! Too many products!");
            }
            else if (x.Length < numberOfProducts)
            {
                Console.WriteLine("Error! Not enough products!");
            }
            else { meals.Add(name, new Meal(name, type, new List<Product> { products[x[0]], products[x[1]], products[x[2]] })); }
            
        }
        public void PrintMeal(string name)
        {
            Console.WriteLine(meals[name]);
        }
    }
}
