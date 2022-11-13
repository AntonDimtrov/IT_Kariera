using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_modul3_BEGINING
{
    class Person
    {   /*                                                                  (1)
        private int age;
        private string name;
        
        List<BankAccount> bankAccounts = new List<BankAccount>();
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<BankAccount> BankAccounts
        {
            get { return bankAccounts; }
            set { bankAccounts = value; } 
        }
        public double GetBalance()
        { double balance = 0;
            foreach(BankAccount bankAccount in bankAccounts)
            {
                balance += bankAccount.Balance;
            }
            return balance;
        }*/

        private string name;
        private int age;
        private double salary;
        private string job;
        private string department;
        private string email;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Job
        {
            get
            {
                if (job == "") { return "None"; }
                else { return job; }
            }
            set { job = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
