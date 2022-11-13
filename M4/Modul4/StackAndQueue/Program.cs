using System;
using System.Collections.Generic;
using System.Linq;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            //Longest series on numbers (depending on the sign)
            List<int> l = Console.ReadLine().Split().Where(x=>x!="").Select(int.Parse).ToList();
            int index = 0, length = 1, maxLength = 1;
            for (int i = 0; i < l.Count - 1; i++)
            {
                if (l[i] /*= + - > < <= >=*/-1== l[i + 1]) length++;
                else
                {
                    if (length > maxLength)
                    {
                        index = i - length+1;
                        maxLength = length;

                    }
                    length = 1;
                }
            }
            if (length > maxLength)
            {
                index = l.Count - length ;
                maxLength = length;
            }
            for (int i = index; i < index + maxLength; i++)
            {
                Console.Write(l[i]+" ");
            }










            //                                                    n -> m
            /*int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Console.Write(n);
            while (n != m/2)
            {
                if (n * 2 <=m/2) n *= 2;
                else if (n + 2 <=m/2) n += 2;
                else n += 1;
                Console.Write($"->{n}");
            }
            if (m % 2 == 0) { n++; Console.Write($"->{n}"); }
            n *= 2;
            Console.Write($"->{n}");*/














            //                                      1 + (2 + (3 + 4) + (5 + (6 + 7)) + 8) + 9
            /*string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(') indexes.Push(i);
                else if (input[i] == ')')
                {

                    if (indexes.Count > 0)
                    {
                        int startIndex = indexes.Pop();
                        Console.WriteLine(input.Substring(startIndex, i - startIndex + 1));
                    }
                }
            }*/
        }
    }
}
