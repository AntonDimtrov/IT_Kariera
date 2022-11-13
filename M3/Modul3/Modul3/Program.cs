using System;
using System.Collections.Generic;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                double salary = double.Parse(input[1]);
                string job = input[2];
                string department = input[3];
                string email = "n/a";
                int age = -1;
                if (input.Length > 4)
                {
                    if (input.Length > 5)
                    {
                        email = input[4];
                        age = int .Parse(input[5]);
                    }
                    else if (input[4].Contains('@'))
                    {
                        email = input[4];
                    }
                    else
                    {
                        age = int.Parse(input[4]);
                    }
                }
                list.Add(new Employee(name, salary, job, department, email, age));
            }

        }
    }
}
