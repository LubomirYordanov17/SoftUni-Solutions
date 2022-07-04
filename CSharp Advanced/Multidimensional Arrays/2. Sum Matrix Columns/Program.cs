using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] rowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            int[,] matrix = new int[rows, cols];
            int[]colSum=new int[cols];
            for (int row = 0; row < rows; row++)
            {
                int[] rowOfMatrix = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowOfMatrix[col];
                    colSum[col] += rowOfMatrix[col];
                }
            }
            Console.WriteLine(string.Join("\n",colSum));
            

        }
    }
}
