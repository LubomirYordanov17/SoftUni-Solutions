using System;
using System.Linq;
namespace P03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1=new int[n];
            int[] arr2=new int[n];
            for (int i = 1; i <= n; i++)
            {
                int[] currRum=Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                int firstN = currRum[0];
                int secondN = currRum[1];
                if (i%2!=0)
                {
                    arr1[i-1]=firstN;
                    arr2[i - 1] = secondN;
                }
                else
                {
                    arr1[i-1]=secondN;
                    arr2[i-1] = firstN;
                }

            }
            foreach (int i in arr1)
            {
                Console.Write ($"{i} ");
               
            }
            Console.WriteLine();
            foreach (int i in arr2)
            {
                Console.Write ($"{i} ");
            }
        }
    }
}
