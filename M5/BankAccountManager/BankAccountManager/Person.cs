using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise1_Person
{
    class Person
    {
        //Properties
        private string name;
        private int age;
        private Dictionary<string, BankAccount> accounts;

        //Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.accounts = new Dictionary<string, BankAccount>();
        }

        //Getters And Setters (Fields?)
        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public Dictionary<string, BankAccount> Accounts
        {
            get { return this.accounts; }
        }

        //Methods
        public void IntroduceYourself()
        {
            Console.WriteLine($"Hello, my name is {this.name}");
        }
        public double GetBalance()
        {           
            Console.WriteLine($"{this.name} -> {accounts.Values.Sum(x => x.Balance)}$");
            return accounts.Values.Sum(x => x.Balance);
        }
        public BankAccount GetAccount(string id)
        {
            if (!AccountExists(id)) throw new ArgumentException($"Bank Account With ID '{id}' Does NOT Exist");
            return accounts[id];
        }
        public void GetBankAccountsInfo()
        {
            foreach (var acc in accounts.Values)
            {
                Console.WriteLine(acc);
            }
        }
        public BankAccount AddAccount(string id)
        {
            if (accounts.ContainsKey(id)) throw new ArgumentException($"Bank Account With ID '{id}' Already Exists!");
            else
            {
                accounts.Add(id, new BankAccount(id));              
            }
            return accounts[id];
        }
        public void Deposit(string id, double amount)
        {
            if(!AccountExists(id)) throw new ArgumentException($"Bank Account With ID '{id}' Does NOT Exist!");
            else
            {
                accounts[id].Deposit(amount);
            }
        }
        public void Withdraw(string id, double amount)
        {
            if (!AccountExists(id)) throw new ArgumentException("Bank Account With Such Name Does NOT Exist!");
            else
            {
                accounts[id].Withdraw(amount);
            }
        }
        public bool AccountExists(string id)
        {
            return accounts.ContainsKey(id);
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder("\nPERSON INFO:\n");
            info.Append($"Name: {this.name}\n");
            info.Append($"Age: {this.age}\n");
            info.Append($"BankAccounts:\n");
            foreach (var acc in accounts.Values)
            {
                info.Append(acc+"\n");
            }
            return info.ToString();
        }
    }
}
