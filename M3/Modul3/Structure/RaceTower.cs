using System;
using System.Collections.Generic;
using System.Text;

namespace GrandPrix
{
    class RaceTower
    {
        public void SetTrackInfo(int lapsNumber, int trackLength)
        {
            //TODO: Add some logic here …
        }
        public void RegisterDriver(List<string> commandArgs)
        {   
            string type = commandArgs[0];
            string name = commandArgs[1];
            int hp = int.Parse(commandArgs[2]);
            double fuelAmount = double.Parse(commandArgs[3]);
            string tyreType = commandArgs[4];
            string tyreHardness = commandArgs[5];
            if (tyreType == "UltraSoft"&&commandArgs.Count==7)
            {
                string grip = commandArgs[6];
            }
            
        }

        void DriverBoxes(List<string> commandArgs)
        {
            //TODO: Add some logic here …
        }

        string CompleteLaps(List<string> commandArgs)
        {
            //TODO: Add some logic here …
        }

        string GetLeaderboard()
        {
            //TODO: Add some logic here …
        }

        void ChangeWeather(List<string> commandArgs)
        {
            //TODO: Add some logic here …
        }

    }
}
