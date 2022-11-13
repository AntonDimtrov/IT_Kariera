using System;
using System.Collections.Generic;

namespace BankAccountCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, BankAccount> accounts = new Dictionary<string, BankAccount>();
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] comArgs = command.Split(' ');

                switch (comArgs[0])
                {
                    case "Create":
                        CreateAccount(comArgs, accounts);
                        break;
                    case "Deposit":
                        Deposit(comArgs, accounts);
                        break;
                    case "Withdraw":
                        Withdraw(comArgs, accounts);
                         break;
                    case "Print":
                        Print(comArgs, accounts);
                        break;
                        
                }
                command = Console.ReadLine();
                
            }
        }
        public static void CreateAccount(string[] comArgs, Dictionary<string, BankAccount> accounts)
        {
            string id=comArgs[0];
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists!");
            }
            else accounts.Add(id, new BankAccount(id));
        }
        public static void Deposit(string[] comArgs, Dictionary<string, BankAccount> accounts)
        {
            string id = comArgs[0];
            double amount = double.Parse(comArgs[2]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account doesnt exist!");
            }
            else accounts[id].Deposit(amount);
        }
        public static void Withdraw(string[] comArgs, Dictionary<string, BankAccount> accounts)
        {
            string id = comArgs[0];
            double amount = double.Parse(comArgs[2]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account doesnt exist!");
            }
            else if (accounts[id].Balance < amount)
            {
                Console.WriteLine("Not nough money in bank account!");
            }
            else accounts[id].Withdraw(amount);
        }
        public static void Print(string[] comArgs, Dictionary<string, BankAccount> accounts)
        {
            string id = comArgs[0];
            Console.WriteLine(accounts[id].ToString());
        }
        

    }
}
