using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][]matrix=new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            for (int row = 0; row < rows-1; row++)
            {
                if (matrix[row].Length==matrix[row+1].Length)
                {
                    matrix[row] = matrix[row].Select(e => e * 2).ToArray();
                    matrix[row+1] = matrix[row+1].Select(e => e * 2).ToArray();
                }
                else
                {
                    matrix[row] = matrix[row].Select(e => e / 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(e => e / 2).ToArray();
                }
            }
            string command = Console.ReadLine();

            while (command!="End")
            {
                string action=command.Split(' ')[0];
                int row=int.Parse(command.Split(' ')[1]);
                int col=int.Parse(command.Split(' ')[2]);
                int value=int.Parse(command.Split(' ')[3]);
                if (action=="Add")
                {
                    if (row>=0&&row<rows&&col>=0&&col<matrix[row].Length)
                    {
                        matrix[row][col] = matrix[row][col] + value;
                    }

                }
                else if (action== "Subtract")
                {
                    if (row >= 0 && row < rows && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] = matrix[row][col] - value;
                    }
                }




                command = Console.ReadLine();
            }

            foreach (int[] row in matrix)
            {
                Console.WriteLine(String.Join(" ",row));
            }

        }
    }
}
