using System;
using System.Collections.Generic;
using System.Linq;

namespace ReversedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //                                              PERFECT
            ReversedList<int> rl = new ReversedList<int>();
            List<int> l = new List<int>();
            rl.Add(1);
            rl.Add(2);
            rl.Add(3);
            rl.Add(4);
            rl.PrintR();
            rl.Remove(4);
            rl.RemoveAt(2);
            rl.Add(6);
            Console.WriteLine(rl.IndexOf(3));
            Console.WriteLine(rl.Contains(4));



            rl.PrintR();
            
            Console.WriteLine();
        }
    }
}
