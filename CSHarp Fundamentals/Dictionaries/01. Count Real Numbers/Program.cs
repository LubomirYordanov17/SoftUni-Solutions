using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            SortedDictionary<int,int>countNums=new SortedDictionary<int,int>(); 
            foreach (int number in numbers)
            {
                if (countNums.ContainsKey(number))
                {
                    countNums[number]+=1;
                }
                else
                {
                    countNums.Add(number, 1);
                }
            }
            foreach (var item in countNums)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
