using System;

namespace P07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix();
        }
       static void Matrix()
        {
            int num=int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}
