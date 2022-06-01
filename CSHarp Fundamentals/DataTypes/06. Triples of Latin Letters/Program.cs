using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int r = 0; r < num; r++)
                {
                    for (int j = 0; j < num; j++)
                    {
                        char a = (char)(i + 97);
                        char b = (char)(r + 97);
                        char c = (char)(j + 97);
                        Console.WriteLine($"{a}{b}{c}");
                    }
                }
            }
        }
    }
}
