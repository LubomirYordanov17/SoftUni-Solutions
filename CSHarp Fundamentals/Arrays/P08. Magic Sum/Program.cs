using System;
using System.Linq;
namespace P08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
           
            int currSum = int.Parse(Console.ReadLine());
            string result=string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j=i+1; j < arr.Length; j++)
                {
                    if (arr[i]+arr[j]==currSum)
                    {
                        result += $"{arr[i]} {arr[j]}\n";
                        
                    }
                }
                
            }
            Console.Write(result);
        }
    }
}
