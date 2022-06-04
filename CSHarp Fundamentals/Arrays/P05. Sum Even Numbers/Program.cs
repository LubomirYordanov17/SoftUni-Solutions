using System;

namespace P05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                double numbers= double.Parse(input[i]);
                if (numbers%2==0)
                {
                    sum += numbers;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
