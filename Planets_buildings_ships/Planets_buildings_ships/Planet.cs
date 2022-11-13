using System;
using System.Collections.Generic;
using System.Text;

namespace Planets_buildings_ships
{
    class Planet
    {
        private string name;
        private int metals;
        private int minerals;
        private List<Building> buildings;
        private List<Ship> ships;

        public Planet(string name, int metals, int minerals)
        {
            Name = name;
            Metals = metals;
            Minerals = minerals;
            this.buildings = new List<Building>();
            this.ships = new List<Ship>();
        }
        public List<Ship> Ships
        {
            get { return this.ships; }
        }
        public List< Building> Buildings
        {
            get { return this.buildings; }
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length >= 1) { name = value; }
                else { throw new ArgumentException("Name cannot be empty"); }

            }
        }
        public int Metals
        {
            get { return this.metals; }
            set
            {
                if (value >= 0) { metals = value; }
                else { throw new ArgumentException("Metals cannot be less than 0"); }

            }
        }
        public int Minerals
        {
            get { return this.minerals; }
            set
            {
                if (value >= 0) { minerals = value; }
                else { throw new ArgumentException("Minerals cannot be less than 0"); }

            }
        }
        public void AddBuilding(Building building, int count)
        {   //if have enough recources

            for (int i = 0; i < count; i++)
            {
                if (this.metals >= building.MetalsRequired && this.minerals >= building.MineralsRequired)
                {
                    this.buildings.Add( building);
                    this.metals -= building.MetalsRequired;
                    this.minerals -= building.MineralsRequired;
                    Console.WriteLine("Added Building!");
                }
                else
                {
                    Console.WriteLine("Not Enough Recources for Building");
                    break;
                }
            }

        }
        public void AddShip(Ship ship , int count)
        {   
            for (int i = 0; i < count; i++)
            {
                if (this.metals >= ship.MetalsRequired && this.minerals >= ship.MineralsRequired)
                {
                    this.ships.Add(ship);
                    this.metals -= ship.MetalsRequired;
                    this.minerals -= ship.MineralsRequired;
                    Console.WriteLine("Added Ship!");
                }
                else
                {
                    Console.WriteLine("Not Enough Recources for Ship");
                    break;
                }
            }

        }

        public override string ToString()
        {   
            string a = "No buildings";
            string b = "No ships";
            if (this.buildings.Count > 0)   {a = string.Join(" ", this.buildings);}
            if (this.ships.Count > 0)   { b = string.Join(" ", this.ships); }
            
            return $"{this.name}: {this.metals} , {this.minerals}\nBuildings: {a}\nShips: {b}\n";
        }
    }
}
