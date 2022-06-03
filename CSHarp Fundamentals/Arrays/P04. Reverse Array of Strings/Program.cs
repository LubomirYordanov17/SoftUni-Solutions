using System;

namespace P04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rawInput = Console.ReadLine().Split();
            Array.Reverse(rawInput);
            Console.WriteLine(string.Join(" ",rawInput));
        }
    }
}
