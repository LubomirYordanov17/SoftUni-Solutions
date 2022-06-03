using System;

namespace P03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rawInput = Console.ReadLine().Split();
            double[] numbers = new double[rawInput.Length];
            for (int i = 0; i < rawInput.Length; i++)
            {
                numbers[i] = double.Parse(rawInput[i]);
                
            }
            for (int i = 0; i < rawInput.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
