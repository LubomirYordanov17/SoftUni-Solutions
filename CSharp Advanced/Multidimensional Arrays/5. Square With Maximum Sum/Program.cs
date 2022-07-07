using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            int[,] matrix = new int[rows, cols];
            int matrixSum = 0;
            for (int row = 0; row < rows; row++)
            {
                int[] rowOfMatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowOfMatrix[col];
                    
                }
            }
            int sumbiggersum = int.MinValue;
            int indexRow = -1;
            int indexCol = -1;
            for (int row = 0; row < rows-1; row++)
            {

                int sum = 0;
                for (int col = 0; col < cols-1; col++)
                {
                    sum=matrix[row, col]+matrix[row,col+1] + matrix[row+1, col ] + matrix[row+1, col + 1];
                    if (sumbiggersum<sum)
                    {
                        sumbiggersum = sum;
                        indexRow = row;
                        indexCol = col;
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{matrix[indexRow, indexCol]} {matrix[indexRow, indexCol + 1]}");
                indexRow++;
            }
            Console.WriteLine(sumbiggersum);
        }
    }
}
