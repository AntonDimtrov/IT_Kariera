using System;
using System.Collections.Generic;
using System.Text;

namespace Modul3_test_carshop
{
    class Store
    {
        private string name;
        private List<Car> listOfCars;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 5) { Console.WriteLine("Invalid Store name"); }
                else { name = value; }
            }
        }
        public Store(string name)
        {
            this.Name = name;
            this.listOfCars = new List<Car>();
        }
        public void AddCar(Car car)
        {
            listOfCars.Add(car);
            Console.WriteLine($"You added a car with number {car.Number} to store {this.name}");
        }
        public bool SellCar(Car car)
        {
            if (listOfCars.Contains(car))
            {
                listOfCars.Remove(car);
                Console.WriteLine($"You sold a car with number {car.Number} from store {this.name}");
                return true;
            }
            Console.WriteLine($"Such car doesn't exist in {this.name}");
            return false;
        }
        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (Car car in listOfCars)
            {
                totalPrice += car.Price;
            }
            return totalPrice;
        }
        public Car GetCarWithHighestPrice()
        {
            
            Car highiestPricedCar = new Car(-1234, 0);
            foreach (Car car in listOfCars)
            {
                if (car.Price > highiestPricedCar.Price)
                {
                    highiestPricedCar.Price = car.Price;
                    highiestPricedCar = car;
                }
            }
            return highiestPricedCar;
        }
        public Car GetCarWithLowestPrice()
        {
            if (listOfCars.Count < 1) { throw new ArgumentException("No cars in store"); }
            double price = 0;
            Car lowestPricedCar = new Car(0, 0);
            foreach (Car car in listOfCars)
            {
                if (car.Price < price)
                {
                    price = car.Price;
                    lowestPricedCar = car;
                }
            }
            return lowestPricedCar;

        }
        public void RenameStore(string newName)
        {
            this.Name = name;
        }
        public void SellAllCars()
        {
            this.listOfCars.Clear();
        }
        public void StoreInfo()
        {
            if (listOfCars.Count < 0)
            {

            }
            else
            {
                Console.WriteLine($"Store {this.name} has {listOfCars.Count} car/s:");
                foreach(Car car in listOfCars)
                {
                    Console.WriteLine(car);
                }

            }
        }
        public override string ToString()
        {
            return $"";
        }
    }
}
