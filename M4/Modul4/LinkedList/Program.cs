using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //                                                  PER

            /*LinkedList l = new LinkedList();
            l.Add("a");
            l.RemoveAt(0);
            l.Add("b");
            l.Add("c");
            l.Add("d");
            l.Add("e");
            l.Add("f");
            l.Remove("f");
            Console.WriteLine();           
            l.Reverse();
            PrintList(l);*/
            DoubleLinkedList<string> l = new DoubleLinkedList<string>();
            l.Add("a");
            l.Add("b");
            l.Add("c");
            l.Add("d");
            l.Add("e");
            l.Add("f");
            l.Insert("i", 3);
            l.Reverse();                                                           
            String[] array = l.ToArray();
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine();
        }
        public static void PrintList(LinkedList l)
        {                       
            for (int i = 0; i < l.Count; i++)
            {
                Console.Write(l[i] + "  ");
            }
        }
    }
}
