using System;
using System.Collections.Generic;
using System.Text;
using BorderControl.Interfaces;

namespace BorderControl.Classes
{
    public class Rebel : IBuyer, IInhabitant
    {
        private const int foodIncrease = 5;

        private string name;
        private int age;
        private string group;
        private int food;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
            Food = 0;
        }
        public int FoodIncrease => foodIncrease;
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Group { get => group; set => group = value; }
        public int Food { get => food; private set => food = value; }

        public void BuyFood()
        {
            Food += foodIncrease;
        }
    }
}
