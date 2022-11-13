using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Fridge
    {
        List<string> v = new List<string>();

        public Fridge() { }

        public void AddProduct(string ProductName)
        {
            this.v.Add(ProductName);
        }

        public string[] CookMeal(int start, int end)
        {
            List<string> help = new List<string>();
            for (int i = start; i <= Math.Min(end, this.v.Count - 1); i++)
            {
                help.Add(this.v[i]);
            }

            return help.ToArray();
        }

        public string RemoveProductByIndex(int index)
        {
            if (index < this.v.Count)
            {
                string ans = this.v[index];
                this.v.RemoveAt(index);

                return ans;
            }
            else
            {
                return null;
            }
        }

        public string RemoveProductByName(string name)
        {
            int index = this.v.Count;
            for (int i = 0; i < this.v.Count; i++)
            {
                if (this.v[i] == name)
                {
                    index = i;
                    break;
                }
            }

            return RemoveProductByIndex(index);
        }

        public bool CheckProductIsInStock(string name)
        {
            for (int i = 0; i < this.v.Count; i++)
            {
                if (this.v[i] == name)
                {
                    return true;
                }
            }

            return false;
        }

        public string[] ProvideInformationAboutAllProducts()
        {
            string[] products = CookMeal(0, this.v.Count - 1);
            for (int i = 0; i < products.Length; i++)
            {
                products[i] = "Product " + products[i];
            }

            return products;
        }

    }
}
