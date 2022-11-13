using System;

namespace MyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<string> ms = new ArrayStack<string>();
   
            //                                                  PERFECT
            ms.Push("a");
            Console.WriteLine(ms.Count);
            Console.WriteLine(ms.GetCapacity());
            ms.Push("n");
            ms.Push("t");
            Console.WriteLine(ms.Peek());
            Console.WriteLine(ms.Count);
            Console.WriteLine(ms.GetCapacity());
            string[] array = ms.ToArray();
            Console.WriteLine(string.Join(" ", array));            
            while (ms.Count > 0)
            {
                Console.WriteLine(ms.Pop());
            }
            Console.WriteLine();
            


        }
    }
}
