using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_validation_exercises
{
    class Cargo
    {
        private string name;
        private int weigth;

        public Cargo(string name, int weigth)
        {
            Name = name;
            Weigth = weigth;
        }

        public string Name { 
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
        public int Weigth
        {
            get { return this.weigth; }
            set
            {
                if (value.ToString().Length == 0)
                {
                    throw new ArgumentException("Weigth cannot be empty");
                }
                if (value<= 0)
                {
                    throw new ArgumentException("Weigth must be positive number");

                }
                weigth = value;
            }
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
