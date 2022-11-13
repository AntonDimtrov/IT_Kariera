using System;
using System.Collections.Generic;
using System.Linq;

namespace Planets_buildings_ships
{
    class Program
    {


        static void Main(string[] args)
        {

            Dictionary<string, Planet> planets = GetPlanetInput();
            Dictionary<string, Building> buildings = GetBuildingInput();
            Dictionary<string, Ship> ships = GetShipInput();
            string input = Console.ReadLine();
            while (input != "END")
            {
                AddBuildingOrShip(input, planets, buildings, ships);                
            }
            PrintPlanetStats(planets);
        }
        static void PrintPlanetStats(Dictionary<string, Planet> planets)
        {
            foreach (KeyValuePair<string, Planet> planet in planets)
            {
                Console.WriteLine(planet.Value);
            }
        }
        static void AddBuildingOrShip(string input, Dictionary<string, Planet> planets, Dictionary<string, Building>buildings, Dictionary<string, Ship> ships)
        {
            if (input.Length > 1)
            {
                string[] commandArgs = input.Split(' ').Where(x => x != "").ToArray();
                int count = 1;
                if (commandArgs.Length == 3)
                {
                    count = int.Parse(commandArgs[2]);
                }
                if (planets.ContainsKey(commandArgs[0]))
                {
                    if (buildings.ContainsKey(commandArgs[1]))
                    {
                        planets[commandArgs[0]].AddBuilding(buildings[commandArgs[1]], count);
                    }
                    else if (ships.ContainsKey(commandArgs[1]))
                    {
                        planets[commandArgs[0]].AddShip(ships[commandArgs[1]], count);
                    }
                    else
                    {
                        Console.WriteLine("No such ship/building exists");
                    }
                }
                else { Console.WriteLine("No such planet exists"); }
            }
            else { Console.WriteLine("error"); }

            input = Console.ReadLine();
            
        }
        static Dictionary<string, Ship> GetShipInput()
        {
            string[] userInput = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();
            Dictionary<string, Ship> ships = new Dictionary<string, Ship>();

            while (userInput.Length >= 1)
            {
                if (userInput.Length % 3 != 0) throw new ArgumentException("Invalid User Input(building)");
                ships.Add(userInput[0], new Ship(userInput[0], int.Parse(userInput[1]), int.Parse(userInput[2])));
                userInput = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();
            }
            return ships;
        }
        static Dictionary<string, Building> GetBuildingInput()
        {
            string[] userInput = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();
            Dictionary<string, Building> buildings = new Dictionary<string, Building>();

            while (userInput.Length >= 1)
            {
                if (userInput.Length % 3 != 0) throw new ArgumentException("Invalid User Input(building)");
                buildings.Add(userInput[0], new Building(userInput[0], int.Parse(userInput[1]), int.Parse(userInput[2])));
                userInput = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();
            }
            return buildings;
        }


        static Dictionary<string, Planet> GetPlanetInput()
        {
            string[] userInput = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();
            Dictionary<string, Planet> planets = new Dictionary<string, Planet>();
            if (userInput.Length % 3 != 0) throw new ArgumentException("Invalid User Input(1)");
            for (int i = 0; i+2<=userInput.Length-1; i += 3)
            {
                planets.Add(userInput[i], new Planet(userInput[i], int.Parse(userInput[i + 1]), int.Parse(userInput[i + 2])));
            }
            return planets;

        }
    }
}

