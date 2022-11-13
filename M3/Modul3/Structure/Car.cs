using System;
using System.Collections.Generic;
using System.Text;

namespace Structure
{
    class Car
    {
        private int hp;
        private double fuelAmount;
        private Tyre tyre;

        public Car(int hp, double fuelAmount, Tyre tyre)
        {
            this.Hp = hp;
            this.FuelAmount = fuelAmount;
            this.Tyre = tyre;
        }

        public int Hp
        {
            get { return this.hp; }
            set
            {
                if (value > 0) this.hp = value;
                else throw new ArgumentException("HP BELOW 0!");
            }
        }
        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set
            {
                if (value > 160) value = 160;
                else if (value < 0) throw new ArgumentException("FUEL BELOW 0!");
                fuelAmount = value;
            }
        }
        public Tyre Tyre
        {
            get { return this.Tyre; }
            set { this.tyre = value; }
        }
    }
}
