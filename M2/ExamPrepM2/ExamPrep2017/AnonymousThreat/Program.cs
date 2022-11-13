using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            string command = Console.ReadLine();
            while (command != "3:1")
            {
                string[] comArgs = command.Split(' ');
                string com = comArgs[0];
                int num1 = int.Parse(comArgs[1]);
                int num2 = int.Parse(comArgs[2]);
                if (num1 < 0) num1 = 0;
                switch (com)
                {
                    case "merge":
                        int startIndex = num1;
                        int endIndex = num2;
                        if (endIndex > list.Count - 1) endIndex = list.Count - 1;
                        for (int i = 0; i < endIndex - startIndex; i++)
                        {
                            list[startIndex] += list[startIndex + 1];
                            list.RemoveAt(startIndex + 1);
                        }
                        break;
                    case "divide":
                        int index = num1;
                        int parts = num2;
                        int partLength = list[index].Length / parts;
                        int remainder = list[index].Length % parts;
                        bool unevenParts = list[index].Length % parts != 0 ? true : false;

                        for (int i = 0; i < list[index].Length; i += partLength)
                        {
                            string s;
                            if (unevenParts && i == list[index].Length - partLength - remainder)
                            {

                                s = list[index].Substring(i, partLength + remainder);
                                i = list[index].Length;
                            }
                            else
                            {
                                s = list[index].Substring(i, partLength);
                            }
                            list.Insert(index, s);
                            index++;
                        }
                        list.RemoveAt(index);
                        break;
                    default: break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
