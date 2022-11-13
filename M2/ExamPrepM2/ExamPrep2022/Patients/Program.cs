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
                string[] inpArgs = input.Split(' ');
                switch (input)
                {
                    case "Add patient":

                        patients.Add(Console.ReadLine());
                        break;

                    case "Add patient on position":

                        string patient = Console.ReadLine();
                        int position = int.Parse(Console.ReadLine());
                        try
                        {
                            patients.Insert(position, patient);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        break;

                    case "Remove patient on position":

                        int pos = int.Parse(Console.ReadLine()) - 1;
                        patients.RemoveAt(pos);
                        break;

                    case "Remove first patient":

                        if (patients.Count > 0) patients.RemoveAt(0);

                        break;

                    case "Remove last patient":

                        if (patients.Count > 0) patients.RemoveAt(patients.Count - 1); break;

                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", patients));
        }
    }
}
