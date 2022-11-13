using System;
using System.Collections.Generic;
using System.Linq;

namespace FitnessVisitors_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> visitors = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] inpArgs = input.Split(' ');
                switch (input)
                {
                    case "Add visitor":

                        visitors.Add(Console.ReadLine());
                        break;

                    case "Add visitor on position":

                        string visitor = Console.ReadLine();
                        int position = int.Parse(Console.ReadLine());
                        try
                        {
                            visitors.Insert(position, visitor);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        break;

                    case "Remove visitor on position":

                        int pos = int.Parse(Console.ReadLine()) - 1;
                        if (visitors.Count > 0 && visitors.Count > pos) visitors.RemoveAt(pos);
                        break;

                    case "Remove first visitor":

                        if (visitors.Count > 0) visitors.RemoveAt(0);
                        
                            break;

                    case "Remove last visitor":

                        if (visitors.Count > 0) visitors.RemoveAt(visitors.Count - 1); break;

                }
               
                input = Console.ReadLine();
            }
            
            Console.WriteLine(string.Join(", ", visitors));
        }
    }
}
