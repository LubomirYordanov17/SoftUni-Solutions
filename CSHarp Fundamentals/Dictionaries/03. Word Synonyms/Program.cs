using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            Dictionary<string,List<string>> words = new Dictionary<string,List<string>>();
            for (int i = 0; i < number; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (words.ContainsKey(word))
                {
                    words[word].Add(synonym);
                }
                else
                {
                    List<string> list = new List<string>();
                    list.Add(synonym);
                    words.Add(word, list);
                }
            }
            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ",word.Value)}");
            }
        }
    }
}
