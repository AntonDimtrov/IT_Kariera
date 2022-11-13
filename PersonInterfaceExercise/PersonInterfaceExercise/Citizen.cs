using PersonInterfaceExercise.Interfaces;

namespace PersonInterfaceExercise

{
    internal class Citizen : IPerson, IIdentifiable, IBirthable
    {
        private string _name;
        private int _age;
        private string _id;
        private string _birthdate;

        public Citizen(string name, int age, string id, string birthdate)
        {
            _name = name;
            _age = age;
            _id = id;
            _birthdate = birthdate;
        }

        public string Name => _name;
        public int Age => _age;
        public string id => _id;
        public string birthday => _birthdate;
    }
}