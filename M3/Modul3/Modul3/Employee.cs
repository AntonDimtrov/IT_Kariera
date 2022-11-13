using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    class Employee
    {
        private string name;
        private double salary;
        private string job;
        private string department;
        private string email;
        private int age;

        public Employee(string name, double salary, string job, string department, string email = "n/a", int age = -1)
        {
            this.Name = name;
            this.Salary = salary;
            this.Job = job;
            this.Department = department;
            this.Email = email;
            this.Age = age;
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { this.salary = value; }
        }
        public string Job
        {
            get { return job; }
            set { this.job = value; }
        }
        public string Department
        {
            get { return department; }
            set { this.department = value; }
        }
        public string Email
        {
            get { return email; }
            set { this.email = value; }
        }
        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }

        
    }
}
