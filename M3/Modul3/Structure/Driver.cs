using System;
using System.Collections.Generic;
using System.Text;

namespace Structure
{
    class Driver
    {
        private string name;
        private double totalTime;
        private Car car;
        private double fuelConsumptionPerKm;
        private double speed;
        private string type;

        public Driver(string type,string name, double totalTime, Car car, double fuelConsumptionPerKm, double speed)
        {
            this.type = type;     
            this.name = name;
            this.totalTime = totalTime;
            this.car = car;
            this.speed = speed;
            GetTypeStats(type);
            //this.speed = (this.car.Hp + this.car.Tyre.Degradation) / this.car.FuelAmount;

        }
        private void GetTypeStats(string type)
        {
            if (type == "Endurance") this.fuelConsumptionPerKm = 1.5;
            else if (type == "Aggressive")
            {
                this.fuelConsumptionPerKm = 2.7;
                speed *= 1.3;
            }
        }


    }
}
