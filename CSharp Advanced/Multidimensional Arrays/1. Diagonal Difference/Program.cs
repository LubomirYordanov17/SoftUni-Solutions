using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                int[] rowOfMatrix = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    
                    matrix[row, col] = rowOfMatrix[col];
                }
            }
            int sumOfFirstDiagonal = 0;
            int sumOfSecondDiagonal = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row==col)
                    {
                        sumOfFirstDiagonal+=matrix[row, col];
                    }
                    if (row+col==n-1)
                    {
                        sumOfSecondDiagonal += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(Math.Abs(sumOfFirstDiagonal-sumOfSecondDiagonal));
        }
    }
}
