using System;
using System.Linq;
namespace P07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int count = 0;
            int biggestCount = 0;
            string currResult = string.Empty;
            string result = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] != arr[j])
                    {
                        break;
                    }
                    else
                    {
                        count++;
                        currResult = currResult + $"{arr[j]} ";
                    }
                    if (biggestCount < count)
                    {
                        biggestCount = count;
                        result = currResult+$"{arr[j]}";
                    }

                }
                currResult = string.Empty;
                count = 0;
            }
            Console.WriteLine(result);
        }
    }
}
