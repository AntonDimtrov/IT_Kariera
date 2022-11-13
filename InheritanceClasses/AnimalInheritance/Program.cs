using System;

namespace AnimalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            Cat c = new Cat();
            Puppy p = new Puppy();
            d.Eat();
            p.Eat();
            p.Wheep();
              
            

        }
    }
}
