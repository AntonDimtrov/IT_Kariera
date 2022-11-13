using System;
using System.Collections.Generic;

namespace SpecialWords_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> special = new List<string>();
            List<string> manyA = new List<string>();
            List<string> notSpecial = new List<string>();
            for(int i = 0; i < n; i++)
            {    bool ordinary = true;
                string word = Console.ReadLine();
                if (word[0] == word[word.Length - 1]) { special.Add(word); ordinary = false; }
                int numofA = 0;
                foreach(char c in word)
                {
                    if (c == 'a') numofA++;
                }
                if (numofA > 1) { manyA.Add(word); ordinary = false; }
                if (ordinary) notSpecial.Add(word);
            }
            Console.WriteLine(string.Join(" ",special));
            Console.WriteLine(string.Join(" ", manyA));
            Console.WriteLine(string.Join(" ", notSpecial));
        }
    }
}
