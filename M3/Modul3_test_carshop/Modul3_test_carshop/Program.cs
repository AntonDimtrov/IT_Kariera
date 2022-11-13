using System;
using System.Linq;
using System.Collections.Generic;

namespace Modul3_test_carshop
{
    class Program
    {
        static Dictionary<string, Store> stores = new Dictionary<string, Store>();
        static void Main(string[] args)
        {
            string command = "";

            while (command != "STOP")
            {
                command = Console.ReadLine();
                string[] cmdArgs = command.Split(' ').Where(x => x != "").ToArray();
                switch (cmdArgs[0])
                {
                    case "CreateStore":
                        CreateStore(cmdArgs[1]);
                        break;
                    case "StoreInfo":
                        StoreInfo(cmdArgs[1]);
                        break;
                    case "AddCar":
                        AddCar(int.Parse(cmdArgs[1]), double.Parse(cmdArgs[2]), cmdArgs[3]);
                        break;
                    case "SellCar":
                        SellCar(int.Parse(cmdArgs[1]), double.Parse(cmdArgs[2]), cmdArgs[3]);
                        break;
                    case "SellAllCars":
                        SellAllCars(cmdArgs[1]);
                        break;
                    case "RenameStore":
                        RenameStore(cmdArgs[1], cmdArgs[2]);
                        break;
                    case "GetCarWithHighestPrice":

                        break;
                    case "GetCarWithLowesttPrice":
                        GetCarWithHighestPrice(cmdArgs[1]);
                        break;

                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
        }
        public static void GetCarWithHighestPrice(string storeName)
        {
            Console.WriteLine(stores[storeName].GetCarWithHighestPrice()); 
        }
        public static void GetCarWithLowestPric(string storeName)
        {
            Console.WriteLine(stores[storeName].GetCarWithLowestPrice());
        }
        public static void AddCar(int number, double price, string storeName)
        {
            stores[storeName].AddCar(new Car(number, price));
        }
        public static void SellCar(int number, double price, string storeName)
        {
            stores[storeName].SellCar(new Car(number, price));
        }
        public static void SellAllCars(string storeName)
        {
            stores[storeName].SellAllCars();
        }
        public static void CreateStore(string storeName)
        {
            stores.Add(storeName, new Store(storeName));
        }
        public static void RenameStore(string currentName, string newName)
        {
            stores[currentName].RenameStore(newName);
        }
        public static void StoreInfo(string storeName)
        {
            if (stores.ContainsKey(storeName)){ stores[storeName].StoreInfo(); }
            else { Console.WriteLine("Such Store doesn't exist"); }
        }
    }
}
