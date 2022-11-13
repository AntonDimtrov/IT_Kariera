using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPrep_Pharmacy
{
    class Program
    {
        static Dictionary<string, Pharmacy> phars = new Dictionary<string, Pharmacy>();
        static Dictionary<string, Medicine> meds = new Dictionary<string, Medicine>();
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] cmdArgs = command.Split(' ');
                string medName, pharName;
                double medPrice;
                switch (cmdArgs[0])
                {
                    case "AddMedicine":
                        medName = cmdArgs[1];
                        medPrice = double.Parse(cmdArgs[2]);
                        AddMedicine(medName, medPrice);
                        break;


                    case "MedicineInfo":
                        medName = cmdArgs[1];
                        MedicineInfo(medName);
                        break;

                    case "CreatePharmacy":
                        pharName = cmdArgs[1];
                        CreatePharmacy(pharName);
                        break;

                    case "PharmacyInfo":
                        pharName = cmdArgs[1];
                        PharmacyInfo(pharName);
                        break;

                    case "Order":
                        medName = cmdArgs[1];
                        pharName = cmdArgs[2];
                        Order(medName, pharName);
                        break;

                    case "Sell":
                        medName = cmdArgs[1];
                        pharName = cmdArgs[2];
                        Sell(medName, pharName); 
                        break;

                    case "CalculateTotalPrice":
                        pharName = cmdArgs[1];
                        CalculateTotalPrice(pharName);
                        break;

                    case "RenamePharmacy":
                        pharName = cmdArgs[1];
                        string newName = cmdArgs[2];
                        RenamePharmacy(pharName, newName);
                        break;

                    case "SellAllMedicines":
                        pharName = cmdArgs[1];
                        SellAllMedicines(pharName);
                        break;

                    case "GetMedicineWithHighestPrice":
                        pharName = cmdArgs[1];
                        GetMedicineWithHighestPrice(pharName);
                        break;
                    case "GetMedicineWithLowestPrice":
                        pharName = cmdArgs[2];
                        GetMedicineWithLowestPrice(pharName);
                        break;

                }
                command = Console.ReadLine();
            }





        }
        public static void Order(string medicine, string pharmacy)
        {

            if (meds.ContainsKey(medicine))
            {
                phars[pharmacy].Order(meds[medicine]);
            }
            else Console.WriteLine("Could not order medicine");

        }
        public static void Sell(string medicine, string pharmacy)
        {
            if (meds.ContainsKey(medicine))
            {
                phars[pharmacy].Sell(meds[medicine]);
            }
            else Console.WriteLine($"Did not sell medicine {medicine}");
        }
        public static void CalculateTotalPrice(string pharmacy)
        {
            double totalPrice = phars[pharmacy].CalculateTotalPrice();
            Console.WriteLine(totalPrice);
        }
        public static void RenamePharmacy(string pharmacy, string newName)
        {
            phars[pharmacy].RenamePharmacy(newName);
        }
        public static void SellAllMedicines(string pharmacy)
        {
            phars[pharmacy].SellAllMedicines();
        }
        public static void GetMedicineWithHighestPrice(string pharmacy)
        {
            Medicine medicine = phars[pharmacy].GetMedicineWithHighestPrice();
            Console.WriteLine(medicine);
        }
        public static void GetMedicineWithLowestPrice(string pharmacy)
        {
            Medicine medicine = phars[pharmacy].GetMedicineWithLowestPrice();
            Console.WriteLine(medicine);
        }


        static void AddMedicine(string name, double price)
        {
            if (meds.ContainsKey(name))
            {
                Console.WriteLine("Medicine aready added");
            }
            else { meds.Add(name,  new Medicine(name, price)); }
        }
        static void MedicineInfo(string medicine)
        {   
            Console.WriteLine(meds[medicine]);
        }
        static void CreatePharmacy(string name)
        {
            if (phars.ContainsKey(name))
            {
                Console.WriteLine("Pharmacy aready exists");
            }
            else { phars.Add(name, new Pharmacy(name)); }
        }
        static void PharmacyInfo(string pharmacy)
        {
            Console.WriteLine(phars[pharmacy]);
        }

    }
}
