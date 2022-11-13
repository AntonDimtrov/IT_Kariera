using System;
using System.Collections.Generic;
using System.Linq;

namespace Patients
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> patients = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            while (input != "END OF PATIENTS")
            {
                switch (input)
                {
                    case "Add patient":
                        string p = Console.ReadLine();
                        patients.Add(p);
                        break;

                    case "Add patient on position":

                        string patient = Console.ReadLine();
                        int position = int.Parse(Console.ReadLine());
                        patients.Insert(position, patient);

                        break;

                    case "Remove patient on position":

                        int pos = int.Parse(Console.ReadLine());
                        patients.RemoveAt(pos);
                        break;

                    case "Remove first patient":

                        patients.RemoveAt(0);

                        break;

                    case "Remove last patient":

                        patients.RemoveAt(patients.Count - 1); break;

                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", patients));
        }
    }
}
