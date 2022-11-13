using System;
using System.Collections.Generic;
using System.Text;

namespace Banker
{
    static class Bank
    {
        private static Dictionary<string, BankAccount> accounts;

        static Bank()
        {
            accounts = new Dictionary<string, BankAccount>();
        }
        public static BankAccount GetBankAccountByID(string id)
        {
            if (!AccountExists(id)) { throw new ArgumentException("Bank account doesn't exist!"); }
            else return accounts[id];
        }
        public static void AddAccount(string id)
        {
            if (AccountExists(id)) throw new ArgumentException("Bank account already exists!");

            else
            {
                accounts.Add(id, new BankAccount(id));
            }
        }
        public static void Deposit(string id, double amount)
        {
            if (!AccountExists(id)) throw new ArgumentException("Bank account doesn't exist!");
            else if (amount < 0) throw new ArgumentException("Amount is lower than 0!");
            else
            {
                accounts[id].Balance += amount;
            }
        }
        public static void Withdraw(string id, double amount)
        {
            if (!AccountExists(id)) throw new ArgumentException("Bank account doesn't exist!");
            else if (accounts[id].Balance < amount) { throw new ArgumentException("Account balance is lower than withdraw amount!");}
            else
            {
                accounts[id].Balance -= amount;
            }
        }
        public static bool AccountExists(string id)
        {
            if (accounts.ContainsKey(id))
            {
                return true;
            }
            return false;
        }

    }

}

