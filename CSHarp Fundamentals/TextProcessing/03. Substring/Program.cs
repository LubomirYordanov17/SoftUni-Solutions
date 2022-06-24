using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string wordToRemove=Console.ReadLine();
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                if (word.Contains(wordToRemove))
                {
                    int index = word.IndexOf(wordToRemove);
                    word=word.Remove(index,wordToRemove.Length);
                }

            }
            Console.WriteLine(word);
        }
    }
}
