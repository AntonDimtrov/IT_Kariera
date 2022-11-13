using System;
using System.Collections.Generic;
using System.Text;
using BorderControl.Interfaces;

namespace BorderControl
{
    internal class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        private const int foodIncrease = 10;

        private string name;
        private int age;
        private string id;
        private DateTime birthday;
        private int food;

        public Citizen(string name, int age, string id, DateTime birthday)
        {
            Name = name;
            Age = age;
            ID = id;
            Birthday = birthday;
            Food = 0;
        }

        public int FoodIncrease => foodIncrease;

        public int Age { get => age; private set => age = value; }
        public string ID { get => this.id; set => id = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Name { get => name; set => name = value; }
        public int Food { get => food; private set => food = value; }

        public void BuyFood()
        {
            Food += FoodIncrease;
        }
    }
}
