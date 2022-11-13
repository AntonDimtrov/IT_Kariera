using System;
using System.Collections.Generic;
using System.Linq;
using BorderControl.Interfaces;
using BorderControl.Classes;
using System.Globalization;

namespace BorderControl
{
    class Program
    {
        //static List<ICityCitizen> citizens = new List<ICityCitizen>();
        static Dictionary<string, IInhabitant> inhabitants = new Dictionary<string, IInhabitant>();

        static void Main(string[] args)
        {
            GetInhabitantsInput();
            CheckYear();
            CheckID();
            BuyFood();
        }
        public static void GetInhabitantsInput()
        {
            Console.Write("Enter Inhabitant Info: ");
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(' ');
                switch (cmdArgs[0])
                {
                    case "Robot":
                        AddRobot(cmdArgs[1], cmdArgs[2]);
                        break;
                    case "Citizen":
                        AddPerson(cmdArgs[1], int.Parse(cmdArgs[2]), cmdArgs[3], DateTime.ParseExact(cmdArgs[4], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                        break;
                    case "Pet":
                        AddPet(cmdArgs[1], DateTime.ParseExact(cmdArgs[2], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                        break;
                    case "Rebel":
                        AddRebel(cmdArgs[1], int.Parse(cmdArgs[2]), cmdArgs[3]);
                        break;
                    default: break;
                }
                Console.Write("Enter Inhabitant Info: ");
            }
        }
        public static void BuyFood()
        {
            int foodSum = 0;

            Console.Write("Buy Food(Enter Name): ");
            string inputName;
            while ((inputName = Console.ReadLine()) != "End")
            {
                if (inhabitants.ContainsKey(inputName))
                {
                    if (inhabitants[inputName].GetType().GetInterface("IBuyer") == typeof(IBuyer))
                    {
                        ((IBuyer)inhabitants[inputName]).BuyFood();
                        foodSum += ((IBuyer)inhabitants[inputName]).FoodIncrease;
                    }
                }
                Console.Write("Buy Food(Enter Name): ");
            }
            Console.WriteLine($"FOOD: '{foodSum}'");

            //IF USING LIST INSTEAD OF DICTIONARY
            /*foreach (ICityCitizen citizen in citizens)
            {
                if (citizen.GetType().GetInterface("IBuyer") == typeof(IBuyer))
                {
                    foodSum += ((IBuyer)citizen).Food;
                }
            }
            Console.WriteLine($"FOOD: '{foodSum}'");*/
        }
        public static void CheckID()
        {
            Console.Write("Enter Fake ID Ending: ");
            string fakeIDEnding = Console.ReadLine();

            foreach (IInhabitant inhabitant in inhabitants.Values)
            {
                if (inhabitant.GetType().GetInterface("ICitizen") == typeof(IIdentifiable))
                {
                    if (Soldier.CheckIDIsFake(((IIdentifiable)inhabitant).ID, fakeIDEnding))
                    {
                        Console.WriteLine($"FAKE ID: '{((IIdentifiable)inhabitant).ID}'");
                    }
                }
            }

            //IF USING LIST INSTEAD OF DICTIONARY
            /*foreach (ICityCitizen citizen in citizens)
            {
                if (citizen.GetType().GetInterface("ICitizen") == typeof(ICitizen))
                {
                    if (Soldier.CheckIDIsFake(((ICitizen)citizen).ID, fakeIDEnding))
                    {
                        Console.WriteLine($"FAKE ID: '{((ICitizen)citizen).ID}'");
                    }
                }
            }*/
        }
        public static void CheckYear()
        {
            Console.Write("Enter Year: ");
            int year = int.Parse(Console.ReadLine());

            foreach (IInhabitant inhabitant in inhabitants.Values)
            {
                if (inhabitant.GetType().GetInterface("IAlive") == typeof(IBirthable))
                {
                    if (((IBirthable)inhabitant).Birthday.Year == year)
                    {
                        Console.WriteLine($"YEAR: '{((IBirthable)inhabitant).Birthday.ToString("dd/MM/yyyy")}'");
                    }
                }
            }

            /*foreach (ICityCitizen citizen in citizens)
            {
                if (citizen.GetType().GetInterface("IAlive") == typeof(IAlive))
                {
                    if (((IAlive)citizen).Birthday.Year == year)
                    {
                        Console.WriteLine($"YEAR: '{((IAlive)citizen).Birthday.ToString("dd/MM/yyyy")}'");
                    }
                }
            }*/
        }
        private static void AddPerson(string name, int age, string id, DateTime birthday)
        {
            //citizens.Add(new Citizen(name, age, id, birthday));
            inhabitants.Add(name, new Citizen(name, age, id, birthday));
        }
        private static void AddRobot(string model, string id)
        {
            //citizens.Add(new Robot(model, id));
            inhabitants.Add(model, new Robot(model, id));
        }
        private static void AddPet(string name, DateTime birthday)
        {
            //citizens.Add(new Pet(name, birthday));
            inhabitants.Add(name, new Pet(name, birthday));
        }
        private static void AddRebel(string name, int age, string group)
        {
            //citizens.Add(new Rebel(name, age, group));
            inhabitants.Add(name, new Rebel(name, age, group));
        }

    }
}
