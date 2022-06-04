using System;

namespace P07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();
            double sum1 = 0;
            double WrongIndex = -1;
           
            for (int i = 0; i < input.Length; i++)
            {
                double numbers = double.Parse(input[i]);
                double numbers2 = double.Parse(input2[i]);
                sum1 += numbers;

                if (numbers!=numbers2)
                {
                    WrongIndex = i;
                    break;
                }

            }
            if (WrongIndex==-1)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum1}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {WrongIndex} index");
            }
        }
    }
}
