using System;
using System.Linq;
namespace P05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
               .Split() 
               .Select(int.Parse)
               .ToArray();
            int[] topInteger=new int[arr.Length];
            int topIntegerIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];
                bool isTopInteger = true;
                for (int j = i+1; j < arr.Length; j++)
                {
                    int nextNum=arr[j];
                    if (currNum <= nextNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                    
                    
                }
                if (isTopInteger == true)
                {
                    topInteger[topIntegerIndex] = currNum;
                    topIntegerIndex++;
                }

            }
            for (int i = 0; i < topIntegerIndex; i++)
            {
                int currTopinteger = topInteger[i];
                Console.Write($"{currTopinteger} ");
            }
        }
    }
}
