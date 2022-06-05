using System;

namespace P02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstRow=Console.ReadLine().Split(' ');
            string[] secondRow=Console.ReadLine().Split(' ');

            for (int i = 0; i < secondRow.Length; i++)
            {
                string secondIn = secondRow[i];
                for (int j = 0; j < firstRow.Length; j++)
                {
                    string firstIn = firstRow[j];
                    if (secondIn==firstIn)
                    {
                        Console.Write($"{secondIn} ");
                    }
                }
            }

        }
    }
}
