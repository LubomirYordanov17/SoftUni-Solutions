using System;

namespace P03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }
        static void Calculator()
        {
            string word = Console.ReadLine();
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int sum = 0;
            if (word== "add")
            {
                Console.WriteLine(   sum = a + b);
            }
            else if (word == "multiply")
            {
                Console.WriteLine(   sum = a * b);
            }
            else if (word== "subtract")
            {
                Console.WriteLine(   sum = a - b);
            }
            else if (word== "divide")
            {
                Console.WriteLine(   sum = a / b);
            }
        }
    }
}
