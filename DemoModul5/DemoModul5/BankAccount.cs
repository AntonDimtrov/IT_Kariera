using System;
using System.Collections.Generic;
using System.Text;

namespace DemoModul5
{
    public class BankAccount
    {
        private double balance;

        public BankAccount(double balance)
        {
            this.Balance = balance;
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public void Deposit(Double amount)
        {
            if (amount < 0) Console.WriteLine("ERROR: INVALID AMOUNT");
            else
            {
                this.balance += amount;
            }
        }
        public void Withdraw(double amount)
        {
            if (amount < 0) Console.WriteLine("ERROR: INVALID AMOUNT");
            else if (amount > this.balance) Console.WriteLine("ERROR: NOT ENOUGH MONEY IN BANK");
            else
            {
                balance -= amount;
            }
        }
        public void CheckBalance()
        {
            Console.WriteLine($"Balance: {this.balance}");
        }
    }
}
