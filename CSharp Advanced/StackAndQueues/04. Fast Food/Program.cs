using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood=int.Parse(Console.ReadLine());
            int[]food=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> q=new Queue<int>();

            for (int i = 0; i < food.Length; i++)
            {
                q.Enqueue(food[i]);
            }
            int maxnum = int.MinValue;
            while (quantityOfFood>=0)
            {
                if (q.Count == 0)
                {
                    Console.WriteLine(maxnum);
                    Console.WriteLine("Orders complete");
                    return;
                }
                int order = q.Peek();
                if (order>maxnum)
                {
                    maxnum = order;
                }
                if (quantityOfFood <order)
                {
                    Console.WriteLine(maxnum);
                    Console.WriteLine("Orders left: "+String.Join(" ",q));
                    return;
                }
                else
                {
                    q.Dequeue();
                    quantityOfFood-=order;  
                }
            }
        }
    }
}
