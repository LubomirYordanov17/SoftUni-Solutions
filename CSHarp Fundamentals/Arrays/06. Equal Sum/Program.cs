using System;
using System.Linq;
namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    rightSum += arr[j];
                }
                if (i > 0)
                {
                    for (int y = i - 1; y >= 0; y--)
                    {
                        leftSum += arr[y];
                    }
                }
                
                if (rightSum==leftSum)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    if (i==(arr.Length-1))
                    {
                        Console.WriteLine("no");
                        break;
                    }
                    leftSum = 0;
                    rightSum = 0;
                }
            }   
        }
    }
}
