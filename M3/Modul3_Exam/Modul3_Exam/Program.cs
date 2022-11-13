using System;
using System.Collections.Generic;

namespace RegularExam
{
    class Program
    {
        static Dictionary<string, FlowerStore> stores = new Dictionary<string, FlowerStore>();
        static Dictionary<int, Flower> flowers = new Dictionary<int, Flower>();
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "STOP")
            {
                string[] cmdArgs = input.Split(' ');
                string command = cmdArgs[0];
                string storeName, type, color, newName;
                double price;
                switch (command)
                {
                    case "CreateFlowerStore":
                        storeName = cmdArgs[1];
                        CreateFlowerStore(storeName);
                        break;

                    case "AddFlower":
                        type = cmdArgs[1];
                        color = cmdArgs[2];
                        price = double.Parse(cmdArgs[3]);
                        storeName = cmdArgs[4];
                        AddFlower(type, color, price, storeName);
                        break;

                    case "SellFlower":
                        type = cmdArgs[1];
                        color = cmdArgs[2];
                        price = double.Parse(cmdArgs[3]);
                        storeName = cmdArgs[4];
                        SellFlower(type, color, price, storeName);
                        break;

                    case "CalculateTotalPrice":
                        storeName = cmdArgs[1];
                        CalculateTotalPrice(storeName); 
                        break;

                    case "RenameFlowerStore":
                        
                        storeName = cmdArgs[1];
                        newName = cmdArgs[2];
                        RenameFlowerStore(storeName, newName);
                        break;

                    case "SellAllFlowers":
                        storeName = cmdArgs[1];
                        SellAllFlowers(storeName);
                        break;

                    case "GetFlowerWithHighestPrice":
                        storeName = cmdArgs[1];
                        GetFlowerWithHighestPrice(storeName);
                        break;

                    case "GetFlowerWithLowestPrice":
                        storeName = cmdArgs[1];
                        GetFlowerWithLowestPrice(storeName); 
                        break;
                    case "FlowerStoreInfo":
                        storeName = cmdArgs[1];
                        FlowerStoreInfo(storeName);
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
                input = Console.ReadLine();
            }

        }
        static void CreateFlowerStore(string storeName)
        {
            if (!stores.ContainsKey(storeName))
            {
                try
                {
                    FlowerStore flowerStore = new FlowerStore(storeName);
                stores.Add(storeName, flowerStore);
                Console.WriteLine($"You created flower store {storeName}.");
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Could not add this flower to your store.");
            }
        }
        static void AddFlower(string type, string color, double price, string storeName)
        {
            try
            {
                Flower flower = new Flower(type, color, price);
                if (!stores.ContainsKey(storeName))
                {
                    Console.WriteLine("Could not add this flower to your store.");
                    return;
                }
                stores[storeName].AddFLower(flower);
                Console.WriteLine($"You added flower {type} with color {color} to store {storeName}.");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void SellFlower(string type, string color, double price, string storeName)
        {
            try
            {
                if (!stores.ContainsKey(storeName))
                {
                    Console.WriteLine("Could not sell this flower from your store.");
                    return;
                }

                Flower flower = new Flower(type, color, price);
                FlowerStore store = stores[storeName];
                if (store.SellFlower(flower))
                {
                    Console.WriteLine($"You sold flower {type} with color {color} from flower store {storeName}.");
                }
                else
                {
                    Console.WriteLine($"Did not sell flower {type} with color {color} from flower store {storeName}.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void CalculateTotalPrice(string storeName)
        {
            try
            {
                if (!stores.ContainsKey(storeName))
                {
                    Console.WriteLine("Could not calculate total price.");
                    return;
                }
                Console.WriteLine($"Total price: {stores[storeName].CalculateTotalPrice():F2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void RenameFlowerStore(string storeName, string newName)
        {

            if (!stores.ContainsKey(storeName))
            {
                Console.WriteLine($"Could not rename the store {storeName}.");
                return;
            }
            FlowerStore store = stores[storeName];

            try
            {
                store.RenameFlowerStore(newName);
                stores.Remove(storeName);
                stores.Add(newName, store);
                Console.WriteLine($"You renamed your store from {storeName} to {newName}.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void SellAllFlowers(string storeName)
        {
            if (!stores.ContainsKey(storeName))
            {
                Console.WriteLine($"Could not sell all flowers from store {storeName}.");
                return;
            }
            stores[storeName].SellAllFlowers();
            Console.WriteLine($"You sold all flowers from store {storeName}.");
        }

        private static void FlowerStoreInfo(string storeName)
        {
            if (!stores.ContainsKey(storeName))
            {
                Console.WriteLine($"Could not get store {storeName}.");
                return;
            }
            Console.WriteLine(stores[storeName].ToString());
        }


        static void GetFlowerWithHighestPrice(string storeName)
        {
            if (!stores.ContainsKey(storeName))
            {
                Console.WriteLine($"Could not get flower with highest price from store {storeName}.");
                return;
            }
            Flower highestPricedFlower = stores[storeName].GetFlowerWithHighestPrice();
            Console.WriteLine($"Flower from store {storeName} has highest price: {highestPricedFlower.Price:F2}");
        }


        static void GetFlowerWithLowestPrice(string storeName)
        {
            if (!stores.ContainsKey(storeName))
            {
                Console.WriteLine($"Could not get flower with lowest price from store {storeName}.");
                return;
            }
            Flower highestPricedFlower = stores[storeName].GetFlowerWithLowestPrice();
            Console.WriteLine($"Flower from store {storeName} has lowest price: {highestPricedFlower.Price:F2}");
        }

    }
}
