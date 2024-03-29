﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            Dictionary<int,int>numbers= new Dictionary<int,int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (numbers.ContainsKey(num))
                {
                    numbers[num]++;
                }
                else
                {
                    numbers.Add(num, 1);
                }

            }
            Console.WriteLine(numbers.First(x=>x.Value%2==0).Key);
        }
    }
}
