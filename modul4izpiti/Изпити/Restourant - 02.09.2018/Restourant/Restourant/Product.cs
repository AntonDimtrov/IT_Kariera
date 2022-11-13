namespace Restourant
{
    class Product
    {
        public string Name { get; set; }
        public Product Next { get; set; }

        public Product(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Product {Name}";
        }
    }
}
