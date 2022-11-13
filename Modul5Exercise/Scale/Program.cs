using System;

namespace Scale
{
    class Program
    {
        static void Main(string[] args)
        {
            Scale<string> s = new Scale<string>("aaa", "bb");
            Console.WriteLine(s.GetHeavier());
            (int a, string b) = A();
            
            Console.WriteLine(h.GetType());
            Console.WriteLine(a);
        }
        public static (int a, string b) A()
        {
            return (3, "asdasD");
        }
    }
}
