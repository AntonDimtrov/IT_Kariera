using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_validation_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*                                                      1 -> Person Name Validator
              Person person1 = new Person("a", "d", 16, 150);
            */
            /*                                                      2 -> MyMath
             MyMath.Add(1, 2);
            MyMath.Multiply(98, 56);
            Console.ReadLine();
            */
            //                                                      3 -> Bank Account Manager
            /*
            Bank.AddAccount(3);
            Bank.Deposit(3, 50);
            Bank.Withdraw(3, 2);
            Bank.AddAccount(3);
            Bank.AddAccount(2);
            Bank.Deposit(2, 567);
            Bank.Withdraw(2, 1111);
            Bank.PrintAllBankAccounts();
            Console.Read();*/





            //                                                      4 -> Loading Trucks
            Console.WriteLine(25 + "+" + 25);
            Console.ReadLine();
            Dictionary<string, Trucks> trucks =  GetTruckInput();
            Dictionary<string, Cargo> cargos = GetCargoInput();
            string userInput = Console.ReadLine(); ;
            bool error = false;
            
            while (userInput != "END")
            {   
                if (userInput.Length >= 1)
                {
                    string []commandArgs = userInput.Split(' ').Where(x => x != "").ToArray();
                    if (commandArgs.Length != 2) { error = true; }
                    else
                    {
                        trucks[commandArgs[0]].LoadTruck(cargos[commandArgs[1]]);
                    }

                }
                else { error = true; }
                if (error) Console.WriteLine("Error");
                userInput = Console.ReadLine();
            }
            PrinTrucks(trucks);
            Console.ReadLine();

        }
        static Dictionary<string, Trucks> GetTruckInput()
        {
            string[] userInput = Console.ReadLine().Split(';').Where(x => x != "").ToArray();
            Dictionary<string, Trucks> trucks = new Dictionary<string, Trucks>();
            for (int i = 0; i < userInput.Length; i++)
            {
                string[] x = userInput[i].Split('=').ToArray();
                trucks.Add(x[0], new Trucks(x[0], int.Parse(x[1])));
            }
            return trucks;
        }
        static Dictionary<string, Cargo> GetCargoInput()
        {
            string[] userInput = Console.ReadLine().Split(';').Where(x => x != "").ToArray();
            Dictionary<string, Cargo> cargos = new Dictionary<string, Cargo>();
            for (int i = 0; i < userInput.Length; i++)
            {
                string[] x = userInput[i].Split('=').ToArray();
                cargos.Add(x[0], new Cargo(x[0], int.Parse(x[1])));
            }
            return cargos;
        }
        static void PrinTrucks(Dictionary<string, Trucks> trucks)
        {
            foreach(KeyValuePair<string, Trucks> truck in trucks)
            {
                Console.WriteLine(truck.Value);
            }           
        }

    }
}



