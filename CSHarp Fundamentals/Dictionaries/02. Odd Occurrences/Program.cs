using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string, int> occurencies = new Dictionary<string, int>();
            foreach (var word in words)
            {
                string wordInLower=word.ToLower();  
                if (occurencies.ContainsKey(wordInLower))
                {
                    occurencies[wordInLower] += 1;
                }
                else
                {
                    occurencies.Add(wordInLower, 1);
                }
            }
            
            string[]result=occurencies.Where(i=>i.Value%2!=0).Select(i=>i.Key).ToArray();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
