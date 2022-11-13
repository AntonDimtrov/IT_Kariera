namespace Trains2
{
    class Train
    {
            public int Number { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public int Cars { get; set; }

            public Train(int number, string name, string type, int cars)
            {
                Number = number;
                Name = name;
                Type = type;
                Cars = cars;
            }

            public override string ToString()
            {
                return $"{Number} {Name} {Type} {Cars}";
            }
    }
}
