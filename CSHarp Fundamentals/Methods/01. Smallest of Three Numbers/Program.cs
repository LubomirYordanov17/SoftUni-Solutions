using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinNumber();
            
        }
        static void MinNumber()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int minNum = 0;
            if (a <= b && a <= c)
            {
                minNum = a;
            }
            if (b <= a && b<=c)
            {
                minNum=b; 
            }
            if (c <= a && c <= b)
            {
                minNum=c;
            }
            
            Console.WriteLine(minNum);
        }
    }
}
