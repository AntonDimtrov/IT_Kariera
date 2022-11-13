using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_modul3_BEGINING
{
    class Program
    {
        static void Main(string[] args)
        {
            /*                                          (1)
            Person person1 = new Person();
            person1.Name = "John";
            person1.Age = 25;
            
            BankAccount bankAcc1 = new BankAccount();
            bankAcc1.IBan = "b1";
            bankAcc1.Balance = 100;

            BankAccount bankAcc2 = new BankAccount();
            bankAcc2.IBan = "b2";
            bankAcc2.Balance = 200;

           
            person1.BankAccounts.Add(bankAcc1);
            person1.BankAccounts.Add(bankAcc2);
           

            Console.WriteLine(person1.GetBalance()) ;
            Console.ReadLine();*/
            //                                                  Person_Salary_Job_Department_E-mail_Age

            int n = UserInput("Number of people");
            Person[] people = new Person[n];
            Dictionary<string, double[]> bestPayingDepartment = new Dictionary<string, double[]>();
            for (int i = 0; i < n; i++)
            {
                people[i] = new Person();
                // name salary job department email age
                string[] user_input = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();
                while (user_input.Length < 4)
                {
                    Console.WriteLine("Error");
                    user_input = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();

                }
                people[i].Name = user_input[0];
                people[i].Salary = Double.Parse(user_input[1]);
                people[i].Job = user_input[2];
                people[i].Department = user_input[3];
                if (user_input.Length > 4 && user_input[4].Contains("@"))
                {
                    people[i].Email = user_input[4];
                    if (user_input.Length > 5)
                    {
                        people[i].Age = int.Parse(user_input[5]);
                    }
                    else
                    {
                        people[i].Age = -1;
                    }
                }
                else
                {
                    people[i].Email = "n/a";
                    people[i].Age = int.Parse(user_input[4]);
                }
                if (!bestPayingDepartment.ContainsKey(user_input[3]))
                {
                    bestPayingDepartment.Add(people[i].Department, new double[] { people[i].Salary, 1.0 });
                }
                else
                {
                    bestPayingDepartment[people[i].Department][0] += people[i].Salary;
                    bestPayingDepartment[people[i].Department][1]++;
                }
            }
            double a = 0d;
            string departmentName = "";
            //Console.WriteLine(bestPayingDepartment[c][0]);
            foreach (var pair in bestPayingDepartment)
            {
                pair.Value[0] /= pair.Value[1];
                if (pair.Value[0] > a)
                {
                    a = pair.Value[0];
                    departmentName = pair.Key;
                }
            }

            //Print
            Console.WriteLine(departmentName);
            Console.WriteLine(bestPayingDepartment[departmentName][0]);                      //Best average salary
            foreach (Person person in people.OrderBy(item => item.Salary).ToArray())
            {
                if (person.Department == departmentName)
                {
                    Console.WriteLine($"{person.Name} {person.Salary} {person.Email} {person.Age}");
                }
            }
            Console.ReadLine();


            /*
            Dictionary<string, double> accounts = new Dictionary<string, double>();
            string user_input = "";
            while (user_input.ToLower() != "end")
            {   
                user_input = Console.ReadLine();
                if (user_input == "") { Console.WriteLine("Unkown command"); }
                else
                {
                    string[] input = user_input.ToLower().Split(' ').Where(x => x != "").ToArray();
                    // action id ammount
                    if ((input[0] == "create" || input[0] == "c") && input.Length == 2)
                    {
                        if (!accounts.ContainsKey(input[1]))
                        {
                            accounts.Add(input[1], 0d);
                            Console.WriteLine("Account added successfully");
                        }
                        else
                        {
                            Console.WriteLine("Account already exists");
                        }
                    }
                    else if ((input[0] == "deposit" || input[0] == "d") && input.Length == 3)
                    {
                        if (double.Parse(input[2]) < 0)
                        {
                            Console.WriteLine("Amount must be a positive number!");
                        }
                        else if (accounts.ContainsKey(input[1]))
                        {
                            accounts[input[1]] += double.Parse(input[2]);
                            Console.WriteLine("Deposit successful");
                        }
                        else
                        {
                            Console.WriteLine("Bank account doesnt exist");
                        }
                    }
                    else if ((input[0] == "withdraw" || input[0] == "w") && input.Length == 3)
                    {
                        if (accounts.ContainsKey(input[1]))
                        {
                            if (double.Parse(input[2]) < 0)
                            {
                                Console.WriteLine("Amount must be a positive number!");
                            }
                            else if (accounts[input[1]] >= double.Parse(input[2]))
                            {
                                accounts[input[1]] -= double.Parse(input[2]);
                                Console.WriteLine("Withdraw successful");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money in bank account");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Bank account doesnt exist");
                        }
                    }
                    else if ((input[0] == "print" || input[0] == "p") && input.Length == 2)
                    {
                        if (accounts.Count == 0)
                        {
                            Console.WriteLine("No accounts entered");
                        }
                        else if (input[1] == "all")
                        {
                            Console.WriteLine($"ID ---> AMMOUNT");
                            foreach (KeyValuePair<string, double> pair in accounts)
                            {
                                Console.WriteLine($"{pair.Key} ---> {pair.Value}");
                            }
                        }
                        else if (accounts.ContainsKey(input[1]))
                        {
                            Console.WriteLine($"{input[1]} ---> {accounts[input[1]]}");
                        }
                        else
                        {
                            Console.WriteLine("Bank account doesn't exist");
                        }
                    }
                    else if (input[0] != "end")
                    {
                        Console.WriteLine("Unknown command");
                    }
                }

            }
            Console.WriteLine("Ending... Press any key to continue...");
            Console.Read();*/

        }
        static int UserInput(string text)
        {
            int k = 0; string s = "";
            Console.Write($"{text}: ");
            s = Console.ReadLine();
            while (!int.TryParse(s, out k))
            {
                Console.WriteLine("Error! Enter an int number");
                Console.Write($"{text}: ");
                s = Console.ReadLine();
            }
            k = int.Parse(s);
            return k;
        }

    }
}
