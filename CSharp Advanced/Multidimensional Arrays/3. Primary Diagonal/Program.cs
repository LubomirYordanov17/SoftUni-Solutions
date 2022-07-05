using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            int sumOfDiagonal = 0;
            for (int row = 0; row < n; row++)
            {
                int[] rowOfMatrix = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowOfMatrix[col];
                    if (row==col)
                    {
                        sumOfDiagonal += rowOfMatrix[col];
                    }
                }
            }
            Console.WriteLine(sumOfDiagonal);
        }
    }
}
