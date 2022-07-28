﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]numbersInput=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n=numbersInput[0];
            int s=numbersInput[1];
            int x=numbersInput[2];
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0;i < s; i++)
            {
                stack.Pop();
            }
            if (stack.Count==0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }


        }
    }
}
