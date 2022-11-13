using System;
using System.Collections.Generic;

namespace FootballSeason_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, int> players = new SortedDictionary<string, int>();
            while(input!="End of season")
            {
                string playerName = input.Split(" - ")[0];
                int goals = int.Parse(input.Split(" - ")[1]);
                if (!players.ContainsKey(playerName)) players.Add(playerName, 0);
                players[playerName] += goals;
                input = Console.ReadLine();
            }
            foreach(var pair in players)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
