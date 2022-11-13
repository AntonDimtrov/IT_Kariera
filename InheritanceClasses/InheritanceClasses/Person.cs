using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceClasses
{
    class Person
    {
        private string name;
        private int age;

        internal string EGN = "1234";

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
        }
        public int Age
        {
            get { return this.age; }
        }
        public void Sleep()
        {
            Console.WriteLine("Sleeping...ZZZ");
        }
        public override string ToString()
        {
            return $"Name: {this.name}\nAge: {this.age}";
        }

    }
}
