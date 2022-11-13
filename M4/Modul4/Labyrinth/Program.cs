using System;
using System.Collections.Generic;
using System.Linq;

namespace Labyrinth
{
    class Program
    {
        static char[,] lab;
        static List<char> path;
        static void Main(string[] args)
        {
            lab = GetLabyrinthInputDefault();
            path = new List<char>();
            FindPaths(0, 0, 'X');
        }
        private static void FindPaths(int row, int col, char direction)
        {
            if (!IsInBounds(row, col)) return;

            path.Add(direction);

            if (isExit(row, col)) PrintPath();

            else if (isFree(row, col))
            {
                Mark(row, col);
                FindPaths(row, col + 1, 'R');
                FindPaths(row + 1, col, 'D');
                FindPaths(row, col - 1, 'L');
                FindPaths(row - 1, col, 'U');
                Unmark(row, col);
            }
            path.RemoveAt(path.Count - 1);
        }
        private static void Unmark(int row, int col)
        {
            lab[row, col] = '-';
        }
        private static void Mark(int row, int col)
        {
            lab[row, col] = 'v';
        }
        private static bool isFree(int row, int col)
        {
            return lab[row, col] == '-';
        }
        private static bool isExit(int row, int col)
        {
            return lab[row, col] == 'e';
        }
        private static void PrintPath()
        {
            Console.WriteLine(string.Join("", path.Skip(1)));
        }
        private static bool IsInBounds(int row, int col)
        {
            return (row >= 0 && col >= 0 && row < lab.GetLength(0) && col < lab.GetLength(1));
        }
        private static char[,] GetLabyrinthInputDefault()
        {
            return new char[,]
            {
                {'-', '-', '-', '*', '-', '-', '-'},
                {'*', '*', '-', '*', '*', '-', '-'},
                {'-', '-', '-', '-', '-', '-', '-'},
                {'-', '*', '*', '*', '*', '*', '-'},
                {'-', '-', '-', '-', '-', '-', 'e'}
            };
        }
        private static int[,] GetMatrixInput()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(' ').Where(x => x != "").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            return matrix;
        }
    }
}
