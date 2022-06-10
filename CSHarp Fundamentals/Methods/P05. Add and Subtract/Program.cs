using System;

namespace P05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            
            int finalResult=Subtract(firstNum, secondNum, thirdNum);    
            Console.WriteLine(finalResult);
        }
        static int Add(int firstNum,int secondNum)
        {
            int result=firstNum + secondNum;
            return result;

        }
        static int Subtract(int firstNum, int secondNum,int thirdNum)
        {
            int result = Add(firstNum,secondNum)-thirdNum;
            return result;

        }
    }
}
