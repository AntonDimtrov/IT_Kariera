using System;
using System.Linq;

namespace Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = input[input.Length - 1];
            int[] positions = new int[input.Length - 1];
            int steps = 0;
            for(int i = 0; i < positions.Length; i++)
            {
                positions[i] = input[i];                
            }           
            while (positions[index]!=0)
            {               
                for (int i = 0; i < positions.Length; i++)
                {   
                    positions[i]--;
                }
                if (positions[index] == 0) break;
                for(int i = 0; i < positions.Length; i++)
                {
                    if (positions[i] == 0) positions[i] = input[i];
                }
                index = int.Parse(Console.ReadLine());               
                steps++;
            }
            Console.WriteLine(string.Join(" ", positions)+"\n"+steps);

        }
    }
}
