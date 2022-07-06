using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            bool flag=false;
            for (int row = 0; row < n; row++)
            {
                string chhararr=Console.ReadLine(); 
                char[] rowOfMatrix = chhararr.ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowOfMatrix[col];
                    
                }
            }
            char symbol = Console.ReadLine()[0];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row,col]==symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
