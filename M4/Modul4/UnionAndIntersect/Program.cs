using System;
using System.Collections.Generic;
using System.Linq;

namespace UnionAndIntersect
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l1 = Console.ReadLine().Split().Where(x => x != "").Select(int.Parse).ToList();
            List<int> l2 = Console.ReadLine().Split().Where(x => x != "").Select(int.Parse).ToList();
            List<int> l3 = UnionWithAddRange(l1, l2);
            List<int> l4 = IntersectonWithAddRange(l1, l2);
            PrintList(l3);
            PrintList(l4);
        }
        public static List<int> UnionWithAddRange(List<int> l1, List<int> l2)
        {
            List<int> l = new List<int>(l1);
            l.AddRange(l2.Where(x => !l1.Contains(x)));                  
            return l;
        }
        public static List<int> Union(List<int> l1, List<int> l2)
        {           
            List<int> l = new List<int>(l1);           
            foreach (int element in l2)
            {
                if (!l.Contains(element)) l.Add(element);
            }
            return l;
        }
        public static List<int> Intersecton(List<int> l1, List<int> l2)
        {
            List<int> l = new List<int>();
            foreach (int element in l1)
            {
                if (l2.Contains(element)) l.Add(element);
            }
            return l;
        }
        public static List<int> IntersectonWithAddRange(List<int> l1, List<int> l2)
        {
            List<int> l = new List<int>();
            l.AddRange(l1.Where(x => l2.Contains(x)));
            return l;
        }
        public static void PrintList(List<int> l, string seperator = " ")
        {
            Console.WriteLine(string.Join(seperator, l));
        }
    }
}
