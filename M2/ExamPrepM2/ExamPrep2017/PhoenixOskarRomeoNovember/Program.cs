using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoenixOskarRomeoNovember
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "Blaze it!")
            {
                string[] inpArgs = input.Split(" -> ");
                string creature = inpArgs[0];
                string squadCreature = inpArgs[1];
                if (creature != squadCreature)
                {

                    if (!dict.ContainsKey(creature)) { dict.Add(creature, new List<string>()); }
                    if (!dict[creature].Contains(squadCreature)) dict[creature].Add(squadCreature);
                }
                input = Console.ReadLine();
            }
            var trimmedDict = TrimDuplicates(dict);
            SortAndPrintDict(trimmedDict);
        }
        private static Dictionary<string, List<string>> TrimDuplicates(Dictionary<string, List<string>> dict)
        {
            Dictionary<string, List<string>> trimmedDict = new Dictionary<string, List<string>>();
            foreach (string key in dict.Keys)
            {
                List<string> squadMates = new List<string>();
                foreach (string mate in dict[key])
                {
                    if (dict.ContainsKey(mate))
                    {
                        if (dict[mate].Contains(key))
                        {
                            continue;
                        }
                    }
                    squadMates.Add(mate);
                }
                trimmedDict.Add(key, squadMates);
            }
            return trimmedDict;
        }
        private static void SortAndPrintDict(Dictionary<string, List<string>> dict)
        {
            foreach (var item in dict.OrderByDescending(key => key.Value.Count()))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count()}");
            }
        }
    }
}
