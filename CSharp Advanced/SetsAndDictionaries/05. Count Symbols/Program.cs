using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SortedDictionary<char,int> keyValuePairs = new SortedDictionary<char,int>();
            string input = Console.ReadLine();
            char[] data =input.ToCharArray();
            for (int i = 0; i < data.Length; i++)
            {
                if (keyValuePairs.ContainsKey(data[i]))
                {
                    keyValuePairs[data[i]]++;
                }
                else
                {
                    keyValuePairs.Add(data[i], 1);
                }
            }
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
            
        }
    }
}
