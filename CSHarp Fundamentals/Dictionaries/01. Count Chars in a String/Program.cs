using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> counter = new Dictionary<char, int>();
            string text = Console.ReadLine();
            char[] chars = text.ToCharArray().Where(x=>x!=' ').ToArray();
            chars.ToList().ForEach(x =>
            {
                if (counter.ContainsKey(x))
                {
                    counter[x]++;
                }
                else
                {
                    counter.Add(x, 1);
                }
            });
            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
