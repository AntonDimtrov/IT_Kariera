using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountCreator
{
    class BankAccount
    {
        private string id;
        private double balance = 0;

        public BankAccount(string id)
        {
            this.Id = id;

        }

        public string Id
        {
            get { return id; }
            private set { id = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            //private set { balance = value; }
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else { Console.WriteLine("NOT ENOUGH MONEY");}
        }
        public override string ToString()
        {
            return $"ID: {this.id}  BALANCE: {this.balance}";
        }
    }
}
