using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exam
{
    class Program
    {
        static DataList list = new DataList();
        static void Main(string[] args)
        {
            string line;
            while ("END" != (line = Console.ReadLine()))
            {
                string[] cmdArgs = line.Split(' ');
                switch (cmdArgs[0])
                {
                    case "Add":
                        AddElement(cmdArgs[1]);
                        break;
                    case "Resize":
                        ResizeStructure();
                        break;
                    case "Remove":
                        RemoveByIndex(cmdArgs[1]);
                        break;
                    case "Check":
                        Contains(cmdArgs[1]);
                        break;
                    case "Replace":
                        ReplaceLastWithFirst();
                        break;
                    case "Info":
                        StructureInfo();
                        break;
                }
            }

        }
        private static void ReplaceLastWithFirst()
        {
            list.ReplaceLastWithFirst();
        }
        private static void StructureInfo()
        {
            StringBuilder info = list.Info();
            Console.WriteLine(info.ToString().Trim());
        }
        private static void RemoveByIndex(string index)
        {
            bool released = list.RemoveByIndex(int.Parse(index));
            Console.WriteLine(released ? "Removed element" : "Could not remove element");
        }
        private static void Contains(string element)
        {
            bool contained = list.Contains(element);
            Console.WriteLine(contained ? "Element is present" : "Element is not present");
        }
        private static void ResizeStructure()
        {
            list.Resize();
        }
        private static void AddElement(string element)
        {
            list.Add(element);
        }
    }
}
