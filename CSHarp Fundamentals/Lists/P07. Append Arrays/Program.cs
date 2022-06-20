using System;
using System.Linq;
using System.Collections.Generic;

namespace P07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .ToList();
            List<string> numbers2 = new List<string>();
            List<string> numbers3 = 


            //for (int i = numbers.Count-1; i >=0; i--)
            //{
            //    numbers2.Add(numbers[i]);
            //}
            Console.WriteLine(String.Join(" ",numbers2));
            
        }
    }
}
