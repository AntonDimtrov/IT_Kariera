using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceClasses
{
    class Student : Person
    {

        private string school;
        public Student(string name, int age, string school) : base(name, age)
        {
            School = school;
        }

        public string School { get => school; private set => school = value; }
        public void Work()
        {
            Console.WriteLine("Studying...");
        }
        public override string ToString()
        {
            return base.ToString() + $"\nSchool: {this.school}";
        }
    }
}
