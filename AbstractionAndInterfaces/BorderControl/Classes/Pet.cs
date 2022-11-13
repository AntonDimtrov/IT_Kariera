using System;
using System.Collections.Generic;
using System.Text;
using BorderControl.Interfaces;

namespace BorderControl.Classes
{
    class Pet : IBirthable
    {
        private string _name;
        private DateTime _birthday;

        public Pet(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public string Name { get => _name; set => _name = value; }
        public DateTime Birthday { get => _birthday; set => _birthday = value; }
    }
}
