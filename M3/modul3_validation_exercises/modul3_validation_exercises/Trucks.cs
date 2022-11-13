using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_validation_exercises
{
    class Trucks
    {


        private string name;
        private int weigthCapacity;
        private List<Cargo> cargos;

        public Trucks(string name, int weigthCapacity)
        {
            Name = name;
            WeigthCapacity = weigthCapacity;
            this.cargos = new List<Cargo>();
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
                name = value;
            }
        }
        public int WeigthCapacity
        {
            get { return this.weigthCapacity; }
            set
            {
                if (value.ToString().Length == 0)
                {
                    throw new ArgumentException("Weigth cannot be empty");
                }
                if (value <= 0)
                {
                    throw new ArgumentException("Weigth must be positive number");

                }
                weigthCapacity = value;
            }
        }
        public void LoadTruck( Cargo cargo)
        {
            if (this.weigthCapacity >= cargo.Weigth)
            {
                this.weigthCapacity -= cargo.Weigth;
                this.cargos.Add(cargo);
                Console.WriteLine($"{this.name} loaded {cargo.Name}");
            }
            else { Console.WriteLine($"{this.name} can't load {cargo}"); }
        }

        public override string ToString()
        {   if (this.cargos.Count == 0) { return $"{this.name} -> Nothing Loaded"; }
            return $"{this.name} -> {string.Join(",", this.cargos)}";
        }
    }
}
