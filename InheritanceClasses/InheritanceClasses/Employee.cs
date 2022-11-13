using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceClasses
{
    class Employee : Person
    {
        private string company;
        public Employee(string name, int age, string company) : base(name, age)
        {
            Company = company;
        }

        public string Company { get => company; private set => company = value; }
        public void Work()
        {
            Console.WriteLine("Working...");
        }
        public override string ToString()
        {
            return base.ToString() + $"\nCompany: {this.company}";
        }
    }
}
