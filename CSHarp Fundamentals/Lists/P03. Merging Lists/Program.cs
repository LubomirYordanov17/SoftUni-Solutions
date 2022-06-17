using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result =new List<int>();
            int biggerCount = 0;

            if (numbers.Count>=numbers2.Count)
            {
                biggerCount=numbers.Count;
            }
            else
            {
                biggerCount = numbers2.Count;
            }
            for (int i = 0; i < biggerCount; i++)
            {
                if (i<numbers.Count)
                {
                    result.Add(numbers[i]);
                }
                if (i < numbers2.Count)
                {
                    result.Add(numbers2[i]);
                }
                
            }
            Console.WriteLine(String.Join(" ",result));

        }
    }
}
