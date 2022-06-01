using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int singleDigit = 0;
            int sum = 0;
            for (int i = num; i > 0; i/=10)
            {
                singleDigit = i % 10;
                sum += singleDigit;
                
            }
            Console.WriteLine(sum);
        }
    }
}
