using System;

namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            isPositive();
        }
        static void isPositive()
        {
            int a = int.Parse(Console.ReadLine());
            if (a>0)
            {
                Console.WriteLine($"The number {a} is positive. ");
            }
            else if(a==0)
            {
                Console.WriteLine($"The number {a} is zero. ");
            }
            else if (a<0)
            {
                Console.WriteLine($"The number {a} is negative. ");
            }
        }
    }
}
