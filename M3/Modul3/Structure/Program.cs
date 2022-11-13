using System;
using System.Collections.Generic;
using System.Linq;

namespace Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Driver> drivers = new Dictionary<string, Driver>();
            int laps = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string command = input.Split(' ')[0];
            while (command != "CompleteLaps")
            {
                List<string> commandArgs = input.Split(" ").ToList();
                commandArgs.RemoveAt(0);
                switch (command)
                {
                    case "RegisterDriver": RegisterDriver(commandArgs); break;
                    case "Box": DriverBoxes(commandArgs); break;
                    case "CompleteLaps": CompleteLaps(commandArgs); break;
                    case "LeaderBoard": GetLeaderboard(); break;
                    case "ChangeWeather": ChangeWeather(commandArgs); break;

                }
                input = Console.ReadLine();
                command = input.Split(' ')[0];
            }


        }
        public static void SetTrackInfo(int lapsNumber, int trackLength)
        {
            //TODO: Add some logic here …
        }
        public static void RegisterDriver(List<string> commandArgs)
        {
            string type = commandArgs[0];
            string name = commandArgs[1];
            int hp = int.Parse(commandArgs[2]);
            double fuelAmount = double.Parse(commandArgs[3]);
            string tyreType = commandArgs[4];
            string tyreHardness = commandArgs[5];
            if (tyreType == "UltraSoft" && commandArgs.Count == 7)
            {
                string grip = commandArgs[6];
            }
            Driver driver=new Driver(type, name, 0, new car, )
        }

        public static void DriverBoxes(List<string> commandArgs)
        {
            //TODO: Add some logic here …
        }

        public static string CompleteLaps(List<string> commandArgs)
        {
            //TODO: Add some logic here …
        }

        public static string GetLeaderboard()
        {
            //TODO: Add some logic here …
        }

        public static void ChangeWeather(List<string> commandArgs)
        {
            //TODO: Add some logic here …
        }



    }
}
