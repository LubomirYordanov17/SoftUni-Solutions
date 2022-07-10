using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string[,] matrix = new string[rowsAndCols[0], rowsAndCols[1]];
            for (int row = 0; row < rowsAndCols[0]; row++)
            {
                string[] rowOfMatrix = Console.ReadLine().Split(" ");
                for (int col = 0; col < rowsAndCols[1]; col++)
                {

                    matrix[row, col] = rowOfMatrix[col];
                }
            }
            int count = 0;
            for (int row = 0; row < rowsAndCols[0]-1; row++)
            {
                
                for (int col = 0; col < rowsAndCols[1]-1; col++)
                {

                    if (matrix[row,col]== matrix[row, col+1]&& matrix[row, col] ==matrix[row+1, col] && matrix[row, col] == matrix[row+1, col+1])
                    {
                        count++; 
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
