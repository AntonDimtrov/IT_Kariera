using System;
using System.Collections.Generic;
using System.Linq;

namespace RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> customers = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();
            while (input != "I believe I can fly!")
            {
                string[] inpArgs = input.Split(' ');
                string customerName = inpArgs[0];
                
                if (inpArgs[1] == "=")
                {   
                    customers[customerName] = customers[inpArgs[2]].ToList();
                }
                else
                {
                    if (!customers.ContainsKey(customerName))
                    {
                        customers.Add(customerName, new List<int>());
                    }
                    for(int i = 1; i < inpArgs.Length; i++)
                    {
                        customers[customerName].Add(int.Parse(inpArgs[i]));
                    }
                    
                }
                input = Console.ReadLine();
            }
            customers = customers.OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key).ToDictionary(pair => pair.Key,pair=>pair.Value);
            foreach(var pair in customers)
            {
                 
                Console.WriteLine($"#{pair.Key} ::: {string.Join(", ", pair.Value.OrderBy(x => x))}");
            }
            
        }
    }
}
