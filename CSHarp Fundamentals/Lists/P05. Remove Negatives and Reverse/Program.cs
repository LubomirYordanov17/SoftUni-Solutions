using System;
using System.Linq;
using System.Collections.Generic;

namespace P05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> positiveNums=new List<int>();
            List<int> reversedNumbers=new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]>0)
                {
                    positiveNums.Add(numbers[i]);
                }
                
            }
            for (int i = positiveNums.Count-1; i>=0 ; i--)
            {
                reversedNumbers.Add(positiveNums[i]);
            }

            if (reversedNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", reversedNumbers));
            }
        }
    }
}
