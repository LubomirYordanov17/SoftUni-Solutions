using System;

namespace P03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintASCII();
        }
        static void PrintASCII()
        {
            char start=char.Parse(Console.ReadLine());
            char end=char.Parse(Console.ReadLine());
            
            int startInt=(int)start;
            int endInt=(int)end;
            if (startInt<endInt)
            {

                for (int i = startInt + 1; i < endInt; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = endInt + 1; i < startInt; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}
