using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_validation_exercises
{
    static class Bank
    {
        private static Dictionary<int, BankAccount> bankAccounts;

        static Bank()
        {
            bankAccounts = new Dictionary<int, BankAccount>();
        }
        public static void AddAccount(int id)
        {
            if (bankAccounts.ContainsKey(id)) { Console.WriteLine($"Bankaccount with ID => {id} already exists!"); }
            else
            {
                BankAccount bankAccount = new BankAccount(id);
                bankAccounts.Add(id, bankAccount);
            }

        }
        public static void Deposit(int id, double amount)
        {
            if (bankAccounts.ContainsKey(id)) { bankAccounts[id].Deposit(amount); }
            else { Console.WriteLine($"Bankaccount with  ID => {id} doesn't exist!"); }
        }
        public static void Withdraw(int id, double amount)
        {
            if (bankAccounts.ContainsKey(id)) { bankAccounts[id].Withdraw(amount); }
            else { Console.WriteLine($"Bankaccount with  ID => {id} doesn't exist!"); }
        }
        public static void PrintAllBankAccounts()
        {
            foreach (BankAccount bankAcc in bankAccounts.Values.ToArray())
            {
                Console.WriteLine(bankAcc);
            }
        }















    }
}
