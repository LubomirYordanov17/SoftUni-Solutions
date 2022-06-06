using System;
using System.Linq;
namespace P04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr=Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int firstEl = arr[0];
                for (int j = 0; j < arr.Length-1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length-1] = firstEl;
            }
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
