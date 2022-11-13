using System;
using System.Linq;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plane = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = int.Parse(Console.ReadLine());
            int damage = 1;

            string command = Console.ReadLine();
            while (command != "Supernova")
            {
                string direction = command.Split(' ')[0];
                int steps = int.Parse(command.Split(' ')[1]);
                int increaseIndexBy = 1;
                if (direction == "left") increaseIndexBy = -1;
                for (int step = 0; step < steps; step++)
                {
                    int indexA = index + increaseIndexBy;
                    if (indexA < 0) { index = plane.Length - 1; damage++; }
                    else if (indexA > plane.Length - 1) {index = 0; damage++; }
                    else index = indexA;
                    plane[index] -= damage;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", plane));
        }
    }
}
