using System;

namespace InheritanceClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Anton", 16, "PMG");
            Employee em = new Employee("John", 18, "Apple");
            em.Work();
            em.Sleep();
            Console.WriteLine(em);
        }
    }
}
