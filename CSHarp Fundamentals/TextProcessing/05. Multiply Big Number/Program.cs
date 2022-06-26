using System;
using System.Numerics;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger first = BigInteger.Parse(Console.ReadLine());
            BigInteger second =BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(first * second);
        }
    }
}
