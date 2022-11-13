using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPrep_Pharmacy
{
    class Pharmacy
    {
        private string name;
        private List<Medicine> medicines;
        public Pharmacy(string name)
        {
            this.Name = name;
            medicines = new List<Medicine>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 3) Console.WriteLine("Invalid name");
                else name = value;
            }
        }
        public void Order(Medicine medicine)
        {
            medicines.Add(medicine);
        }

        public bool Sell(Medicine medicine)
        {
            return medicines.Remove(medicine);
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (Medicine med in medicines)
            {
                totalPrice += med.Price;
            }
            return totalPrice;
        }



        public Medicine GetMedicineWithHighestPrice()
        {
            return medicines.OrderBy(x => x.Price).ToList()[0];
        }

        public Medicine GetMedicineWithLowestPrice()
        {
            return medicines.OrderByDescending(x => x.Price).ToList()[0];
        }

        public void RenamePharmacy(string newName)
        {
            this.Name = newName;
        }

        public void SellAllMedicines()
        {
            medicines.Clear();
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append($"Pharmacy {name} has {medicines.Count} medicines and they are:");
            if (medicines.Count > 0)
            {
                foreach (Medicine med in medicines)
                {
                    s.Append("\n" + med.ToString());
                }
            }
            else { s.Append("\n" + "N/A"); }
            return s.ToString();
        }
    }
}
