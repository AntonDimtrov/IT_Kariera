using System;
using System.Collections.Generic;
using System.Text;

namespace TrainStation
{
    class Train
    {
        private int number;
        private string name;
        private char type;
        private int numberOfCars;

        public Train(int number, string name, char type, int numberOfCars)
        {
            this.Number = number;
            this.Name = name;
            this.type = type;
            this.NumberOfCars = numberOfCars;
        }

        public int Number { get => number; set => number = value; }
        public string Name { get => name; set => name = value; }
        public char Type { get => type; set => type = value; }
        public int NumberOfCars { get => numberOfCars; set => numberOfCars = value; }
        public override string ToString()
        {
            return $"{this.Number} {this.Name} {this.Type} {this.numberOfCars}";
        }
    }
}
