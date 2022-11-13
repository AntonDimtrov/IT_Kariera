using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_validation_exercises
{
    class BankAccount
    {
        private int id;
        private double balance;
        public BankAccount(int id)
        {
            this.id = id;
            this.balance = 0;
        }

        public int ID { get => id;}
        public double Balance { get => balance; }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }
        public void Withdraw(double amount)
        {   if (this.balance>=amount) this.balance -= amount;
            else Console.WriteLine("Not enough money");

        }
        public override string ToString()
        {
            return $"{this.id}  --->  {this.balance}";
        }
    }
    
}
