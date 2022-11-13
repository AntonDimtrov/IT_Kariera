using System;

namespace Exercise1_Person
{
    class Program
    {
        static Person person = new Person("Anton", 16);
        static void Main(string[] args)
        {
            string command = GetCommand();
            while (command != "End")
            {
                ExecuteCommand(command);
                command = GetCommand();
            }
            PrintPersonInfo();
        }
        public static string GetCommand()
        {
            Console.WriteLine("Enter command: ");
            return Console.ReadLine();
        }
        public static void ExecuteCommand(string command)
        {
            string[] cmdArgs = command.Split();
            switch (cmdArgs[0])
            {
                //Create ID 
                case "Create": Create(cmdArgs[1]); break;
                //Deposit ID Amount
                case "Deposit": Deposit(cmdArgs[1], double.Parse(cmdArgs[2])); break;
                //Withdraw ID Amount
                case "Withdraw": Withdraw(cmdArgs[1], double.Parse(cmdArgs[2])); break;
                //Print ID
                case "Print": PrintAccount(cmdArgs[1]); break;
                //PrintAll 
                case "PrintAll": PrintAll(); break;
                //Invalid Command
                default: Console.WriteLine("Invalid Command!"); break;
            }
        }
        public static void Create(string id)
        {
            try
            {
                person.AddAccount(id);
                Console.WriteLine($"Created Bank Account With ID '{id}'");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Deposit(string id, double amount)
        {
            try
            {
                person.Deposit(id, amount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Withdraw(string id, double amount)
        {
            try
            {
                person.Withdraw(id, amount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void PrintAccount(string id)
        {
            Console.WriteLine(person.GetAccount(id));
        }
        public static void PrintAll()
        {
            person.GetBankAccountsInfo();
        }
        public static void PrintPersonInfo()
        {
            Console.WriteLine(person);
        }
        public static int GetBankAccountsCount()
        {
            Console.WriteLine(BankAccount.GetBankAccountsCount());
            return BankAccount.GetBankAccountsCount();
        }
    }
}
