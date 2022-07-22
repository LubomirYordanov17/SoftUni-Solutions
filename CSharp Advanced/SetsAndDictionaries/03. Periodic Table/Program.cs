using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> elements = new SortedSet<string>();
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] element = Console.ReadLine().Split();
                for (int j = 0; j < element.Length; j++)
                {
                    elements.Add(element[j]);
                }
            }
            Console.WriteLine(string.Join(" ",elements));
        }
    }
}
