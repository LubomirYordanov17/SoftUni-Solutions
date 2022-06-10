using System;

namespace P06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiddleIndex();
        }
        static void MiddleIndex()
        {
            string word = Console.ReadLine();
            string index = "";
            int half;
            int half2;
            if (word.Length % 2 == 0)
            {
                half = word.Length / 2;
                half2 = word.Length / 2 - 1;
                index += word[half2];
                index += word[half] ;
                
            }
            else
            {
                half = word.Length / 2 ;
                index += word[half];

            }
            Console.WriteLine(index);

        }
    }
}
