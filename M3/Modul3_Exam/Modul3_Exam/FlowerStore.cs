using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegularExam
{
    class FlowerStore
    {
        private string name;
        private List<Flower> listOfFlowers;

        public string Name
        {
            get { return this.name; }
            set
            {

                if (value.Length < 6) throw new ArgumentException("Invalid flower store name!");
                else { name = value; }

            }
        }

        public FlowerStore(string name)
        {
            this.Name = name;
            listOfFlowers = new List<Flower>();
        }
        public void AddFLower(Flower flower)
        {
            listOfFlowers.Add(flower);
        }
        public bool SellFlower(Flower flower)
        {

            foreach (Flower f in listOfFlowers)
            {
                if (f.ToString() == flower.ToString())
                {
                    listOfFlowers.Remove(f);
                    return true;
                }
            }
            return false;

        }
        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (Flower flower in listOfFlowers)
            {
                totalPrice += flower.Price;
            }
            return totalPrice;
        }
        public Flower GetFlowerWithHighestPrice()
        {
            return listOfFlowers.OrderByDescending(x => x.Price).ToList()[0];
        }
        public Flower GetFlowerWithLowestPrice()
        {
            return listOfFlowers.OrderBy(x => x.Price).ToList()[0];
        }
        public void RenameFlowerStore(string newName)
        {
            this.Name = newName;
        }
        public void SellAllFlowers()
        {
            listOfFlowers.Clear();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (listOfFlowers.Count > 0)
            {
                sb.Append($"Flower store {Name} has {listOfFlowers.Count} flower/s:");
                foreach (Flower flower in listOfFlowers)
                {
                    sb.Append($"\nFlower {flower.Type} with color {flower.Color} costs {flower.Price:F2}");
                }
            }
            else sb.Append($"Flower store {Name} has no available flowers");
            return sb.ToString();
        }

    }
}
