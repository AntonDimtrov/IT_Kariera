using System;

namespace BetterList
{
    class Program
    {
        static MyList<double> ml = new MyList<double>();
        static void Main(string[] args)
        {
            string[] cmdArgs = Console.ReadLine().Split(" ");
            string command = cmdArgs[0];

            while (!command.Equals("END"))
            {
                switch (command)
                {
                    case "Add":
                        
                        Add(double.Parse(cmdArgs[1]));
                        break;
                    case "Remove":
                        Remove(int.Parse(cmdArgs[1]));
                        break;
                    case "Contains":
                        Contains(double.Parse(cmdArgs[1]));
                        break;
                    case "Swap":
                        Swap(int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
                        break;
                    case "Greater":
                        Greater(double.Parse(cmdArgs[1]));
                        break;
                    case "Max":
                        Max();
                        break;
                    case "Min":
                        Min();
                        break;
                    case "Print":
                        Print();
                        break;
                    case "Sort":
                        Sort();
                        break;
                    case "SortDescending":
                        SortDescending();
                        break;
                    default:
                        Console.WriteLine($"Command ' {command} ' does not exist!");
                        break;
                }

                cmdArgs = Console.ReadLine().Split(" ");
                command = cmdArgs[0];
            }
        }

        public static void Add(double element)
        {
            ml.Add(element);
        }

        public static void Remove(int index)
        {
            ml.Remove(index);
        }

        public static void Contains(double element)
        {
            Console.WriteLine(ml.Contains(element));
        }

        public static void Swap(int index, int otherIndex)
        {
            ml.Swap(index, otherIndex);
        }

        public static void Greater(double element)
        {
            Console.WriteLine(ml.CountGreaterThan(element));
        }

        public static void Max()
        {
            Console.WriteLine(ml.Max());
        }

        public static void Min()
        {
            Console.WriteLine(ml.Min());
        }

        public static void Print()
        {
            ml.Print();
        }

        public static void Sort()
        {
            ml.Sort();
            ml.Print();
        }
        public static void SortDescending()
        {
            ml.SortDescending();
            ml.Print();
        }
        public static void testing()
        {
            MyList<int> mll = new MyList<int>();

        }
    }

}
