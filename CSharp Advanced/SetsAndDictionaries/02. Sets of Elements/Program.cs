using System;
using System.Collections.Generic;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]input=Console.ReadLine().Split(' ');    
            int n1=int.Parse(input[0]);
            int n2=int.Parse(input[1]);
            
            HashSet<int> numbers1 = new HashSet<int>();
            HashSet<int> numbers2 = new HashSet<int>();
            for (int i = 0; i < n1; i++)
            {
                int n = int.Parse(Console.ReadLine());
                numbers1.Add(n);

            }
            for (int i = 0; i < n2; i++)
            {
                int n = int.Parse(Console.ReadLine());
                numbers2.Add(n);

            }
            numbers1.IntersectWith(numbers2);
            Console.WriteLine(String.Join(" ",numbers1));
        }
    }
}
