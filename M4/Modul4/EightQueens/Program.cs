using System;
using System.Collections.Generic;

namespace EightQueens
{
    class Program
    {
        private static int solutions = 0;
        private const int size = 8;
        private static bool[,] board = new bool[size, size];
        private static HashSet<int> attackedCols = new HashSet<int>();
        private static HashSet<int> attackedDiagonalsL = new HashSet<int>();// \
        private static HashSet<int> attackedDiagonalsR = new HashSet<int>();// /
        static void Main(string[] args)
        {
            PlaceQueen(0);
            Console.WriteLine($"Solutons: {solutions}");
        }
        private static void PlaceQueen(int row)
        {
            if (row == 8)
            {
                PrintSolution();
                solutions++;
            }
            for (int col = 0; col < 8; col++)
            {
                if (CanPlaceQueen(row, col))
                {
                    MarkAllAtackedPositions(row, col);
                    PlaceQueen(row + 1);
                    UnMarkAllAtackedPositions(row, col);
                }
            }
        }
        private static void MarkAllAtackedPositions(int row, int col)
        {
            board[row, col] = true;
            attackedCols.Add(col);
            attackedDiagonalsL.Add(col - row);
            attackedDiagonalsR.Add(row + col);
        }
        private static void UnMarkAllAtackedPositions(int row, int col)
        {
            board[row, col] = false;
            attackedCols.Remove(col);
            attackedDiagonalsL.Remove(col - row);
            attackedDiagonalsR.Remove(row + col);
        }
        private static bool CanPlaceQueen(int row, int col)
        {
            bool canPlace = true;
            if (attackedCols.Contains(col) ||
                attackedDiagonalsL.Contains(col - row) ||
                attackedDiagonalsR.Contains(row + col)) canPlace = false;
            return canPlace;
        }
        private static void PrintSolution()
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(board[row, col] ? "+ " : "- ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
