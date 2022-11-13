using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsSkeleton
{
    class Train
    {
        private int number;
        private string name;
        private string type;
        private int cars;

        public Train(int number, string name, string type, int cars)
        {
            Number = number;
            Name = name;
            Type = type;
            Cars = cars;
        }

        public override string ToString()
        {
            return $"{Number} {Name} {Type} {Cars}";
        }

        public string Type { get; set; }

        public int Cars { get; set; }
        public string Name { get => name; set => name = value; }
        public int Number { get => number; set => number = value; }
    }
}
