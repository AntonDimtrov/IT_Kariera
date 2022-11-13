using System;
using System.Collections.Generic;

namespace Restourant
{
    class Fridge
    {
        private Product head;
        private Product tail;
        private int count;
        public int Count
        {  //TODO: Добавете вашия код тук …
           get { return count;  }
           set { count = value; }
        }

        public Fridge()
        {
            head = null; //TODO
            tail = null; //TODO
            Count = 0;
        }

        public void AddProduct(string ProductName)
        {   //TODO: Добавете вашия код тук …

            var product = new Product(ProductName);
            if (head == null)
            {
                head = tail = product;
            }
            else
            {              
                tail.Next = product;
                tail = product;
            }
            Count++;
        }

        public string[] CookMeal(int start, int end)
        {   //TODO: Добавете вашия код тук …
            int index = 0;
            Product current = head;
            while (index < start)
            {
                index++;
                current = current.Next;
            }
            if (end > Count) end = Count;

            var result = new List<string>();
            for (int i = start; i < end; i++)
            {
                result.Add(current.Name);
                current = current.Next;
            }
            return result.ToArray();
        }

        public string RemoveProductByIndex(int index)
        {   //TODO: Добавете вашия код тук …

            if (index >= Count || index < 0)
                throw new InvalidOperationException();
            int currInd = 0;
            Product current = head;
            Product prev = null;           
            while (currInd != index)
            {
                    prev = current;
                    current = current.Next;         
                    currInd++;
            }
            string removed = current.Name;
            if (current == head)head = head.Next;
            else prev.Next = current.Next;
            if (current == tail) tail = prev;
            //if (head == null) tail = null;
            Count--;
            return removed;
        }

        public string RemoveProductByName(string name)
        {   //TODO: Добавете вашия код тук …

            Product current = head;
            int currInd = 0;
            while (current != null && current.Name != name)
            {
                current = current.Next;
                currInd++;
            }
            if (current == null) return null;
            else return RemoveProductByIndex(currInd);
        }

        public bool CheckProductIsInStock(string name)
        {   //TODO: Добавете вашия код тук …

            Product current = head;
            while (current != null)
            {
                if (current.Name == name)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public string[] ProvideInformationAboutAllProducts()
        {   //TODO: Добавете вашия код тук …

            var allProducts = new List<string>();
            Product current = head;
            while (current != null)
            {
                allProducts.Add(current.ToString());
                current = current.Next;
            }
            return allProducts.ToArray();
        }
    }
}
