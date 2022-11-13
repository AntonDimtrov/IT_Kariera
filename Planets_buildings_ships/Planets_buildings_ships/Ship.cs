using System;
using System.Collections.Generic;
using System.Text;

namespace Planets_buildings_ships
{
    class Ship
    {
        private string name;
        private int metalsRequired;
        private int mineralsRequired;

        public Ship(string name, int metalsRequired, int mineralsRequired)
        {
            Name = name;
            MetalsRequired = metalsRequired;
            MineralsRequired = mineralsRequired;
            //Console.WriteLine($"Ship Type Added!");
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                else
                {
                    this.name = value;
                }


            }
        }
        public int MetalsRequired
        {
            get { return this.metalsRequired; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Metals cannot be negative");
                }
                else
                {
                    this.metalsRequired = value;
                }


            }
        }
        public int MineralsRequired
        {
            get { return this.mineralsRequired; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Minerals cannot be negative");
                }
                else
                {
                    this.mineralsRequired = value;
                }
            }
        }
        public override string ToString()
        {
            return this.name;
            
        }
    }
}
