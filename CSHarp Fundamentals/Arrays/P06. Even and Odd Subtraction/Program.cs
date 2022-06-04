using System;

namespace P06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double sum1 = 0;
            double sum2 = 0;
            for (int i = 0; i < input.Length; i++)
            {
                double numbers = double.Parse(input[i]);
                if (numbers % 2 == 0)
                {
                    sum1 += numbers;
                }
                else
                {
                    sum2 += numbers;
                }
            }
            Console.WriteLine(sum1-sum2);
        }
    }
}
