using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_Person
{
    class BankAccount
    {
        private static int count = 0;
        private string id;
        private double balance = 0;
        public BankAccount(string id)
        {
            ID = id;
            BankAccount.count++;
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public void Deposit(double amount)
        {
            if (amount <= 0) throw new ArgumentException("Amount Is NOT Valid");
            else
            {
                this.balance += amount;
                Console.WriteLine($"Deposited ${amount:f2} to Bank Account With ID '{id}'");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > this.balance) throw new ArgumentException("Not Enough Money!");
            else if (amount <= 0) throw new ArgumentException("Amount Is NOT Valid");
            else
            {
                this.balance -= amount;
                Console.WriteLine($"Withdrew ${amount:f2} from Bank Account With ID '{id}'");
            }
        }
        public static int GetBankAccountsCount()
        {
            return BankAccount.count;
        }
        public override string ToString()
        {
            return $"'{this.id}' -> ${this.balance:f2}";
        }
    }
}

