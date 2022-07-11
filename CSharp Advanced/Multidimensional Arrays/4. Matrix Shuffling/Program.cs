using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] rowOfMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {

                    matrix[row, col] = rowOfMatrix[col];
                }
            }
            string[] command = Console.ReadLine().Split();
            while (command[0]!="END")
            {
                
                if (Validation(command,rows,cols))
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);
                    string oldIndexValue1 = matrix[row1, col1];
                    string oldIndexValue2 = matrix[row2, col2];

                    matrix[row1, col1] = oldIndexValue2;
                    matrix[row2, col2] = oldIndexValue1;

                }
                else
                {
                    Console.WriteLine("Invalid input!"); 
                    command = Console.ReadLine().Split();
                    continue;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(matrix[i,j]+" ");
                    }
                    Console.WriteLine();
                }
                command = Console.ReadLine().Split();
            }




        }
        public static bool Validation(string[]command,int rows,int cols)
        {
            if (command[0]=="swap"&&command.Length==5&&int.Parse(command[1])<=rows && int.Parse(command[3]) <= rows && int.Parse(command[2]) <= cols && int.Parse(command[4]) <= cols)
            {
                return true;
            }
            return false;
        }
    }
}
