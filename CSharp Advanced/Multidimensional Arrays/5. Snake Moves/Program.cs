using System;

namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rows=int.Parse(input.Split()[0]);
            int cols=int.Parse(input.Split()[1]);
            char [,]matrix=new char[rows,cols];
            string snake = Console.ReadLine();
            int index = 0;
            for (int row = 0; row < rows; row++)
            {
                if (row%2==0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snake[index];
                        index++;
                        if (index>=snake.Length)
                        {
                            index = 0;
                        }
                    }
                }
                else
                {
                    for (int col = cols-1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[index];
                        index++;
                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
