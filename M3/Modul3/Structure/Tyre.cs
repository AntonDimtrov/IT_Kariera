using System;
using System.Collections.Generic;
using System.Text;

namespace Structure
{
    class Tyre
    {
        private int name;
        private double hardness;
        private double degradation = 100;
        private string type;
        private double grip = 0;

        public Tyre(int name, double hardness)
        {
            this.Name = name;
            this.Hardness = hardness;
            //
        }
        public Tyre(int name, double hardness, double grip)
        {
            this.Name = name;
            this.Hardness = hardness;
            this.grip = grip;
        }

        public int Name { get => name; set => name = value; }
        public double Hardness { get => hardness; set => hardness = value; }
        private void GetTypeStats(string name)
        {
            if (name == "UltraSoft")
            {

            }
            else if (type == "Aggressive")
            {

            }
        }
        public int Degradation
        {
            get { return this.degradation; }
            set { }

        }
    }
}
