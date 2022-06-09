using System;
using System.Linq;
namespace P02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
           int vowelsCount=VowelsCount(word);
            Console.WriteLine(vowelsCount);
        }
        static int VowelsCount(string word)
        {
            char[] vowels = new char[] {'a', 'e', 'i', 'o','u' };
            int vowelsCount =0;
            foreach (char ch in word.ToLower())
            {
                if (vowels.Contains(ch))
                {
                    vowelsCount++;

                }
            }
            return vowelsCount; 
        }
    }
}
