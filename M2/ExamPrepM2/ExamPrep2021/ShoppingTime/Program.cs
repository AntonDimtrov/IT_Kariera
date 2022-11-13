using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingTime_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> shoppingList = new Dictionary<string, double>();
            string input = Console.ReadLine();
            while (input != "Stop shopping")
            {
                string[] inpArgs = input.Split('-');
                string productName = inpArgs[0];
                double price = double.Parse(inpArgs[1]);
                if (!shoppingList.ContainsKey(productName))
                {
                    shoppingList.Add(productName, 0.00);
                }
                shoppingList[productName] += price;

                input = Console.ReadLine();
            }
            shoppingList = shoppingList.OrderBy(x => x.Value).ToDictionary(pair=>pair.Key,pair=>pair.Value);
            double sum = 0;
            foreach(var product in shoppingList)
            {
                Console.WriteLine($"{product.Key} -> {product.Value:f2}");
                sum += product.Value;
            }
            Console.WriteLine($"Total sum: {sum:f2}");
        }
    }
}
