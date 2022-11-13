using System;
using System.Collections.Generic;

namespace PassStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, int> players = new SortedDictionary<string, int>();
            while (input != "End of match")
            {
                string playerName = input.Split(" - ")[0];
                int passes = int.Parse(input.Split(" - ")[1]);
                if (!players.ContainsKey(playerName)) players.Add(playerName, 0);
                players[playerName] += passes;
                input = Console.ReadLine();
            }
            foreach (var pair in players)
            {
                Console.WriteLine($"{pair.Key} has passed {pair.Value} passes.");
            }
        }
    }
}
