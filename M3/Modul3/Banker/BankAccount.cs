using System;
using System.Collections.Generic;
using System.Text;

namespace Banker
{
    class BankAccount
    {
        private string id;
        private double balance;

        public BankAccount(string id)
        {
            this.Id = id;
        }

        public string Id
        {
            get { return this.id; }
            set
            {
                if (value.Length > 0)
                {
                    this.id = value;
                }
                else throw new ArgumentException("ID must be longer!");
            }
        }
        public double Balance
        {
            get { return this.balance; }
            set
            {
                if (value > 0)
                {
                    balance = value;
                }
            }
        }
        public override string ToString()
        {
            return $"Bankaccount with ID {this.id} has a balance of {this.balance} $";
        }
    }
}
