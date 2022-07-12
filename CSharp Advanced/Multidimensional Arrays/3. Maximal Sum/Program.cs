using System;
using System.Linq;
using System.Numerics;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows=rowsAndCols[0];
            int cols=rowsAndCols[1];    
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] rowOfMatrix = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {

                    matrix[row, col] = rowOfMatrix[col];
                }
            }
            long biggerSum = long.MinValue;
            int savedRows = -1;
            int savedCols = -1;
            for (int row = 0; row < rows-2; row++)
            {
                
                for (int col = 0; col < cols-2; col++)
                {

                    if (matrix[row,col]+matrix[row,col+1]+matrix[row,col+2]+ matrix[row+1, col] + matrix[row+1, col + 1] + matrix[row+1, col + 2]+ matrix[row+2, col] + matrix[row+2, col + 1] + matrix[row+2, col + 2]>biggerSum)
                    {
                        biggerSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                        savedCols = col;
                        savedRows = row;
                    }
                }
            }
            Console.WriteLine($"Sum = {biggerSum}");
            for (int i = savedRows ; i < savedRows+3; i++)
            {
                Console.WriteLine($"{matrix[i,savedCols]} {matrix[i, savedCols+1]} {matrix[i, savedCols+2]}");
            }
        }
    }
}
