using System;

namespace P08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int firstNum=int.Parse(Console.ReadLine());
           int secondNum=int.Parse(Console.ReadLine());
            double result=FactorialDivision(firstNum, secondNum);
            Console.WriteLine($"{result:f2}");
        }
        static double FactorialDivision(int firstNum,int secondNum)
        {
            double sum1 = firstNum;
            double sum2 = secondNum;
            double sum = 0;
            for (int i = firstNum-1;i>=1; i--)
            {
                sum1 *= i;
            }
            for (int i = secondNum-1; i >=1; i--)
            {
                sum2 *= i;
            }
            sum = sum1 / sum2;
            return sum;
        }
    }
}
